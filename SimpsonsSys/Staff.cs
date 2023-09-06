using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpsonsSys
{
    class Staff
    {
        #region private properties
        private int privSID = 0;
        private string privSFname = "";
        private string privSSurname = "";
        private bool privIsAdmin = false;
        private string privUsername = "";
        private string privPass = "";
        #endregion

        #region public properties
        public int SID
        {
            get { return privSID; }
            set { privSID = value; }
        }

        public string SFname
        {
            get { return privSFname; }
            set { privSFname = value; }
        }

        public string SSurname
        {
            get { return privSSurname; }
            set { privSSurname = value; }
        }

        public bool isAdmin
        {
            get { return privIsAdmin; }
            set { privIsAdmin = value; }
        }

        public string Username
        {
            get { return privUsername; }
            set { privUsername = value; }
        }

        public string Pass
        {
            get { return privPass; }
            set { privPass = value; }
        }
        #endregion

        #region constructor
        public Staff()
        {

        }

        public Staff(int sid, string fname, string sname,bool admin, string usr, string passwd )
        {
            SID = sid;
            SFname = fname;
            SSurname = sname;
            isAdmin = admin;
            Username = usr;
            Pass = passwd;
        }
        #endregion

        #region Methods

        public static List<Staff> GetStaff()
        {
            List<Staff> list2 = new List<Staff>();
            try
            {
                SqlDataAdapter newDataAdapter = new SqlDataAdapter("SELECT * FROM Staff", dbConnect.dbConnection());
                DataTable dataResult = new DataTable();
                newDataAdapter.Fill(dataResult);

                foreach (DataRow record in dataResult.Rows)
                {
                    Staff newStaff = new Staff(
                        (int)record["SID"],
                        record["SFname"].ToString(),
                        record["SSurname"].ToString(),
                        (bool)record["IsAdmin"],
                        record["Username"].ToString(),
                        record["Pass"].ToString()
                       
                        );
                    list2.Add(newStaff);
                }
                return list2;
            }
            catch (Exception errorMessageText)
            {
                MessageBox.Show("Problem occured when retrieving Staff" + errorMessageText);


                return new List<Staff>();
            }
        }

        public static Staff RetrieveBySID(int ID)
        {
            try
            {
                SqlDataAdapter newDataAdapter = new SqlDataAdapter("SELECT * FROM Staff WHERE SID = @SID", dbConnect.dbConnection());
                newDataAdapter.SelectCommand.Parameters.AddWithValue("@SID", ID);
                DataTable dataResult = new DataTable();
                newDataAdapter.Fill(dataResult);

                // Prohibits an error if the last record is deleted
                if (dataResult.Rows.Count > 0)
                {
                    //Get the staff record from database
                    DataRow staffRecord = dataResult.Rows[0];

                    Staff newStaff = new Staff(
                        (int)staffRecord["SID"],
                        staffRecord["SFname"].ToString(),
                        staffRecord["SSurname"].ToString(),
                        (bool)staffRecord["IsAdmin"],
                        staffRecord["Username"].ToString(),
                        staffRecord["Pass"].ToString()
                        ) ;

                    return newStaff;
                }
                return null;
            }
            catch (Exception errorMessageText)
            {
                MessageBox.Show("problem with retriving staff by ID" + errorMessageText);
                return null;
            }
        }

        public static bool AddStaff(Staff newStaff)
        {

            try
            {
                string insertQuery =
                    "INSERT INTO Staff " +
                    "(SFname,SSurname,IsAdmin,Username,Pass) " +
                    "VALUES " +
                    "(@SFname,@SSurname,@IsAdmin,@Username,@Pass)";

                SqlCommand insertCommand = new SqlCommand(insertQuery, dbConnect.dbConnection());

                if (Int32.TryParse(newStaff.SFname, out var parse1) || Int32.TryParse(newStaff.SSurname, out var parse2) || newStaff.SFname == ""|| newStaff.SSurname == "")
                {
                    MessageBox.Show("Name and surname must contain letters only");
                    return false;

                }
                else
                {
                    insertCommand.Parameters.AddWithValue("@SFname", newStaff.SFname);
                    insertCommand.Parameters.AddWithValue("@SSurname", newStaff.SSurname);
                    insertCommand.Parameters.AddWithValue("@IsAdmin", newStaff.isAdmin);
                }
                if (Int32.TryParse(newStaff.Username, out var parse3) || Int32.TryParse(newStaff.Pass, out var parse4) || newStaff.Username == ""|| newStaff.Pass == "")
                {
                 MessageBox.Show("Username must contain letters and password must contain a  mixture of letters and numbers");
                    return false;
                }
                else
                {

                    insertCommand.Parameters.AddWithValue("@Username", newStaff.Username);
                    insertCommand.Parameters.AddWithValue("@Pass", newStaff.Pass);
                }
               
                insertCommand.Connection.Open();
                insertCommand.ExecuteNonQuery();
                insertCommand.Connection.Close();
                insertCommand.Connection.Dispose();
                return true;

            }
            catch (Exception errorMessage)
            {

                MessageBox.Show("problem occured when adding new Staff" + errorMessage);
            }
            return false;
        }

        public static Staff Login(string user, string pass)
        {
            try
            {
                SqlDataAdapter staffDataAdapter = new SqlDataAdapter("SELECT * FROM Staff WHERE Username = @Username AND Pass = @Pass", dbConnect.dbConnection());
                staffDataAdapter.SelectCommand.Parameters.AddWithValue("@Username", user);
                staffDataAdapter.SelectCommand.Parameters.AddWithValue("@Pass", pass);
                DataTable dataresult = new DataTable();

                staffDataAdapter.Fill(dataresult);

                if (dataresult.Rows.Count > 0)
                {
                    DataRow staffRecords = dataresult.Rows[0];

                    Staff staff = new Staff(

                    (int)staffRecords["SID"],
                    staffRecords["SFname"].ToString(),
                    staffRecords["SSurname"].ToString(),
                    (bool)staffRecords["IsAdmin"],
                    staffRecords["Username"].ToString(),
                    staffRecords["Pass"].ToString()
                    );

                    return staff;
                }
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to find Staff member", ex.Message);
                return null;
            }
        }
        #endregion
    }
}