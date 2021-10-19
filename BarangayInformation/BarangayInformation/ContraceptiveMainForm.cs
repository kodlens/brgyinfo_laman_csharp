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
    public partial class ContraceptiveMainForm : Form
    {
        //declaration
        Contraceptives C;
        public ContraceptiveMainForm()
        {
            InitializeComponent();
            C = new Contraceptives();

            int roleid = Properties.Settings.Default.role_id;
            ControlHelper.SetupControlAccess(this, contextMenuStrip1, roleid);
        }
        public void loadData()
        {
            C.tableData(grid, txtSearch.Text);
        }

        private void ContraceptiveMainForm_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (grid.Rows.Count > 0)
            {
                if (Box.QBox("Are you sure you want to delete this data?"))
                {
                    int id = Convert.ToInt32(grid.SelectedRows[0].Cells["contraceptive_id"].Value);
                    C.delete(id);
                    Box.InfoBox("Data successfully deleted.");
                    loadData();
                }
            }
            else
            {
                Box.WarnBox("No data selected.");
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //call and show AddEdit Form
          ContraceptiveAddEditForm frm = new ContraceptiveAddEditForm(); // 
            frm.id = 0;
            frm.ShowDialog();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            newToolStripMenuItem_Click(sender, e);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (grid.Rows.Count > 0)
            {
                int id = Convert.ToInt32(grid.SelectedRows[0].Cells["contraceptive_id"].Value);
                ContraceptiveAddEditForm frm = new ContraceptiveAddEditForm();
                frm.id = id;
                frm.ShowDialog();
            }
            else
            {
                Box.WarnBox("No data selected.");
            }

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (grid.Rows.Count > 0) //if no rows or data in datagrid
            {
                DialogResult dg = MessageBox.Show("Are you sure you want to delete this row?", "DELETE?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dg == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(grid.SelectedRows[0].Cells["contraceptive_id"].Value);
                    C.delete(id);
                    Box.InfoBox("Successfully deleted.");
                    loadData();
                }
            }
            else
            {
                Box.WarnBox("No data selected.");
            }
        }
    }
}
