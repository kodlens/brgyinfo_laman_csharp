using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;

using BarangayInformation.Class;


namespace BarangayInformation
{
    public partial class ResidentAddEditForm : Form
    {
        MySqlCommand cmd;
        MySqlConnection con;
        DAddress address;

        public int resident_id;
        int returnId = 0;

        public ResidentAddEditForm()
        {
            InitializeComponent();

            //instantiate DAddress
            address = new DAddress();
        }

        private void btnDebug_Click(object sender, EventArgs e)
        {
            this.txtFirstname.Text = "ETIENNE WAYNE";
            txtLastname.Text = "AMPARADO";
            txtMiddlename.Text = "NAMOCATCAT";
            txtSuffix.Text = "TEST";
            cmbSex.Text = "MALE";
            cmbCivilStatus.Text = "SINGLE";
            cmbReligion.Text = "Bible Baptist Church";
            cmbNationality.Text = "FILIPINO";
            cmbEmploymentStatus.Text = "EMPLOYED";
            txtOccupation.Text = "IT PROGRAMMER";
            txtAnnualIncome.Text = "11000";
            txtYearResidency.Text = "1 YEAR";
            txtPlaceBirth.Text = "BAROY, LANAO DEL NORTE";

            txtContactNumber.Text = "09167789585";
            txtEmailAddress.Text = "et@yahoo.com";
            txtValidID.Text = "DRIVER LICENSE";
            txtIDNumber.Text = "K09-1234-214";

            cmbIsVoter.Text = "YES";
            cmbVoterType.Text = "OLD";
            cmbIsSK.Text = "NO";
            txtPlaceReg.Text = "MALORO, TANGUB CITY";

            cmbPresentCountry.Text = "PHILIPPINES";
            cmbPresentProvince.Text = "MISAMIS OCCIDENTAL";
            cmbPresentCity.Text = "TANGUB CITY";
            cmbPresentBarangay.Text = "GARANG";
            txtPresentStreet.Text = "P-SAMPLE LANG";


            //'add row datagrid sample data
            this.gridSibling.Rows.Add( null, "JAY AR", "B", "DOCOY", "MALE", "MARRIED", "04/08/2020", true);

            this.gridSibling.Rows.Add( null, "JUNREY", "M", "SANTARITA", "MALE", "MARRIED", "24/05/1995", false);

            this.gridSibling.Rows.Add( null, "ALBERT", "B", "ALIA", "MALE", "SINGLE", "20/08/1990", true);

            this.gridSibling.Rows.Add( null, "JADE ANN", "C", "FLORIZA", "FEMALE", "SINGLE", "16/10/1993", false);
        }

        private void btnNext1_Click(object sender, EventArgs e)
        {
            TabControl1.SelectedTab = tabContactAddress;
        }

        private void ResidentAddEditForm_Load(object sender, EventArgs e)
        {
            //initialize items in combo box
            //1 open connection for all
            con = Connection.con();
            con.Open();
            address.country(con, this.cmbPresentCountry);

            con.Close();
            con.Dispose();
        }

        private void tbnNext2_Click(object sender, EventArgs e)
        {
            TabControl1.SelectedTab = tabFamilyMembers;
        }

        private void btnBack1_Click(object sender, EventArgs e)
        {
            TabControl1.SelectedTab = tabProfile;

        }

        private void btnBack3_Click(object sender, EventArgs e)
        {
            TabControl1.SelectedTab = tabContactAddress;

        }

        private void btnNext3_Click(object sender, EventArgs e)
        {
            TabControl1.SelectedTab = tabAdditionalInformation;

        }

        private void btnBack4_Click(object sender, EventArgs e)
        {
            TabControl1.SelectedTab = tabFamilyMembers;

        }

        private void btnBack5_Click(object sender, EventArgs e)
        {
            TabControl1.SelectedTab = tabAdditionalInformation;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void clear()
        {
            returnId = 0;
            txtResidentId.Text = "";
            txtLastname.Text = "";
            txtFirstname.Text = "";
            txtMiddlename.Text = "";
            txtSuffix.Text = "";
            cmbSex.SelectedIndex = -1;
            cmbCivilStatus.SelectedIndex = -1;
            cmbReligion.SelectedIndex = -1;
            cmbNationality.SelectedIndex = -1;
            cmbEmploymentStatus.SelectedIndex = -1;
            txtOccupation.Text = "";
            txtAnnualIncome.Text = "";
            txtYearResidency.Text = "";
            txtPlaceBirth.Text = "";

            txtContactNumber.Text = "";
            txtEmailAddress.Text = "";
            txtValidID.Text = "";
            txtIDNumber.Text = "";

            cmbPresentCountry.SelectedIndex = -1;
            cmbPresentProvince.SelectedIndex = -1;
            cmbPresentCity.SelectedIndex = -1;
            cmbPresentBarangay.SelectedIndex = -1;
            txtPresentStreet.Text = "";

            cmbPermanentCountry.SelectedIndex = -1;
            cmbPermanentProvince.SelectedIndex = -1;
            cmbPermanentCity.SelectedIndex = -1;
            cmbPermanentBarangay.SelectedIndex = -1;
            txtPermanentStreet.Text = "";

            cmbIsVoter.SelectedIndex = -1;
            cmbVoterType.SelectedIndex = -1;
            cmbIsSK.SelectedIndex = -1;
            txtPlaceReg.Text = "";

            txtSiblingLname.Text = "";
            txtSiblingFname.Text = "";
            txtSiblingFname.Text = "";
            cmbSiblingSex.SelectedIndex = -1;
            cmbSiblingCivilStatus.SelectedIndex = -1;
            cmbSiblingIsLiving.SelectedIndex = -1;

            gridSibling.Rows.Clear();

            cmbWaterSource.SelectedIndex = -1;
            cmbToilet.SelectedIndex = -1;
            cmbGarden.SelectedIndex = -1;
            cmbPet.SelectedIndex = -1;
            cmbContraceptive.SelectedIndex = -1;

            dgridPets.Rows.Clear();

            cmbHaveComplain.SelectedIndex = -1;
            txtAgainstWhom.Text = "";
            cmbIsSettled.SelectedIndex = -1;
            txtIfNotWhy.Text = "";
        cmbIsDeathMember.SelectedIndex = -1;
        }

        private void cmbPresentCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                address.provinces(this.cmbPresentCountry.Text, cmbPresentProvince);
            }
            catch (Exception er)
            {

                Box.ErrBox(er.Message);
            }
        }

        private void cmbPresentProvince_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                address.cities(this.cmbPresentProvince.Text, cmbPresentCity);
            }
            catch (Exception er)
            {

                Box.ErrBox(er.Message);
            }
        }

        private void cmbPresentCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                address.barangays(this.cmbPresentProvince.Text, this.cmbPresentCity.Text, cmbPresentBarangay);
            }
            catch (Exception er)
            {

                Box.ErrBox(er.Message);
            }
        }
    }
}
