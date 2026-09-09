namespace Product_Management_System.Forms
{
    partial class FormEditProduct
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
            btnSave = new Button();
            txtStock = new TextBox();
            txtPrice = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtName = new TextBox();
            cmbCategory = new ComboBox();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Khmer OS Siemreap", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(509, 231);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(119, 49);
            btnSave.TabIndex = 28;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(161, 171);
            txtStock.Multiline = true;
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(467, 38);
            txtStock.TabIndex = 27;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(161, 108);
            txtPrice.Multiline = true;
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(467, 38);
            txtPrice.TabIndex = 26;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Khmer OS Siemreap", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(52, 182);
            label3.Name = "label3";
            label3.Size = new Size(56, 31);
            label3.TabIndex = 25;
            label3.Text = "Stock";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Khmer OS Siemreap", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(52, 114);
            label2.Name = "label2";
            label2.Size = new Size(52, 31);
            label2.TabIndex = 24;
            label2.Text = "Price";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Khmer OS Siemreap", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(52, 41);
            label1.Name = "label1";
            label1.Size = new Size(58, 31);
            label1.TabIndex = 23;
            label1.Text = "Name";
            // 
            // txtName
            // 
            txtName.Location = new Point(161, 36);
            txtName.Multiline = true;
            txtName.Name = "txtName";
            txtName.Size = new Size(467, 38);
            txtName.TabIndex = 22;
            // 
            // cmbCategory
            // 
            cmbCategory.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(161, 240);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(312, 36);
            cmbCategory.TabIndex = 21;
            // 
            // FormEditProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(714, 359);
            Controls.Add(btnSave);
            Controls.Add(txtStock);
            Controls.Add(txtPrice);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtName);
            Controls.Add(cmbCategory);
            Name = "FormEditProduct";
            Text = "FormEditProduct";
            Load += FormEditProduct_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private TextBox txtStock;
        private TextBox txtPrice;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtName;
        private ComboBox cmbCategory;
    }
}