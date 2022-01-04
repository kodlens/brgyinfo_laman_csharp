using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarangayInformation
{
    class Box
    {


        public static void InfoBox(string msg)
        {
            MessageBox.Show(msg, "INFORMATION!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void WarnBox(string msg)
        {
            MessageBox.Show(msg, "WARNING!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void ErrBox(string msg)
        {
            MessageBox.Show(msg, "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static bool QBox(string msg)
        {
            DialogResult emjeeMaot = MessageBox.Show(msg, "ARE YOU SURE?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(emjeeMaot == DialogResult.Yes)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
