namespace ShopManagement
{
    partial class frmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblLType = new System.Windows.Forms.Label();
            this.lblLemailid = new System.Windows.Forms.Label();
            this.lblLPassword = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnLClear = new System.Windows.Forms.Button();
            this.txtbxLPassword = new System.Windows.Forms.TextBox();
            this.txtbxLEmailID = new System.Windows.Forms.TextBox();
            this.cmbbxLType = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblLType
            // 
            this.lblLType.AutoSize = true;
            this.lblLType.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLType.Location = new System.Drawing.Point(133, 57);
            this.lblLType.Name = "lblLType";
            this.lblLType.Size = new System.Drawing.Size(48, 23);
            this.lblLType.TabIndex = 0;
            this.lblLType.Text = "Type";
            // 
            // lblLemailid
            // 
            this.lblLemailid.AutoSize = true;
            this.lblLemailid.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLemailid.Location = new System.Drawing.Point(133, 119);
            this.lblLemailid.Name = "lblLemailid";
            this.lblLemailid.Size = new System.Drawing.Size(70, 23);
            this.lblLemailid.TabIndex = 1;
            this.lblLemailid.Text = "Email ID";
            // 
            // lblLPassword
            // 
            this.lblLPassword.AutoSize = true;
            this.lblLPassword.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLPassword.Location = new System.Drawing.Point(133, 196);
            this.lblLPassword.Name = "lblLPassword";
            this.lblLPassword.Size = new System.Drawing.Size(85, 23);
            this.lblLPassword.TabIndex = 3;
            this.lblLPassword.Text = "Password";
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(137, 274);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(103, 43);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnLClear
            // 
            this.btnLClear.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLClear.Location = new System.Drawing.Point(335, 274);
            this.btnLClear.Name = "btnLClear";
            this.btnLClear.Size = new System.Drawing.Size(103, 43);
            this.btnLClear.TabIndex = 5;
            this.btnLClear.Text = "Clear";
            this.btnLClear.UseVisualStyleBackColor = true;
            // 
            // txtbxLPassword
            // 
            this.txtbxLPassword.Location = new System.Drawing.Point(335, 196);
            this.txtbxLPassword.Name = "txtbxLPassword";
            this.txtbxLPassword.Size = new System.Drawing.Size(173, 20);
            this.txtbxLPassword.TabIndex = 6;
            // 
            // txtbxLEmailID
            // 
            this.txtbxLEmailID.Location = new System.Drawing.Point(335, 119);
            this.txtbxLEmailID.Name = "txtbxLEmailID";
            this.txtbxLEmailID.Size = new System.Drawing.Size(231, 20);
            this.txtbxLEmailID.TabIndex = 7;
            // 
            // cmbbxLType
            // 
            this.cmbbxLType.FormattingEnabled = true;
            this.cmbbxLType.Items.AddRange(new object[] {
            "Admin",
            "Customer"});
            this.cmbbxLType.Location = new System.Drawing.Point(335, 56);
            this.cmbbxLType.Name = "cmbbxLType";
            this.cmbbxLType.Size = new System.Drawing.Size(173, 21);
            this.cmbbxLType.TabIndex = 9;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 371);
            this.Controls.Add(this.cmbbxLType);
            this.Controls.Add(this.txtbxLEmailID);
            this.Controls.Add(this.txtbxLPassword);
            this.Controls.Add(this.btnLClear);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblLPassword);
            this.Controls.Add(this.lblLemailid);
            this.Controls.Add(this.lblLType);
            this.Name = "frmLogin";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLType;
        private System.Windows.Forms.Label lblLemailid;
        private System.Windows.Forms.Label lblLPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnLClear;
        private System.Windows.Forms.TextBox txtbxLPassword;
        private System.Windows.Forms.TextBox txtbxLEmailID;
        private System.Windows.Forms.ComboBox cmbbxLType;
    }
}