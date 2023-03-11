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
    public partial class frmProductType : Form
    {
        public frmProductType()
        {
            InitializeComponent();
        }

        private void btnTSave_Click(object sender, EventArgs e)
        {
            clsShopManagement objShop = new clsShopManagement(txtbxType.Text);
            objShop.SaveType();

            MessageBox.Show("Save Successfull");
        }
    }
}
