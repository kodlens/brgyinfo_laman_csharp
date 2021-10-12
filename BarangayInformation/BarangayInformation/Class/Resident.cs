using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;

namespace BarangayInformation.Class
{
    class Resident
    {
        MySqlConnection con;
        MySqlCommand cmd;
        string query;

        public string household_no { set; get; }
        public string family_no { set; get; }
        public bool is_head { set; get; }
        public string lname { set; get; }
        public string fname { set; get; }
        public string mname { set; get; }
        public string suffix { set; get; }
        public string sex { set; get; }
        public string civil_status { set; get; }
        public string religion { set; get; }
        public string nationality { set; get; }
        public string employment_status { set; get; }
        public string occupation { set; get; }
        public double annual_income { set; get; }
        public string year_residence { set; get; }
        public string bdate { set; get; }
        public string place_of_birth { set; get; }

        //contact no
        public string contact_no { set; get; }
        public string email { set; get; }
        public string type_valid_id { set; get; }
        public string id_no { set; get; }

        //address
        public string present_country { set; get; }
        public string present_province { set; get; }
        public string present_city { set; get; }
        public string present_barangay { set; get; }
        public string present_street { set; get; }


        public string permanent_country { set; get; }
        public string permanent_province { set; get; }
        public string permanent_city { set; get; }
        public string permanent_barangay { set; get; }
        public string permanent_street { set; get; }

        public Int16 is_voter { set; get; }
        public string voter_type { set; get; }
        public Int16 is_sk { set; get; }
        public string place_registration { set; get; }

        public string water_source { set; get; }
        public string toilet { set; get; }
        public string garden { set; get; }
        public string contraceptive { set; get; }


        public Int16 have_complain { set; get; }
        public string against_whom { set; get; }

        public Int16 is_settled { set; get; }
        public string date_settled { set; get; }

        public string if_not_why { set; get; }

        public string is_death_aid { set; get; }



        //locale declaration
        ArrayList res_sibling_ids = new ArrayList();
        ArrayList res_pets_ids = new ArrayList();

        ArrayList res_sibling_ids_databse = new ArrayList();
        ArrayList res_pets_ids_database = new ArrayList();


