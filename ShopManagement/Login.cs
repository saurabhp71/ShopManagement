using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopManagement
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string Type = cmbbxLType.SelectedItem.ToString();
            string EmailID = txtbxLEmailID.Text;
            string password = txtbxLPassword.Text;

            clsRegister objlogin = new clsRegister(Type, EmailID, password);
            SqlDataReader dr;
            dr = objlogin.Login();
            while (dr.Read())
            {
                int orderid = Convert.ToInt32(dr["UserTypeID"].ToString());
                string name = dr["Name"].ToString();
                string emailid = dr["EmailID"].ToString();
                string contact = dr["Contact"].ToString();


                if(cmbbxLType.Text.ToString() == "Admin")
                {
                    frmAdmin admin = new frmAdmin();
                    MessageBox.Show("Login Successfully");
                    admin.Show();
                }

               else if (cmbbxLType.Text.ToString() == "Customer")
                {
                    frmOrder order = new frmOrder(orderid,name, emailid, contact);
                    MessageBox.Show("Login Successfully");
                    order.Show();
                }
                else
                {
                    MessageBox.Show("Login Failed");
                }
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
         
        }
    }
}
