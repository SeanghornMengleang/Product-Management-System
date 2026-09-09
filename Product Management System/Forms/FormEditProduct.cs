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

namespace Product_Management_System.Forms
{
    public partial class FormEditProduct : Form
    {
        private int productId;
        private string connString = @"Server=MSI\SQLEXPRESS01;Database=ProductManagementDB;Integrated Security=true;";

        public FormEditProduct(int id, string name, decimal price, int stock, int categoryId)
        {
            InitializeComponent();

            productId = id;
            txtName.Text = name;
            txtPrice.Text = price.ToString();
            txtStock.Text = stock.ToString();

            LoadCategories(categoryId);
        }

        private void LoadCategories(int selectedCategoryId)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    string query = "SELECT CategoryID, CategoryName FROM Categories";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cmbCategory.DataSource = dt;
                    cmbCategory.DisplayMember = "CategoryName";
                    cmbCategory.ValueMember = "CategoryID";

                    cmbCategory.SelectedValue = selectedCategoryId;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading categories: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormEditProduct_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtPrice.Text) || string.IsNullOrWhiteSpace(txtStock.Text))
            {
                MessageBox.Show("Please fill in all required fields!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();
                    string query = "UPDATE Products SET Name = @Name, Price = @Price, Stock = @Stock, CategoryId = @CategoryId WHERE Id = @Id";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Name", txtName.Text.Trim());
                        cmd.Parameters.AddWithValue("@Price", Convert.ToDecimal(txtPrice.Text));
                        cmd.Parameters.AddWithValue("@Stock", Convert.ToInt32(txtStock.Text));
                        cmd.Parameters.AddWithValue("@CategoryId", cmbCategory.SelectedValue);
                        cmd.Parameters.AddWithValue("@Id", productId);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Product updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating product: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}