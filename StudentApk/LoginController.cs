using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace StudentApk
{
    class LoginController
    {
        public static void login(LoginModel loginmodel)
        {
            try
            {
                string query = "SELECT username,password FROM t_users WHERE username = @username AND password = @password";
                MySqlConnection con = Database.getConnection();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@username", loginmodel.Username);
                cmd.Parameters.AddWithValue("@password", loginmodel.Password);
                cmd.ExecuteNonQuery();

                MySqlDataReader data;
                data = cmd.ExecuteReader();

                if (data.Read())
                {
                    Login login = new Login();
                    login.Hide();
                    new Main(loginmodel.Username).Show();
                }
                else
                {
                    MessageBox.Show("The user does not exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("An error occured\n" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
