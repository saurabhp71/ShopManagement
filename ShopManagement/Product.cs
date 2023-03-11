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
    public partial class frmProduct : Form
    {
        public frmProduct()
        {
            InitializeComponent();
        }

        private void btnPSave_Click(object sender, EventArgs e)
        {
            int TypeID = Convert.ToInt32(cmbbxPType.SelectedValue.ToString());

            clsShopManagement objshop = new clsShopManagement(txtbxProductName.Text, Convert.ToInt32(cmbbxPType.SelectedValue.ToString()));
            objshop.SaveProduct();

            MessageBox.Show("Save Successfully");
        }

        private void frmProduct_Load(object sender, EventArgs e)
        {
            clsShopManagement objshop = new clsShopManagement();
            DataTable dt = new DataTable();
            dt = objshop.GetProductType();
            cmbbxPType.DisplayMember = "Type";
            cmbbxPType.ValueMember = "TypeID";

            cmbbxPType.DataSource = dt;
        }

        private void cmbbxPType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
