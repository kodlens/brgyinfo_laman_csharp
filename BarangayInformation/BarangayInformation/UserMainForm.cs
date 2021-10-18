using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BarangayInformation.Class;

namespace BarangayInformation
{
    public partial class UserMainForm : Form
    {
        User u;
        public UserMainForm()
        {
            InitializeComponent();
            u = new User();

            ControlHelper.SetupControlAccess(this, contextMenuStrip1, Properties.Settings.Default.role_id);


        }
        public void loadData()
        {
            u.find(this.flx, txtSearchUsername.Text, txtSearchLastname.Text);
            //2 param, 1 for grid, 1 for the key for search
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void UserMainForm_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserAddEditForm frm = new UserAddEditForm(this);
            frm.id = 0;
            frm.ShowDialog();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (flx.Rows.Count > 1) //if no rows or data in datagrid
            {
                DialogResult dg = MessageBox.Show("Are you sure you want to delete this row?", "DELETE?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dg == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(flx[flx.RowSel,"user_id"]);
                    u.delete(id);
                    Box.InfoBox("Successfully deleted.");
                    loadData();
                }
            }
            else
            {
                Box.WarnBox("No data selected.");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            newToolStripMenuItem_Click(sender, e);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            deleteToolStripMenuItem_Click(sender, e);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (flx.Rows.Count > 1)
            {
                int id = Convert.ToInt32(flx[flx.RowSel, "user_id"]);
                UserAddEditForm frm = new UserAddEditForm(this);
                frm.id = id;
                frm.ShowDialog();
            }
            else
            {
                Box.WarnBox("No data selected.");
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnEdit_Click(sender, e);
        }


    }
}
