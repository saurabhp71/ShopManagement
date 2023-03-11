namespace ShopManagement
{
    partial class frmAll_Products
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
            this.allproductinformation = new System.Windows.Forms.Label();
            this.grdallproducts = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grdallproducts)).BeginInit();
            this.SuspendLayout();
            // 
            // allproductinformation
            // 
            this.allproductinformation.AutoSize = true;
            this.allproductinformation.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allproductinformation.Location = new System.Drawing.Point(48, 25);
            this.allproductinformation.Name = "allproductinformation";
            this.allproductinformation.Size = new System.Drawing.Size(287, 31);
            this.allproductinformation.TabIndex = 0;
            this.allproductinformation.Text = "All Products Information :";
            // 
            // grdallproducts
            // 
            this.grdallproducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdallproducts.Location = new System.Drawing.Point(54, 72);
            this.grdallproducts.Name = "grdallproducts";
            this.grdallproducts.Size = new System.Drawing.Size(567, 279);
            this.grdallproducts.TabIndex = 1;
            // 
            // frmAll_Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grdallproducts);
            this.Controls.Add(this.allproductinformation);
            this.Name = "frmAll_Products";
            this.Text = "All_Products";
            ((System.ComponentModel.ISupportInitialize)(this.grdallproducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label allproductinformation;
        private System.Windows.Forms.DataGridView grdallproducts;
    }
}