        public void save()
        {
            try
            {
                con = Connection.con();
                con.Open();
                query = @"INSERT INTO residents SET 
                    is_head = ?ishead,
                    household_no = ?household_no, family_no = ?family_no, lname = ?lname, fname = ?fname, mname = ?mname,
                    suffix = ?suffix, sex = ?sex, civil_status = ?cstatus,
                    religion = ?religion, nationality = ?nationality,
                    employment_status = ?employment, occupation = ?occupation, annual_income = ?annual_income, year_residence = ?yr_residence,
                    bdate = ?bdate, place_of_birth = ?placebdate, 
                    contact_no = ?contact, email = ?email, type_valid_id = ?typeId, id_no = ?idno,
                    present_country = ?pre_country, present_province = ?pre_province, present_city = ?pre_city, present_barangay = ?pre_brgy, present_street = ?pre_street,
                    permanent_country = ?per_country, permanent_province = ?per_province, permanent_city = ?per_city, permanent_barangay = ?per_brgy, permanent_street = ?per_street,
                    is_voter = ?isvoter, voter_type = ?voter_type, is_sk = ?issk, place_registration = ?placereg,
                    water_source=?wsource, toilet=?toilet, garden=?garden, contraceptive=?contraceptive,
                    have_complain=?havecomplain, against_whom=?whom, is_settled=?issettled, date_settled=?when, if_not_why=?why, is_death_aid=@isaid; SELECT last_insert_id()";
                cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?ishead", this.is_head);
                cmd.Parameters.AddWithValue("?household_no", this.household_no);
                cmd.Parameters.AddWithValue("?family_no", this.family_no);
                cmd.Parameters.AddWithValue("?lname", this.lname);
                cmd.Parameters.AddWithValue("?fname", this.fname);
                cmd.Parameters.AddWithValue("?mname", this.mname);
                cmd.Parameters.AddWithValue("?suffix", this.suffix);
                cmd.Parameters.AddWithValue("?sex", this.sex);
                cmd.Parameters.AddWithValue("?cstatus", this.civil_status);
                cmd.Parameters.AddWithValue("?religion", this.religion);
                cmd.Parameters.AddWithValue("?nationality", this.nationality);
                cmd.Parameters.AddWithValue("?employment", this.employment_status);
                cmd.Parameters.AddWithValue("?occupation", this.occupation);
                cmd.Parameters.AddWithValue("?annual_income", this.annual_income);
                cmd.Parameters.AddWithValue("?yr_residence", this.year_residence);
                cmd.Parameters.AddWithValue("?bdate", this.bdate);
                cmd.Parameters.AddWithValue("?placebdate", this.place_of_birth);

                //contact
                cmd.Parameters.AddWithValue("?contact", this.contact_no);
                cmd.Parameters.AddWithValue("?email", this.email);
                cmd.Parameters.AddWithValue("?typeId", this.type_valid_id);
                cmd.Parameters.AddWithValue("?idno", this.id_no);

                //present address
                cmd.Parameters.AddWithValue("?pre_country", this.present_country);
                cmd.Parameters.AddWithValue("?pre_province", this.present_province);
                cmd.Parameters.AddWithValue("?pre_city", this.present_city);
                cmd.Parameters.AddWithValue("?pre_brgy", this.present_barangay);
                cmd.Parameters.AddWithValue("?pre_street", this.present_street);

                //permament address
                cmd.Parameters.AddWithValue("?pre_country", this.permanent_country);
                cmd.Parameters.AddWithValue("?pre_province", this.permanent_province);
                cmd.Parameters.AddWithValue("?pre_city", this.permanent_city);
                cmd.Parameters.AddWithValue("?pre_brgy", this.permanent_barangay);
                cmd.Parameters.AddWithValue("?pre_street", this.permanent_street);

                //voters info
                cmd.Parameters.AddWithValue("?isvoter", this.is_voter);
                cmd.Parameters.AddWithValue("?voter_type", this.voter_type);
                cmd.Parameters.AddWithValue("?issk", this.is_sk);
                cmd.Parameters.AddWithValue("?placereg", this.place_registration);

                //additional info
                cmd.Parameters.AddWithValue("?wsource", this.water_source);
                cmd.Parameters.AddWithValue("?toilet", this.toilet);
                cmd.Parameters.AddWithValue("?garden", this.garden);
                cmd.Parameters.AddWithValue("?contraceptive", this.contraceptive);

                //Survey info
                cmd.Parameters.AddWithValue("?havecomplain", this.have_complain);
                cmd.Parameters.AddWithValue("?whom", this.against_whom);
                cmd.Parameters.AddWithValue("?issettled", this.is_settled);

                string dateSettled = "";
                dateSettled = this.is_settled > 0 ? this.date_settled : "";
                //IIf(Me.IsSettled > 0, dateSettiled = Me.DateSettled, dateSettiled = "")
                cmd.Parameters.AddWithValue("?when", dateSettled);
                cmd.Parameters.AddWithValue("?why", this.if_not_why);
                cmd.Parameters.AddWithValue("?isaid", this.is_death_aid);

                int i = Convert.ToInt32(cmd.ExecuteScalar());
                cmd.Dispose();

            }
            catch (Exception er)
            {
                Box.ErrBox(er.Message);
            }
        }

        public void update(int id)
        {

        }

        public void delete(int id)
        {

        }

        public void all(DataGridView grid)
        {
            try
            {
                con = Connection.con();
                con.Open();
                query = "SELECT * FROM residents ORDER BY lname ASC";
                cmd = new MySqlCommand(query, con);
                DataTable dt = new DataTable();
                MySqlDataAdapter adtpr = new MySqlDataAdapter(cmd);
                adtpr.Fill(dt);
                cmd.Dispose();
               
                con.Close();
                con.Dispose();

                grid.AutoGenerateColumns = false;
                grid.DataSource = dt;
            }
            catch (Exception er)
            {

                Box.ErrBox(er.Message);
            }
        }


    }
}
