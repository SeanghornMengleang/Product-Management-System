using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Product_Management_System.Forms
{
    public partial class FormReports : Form
    {
        string connString = ConfigurationManager.ConnectionStrings["MyShopDB"]?.ConnectionString;

        public FormReports()
        {
            InitializeComponent();
        }

        private void FormReports_Load(object sender, EventArgs e)
        {
            dtpStartDate.Value = DateTime.Today.AddDays(-30);
            dtpEndDate.Value = DateTime.Today;

            LoadProductReport();
        }

        private void FormReports_Load_1(object sender, EventArgs e)
        {
            FormReports_Load(sender, e);
        }

        private void LoadProductReport()
        {
            if (string.IsNullOrEmpty(connString)) return;

            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    conn.Open();

                    // ទាញទិន្នន័យដោយភ្ជាប់តារាង Products និង Categories ចូលគ្នាเพื่อให้លេចចេញឈ្មោះ Category
                    string query = @"SELECT p.Id, p.Name, p.Price, p.Stock, c.CategoryName 
                                     FROM Products p 
                                     INNER JOIN Categories c ON p.CategoryId = c.CategoryID";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // បញ្ចូលទិន្នន័យទៅក្នុង DataGridView
                    dgvReports.DataSource = dt;

                    // គណនាទឹកប្រាក់សរុបនៃតម្លៃទំនិញទាំងអស់ (Total Price)
                    decimal totalRevenue = 0;
                    foreach (DataRow row in dt.Rows)
                    {
                        if (row["Price"] != DBNull.Value)
                        {
                            totalRevenue += Convert.ToDecimal(row["Price"]);
                        }
                    }


                    lblTotalPrice.Text = "Total Price: $" + totalRevenue.ToString("0.00");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading report: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadProductReport();
        }

        private void dtpSartDate_ValueChanged(object sender, EventArgs e) { }
        private void dtpEndDate_ValueChanged(object sender, EventArgs e) { }
        private void dgvReports_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void lblTotalRevenue_Click(object sender, EventArgs e) { }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}