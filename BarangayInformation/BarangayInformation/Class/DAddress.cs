using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BarangayInformation.Class
{
    class DAddress
    {

        MySqlConnection con;
        MySqlCommand cmd;
        string query;

  
        public void country(MySqlConnection con, ComboBox cmb)
        {
            cmb.Items.Clear();
            string n = "select * from countries order by country asc";
            cmd = new MySqlCommand(n, con);
            MySqlDataReader dr;
            dr = cmd.ExecuteReader();

            //'subject for refactoring;
            while (dr.Read())
            {
                cmb.Items.Add(Convert.ToString(dr["country"]));
            }

            dr.Dispose();
            cmd.Dispose();
         
        }

        public void country(ComboBox cmb)
        {
            cmb.Items.Clear();
            con = Connection.con();
            con.Open();
            string n = "select * from countries order by country asc";
            cmd = new MySqlCommand(n, con);
            MySqlDataReader dr;
            dr = cmd.ExecuteReader();

            //'subject for refactoring;
            while (dr.Read())
            {
                cmb.Items.Add(Convert.ToString(dr["country"]));
            }
            dr.Dispose();
            cmd.Dispose();
            con.Close();
            con.Dispose();
        }






        public void provinces(MySqlConnection con, string country, ComboBox cmb)
        {
            cmb.Items.Clear();
            query = "SELECT * FROM provinces a JOIN countries b on a.country_id = b.country_id WHERE b.country = ?c order by a.provDesc ASC";
            cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("?c", country);
       
            MySqlDataReader dr;
            dr = cmd.ExecuteReader();
            //'subject for refactoring

            while (dr.Read())
            {
                cmb.Items.Add(Convert.ToString(dr["provDesc"]));
            }
            dr.Dispose();
            cmd.Dispose();
           
        }

        public void provinces(string country, ComboBox cmb)
        {
            con = Connection.con();
            con.Open();
            cmb.Items.Clear();
            query = "SELECT * FROM provinces a JOIN countries b on a.country_id = b.country_id WHERE b.country = ?c order by a.provDesc ASC";
            cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("?c", country);

            MySqlDataReader dr;
            dr = cmd.ExecuteReader();
            //'subject for refactoring

            while (dr.Read())
            {
                cmb.Items.Add(Convert.ToString(dr["provDesc"]));
            }
            dr.Dispose();
            cmd.Dispose();
            con.Close();
            con.Dispose();
        }



        public void cities(MySqlConnection con, string province, ComboBox cmb)
        {
            cmb.Items.Clear();
            query = "SELECT * FROM cities a JOIN provinces b on a.provCode = b.provCode WHERE b.provDesc = ?provdesc order by a.citymunDesc asc";
            cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("?provdesc", province);
            MySqlDataReader dr;
            dr = cmd.ExecuteReader();
            //'subject for refactoring
            while (dr.Read())
            {
                cmb.Items.Add(Convert.ToString(dr["citymunDesc"]));

            }
            dr.Dispose();
            cmd.Dispose();
        }
        public void cities(string province, ComboBox cmb)
        {
            cmb.Items.Clear();
            con = Connection.con();
            con.Open();
            query = "SELECT * FROM cities a JOIN provinces b on a.provCode = b.provCode WHERE b.provDesc = ?provdesc order by a.citymunDesc asc";
            cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("?provdesc", province);
            MySqlDataReader dr;
            dr = cmd.ExecuteReader();
            //'subject for refactoring
            while (dr.Read())
            {
                cmb.Items.Add(Convert.ToString(dr["citymunDesc"]));

            }
            dr.Dispose();
            cmd.Dispose();

            con.Close();
            con.Dispose();
        }


        public void barangays(MySqlConnection con, string province, string city, ComboBox cmb)
        {
            cmb.Items.Clear();
            query = @"SELECT * FROM barangays a JOIN cities b ON a.citymunCode = b.citymunCode
                JOIN provinces c ON b.provCode = c.provCode
                WHERE b.citymunDesc = ?city AND c.provDesc = ?prov";
            cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("?city", city);
            cmd.Parameters.AddWithValue("?prov", province);
            MySqlDataReader dr;
            dr = cmd.ExecuteReader();
            //'subject for refactoring
            while (dr.Read())
            {
                cmb.Items.Add(Convert.ToString(dr["brgyDesc"]));

            }
            dr.Dispose();
            cmd.Dispose();
            
        }
        public void barangays(string province, string city, ComboBox cmb)
        {
            con = Connection.con();
            con.Open();
            cmb.Items.Clear();
            query = @"SELECT * FROM barangays a JOIN cities b ON a.citymunCode = b.citymunCode
                JOIN provinces c ON b.provCode = c.provCode
                WHERE b.citymunDesc = ?city AND c.provDesc = ?prov";
            cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("?city", city);
            cmd.Parameters.AddWithValue("?prov", province);
            MySqlDataReader dr;
            dr = cmd.ExecuteReader();
            //'subject for refactoring
            while (dr.Read())
            {
                cmb.Items.Add(Convert.ToString(dr["brgyDesc"]));

            }
            dr.Dispose();
            cmd.Dispose();

            con.Close();
            con.Dispose();

        }

    }
}
