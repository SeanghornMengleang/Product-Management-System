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
    public partial class FormAddProduct : Form
    {
        public FormAddProduct()
        {
            InitializeComponent();
            LoadCategories();
        }

        private void LoadCategories()
        {
            try
            {
                string connString = "Server=MSI\\SQLEXPRESS01;Database=ProductManagementDB;Integrated Security=true;";
                string query = "SELECT CategoryId, CategoryName FROM Categories";

                using (SqlConnection conn = new SqlConnection(connString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        cmbCategory.DataSource = dt;
                        cmbCategory.DisplayMember = "CategoryName";
                        cmbCategory.ValueMember = "CategoryId";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading categories: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string connString = @"Server=MSI\SQLEXPRESS01;Database=ProductManagementDB;Integrated Security=true;";
                string query = "INSERT INTO Products (Name, Price, Stock, CategoryId) VALUES (@Name, @Price, @Stock, @CategoryId)";

                using (SqlConnection conn = new SqlConnection(connString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Name", txtName.Text);
                        cmd.Parameters.AddWithValue("@Price", Convert.ToDecimal(txtPrice.Text));
                        cmd.Parameters.AddWithValue("@Stock", Convert.ToInt32(txtStock.Text));
                        cmd.Parameters.AddWithValue("@CategoryId", cmbCategory.SelectedValue);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                }

                MessageBox.Show("Product added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormAddProduct_Load(object sender, EventArgs e)
        {

        }
    }
}