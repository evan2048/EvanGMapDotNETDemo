namespace EvanGMapDotNETDemo
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.gMapControl = new GMap.NET.WindowsForms.GMapControl();
            this.infoFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.mySerialPort = new System.IO.Ports.SerialPort(this.components);
            this.SuspendLayout();
            // 
            // gMapControl
            // 
            this.gMapControl.Bearing = 0F;
            this.gMapControl.CanDragMap = true;
            this.gMapControl.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl.GrayScaleMode = false;
            this.gMapControl.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl.LevelsKeepInMemmory = 5;
            this.gMapControl.Location = new System.Drawing.Point(0, 0);
            this.gMapControl.MarkersEnabled = true;
            this.gMapControl.MaxZoom = 2;
            this.gMapControl.MinZoom = 2;
            this.gMapControl.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapControl.Name = "gMapControl";
            this.gMapControl.NegativeMode = false;
            this.gMapControl.PolygonsEnabled = true;
            this.gMapControl.RetryLoadTile = 0;
            this.gMapControl.RoutesEnabled = true;
            this.gMapControl.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControl.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControl.ShowTileGridLines = false;
            this.gMapControl.Size = new System.Drawing.Size(800, 760);
            this.gMapControl.TabIndex = 0;
            this.gMapControl.Zoom = 0D;
            this.gMapControl.Load += new System.EventHandler(this.gMapControl_Load);
            this.gMapControl.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gMapControl_MouseClick);
            this.gMapControl.MouseUp += new System.Windows.Forms.MouseEventHandler(this.gMapControl_MouseUp);
            // 
            // infoFlowLayoutPanel
            // 
            this.infoFlowLayoutPanel.AutoScroll = true;
            this.infoFlowLayoutPanel.BackColor = System.Drawing.Color.White;
            this.infoFlowLayoutPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.infoFlowLayoutPanel.Location = new System.Drawing.Point(800, 0);
            this.infoFlowLayoutPanel.Name = "infoFlowLayoutPanel";
            this.infoFlowLayoutPanel.Size = new System.Drawing.Size(250, 760);
            this.infoFlowLayoutPanel.TabIndex = 1;
            // 
            // mySerialPort
            // 
            this.mySerialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.mySerialPort_DataReceived);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 757);
            this.Controls.Add(this.infoFlowLayoutPanel);
            this.Controls.Add(this.gMapControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EvanGMapDotNETDemo";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl gMapControl;
        private System.Windows.Forms.FlowLayoutPanel infoFlowLayoutPanel;
        private System.IO.Ports.SerialPort mySerialPort;
    }
}

