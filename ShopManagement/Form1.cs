using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ShopManagement
{
    public partial class frmShopManagement : Form
    {
        public frmShopManagement()
        {
            InitializeComponent();
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegisterUser RegisterUser = new frmRegisterUser();
            RegisterUser.Show();
            RegisterUser.MdiParent = this;
        }

        private void frmShopManagement_Load(object sender, EventArgs e)
        {

        }

        private void productTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProductType ProductType = new frmProductType();
            ProductType.Show();
            ProductType.MdiParent = this;
        }

        private void productToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmProduct Product = new frmProduct();
            Product.Show();
            Product.MdiParent = this;
        }

        private void sizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSize Size = new frmSize();
            Size.Show();
            Size.MdiParent = this;
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin Login = new frmLogin();
            Login.Show();
            Login.MdiParent = this;
        }
    }
}
