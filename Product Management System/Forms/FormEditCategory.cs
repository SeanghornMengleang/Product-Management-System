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
    public partial class FormEditCategory : Form
    {
        private int categoryId;
        private string connString = @"Server=MSI\SQLEXPRESS01;Database=ProductManagementDB;Integrated Security=true;";

        public FormEditCategory(int id, string name)
        {
            InitializeComponent();

            categoryId = id;
            txtCategoryName.Text = name;
        }

        private void txtCategoryName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCategoryName.Text))
            {
                MessageBox.Show("Please enter a category name!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();
                    string query = "UPDATE Categories SET CategoryName = @CategoryName WHERE CategoryID = @CategoryId";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@CategoryName", txtCategoryName.Text.Trim());
                        cmd.Parameters.AddWithValue("@CategoryId", categoryId);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Category updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating category: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormEditCategory_Load(object sender, EventArgs e)
        {

        }
    }
}