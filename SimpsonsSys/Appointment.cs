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
    class Appointment
    {

        #region private properties
        private int id = 0;
        private int cid = 0;
        private int sid = 0;
        private int measurements = 0;
        private string fabChosen = "";
        private DateTime furtDate;
        private decimal estPrice = 0m;
        private bool depositPaid = false;
        #endregion

        #region public properties

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public int CId
        {
            get { return cid; }
            set { cid = value; }
        }

        public int SId
        {
            get { return sid; }
            set { sid = value; }
        }


        public int Measurements
        {
            get { return measurements; }
            set
            { measurements = value;}
        }

        public string FabChosen
        {
            get { return fabChosen; }
            set { fabChosen = value; }
        }

        public DateTime Furtdate
        {
            get { return furtDate; }
            set { furtDate = value; }
        }

        public decimal EstPrice
        {
            get { return estPrice; }
            set { estPrice = value; }
        }

        public bool DepositPaid
        {
            get { return depositPaid; }
            set { depositPaid = value; }
        }

        #endregion

        #region Constructor
        public Appointment(int ids, int cids, int sids,  int measure, string fabric, DateTime date, decimal est, bool deposit)
        {
            Id = ids;
            CId = cids;
            SId = sids;
            Measurements = measure;
            FabChosen = fabric;
            Furtdate = date;
            EstPrice = est;
            DepositPaid = deposit;
        }

        public Appointment()
        {

        }
        #endregion

        #region Methods

        public static List<Appointment> GetAppointment()
        {
            List<Appointment> list = new List<Appointment>();
            try
            {
                SqlDataAdapter newDataAdapter = new SqlDataAdapter("SELECT * FROM Appointment", dbConnect.dbConnection());
                DataTable dataResult = new DataTable();
                newDataAdapter.Fill(dataResult);

                foreach (DataRow record in dataResult.Rows)
                {
                    Appointment newAppoint = new Appointment
                        (
                        (int)record["Id"],
                        (int)record["ClientID"],
                        (int)record["StaffID"],
                        
                        (int)record["Measurements"],
                        record["fabChosen"].ToString(),
                        (DateTime)record["furtDate"],
                        (decimal)record["estPrice"],
                        (bool)record["depositPaid"]
                        );
                    list.Add(newAppoint);
                }
                return list;
            }
            catch (Exception errorMessageText)
            {
                MessageBox.Show("Problem with retrieving Appointments" + errorMessageText);

                return new List<Appointment>();
            }
        }

        public static Appointment RetrieveByID(int ID)
        {
            try
            {
                SqlDataAdapter newDataAdapter = new SqlDataAdapter("SELECT * FROM Appointment WHERE Id = @Id", dbConnect.dbConnection());
                newDataAdapter.SelectCommand.Parameters.AddWithValue("@Id", ID);
                DataTable dataResult = new DataTable();
                newDataAdapter.Fill(dataResult);

                // Prohibits an error if the last record is deleted
                if (dataResult.Rows.Count > 0)
                {
                    
                    DataRow AppointmentRec = dataResult.Rows[0];

                    Appointment newAppoint = new Appointment(
                        (int)AppointmentRec["Id"],
                        (int)AppointmentRec["ClientID"],
                        (int)AppointmentRec["StaffID"],
                        
                        (int)AppointmentRec["Measurements"],
                        AppointmentRec["fabChosen"].ToString(),
                        (DateTime)AppointmentRec["furtDate"],
                        (decimal)AppointmentRec["estPrice"],
                        (bool)AppointmentRec["depositPaid"]
                        );

                    return newAppoint;
                }
                return null;
            }
            catch (Exception errorMessageText)
            {
                MessageBox.Show("Problem retreiving Appointments by ID" + errorMessageText);
                return null;
            }
        }

        public static bool AddAppoint(Appointment newAppoint)
        {

            try
            {
                string insertQuery =
                    "INSERT INTO Appointment " +
                    "(ClientID,StaffID,Measurements,fabChosen,furtDate,estPrice,depositPaid) " +
                    "VALUES " +
                    "(@ClientID,@StaffID,@Measurements,@fabChosen,@furtDate,@estPrice,@depositPaid)";

                SqlCommand insertCommand = new SqlCommand(insertQuery, dbConnect.dbConnection());

               

                    insertCommand.Parameters.AddWithValue("@ClientID", newAppoint.CId);
                    insertCommand.Parameters.AddWithValue("@StaffID", newAppoint.SId);
                    insertCommand.Parameters.AddWithValue("@Measurements", newAppoint.Measurements);
                    insertCommand.Parameters.AddWithValue("@fabChosen", newAppoint.FabChosen);
                    insertCommand.Parameters.AddWithValue("@furtDate", newAppoint.Furtdate);
                    insertCommand.Parameters.AddWithValue("@estPrice", newAppoint.EstPrice);
                    insertCommand.Parameters.AddWithValue("@depositPaid", newAppoint.DepositPaid);
                

                insertCommand.Connection.Open();
                insertCommand.ExecuteNonQuery();
                insertCommand.Connection.Close();
                insertCommand.Connection.Dispose();
                return true;

            }
            catch (Exception errorMessage)
            {

                MessageBox.Show("problem occured when adding new Appointments" + errorMessage);
            }
            return false;
        }
        #endregion
    }
}


  
