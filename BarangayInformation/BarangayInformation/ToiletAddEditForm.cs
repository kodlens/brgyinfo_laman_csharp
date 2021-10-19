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
    public partial class ToiletAddEditForm : Form
    {
        Toilet toilet;
        public int id;
        public ToiletAddEditForm()
        {
            InitializeComponent();
            toilet = new Toilet();
        }

        private void buttontoiletsave_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.textBoxwatersource.Text))
            {
                textBoxwatersource.Focus();
                Box.WarnBox("Water Source data is required.");
                return;
            }
            toilet.toilet = this.textBoxwatersource.Text; //input data from textbox pass to the properties of the class
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
                if (toilet.save() > 0) //check if save is greater than 0, it also execute the save() method
                {
                    //if greater than 1, show success message
                    Box.InfoBox("Data successfully saved.");
                    this.Close();
                }
            }

            void update()
            {
                if (toilet.update(id) > 0) //check if save is greater than 0, it also execute the update() method
                {
                    //if greater than 1, show success message
                    Box.InfoBox("Data successfully updated.");
                    this.Close();
                }
            }

            
        }

        private void ToiletAddEditForm_Load(object sender, EventArgs e)
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
            toilet.getData(id);
            this.textBoxwatersource.Text = toilet.toilet;
        }
    }
}
