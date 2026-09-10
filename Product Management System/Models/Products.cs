using Product_Management_System.Forms;
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgv.SelectedRows[0].Cells["Id"].Value);
                string name = dgv.SelectedRows[0].Cells["Name"].Value.ToString();
                decimal price = Convert.ToDecimal(dgv.SelectedRows[0].Cells["Price"].Value);
                int stock = Convert.ToInt32(dgv.SelectedRows[0].Cells["Stock"].Value);
                int categoryId = Convert.ToInt32(dgv.SelectedRows[0].Cells["CategoryId"].Value);


                FormEditProduct editForm = new FormEditProduct(id, name, price, stock, categoryId);
                editForm.ShowDialog();

            }
            else
            {
                MessageBox.Show("Please select a product to edit!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count > 0)
            {
                int productId = Convert.ToInt32(dgv.SelectedRows[0].Cells["Id"].Value);

                DialogResult result = MessageBox.Show("Are you sure you want to delete this product?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        string connString = "Server=MSI\\SQLEXPRESS01;Database=ProductManagementDB;Integrated Security=true;";
                        string query = "DELETE FROM Products WHERE Id = @Id";

                        using (SqlConnection conn = new SqlConnection(connString))
                        {
                            conn.Open();
                            using (SqlCommand cmd = new SqlCommand(query, conn))
                            {
                                cmd.Parameters.AddWithValue("@Id", productId);
                                cmd.ExecuteNonQuery();
                            }
                        }

                        MessageBox.Show("Data deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadProductData();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a row in the grid to delete!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                

                MessageBox.Show("Data refreshed successfully!", "Refresh", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}