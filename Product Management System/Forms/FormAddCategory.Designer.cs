namespace Product_Management_System.Forms
{
    partial class FormAddCategory
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
            txtCategoryName = new TextBox();
            btnSave = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Khmer OS Siemreap", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(43, 35);
            label1.Name = "label1";
            label1.Size = new Size(128, 31);
            label1.TabIndex = 0;
            label1.Text = "Category Name";
            // 
            // txtCategoryName
            // 
            txtCategoryName.Location = new Point(221, 21);
            txtCategoryName.Multiline = true;
            txtCategoryName.Name = "txtCategoryName";
            txtCategoryName.Size = new Size(473, 48);
            txtCategoryName.TabIndex = 1;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Khmer OS Siemreap", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(584, 116);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(110, 41);
            btnSave.TabIndex = 2;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // FormAddCategory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 228);
            Controls.Add(btnSave);
            Controls.Add(txtCategoryName);
            Controls.Add(label1);
            Name = "FormAddCategory";
            Text = "FormAddCategory";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtCategoryName;
        private Button btnSave;
    }
}