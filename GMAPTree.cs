using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Waypoint_Path_Generator.Models
{
    public static class GMAPTree
    {

        public static void Update_GMapTree(Waypoint_Path_Gen _wpg, TreeView _tregmap)
        {

            // Add POI Items
            POIPoints pnt;
            Models.Path path;
            Models.Shape shape;
            _tregmap.Nodes.Clear();
            TreeNode tNode;
            tNode = _tregmap.Nodes.Add("Objects");
            _tregmap.Nodes[0].Nodes.Add("POIs");
            _tregmap.Nodes[0].Nodes.Add("Paths");
            _tregmap.Nodes[0].Nodes.Add("Polygons");

            for (int i = 0; i < _wpg.POICount(); i++)
            {
                pnt = _wpg.POIPointAt(i);
                _tregmap.Nodes[0].Nodes[0].Nodes.Add(pnt.name);
                _tregmap.Nodes[0].Nodes[0].Nodes[i].Tag = i;
                _tregmap.Nodes[0].Nodes[0].Nodes[i].Checked = pnt.visible;
            }

            for (int i = 0; i < _wpg.PathCount(); i++)
            {
                path = _wpg.PathAt(i);
                _tregmap.Nodes[0].Nodes[1].Nodes.Add(path.name);
                _tregmap.Nodes[0].Nodes[1].Nodes[i].Tag = i;
                _tregmap.Nodes[0].Nodes[1].Nodes[i].Checked = path.visible;
            }

            for (int i = 0; i < _wpg.ShapeCount(); i++)
            {
                shape = _wpg.ShapeAt(i);
                _tregmap.Nodes[0].Nodes[2].Nodes.Add(shape.name);
                _tregmap.Nodes[0].Nodes[2].Nodes[i].Tag = i;
                _tregmap.Nodes[0].Nodes[2].Nodes[i].Checked = shape.visible;

            }
        }
    }
}
