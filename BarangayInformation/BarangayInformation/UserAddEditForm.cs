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
        public int id;
        public UserAddEditForm()
        {
            InitializeComponent();
            user = new User();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.txtFirstname.Text))
            {
                txtFirstname.Focus();
                Box.WarnBox("Fill up details.");
                return;
            }
            else if (String.IsNullOrEmpty(this.txtMiddlename.Text))
            {
                txtMiddlename.Focus();
                Box.WarnBox("Fill up details.");
                return;
            }
            else if (String.IsNullOrEmpty(this.txtLastname.Text))
            {
                txtLastname.Focus();
                Box.WarnBox("Fill up details.");
                return;
            }
            else if (String.IsNullOrEmpty(this.txtRole.Text))
            {
                txtRole.Focus();
                Box.WarnBox("Fill up details.");
                return;
            }
            else if (String.IsNullOrEmpty(this.txtDatecreated.Text))
            {
                txtDatecreated.Focus();
                Box.WarnBox("Fill up details.");
                return;
            }
            else if (String.IsNullOrEmpty(this.txtDateUpdated.Text))
            {
               txtDateUpdated.Focus();
                Box.WarnBox("Fill up details.");
                return;
            
         
            }
           
        }

        void save()
        {
            if (user.save() > 0) //check if save is greater than 0, it also execute the save() method
            {
                //if greater than 1, show success message
                Box.InfoBox("Data successfully saved.");
                this.Close();
            }
        }

        void update()
        {
            if (user.update(id) > 0) //check if save is greater than 0, it also execute the update() method
            {
                //if greater than 1, show success message
                Box.InfoBox("Data successfully updated.");
                this.Close();
            }
        }



        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.txtFirstname.Text))
            {
                txtFirstname.Focus();
                Box.WarnBox("Fill up details.");
                return;
            }
            else if (String.IsNullOrEmpty(this.txtMiddlename.Text))
            {
                txtMiddlename.Focus();
                Box.WarnBox("Fill up details.");
                return;
            }
            else if (String.IsNullOrEmpty(this.txtLastname.Text))
            {
                txtLastname.Focus();
                Box.WarnBox("Fill up details.");
                return;
            }
            else if (String.IsNullOrEmpty(this.txtRole.Text))
            {
                txtRole.Focus();
                Box.WarnBox("Fill up details.");
                return;
            }
            else if (String.IsNullOrEmpty(this.txtDatecreated.Text))
            {
                txtDatecreated.Focus();
                Box.WarnBox("Fill up details.");
                return;
            }
            else if (String.IsNullOrEmpty(this.txtDateUpdated.Text))
            {
                txtDateUpdated.Focus();
                Box.WarnBox("Fill up details.");
                return;


            }
            else
            {
                Box.InfoBox("Data successfully updated.");
                this.Close();
            }
        }

        private void UserAddEditForm_Load(object sender, EventArgs e)
        {
            //if edit mode
            if (id > 0)
            {
                //edit mode
                getData();
            }
        }

        void getData()
        {
            user.getData(id);
            this.txtLastname.Text = user.username;
        }
    }
}
