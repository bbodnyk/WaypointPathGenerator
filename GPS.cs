using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Waypoint_Path_Generator
{
    public static class GPS
    {

        public static double GPS_Bearing(double d_lat2, double d_lon2, double d_lat1, double d_lon1)
        {
            double lat1 = DegreesToRadians(d_lat1);
            double lon1 = DegreesToRadians(d_lon1);
            double lat2 = DegreesToRadians(d_lat2);
            double lon2 = DegreesToRadians(d_lon2);
            /* BEARING = MOD(ATAN2((COS(lat1)*SIN(lat2))-(SIN(lat1)*COS(lat1)*COS(lon2-lon1)), SIN(lon2-lon1)*COS(lat2)),2*PI()) */

            double bearing = Math.Atan2(Math.Sin(lon2 - lon1) * Math.Cos(lat2), (Math.Cos(lat1) * Math.Sin(lat2)) - (Math.Sin(lat1) * Math.Cos(lat2) * Math.Cos(lon2 - lon1)));
            bearing = RadiansToDegrees(bearing);

            return (bearing + 180.0) % 360;
        }

        public static double GPS_Distance(double d_lat1, double d_lon1, double d_lat2, double d_lon2, double radius)
        {
            double lat1 = DegreesToRadians(d_lat1);
            double lon1 = DegreesToRadians(d_lon1);
            double lat2 = DegreesToRadians(d_lat2);
            double lon2 = DegreesToRadians(d_lon2);

            /* DISTANCE =ACOS(COS(RADIANS(90-Lat1)) *COS(RADIANS(90-Lat2)) +SIN(RADIANS(90-Lat1)) *SIN(RADIANS(90-Lat2)) *COS(RADIANS(Long1-Long2))) *6371 */

            double distance = Math.Acos(Math.Cos(Math.PI / 2 - lat1) * Math.Cos(Math.PI / 2 - lat2)
                + Math.Sin(Math.PI / 2 - lat1) * Math.Sin(Math.PI / 2 - lat2) * Math.Cos(lon1 - lon2)) * radius;

            return distance;
        }

        public static double GPS_Lat_BearDist(double clat, double clon, double bearing, double dist, double radius)
        {
            clat = DegreesToRadians(clat);
            clon = DegreesToRadians(clon);
            bearing = Mod_Angle(bearing);
            bearing = DegreesToRadians(bearing);
            double lat2 = Math.Asin(Math.Sin(clat) * Math.Cos(dist / radius) + Math.Cos(clat) * Math.Sin(dist / radius) * Math.Cos(bearing));
            return RadiansToDegrees(lat2);
        }

        public static double GPS_Lon_BearDist(double clat, double clon, double lat2, double bearing, double dist, double radius)
        {
            clat = DegreesToRadians(clat);
            clon = DegreesToRadians(clon);
            lat2 = DegreesToRadians(lat2);
            bearing = DegreesToRadians(bearing);
            //double lon2 = clon + Math.Atan2(Math.Cos(dist / radius) - Math.Sin(clat) * Math.Sin(lat2), Math.Sin(bearing) * Math.Sin(dist/radius) * Math.Cos(clat));
            double lon2 = clon + Math.Atan2(Math.Sin(bearing) * Math.Sin(dist / radius) * Math.Cos(clat),
                Math.Cos(dist / radius) - Math.Sin(clat) * Math.Sin(lat2));
            return RadiansToDegrees(lon2);
        }

        public static void GPS_Intersection(Form1.WPG_PointVector line1, Form1.WPG_PointVector line2,
            out bool lines_intersect, out bool segments_intersect, out PointF intersection, out PointF close_p1, out PointF close_p2)
        {
            Form1.XYPnt p1 = new Form1.XYPnt();
            Form1.XYPnt p2 = new Form1.XYPnt();
            Form1.XYPnt p3 = new Form1.XYPnt();
            Form1.XYPnt p4 = new Form1.XYPnt();
            p1.x = line1.pnt1.lat;
            p1.y = line1.pnt1.lon;
            p2.x = line1.pnt2.lat;
            p2.y = line1.pnt2.lon;
            p3.x = line2.pnt1.lat;
            p3.y = line2.pnt1.lon;
            p4.x = line2.pnt2.lat;
            p4.y = line2.pnt2.lon;

            // Get the segments' parameters.
            double dx12 = p2.x - p1.x;
            double dy12 = p2.y - p1.y;
            double dx34 = p4.x - p3.x;
            double dy34 = p4.y - p3.y;

            // Solve for t1 and t2
            double denominator = (dy12 * dx34 - dx12 * dy34);

            double t1 =
                ((p1.x - p3.x) * dy34 + (p3.y - p1.y) * dx34)
                    / denominator;

            if (double.IsInfinity(t1))
            {
                // The lines are parallel (or close enough to it).
                lines_intersect = false;
                segments_intersect = false;
                intersection = new PointF(float.NaN, float.NaN);
                close_p1 = new PointF(float.NaN, float.NaN);
                close_p2 = new PointF(float.NaN, float.NaN);
                return;
            }
            lines_intersect = true;

            double t2 = ((p3.x - p1.x) * dy12 + (p1.y - p3.y) * dx12) / -denominator;

            // Find the point of intersection.
            intersection = new PointF((float)(p1.x + dx12 * t1), (float)(p1.y + dy12 * t1));

            // The segments intersect if t1 and t2 are between 0 and 1.
            segments_intersect =
                ((t1 >= 0) && (t1 <= 1) &&
                 (t2 >= 0) && (t2 <= 1));

            // Find the closest points on the segments.
            if (t1 < 0)
            {
                t1 = 0;
            }
            else if (t1 > 1)
            {
                t1 = 1;
            }

            if (t2 < 0)
            {
                t2 = 0;
            }
            else if (t2 > 1)
            {
                t2 = 1;
            }

            float x = (float)(p1.x + dx12 * t1);
            float y = (float)(p1.y + dy12 * t1);
            close_p1 = new PointF(x, y);
            x = (float)(p3.x + dx34 * t2);
            y = (float)(p3.y + dy34 * t2);
            close_p2 = new PointF(x, y);
            return;
        }



        public static double RadiansToDegrees(double radians)
        {
            return radians * (180.0 / Math.PI);
        }

        public static double DegreesToRadians(double degrees)
        {
            return degrees / (180.0 / Math.PI);
        }

        public static double Modulus(double val1, double val2)
        {
            int i = Convert.ToInt16(val1 / val2);
            return val1 - (i * val2);
        }

        public static double Mod_Angle(double ang)
        {
            if (ang >= 0.0 & ang <= 360) return ang;
            if (ang > 360.0)
            {
                do
                {
                    ang = ang - 360.0;
                } while (ang > 360.0);
                return ang;
            }
            if (ang < 0.0)
            {
                do
                {
                    ang = ang + 360;
                } while (ang < 0);
                return ang;
            }
            return ang;
        }

        public static double MetersToFeet(double meters)
        {
            double conversion = 3.280839;
            return (meters * conversion);
        }

        public static double FeetToMeters(double feet)
        {
            double conversion = 3.280839;
            return (feet / conversion);
        }
    }
}
