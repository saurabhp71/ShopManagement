namespace ShopManagement
{
    partial class frmUnorder_Product
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
            this.grdUnorderProduct = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lblUnorder = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdUnorderProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // grdUnorderProduct
            // 
            this.grdUnorderProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdUnorderProduct.Location = new System.Drawing.Point(12, 76);
            this.grdUnorderProduct.Name = "grdUnorderProduct";
            this.grdUnorderProduct.Size = new System.Drawing.Size(759, 234);
            this.grdUnorderProduct.TabIndex = 0;
            // 
            // lblUnorder
            // 
            this.lblUnorder.AutoSize = true;
            this.lblUnorder.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblUnorder.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnorder.Location = new System.Drawing.Point(12, 34);
            this.lblUnorder.Name = "lblUnorder";
            this.lblUnorder.Size = new System.Drawing.Size(259, 25);
            this.lblUnorder.TabIndex = 1;
            this.lblUnorder.Text = "UNOrder Product Information";
            // 
            // frmUnorder_Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblUnorder);
            this.Controls.Add(this.grdUnorderProduct);
            this.Name = "frmUnorder_Product";
            this.Text = "Unorder_Product";
            this.Load += new System.EventHandler(this.frmUnorder_Product_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdUnorderProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdUnorderProduct;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lblUnorder;
    }
}