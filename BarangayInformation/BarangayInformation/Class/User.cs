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
using C1.Win.C1FlexGrid;



namespace BarangayInformation.Class
{
    class User : Role
    {
 
        MySqlConnection con;
        MySqlCommand cmd;
        string query;

        //property of Nationality Class
        //usually your properties are the column name from database
        public string username { set; get; }
        public string password { set; get; }
        public string lname { set; get; }
        public string fname { set; get; }
        public string mname { set; get; }
        public string sex { set; get; }
        public string role { set; get; }


        public int save()
        {
            int i = 0;
            con = Connection.con();
            con.Open(); 

            int role_id = getRoleIdByRoleName(con, this.role); //get role id by role name;

            query = @"INSERT INTO users SET username=?user, password=sha1(?pwd), lname=?lname, fname=?fname, mname=?mname,
                    sex=?sex, role_id=?roleid"; //query for database
            cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("?user", this.username);
            cmd.Parameters.AddWithValue("?pwd", this.password);
            cmd.Parameters.AddWithValue("?lname", this.lname);
            cmd.Parameters.AddWithValue("?fname", this.fname);
            cmd.Parameters.AddWithValue("?mname", this.mname);
            cmd.Parameters.AddWithValue("?sex", this.sex);
            cmd.Parameters.AddWithValue("?roleid", role_id);
            i = cmd.ExecuteNonQuery(); 
            cmd.Dispose(); 
            con.Close();
            con.Dispose();
            return i;
        }

        public int update(int id)
        {
            int i = 0;
            con = Connection.con();
            con.Open();

            int role_id = getRoleIdByRoleName(con, this.role); //get role id by role name;

            query = @"UPDATE users SET username=?user, lname=?lname, fname=?fname, mname=?mname,
                    sex=?sex, role_id=?roleid WHERE user_id = ?id"; //query for database
            cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("?user", this.username);
          
            cmd.Parameters.AddWithValue("?lname", this.lname);
            cmd.Parameters.AddWithValue("?fname", this.fname);
            cmd.Parameters.AddWithValue("?mname", this.mname);
            cmd.Parameters.AddWithValue("?sex", this.sex);
            cmd.Parameters.AddWithValue("?roleid", role_id);
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
            query = "DELETE FROM users WHERE user_id = ?id";
            cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("?id", id);
            i = cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
            con.Dispose();
            return i;
        }
        public void find(C1FlexGrid grid, string username, string search_lname)
        {
            con = Connection.con();
            con.Open();
            query = "SELECT * FROM users WHERE username LIKE ?user AND lname LIKE ?lname";
            cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("?user", username + "%");
            cmd.Parameters.AddWithValue("?lname", search_lname + "%");
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
        public void getData(int id)
        {
            con = Connection.con();
            con.Open();
            query = "SELECT a.*, b.role FROM users a join roles b on a.role_id = b.role_id WHERE user_id = ?id";
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
                this.username = Convert.ToString(dt.Rows[0]["username"]);
                this.lname = Convert.ToString(dt.Rows[0]["lname"]);
                this.fname = Convert.ToString(dt.Rows[0]["fname"]);
                this.mname = Convert.ToString(dt.Rows[0]["mname"]);
                this.sex = Convert.ToString(dt.Rows[0]["sex"]);
                this.role = Convert.ToString(dt.Rows[0]["role"]);
            }
        }



        public bool isExistUsername(int id, string u)
        {
            bool flag = false;
            con = Connection.con();
            con.Open();
            if(id > 0)
            {
                query = "select * from users where username = ?user and user_id != ?id";
                cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?user", u);
                cmd.Parameters.AddWithValue("?id", id);
            }
            else
            {
                query = "select * from users where username = ?user";
                cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?user", u);
            }

            MySqlDataReader dr;
            dr = cmd.ExecuteReader();
            flag = dr.Read();
            dr.Close();
            cmd.Dispose();
            con.Close();
            con.Dispose();
            return flag;
        }

    }
}

