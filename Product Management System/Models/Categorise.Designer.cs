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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Categorise));
            dgv = new DataGridView();
            btnRefresh = new Button();
            btnDelete = new Button();
            btnEdit = new Button();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            SuspendLayout();
            // 
            // dgv
            // 
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Location = new Point(31, 23);
            dgv.Name = "dgv";
            dgv.RowHeadersWidth = 51;
            dgv.Size = new Size(656, 327);
            dgv.TabIndex = 0;
            dgv.CellContentClick += dgv_CellContentClick;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(0, 192, 0);
            btnRefresh.Font = new Font("Khmer OS Siemreap", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Image = Properties.Resources.refresh;
            btnRefresh.ImageAlign = ContentAlignment.MiddleRight;
            btnRefresh.Location = new Point(586, 378);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(101, 38);
            btnRefresh.TabIndex = 13;
            btnRefresh.Text = "Refresh";
            btnRefresh.TextAlign = ContentAlignment.MiddleLeft;
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(255, 128, 128);
            btnDelete.Font = new Font("Khmer OS Siemreap", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.White;
            btnDelete.Image = Properties.Resources.delete;
            btnDelete.ImageAlign = ContentAlignment.MiddleRight;
            btnDelete.Location = new Point(439, 378);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 38);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "Delete";
            btnDelete.TextAlign = ContentAlignment.MiddleLeft;
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.DodgerBlue;
            btnEdit.Font = new Font("Khmer OS Siemreap", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEdit.ForeColor = Color.White;
            btnEdit.Image = (Image)resources.GetObject("btnEdit.Image");
            btnEdit.ImageAlign = ContentAlignment.MiddleRight;
            btnEdit.Location = new Point(292, 378);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 38);
            btnEdit.TabIndex = 11;
            btnEdit.Text = "Edit";
            btnEdit.TextAlign = ContentAlignment.MiddleLeft;
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click_1;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Red;
            btnClose.Font = new Font("Khmer OS Siemreap", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.White;
            btnClose.Image = Properties.Resources.close;
            btnClose.ImageAlign = ContentAlignment.MiddleRight;
            btnClose.Location = new Point(705, 23);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(92, 46);
            btnClose.TabIndex = 14;
            btnClose.Text = "Close";
            btnClose.TextAlign = ContentAlignment.MiddleLeft;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click_1;
            // 
            // Categorise
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Moccasin;
            ClientSize = new Size(818, 450);
            Controls.Add(btnClose);
            Controls.Add(btnRefresh);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(dgv);
            Name = "Categorise";
            Text = "Categorise";
            Load += Categorise_Load;
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgv;
        private Button btnRefresh;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnClose;
    }
}