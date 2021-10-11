using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace BarangayInformation
{
    class Connection
    {

        public static MySqlConnection con()
        {
            return new MySqlConnection("server=localhost; database=brgy_info;user=root;password=''");
        }
    }
}
