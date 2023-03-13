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
        public int login(LoginModel loginmodel)
        {
            int value = 0;
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
                    value = 1;
                }
                else
                {
                    MessageBox.Show("Invalid user name or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    value = 0;
                }
            }
            catch (MySqlException ex)
            {

                MessageBox.Show("MySql error\n"+ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
                
            return value;
            }
    }
}
