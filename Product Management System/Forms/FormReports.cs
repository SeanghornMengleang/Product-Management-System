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

            LoadSalesReport();
        }

        private void FormReports_Load_1(object sender, EventArgs e)
        {
            FormReports_Load(sender, e);
        }

        private void LoadSalesReport()
        {
            if (string.IsNullOrEmpty(connString)) return;

            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    conn.Open();

       
                    string query = @"SELECT SaleId, SaleDate, TotalAmount 
                                     FROM Sales 
                                     WHERE SaleDate >= @StartDate AND SaleDate <= @EndDate";

                    SqlCommand cmd = new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@StartDate", dtpStartDate.Value.Date);
                    cmd.Parameters.AddWithValue("@EndDate", dtpEndDate.Value.Date.AddDays(1).AddSeconds(-1));

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvReports.DataSource = dt;

                    decimal totalRevenue = 0;
                    foreach (DataRow row in dt.Rows)
                    {
                        if (row["TotalAmount"] != DBNull.Value)
                        {
                            totalRevenue += Convert.ToDecimal(row["TotalAmount"]);
                        }
                    }

                    lblTotalRevenue.Text = "Total Revenue: $" + totalRevenue.ToString("0.00");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading report: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadSalesReport();
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