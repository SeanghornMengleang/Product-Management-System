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
    public partial class FormSales : Form
    {
        string connString = ConfigurationManager.ConnectionStrings["MyShopDB"]?.ConnectionString;
        DataTable cartTable = new DataTable();

        public FormSales()
        {
            InitializeComponent();
        }

        private void FormSales_Load(object sender, EventArgs e)
        {
            
        }

        private void FormSales_Load_1(object sender, EventArgs e)
        {
            cartTable.Columns.Add("ProductId", typeof(int));
            cartTable.Columns.Add("ProductName", typeof(string));
            cartTable.Columns.Add("Price", typeof(decimal));
            cartTable.Columns.Add("Qty", typeof(int));
            cartTable.Columns.Add("Total", typeof(decimal));

            dgvCart.DataSource = cartTable;

            txtPrice.ReadOnly = true;
            txtTotal.ReadOnly = true;

            cmbCategory.SelectedIndexChanged += cmbCategory_SelectedIndexChanged;
            cmbProduct.SelectedIndexChanged += cmbProduct_SelectedIndexChanged;

            LoadCategories();
        }

        private void LoadCategories()
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT CategoryID AS Id, CategoryName AS Name FROM Categories";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cmbCategory.DataSource = dt;
                    cmbCategory.DisplayMember = "Name";
                    cmbCategory.ValueMember = "Id";

                    if (dt.Rows.Count > 0)
                    {
                        cmbCategory.SelectedIndex = 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading categories: " + ex.Message);
                }
            }
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCategory.SelectedItem is DataRowView row)
            {
                if (int.TryParse(row["Id"].ToString(), out int categoryId))
                {
                    LoadProductsByCategory(categoryId);
                }
            }
        }

        private void LoadProductsByCategory(int categoryId)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT Id, Name, Price FROM Products WHERE CategoryId = @CategoryId";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@CategoryId", categoryId);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cmbProduct.DataSource = dt;
                    cmbProduct.DisplayMember = "Name";
                    cmbProduct.ValueMember = "Id";

                    if (cmbProduct.Items.Count > 0)
                    {
                        cmbProduct.SelectedIndex = 0;
                    }
                    else
                    {
                        cmbProduct.SelectedIndex = -1;
                        txtPrice.Clear();
                        txtTotal.Clear();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading products: " + ex.Message);
                }
            }
        }

        private void cmbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProduct.SelectedItem is DataRowView row)
            {
                decimal price = Convert.ToDecimal(row["Price"]);
                txtPrice.Text = price.ToString("0.00");
                CalculateTotal();
            }
        }

        private void txtQty_TextChanged(object sender, EventArgs e)
        {
            CalculateTotal();
        }

        private void CalculateTotal()
        {
            if (decimal.TryParse(txtPrice.Text, out decimal price) && int.TryParse(txtQty.Text, out int qty))
            {
                decimal total = price * qty;
                txtTotal.Text = total.ToString("0.00");
            }
            else
            {
                txtTotal.Text = "0.00";
            }
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cmbProduct.SelectedItem == null)
            {
                MessageBox.Show("Please select a product first!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtQty.Text, out int qty) || qty <= 0)
            {
                MessageBox.Show("Please enter a valid quantity!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataRowView row = cmbProduct.SelectedItem as DataRowView;
            int productId = Convert.ToInt32(row["Id"]);
            string productName = row["Name"].ToString();
            decimal price = Convert.ToDecimal(row["Price"]);
            decimal total = price * qty;

            cartTable.Rows.Add(productId, productName, price, qty, total);

            txtQty.Clear();
            txtTotal.Clear();
            txtPrice.Clear();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgvCart.SelectedRows.Count > 0)
            {
                dgvCart.Rows.RemoveAt(dgvCart.SelectedRows[0].Index);
            }
            else
            {
                MessageBox.Show("Please select an item in the cart to remove!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            if (cartTable.Rows.Count == 0)
            {
                MessageBox.Show("Cart is empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
        
                using (SqlTransaction transaction = conn.BeginTransaction())
                {
                    try
                    {
                      
                        decimal grandTotal = 0;
                        foreach (DataRow row in cartTable.Rows)
                        {
                            grandTotal += Convert.ToDecimal(row["Total"]);
                        }

                        string insertSaleQuery = "INSERT INTO Sales (SaleDate, TotalAmount) OUTPUT INSERTED.SaleID VALUES (@SaleDate, @TotalAmount)";
                        int saleId = 0;

                        using (SqlCommand cmdSale = new SqlCommand(insertSaleQuery, conn, transaction))
                        {
                            cmdSale.Parameters.AddWithValue("@SaleDate", DateTime.Now);
                            cmdSale.Parameters.AddWithValue("@TotalAmount", grandTotal);

                            saleId = (int)cmdSale.ExecuteScalar();
                        }

                        // ៣. Loop បញ្ចូលទំនិញនីមួយៗពី cartTable ចូលទៅក្នុងតារាង SaleDetails
                        foreach (DataRow row in cartTable.Rows)
                        {
                            string insertDetailQuery = "INSERT INTO SaleDetails (SaleID, ProductID, Quantity, Price, Total) VALUES (@SaleID, @ProductID, @Quantity, @Price, @Total)";

                            using (SqlCommand cmdDetail = new SqlCommand(insertDetailQuery, conn, transaction))
                            {
                                cmdDetail.Parameters.AddWithValue("@SaleID", saleId);
                                cmdDetail.Parameters.AddWithValue("@ProductID", Convert.ToInt32(row["ProductId"]));
                                cmdDetail.Parameters.AddWithValue("@Quantity", Convert.ToInt32(row["Qty"]));
                                cmdDetail.Parameters.AddWithValue("@Price", Convert.ToDecimal(row["Price"]));
                                cmdDetail.Parameters.AddWithValue("@Total", Convert.ToDecimal(row["Total"]));

                                cmdDetail.ExecuteNonQuery();
                            }
                        }

                     
                        transaction.Commit();

                        MessageBox.Show("Payment Successful and Saved to Database!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                     
                        cartTable.Clear();
                    }
                    catch (Exception ex)
                    {
                    
                        transaction.Rollback();
                        MessageBox.Show("Payment failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void dgvCart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}