using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

using BarangayInformation.Access_Control;
using BarangayInformation.Class;

namespace BarangayInformation
{
    public partial class Mainform : Form
    {
        MySqlConnection con;
        MySqlCommand cmd;

        LoginForm _frm;
        public Mainform(LoginForm _frm)
        {
            InitializeComponent();

            this._frm = _frm;
        }

        //private void openForm(Form frm)
        //{
        //    foreach (Form form in Application.OpenForms)
        //    {
        //        if (form.GetType() == typeof(Form))
        //        {
        //            form.Activate();
        //            return;
        //        }
        //    }

        //    Form frm = new ;
        //    frm.Show();

        //}

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(ResidentMainForm))
                {
                    form.Activate();
                    return;
                }
            }

            Form frm = new ResidentMainForm();
            frm.Show();

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            DialogResult diagresult = MessageBox.Show("Are you sure you want to logout?", "LOGOUT?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(diagresult == DialogResult.Yes)
            {
                this.Close();
            }
           
        }

        private void Mainform_FormClosing(object sender, FormClosingEventArgs e)
        {
            _frm.Show();
        }

        private void nationalitiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
      
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(NationalityMainForm))
                {
                    form.Activate();
                    return;
                }
            }

            Form frm = new NationalityMainForm();
            frm.Show();
        }

        private void waterSourceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(WaterSourceMainForm))
                {
                    form.Activate();
                    return;
                }
            }

            Form frm = new WaterSourceMainForm();
            frm.Show();

        }


        private void religionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(ReligionMainForm))
                {
                    form.Activate();
                    return;
                }
            }

            Form frm = new ReligionMainForm();
            frm.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(CountryMainForm))
                {
                    form.Activate();
                    return;
                }
            }

            Form frm = new CountryMainForm();
            frm.Show();
        }


        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(UserMainForm))
                {
                    form.Activate();
                    return;
                }
            }

            Form frm = new UserMainForm();
            frm.Show();
        }

        private void Mainform_Load(object sender, EventArgs e)
        {
            int roleid = Properties.Settings.Default.role_id;
            ControlHelper.SetupControlAccess(this, null, roleid);

            timer1.Start();
            toolStripLabelUser.Text = Properties.Settings.Default.fname.ToUpper()  + " " + Properties.Settings.Default.lname.ToUpper();
            toolStripLabelRole.Text = Properties.Settings.Default.role.ToUpper();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripLabelSystemTime.Text = DateTime.Now.ToString();
        }

        private void toolStripMenuSetupControl_Click(object sender, EventArgs e)
        {
 
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(ControlMainForm))
                {
                    form.Activate();
                    return;
                }
            }

            Form frm = new ControlMainForm();
            frm.Show();

        }

        private void accessLevelsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(AccessLevelMainForm))
                {
                    form.Activate();
                    return;
                }
            }

            Form frm = new AccessLevelMainForm();
            frm.Show();
        }

        private void rolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(RoleMainForm))
                {
                    form.Activate();
                    return;
                }
            }

            Form frm = new RoleMainForm();
            frm.Show();
        }

        private void rolesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(RoleMainForm))
                {
                    form.Activate();
                    return;
                }
            }

            Form frm = new RoleMainForm();
            frm.Show();
        }

        private void contraceptiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(ContraceptiveMainForm))
                {
                    form.Activate();
                    return;
                }
            }

            Form frm = new ContraceptiveMainForm();
            frm.Show();
        }

        private void gardenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(GardenMainForm))
                {
                    form.Activate();
                    return;
                }
            }

            Form frm = new GardenMainForm();
            frm.Show();
        }

        private void toiletToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(ToiletMainForm))
                {
                    form.Activate();
                    return;
                }
            }

            Form frm = new ToiletMainForm();
            frm.Show();

        }

        private void petToolStripMenuItem_Click(object sender, EventArgs e)
        {

            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(PetMainForm))
                {
                    form.Activate();
                    return;
                }
            }

            Form frm = new PetMainForm();
            frm.Show();
        }

        private void barangaysToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //foreach (Form form in Application.OpenForms)
            //{
            //    if (form.GetType() == typeof(BarangayInformation))
            //    {
            //        form.Activate();
            //        return;
            //    }
            //}

            //Form frm = new BarangayInformation();
            //frm.Show();
        }

        private void aForgeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(AForge))
                {
                    form.Activate();
                    return;
                }
            }

            Form frm = new AForge();
            frm.Show();
        }
    }
}
