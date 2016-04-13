using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EvanGMapDotNETDemo
{
    public partial class InfoUserControl : UserControl
    {
        private int mIndex = 0;
        private double mLat = 0.0;
        private double mLng = 0.0;

        public InfoUserControl(int index, double lat, double lng)
        {
            InitializeComponent();
            this.mIndex = index;
            this.mLat = lat;
            this.mLng = lng;
            indexLabel.Text = mIndex.ToString();
            latLabel.Text = mLat.ToString();
            lngLabel.Text = mLng.ToString();
        }

        private void InfoUserControl_Load(object sender, EventArgs e)
        {

        }

        public int getIndex()
        {
            return mIndex;
        }

        public void setIndex(int index)
        {
            this.mIndex = index;
            indexLabel.Text = mIndex.ToString();
        }

        public double getLat()
        {
            return mLat;
        }

        public void setLat(double lat)
        {
            this.mLat = lat;
            latLabel.Text = mLat.ToString();
        }

        public double getLng()
        {
            return mLng;
        }

        public void setLng(double lng)
        {
            this.mLng = lng;
            lngLabel.Text = mLng.ToString();
        }
    }
}
