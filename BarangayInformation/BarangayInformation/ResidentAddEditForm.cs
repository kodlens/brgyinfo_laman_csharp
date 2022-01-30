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

        Religion rel;
        Nationality nat;
        WaterSource ws;
        Garden garden;
        Contraceptives contra;
        Toilet toilet;


        ResidentMainForm _frm;

        Resident res;

        public long resident_id;
        //int returnId = 0;

        public ResidentAddEditForm(ResidentMainForm _frm)
        {
            InitializeComponent();

            this._frm = _frm;
            //instantiate DAddress
            address = new DAddress();
            res = new Resident();
            rel = new Religion();
            nat = new Nationality();
            ws = new WaterSource();
            garden = new Garden();
            toilet = new Toilet();
            contra = new Contraceptives();
        }


        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            bool bHandled = false;
            // switch case is the easy way, a hash or map would be better, 
            // but more work to get set up.
            switch (keyData)
            {
                case Keys.F5:
                    // do whatever
                    bHandled = true;
                    btnNew_Click(null, null);
                    break;
                case Keys.F12:
                    bHandled = true;
                    //editToolStripMenuItem_Click(null, null);
                    debug();
                    break;
                case Keys.F2:
                    //deleteToolStripMenuItem_Click(null, null);
                    break;
                case Keys.F9:
                    btnSave_Click(null, null);
                    break;
                case (Keys.P | Keys.Control):
                    if(this.resident_id > 0)
                    {
                        ResidentReportForm frm = new ResidentReportForm();
                        frm.id = this.resident_id;
                        frm.ShowDialog();
                    }
                    else
                    {
                        Box.WarnBox("No resident selected. Please make sure you select a resident to view.");
                    }
                    
                    break;
            }
            return bHandled;


        }


        void debug()
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
            txtAnnualIncome.Text = "IT PROGRAMMER";
            txtOccupation.Text = "FARMER";
            txtAnnualIncome.Value = 12000;
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

            txtMotherLName.Text = "NAMOCATCAT";
            txtMotherFName.Text = "HELEN";
            txtMotherMName.Text = "MILA";
            
            txtFatherLName.Text = "AMPARADO";
            txtFatherFName.Text = "SEGUNDO";
            txtFatherMName.Text = "SIBALDE";
            txtFatherSuffix.Text = "JR";


            cmbPresentCountry.Text = "PHILIPPINES";
            cmbPresentProvince.Text = "MISAMIS OCCIDENTAL";
            cmbPresentCity.Text = "TANGUB CITY";
            cmbPresentBarangay.Text = "GARANG";
            txtPresentStreet.Text = "P-SAMPLE LANG";


            //'add row datagrid sample data
            this.flxSibling.Rows.Add();
            this.flxSibling[1, 1] = null;
            this.flxSibling[1, 2] = "DOCOY";
            this.flxSibling[1, 3] = "JAY AR";
            this.flxSibling[1, 4] = "B";
            this.flxSibling[1, 5] = "JR";
            this.flxSibling[1, 6] = "MALE";
            this.flxSibling[1, 7] = "MARRIED";
            this.flxSibling[1, 8] = "04/08/2020";
            this.flxSibling[1, 9] = true;

            this.flxSibling.Rows.Add();
            this.flxSibling[2, 1] = null;
            this.flxSibling[2, 2] = "SANTARITA";
            this.flxSibling[2, 3] = "JUNREY";
            this.flxSibling[2, 4] = "M";
            this.flxSibling[2, 5] = "";
            this.flxSibling[2, 6] = "MALE";
            this.flxSibling[2, 7] = "MARRIED";
            this.flxSibling[2, 8] = "24/05/1995";
            this.flxSibling[2, 9] = false;

            this.flxSibling.Rows.Add();
            this.flxSibling[3, 1] = null;
            this.flxSibling[3, 2] = "FLORIZA";
            this.flxSibling[3, 3] = "JADE";
            this.flxSibling[3, 4] = "C";
            this.flxSibling[3, 5] = "";
            this.flxSibling[3, 6] = "FEMALE";
            this.flxSibling[3, 7] = "SINGLE";
            this.flxSibling[3, 8] = "20/08/1990";
            this.flxSibling[3, 9] = false;

            //add pet
            this.flxPet.Rows.Add();
            this.flxPet[1, 1] = null;
            this.flxPet[1, 2] = "DOG";
            this.flxPet[1, 3] = 2;

            this.flxPet.Rows.Add();
            this.flxPet[2, 1] = null;
            this.flxPet[2, 2] = "CAT";
            this.flxPet[2, 3] = 1;

            this.flxPet.Rows.Add();
            this.flxPet[3, 1] = null;
            this.flxPet[3, 2] = "PIG";
            this.flxPet[3, 3] = 3;

        }//for debugging purpose only

        private void btnNext1_Click(object sender, EventArgs e)
        {
            TabControl1.SelectedTab = tabContactAddress;
        }

        private void ResidentAddEditForm_Load(object sender, EventArgs e)
        {
            //initialize items in combo box
            //1 open connection for all

            rbMember.Checked = true;
            

            //load data from database to combobox
            con = Connection.con();
            con.Open();
            address.country(con, this.cmbPresentCountry);
            address.country(con, this.cmbPermanentCountry);
            rel.fillCmbReligion(con, cmbReligion);
            nat.fillCmb(con, cmbNationality);
            ws.fillCmb(con, cmbWaterSource);
            garden.fillCmb(con, cmbGarden);
            toilet.fillCmb(con, cmbToilet);
            contra.fillCmb(con, cmbContraceptive);
            con.Close();
            con.Dispose();
            //=================================


            //if have resident value, edit mode
            if(resident_id > 0)
            {
                getData();
            }
        }

        void getData()
        {
            res.getData(resident_id, flxSibling, flxPet);

            if (res.is_head == 1)
                rbHead.Checked = true;
            else
                rbMember.Checked = true;

            txtResidentId.Text = "RES-" + res.resident_id.ToString("00000000");
            txthouseholdNo.Text = res.household_no;
            txtFamilyNo.Text = res.family_no;
            txtLastname.Text = res.lname;
            txtFirstname.Text = res.fname;
            txtMiddlename.Text = res.mname;
            txtSuffix.Text = res.suffix;
            cmbSex.Text = res.sex;
            cmbCivilStatus.Text = res.civil_status;
            cmbReligion.Text = res.religion;
            cmbNationality.Text = res.nationality;
            cmbEmploymentStatus.Text = res.employment_status;
            txtOccupation.Text = Convert.ToString(res.occupation);
            txtAnnualIncome.Value = Convert.ToDecimal(res.annual_income);
            txtYearResidency.Text = res.year_residence;

            //primary contact inof
            dtBdate.Value = Convert.ToDateTime(res.bdate);
            txtPlaceBirth.Text = res.place_of_birth;
            txtContactNumber.Text = res.contact_no;
            txtEmailAddress.Text = res.email;
            txtValidID.Text = res.type_valid_id;
            txtIDNumber.Text = res.id_no;

            //addresses present
            cmbPresentCountry.Text = res.present_country;
            cmbPresentProvince.Text = res.present_province;
            cmbPresentCity.Text = res.present_city;
            cmbPresentBarangay.Text = res.present_barangay;
            txtPresentStreet.Text = res.present_street;
            //addresses permament
            cmbPermanentCountry.Text = res.permanent_country;
            cmbPermanentProvince.Text = res.permanent_province;
            cmbPermanentCity.Text = res.permanent_city;
            cmbPermanentBarangay.Text = res.permanent_barangay;
            txtPermanentStreet.Text = res.permanent_street;
            //voter status
            cmbIsVoter.Text = res.is_voter == 1 ? "YES" : "NO";
            cmbVoterType.Text = res.voter_type;
            cmbIsSK.Text = res.is_sk == 1 ? "YES" : "NO";
            txtPlaceReg.Text = res.place_registration;

            //mother & father information
            txtMotherLName.Text = res.mother_lname;
            txtMotherFName.Text = res.mother_fname;
            txtMotherMName.Text = res.mother_mname;
            txtMotherSuffix.Text = res.mother_suffix;
            txtFatherLName.Text = res.father_lname;
            txtFatherFName.Text = res.father_fname;
            txtFatherMName.Text = res.father_mname;
            txtFatherSuffix.Text = res.father_suffix;


            //other info
            cmbWaterSource.Text = res.water_source;
            cmbToilet.Text = res.toilet;
            cmbGarden.Text = res.garden;
            cmbContraceptive.Text = res.contraceptive;


            //survey
            cmbHaveComplain.Text = res.have_complain == 1 ? "YES" : "NO";
            txtAgainstWhom.Text = res.against_whom;
            cmbIsSettled.Text = res.is_settled == 1 ? "YES" : "NO";


            //date settled
            if(res.date_settled == null)
            {
                dtComplainWhen.Value = DateTime.Now;
                dtComplainWhen.Enabled = false;
            }
            else
            {
                dtComplainWhen.Value = Convert.ToDateTime(res.date_settled);
                dtComplainWhen.Enabled = true;
            }
            
            txtIfNotWhy.Text = res.if_not_why;
            cmbIsDeathMember.Text = res.is_death_aid == 1 ? "YES" : "NO";


            if (!String.IsNullOrEmpty(res.img_path))
            {
                string[] lines = System.IO.File.ReadAllLines(Application.StartupPath + "/config.txt");
                string path = lines[0] + resident_id + "_" + res.img_path + ".jpeg";

                pictureBox1.ImageLocation = path;
            }

           
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
            if (String.IsNullOrEmpty(txtLastname.Text))
            {
                Box.WarnBox("Please input lastname.");
                txtLastname.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtFirstname.Text))
            {
                Box.WarnBox("Please input lastname.");
                txtFirstname.Focus();
                return;
            }
            if (String.IsNullOrEmpty(cmbSex.Text))
            {
                Box.WarnBox("Please select sex.");
                cmbSex.Focus();
                return;
            }
            //filter address
            //present address
            if (String.IsNullOrEmpty(cmbPresentCountry.Text))
            {
                Box.WarnBox("Please select present country.");
                cmbPresentCountry.Focus();
                return;
            }
            if (String.IsNullOrEmpty(cmbPresentProvince.Text))
            {
                Box.WarnBox("Please select present province.");
                cmbPresentProvince.Focus();
                return;
            }
            if (String.IsNullOrEmpty(cmbPresentCity.Text))
            {
                Box.WarnBox("Please select present city.");
                cmbPresentCity.Focus();
                return;
            }
            if (String.IsNullOrEmpty(cmbPresentBarangay.Text))
            {
                Box.WarnBox("Please select present barangay.");
                cmbPresentBarangay.Focus();
                return;
            }
            //permanent address
            if (String.IsNullOrEmpty(cmbPermanentCountry.Text))
            {
                Box.WarnBox("Please select permanent country.");
                cmbPermanentCountry.Focus();
                return;
            }
            if (String.IsNullOrEmpty(cmbPermanentProvince.Text))
            {
                Box.WarnBox("Please select permanent province.");
                cmbPermanentProvince.Focus();
                return;
            }
            if (String.IsNullOrEmpty(cmbPermanentCity.Text))
            {
                Box.WarnBox("Please select permanent city.");
                cmbPermanentCity.Focus();
                return;
            }
            if (String.IsNullOrEmpty(cmbPermanentBarangay.Text))
            {
                Box.WarnBox("Please select permanent barangay.");
                cmbPermanentBarangay.Focus();
                return;
            }

            insertResident();
        }

        void saveImage(long i)
        {
            try
            {
                string[] lines = System.IO.File.ReadAllLines(Application.StartupPath + "/config.txt");
                Image img;
                img = pictureBox1.Image;

                string dir = Application.StartupPath;
                string nFilename = txtLastname.Text + "_" + txtFirstname.Text.Replace(" ", "");
                img.Save(lines[0] + i.ToString() + "_" + nFilename + ".jpeg", System.Drawing.Imaging.ImageFormat.Jpeg);
                //img.Save(@"F:\test\" + nFilename + ".jpeg", System.Drawing.Imaging.ImageFormat.Jpeg);
            }
            catch (Exception err)
            {

                //throw;
                Box.ErrBox(err.Message);
            }
            
        }

        void insertResident()
        {
            res.household_no = txthouseholdNo.Text;
            res.family_no = txtFamilyNo.Text;
            res.is_head = rbHead.Checked ? (short)1 : (short)0;
            res.lname = txtLastname.Text;
            res.fname = this.txtFirstname.Text.Trim();
            res.mname = this.txtMiddlename.Text.Trim();
            res.suffix = this.txtSuffix.Text.Trim();
            res.sex = this.cmbSex.Text;
            res.civil_status = this.cmbCivilStatus.Text;
            res.religion = this.cmbReligion.Text;
            res.nationality = this.cmbNationality.Text;
            res.employment_status = this.cmbEmploymentStatus.Text;
            res.occupation = this.txtOccupation.Text;
            res.annual_income = this.txtAnnualIncome.Value;
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
            res.permanent_country = this.cmbPermanentCountry.Text;
            res.permanent_province = this.cmbPermanentProvince.Text;
            res.permanent_city = this.cmbPermanentCity.Text;
            res.permanent_barangay = this.cmbPermanentBarangay.Text;
            res.permanent_street = this.txtPermanentStreet.Text;

            //voters info
            res.is_voter = cmbIsVoter.Text == "YES" ? (short)1 : (short)0;
            res.voter_type = this.cmbVoterType.Text;
            res.is_sk = cmbIsSK.Text == "YES" ? (short)1 : (short)0;
            res.place_registration = this.txtPlaceReg.Text;

            //mother & father info
            res.mother_lname = txtMotherLName.Text;
            res.mother_fname = txtMotherFName.Text;
            res.mother_mname = txtMotherMName.Text;
            res.mother_suffix = txtMotherSuffix.Text;
            res.father_lname = txtFatherLName.Text;
            res.father_fname = txtFatherFName.Text;
            res.father_mname = txtFatherMName.Text;
            res.father_suffix = txtFatherSuffix.Text;


            //'additional Info
            res.water_source = cmbWaterSource.Text;
            res.toilet = cmbToilet.Text;
            res.garden = cmbGarden.Text;
            res.contraceptive = cmbContraceptive.Text;

            //survey info
            res.have_complain = this.cmbHaveComplain.Text == "YES" ? (short)1 : (short)0;
            res.against_whom = this.txtAgainstWhom.Text;
            res.is_settled = this.cmbIsSettled.Text == "YES" ? (short)1 : (short)0;

            if(this.cmbIsSettled.Text == "YES")
            {
                res.date_settled = dtComplainWhen.Value.ToString("yyyy-MM-dd");
            }
            else
            {
                res.date_settled = null;
            }
            
            res.if_not_why = txtIfNotWhy.Text;
            res.is_death_aid = this.cmbIsDeathMember.Text == "YES" ? (short)1 : (short)0;

            //check if naa image sa pic 
            res.img_path = this.pictureBox1.Image != null ? txtLastname.Text + "_" + txtFirstname.Text.Replace(" ", "") : null;
            


            if (resident_id > 0)
            {
                res.update(resident_id, flxSibling, flxPet);
                if (this.pictureBox1.Image != null)
                {
                    res.img_path = txtLastname.Text + "_" + txtFirstname.Text.Replace(" ", "");
                    saveImage(resident_id);
                }
                    

                Box.InfoBox("Successfully update!");
            }
            else
            {
                resident_id = res.save(this.flxSibling, this.flxPet);
                txtResidentId.Text = "RES-" + resident_id.ToString("00000000");
                if(this.pictureBox1.Image != null)
                {
                    res.img_path = txtLastname.Text + "_" + txtFirstname.Text.Replace(" ", "");
                    saveImage(resident_id);
                }
                  

                Box.InfoBox("Successfully saved!");
            }

            _frm.loadData();
        }

        private void clear()
        {
            resident_id = 0;
            rbMember.Checked = true;
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
            txtAnnualIncome.Text = "";
            txtOccupation.Text = "";
            txtYearResidency.Text = "";
            txtPlaceBirth.Text = "";

            txtContactNumber.Text = "";
            txtEmailAddress.Text = "";
            txtValidID.Text = "";
            txtIDNumber.Text = "";

            txtMotherLName.Text = "";
            txtMotherFName.Text = "";
            txtMotherMName.Text = "";
            txtMotherSuffix.Text = "";
            txtFatherLName.Text = "";
            txtFatherFName.Text = "";
            txtFatherMName.Text = "";
            txtFatherSuffix.Text = "";

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

            pictureBox1.Image = null;

            //txtSiblingLname.Text = "";
            //txtSiblingFname.Text = "";
            //txtSiblingFname.Text = "";
            //cmbSiblingSex.SelectedIndex = -1;
            //cmbSiblingCivilStatus.SelectedIndex = -1;
            //cmbSiblingIsLiving.SelectedIndex = -1;

            flxSibling.Rows.Count = flxSibling.Rows.Fixed;
        

            cmbWaterSource.SelectedIndex = -1;
            cmbToilet.SelectedIndex = -1;
            cmbGarden.SelectedIndex = -1;
         
            cmbContraceptive.SelectedIndex = -1;

            flxPet.Rows.Count = this.flxPet.Rows.Fixed;

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

        private void flxSibling_SetupEditor(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
        {
            if (this.flxSibling.Cols[e.Col].Name == "lname" || this.flxSibling.Cols[e.Col].Name == "fname" ||
                this.flxSibling.Cols[e.Col].Name == "mname" || this.flxSibling.Cols[e.Col].Name == "suffix")
            {
                TextBox tb = this.flxSibling.Editor as TextBox;
                tb.CharacterCasing = CharacterCasing.Upper;
            }
        }

        private void checkIsSameWithPresentAddress_CheckedChanged(object sender, EventArgs e)
        {
            if(this.checkIsSameWithPresentAddress.Checked)
            {
                this.cmbPermanentCountry.Text = this.cmbPresentCountry.Text;
                this.cmbPermanentProvince.Text = this.cmbPresentProvince.Text;
                this.cmbPermanentCity.Text = this.cmbPresentCity.Text;
                this.cmbPermanentBarangay.Text = this.cmbPresentBarangay.Text;
                this.txtPermanentStreet.Text = this.txtPresentStreet.Text;
            }
        }

        private void cmbPermanentCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                address.provinces(this.cmbPermanentCountry.Text, cmbPermanentProvince);
            }
            catch (Exception er)
            {

                Box.ErrBox(er.Message);
            }
        }

        private void cmbPermanentCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                address.barangays(this.cmbPermanentProvince.Text, this.cmbPermanentCity.Text, cmbPermanentBarangay);
            }
            catch (Exception er)
            {
                Box.ErrBox(er.Message);
            }
        }

        private void cmbPermanentProvince_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                address.cities(this.cmbPermanentProvince.Text, cmbPermanentCity);
            }
            catch (Exception er)
            {
                Box.ErrBox(er.Message);
            }
        }

        private void btnNext4_Click(object sender, EventArgs e)
        {
            TabControl1.SelectedTab = tabSurvey;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnTakePic_Click(object sender, EventArgs e)
        {
            TakePicMainform frm = new TakePicMainform(this);
            frm.ShowDialog();
        }

        private void cmbIsSettled_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbIsSettled.Text == "YES")
            {
                dtComplainWhen.Enabled = true;
            }
            else
            {
                dtComplainWhen.Enabled = false;

            }
        }
    }
}
