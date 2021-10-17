using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace BarangayInformation.Class
{
    class Login
    {

        MySqlCommand cmd;
        MySqlConnection con;
        string query;

        public bool auth(string username, string password)
        {
            bool flag = false;
            try
            {
                con = Connection.con();
                con.Open();
                query = @"SELECT * FROM users a JOIN roles b ON a.role_id = b.role_id
                            WHERE a.username=?user AND a.password=sha1(?pass) LIMIT 1";
                cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?user", username);
                cmd.Parameters.AddWithValue("?pass", password);
                MySqlDataReader dr;
                dr = cmd.ExecuteReader();
                //flag = dr.Read();
                while(dr.Read())
                {
                    flag = true;
                    Properties.Settings.Default.user_id = Convert.ToInt32(dr["user_id"]);
                    Properties.Settings.Default.username = Convert.ToString(dr["username"]);
                    Properties.Settings.Default.lname = Convert.ToString(dr["lname"]);
                    Properties.Settings.Default.fname = Convert.ToString(dr["fname"]);
                    Properties.Settings.Default.mname = Convert.ToString(dr["mname"]);
                    Properties.Settings.Default.role_id = Convert.ToInt32(dr["role_id"]);
                    Properties.Settings.Default.role = Convert.ToString(dr["role"]);

                    Properties.Settings.Default.Save();
                }
                dr.Close();
                cmd.Dispose();
                con.Close();
                con.Dispose();
                return flag;
            }
            catch (Exception)
            {

                return false;
            }
            
        }
    }
}
