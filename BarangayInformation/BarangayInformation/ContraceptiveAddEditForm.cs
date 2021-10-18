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
    public partial class ContraceptiveAddEditForm : Form
    {

        Contraceptives contraceptive;
        public int id;
        public ContraceptiveAddEditForm()
        {
            InitializeComponent();
            contraceptive = new Contraceptives();
        }

        private void buttonwatersave_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.textBoxcontraceptive.Text))
            {
                textBoxcontraceptive.Focus();
                Box.WarnBox("Contraceptive data is required.");
                return;
            }
           contraceptive.contraceptive = this.textBoxcontraceptive.Text; //input data from textbox pass to the properties of the class
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
                if (contraceptive.save() > 0) //check if save is greater than 0, it also execute the save() method
                {
                    //if greater than 1, show success message
                    Box.InfoBox("Data successfully saved.");
                    this.Close();
                }
            }

            void update()
            {
                if (contraceptive.update(id) > 0) //check if save is greater than 0, it also execute the update() method
                {
                    //if greater than 1, show success message
                    Box.InfoBox("Data successfully updated.");
                    this.Close();
                }
            }


        }

        private void ContraceptiveAddEditForm_Load(object sender, EventArgs e)
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
            contraceptive.getData(id);
            this.textBoxcontraceptive.Text = contraceptive.contraceptive;
        }
    }
}

