namespace ShopManagement
{
    partial class frmOFFER_FORM
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
            this.lblOfferform = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbxDiscount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtbxNewPrice = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnUpdatedPrice = new System.Windows.Forms.Button();
            this.btnCalculatednewprice = new System.Windows.Forms.Button();
            this.lblProduct = new System.Windows.Forms.Label();
            this.lblOrderID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblOfferform
            // 
            this.lblOfferform.AutoSize = true;
            this.lblOfferform.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOfferform.Location = new System.Drawing.Point(299, 23);
            this.lblOfferform.Name = "lblOfferform";
            this.lblOfferform.Size = new System.Drawing.Size(161, 31);
            this.lblOfferform.TabIndex = 0;
            this.lblOfferform.Text = "OFFER FORM";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Highlight;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "OFFER INFORMATION:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(93, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Original Price Of ";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(433, 144);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(40, 20);
            this.lblPrice.TabIndex = 3;
            this.lblPrice.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(556, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Rs";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(93, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Discount in Percentage";
            // 
            // txtbxDiscount
            // 
            this.txtbxDiscount.Location = new System.Drawing.Point(412, 208);
            this.txtbxDiscount.Name = "txtbxDiscount";
            this.txtbxDiscount.Size = new System.Drawing.Size(108, 20);
            this.txtbxDiscount.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(556, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "%";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(93, 266);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "New Price";
            // 
            // txtbxNewPrice
            // 
            this.txtbxNewPrice.Location = new System.Drawing.Point(412, 266);
            this.txtbxNewPrice.Name = "txtbxNewPrice";
            this.txtbxNewPrice.Size = new System.Drawing.Size(108, 20);
            this.txtbxNewPrice.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(556, 266);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Rs";
            // 
            // btnUpdatedPrice
            // 
            this.btnUpdatedPrice.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdatedPrice.Location = new System.Drawing.Point(133, 351);
            this.btnUpdatedPrice.Name = "btnUpdatedPrice";
            this.btnUpdatedPrice.Size = new System.Drawing.Size(121, 39);
            this.btnUpdatedPrice.TabIndex = 11;
            this.btnUpdatedPrice.Text = "Updated Price";
            this.btnUpdatedPrice.UseCompatibleTextRendering = true;
            this.btnUpdatedPrice.UseVisualStyleBackColor = true;
            this.btnUpdatedPrice.Click += new System.EventHandler(this.btnUpdatedPrice_Click);
            // 
            // btnCalculatednewprice
            // 
            this.btnCalculatednewprice.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculatednewprice.Location = new System.Drawing.Point(362, 351);
            this.btnCalculatednewprice.Name = "btnCalculatednewprice";
            this.btnCalculatednewprice.Size = new System.Drawing.Size(158, 39);
            this.btnCalculatednewprice.TabIndex = 12;
            this.btnCalculatednewprice.Text = "Calculated New Price";
            this.btnCalculatednewprice.UseCompatibleTextRendering = true;
            this.btnCalculatednewprice.UseVisualStyleBackColor = true;
            this.btnCalculatednewprice.Click += new System.EventHandler(this.btnCalculatednewprice_Click);
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduct.Location = new System.Drawing.Point(223, 144);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(57, 20);
            this.lblProduct.TabIndex = 13;
            this.lblProduct.Text = "Product";
            // 
            // lblOrderID
            // 
            this.lblOrderID.AutoSize = true;
            this.lblOrderID.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderID.Location = new System.Drawing.Point(425, 109);
            this.lblOrderID.Name = "lblOrderID";
            this.lblOrderID.Size = new System.Drawing.Size(48, 16);
            this.lblOrderID.TabIndex = 14;
            this.lblOrderID.Text = "OrderID";
            // 
            // frmOFFER_FORM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblOrderID);
            this.Controls.Add(this.lblProduct);
            this.Controls.Add(this.btnCalculatednewprice);
            this.Controls.Add(this.btnUpdatedPrice);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtbxNewPrice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtbxDiscount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblOfferform);
            this.Name = "frmOFFER_FORM";
            this.Text = "OFFER_FORM";
            this.Load += new System.EventHandler(this.frmOFFER_FORM_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOfferform;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbxDiscount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtbxNewPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnUpdatedPrice;
        private System.Windows.Forms.Button btnCalculatednewprice;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Label lblOrderID;
    }
}