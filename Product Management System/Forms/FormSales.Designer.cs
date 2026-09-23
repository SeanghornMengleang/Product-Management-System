namespace Product_Management_System.Forms
{
    partial class FormSales
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtQty = new TextBox();
            txtPrice = new TextBox();
            txtTotal = new TextBox();
            cmbCategory = new ComboBox();
            dgvCart = new DataGridView();
            btnAdd = new Button();
            btnRemove = new Button();
            btnPayment = new Button();
            cmbProduct = new ComboBox();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCart).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Khmer OS Siemreap", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(38, 61);
            label1.Name = "label1";
            label1.Size = new Size(86, 33);
            label1.TabIndex = 0;
            label1.Text = "Category";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Khmer OS Siemreap", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(368, 61);
            label2.Name = "label2";
            label2.Size = new Size(76, 33);
            label2.TabIndex = 1;
            label2.Text = "Product";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Khmer OS Siemreap", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(40, 132);
            label3.Name = "label3";
            label3.Size = new Size(41, 33);
            label3.TabIndex = 2;
            label3.Text = "Qty";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Khmer OS Siemreap", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(38, 201);
            label4.Name = "label4";
            label4.Size = new Size(55, 33);
            label4.TabIndex = 3;
            label4.Text = "Price";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Khmer OS Siemreap", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(38, 264);
            label5.Name = "label5";
            label5.Size = new Size(53, 33);
            label5.TabIndex = 4;
            label5.Text = "Total";
            // 
            // txtQty
            // 
            txtQty.Location = new Point(149, 128);
            txtQty.Multiline = true;
            txtQty.Name = "txtQty";
            txtQty.Size = new Size(524, 37);
            txtQty.TabIndex = 6;
            txtQty.TextChanged += txtQty_TextChanged;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(149, 197);
            txtPrice.Multiline = true;
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(524, 37);
            txtPrice.TabIndex = 7;
            txtPrice.TextChanged += txtPrice_TextChanged;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(149, 260);
            txtTotal.Multiline = true;
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(524, 37);
            txtTotal.TabIndex = 8;
            txtTotal.TextChanged += txtTotal_TextChanged;
            // 
            // cmbCategory
            // 
            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategory.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbCategory.ForeColor = Color.Black;
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(149, 60);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(202, 33);
            cmbCategory.TabIndex = 9;
            cmbCategory.SelectedIndexChanged += cmbCategory_SelectedIndexChanged;
            // 
            // dgvCart
            // 
            dgvCart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCart.Location = new Point(40, 314);
            dgvCart.Name = "dgvCart";
            dgvCart.RowHeadersWidth = 51;
            dgvCart.Size = new Size(633, 277);
            dgvCart.TabIndex = 11;
            dgvCart.CellContentClick += dgvCart_CellContentClick;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.PaleTurquoise;
            btnAdd.Font = new Font("Khmer OS Siemreap", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.Image = Properties.Resources.add;
            btnAdd.ImageAlign = ContentAlignment.MiddleRight;
            btnAdd.Location = new Point(712, 60);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(122, 34);
            btnAdd.TabIndex = 12;
            btnAdd.Text = "Add";
            btnAdd.TextAlign = ContentAlignment.MiddleLeft;
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnRemove
            // 
            btnRemove.BackColor = Color.FromArgb(255, 128, 128);
            btnRemove.Font = new Font("Khmer OS Siemreap", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRemove.Image = Properties.Resources.remove;
            btnRemove.ImageAlign = ContentAlignment.MiddleRight;
            btnRemove.Location = new Point(712, 128);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(122, 37);
            btnRemove.TabIndex = 13;
            btnRemove.Text = "Remove";
            btnRemove.TextAlign = ContentAlignment.MiddleLeft;
            btnRemove.UseVisualStyleBackColor = false;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnPayment
            // 
            btnPayment.BackColor = Color.FromArgb(192, 255, 192);
            btnPayment.Font = new Font("Khmer OS Siemreap", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPayment.Image = Properties.Resources.payment;
            btnPayment.ImageAlign = ContentAlignment.MiddleRight;
            btnPayment.Location = new Point(712, 197);
            btnPayment.Name = "btnPayment";
            btnPayment.Size = new Size(122, 41);
            btnPayment.TabIndex = 14;
            btnPayment.Text = "Payment";
            btnPayment.TextAlign = ContentAlignment.MiddleLeft;
            btnPayment.UseVisualStyleBackColor = false;
            btnPayment.Click += btnPayment_Click;
            // 
            // cmbProduct
            // 
            cmbProduct.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProduct.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbProduct.ForeColor = Color.Black;
            cmbProduct.FormattingEnabled = true;
            cmbProduct.Location = new Point(471, 61);
            cmbProduct.Name = "cmbProduct";
            cmbProduct.Size = new Size(202, 33);
            cmbProduct.TabIndex = 15;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Red;
            btnClose.Font = new Font("Khmer OS Siemreap", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.White;
            btnClose.Image = Properties.Resources.close;
            btnClose.ImageAlign = ContentAlignment.MiddleRight;
            btnClose.Location = new Point(712, 552);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(122, 39);
            btnClose.TabIndex = 16;
            btnClose.Text = "Close";
            btnClose.TextAlign = ContentAlignment.MiddleLeft;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // FormSales
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(873, 627);
            Controls.Add(btnClose);
            Controls.Add(cmbProduct);
            Controls.Add(btnPayment);
            Controls.Add(btnRemove);
            Controls.Add(btnAdd);
            Controls.Add(dgvCart);
            Controls.Add(cmbCategory);
            Controls.Add(txtTotal);
            Controls.Add(txtPrice);
            Controls.Add(txtQty);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormSales";
            Text = "FormSales";
            Load += FormSales_Load_1;
            ((System.ComponentModel.ISupportInitialize)dgvCart).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtQty;
        private TextBox txtPrice;
        private TextBox txtTotal;
        private ComboBox cmbCategory;
        private DataGridView dgvCart;
        private Button btnAdd;
        private Button btnRemove;
        private Button btnPayment;
        private ComboBox cmbProduct;
        private Button btnClose;
    }
}