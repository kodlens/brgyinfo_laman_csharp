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
using BarangayInformation.Access_Control;

namespace BarangayInformation
{
    public partial class AccessLevelMainForm : Form
    {
        MySqlConnection con;
        MySqlCommand cmd;
        string query;


        AccessLevel control;

        public AccessLevelMainForm()
        {
            InitializeComponent();
            control = new AccessLevel();
        }

        private void ControlMainForm_Load(object sender, EventArgs e)
        {
            Helper.LoadCmb("select * from roles", cmbRole, 1);
            loadData();
        }

        public void loadData()
        {
            flx.AutoGenerateColumns = false;
            flx.DataSource = control.find(txtName.Text, txtText.Text, cmbRole.Text, txtDesc.Text);
        }

        private void modifyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (flx.Rows.Count > 1)
            {
                if (Box.QBox("Are you sure you want to remove this/these control(s)?"))
                {
                    con = Connection.con();
                    con.Open();

                    foreach (C1.Win.C1FlexGrid.RowCol row in flx.Rows)
                    {
                        if (row.Selected == true)
                        {
                            int id = Convert.ToInt32(flx[row.Index, "access_level_id"]);
                            //int posid = Helper.returnIDperConnection(con, "nposition", "position", position, "positionID");

                            query = "DELETE FROM access_levels WHERE access_level_id=?id";
                            cmd = new MySqlCommand(query, con);

                            cmd.Parameters.AddWithValue("?id", id);
                            cmd.ExecuteNonQuery();
                            cmd.Parameters.Clear();
                        }
                    }


                    cmd.Dispose();
                    con.Close();
                    con.Dispose();


                    Box.InfoBox("Control(s) removed.");
                    loadData();
                }

            }
            else
            {
                Box.WarnBox("No data found!");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(cmbRole.Text))
            {
                Box.WarnBox("Please select role.");
                return;
            }
            BrowseControls frm = new BrowseControls(this);
            frm.role = cmbRole.Text;
            frm.ShowDialog();
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
