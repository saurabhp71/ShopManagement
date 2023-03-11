namespace ShopManagement
{
    partial class frmUnorder_Customer
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
            this.lblUncustomer = new System.Windows.Forms.Label();
            this.grdUncustomer = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grdUncustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUncustomer
            // 
            this.lblUncustomer.AutoSize = true;
            this.lblUncustomer.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblUncustomer.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUncustomer.Location = new System.Drawing.Point(29, 46);
            this.lblUncustomer.Name = "lblUncustomer";
            this.lblUncustomer.Size = new System.Drawing.Size(274, 25);
            this.lblUncustomer.TabIndex = 2;
            this.lblUncustomer.Text = "UNOrder Customer Information";
            // 
            // grdUncustomer
            // 
            this.grdUncustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdUncustomer.Location = new System.Drawing.Point(34, 97);
            this.grdUncustomer.Name = "grdUncustomer";
            this.grdUncustomer.Size = new System.Drawing.Size(740, 253);
            this.grdUncustomer.TabIndex = 3;
            // 
            // frmUnorder_Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grdUncustomer);
            this.Controls.Add(this.lblUncustomer);
            this.Name = "frmUnorder_Customer";
            this.Text = "Unorder_Customer";
            this.Load += new System.EventHandler(this.frmUnorder_Customer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdUncustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUncustomer;
        private System.Windows.Forms.DataGridView grdUncustomer;
    }
}