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
    public partial class frmSize : Form
    {
        public frmSize()
        {
            InitializeComponent();
        }

        private void frmSize_Load(object sender, EventArgs e)
        {
            clsShopManagement objshop = new clsShopManagement();
            DataTable dt = new DataTable();
            dt = objshop.GetSizeType();
            cmbbxSType.DisplayMember = "Type";
            cmbbxSType.ValueMember = "TypeID";

            cmbbxSType.DataSource = dt;

        }

        private void cmbbxSType_SelectedIndexChanged(object sender, EventArgs e)
        {
            int TypeID = Convert.ToInt32(cmbbxSType.SelectedValue.ToString());


            clsShopManagement objshop = new clsShopManagement(TypeID);
            DataTable dt = new DataTable();
            dt = objshop.GetSizeProduct();
            cmbbxProductName.DisplayMember = "ProductName";
            cmbbxProductName.ValueMember = "ProductID";

            cmbbxProductName.DataSource = dt;

        }

        private void btnSSave_Click(object sender, EventArgs e)
        {
            int TypeID = Convert.ToInt32(cmbbxSType.SelectedValue.ToString());
            int ProductID = Convert.ToInt32(cmbbxProductName.SelectedValue.ToString());
            decimal MRP = Convert.ToDecimal(txtbxMRP.Text.ToString());
            decimal RealPrice = Convert.ToDecimal(txtbxRealPrice.Text.ToString());

            clsShopManagement objshop = new clsShopManagement(txtbxSize.Text,MRP,RealPrice , TypeID,ProductID);
            objshop.SaveSize();

            MessageBox.Show("Save Successfully");
        }

        private void cmbbxProductName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    
}
