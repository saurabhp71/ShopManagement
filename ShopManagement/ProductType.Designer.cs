namespace ShopManagement
{
    partial class frmProductType
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
            this.txtbxType = new System.Windows.Forms.TextBox();
            this.lblTType = new System.Windows.Forms.Label();
            this.btnTSave = new System.Windows.Forms.Button();
            this.btnTClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtbxType
            // 
            this.txtbxType.Location = new System.Drawing.Point(189, 92);
            this.txtbxType.Name = "txtbxType";
            this.txtbxType.Size = new System.Drawing.Size(184, 20);
            this.txtbxType.TabIndex = 0;
            // 
            // lblTType
            // 
            this.lblTType.AutoSize = true;
            this.lblTType.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTType.Location = new System.Drawing.Point(77, 86);
            this.lblTType.Name = "lblTType";
            this.lblTType.Size = new System.Drawing.Size(60, 25);
            this.lblTType.TabIndex = 1;
            this.lblTType.Text = "Type:";
            // 
            // btnTSave
            // 
            this.btnTSave.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTSave.Location = new System.Drawing.Point(82, 190);
            this.btnTSave.Name = "btnTSave";
            this.btnTSave.Size = new System.Drawing.Size(95, 42);
            this.btnTSave.TabIndex = 2;
            this.btnTSave.Text = "Save";
            this.btnTSave.UseVisualStyleBackColor = true;
            this.btnTSave.Click += new System.EventHandler(this.btnTSave_Click);
            // 
            // btnTClear
            // 
            this.btnTClear.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTClear.Location = new System.Drawing.Point(230, 190);
            this.btnTClear.Name = "btnTClear";
            this.btnTClear.Size = new System.Drawing.Size(95, 42);
            this.btnTClear.TabIndex = 3;
            this.btnTClear.Text = "Clear";
            this.btnTClear.UseVisualStyleBackColor = true;
            // 
            // frmProductType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 275);
            this.Controls.Add(this.btnTClear);
            this.Controls.Add(this.btnTSave);
            this.Controls.Add(this.lblTType);
            this.Controls.Add(this.txtbxType);
            this.Name = "frmProductType";
            this.Text = "ProductType";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbxType;
        private System.Windows.Forms.Label lblTType;
        private System.Windows.Forms.Button btnTSave;
        private System.Windows.Forms.Button btnTClear;
    }
}