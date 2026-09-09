using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Product_Management_System.Data
{
    public partial class Database : Form
    {
        public Database()
        {
            InitializeComponent();
        }

        public static string ConnectionString = @"Server=MSI\SQLEXPRESS01;Database=ProductManagementDB;Integrated Security=true;";

       
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(ConnectionString);
        }

        private void Database_Load(object sender, EventArgs e)
        {

        }
    }
}