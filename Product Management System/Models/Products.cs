using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Product_Management_System.Services
{
    public partial class Products : Form
    {
        public Products()
        {
            InitializeComponent();
        }

        private void Products_Load(object sender, EventArgs e)
        {
            LoadProductData(); 
        }

        private void LoadProductData()
        {
            try
            {
                string connString = @"Server=MSI\SQLEXPRESS01;Database=ProductManagementDB;Integrated Security=true;";
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    string query = "SELECT * FROM Products";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgv.DataSource = dt; 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}