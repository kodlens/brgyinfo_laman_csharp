using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarangayInformation
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

      

        private void btn_login_Click(object sender, EventArgs e)
        {
            If txtbox_username.Text = "admin" And txtbox_pass.Text = "pass" Then
          Mainform.Show()
       Else
           MsgBox("Sorry, username or password not found", MsgBoxStyle.OkOnly, "Invalid")
       End If
        }
    }
}
