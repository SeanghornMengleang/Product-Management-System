using Product_Management_System.Forms;
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

namespace Product_Management_System.Models
{
    public partial class Categorise : Form
    {
        public Categorise()
        {
            InitializeComponent();
            LoadCategoryData();
            dgv.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void Categorise_Load(object sender, EventArgs e)
        {
            LoadCategoryData();
        }

        private void LoadCategoryData()
        {
            try
            {
                string connString = ConfigurationManager.ConnectionStrings["MyShopDB"].ConnectionString;
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    string query = "SELECT * FROM Categories";
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
                int id = Convert.ToInt32(dgv.SelectedRows[0].Cells["CategoryID"].Value);
                string name = dgv.SelectedRows[0].Cells["CategoryName"].Value.ToString();

                FormEditCategory editForm = new FormEditCategory(id, name);
                editForm.ShowDialog();


                LoadCategoryData();
            }
            else
            {
                MessageBox.Show("Please select a category to edit!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgv.SelectedRows[0].Cells["CategoryID"].Value);
                string name = dgv.SelectedRows[0].Cells["CategoryName"].Value.ToString();

                FormEditCategory editForm = new FormEditCategory(id, name);
                editForm.ShowDialog();


                LoadCategoryData();
            }
            else
            {
                MessageBox.Show("Please select a category to edit!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this category?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        int id = Convert.ToInt32(dgv.SelectedRows[0].Cells["CategoryID"].Value);
                        string connString = ConfigurationManager.ConnectionStrings["MyShopDB"].ConnectionString;

                        using (SqlConnection conn = new SqlConnection(connString))
                        {
                            string query = "DELETE FROM Categories WHERE CategoryID = @CategoryID";
                            using (SqlCommand cmd = new SqlCommand(query, conn))
                            {
                                cmd.Parameters.AddWithValue("@CategoryID", id);
                                conn.Open();
                                cmd.ExecuteNonQuery();
                            }
                        }

                        MessageBox.Show("Category deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadCategoryData();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a category to delete!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
          
                LoadCategoryData();

                MessageBox.Show("Data refreshed successfully!", "Refresh", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}