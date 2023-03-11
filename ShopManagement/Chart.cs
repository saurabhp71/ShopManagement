using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopManagement
{
    public partial class frmChart : Form
    {
        public frmChart()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            this.chart1.Series["Age"].Points.AddXY("max",33);
            this.chart1.Series["Score"].Points.AddXY("max", 25);

            this.chart1.Series["Age"].Points.AddXY("carl", 20);
            this.chart1.Series["Score"].Points.AddXY("carl", 24);

            this.chart1.Series["Age"].Points.AddXY("mark", 45);
            this.chart1.Series["Score"].Points.AddXY("mark", 43);

            this.chart1.Series["Age"].Points.AddXY("ali", 50);
            this.chart1.Series["Score"].Points.AddXY("ali", 55);

            this.chart1.Series["Age"].Points.AddXY("maxi", 40);
            this.chart1.Series["Score"].Points.AddXY("maxi", 47);
        }
    }
}
