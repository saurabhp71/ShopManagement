namespace ShopManagement
{
    partial class frmProduct
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
            this.lblPSize = new System.Windows.Forms.Label();
            this.lblPProductName = new System.Windows.Forms.Label();
            this.cmbbxPType = new System.Windows.Forms.ComboBox();
            this.txtbxProductName = new System.Windows.Forms.TextBox();
            this.btnPSave = new System.Windows.Forms.Button();
            this.btnPClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPSize
            // 
            this.lblPSize.AutoSize = true;
            this.lblPSize.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPSize.Location = new System.Drawing.Point(52, 68);
            this.lblPSize.Name = "lblPSize";
            this.lblPSize.Size = new System.Drawing.Size(60, 25);
            this.lblPSize.TabIndex = 0;
            this.lblPSize.Text = "Type:";
            // 
            // lblPProductName
            // 
            this.lblPProductName.AutoSize = true;
            this.lblPProductName.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPProductName.Location = new System.Drawing.Point(52, 126);
            this.lblPProductName.Name = "lblPProductName";
            this.lblPProductName.Size = new System.Drawing.Size(137, 25);
            this.lblPProductName.TabIndex = 1;
            this.lblPProductName.Text = "Product Name:";
            // 
            // cmbbxPType
            // 
            this.cmbbxPType.FormattingEnabled = true;
            this.cmbbxPType.Location = new System.Drawing.Point(216, 68);
            this.cmbbxPType.Name = "cmbbxPType";
            this.cmbbxPType.Size = new System.Drawing.Size(176, 21);
            this.cmbbxPType.TabIndex = 2;
            this.cmbbxPType.SelectedIndexChanged += new System.EventHandler(this.cmbbxPType_SelectedIndexChanged);
            // 
            // txtbxProductName
            // 
            this.txtbxProductName.Location = new System.Drawing.Point(216, 131);
            this.txtbxProductName.Name = "txtbxProductName";
            this.txtbxProductName.Size = new System.Drawing.Size(176, 20);
            this.txtbxProductName.TabIndex = 3;
            // 
            // btnPSave
            // 
            this.btnPSave.Font = new System.Drawing.Font("Arial Narrow", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPSave.Location = new System.Drawing.Point(95, 217);
            this.btnPSave.Name = "btnPSave";
            this.btnPSave.Size = new System.Drawing.Size(94, 42);
            this.btnPSave.TabIndex = 4;
            this.btnPSave.Text = "Save";
            this.btnPSave.UseVisualStyleBackColor = true;
            this.btnPSave.Click += new System.EventHandler(this.btnPSave_Click);
            // 
            // btnPClear
            // 
            this.btnPClear.Font = new System.Drawing.Font("Arial Narrow", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPClear.Location = new System.Drawing.Point(256, 217);
            this.btnPClear.Name = "btnPClear";
            this.btnPClear.Size = new System.Drawing.Size(94, 42);
            this.btnPClear.TabIndex = 5;
            this.btnPClear.Text = "Clear";
            this.btnPClear.UseVisualStyleBackColor = true;
            // 
            // frmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 292);
            this.Controls.Add(this.btnPClear);
            this.Controls.Add(this.btnPSave);
            this.Controls.Add(this.txtbxProductName);
            this.Controls.Add(this.cmbbxPType);
            this.Controls.Add(this.lblPProductName);
            this.Controls.Add(this.lblPSize);
            this.Name = "frmProduct";
            this.Text = "Product";
            this.Load += new System.EventHandler(this.frmProduct_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPSize;
        private System.Windows.Forms.Label lblPProductName;
        private System.Windows.Forms.ComboBox cmbbxPType;
        private System.Windows.Forms.TextBox txtbxProductName;
        private System.Windows.Forms.Button btnPSave;
        private System.Windows.Forms.Button btnPClear;
    }
}