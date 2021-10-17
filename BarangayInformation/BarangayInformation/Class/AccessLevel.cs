using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using C1.Win;


namespace BarangayInformation.Class
{
    class AccessLevel
    {
        MySqlConnection con;
        MySqlCommand cmd;
        string query;


        public DataTable find(string name, string text, string role, string desc)
        {
            con = Connection.con();
            con.Open();
            query = @"SELECT a.access_level_id,
                        a.role_id, b.role, a.control_id,
                        c.control_name, c.control_text, c.description, c.class_name
                        FROM access_levels a
                        JOIN roles b ON a.role_id = b.role_id
                        JOIN controls c ON a.control_id = c.control_id
                        WHERE control_name like ?cname and control_text like ?ctext and role like ?role and description like ?desc";
            cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("?cname", name + "%");
            cmd.Parameters.AddWithValue("?ctext", text + "%");
            cmd.Parameters.AddWithValue("?role", role + "%");
            cmd.Parameters.AddWithValue("?desc", desc + "%");
            DataTable dt = new DataTable();
            MySqlDataAdapter adptr = new MySqlDataAdapter(cmd);
            adptr.Fill(dt);
            adptr.Dispose();
            cmd.Dispose();
            con.Close();
            con.Dispose();

            return dt;
        }
    }
}
