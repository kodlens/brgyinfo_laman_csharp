using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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

        public void loadToComboBox(ComboBox cmb)
        {
            con = Connection.con();
            con.Open();

            cmb.Items.Clear();
            query = @"SELECT * FROM roles ORDER BY role ASC"; //query for database
            cmd = new MySqlCommand(query, con);
            MySqlDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmb.Items.Add(Convert.ToString(dr["role"]));
            }
            dr.Close();
            cmd.Dispose();
            con.Close();
            con.Dispose();
        }

    }
}
