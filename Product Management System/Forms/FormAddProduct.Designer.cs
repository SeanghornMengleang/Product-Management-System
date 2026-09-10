namespace Product_Management_System.Forms
{
    partial class FormAddProduct
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
            cmbCategory = new ComboBox();
            btnSave = new Button();
            txtStock = new TextBox();
            txtPrice = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtName = new TextBox();
            SuspendLayout();
            // 
            // cmbCategory
            // 
            cmbCategory.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(170, 248);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(312, 36);
            cmbCategory.TabIndex = 13;
            cmbCategory.SelectedIndexChanged += cmbCategory_SelectedIndexChanged;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.DeepSkyBlue;
            btnSave.Font = new Font("Khmer OS Siemreap", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.White;
            btnSave.Image = Properties.Resources.save2;
            btnSave.ImageAlign = ContentAlignment.MiddleRight;
            btnSave.Location = new Point(539, 248);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(98, 40);
            btnSave.TabIndex = 20;
            btnSave.Text = "Save";
            btnSave.TextAlign = ContentAlignment.MiddleLeft;
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(170, 179);
            txtStock.Multiline = true;
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(467, 38);
            txtStock.TabIndex = 19;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(170, 116);
            txtPrice.Multiline = true;
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(467, 38);
            txtPrice.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Khmer OS Siemreap", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(61, 190);
            label3.Name = "label3";
            label3.Size = new Size(56, 31);
            label3.TabIndex = 17;
            label3.Text = "Stock";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Khmer OS Siemreap", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(61, 122);
            label2.Name = "label2";
            label2.Size = new Size(52, 31);
            label2.TabIndex = 16;
            label2.Text = "Price";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Khmer OS Siemreap", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(61, 49);
            label1.Name = "label1";
            label1.Size = new Size(58, 31);
            label1.TabIndex = 15;
            label1.Text = "Name";
            // 
            // txtName
            // 
            txtName.Location = new Point(170, 44);
            txtName.Multiline = true;
            txtName.Name = "txtName";
            txtName.Size = new Size(467, 38);
            txtName.TabIndex = 14;
            // 
            // FormAddProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(728, 345);
            Controls.Add(btnSave);
            Controls.Add(txtStock);
            Controls.Add(txtPrice);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtName);
            Controls.Add(cmbCategory);
            Name = "FormAddProduct";
            Text = "FormAddProduct";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbCategory;
        private Button btnSave;
        private TextBox txtStock;
        private TextBox txtPrice;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtName;
    }
}