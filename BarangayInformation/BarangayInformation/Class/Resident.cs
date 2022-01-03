using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;

using C1.Win.C1FlexGrid;

namespace BarangayInformation.Class
{
    class Resident
    {
        MySqlConnection con;
        MySqlCommand cmd;
        string query;

        public long resident_id { set; get; }
        public string household_no { set; get; }
        public string family_no { set; get; }
        public short is_head { set; get; }
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
        public decimal annual_income { set; get; }
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

        public C1FlexGrid flxSibling;


        public Int16 have_complain { set; get; }
        public string against_whom { set; get; }

        public Int16 is_settled { set; get; }
        public string date_settled { set; get; }

        public string if_not_why { set; get; }

        public short is_death_aid { set; get; }

        public string img_path { set; get; }

        public C1FlexGrid flxPet;


        //locale declaration
        ArrayList res_sibling_ids = new ArrayList();
        ArrayList res_pets_ids = new ArrayList();

        ArrayList res_sibling_ids_database = new ArrayList();
        ArrayList res_pets_ids_database = new ArrayList();


        public int save(C1FlexGrid flxSibling, C1FlexGrid flxPet)
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
                    have_complain=?havecomplain, against_whom=?whom, is_settled=?issettled, date_settled=?when, if_not_why=?why, is_death_aid=@isaid, img_path=?img; SELECT last_insert_id();";
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
                cmd.Parameters.AddWithValue("?per_country", this.permanent_country);
                cmd.Parameters.AddWithValue("?per_province", this.permanent_province);
                cmd.Parameters.AddWithValue("?per_city", this.permanent_city);
                cmd.Parameters.AddWithValue("?per_brgy", this.permanent_barangay);
                cmd.Parameters.AddWithValue("?per_street", this.permanent_street);

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

                cmd.Parameters.AddWithValue("?img", this.img_path);

                int i = Convert.ToInt32(cmd.ExecuteScalar());
                cmd.Dispose();


                if(flxSibling.Rows.Count > 1)
                {
                    query = @"INSERT INTO resident_siblings SET resident_id = ?resid, lname=?lname, fname=?fname, mname=?mname, suffix=?suffix,
                            sex=?sex, civil_status=?cstatus, bdate=?bdate, is_living_with_you = ?isliving; SELECT LAST_INSERT_ID();";
                    cmd = new MySqlCommand(query, con);
                    for (int row = 1; row <= flxSibling.Rows.Count - 2; row++)
                    {
                        cmd.Parameters.AddWithValue("?resid", i);
                        cmd.Parameters.AddWithValue("?lname", Convert.ToString(flxSibling[row, "lname"]));
                        cmd.Parameters.AddWithValue("?fname", Convert.ToString(flxSibling[row, "fname"]));
                        cmd.Parameters.AddWithValue("?mname", Convert.ToString(flxSibling[row, "mname"]));
                        cmd.Parameters.AddWithValue("?suffix", Convert.ToString(flxSibling[row, "suffix"]));
                        cmd.Parameters.AddWithValue("?sex", Convert.ToString(flxSibling[row, "sex"]));
                        cmd.Parameters.AddWithValue("?cstatus", Convert.ToString(flxSibling[row, "civil_status"]));
                        cmd.Parameters.AddWithValue("?bdate", Convert.ToString(flxSibling[row, "bdate"]));
                        cmd.Parameters.AddWithValue("?isliving", Convert.ToString(flxSibling[row, "is_living_with_you"]));
                        int res_sibling_id = Convert.ToInt32(cmd.ExecuteScalar());
                        flxSibling[row, "resident_sibling_id"] = res_sibling_id;
                        cmd.Parameters.Clear();
                    }
                    cmd.Dispose();
                }

