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
    public partial class frmOrder_Products : Form
    {
        public frmOrder_Products()
        {
            InitializeComponent();
        }

        private void txtbxsearchProducts_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmOrder_Products_Load(object sender, EventArgs e)
        {
            clsRegister objshop = new clsRegister();
            DataTable dt = new DataTable();
            dt = objshop.GetAllProduct();
            grdAllInformation.DataSource = dt;
            grdAllInformation.Show();

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            clsRegister objshop = new clsRegister();
            DataTable dt = new DataTable();
            dt = objshop.GetAllProduct();
            grdAllInformation.DataSource = dt;
            grdAllInformation.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string name = txtbxSearchName.Text;
            string productname = txtbxsearchProducts.Text;

            clsRegister objshop = new clsRegister(name,productname);
            DataTable dt = new DataTable();
            dt = objshop.Search();
            grdAllInformation.DataSource = dt;
            grdAllInformation.Show();
        }

        private void grdAllInformation_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            string product = grdAllInformation.Rows[grdAllInformation.CurrentRow.Index].Cells[7].Value.ToString();
            string mrp = grdAllInformation.Rows[grdAllInformation.CurrentRow.Index].Cells[9].Value.ToString();
            string orderid = grdAllInformation.Rows[grdAllInformation.CurrentRow.Index].Cells[2].Value.ToString();

            if(e.ColumnIndex == 1)
            {
                frmOFFER_FORM offer = new frmOFFER_FORM(product, mrp, orderid);
                offer.Show();
            }
        }

        private void btnDetete_Click(object sender, EventArgs e)
        {
            int i = 0;
            foreach(DataGridViewRow row in grdAllInformation.Rows)
            {
                if (Convert.ToBoolean(row.Cells[0].Value))
                {
                    int orderid = Convert.ToInt32(row.Cells[2].Value);
                    clsRegister objshop = new clsRegister(orderid);
                    objshop.ISDeleted();
                    grdAllInformation.Rows.Remove(row);
                    i++;    
                }
            }
        }
    }
}
