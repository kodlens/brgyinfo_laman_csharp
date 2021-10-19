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
    public partial class PetMainForm : Form
    {
        //declaration
        Pet P;
        public PetMainForm()
        {
            InitializeComponent();
            //instantiate
            P = new Pet();

            int roleid = Properties.Settings.Default.role_id;
            ControlHelper.SetupControlAccess(this, contextMenuStrip1, roleid);
        }
        public void loadData()
        {
           P.tableData(grid, txtSearch.Text);
        }

        

        private void PetMainForm_Load(object sender, EventArgs e)
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
                    int id = Convert.ToInt32(grid.SelectedRows[0].Cells["pet_id"].Value);
                    P.delete(id);
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
           PetAddEditForm frm = new PetAddEditForm(); // 
            frm.id = 0;
            frm.ShowDialog();
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            //call and show AddEdit Form
            PetAddEditForm frm = new PetAddEditForm(); // 
            frm.id = 0;
            frm.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (grid.Rows.Count > 0)
            {
                int id = Convert.ToInt32(grid.SelectedRows[0].Cells["pet_id"].Value);
                WaterSourceAddEditForm frm = new WaterSourceAddEditForm();
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
            deleteToolStripMenuItem_Click(sender, e);
        }
    }
}