                if (flxPet.Rows.Count > 1)
                {
                    query = @"INSERT INTO resident_pets SET resident_id = ?resid, pet=?pet, no_pet=?npet; SELECT LAST_INSERT_ID();";
                    cmd = new MySqlCommand(query, con);
                    for (int row = 1; row <= flxPet.Rows.Count - 2; row++)
                    {
                        cmd.Parameters.AddWithValue("?resid", i);
                        cmd.Parameters.AddWithValue("?pet", Convert.ToString(flxPet[row, "pet"]));
                        cmd.Parameters.AddWithValue("?npet", Convert.ToString(flxPet[row, "no_pet"]));
                        int res_pet_id = Convert.ToInt32(cmd.ExecuteScalar());
                        flxPet[row, "resident_pet_id"] = res_pet_id;
                        cmd.Parameters.Clear();
                    }
                    cmd.Dispose();
                }


                return i;
            }
            catch (Exception er)
            {        
                Box.ErrBox(er.Message);
                return 0;
            }
        }




        public int update(long id, C1FlexGrid flxSibling, C1FlexGrid flxPet)
        {

            res_sibling_ids_database.Clear();
            res_sibling_ids.Clear();
            try
            {

            }
            catch (Exception er)
            {
                throw;
                Box.ErrBox(er.Message);
                return 0;
            }


            con = Connection.con();
            con.Open();
            query = @"UPDATE residents SET 
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
                    have_complain=?havecomplain, against_whom=?whom, is_settled=?issettled, date_settled=?when, if_not_why=?why, is_death_aid=@isaid WHERE resident_id = ?id";
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
            cmd.Parameters.AddWithValue("?per_country", this.permanent_country);
            cmd.Parameters.AddWithValue("?per_province", this.permanent_province);
            cmd.Parameters.AddWithValue("?per_city", this.permanent_city);
            cmd.Parameters.AddWithValue("?per_brgy", this.permanent_barangay);
            cmd.Parameters.AddWithValue("?per_street", this.permanent_street);

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
            cmd.Parameters.AddWithValue("?id", id);
            int i = Convert.ToInt32(cmd.ExecuteNonQuery());
            cmd.Dispose();


            if (flxSibling.Rows.Count > 1)
            {
                int res_sibling_id = 0;
                cmd = new MySqlCommand(query, con);
                for (int row = 1; row <= flxSibling.Rows.Count - 2; row++)
                {
                    string resN = Convert.ToString(flxSibling[row, "resident_sibling_id"]);
                    //Box.InfoBox(resN);
                    if (String.IsNullOrEmpty(resN))
                    {
                        //insert
                        query = @"INSERT INTO resident_siblings SET resident_id = ?resid, lname=?lname, fname=?fname, mname=?mname, suffix=?suffix,
                                    sex=?sex, civil_status=?cstatus, bdate=?bdate, is_living_with_you = ?isliving; SELECT LAST_INSERT_ID();";
                        cmd = new MySqlCommand(query, con);
                        cmd.Parameters.AddWithValue("?resid", id);
                        cmd.Parameters.AddWithValue("?lname", Convert.ToString(flxSibling[row, "lname"]));
                        cmd.Parameters.AddWithValue("?fname", Convert.ToString(flxSibling[row, "fname"]));
                        cmd.Parameters.AddWithValue("?mname", Convert.ToString(flxSibling[row, "mname"]));
                        cmd.Parameters.AddWithValue("?suffix", Convert.ToString(flxSibling[row, "suffix"]));
                        cmd.Parameters.AddWithValue("?sex", Convert.ToString(flxSibling[row, "sex"]));
                        cmd.Parameters.AddWithValue("?cstatus", Convert.ToString(flxSibling[row, "civil_status"]));
                        cmd.Parameters.AddWithValue("?bdate", Convert.ToString(flxSibling[row, "bdate"]));
                        cmd.Parameters.AddWithValue("?isliving", Convert.ToString(flxSibling[row, "is_living_with_you"]));
                        res_sibling_id = Convert.ToInt32(cmd.ExecuteScalar());
                        cmd.Parameters.Clear();

                        //after insert add in array list
                        flxSibling[row, "resident_sibling_id"] = res_sibling_id;
                        res_sibling_ids.Add(res_sibling_id);
                    }
                    else
                    {
                        //update
                        //save id in array
                        res_sibling_id = Convert.ToInt32(flxSibling[row, "resident_sibling_id"]);
                        res_sibling_ids.Add(res_sibling_id);

                        query = @"UPDATE resident_siblings SET resident_id = ?resid, lname=?lname, fname=?fname, mname=?mname, suffix=?suffix,
                                    sex=?sex, civil_status=?cstatus, bdate=?bdate, is_living_with_you = ?isliving WHERE resident_sibling_id = ?id";
                        cmd = new MySqlCommand(query, con);
                        cmd.Parameters.AddWithValue("?resid", id);
                        cmd.Parameters.AddWithValue("?lname", Convert.ToString(flxSibling[row, "lname"]));
                        cmd.Parameters.AddWithValue("?fname", Convert.ToString(flxSibling[row, "fname"]));
                        cmd.Parameters.AddWithValue("?mname", Convert.ToString(flxSibling[row, "mname"]));
                        cmd.Parameters.AddWithValue("?suffix", Convert.ToString(flxSibling[row, "suffix"]));
                        cmd.Parameters.AddWithValue("?sex", Convert.ToString(flxSibling[row, "sex"]));
                        cmd.Parameters.AddWithValue("?cstatus", Convert.ToString(flxSibling[row, "civil_status"]));
                        cmd.Parameters.AddWithValue("?bdate", Convert.ToString(flxSibling[row, "bdate"]));
                        cmd.Parameters.AddWithValue("?isliving", Convert.ToString(flxSibling[row, "is_living_with_you"]));
                        cmd.Parameters.AddWithValue("?id", resN);
                        cmd.ExecuteNonQuery();
                        cmd.Parameters.Clear();
                    }

                }
                cmd.Dispose();
            }//if row greater than 0

            //delete siblings if there is missing
            //get all ids from databse and compare to dgrid ids
            query = "SELECT * FROM resident_siblings WHERE resident_id = @res_id";
            cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("@res_id", id);
            MySqlDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                res_sibling_ids_database.Add(Convert.ToInt32(dr["resident_sibling_id"]));
            }
            dr.Close();
            cmd.Dispose();

            foreach(int item in res_sibling_ids_database)
            {
                if (!res_sibling_ids.Contains(item))
                {
                    cmd = new MySqlCommand("DELETE FROM resident_siblings WHERE resident_sibling_id = @res_sib_id", con);
                    cmd.Parameters.AddWithValue("@res_sib_id", item);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                }
            }



            //PET Save and Edit
            if (flxPet.Rows.Count > 1)
            {
                int res_pet_id = 0;
                cmd = new MySqlCommand(query, con);
                for (int row = 1; row <= flxPet.Rows.Count - 2; row++)
                {
                    string resN = Convert.ToString(flxPet[row, "resident_pet_id"]);
                    //Box.InfoBox(resN);
                    if (String.IsNullOrEmpty(resN))
                    {
                        //insert
                        query = @"INSERT INTO resident_pets SET resident_id = ?resid, pet=?pet, no_pet=?no_pet; SELECT LAST_INSERT_ID();";
                        cmd = new MySqlCommand(query, con);
                        cmd.Parameters.AddWithValue("?resid", id);
                        cmd.Parameters.AddWithValue("?pet", Convert.ToString(flxPet[row, "pet"]));
                        cmd.Parameters.AddWithValue("?no_pet", Convert.ToString(flxPet[row, "no_pet"]));
                       
                        res_pet_id = Convert.ToInt32(cmd.ExecuteScalar());
                        cmd.Parameters.Clear();

                        //after insert add in array list
                        flxPet[row, "resident_pet_id"] = res_pet_id;
                        res_pets_ids.Add(res_pet_id);
                    }
                    else
                    {
                        //update
                        //save id in array
                        res_pet_id = Convert.ToInt32(flxPet[row, "resident_pet_id"]);
                        res_pets_ids.Add(res_pet_id);

                        query = @"UPDATE resident_pets SET resident_id = ?resid, pet=?pet, no_pet=?no_pet WHERE resident_pet_id = ?id";
                        cmd = new MySqlCommand(query, con);
                        cmd.Parameters.AddWithValue("?resid", id);
                        cmd.Parameters.AddWithValue("?pet", Convert.ToString(flxPet[row, "pet"]));
                        cmd.Parameters.AddWithValue("?no_pet", Convert.ToString(flxPet[row, "no_pet"]));
                        cmd.Parameters.AddWithValue("?id", resN);
                        cmd.ExecuteNonQuery();
                        cmd.Parameters.Clear();
                    }

                }
                cmd.Dispose();
            }//if row greater than 0

            //delete pet if there is missing
            //get all ids from databse and compare to dgrid ids
            query = "SELECT * FROM resident_pets WHERE resident_id = @res_id";
            cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("@res_id", id);
            //MySqlDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                res_pets_ids_database.Add(Convert.ToInt32(dr["resident_pet_id"]));
            }
            dr.Close();
            cmd.Dispose();

            foreach (int item in res_pets_ids_database)
            {
                if (!res_pets_ids.Contains(item))
                {
                    cmd = new MySqlCommand("DELETE FROM resident_pets WHERE resident_pet_id = @res_pet_id", con);
                    cmd.Parameters.AddWithValue("@res_pet_id", item);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                }
            }



            return i;
        }

        public int delete(int id)
        {
            con = Connection.con();
            con.Open();
            query = "DELETE FROM residents WHERE resident_id = ?id";
            cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("?id", id);
            int i = cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
            con.Dispose();
            return i;
        }

        public void find(C1FlexGrid flx, string slname, string sfname, string sresNo)
        {
            try
            {
                con = Connection.con();
                con.Open();
                query = "SELECT * FROM residents WHERE lname LIKE ?lname AND fname LIKE ?fname AND resident_id LIKE ?res_id ORDER BY lname ASC";
                cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?lname", slname + "%");
                cmd.Parameters.AddWithValue("?fname", sfname + "%");
                cmd.Parameters.AddWithValue("?res_id", sresNo + "%");
                DataTable dt = new DataTable(); 
                MySqlDataAdapter adtpr = new MySqlDataAdapter(cmd);
                adtpr.Fill(dt);
                cmd.Dispose();
               
                con.Close();
                con.Dispose();

                flx.AutoGenerateColumns = false;
                flx.DataSource = dt;
            }
            catch (Exception er)
            {
                Box.ErrBox(er.Message);
            }
        }

        public void getData(long id, C1FlexGrid flxSibling, C1FlexGrid flxPet)
        {
            con = Connection.con();
            con.Open();

            query = "SELECT * FROM residents WHERE resident_id = ?id";
            cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("?id", id);
            DataTable dt= new DataTable();
            MySqlDataAdapter adprtr = new MySqlDataAdapter(cmd);
            adprtr.Fill(dt);
            adprtr.Dispose();
            cmd.Dispose();

            if(dt.Rows.Count > 0)
            {
                //personal info
                resident_id = id;
                fname = Convert.ToString(dt.Rows[0]["fname"]);
                lname = Convert.ToString(dt.Rows[0]["lname"]);
                mname = Convert.ToString(dt.Rows[0]["mname"]);
                suffix = Convert.ToString(dt.Rows[0]["suffix"]);
                civil_status = Convert.ToString(dt.Rows[0]["civil_status"]);
                religion = Convert.ToString(dt.Rows[0]["religion"]);
                nationality = Convert.ToString(dt.Rows[0]["nationality"]);
                employment_status = Convert.ToString(dt.Rows[0]["employment_status"]);
                occupation = Convert.ToString(dt.Rows[0]["occupation"]);
                annual_income = Convert.ToDecimal(dt.Rows[0]["annual_income"]);
                year_residence = Convert.ToString(dt.Rows[0]["year_residence"]);

                //bdate information
                bdate = Convert.ToString(dt.Rows[0]["bdate"]);
                place_of_birth = Convert.ToString(dt.Rows[0]["place_of_birth"]);

                //contact info
                contact_no = Convert.ToString(dt.Rows[0]["contact_no"]);
                email = Convert.ToString(dt.Rows[0]["email"]);
                type_valid_id = Convert.ToString(dt.Rows[0]["type_valid_id"]);
                id_no = Convert.ToString(dt.Rows[0]["id_no"]);

                //addree present
                present_country = Convert.ToString(dt.Rows[0]["present_country"]);
                present_province = Convert.ToString(dt.Rows[0]["present_province"]);
                present_city = Convert.ToString(dt.Rows[0]["present_city"]);
                present_barangay = Convert.ToString(dt.Rows[0]["present_barangay"]);
                present_street = Convert.ToString(dt.Rows[0]["present_street"]);
                //address permanent
                permanent_country = Convert.ToString(dt.Rows[0]["permanent_country"]);
                permanent_province = Convert.ToString(dt.Rows[0]["permanent_province"]);
                permanent_city = Convert.ToString(dt.Rows[0]["permanent_city"]);
                permanent_barangay = Convert.ToString(dt.Rows[0]["permanent_barangay"]);
                permanent_street = Convert.ToString(dt.Rows[0]["permanent_street"]);

                //voter status
                is_voter = Convert.ToSByte(dt.Rows[0]["is_voter"]);
                voter_type = Convert.ToString(dt.Rows[0]["voter_type"]);
                is_sk = Convert.ToSByte(dt.Rows[0]["is_sk"]);
                place_registration = Convert.ToString(dt.Rows[0]["place_registration"]);

                //Other info
                water_source = Convert.ToString(dt.Rows[0]["water_source"]);
                toilet = Convert.ToString(dt.Rows[0]["toilet"]);
                garden = Convert.ToString(dt.Rows[0]["garden"]);
                contraceptive = Convert.ToString(dt.Rows[0]["contraceptive"]);

            }

            query = "SELECT * FROM resident_siblings WHERE resident_id = ?id";
            cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("?id", id);
            DataTable dtSIblings = new DataTable();
            adprtr = new MySqlDataAdapter(cmd);
            adprtr.Fill(dtSIblings);
            //'Siblings = New DataGridView
            //'Box.InfoBox(dtSIblings.Rows.Count)
            flxSibling.AutoGenerateColumns = false;
            //flxSibling.DataSource = dtSIblings;
            int row = 0;

            for(row = 0; row < dtSIblings.Rows.Count; row++)
            {
                flxSibling.Rows.Add();
                flxSibling[row + 1, "resident_sibling_id"] = Convert.ToInt32(dtSIblings.Rows[row]["resident_sibling_id"]);
                flxSibling[row + 1, "lname"] = Convert.ToString(dtSIblings.Rows[row]["lname"]);
                flxSibling[row + 1, "fname"] = Convert.ToString(dtSIblings.Rows[row]["fname"]);
                flxSibling[row + 1, "mname"] = Convert.ToString(dtSIblings.Rows[row]["mname"]);
                flxSibling[row + 1, "suffix"] = Convert.ToString(dtSIblings.Rows[row]["suffix"]);
                flxSibling[row + 1, "sex"] = Convert.ToString(dtSIblings.Rows[row]["sex"]);
            }

            adprtr.Dispose();
            cmd.Dispose();

            query = "SELECT * FROM resident_pets WHERE resident_id = ?id";
            cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("?id", id);
            MySqlDataReader dr;
            dr = cmd.ExecuteReader();
            row = 1;

            while (dr.Read())
            {
                flxPet.Rows.Add();
                flxPet[row, "resident_pet_id"] = Convert.ToInt64(dr["resident_pet_id"]);
                flxPet[row, "pet"] = Convert.ToString(dr["pet"]);
                flxPet[row, "no_pet"] = Convert.ToInt32(dr["no_pet"]);
                row++;
            }
            dr.Close();
            cmd.Dispose();
            con.Close();
            con.Dispose();
        }


    }
}
