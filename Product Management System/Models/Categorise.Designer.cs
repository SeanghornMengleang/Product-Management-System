namespace Product_Management_System.Models
{
    partial class Categorise
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
            btnClose = new Button();
            btnEdit = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            SuspendLayout();
            // 
            // dgv
            // 
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Location = new Point(64, 25);
            dgv.Name = "dgv";
            dgv.RowHeadersWidth = 51;
            dgv.Size = new Size(656, 327);
            dgv.TabIndex = 0;
            dgv.CellContentClick += dgv_CellContentClick;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Khmer OS Siemreap", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClose.Location = new Point(582, 393);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(138, 45);
            btnClose.TabIndex = 2;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnEdit
            // 
            btnEdit.Font = new Font("Khmer OS Siemreap", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEdit.Location = new Point(380, 393);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(138, 45);
            btnEdit.TabIndex = 3;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // Categorise
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEdit);
            Controls.Add(btnClose);
            Controls.Add(dgv);
            Name = "Categorise";
            Text = "Categorise";
            Load += Categorise_Load;
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgv;
        private Button btnClose;
        private Button btnEdit;
    }
}