namespace Product_Management_System.Forms
{
    partial class FormMainDashboard
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
            dgv = new DataGridView();
            btnProducts = new Button();
            btnCategorise = new Button();
            btnAddProduct = new Button();
            btnAddCategory = new Button();
            txtSearch = new TextBox();
            cmbCategoryFilter = new ComboBox();
            btnEdit = new Button();
            btnDelete = new Button();
            btnRefresh = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            SuspendLayout();
            // 
            // dgv
            // 
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Location = new Point(66, 258);
            dgv.Name = "dgv";
            dgv.RowHeadersWidth = 51;
            dgv.Size = new Size(638, 261);
            dgv.TabIndex = 0;
            dgv.CellClick += dgv_CellClick;
            // 
            // btnProducts
            // 
            btnProducts.Font = new Font("Khmer OS Siemreap", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnProducts.Location = new Point(66, 28);
            btnProducts.Name = "btnProducts";
            btnProducts.Size = new Size(186, 60);
            btnProducts.TabIndex = 1;
            btnProducts.Text = "Products";
            btnProducts.UseVisualStyleBackColor = true;
            btnProducts.Click += btnProducts_Click;
            // 
            // btnCategorise
            // 
            btnCategorise.Font = new Font("Khmer OS Siemreap", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCategorise.Location = new Point(66, 105);
            btnCategorise.Name = "btnCategorise";
            btnCategorise.Size = new Size(186, 60);
            btnCategorise.TabIndex = 2;
            btnCategorise.Text = "Categorise";
            btnCategorise.UseVisualStyleBackColor = true;
            btnCategorise.Click += btnCategorise_Click;
            // 
            // btnAddProduct
            // 
            btnAddProduct.Font = new Font("Khmer OS Siemreap", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddProduct.Location = new Point(508, 26);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(196, 60);
            btnAddProduct.TabIndex = 3;
            btnAddProduct.Text = "AddProduct";
            btnAddProduct.UseVisualStyleBackColor = true;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // btnAddCategory
            // 
            btnAddCategory.Font = new Font("Khmer OS Siemreap", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddCategory.Location = new Point(508, 100);
            btnAddCategory.Name = "btnAddCategory";
            btnAddCategory.Size = new Size(196, 60);
            btnAddCategory.TabIndex = 4;
            btnAddCategory.Text = "AddCategory";
            btnAddCategory.UseVisualStyleBackColor = true;
            btnAddCategory.Click += btnAddCategory_Click;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(65, 188);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search";
            txtSearch.Size = new Size(437, 34);
            txtSearch.TabIndex = 5;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // cmbCategoryFilter
            // 
            cmbCategoryFilter.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbCategoryFilter.FormattingEnabled = true;
            cmbCategoryFilter.Location = new Point(508, 189);
            cmbCategoryFilter.Name = "cmbCategoryFilter";
            cmbCategoryFilter.Size = new Size(196, 33);
            cmbCategoryFilter.TabIndex = 6;
            cmbCategoryFilter.SelectedIndexChanged += cmbCategoryFilter_SelectedIndexChanged;
            cmbCategoryFilter.Click += cmbCategoryFilter_Click;
            // 
            // btnEdit
            // 
            btnEdit.Font = new Font("Khmer OS Siemreap", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEdit.Location = new Point(65, 554);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 38);
            btnEdit.TabIndex = 7;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Khmer OS Siemreap", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(211, 554);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 38);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Font = new Font("Khmer OS Siemreap", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRefresh.Location = new Point(354, 554);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(94, 38);
            btnRefresh.TabIndex = 9;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click_1;
            // 
            // FormMainDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 644);
            Controls.Add(btnRefresh);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(cmbCategoryFilter);
            Controls.Add(txtSearch);
            Controls.Add(btnAddCategory);
            Controls.Add(btnAddProduct);
            Controls.Add(btnCategorise);
            Controls.Add(btnProducts);
            Controls.Add(dgv);
            Name = "FormMainDashboard";
            Text = "FormMainDashboard";
            Load += FormMainDashboard_Load;
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv;
        private Button btnProducts;
        private Button btnCategorise;
        private Button btnAddProduct;
        private Button btnAddCategory;
        private TextBox txtSearch;
        private ComboBox cmbCategoryFilter;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnRefresh;
    }
}