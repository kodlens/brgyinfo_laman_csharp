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

namespace BarangayInformation.Access_Control
{
    public partial class ControlAddEditForm : Form
    {

        public int id;

        ControlMainForm _frm;

        NControl control;

        public ControlAddEditForm(ControlMainForm _frm)
        {
            InitializeComponent();
            this._frm = _frm;
            control = new NControl();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                Box.WarnBox("Please input control name.");
                txtName.Focus();
                return;
            }

            if (control.isExist(this.txtName.Text, this.txtClass.Text, id))
            {
                Box.WarnBox("Duplicate control name.");
                txtName.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtText.Text))
            {
                Box.WarnBox("Please input control text.");
                txtText.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtClass.Text))
            {
                Box.WarnBox("Please input control class name.");
                txtClass.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtDesc.Text))
            {
                Box.WarnBox("Please input control description.");
                txtClass.Focus();
                return;
            }

            control.name = this.txtName.Text;
            control.text = this.txtText.Text;
            control.class_name = this.txtClass.Text;
            control.desc = this.txtDesc.Text;

            if (id > 0)
            {
                if (control.update(id) > 0)
                {
                    Box.InfoBox("Control updated.");
                    _frm.loadData();
                }
            }
            else
            {
                if (control.save()>0)
                {
                    Box.InfoBox("Control saved.");
                    _frm.loadData();

                }
            }

            this.Close();

        }

        private void ControlAddEditForm_Load(object sender, EventArgs e)
        {
            if (id > 0)
            {
                control.getData(id);
                getData();
            }
        }

        void getData()
        {
            txtName.Text = control.name;
            txtText.Text = control.text;
            txtClass.Text = control.class_name;
            txtDesc.Text = control.desc;
        }
    }
}
