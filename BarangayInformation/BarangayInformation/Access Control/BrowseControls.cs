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


using BarangayInformation.Class;


namespace BarangayInformation.Access_Control
{
    public partial class BrowseControls : Form
    {
        MySqlConnection con;
        MySqlCommand cmd;
        string query;

        AccessLevelMainForm _frm;

        public string role;

        public BrowseControls(AccessLevelMainForm _frm)
        {
            InitializeComponent();
            this._frm = _frm;
        }

        private void BrowseControls_Load(object sender, EventArgs e)
        {
            try
            {
                LoadData();
            }
            catch (Exception er)
            {
                Box.ErrBox(er.Message);
                //throw;
            }
        }

        public void LoadData()
        {
            try
            {
                con = Connection.con();
                con.Open();
                query = @"
                        SELECT * FROM 
                            (
	                            SELECT * FROM controls a WHERE a.control_id NOT IN 
	                            (
		                            SELECT aa.control_id FROM access_levels aa
		                            JOIN roles bb ON aa.role_id = bb.role_id
		                            WHERE bb.role = ?role
                                )
                        ) AS a
                        WHERE a.control_name LIKE ?cname
                        AND a.control_text LIKE ?ctext
                        AND a.description LIKE ?cdesc";
                cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?role", role);
                cmd.Parameters.AddWithValue("?cname", txtName.Text + "%");
                cmd.Parameters.AddWithValue("?ctext", txtText.Text + "%");
                cmd.Parameters.AddWithValue("?cdesc", txtdesc.Text + "%");
                DataTable dt = new DataTable();
                MySqlDataAdapter adptr = new MySqlDataAdapter(cmd);
                adptr.Fill(dt);
                adptr.Dispose();
                cmd.Dispose();
                con.Close();

                this.flxControls.AutoGenerateColumns = false;
                this.flxControls.DataSource = dt;
            }
            catch (Exception er)
            {
                Box.ErrBox(er.Message);
                //throw;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (flxControls.Rows.Count > 1)
            {
                con = Connection.con();
                con.Open();

                int role_id = Role.getRoleIdByRoleName(con, role);

                foreach (C1.Win.C1FlexGrid.RowCol row in flxControls.Rows)
                {
                    if (row.Selected == true)
                    {
                        int id = Convert.ToInt32(flxControls[row.Index, "control_id"]);
   
                        query = "INSERT INTO access_levels (role_id, control_id) VALUES (?roleid, ?ctrlid)";
                        cmd = new MySqlCommand(query, con);
                        cmd.Parameters.AddWithValue("?roleid", role_id);
                        cmd.Parameters.AddWithValue("?ctrlid", id);
                        cmd.ExecuteNonQuery();
                        cmd.Parameters.Clear();
                    }
                }


                cmd.Dispose();
                con.Close();
                con.Dispose();


                Box.InfoBox("Controls Successfully Added.");
                LoadData();
                _frm.loadData();
            }
            else
            {
                Box.WarnBox("No data found.");
            }
        }
    }
}
