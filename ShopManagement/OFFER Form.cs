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
    public partial class frmOFFER_FORM : Form
    {
        public frmOFFER_FORM(string ProductName, string mrp,string OrderID)
        {
            InitializeComponent();
            lblProduct.Text = ProductName;
            lblPrice.Text = mrp;
            lblOrderID.Text = OrderID;

        }

        private void frmOFFER_FORM_Load(object sender, EventArgs e)
        {

        }

        private void btnCalculatednewprice_Click(object sender, EventArgs e)
        {
            decimal MRP = Convert.ToDecimal(lblPrice.Text);
            decimal Discount = Convert.ToDecimal(txtbxDiscount.Text);

            decimal price = MRP - (MRP * Discount / 100);

            txtbxNewPrice.Text = price.ToString();


        }

        private void btnUpdatedPrice_Click(object sender, EventArgs e)
        {
            int discount = Convert.ToInt32(txtbxDiscount.Text);
            int OrderID = Convert.ToInt32(lblOrderID.Text);
            decimal newPrice = Convert.ToDecimal(txtbxNewPrice.Text);

            clsRegister objshop = new clsRegister(OrderID,discount,newPrice);
            objshop.UpdateNewPrice();

            MessageBox.Show("Update Successfully");
        }
    }
}
