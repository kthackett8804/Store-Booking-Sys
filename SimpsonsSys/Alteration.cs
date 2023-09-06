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
    class Alteration
    {

        #region Private 

        private int altId = 0;
        private int cid = 0;
        private int sid = 0;
        private string reason = "";
        private decimal cost = 0;
        private DateTime dateComp;
        private bool ifPaid = false;
        #endregion

        #region Public 
        public int AltId
        {
            get { return altId; }
            set { altId = value; }
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
        public string Reason
        {
            get { return reason; }
            set { reason = value; }
        }

        public decimal Cost
        {
            get { return cost; }
            set { cost = value; }
        }

        public DateTime DateComp
        {
            get { return dateComp; }
            set { dateComp = value; }
        }

        public bool IfPaid
        {
            get { return ifPaid; }
            set { ifPaid = value; }
        }
        #endregion

        #region Constructor

        public Alteration(int altId, int cids, int sids, string reasons, decimal costofalt, DateTime datecompleted, bool paid)
        {
            AltId = altId;
            CId = cids;
            SId = sids;
            Reason = reasons;
            Cost = costofalt;
            DateComp = datecompleted;
            IfPaid = paid;
        }

        public Alteration()
        {

        }

        #endregion

        #region Methods 


        public static List<Alteration> GetAlteration()
        {
            List<Alteration> list = new List<Alteration>();
            try
            {
                SqlDataAdapter newDataAdapter = new SqlDataAdapter("SELECT * FROM Alteration", dbConnect.dbConnection());
                DataTable dataResult = new DataTable();
                newDataAdapter.Fill(dataResult);

                foreach (DataRow record in dataResult.Rows)
                {
                    Alteration newAlteration = new Alteration
                        (
                        (int)record["AlterationId"],
                        (int)record["ClientID"],
                        (int)record["StaffID"],
                        record["Reason"].ToString(),
                        (decimal)record["Cost"],
                        (DateTime)record["DateComp"],
                        (bool)record["ifPaid"]
                        );
                    list.Add(newAlteration);
                }
                return list;
            }
            catch (Exception errorMessageText)
            {
                MessageBox.Show("Problem with retrieving Alteration forms" + errorMessageText);

                return new List<Alteration>();
            }
        }

        public static Alteration RetrieveByAlterationID(int AltID)
        {
            try
            {
                SqlDataAdapter newDataAdapter = new SqlDataAdapter("SELECT * FROM Alteration WHERE AlterationId = @AlterationId", dbConnect.dbConnection());
                newDataAdapter.SelectCommand.Parameters.AddWithValue("@AlterationId", AltID);
                DataTable dataResult = new DataTable();
                newDataAdapter.Fill(dataResult);

                // Prohibits an error if the last record is deleted
                if (dataResult.Rows.Count > 0)
                {

                    DataRow AlterationRec = dataResult.Rows[0];

                    Alteration newAlt = new Alteration(
                        (int)AlterationRec["AlterationId"],
                        (int)AlterationRec["ClientID"],
                        (int)AlterationRec["StaffID"],
                        AlterationRec["Reason"].ToString(),
                        (decimal)AlterationRec["Cost"],
                        (DateTime)AlterationRec["DateComp"],
                        (bool)AlterationRec["ifPaid"]
                        );


                    return newAlt;
                }
                return null;
            }
            catch (Exception errorMessageText)
            {
                MessageBox.Show("Problem retreiving Alteration forms by ID" + errorMessageText);
                return null;
            }
        }

        public static bool AddAlteration(Alteration newAlteration)
        {

            try
            {
                string insertQuery =
                    "INSERT INTO Alteration " +
                    "(ClientID,StaffID,Reason,Cost,DateComp,ifPaid) " +
                    "VALUES " +
                    "(@ClientID,@StaffID,@Reason,@Cost,@DateComp,@ifPaid)";

                //if the ID is parsed as an integer then allow adding a new alteration
                SqlCommand insertCommand = new SqlCommand(insertQuery, dbConnect.dbConnection());
                if (Int32.TryParse(newAlteration.CId.ToString(), out var parse1) || Int32.TryParse(newAlteration.SId.ToString(), out var parse2) )
                {
                    insertCommand.Parameters.AddWithValue("@ClientID", newAlteration.CId);
                    insertCommand.Parameters.AddWithValue("@StaffID", newAlteration.SId);


                }
                else
                {
                    MessageBox.Show("ID must contain numbers only");
                    return false;
                    
                }

                //if the Reason is parsed as an integer then dont allow add
                if (Int32.TryParse(newAlteration.Reason, out var parse4) || newAlteration.Reason == "")
                {
                    MessageBox.Show("Reason must contain letters only");
                    return false;
                }
                else
                {
                    insertCommand.Parameters.AddWithValue("@Reason", newAlteration.Reason);
                }

                //if the Cost is parsed as an Decimal then allow adding a new alteration
                if (decimal.TryParse(newAlteration.Cost.ToString(), out var parse5))
                {
                    insertCommand.Parameters.AddWithValue("@Cost", newAlteration.Cost);
                }
                else
                {
                    MessageBox.Show("Cost must contain decimal ");
                    return false;
                }

                //if the Date is parsed as an DateTime then allow adding a new alteration
                if (DateTime.TryParse(newAlteration.DateComp.ToString(), out var parse7))
                {
                    insertCommand.Parameters.AddWithValue("@DateComp", newAlteration.DateComp);
                    insertCommand.Parameters.AddWithValue("@ifPaid", newAlteration.IfPaid);
                }
                else
                {
                    MessageBox.Show("Date textbox must contain a date only");
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

                MessageBox.Show("problem occured when adding new Alteration forms" + errorMessage);
            }
            return false;
        }

        #endregion
    }
}
