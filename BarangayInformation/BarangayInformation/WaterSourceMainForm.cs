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
    public partial class WaterSourceMainForm : Form
    {

        //declaration
        WaterSource ws;


        public WaterSourceMainForm()
        {
            InitializeComponent();

            //instantiate
            ws = new WaterSource();
        }

        public void loadData()
        {
            ws.tableData(grid, txtSearch.Text);
        }

        private void WaterSourceMainForm_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(grid.Rows.Count > 0)
            {
                if(Box.QBox("Are you sure you want to delete this data?"))
                {
                    int id = Convert.ToInt32(grid.SelectedRows[0].Cells["water_source_id"].Value);
                    ws.delete(id);
                    Box.InfoBox("Data successfully deleted.");
                    loadData();
                }
            }
            else
            {
                Box.WarnBox("No data selected.");
            }
        }
    }
}


  
    

