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
    public partial class CountryAddEditForm : Form
    {
        Country country;
        public int id;

        public CountryAddEditForm()
        {
            InitializeComponent();

            country = new Country();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.txtCountry.Text))
            {
                txtCountry.Focus();
                Box.WarnBox("Country is required.");
                return;
            }

            country.country = this.txtCountry.Text; //input data from textbox pass to the properties of the class
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
        }

        void save()
        {
            if (country.save() > 0) //check if save is greater than 0, it also execute the save() method
            {
                //if greater than 1, show success message
                Box.InfoBox("Data successfully saved.");
                this.Close();
            }
        }

        void update()
        {
            if (country.update(id) > 0) //check if save is greater than 0, it also execute the update() method
            {
                //if greater than 1, show success message
                Box.InfoBox("Data successfully updated.");
                this.Close();
            }
        }

        private void CountryAddEditForm_Load(object sender, EventArgs e)
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
            country.getData(id);
            this.txtCountry.Text = country.country;
        }
    }
    }

