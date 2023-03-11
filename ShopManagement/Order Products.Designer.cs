namespace ShopManagement
{
    partial class frmOrder_Products
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
            this.components = new System.ComponentModel.Container();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lblorderproductinformation = new System.Windows.Forms.Label();
            this.lblsearchname = new System.Windows.Forms.Label();
            this.lblsearchproduct = new System.Windows.Forms.Label();
            this.txtbxSearchName = new System.Windows.Forms.TextBox();
            this.txtbxsearchProducts = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnDetete = new System.Windows.Forms.Button();
            this.grdAllInformation = new System.Windows.Forms.DataGridView();
            this.Select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Discount = new System.Windows.Forms.DataGridViewButtonColumn();
            this.programBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.grdAllInformation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblorderproductinformation
            // 
            this.lblorderproductinformation.AutoSize = true;
            this.lblorderproductinformation.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblorderproductinformation.Location = new System.Drawing.Point(33, 9);
            this.lblorderproductinformation.Name = "lblorderproductinformation";
            this.lblorderproductinformation.Size = new System.Drawing.Size(295, 31);
            this.lblorderproductinformation.TabIndex = 1;
            this.lblorderproductinformation.Text = "Order Product Information";
            // 
            // lblsearchname
            // 
            this.lblsearchname.AutoSize = true;
            this.lblsearchname.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsearchname.Location = new System.Drawing.Point(88, 315);
            this.lblsearchname.Name = "lblsearchname";
            this.lblsearchname.Size = new System.Drawing.Size(149, 25);
            this.lblsearchname.TabIndex = 2;
            this.lblsearchname.Text = "Search by Name";
            // 
            // lblsearchproduct
            // 
            this.lblsearchproduct.AutoSize = true;
            this.lblsearchproduct.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsearchproduct.Location = new System.Drawing.Point(88, 360);
            this.lblsearchproduct.Name = "lblsearchproduct";
            this.lblsearchproduct.Size = new System.Drawing.Size(169, 25);
            this.lblsearchproduct.TabIndex = 3;
            this.lblsearchproduct.Text = "Search by Product";
            // 
            // txtbxSearchName
            // 
            this.txtbxSearchName.Location = new System.Drawing.Point(279, 320);
            this.txtbxSearchName.Name = "txtbxSearchName";
            this.txtbxSearchName.Size = new System.Drawing.Size(205, 20);
            this.txtbxSearchName.TabIndex = 4;
            // 
            // txtbxsearchProducts
            // 
            this.txtbxsearchProducts.Location = new System.Drawing.Point(279, 366);
            this.txtbxsearchProducts.Name = "txtbxsearchProducts";
            this.txtbxsearchProducts.Size = new System.Drawing.Size(205, 20);
            this.txtbxsearchProducts.TabIndex = 5;
            this.txtbxsearchProducts.TextChanged += new System.EventHandler(this.txtbxsearchProducts_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(290, 426);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(114, 38);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(434, 426);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(114, 38);
            this.btnRefresh.TabIndex = 7;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnDetete
            // 
            this.btnDetete.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetete.Location = new System.Drawing.Point(585, 426);
            this.btnDetete.Name = "btnDetete";
            this.btnDetete.Size = new System.Drawing.Size(114, 38);
            this.btnDetete.TabIndex = 8;
            this.btnDetete.Text = "Delete";
            this.btnDetete.UseVisualStyleBackColor = true;
            this.btnDetete.Click += new System.EventHandler(this.btnDetete_Click);
            // 
            // grdAllInformation
            // 
            this.grdAllInformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdAllInformation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Select,
            this.Discount});
            this.grdAllInformation.Location = new System.Drawing.Point(39, 58);
            this.grdAllInformation.Name = "grdAllInformation";
            this.grdAllInformation.Size = new System.Drawing.Size(1026, 237);
            this.grdAllInformation.TabIndex = 9;
            this.grdAllInformation.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdAllInformation_CellContentClick_1);
            // 
            // Select
            // 
            this.Select.Frozen = true;
            this.Select.HeaderText = "Select";
            this.Select.Name = "Select";
            this.Select.ToolTipText = "Select";
            this.Select.Width = 50;
            // 
            // Discount
            // 
            this.Discount.Frozen = true;
            this.Discount.HeaderText = "Discount";
            this.Discount.Name = "Discount";
            this.Discount.Text = "Discount";
            this.Discount.UseColumnTextForButtonValue = true;
            // 
            // programBindingSource
            // 
            this.programBindingSource.DataSource = typeof(ShopManagement.Program);
            // 
            // frmOrder_Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 494);
            this.Controls.Add(this.grdAllInformation);
            this.Controls.Add(this.btnDetete);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtbxsearchProducts);
            this.Controls.Add(this.txtbxSearchName);
            this.Controls.Add(this.lblsearchproduct);
            this.Controls.Add(this.lblsearchname);
            this.Controls.Add(this.lblorderproductinformation);
            this.Name = "frmOrder_Products";
            this.Text = "Order_Products";
            this.Load += new System.EventHandler(this.frmOrder_Products_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdAllInformation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lblorderproductinformation;
        private System.Windows.Forms.Label lblsearchname;
        private System.Windows.Forms.Label lblsearchproduct;
        private System.Windows.Forms.TextBox txtbxSearchName;
        private System.Windows.Forms.TextBox txtbxsearchProducts;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnDetete;
        private System.Windows.Forms.BindingSource programBindingSource;
        private System.Windows.Forms.DataGridView grdAllInformation;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Select;
        private System.Windows.Forms.DataGridViewButtonColumn Discount;
    }
}