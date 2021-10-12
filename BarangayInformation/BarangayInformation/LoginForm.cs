using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//call the Class folder
using BarangayInformation.Class;

namespace BarangayInformation
{
    public partial class LoginForm : Form
    {

        //class the class
        Login login;
        public LoginForm()
        {
            InitializeComponent();

            //instantiate the class
            login = new Login();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //filter
            if (String.IsNullOrEmpty(txtUsername.Text))
            {
                Box.ErrBox("Please input username.");
                txtUsername.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtPassword.Text))
            {
                Box.ErrBox("Please input password.");
                txtPassword.Focus();
                return;
            }


            //use the method under the class Login
            if (login.auth(this.txtUsername.Text, this.txtPassword.Text))
            {
                Mainform frm = new Mainform(this); //using this class so that we can hide the form and recall during logout
                this.txtUsername.Text = "";
                this.txtPassword.Text = "";
                frm.Show();
                this.Hide();
            }
            else
            {
                Box.ErrBox("Username and Password error!");
            }
        }
    }
}
