namespace EvanGMapDotNETDemo
{
    partial class InfoUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.indexLabel = new System.Windows.Forms.Label();
            this.latLabel = new System.Windows.Forms.Label();
            this.lngLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // indexLabel
            // 
            this.indexLabel.AutoSize = true;
            this.indexLabel.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.indexLabel.Location = new System.Drawing.Point(2, 25);
            this.indexLabel.Name = "indexLabel";
            this.indexLabel.Size = new System.Drawing.Size(40, 12);
            this.indexLabel.TabIndex = 0;
            this.indexLabel.Text = "index";
            // 
            // latLabel
            // 
            this.latLabel.AutoSize = true;
            this.latLabel.Location = new System.Drawing.Point(50, 10);
            this.latLabel.Name = "latLabel";
            this.latLabel.Size = new System.Drawing.Size(23, 12);
            this.latLabel.TabIndex = 1;
            this.latLabel.Text = "lat";
            // 
            // lngLabel
            // 
            this.lngLabel.AutoSize = true;
            this.lngLabel.Location = new System.Drawing.Point(50, 30);
            this.lngLabel.Name = "lngLabel";
            this.lngLabel.Size = new System.Drawing.Size(23, 12);
            this.lngLabel.TabIndex = 2;
            this.lngLabel.Text = "lng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "lat:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "lng:";
            // 
            // InfoUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lngLabel);
            this.Controls.Add(this.latLabel);
            this.Controls.Add(this.indexLabel);
            this.Name = "InfoUserControl";
            this.Size = new System.Drawing.Size(225, 60);
            this.Load += new System.EventHandler(this.InfoUserControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label indexLabel;
        private System.Windows.Forms.Label latLabel;
        private System.Windows.Forms.Label lngLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
