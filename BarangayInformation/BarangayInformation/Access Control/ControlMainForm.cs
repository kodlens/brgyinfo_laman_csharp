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

namespace BarangayInformation.Access_Control
{
    public partial class ControlMainForm : Form
    {
        NControl c;
        public ControlMainForm()
        {
            InitializeComponent();
            c = new NControl();
        }

        public void loadData()
        {
            flx.AutoGenerateColumns = false;
            flx.DataSource = c.find(txtName.Text, txtText.Text, txtDesc.Text);
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControlAddEditForm frm = new ControlAddEditForm(this);
            frm.id = 0;
            frm.ShowDialog();
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void deleteControlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(flx.Rows.Count > 1)
            {
                if(Box.QBox("Are you sure you want to delete this data?"))
                {
                    int id = Convert.ToInt32(flx[flx.RowSel, "control_id"]);
                    c.delete(id);
                    Box.InfoBox("Data deleted successfully.");
                    loadData();
                }
            }
            else
            {
                Box.WarnBox("No data selected.");
            }
        }

        private void editControlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (flx.Rows.Count > 1)
            { 
                ControlAddEditForm frm = new ControlAddEditForm(this);
                frm.id = Convert.ToInt32(flx[flx.RowSel, "control_id"]);
                frm.ShowDialog();
            }
        }

        private void ControlMainForm_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            addToolStripMenuItem_Click(sender, e);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            editControlToolStripMenuItem_Click(sender, e);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            deleteControlToolStripMenuItem_Click(sender, e);
        }
    }
}
