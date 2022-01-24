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
    public partial class GardenAddEditForm : Form
    {

        Garden garden;
        public int id;

        GardenMainForm _frm;

        public GardenAddEditForm(GardenMainForm _frm)
        {
            InitializeComponent();
            this._frm = _frm;
            garden = new Garden();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.txtGarden.Text))
            {
                txtGarden.Focus();
                Box.WarnBox("Garden data is required.");
                return;
            }

            garden.garden = this.txtGarden.Text; //input data from textbox pass to the properties of the class
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
            if (garden.save() > 0) //check if save is greater than 0, it also execute the save() method
            {
                //if greater than 1, show success message
                Box.InfoBox("Data successfully saved.");
                _frm.loadData();
                this.Close();
            }
        }

        void update()
        {
            if (garden.update(id) > 0) //check if save is greater than 0, it also execute the update() method
            {
                //if greater than 1, show success message
                Box.InfoBox("Data successfully updated.");
                _frm.loadData();
                this.Close();
            }
        }
        private void GardenAddEditForm_Load(object sender, EventArgs e)
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
            garden.getData(id);
            this.txtGarden.Text = garden.garden;
        }

    }
}
