

using Product_Management_System.Models;
using Product_Management_System.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration; 
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Product_Management_System.Forms
{
    public partial class FormMainDashboard : Form
    {

        string connString = ConfigurationManager.ConnectionStrings["MyShopDB"].ConnectionString;

        public FormMainDashboard()
        {
            InitializeComponent();
        }

        private void FormMainDashboard_Load(object sender, EventArgs e)
        {
            LoadProducts();
            LoadCategoriesToComboBox();
        }

        public void LoadCategoriesToComboBox()
        {
            try
            {
                string query = "SELECT CategoryId, CategoryName FROM Categories";

                using (SqlConnection conn = new SqlConnection(connString))
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cmbCategoryFilter.DataSource = dt;
                    cmbCategoryFilter.DisplayMember = "CategoryName";
                    cmbCategoryFilter.ValueMember = "CategoryId";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading categories: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LoadProducts()
        {
            try
            {
                string query = "SELECT * FROM Products";

                using (SqlConnection conn = new SqlConnection(connString))
                {
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgv.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            Products prodForm = new Products();
            prodForm.ShowDialog();
            LoadProducts();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            FormAddProduct frm = new FormAddProduct();
            frm.ShowDialog();
            LoadProducts();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadProducts();
            LoadCategoriesToComboBox();
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
                        LoadProducts();
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
                LoadProducts();
            }
            else
            {
                MessageBox.Show("Please select a product to edit!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT * FROM Products WHERE Name LIKE @SearchQuery";

                using (SqlConnection conn = new SqlConnection(connString))
                {
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    da.SelectCommand.Parameters.AddWithValue("@SearchQuery", "%" + txtSearch.Text + "%");

                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgv.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            FormAddCategory frm = new FormAddCategory();
            frm.ShowDialog();
            LoadCategoriesToComboBox();
        }

        private void cmbCategoryFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCategoryFilter.SelectedValue == null || cmbCategoryFilter.SelectedValue is DataRowView)
            {
                return;
            }

            try
            {
                string query = "SELECT * FROM Products WHERE CategoryId = @CategoryId";

                using (SqlConnection conn = new SqlConnection(connString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@CategoryId", cmbCategoryFilter.SelectedValue);

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        dgv.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error filtering products: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCategorise_Click(object sender, EventArgs e)
        {
            Categorise catForm = new Categorise();
            catForm.ShowDialog();
            LoadCategoriesToComboBox();
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv.Rows[e.RowIndex];

                if (row.Cells["CategoryId"].Value != null)
                {
                    var catId = row.Cells["CategoryId"].Value;
                    cmbCategoryFilter.SelectedValue = catId;
                }
            }
        }

        private void cmbCategoryFilter_Click(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click_1(object sender, EventArgs e)
        {
            try
            {

                LoadProducts();
                LoadCategoriesToComboBox();

                MessageBox.Show("Data refreshed successfully!", "Refresh", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSale_Click(object sender, EventArgs e)
        {
            FormSales salesForm = new FormSales();
            salesForm.ShowDialog();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            FormReports reportForm = new FormReports();
            reportForm.Show();
        }
    }
}