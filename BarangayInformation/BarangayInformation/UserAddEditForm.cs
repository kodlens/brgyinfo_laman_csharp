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
    public partial class UserAddEditForm : Form
    {

        User user;
        UserMainForm _frm;
        public int id;
        public UserAddEditForm(UserMainForm _frm)
        {
            InitializeComponent();
            this._frm = _frm;
            user = new User();
        }

 
        void save()
        {
            if (user.save() > 0) //check if save is greater than 0, it also execute the save() method
            {
                //if greater than 1, show success message
                Box.InfoBox("Data successfully saved.");
                _frm.loadData();
                this.Close();
            }
        }

        void update()
        {
            if (user.update(id) > 0) //check if save is greater than 0, it also execute the update() method
            {
                //if greater than 1, show success message
                Box.InfoBox("Data successfully updated.");
                _frm.loadData();
                this.Close();
            }
        }



        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.textUsername.Text))
            {
                textUsername.Focus();
                Box.WarnBox("Username is required.");
                return;
            }
            if (String.IsNullOrEmpty(this.txtPassword.Text))
            {
                txtFirstname.Focus();
                Box.WarnBox("Password is required.");
                return;
            }
            if (String.IsNullOrEmpty(this.txtFirstname.Text))
            {
                txtFirstname.Focus();
                Box.WarnBox("Firstname is required.");
                return;
            }
     
            if (String.IsNullOrEmpty(this.txtLastname.Text))
            {
                txtLastname.Focus();
                Box.WarnBox("Lastname is required.");
                return;
            }
            if (String.IsNullOrEmpty(this.cmbRole.Text))
            {
                cmbRole.Focus();
                Box.WarnBox("Please select access role for the account.");
                return;
            }


            user.username = this.textUsername.Text;
            user.password = this.txtPassword.Text;

            user.lname = this.txtLastname.Text;
            user.fname = this.txtFirstname.Text;
            user.mname = this.txtMiddlename.Text;
            user.sex = this.cmbSex.Text;
            user.role = this.cmbRole.Text;

            if (id > 0)
            {
                //update
                update();
            }
            else
            {
                //insert
                save();
                
            }
            
            
        }
        private void UserAddEditForm_Load(object sender, EventArgs e)
        {
            //if edit mode
            new Role().loadToComboBox(cmbRole);
            if (id > 0)
            {
                //edit mode
                getData();

                //disable password during edit mode
                this.txtPassword.Enabled = false;
            }
        }

        void getData()
        {
            user.getData(id);
            textUsername.Text = user.username;
            this.txtLastname.Text = user.lname;
            this.txtFirstname.Text = user.fname;
            this.txtMiddlename.Text = user.mname;
            this.cmbSex.Text = user.sex;
            this.cmbRole.Text = user.role;
        }
    }
}
