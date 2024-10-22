﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace BarangayInformation.Class

{
    class Contraceptives
    {
        MySqlCommand cmd;
        MySqlConnection con;
        string query;
        //property of WaterSources Class
        //usually your properties are the column name from database
        public string contraceptive { set; get; }

        public int save()
        {
            int i = 0; //instead void, i use int to add some remarks when inserting to database, default 0, means failed.

            //instantation of class will use the new keyword
            con = Connection.con(); //another type of insantiation of object, the new keyword can be found in Connection.cs
            con.Open(); //open the connection
            query = "INSERT INTO contraceptives SET contraceptive=?n"; //query for database // INSERT INTO tablename SET columname = 'value'
            cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("?n", this.contraceptive); //you can use this keyword, or remove the this keyword
            i = cmd.ExecuteNonQuery(); //cmd.executenonquery since the query is not a select statement, it is an insert statement
            //assign variable i. if insert is successfull, it will return 1, else 0.
            cmd.Dispose(); //dispose the cmd object variable to free memory
            con.Close(); //close the connection , detached the connection from database to free connections
            con.Dispose(); //usually garbage collector of the language will auto dispose objects but i prefer disposing manually to avoid any future problem
            return i;
            //KLARO EMJEEEH!!!
        }

        public int update(int id)
        {
            int i = 0;
            //we will change this void into int like save() method
            con = Connection.con();
            con.Open();
            query = "UPDATE contraceptives SET contraceptive=?n WHERE contraceptive_id = ?id";
            cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("?n", this.contraceptive);
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
            query = "DELETE FROM contraceptives WHERE contraceptive_id = ?id";
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
            query = "SELECT * FROM contraceptives WHERE contraceptive LIKE ?key";
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
            query = "SELECT * FROM contraceptives WHERE contraceptive_id = ?id";
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
                this.contraceptive = Convert.ToString(dt.Rows[0]["contraceptive"]);
            }
        }

        public void fillCmb(MySqlConnection con, ComboBox cmb)
        {
            cmb.Items.Clear();
            string n = "select * from contraceptives order by contraceptive asc";
            cmd = new MySqlCommand(n, con);
            MySqlDataReader dr;
            dr = cmd.ExecuteReader();

            //'subject for refactoring;
            while (dr.Read())
            {
                cmb.Items.Add(Convert.ToString(dr["contraceptive"]));
            }

            dr.Dispose();
            cmd.Dispose();
        }

    }
    
}


