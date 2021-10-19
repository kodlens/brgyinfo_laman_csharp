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
    public partial class RoleAddEditForm : Form
    {
        Role role;
        public int id;

        public RoleAddEditForm()
        {
            InitializeComponent();
            role = new Role();

        }

        private void buttonwatersave_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.textBoxrole.Text))
            {
                textBoxrole.Focus();
                Box.WarnBox("Role data is required.");
                return;
            }
            role.role = this.textBoxrole.Text; //input data from textbox pass to the properties of the class
            if (id > 0)
            {
                //update
                update();
            }
            else
            {
                //insert or save
                save();
            }

            void save()
            {
                if (role.save() > 0) //check if save is greater than 0, it also execute the save() method
                {
                    //if greater than 1, show success message
                    Box.InfoBox("Data successfully saved.");
                    this.Close();
                }
            }


            void update()
            {
                if (role.update(id) > 0) //check if save is greater than 0, it also execute the update() method
                {
                    //if greater than 1, show success message
                    Box.InfoBox("Data successfully updated.");
                    this.Close();
                }
            }
        }

        private void RoleAddEditForm_Load(object sender, EventArgs e)
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
            role.getData(id);
            this.textBoxrole.Text = role.role;
        }
    }
}
