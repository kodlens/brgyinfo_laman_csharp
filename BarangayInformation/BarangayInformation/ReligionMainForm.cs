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
    public partial class ReligionMainForm : Form
    {
        Religion r;

        public ReligionMainForm()
        {
            InitializeComponent();
            r = new Religion();

            int roleid = Properties.Settings.Default.role_id;
            ControlHelper.SetupControlAccess(this, contextMenuStrip1, roleid);
        }

        public void loadData()
        {
            r.TD(gridreligion, txtSearch.Text);
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadData();
        }
       private void ReligionMainForm_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //call and show AddEdit Form
            ReligionAddEditForm frm = new ReligionAddEditForm();
            frm.id = 0;
            frm.ShowDialog();
        }
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (gridreligion.Rows.Count > 0)//if no rows or data in datagrid
            {
              
                {
                    DialogResult dg = MessageBox.Show("Are you sure you want to delete this row?", "DELETE?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dg == DialogResult.Yes)
                    {
                        int id = Convert.ToInt32(gridreligion.SelectedRows[0].Cells["religion_id"].Value);
                        r.delete(id);
                        Box.InfoBox("Successfully deleted.");
                        loadData();
                    }

                    else
                    {
                        Box.WarnBox("No data selected.");
                    }
                }

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
            if (gridreligion.Rows.Count > 0)
            {
                int id = Convert.ToInt32(gridreligion.SelectedRows[0].Cells["religion_id"].Value);
                ReligionAddEditForm frm = new ReligionAddEditForm();
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

