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
    public partial class NationalityAddEditForm : Form
    {

        Nationality nationality;
        public int id;

        public NationalityAddEditForm()
        {
            InitializeComponent();

            nationality = new Nationality();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.txtNationality.Text))
            {
                txtNationality.Focus();
                Box.WarnBox("Nationality is required.");
                return;
            }

            nationality.nationality = this.txtNationality.Text; //input data from textbox pass to the properties of the class
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
            if (nationality.save() > 0) //check if save is greater than 0, it also execute the save() method
            {
                //if greater than 1, show success message
                Box.InfoBox("Data successfully saved.");
                this.Close();
            }
        }

        void update()
        {
            if (nationality.update(id) > 0) //check if save is greater than 0, it also execute the update() method
            {
                //if greater than 1, show success message
                Box.InfoBox("Data successfully updated.");
                this.Close();
            }
        }

        private void NationalityAddEditForm_Load(object sender, EventArgs e)
        {
            //if edit mode
            if(id > 0)
            {
                //edit mode
                getData();
            }
        }

        void getData()
        {
            nationality.getData(id);
            this.txtNationality.Text = nationality.nationality;
        }
    }
}
