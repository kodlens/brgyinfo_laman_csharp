using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using BarangayInformation.Reports;



namespace BarangayInformation
{
    public partial class ResidentReportForm : Form
    {
        MySqlConnection con;
        MySqlCommand cmd;
        string query;

        public long id;



        public ResidentReportForm()
        {
            InitializeComponent();
        }


        void loadReport()
        {
            //get residents by ID
            query = "proc_residents";
            con = Connection.con();
            con.Open();
            cmd = new MySqlCommand(query, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("?vid", id);
            MySqlDataAdapter adptr = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adptr.Fill(dt);
            adptr.Dispose();
            cmd.Dispose();
           
            //git siblings by resident
            query = "proc_siblings";
            con = Connection.con();
            con.Open();
            cmd = new MySqlCommand(query, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("?vid", id);
            adptr = new MySqlDataAdapter(cmd);
            DataTable dtSiblings = new DataTable();
            adptr.Fill(dtSiblings);
            adptr.Dispose();
            cmd.Dispose();
            con.Close();
            con.Dispose();


            ResidentReport rpt = new ResidentReport();
            rpt.SetDataSource(dt);
            rpt.Subreports[0].SetDataSource(dtSiblings);
          
            crystalReportViewer1.ReportSource = rpt;
        }

        private void ResidentReportForm_Load(object sender, EventArgs e)
        {
            try
            {
                loadReport();
            }
            catch (Exception err)
            {
                Box.ErrBox(err.Message);
            }
        }
    }
}
