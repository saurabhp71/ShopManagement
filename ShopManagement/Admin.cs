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
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
        }

        private void orderProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOrder_Products orderproduct = new frmOrder_Products();
            orderproduct.Show();
            orderproduct.MdiParent = this;
        }

        private void allProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAll_Products allproducts = new frmAll_Products();
            allproducts.Show();
            allproducts.MdiParent = this;
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUnorder_Product objshop = new frmUnorder_Product();
            objshop.Show();
            objshop.MdiParent = this;
        }

        private void unOrderCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUnorder_Customer objshop = new frmUnorder_Customer();
            objshop.Show();
            objshop.MdiParent = this;
        }
    }
}
