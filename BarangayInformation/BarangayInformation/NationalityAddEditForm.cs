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
            if (nationality.save() > 0) //check if save is greater than 0, it also execute the save() method
            {
                //if greater than 1, show success message
                Box.InfoBox("Data successfully saved.");
                this.Close();
            }
        }
    }
}
