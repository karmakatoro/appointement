using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace StudentApk
{
    class Database
    {
        public static MySqlConnection getConnection()
        {
            string query = "datasource=localhost;port=3306;username=root;password=;database=db_doctor";
            MySqlConnection con = new MySqlConnection(query);
            try
            {
                con.Open();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Could not connect to the database\n" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return con;
        }
    }
}
