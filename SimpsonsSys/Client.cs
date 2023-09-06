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
    class Client
    {
        #region private properties
        private int privCID = 0;
        private string privCFname = "";
        private string privCSname = "";
        private string privhouseno = "";
        private string privStreet = "";
        private string privTown = "";
        private string privPostcode = "";
        private string privPhoneNum = "";
        #endregion

        #region public properties
        public int CID
        {
            get { return privCID; }
            set { privCID = value; }
        }

        public string CFname
        {
            get { return privCFname; }
            set { privCFname = value; }
        }

        public string CSurname
        {
            get { return privCSname; }
            set { privCSname = value; }
        }

        public string CHouseNo
        {
            get { return privhouseno; }
            set { privhouseno = value; }
        }

        public string Cstreet
        {
            get { return privStreet; }
            set { privStreet = value; }
        }

        public string Ctown
        {
            get { return privTown; }
            set { privTown = value; }
        }

        public string Cpostcode
        {
            get { return privPostcode; }
            set { privPostcode = value; }
        }

        public string phoneNum
        {
            get { return privPhoneNum; }
            set { privPhoneNum = value; }
        }
        #endregion

        #region constructor 

        public Client(int ID, string name, string surname, string CHouseno, string cStreet, string cTown, string cPostcode,
            string cPhoneNo)
        {
            CID = ID;
            CFname = name;
            CSurname = surname;
            CHouseNo = CHouseno;
            Cstreet = cStreet;
            Ctown = cTown;
            Cpostcode = cPostcode;
            phoneNum = cPhoneNo;
        }

        public Client()
        {

        }
        #endregion

        #region methods

        //Retrieves all of the clients from the database
        public static List<Client> GetClients()
        {
            List<Client> list = new List<Client>();
            try
            {
                SqlDataAdapter newDataAdapter = new SqlDataAdapter("SELECT * FROM Client", dbConnect.dbConnection());
                DataTable dataResult = new DataTable();
                newDataAdapter.Fill(dataResult);

                foreach (DataRow record in dataResult.Rows)
                {
                    Client newClients = new Client(
                        (int)record["CID"],
                        record["CFname"].ToString(),
                        record["CSurname"].ToString(),
                        record["ChouseNo"].ToString(),
                        record["Cstreet"].ToString(),
                        record["Ctown"].ToString(),
                        record["Cpostcode"].ToString(),
                        record["phoneNum"].ToString()
                        );
                    list.Add(newClients);
                }
                return list;
            }
            catch (Exception errorMessageText)
            {
                MessageBox.Show("Problem with retrieving Clients" + errorMessageText);
                

                return new List<Client>();
            }
        }

        public static Client RetrieveByClientID(int ID)
        {
            try
            {
                SqlDataAdapter newDataAdapter = new SqlDataAdapter("SELECT * FROM Client WHERE CID = @CID", dbConnect.dbConnection());
                newDataAdapter.SelectCommand.Parameters.AddWithValue("@CID", ID);
                DataTable dataResult = new DataTable();
                newDataAdapter.Fill(dataResult);

                // Prohibits an error if the last record is deleted
                if (dataResult.Rows.Count > 0)
                {
                    //Get the customer record from database
                    DataRow clientRecord = dataResult.Rows[0];

                    Client newCustomer = new Client(
                        (int)clientRecord["CID"],
                        clientRecord["CFname"].ToString(),
                        clientRecord["CSurname"].ToString(),
                        clientRecord["ChouseNo"].ToString(),
                        clientRecord["Cstreet"].ToString(),
                        clientRecord["Ctown"].ToString(),
                        clientRecord["Cpostcode"].ToString(),
                        clientRecord["phoneNum"].ToString()
                        );

                    return newCustomer;
                }
                return null;
            }
            catch (Exception errorMessageText)
            {
                MessageBox.Show("Problem retreiving client by ID" + errorMessageText);
                return null;
            }
        }

        public static bool AddClient(Client newClient)
        {

            try
            {
                string insertQuery =
                    "INSERT INTO Client" +
                    "(CFname,CSurname,ChouseNo,Cstreet,Ctown,Cpostcode,phoneNum)" +
                    "VALUES " +
                    "(@CFname,@CSurname,@ChouseNo,@Cstreet,@Ctown,@Cpostcode,@phoneNum)";

                SqlCommand insertCommand = new SqlCommand(insertQuery, dbConnect.dbConnection());

                //if the Name is parsed as an integer then do not proceed
                if (Int32.TryParse(newClient.CFname, out var parse1) || Int32.TryParse(newClient.CSurname, out var parse2))
                {
                    MessageBox.Show("Name and surname must contain letters only");
                    return false;

                }
                else
                {
                    insertCommand.Parameters.AddWithValue("@CFname", newClient.CFname);
                    insertCommand.Parameters.AddWithValue("@CSurname", newClient.CSurname);
                    
                }

                //if the HouseNumber is parsed as an integer then allow adding a new Client
                if (Int32.TryParse(newClient.CHouseNo, out var parse3))
                {
                    insertCommand.Parameters.AddWithValue("@ChouseNo", newClient.CHouseNo);
                }
                else
                {
                    MessageBox.Show("house number must contain numbers only");
                    return false;
                }

                //if the Street is parsed as an integer then dont proceed
                if (Int32.TryParse(newClient.Cstreet, out var parse4) || Int32.TryParse(newClient.Ctown, out var parse5) || Int32.TryParse(newClient.Cpostcode, out var parse6))
                {
                    MessageBox.Show("Street,town and postcode must contain letters only");
                    return false;
                }
                else
                {
                    insertCommand.Parameters.AddWithValue("@Cstreet", newClient.Cstreet);
                    insertCommand.Parameters.AddWithValue("@Ctown", newClient.Ctown);
                    insertCommand.Parameters.AddWithValue("Cpostcode", newClient.Cpostcode);
                }

                //if the Phone number is parsed as an integer then allow adding a new client
                if (Int64.TryParse(newClient.phoneNum, out var parse8))
                {
                    insertCommand.Parameters.AddWithValue("@phoneNum", newClient.phoneNum);
                }
                else
                {
                    MessageBox.Show("phone number must contain numbers only");
                    return false;
                }

                insertCommand.Connection.Open();
                insertCommand.ExecuteNonQuery();
                insertCommand.Connection.Close();
                insertCommand.Connection.Dispose();
                return true;

            }
            catch (Exception errorMessage)
            {

                MessageBox.Show("problem occured when adding new client" + errorMessage);
            }
            return false;
        }
        #endregion



    }
}