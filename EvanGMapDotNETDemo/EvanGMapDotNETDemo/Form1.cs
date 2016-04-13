using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms.ToolTips;

namespace EvanGMapDotNETDemo
{
    public partial class MainForm : Form
    {
        private int index = 0;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

        private void gMapControl_Load(object sender, EventArgs e)
        {
            gMapControl.MapProvider = GMap.NET.MapProviders.GoogleChinaMapProvider.Instance;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerAndCache;
            gMapControl.DragButton = MouseButtons.Left;
            gMapControl.Position = new PointLatLng(22.539961, 113.946795);  //dji skyworth yard center
            gMapControl.MinZoom = 0;
            gMapControl.MaxZoom = 20;
            gMapControl.Zoom = 15;
        }

        private void gMapControl_MouseClick(object sender, MouseEventArgs e)
        {
            GMapOverlay markersOverlay = new GMapOverlay("markers");
            PointLatLng pointLatLng = gMapControl.FromLocalToLatLng(e.X, e.Y);
            GMarkerGoogle marker = new GMarkerGoogle(pointLatLng, GMarkerGoogleType.blue);
            marker.ToolTipMode = MarkerTooltipMode.Always;
            marker.ToolTipText = "index:"+index+"\nlat:"+pointLatLng.Lat+"\nlng:"+pointLatLng.Lng;
            /*
             * Notice:Bug here,must add overlay first,then add marker
             * detail:http://stackoverflow.com/questions/30173888/gmap-net-marker-initially-in-incorrect-position
             */
            gMapControl.Overlays.Add(markersOverlay);
            markersOverlay.Markers.Add(marker);
            //add in infoFlowLayoutPanel
            InfoUserControl infoUserControl = new InfoUserControl(index++, pointLatLng.Lat, pointLatLng.Lng);
            infoFlowLayoutPanel.Controls.Add(infoUserControl);
            infoFlowLayoutPanel.ScrollControlIntoView(infoUserControl);  //scroll to bottom
        }

        private void gMapControl_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void mySerialPort_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {

        }
    }
}
