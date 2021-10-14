using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//using mysql.dll
using MySql.Data.MySqlClient;

//add also the System.windows.forms so we can use DataGridView Object
using System.Windows.Forms;
using System.Data;

namespace BarangayInformation
{
    class Religion
    {
        //declare always this 3 var
        MySqlConnection con;
        MySqlCommand cmd;
        string query;

        public string religion { set; get; }

        public int save()
        {
            int i = 0;
            con = Connection.con(); //another type of insantiation of object, the new keyword can be found in Connection.cs
            con.Open(); //open the connection
            query = "INSERT INTO religions SET religion=?n"; //query for database // INSERT INTO tablename SET columname = 'value'
            cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("?n", this.religion); //you can use this keyword, or remove the this keyword
            i = cmd.ExecuteNonQuery(); //cmd.executenonquery since the query is not a select statement, it is an insert statement
            //assign variable i. if insert is successfull, it will return 1, else 0.
            cmd.Dispose(); //dispose the cmd object variable to free memory
            con.Close(); //close the connection , detached the connection from database to free connections
            con.Dispose(); //usually garbage collector of the language will auto dispose objects but i prefer disposing manually to avoid any future problem
            return i;
        }

        public int update(int id)
        {
            int i = 0;
            //we will change this void into int like save() method
            con = Connection.con();
            con.Open();
            query = "UPDATE religion SET religion=?n WHERE religion_id = ?id";
            cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("?n", this.religion);
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
            query = "DELETE FROM religions WHERE religion_id = ?id";
            cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("?id", id);
            i = cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
            con.Dispose();
            return i;
        }

        //by calling the System.Windows.Form, we can use the DataGridView Object here
        public void TD(DataGridView grid, string key)
        {
            con = Connection.con();
            con.Open();
            query = "SELECT * FROM religions WHERE religion LIKE ?key";
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
            query = "SELECT * FROM religions WHERE religion_id = ?id";
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
                this.religion = Convert.ToString(dt.Rows[0]["religion"]);
            }
        }
    }
}
