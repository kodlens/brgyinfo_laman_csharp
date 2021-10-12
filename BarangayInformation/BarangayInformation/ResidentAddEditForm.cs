using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BarangayInformation
{
    public partial class ResidentAddEditForm : Form
    {
        public int resident_id;


        public ResidentAddEditForm()
        {
            InitializeComponent();
        }

        private void btnDebug_Click(object sender, EventArgs e)
        {

        }

        private void btnNext1_Click(object sender, EventArgs e)
        {
            TabControl1.SelectedTab = tabContactAddress;
        }

        private void ResidentAddEditForm_Load(object sender, EventArgs e)
        {

        }
    }
}
