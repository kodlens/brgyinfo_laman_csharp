using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//use mysql dll
using MySql.Data.MySqlClient;
//add also the System.windows.forms so we can use DataGridView Object
using System.Windows.Forms;
using System.Data;

namespace BarangayInformation
{
    class Role
    {
        MySqlConnection con;
        MySqlCommand cmd;
        string query;

        //property of WaterSources Class
        //usually your properties are the column name from database
        public string role { set; get; }



        public int save()
        {
            int i = 0; //instead void, i use int to add some remarks when inserting to database, default 0, means failed.

            //instantation of class will use the new keyword
            con = Connection.con(); 
            con.Open(); 
            query = "INSERT INTO roles SET role=?n"; 
            cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("?n", this.role); 
            i = cmd.ExecuteNonQuery(); 
            cmd.Dispose(); 
            con.Close();
            con.Dispose();
            return i;
        }

        public int update(int id)
        {
            int i = 0;
            //we will change this void into int like save() method
            con = Connection.con();
            con.Open();
            query = "UPDATE roles SET role=?n WHERE water_source_id = ?id";
            cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("?n", this.role);
            cmd.Parameters.AddWithValue("?id", id);
            i = cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
            con.Dispose();
            return i;
        }

        public int delete(int id)
        {
            int i = 0;
            //we will change this void into int like save() method
            con = Connection.con();
            con.Open();
            query = "DELETE FROM roles WHERE role_id = ?id";
            cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("?id", id);
            i = cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
            con.Dispose();
            return i;
        }

        //by calling the System.Windows.Form, we can use the DataGridView Object here
        public void tableData(DataGridView grid, string key)
        {
            con = Connection.con();
            con.Open();
            query = "SELECT * FROM roles WHERE role LIKE ?key";
            cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("?key", key + "%");
            DataTable dt = new DataTable();
            MySqlDataAdapter adptr = new MySqlDataAdapter(cmd);
            adptr.Fill(dt);

            adptr.Dispose();
            cmd.Dispose();
            con.Close();
            con.Dispose();

            //assign data to grid
            grid.AutoGenerateColumns = false;
            grid.DataSource = dt;
        }

        //subject for changes, depends on how we implement the searching
        public void getData(int id)
        {
            con = Connection.con();
            con.Open();
            query = "SELECT * FROM roles WHERE role_id = ?id";
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
                this.role = Convert.ToString(dt.Rows[0]["role"]);
            }
        }

        public void loadToComboBox(ComboBox cmb)
        {
            cmb.Items.Clear();
            con = Connection.con();
            con.Open();
            query = "select * from roles order by role asc";
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

        public int getRoleIdByRoleName(MySqlConnection con, string nrole)
        {
            int i = 0;
            query = "select * from roles where role = ?role";
            cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("?role", nrole);
            MySqlDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                i = Convert.ToInt32(dr["role_id"]);
            }
            dr.Close();
            cmd.Dispose();


            return i;
        }


    }
}
