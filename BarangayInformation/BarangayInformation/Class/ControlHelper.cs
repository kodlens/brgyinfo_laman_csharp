using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarangayInformation.Class
{
    class ControlHelper
    {

        public static void SetupControlAccess(Form frm, ContextMenuStrip cstrip, int position_id)
        {

            //for Contextmenu Items (RIGHTCLICK)
            if (cstrip != null)
            {
                foreach (ToolStripItem menuitem in cstrip.Items)
                {
                    //Box.infoBox(menuitem.GetType().ToString());
                    if (menuitem.GetType() == typeof(ToolStripSeparator))
                    {
                        menuitem.Enabled = false;
                    }

                    if (menuitem.GetType() == typeof(ToolStripMenuItem))
                    {
                        if (!getAccessControlsList(frm.Name, position_id).Contains(menuitem.Name))
                        {
                            //menuitem.Enabled = false;
                            menuitem.Enabled = false;
                        }
                    }

                }
            }



            foreach (Control ctrl in frm.Controls)
            {
                if (ctrl.GetType() == typeof(ToolStrip))
                {
                    foreach (ToolStripItem item in ((ToolStrip)ctrl).Items)
                    {

                        if (item.GetType() == typeof(ToolStripSplitButton))
                        {
                            foreach (ToolStripMenuItem item2 in ((ToolStripSplitButton)item).DropDownItems)
                            {
                                //Box.infoBox(item2.Name);
                                if (!getAccessControlsList(frm.Name, position_id).Contains(item2.Name))
                                {
                                    item2.Enabled = false;
                                    //item2.Visible = false;
                                }
                            }
                        }

                        if (!getAccessControlsList(frm.Name, position_id).Contains(item.Name))
                        {
                            item.Visible = false;
                            //item.Visible = false;
                        }


                    }
                }


            }
        }


        private static Control GetControlByName(string controlName, Control.ControlCollection parent)
        {
            Control c = null;
            foreach (Control ctrl in parent)
            {
                if (ctrl.Name.Equals(controlName))
                {
                    c = ctrl;
                    return c;
                }

                if (ctrl.GetType() == typeof(ToolStrip))
                {
                    foreach (ToolStripItem item in ((ToolStrip)ctrl).Items)
                    {
                        if (item.Name.Equals(controlName))
                        {
                            switch (item.GetType().Name)
                            {
                                case "ToolStripComboBox":
                                    c = ((ToolStripComboBox)item).Control;
                                    break;
                                case "ToolStripTextBox":
                                    c = ((ToolStripTextBox)item).Control;
                                    break;
                            }
                            if (c != null)
                            {
                                break;
                            }
                        }
                    }
                }
                if (c == null)
                    c = GetControlByName(controlName, ctrl.Controls);
                else
                    break;
            }
            return c;
        }



        //public static IEnumerable<Control> GetControlHierarchy(Control root)
        //{
        //    var queue = new Queue<Control>();

        //    queue.Enqueue(root);

        //    do
        //    {
        //        var control = queue.Dequeue();

        //        yield return control;

        //        foreach (var child in control.Controls.OfType<Control>())
        //            queue.Enqueue(child);

        //    } while (queue.Count > 0);

        //}


        static List<string> getAccessControlsList(string className, int position_id)
        {
            MySqlConnection con;
            MySqlCommand cmd;
            string query;

            var retList = new List<string>();

            con = Connection.con();
            con.Open();
            query = @"SELECT a.access_level_id, a.position_id, b.position,
                        a.control_id, c.control_name, c.control_text, c.description, c.class_name
                        FROM
                        access_levels a
                        JOIN positions b ON a.position_id = b.position_id
                        JOIN controls c ON a.control_id = c.control_id WHERE a.posistion_id=?posid and c.class_name=?classname";
            cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("?posid", position_id);
            cmd.Parameters.AddWithValue("?classname", className);
            MySqlDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                retList.Add(Convert.ToString(dr["control_name"]));
            }
            dr.Close();
            con.Close();
            con.Dispose();

            return retList;
        }
    }
}
