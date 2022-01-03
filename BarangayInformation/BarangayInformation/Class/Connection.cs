using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace BarangayInformation
{
    class Connection
    {

        public static MySqlConnection con()
        {
            string[] lines = System.IO.File.ReadAllLines(Application.StartupPath + "/config.txt");

            return new MySqlConnection("server=" + lines[1]+ "; database=brgyinfo_laman;user=root;password=''");
        }
    }
}
