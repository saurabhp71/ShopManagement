namespace ShopManagement
{
    partial class frmOrder
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
            this.lblorderform = new System.Windows.Forms.Label();
            this.lblOType = new System.Windows.Forms.Label();
            this.lblOProduct = new System.Windows.Forms.Label();
            this.lblOPrice = new System.Windows.Forms.Label();
            this.GrdSizeshow = new System.Windows.Forms.DataGridView();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnOclear = new System.Windows.Forms.Button();
            this.btnAddtocart = new System.Windows.Forms.Button();
            this.btnRemovetocart = new System.Windows.Forms.Button();
            this.txtbxOPrice = new System.Windows.Forms.TextBox();
            this.cmbbxOtype = new System.Windows.Forms.ComboBox();
            this.cmbbxOProduct = new System.Windows.Forms.ComboBox();
            this.lblname = new System.Windows.Forms.Label();
            this.lblemailid = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtbxTotalPrice = new System.Windows.Forms.TextBox();
            this.btntotal = new System.Windows.Forms.Button();
            this.btnorderconformed = new System.Windows.Forms.Button();
            this.Producttype = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Product = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Size = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SizeID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listview = new System.Windows.Forms.ListView();
            this.lblOName = new System.Windows.Forms.Label();
            this.lblOEmailid = new System.Windows.Forms.Label();
            this.lblOContact = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblOID = new System.Windows.Forms.Label();
            this.btnOpen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GrdSizeshow)).BeginInit();
            this.SuspendLayout();
            // 
            // lblorderform
            // 
            this.lblorderform.AutoSize = true;
            this.lblorderform.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblorderform.Location = new System.Drawing.Point(473, 9);
            this.lblorderform.Name = "lblorderform";
            this.lblorderform.Size = new System.Drawing.Size(104, 25);
            this.lblorderform.TabIndex = 0;
            this.lblorderform.Text = "OrderForm";
            // 
            // lblOType
            // 
            this.lblOType.AutoSize = true;
            this.lblOType.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOType.Location = new System.Drawing.Point(43, 71);
            this.lblOType.Name = "lblOType";
            this.lblOType.Size = new System.Drawing.Size(112, 23);
            this.lblOType.TabIndex = 1;
            this.lblOType.Text = "Product Type";
            // 
            // lblOProduct
            // 
            this.lblOProduct.AutoSize = true;
            this.lblOProduct.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOProduct.Location = new System.Drawing.Point(43, 119);
            this.lblOProduct.Name = "lblOProduct";
            this.lblOProduct.Size = new System.Drawing.Size(70, 23);
            this.lblOProduct.TabIndex = 2;
            this.lblOProduct.Text = "Product";
            // 
            // lblOPrice
            // 
            this.lblOPrice.AutoSize = true;
            this.lblOPrice.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOPrice.Location = new System.Drawing.Point(43, 362);
            this.lblOPrice.Name = "lblOPrice";
            this.lblOPrice.Size = new System.Drawing.Size(48, 23);
            this.lblOPrice.TabIndex = 3;
            this.lblOPrice.Text = "Price";
            // 
            // GrdSizeshow
            // 
            this.GrdSizeshow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdSizeshow.Location = new System.Drawing.Point(57, 172);
            this.GrdSizeshow.Name = "GrdSizeshow";
            this.GrdSizeshow.Size = new System.Drawing.Size(272, 150);
            this.GrdSizeshow.TabIndex = 4;
            this.GrdSizeshow.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdSizeshow_CellClick);
            this.GrdSizeshow.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdSizeshow_CellContentClick);
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(37, 428);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(87, 40);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // btnOclear
            // 
            this.btnOclear.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOclear.Location = new System.Drawing.Point(222, 428);
            this.btnOclear.Name = "btnOclear";
            this.btnOclear.Size = new System.Drawing.Size(87, 40);
            this.btnOclear.TabIndex = 6;
            this.btnOclear.Text = "Clear";
            this.btnOclear.UseVisualStyleBackColor = true;
            // 
            // btnAddtocart
            // 
            this.btnAddtocart.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddtocart.Location = new System.Drawing.Point(369, 196);
            this.btnAddtocart.Name = "btnAddtocart";
            this.btnAddtocart.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAddtocart.Size = new System.Drawing.Size(106, 39);
            this.btnAddtocart.TabIndex = 7;
            this.btnAddtocart.Text = "Add to Cart";
            this.btnAddtocart.UseVisualStyleBackColor = true;
            this.btnAddtocart.Click += new System.EventHandler(this.btnAddtocart_Click);
            // 
            // btnRemovetocart
            // 
            this.btnRemovetocart.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemovetocart.Location = new System.Drawing.Point(355, 284);
            this.btnRemovetocart.Name = "btnRemovetocart";
            this.btnRemovetocart.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnRemovetocart.Size = new System.Drawing.Size(120, 57);
            this.btnRemovetocart.TabIndex = 8;
            this.btnRemovetocart.Text = "Remove to Cart";
            this.btnRemovetocart.UseVisualStyleBackColor = true;
            this.btnRemovetocart.Click += new System.EventHandler(this.btnRemovetocart_Click);
            // 
            // txtbxOPrice
            // 
            this.txtbxOPrice.Location = new System.Drawing.Point(110, 367);
            this.txtbxOPrice.Name = "txtbxOPrice";
            this.txtbxOPrice.Size = new System.Drawing.Size(144, 20);
            this.txtbxOPrice.TabIndex = 9;
            // 
            // cmbbxOtype
            // 
            this.cmbbxOtype.FormattingEnabled = true;
            this.cmbbxOtype.Location = new System.Drawing.Point(183, 73);
            this.cmbbxOtype.Name = "cmbbxOtype";
            this.cmbbxOtype.Size = new System.Drawing.Size(146, 21);
            this.cmbbxOtype.TabIndex = 10;
            this.cmbbxOtype.SelectedIndexChanged += new System.EventHandler(this.cmbbxOtype_SelectedIndexChanged);
            // 
            // cmbbxOProduct
            // 
            this.cmbbxOProduct.FormattingEnabled = true;
            this.cmbbxOProduct.Location = new System.Drawing.Point(183, 124);
            this.cmbbxOProduct.Name = "cmbbxOProduct";
            this.cmbbxOProduct.Size = new System.Drawing.Size(146, 21);
            this.cmbbxOProduct.TabIndex = 11;
            this.cmbbxOProduct.SelectedIndexChanged += new System.EventHandler(this.cmbbxOProduct_SelectedIndexChanged);
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(626, 73);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(58, 23);
            this.lblname.TabIndex = 12;
            this.lblname.Text = "Name:";
            // 
            // lblemailid
            // 
            this.lblemailid.AutoSize = true;
            this.lblemailid.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemailid.Location = new System.Drawing.Point(619, 124);
            this.lblemailid.Name = "lblemailid";
            this.lblemailid.Size = new System.Drawing.Size(71, 23);
            this.lblemailid.TabIndex = 13;
            this.lblemailid.Text = "EmailID:";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(626, 172);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(64, 23);
            this.lblPhone.TabIndex = 14;
            this.lblPhone.Text = "Phone:";
            // 
            // txtbxTotalPrice
            // 
            this.txtbxTotalPrice.Location = new System.Drawing.Point(755, 408);
            this.txtbxTotalPrice.Name = "txtbxTotalPrice";
            this.txtbxTotalPrice.Size = new System.Drawing.Size(139, 20);
            this.txtbxTotalPrice.TabIndex = 18;
            // 
            // btntotal
            // 
            this.btntotal.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntotal.Location = new System.Drawing.Point(609, 408);
            this.btntotal.Name = "btntotal";
            this.btntotal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btntotal.Size = new System.Drawing.Size(81, 28);
            this.btntotal.TabIndex = 20;
            this.btntotal.Text = "Total";
            this.btntotal.UseVisualStyleBackColor = true;
            this.btntotal.Click += new System.EventHandler(this.btntotal_Click);
            // 
            // btnorderconformed
            // 
            this.btnorderconformed.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnorderconformed.Location = new System.Drawing.Point(934, 456);
            this.btnorderconformed.Name = "btnorderconformed";
            this.btnorderconformed.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnorderconformed.Size = new System.Drawing.Size(145, 28);
            this.btnorderconformed.TabIndex = 21;
            this.btnorderconformed.Text = "Order Conformed";
            this.btnorderconformed.UseVisualStyleBackColor = true;
            this.btnorderconformed.Click += new System.EventHandler(this.btnorderconformed_Click);
            // 
            // Producttype
            // 
            this.Producttype.Text = "Product Type";
            this.Producttype.Width = 119;
            // 
            // Product
            // 
            this.Product.Text = "Product";
            this.Product.Width = 101;
            // 
            // Size
            // 
            this.Size.Text = "Size";
            this.Size.Width = 74;
            // 
            // Price
            // 
            this.Price.Text = "Price";
            this.Price.Width = 94;
            // 
            // SizeID
            // 
            this.SizeID.Text = "SizeID";
            // 
            // listview
            // 
            this.listview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Producttype,
            this.Product,
            this.Size,
            this.Price,
            this.SizeID});
            this.listview.HideSelection = false;
            this.listview.Location = new System.Drawing.Point(609, 214);
            this.listview.Name = "listview";
            this.listview.Size = new System.Drawing.Size(450, 173);
            this.listview.TabIndex = 22;
            this.listview.UseCompatibleStateImageBehavior = false;
            this.listview.View = System.Windows.Forms.View.Details;
            this.listview.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listview_ColumnClick);
            // 
            // lblOName
            // 
            this.lblOName.AutoSize = true;
            this.lblOName.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOName.Location = new System.Drawing.Point(733, 73);
            this.lblOName.Name = "lblOName";
            this.lblOName.Size = new System.Drawing.Size(53, 23);
            this.lblOName.TabIndex = 23;
            this.lblOName.Text = "Name";
            // 
            // lblOEmailid
            // 
            this.lblOEmailid.AutoSize = true;
            this.lblOEmailid.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOEmailid.Location = new System.Drawing.Point(720, 124);
            this.lblOEmailid.Name = "lblOEmailid";
            this.lblOEmailid.Size = new System.Drawing.Size(66, 23);
            this.lblOEmailid.TabIndex = 24;
            this.lblOEmailid.Text = "EmailID";
            // 
            // lblOContact
            // 
            this.lblOContact.AutoSize = true;
            this.lblOContact.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOContact.Location = new System.Drawing.Point(720, 172);
            this.lblOContact.Name = "lblOContact";
            this.lblOContact.Size = new System.Drawing.Size(59, 23);
            this.lblOContact.TabIndex = 25;
            this.lblOContact.Text = "Phone";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(626, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 23);
            this.label1.TabIndex = 26;
            this.label1.Text = "ID:";
            // 
            // lblOID
            // 
            this.lblOID.AutoSize = true;
            this.lblOID.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOID.Location = new System.Drawing.Point(733, 23);
            this.lblOID.Name = "lblOID";
            this.lblOID.Size = new System.Drawing.Size(30, 23);
            this.lblOID.TabIndex = 27;
            this.lblOID.Text = "ID:";
            // 
            // btnOpen
            // 
            this.btnOpen.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpen.Location = new System.Drawing.Point(461, 417);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(87, 40);
            this.btnOpen.TabIndex = 28;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // frmOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 531);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.lblOID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblOContact);
            this.Controls.Add(this.lblOEmailid);
            this.Controls.Add(this.lblOName);
            this.Controls.Add(this.listview);
            this.Controls.Add(this.btnorderconformed);
            this.Controls.Add(this.btntotal);
            this.Controls.Add(this.txtbxTotalPrice);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblemailid);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.cmbbxOProduct);
            this.Controls.Add(this.cmbbxOtype);
            this.Controls.Add(this.txtbxOPrice);
            this.Controls.Add(this.btnRemovetocart);
            this.Controls.Add(this.btnAddtocart);
            this.Controls.Add(this.btnOclear);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.GrdSizeshow);
            this.Controls.Add(this.lblOPrice);
            this.Controls.Add(this.lblOProduct);
            this.Controls.Add(this.lblOType);
            this.Controls.Add(this.lblorderform);
            this.Name = "frmOrder";
            this.Text = "Order";
            this.Load += new System.EventHandler(this.frmOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrdSizeshow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblorderform;
        private System.Windows.Forms.Label lblOType;
        private System.Windows.Forms.Label lblOProduct;
        private System.Windows.Forms.Label lblOPrice;
        private System.Windows.Forms.DataGridView GrdSizeshow;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnOclear;
        private System.Windows.Forms.Button btnAddtocart;
        private System.Windows.Forms.Button btnRemovetocart;
        private System.Windows.Forms.TextBox txtbxOPrice;
        private System.Windows.Forms.ComboBox cmbbxOtype;
        private System.Windows.Forms.ComboBox cmbbxOProduct;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblemailid;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtbxTotalPrice;
        private System.Windows.Forms.Button btntotal;
        private System.Windows.Forms.Button btnorderconformed;
        private System.Windows.Forms.ColumnHeader Producttype;
        private System.Windows.Forms.ColumnHeader Product;
        private System.Windows.Forms.ColumnHeader Size;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.ColumnHeader SizeID;
        private System.Windows.Forms.ListView listview;
        private System.Windows.Forms.Label lblOName;
        private System.Windows.Forms.Label lblOEmailid;
        private System.Windows.Forms.Label lblOContact;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblOID;
        private System.Windows.Forms.Button btnOpen;
    }
}