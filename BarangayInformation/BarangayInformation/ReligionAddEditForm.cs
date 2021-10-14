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
    public partial class ReligionAddEditForm : Form
    {
        Religion religion;
        internal int id;

        public ReligionAddEditForm()
        {
            InitializeComponent();
            religion = new Religion();
        }



        private void buttonwatersave_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.textreligion.Text))
            {
                textreligion.Focus();
                Box.WarnBox("Religion data is required.");
                return;
            }
            religion.religion = this.textreligion.Text; //input data from textbox pass to the properties of the class
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
                if (religion.save() > 0) //check if save is greater than 0, it also execute the save() method
                {
                    //if greater than 1, show success message
                    Box.InfoBox("Data successfully saved.");
                    this.Close();
                }
            }

            void update()
            {
                if (religion.update(id) > 0) //check if save is greater than 0, it also execute the update() method
                {
                    //if greater than 1, show success message
                    Box.InfoBox("Data successfully updated.");
                    this.Close();
                }
            }
        }
    }
}
    
