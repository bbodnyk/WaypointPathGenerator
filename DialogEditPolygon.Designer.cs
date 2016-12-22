namespace Waypoint_Path_Generator
{
    partial class DialogEditPolygon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtPolyName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAcceptChange = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPolyName
            // 
            this.txtPolyName.Location = new System.Drawing.Point(117, 25);
            this.txtPolyName.Name = "txtPolyName";
            this.txtPolyName.Size = new System.Drawing.Size(163, 20);
            this.txtPolyName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Polygon Name";
            // 
            // btnAcceptChange
            // 
            this.btnAcceptChange.Location = new System.Drawing.Point(21, 237);
            this.btnAcceptChange.Name = "btnAcceptChange";
            this.btnAcceptChange.Size = new System.Drawing.Size(136, 23);
            this.btnAcceptChange.TabIndex = 2;
            this.btnAcceptChange.Text = "Accept Change";
            this.btnAcceptChange.UseVisualStyleBackColor = true;
            this.btnAcceptChange.Click += new System.EventHandler(this.btnAcceptChange_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(188, 237);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // DialogEditPolygon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 272);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAcceptChange);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPolyName);
            this.Name = "DialogEditPolygon";
            this.Text = "Edit Polygon";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPolyName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAcceptChange;
        private System.Windows.Forms.Button btnCancel;
    }
}