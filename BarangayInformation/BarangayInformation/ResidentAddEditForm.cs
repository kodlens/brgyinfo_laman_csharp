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

        Resident res;

        public int resident_id;
        int returnId = 0;

        public ResidentAddEditForm()
        {
            InitializeComponent();

            //instantiate DAddress
            address = new DAddress();
            res = new Resident();
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
            //if (String.IsNullOrEmpty(txtLastname.Text))
            //{
            //    Box.WarnBox("Please input lastname.");
            //    txtLastname.Focus();
            //    return;
            //}
            //if (String.IsNullOrEmpty(txtFirstname.Text))
            //{
            //    Box.WarnBox("Please input lastname.");
            //    txtFirstname.Focus();
            //    return;
            //}
            //if (String.IsNullOrEmpty(cmbSex.Text))
            //{
            //    Box.WarnBox("Please select sex.");
            //    cmbSex.Focus();
            //    return;
            //}
            ////filter address
            ////present address
            //if (String.IsNullOrEmpty(cmbPresentCountry.Text))
            //{
            //    Box.WarnBox("Please select present country.");
            //    cmbPresentCountry.Focus();
            //    return;
            //}
            //if (String.IsNullOrEmpty(cmbPresentProvince.Text))
            //{
            //    Box.WarnBox("Please select present province.");
            //    cmbPresentProvince.Focus();
            //    return;
            //}
            //if (String.IsNullOrEmpty(cmbPresentCity.Text))
            //{
            //    Box.WarnBox("Please select present city.");
            //    cmbPresentCity.Focus();
            //    return;
            //}
            //if (String.IsNullOrEmpty(cmbPresentBarangay.Text))
            //{
            //    Box.WarnBox("Please select present barangay.");
            //    cmbPresentBarangay.Focus();
            //    return;
            //}
            ////permanent address
            //if (String.IsNullOrEmpty(cmbPermanentCountry.Text))
            //{
            //    Box.WarnBox("Please select permanent country.");
            //    cmbPermanentCountry.Focus();
            //    return;
            //}
            //if (String.IsNullOrEmpty(cmbPermanentProvince.Text))
            //{
            //    Box.WarnBox("Please select permanent province.");
            //    cmbPermanentProvince.Focus();
            //    return;
            //}
            //if (String.IsNullOrEmpty(cmbPermanentCity.Text))
            //{
            //    Box.WarnBox("Please select permanent city.");
            //    cmbPermanentCity.Focus();
            //    return;
            //}
            //if (String.IsNullOrEmpty(cmbPermanentBarangay.Text))
            //{
            //    Box.WarnBox("Please select permanent barangay.");
            //    cmbPermanentBarangay.Focus();
            //    return;
            //}

            if(returnId > 0)
            {
               //UPDATE
            }
            else
            {
                //INSERT
                insertResident();
            }

        }

        void insertResident()
        {

            res.is_head = rbHead.Checked ? (short)1 : (short)0;

            res.fname = this.txtFirstname.Text.Trim();
            res.mname = this.txtMiddlename.Text.Trim();
            res.suffix = this.txtSuffix.Text.Trim();
            res.sex = this.cmbSex.Text;
            res.civil_status = this.cmbCivilStatus.Text;
            res.religion = this.cmbReligion.Text;
            res.nationality = this.cmbNationality.Text;
            res.employment_status = this.cmbEmploymentStatus.Text;
            res.occupation = this.txtOccupation.Text;
            res.annual_income = Convert.ToDouble(this.txtAnnualIncome.Text);
            res.year_residence = this.txtYearResidency.Text;
            res.bdate = this.dtBdate.Value.ToString("yyyy-MM-dd");
            res.place_of_birth = this.txtPlaceBirth.Text;

            //'CONTACT INFO
            res.contact_no = txtContactNumber.Text;
            res.email = txtEmailAddress.Text;
            res.type_valid_id = txtValidID.Text;
            res.id_no = txtIDNumber.Text;

            //'PRESENT ADDRESS
            res.present_country = this.cmbPresentCountry.Text;
            res.present_province = this.cmbPresentProvince.Text;
            res.present_city = this.cmbPresentCity.Text;
            res.present_barangay = this.cmbPresentBarangay.Text;
            res.present_street = this.txtPresentStreet.Text;

            //'PERMANENT ADDRESS
            res.present_country = this.cmbPermanentCountry.Text;
            res.permanent_province = this.cmbPermanentProvince.Text;
            res.permanent_city = this.cmbPermanentCity.Text;
            res.permanent_barangay = this.cmbPermanentBarangay.Text;
            res.permanent_street = this.txtPermanentStreet.Text;

            res.is_voter = cmbIsVoter.Text == "YES" ? (short)1 : (short)0;
            res.voter_type = this.cmbVoterType.Text;
            res.is_sk = cmbIsSK.Text == "YES" ? (short)1 : (short)0;
            res.place_registration = this.txtPlaceReg.Text;

            //'additional Info
            res.water_source = cmbWaterSource.Text;
            res.toilet = cmbToilet.Text;
            res.garden = cmbGarden.Text;
            res.contraceptive = cmbContraceptive.Text;

            //survey info
            res.have_complain = this.cmbHaveComplain.Text == "YES" ? (short)1 : (short)0;
            res.against_whom = this.txtAgainstWhom.Text;
            res.is_settled = this.cmbIsSettled.Text == "YES" ? (short)1 : (short)0;
            res.date_settled = dtComplainWhen.Value.ToString("yyyy-MM-dd");
            res.if_not_why = txtIfNotWhy.Text;

            res.is_death_aid = this.cmbIsDeathMember.Text == "YES" ? (short)1 : (short)0;

           
            returnId = res.save();
            txtResidentId.Text = "RES-" + returnId.ToString("000000");
            Box.InfoBox("Successfully saved!");
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
