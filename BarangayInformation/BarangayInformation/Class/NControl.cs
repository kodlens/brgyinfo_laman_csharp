using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;


namespace BarangayInformation.Class
{
    class NControl
    {

        MySqlConnection con;
        MySqlCommand cmd;
        string query;

        public string name { set; get; }
        public string text { set; get; }

        public string desc { set; get; }

        public string class_name { set; get; }


        public int save()
        {
        
            con = Connection.con();
            con.Open();
            query = @"INSERT INTO controls SET control_name=?cname, control_text=?ctext, description=?desc, class_name=?class";
            cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("?cname", this.name);
            cmd.Parameters.AddWithValue("?ctext", this.text);
            cmd.Parameters.AddWithValue("?desc", this.desc);
            cmd.Parameters.AddWithValue("?class", this.class_name);
            //cmd.Parameters.AddWithValue("?id", id);
            int n = cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
            con.Dispose();
            con.Close();
            con.Dispose();
            return n;
        }

        public int update(int id)
        {
            con = Connection.con();
            con.Open();
            query = @"UPDATE controls SET control_name=?cname, control_text=?ctext, description=?desc, class_name=?class WHERE control_id=?id";
            cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("?cname", this.name);
            cmd.Parameters.AddWithValue("?ctext", this.text);
            cmd.Parameters.AddWithValue("?desc", this.desc);
            cmd.Parameters.AddWithValue("?class", this.class_name);
            cmd.Parameters.AddWithValue("?id", id);
            int n = cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
            con.Dispose();
            con.Close();
            con.Dispose();
            return n;
        }


        public void delete(int id)
        {
            con = Connection.con();
            con.Open();
            query = @"DELETE FROM controls WHERE control_id=?id";
            cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("?id", id);
            int n = cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
            con.Dispose();
            con.Close();
            con.Dispose();
        }


        public DataTable find(string name, string text, string desc)
        {
            con = Connection.con();
            con.Open();
            query = @"SELECT * FROM controls
                        WHERE control_name like ?cname and control_text like ?ctext and description like ?desc ORDER BY control_id DESC";
            cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("?cname", name + "%");
            cmd.Parameters.AddWithValue("?ctext", '%' + text + "%");
            cmd.Parameters.AddWithValue("?desc", '%' + desc + "%");
            DataTable dt = new DataTable();
            MySqlDataAdapter adptr = new MySqlDataAdapter(cmd);
            adptr.Fill(dt);
            adptr.Dispose();
            cmd.Dispose();
            con.Close();
            con.Dispose();

            return dt;
        }

        public void getData(int id)
        {
            con = Connection.con();
            con.Open();
            query = @"SELECT * FROM controls
                        WHERE control_id = ?id";
            cmd = new MySqlCommand(query, con);
   
            cmd.Parameters.AddWithValue("?id", id);
            DataTable dt = new DataTable();
            MySqlDataAdapter adptr = new MySqlDataAdapter(cmd);
            adptr.Fill(dt);
            adptr.Dispose();
            cmd.Dispose();
            con.Close();
            con.Dispose();

            if (dt.Rows.Count > 0)
            {
                this.name = Convert.ToString(dt.Rows[0]["control_name"]);
                this.text = Convert.ToString(dt.Rows[0]["control_text"]);
                this.desc = Convert.ToString(dt.Rows[0]["description"]);
                this.class_name = Convert.ToString(dt.Rows[0]["class_name"]);
            }
        }


        public bool isExist(string n, string cname, int id)
        {
            bool flag = false;
            con = Connection.con();
            con.Open();

            if(id> 0)
            {
                //editmode
                query = @"SELECT * FROM controls
                        WHERE control_name = ?n and class_name = ?cname AND control_id != ?id";
                cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?n", n);
                cmd.Parameters.AddWithValue("?cname", n);
                cmd.Parameters.AddWithValue("?id", id);
            }
            else
            {
                //insert mode
                query = @"SELECT * FROM controls
                        WHERE control_name = ?n and class_name = ?cname";
                cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?n", n);
                cmd.Parameters.AddWithValue("?cname", n);
            }

            MySqlDataReader dr;
            dr = cmd.ExecuteReader();
            flag = dr.Read();
            cmd.Dispose();
            con.Close();
            con.Dispose();
            return flag;
        }


    }
}
