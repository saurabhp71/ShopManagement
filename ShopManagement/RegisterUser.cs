using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace ShopManagement
{
    public partial class frmRegisterUser : Form
    {
        public frmRegisterUser()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (cmbbxRType.Text == " ")
            {
                MessageBox.Show("You must select a conversion type");
                ErrorRegister.SetError(this.cmbbxRType, "You must select a conversion type");
                return;
            }
            if (txtbxRname.Text == "")
            {
                MessageBox.Show("Please Enter your Name");
                ErrorRegister.SetError(this.txtbxRname, "plzzz provide valid Name");
                return;
            }
            if (txtbxREmailID.Text == "")
            {
                MessageBox.Show("Please Enter your EmailID");
                ErrorRegister.SetError(this.txtbxREmailID, "plzzz provide valid EmailID");
                return;
            }
            if (txtbxRContact.Text == "")
            {
                MessageBox.Show("Please Enter your Contact");
                ErrorRegister.SetError(this.txtbxREmailID, "plzzz provide valid Contact");
                return;
            }
            if (rdbbtnMale.Checked && rdbbtnFemale.Checked)
            {
                MessageBox.Show("Please Select your Gender");
                ErrorRegister.SetError(this.lblGender, "plzzz provide valid Gender");
                return;
            }
            if (txtbxRState.Text == "")
            {
                MessageBox.Show("Please Enter your State");
                ErrorRegister.SetError(this.txtbxRState, "plzzz provide valid State");
                return;
            }
            if (txtbxRPassword.Text == "")
            {
                MessageBox.Show("Please Enter your Password");
                ErrorRegister.SetError(this.txtbxRPassword, "plzzz provide valid Password");
                return;
            }



            string Typename = cmbbxRType.SelectedItem.ToString();
            string Gender = "";
            if(rdbbtnMale.Checked)
            {
                Gender = rdbbtnMale.Text;
            }
            else
            {
                Gender = rdbbtnFemale.Text;
            }

            Int64 Contact = Convert.ToInt64(txtbxRContact.Text);


            clsRegister objregi = new clsRegister(txtbxRname.Text,txtbxREmailID.Text,txtbxRState.Text,txtbxRPassword.Text, Typename, Gender,Contact);
            objregi.SaveRegister();


            MessageBox.Show("Save Successfully");
        }

        private void txtbxRContact_TextChanged(object sender, EventArgs e)
        {
            string pattern = @"^[0-9]{10}$";

            if (Regex.IsMatch(txtbxRContact.Text, pattern))
            {
                ErrorRegister.Clear();
            }
            else
            {
                ErrorRegister.SetError(this.txtbxRContact, "plzzz provide valid Contact");
                return;
            }
        }

        private void frmRegisterUser_Load(object sender, EventArgs e)
        {

        }

        private void cmbbxRType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmbbxRType.SelectedText))
            {
                ErrorRegister.Clear();
            }
            else
            {
                ErrorRegister.SetError(this.cmbbxRType, "You must select a conversion type");
                return;
            }
        }

        private void txtbxRname_TextChanged(object sender, EventArgs e)
        {
            string pattern = "^[a-zA-Z ]*$";

            if (Regex.IsMatch(txtbxRname.Text, pattern))
            {
                ErrorRegister.Clear();
            }
            else
            {
                ErrorRegister.SetError(this.txtbxRname, "plzzz provide valid Name");
                return;
            }
        }

        private void txtbxREmailID_TextChanged(object sender, EventArgs e)
        {
            string pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA]\\.)+[a-zA-Z]{2,9})$";

            if (Regex.IsMatch(txtbxREmailID.Text,pattern))
            {
                ErrorRegister.Clear();
            }
            else
            {
                ErrorRegister.SetError(this.txtbxREmailID, "plzzz provide valid Mail address");
                return;
            }
        }

        private void txtbxRState_TextChanged(object sender, EventArgs e)
        {
            string pattern = "^[a-zA-Z ]*$";

            if (Regex.IsMatch(txtbxRState.Text, pattern))
            {
                ErrorRegister.Clear();
            }
            else
            {
                ErrorRegister.SetError(this.txtbxRState, "plzzz provide valid State");
                return;
            }
        }

        private void lblGender_Click(object sender, EventArgs e)
        {
            if (rdbbtnMale.Checked && rdbbtnFemale.Checked)
            {
                ErrorRegister.Clear();
            }
            else
            {
                ErrorRegister.SetError(this.lblGender, "Plz select Gender");
                return;
            }
        }

        private void txtbxRPassword_TextChanged(object sender, EventArgs e)
        {
            string pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*[!@#$%^&*])";

            if (Regex.IsMatch(txtbxRPassword.Text, pattern))
            {
                ErrorRegister.Clear();
            }
            else
            {
                ErrorRegister.SetError(this.txtbxRPassword, "plzzz provide valid Password");
                return;
            }
        }

        private void btnRClear_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
