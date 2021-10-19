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
    public partial class PetAddEditForm : Form
    {

        Pet pet;
        public int id;
        public PetAddEditForm()
        {
            InitializeComponent();
            pet = new Pet();
        }

        private void buttontoiletsave_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.textBoxwatersource.Text))
            {
                textBoxwatersource.Focus();
                Box.WarnBox("Pet data is required.");
                return;
            }
            pet.pet = this.textBoxwatersource.Text; //input data from textbox pass to the properties of the class
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
                if (pet.save() > 0) //check if save is greater than 0, it also execute the save() method
                {
                    //if greater than 1, show success message
                    Box.InfoBox("Data successfully saved.");
                    this.Close();
                }
            }

            void update()
            {
                if (pet.update(id) > 0) //check if save is greater than 0, it also execute the update() method
                {
                    //if greater than 1, show success message
                    Box.InfoBox("Data successfully updated.");
                    this.Close();
                }
            }

        }

        private void PetAddEditForm_Load(object sender, EventArgs e)
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
            pet.getData(id);
            this.textBoxwatersource.Text = pet.pet;
        }
    }
}
