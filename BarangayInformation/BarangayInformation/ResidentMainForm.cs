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
    public partial class ResidentMainForm : Form
    {
        Resident resident;
        
        public ResidentMainForm()
        {
            InitializeComponent();
            resident = new Resident();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            bool bHandled = false;
            // switch case is the easy way, a hash or map would be better, 
            // but more work to get set up.
            switch (keyData)
            {
                case Keys.F1:
                    // do whatever
                    bHandled = true;
                    newToolStripMenuItem_Click(null, null);
                    break;
                case Keys.F2:
                    bHandled = true;
                    editToolStripMenuItem_Click(null, null);
                    break;
                case Keys.Delete:
                    deleteToolStripMenuItem_Click(null, null);
                    break;
            }
            return bHandled;
        }
        public void loadData()
        {
            if (rbLastName.Checked)
            {
                resident.find(flx, this.txtSearch.Text, "", "");
            }
            if (rbFirstName.Checked)
            {
                resident.find(flx, "", txtSearch.Text, "");
            }
            if (rbResidentNumber.Checked)
            {
                resident.find(flx, "",  "", txtSearch.Text);
            }

        }
        private void ResidentMainForm_Load(object sender, EventArgs e)
        {

            int roleid = Properties.Settings.Default.role_id;
            ControlHelper.SetupControlAccess(this, contextMenuStrip1, roleid);


            this.rbLastName.Checked = true;
            loadData();
        }


 

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResidentAddEditForm frm = new ResidentAddEditForm(this);
            frm.resident_id = 0;
            frm.ShowDialog();
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                loadData();
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(this.flx.Rows.Count > 1)
            {
                int id = Convert.ToInt32(flx[flx.RowSel, "resident_id"]);
                ResidentAddEditForm frm = new ResidentAddEditForm(this);
                frm.resident_id = id;
                frm.ShowDialog();
            }
            else
            {
                Box.ErrBox("No data found.");
            }
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(flx.Rows.Count > 1)
            {
                int id = Convert.ToInt32(flx[flx.RowSel, "resident_id"]);
                if(Box.QBox("Are you sure you want to delete this data?"))
                {
                    resident.delete(id);
                    Box.InfoBox("Successfully deleted.");
                    loadData();
                }
            }
            else
            {
                Box.ErrBox("No data found.");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            newToolStripMenuItem_Click(sender, e);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            editToolStripMenuItem_Click(sender, e);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            deleteToolStripMenuItem_Click(sender, e);
        }
    }
}