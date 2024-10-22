﻿using System;
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
    public partial class CountryMainForm : Form
    {
        Country c;

        public CountryMainForm()
        {
            InitializeComponent();
            c = new Country();

            int roleid = Properties.Settings.Default.role_id;
            ControlHelper.SetupControlAccess(this, contextMenuStrip1, roleid);
        }

        public void loadData()
        {
            c.TD(grid, txtSearch.Text);
        }
        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void CountryMainForm_Load(object sender, EventArgs e)
        {
            loadData();
        }
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //call and show AddEdit Form
            CountryAddEditForm frm= new CountryAddEditForm(this);
            frm.id = 0;
            frm.ShowDialog();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (grid.Rows.Count > 0)//if no rows or data in datagrid
            {

                {
                    DialogResult dg = MessageBox.Show("Are you sure you want to delete this row?", "DELETE?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dg == DialogResult.Yes)
                    {
                        int id = Convert.ToInt32(grid.SelectedRows[0].Cells["country_id"].Value);
                        c.delete(id);
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
            if (grid.Rows.Count > 0)
            {
                int id = Convert.ToInt32(grid.SelectedRows[0].Cells["country_id"].Value);
                CountryAddEditForm frm = new CountryAddEditForm(this);
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
        
    

