namespace Product_Management_System.Forms
{
    partial class FormReports
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
            lblTotalRevenue = new Label();
            dtpStartDate = new DateTimePicker();
            dtpEndDate = new DateTimePicker();
            dgvReports = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvReports).BeginInit();
            SuspendLayout();
            // 
            // lblTotalRevenue
            // 
            lblTotalRevenue.AutoSize = true;
            lblTotalRevenue.Font = new Font("Khmer OS Siemreap", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalRevenue.Location = new Point(485, 344);
            lblTotalRevenue.Name = "lblTotalRevenue";
            lblTotalRevenue.Size = new Size(127, 33);
            lblTotalRevenue.TabIndex = 0;
            lblTotalRevenue.Text = "Total Revenue";
            lblTotalRevenue.Click += lblTotalRevenue_Click;
            // 
            // dtpStartDate
            // 
            dtpStartDate.Font = new Font("Khmer OS Siemreap", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpStartDate.Location = new Point(145, 50);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(250, 40);
            dtpStartDate.TabIndex = 1;
            dtpStartDate.ValueChanged += dtpSartDate_ValueChanged;
            // 
            // dtpEndDate
            // 
            dtpEndDate.Font = new Font("Khmer OS Siemreap", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpEndDate.Location = new Point(563, 50);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(250, 40);
            dtpEndDate.TabIndex = 2;
            dtpEndDate.ValueChanged += dtpEndDate_ValueChanged;
            // 
            // dgvReports
            // 
            dgvReports.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReports.Location = new Point(38, 118);
            dgvReports.Name = "dgvReports";
            dgvReports.RowHeadersWidth = 51;
            dgvReports.Size = new Size(775, 209);
            dgvReports.TabIndex = 4;
            dgvReports.CellContentClick += dgvReports_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Khmer OS Siemreap", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(38, 58);
            label1.Name = "label1";
            label1.Size = new Size(89, 33);
            label1.TabIndex = 5;
            label1.Text = "StartDate";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Khmer OS Siemreap", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(474, 57);
            label2.Name = "label2";
            label2.Size = new Size(83, 33);
            label2.TabIndex = 6;
            label2.Text = "EndDate";
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Red;
            btnClose.Font = new Font("Khmer OS Siemreap", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.White;
            btnClose.Image = Properties.Resources.close;
            btnClose.ImageAlign = ContentAlignment.MiddleRight;
            btnClose.Location = new Point(691, 338);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(122, 39);
            btnClose.TabIndex = 17;
            btnClose.Text = "Close";
            btnClose.TextAlign = ContentAlignment.MiddleLeft;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // FormReports
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(855, 410);
            Controls.Add(btnClose);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvReports);
            Controls.Add(dtpEndDate);
            Controls.Add(dtpStartDate);
            Controls.Add(lblTotalRevenue);
            Name = "FormReports";
            Text = "FormReports";
            Load += FormReports_Load_1;
            ((System.ComponentModel.ISupportInitialize)dgvReports).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTotalRevenue;
        private DateTimePicker dtpStartDate;
        private DateTimePicker dtpEndDate;
        private DataGridView dgvReports;
        private Label label1;
        private Label label2;
        private Button btnClose;
    }
}