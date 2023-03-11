using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopManagement
{
    public partial class frmOrder : Form
    {
        public int UserID = 0;
        public frmOrder()
        {
            InitializeComponent();
        }
        public frmOrder(int uid ,string Name, string EmailID, String Contact)
        {
            InitializeComponent();
            UserID = uid;
            lblOName.Text = Name;
            lblOEmailid.Text = EmailID;
            lblOContact.Text = Contact;
        }

        private void frmOrder_Load(object sender, EventArgs e)
        {
            clsRegister objshop = new clsRegister();
            DataTable dt = new DataTable();
            dt = objshop.GetOrderType();
            cmbbxOtype.DisplayMember = "Type";
            cmbbxOtype.ValueMember = "TypeID";
            cmbbxOtype.DataSource = dt;

        }

        private void cmbbxOtype_SelectedIndexChanged(object sender, EventArgs e)
        {
            int TypeID = Convert.ToInt32(cmbbxOtype.SelectedValue.ToString());

            clsRegister objshop = new clsRegister(TypeID);
            DataTable dt = new DataTable();
            dt = objshop.GetOrderProduct();
            cmbbxOProduct.DisplayMember = "ProductName";
            cmbbxOProduct.ValueMember = "ProductID";

            cmbbxOProduct.DataSource = dt;
        }

        private void cmbbxOProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            int TypeID = Convert.ToInt32(cmbbxOtype.SelectedValue.ToString());

            clsRegister objshop = new clsRegister(TypeID);
            DataTable dt = new DataTable();
            dt = objshop.GetSizeShow();
            GrdSizeshow.DataSource = dt;
            GrdSizeshow.Show();
        }

        private void GrdSizeshow_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int sizeid = Convert.ToInt32(GrdSizeshow.Rows[GrdSizeshow.CurrentRow.Index].Cells[0].Value.ToString());
            string size = GrdSizeshow.Rows[GrdSizeshow.CurrentRow.Index].Cells[1].Value.ToString();

            clsRegister objshop = new clsRegister(size,sizeid);
            SqlDataReader dr;
            dr = objshop.MRPShow();
            while (dr.Read())
            {
                txtbxOPrice.Text = dr["MRP"].ToString();
            }
        }

        private void btnAddtocart_Click(object sender, EventArgs e)
        {
            string type = cmbbxOtype.Text.ToString();
            string product = cmbbxOProduct.Text.ToString();
            string size = GrdSizeshow.Rows[GrdSizeshow.CurrentRow.Index].Cells[1].Value.ToString();
            string sizeId = GrdSizeshow.Rows[GrdSizeshow.CurrentRow.Index].Cells[0].Value.ToString();
            string price = txtbxOPrice.Text;


            ListViewItem list = new ListViewItem();
            list.Text = type;
            list.SubItems.Add(product);
            list.SubItems.Add(size);
            list.SubItems.Add(price);
            list.SubItems.Add(sizeId);
           listview.Items.Add(list);
        }

        private void btnRemovetocart_Click(object sender, EventArgs e)
        {
            for(int i = listview.Items.Count - 1; i >= 0; i--)
            {
                if (listview.Items[i].Selected)
                {
                    listview.Items[i].Remove();
                }
            }
        }

        private void listview_ColumnClick(object sender, ColumnClickEventArgs e)
        {

        }

        private void btntotal_Click(object sender, EventArgs e)
        {
            decimal sum = 0;
            foreach (ListViewItem item in listview.Items)
            {
                sum += decimal.Parse(item.SubItems[3].Text);
            }
            txtbxTotalPrice.Text = Convert.ToString(sum);
        }

        private void btnorderconformed_Click(object sender, EventArgs e)
        {
            DateTime Orderdate = DateTime.Now;
            DateTime Odate = (Orderdate);
            string orderstatus = "confirmed";
            int discount = 0;
            int newprice = 0;
            bool isdelete = false;

            for(int i = 0; i < listview.Items.Count; i++)
            {
                int sizeid = Convert.ToInt32(listview.Items[i].SubItems[4].Text);
                clsRegister obj = new clsRegister(UserID,sizeid,Orderdate,orderstatus,discount,newprice,isdelete);
                obj.OrderConfirmed();

            }
            MessageBox.Show("Confirmed Success");
        }

        private void GrdSizeshow_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            frmChart obj = new frmChart();
            obj.Show();
        }
    }
}
