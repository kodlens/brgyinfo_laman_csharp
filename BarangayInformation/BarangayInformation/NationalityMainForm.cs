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
    public partial class NationalityMainForm : Form
    {
        Nationality n;

        public NationalityMainForm()
        {
            InitializeComponent();

            n = new Nationality();
        }

        public void loadData()
        {
            n.find(this.gridNationality, txtSearch.Text);
            //2 param, 1 for grid, 1 for the key for search
        }
        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void NationalityMainForm_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //call and show AddEdit Form
            NationalityAddEditForm frm = new NationalityAddEditForm();
            frm.id = 0;
            frm.ShowDialog();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (gridNationality.Rows.Count > 0) //if no rows or data in datagrid
            {
                DialogResult dg = MessageBox.Show("Are you sure you want to delete this row?", "DELETE?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dg == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(gridNationality.SelectedRows[0].Cells["nationality_id"].Value);
                    n.delete(id);
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
            if (gridNationality.Rows.Count > 0)
            {
                int id = Convert.ToInt32(gridNationality.SelectedRows[0].Cells["nationality_id"].Value);
                NationalityAddEditForm frm = new NationalityAddEditForm();
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

        private void gridNationality_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
