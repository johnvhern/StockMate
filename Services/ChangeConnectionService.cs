using Microsoft.Data.SqlClient;
using StockMate.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockMate.Services
{
    public class ChangeConnectionService
    {
        public bool SaveConnection(string server, string database, string username, string password)
        {
            string connectionString = $"Server={server};Database={database};User Id={username};Password={password};Trust Server Certificate=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    MessageBox.Show("Connection succeeded!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DatabaseConnection.ConnectionString = connectionString;
                    Properties.Settings.Default.ConnectionString = connectionString;
                    Properties.Settings.Default.Save(); // saves to user config file
                    return true;
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Connection failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }
    }
}
