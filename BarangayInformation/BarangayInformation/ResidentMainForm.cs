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
            this.rbLastName.Checked = true;
            loadData();
        }


 

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResidentAddEditForm frm = new ResidentAddEditForm();
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
    }
}