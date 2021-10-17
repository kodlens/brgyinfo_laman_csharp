using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace BarangayInformation.Class
{
    class Role
    {

        MySqlCommand cmd;
        MySqlConnection con;
        string query;



        public static int getRoleIdByRoleName(MySqlConnection con, string roleName)
        {
            int flag = 0;
            //MySqlConnection con;
            MySqlCommand cmd;
            //con = Connection.con();
            //con.Open();
            cmd = new MySqlCommand("SELECT * FROM roles WHERE role = ?role", con);
            cmd.Parameters.AddWithValue("?role", roleName);
            MySqlDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                flag = Convert.ToInt32(dr["role_id"]);
            }

            dr.Close();
            cmd.Dispose();
            // con.Close();
            return flag;
        }

    }
}
