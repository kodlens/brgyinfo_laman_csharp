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
    public partial class WaterSourceAddEditForm : Form
    {
        WaterSource water_source;
        public int id;

        public WaterSourceAddEditForm()
        {
            InitializeComponent();
            water_source = new WaterSource();
        }

        private void buttonwatersave_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.textBoxwatersource.Text))
            {
                textBoxwatersource.Focus();
                Box.WarnBox("Water Source data is required.");
                return;
            }
            water_source.water_source = this.textBoxwatersource.Text; //input data from textbox pass to the properties of the class
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
                if (water_source.save() > 0) //check if save is greater than 0, it also execute the save() method
                {
                    //if greater than 1, show success message
                    Box.InfoBox("Data successfully saved.");
                    this.Close();
                }
            }

            void update()
            {
                if (water_source.update(id) > 0) //check if save is greater than 0, it also execute the update() method
                {
                    //if greater than 1, show success message
                    Box.InfoBox("Data successfully updated.");
                    this.Close();
                }
            }
        }

            
        private void WaterSourceAddEditForm_Load_1(object sender, EventArgs e)
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
            water_source.getData(id);
            this.textBoxwatersource.Text = water_source.water_source;
        }
    }


    }
