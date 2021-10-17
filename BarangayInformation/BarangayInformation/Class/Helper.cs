using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BarangayInformation
{
    class Helper
    {


        public static void LoadCmb(string query, ComboBox cmb, int index)
        {
            MySqlConnection con;
            MySqlCommand cmd;
            // string query;
            cmb.Items.Clear();
            con = Connection.con();
            con.Open();
            cmd = new MySqlCommand(query, con);
            MySqlDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmb.Items.Add(Convert.ToString(dr[index]));
            }
            dr.Close();
            cmd.Dispose();
            con.Close();
            con.Dispose();
        }


    }
}
