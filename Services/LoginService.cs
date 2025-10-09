using StockMate.Database;
using StockMate.Forms;
using Syncfusion.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockMate.Services
{
    public class LoginService
    {
        public void Login(string username, string password, Form form)
        {
            using (Microsoft.Data.SqlClient.SqlConnection conn = new Microsoft.Data.SqlClient.SqlConnection(Properties.Settings.Default.ConnectionString))
            {
                string loginQuery = "SELECT COUNT (*) FROM Users WHERE Username = @username AND Password = @password";

                using (Microsoft.Data.SqlClient.SqlCommand cmd = new Microsoft.Data.SqlClient.SqlCommand(loginQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    conn.Open();
                    int success = (int)cmd.ExecuteScalar();
                    conn.Close();

                    if (success == 1)
                    {
                        MessageBoxAdv.Show("Login Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        form.Hide();
                        new frmMain().ShowDialog();
                        form.Close();
                    }
                    else
                    {
                        MessageBoxAdv.Show("Username or password is incorrect. Please try again.", "Incorrect Credentials", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
    }
}
