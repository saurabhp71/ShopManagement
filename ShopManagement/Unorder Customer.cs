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
    public partial class frmUnorder_Customer : Form
    {
        public frmUnorder_Customer()
        {
            InitializeComponent();
        }

        private void frmUnorder_Customer_Load(object sender, EventArgs e)
        {
            clsRegister objshop = new clsRegister();
            DataTable dt = new DataTable();
            dt = objshop.Unorder_Customer();
            grdUncustomer.DataSource = dt;
            grdUncustomer.Show();
        }
    }
}
