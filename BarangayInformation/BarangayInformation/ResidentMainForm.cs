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
    public partial class ResidentMainForm : Form
    {
        Resident resident;
        
        public ResidentMainForm()
        {
            InitializeComponent();
            resident = new Resident();
        }

        private void ResidentMainForm_Load(object sender, EventArgs e)
        {
            resident.all(gridResidents);
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResidentAddEditForm frm = new ResidentAddEditForm();
            frm.resident_id = 0;
            frm.ShowDialog();
        }
    }
}