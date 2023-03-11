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
    public partial class frmUnorder_Product : Form
    {
        public frmUnorder_Product()
        {
            InitializeComponent();
        }

        private void frmUnorder_Product_Load(object sender, EventArgs e)
        {
            clsRegister objshop = new clsRegister();
            DataTable dt = new DataTable();
            dt = objshop.Unorder_Product();
            grdUnorderProduct.DataSource = dt;
            grdUnorderProduct.Show();
        }
    }
}
