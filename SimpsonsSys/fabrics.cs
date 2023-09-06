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
    class fabrics
    {
        #region private properties
        private int fabId = 0;
        private string fabric = "";
        private int length = 0;
        private int quantity = 0;
        #endregion

        #region public properties

        public int FabId
        {
            get { return fabId; }
            set { fabId = value; }
        }

        public string Fabric
        {
            get { return fabric; }
            set { fabric = value; }
        }

        public int Length
        {
            get { return length; }
            set { length = value; }
        }

        public int Quantity 
        {
            get { return quantity; }
            set { quantity  = value; }
        }

        #endregion

        #region constructor 

        public fabrics(int id, string fab, int lengths, int quant)
        {
            FabId = id;
            Fabric = fab;
            Length = lengths;
            Quantity = quant;
        }
        public fabrics()
        {

        }
        #endregion

        #region methods

        public static List<fabrics> GetFabrics()
        {
            List<fabrics> list = new List<fabrics>();
            try
            {
                SqlDataAdapter newDataAdapter = new SqlDataAdapter("SELECT * FROM fabrics", dbConnect.dbConnection());
                DataTable dataResult = new DataTable();
                newDataAdapter.Fill(dataResult);

                foreach (DataRow record in dataResult.Rows)
                {
                    fabrics newfabric = new fabrics
                        (
                        (int)record["fabID"],
                        record["fabric"].ToString(),
                        (int)record["length"],
                       (int)record["quantity"]
                        );
                    list.Add(newfabric);
                }
                return list;
            }
            catch (Exception errorMessageText)
            {
                MessageBox.Show("Problem with retrieving Fabric table" + errorMessageText);

                return new List<fabrics>();
            }
        }


        public static fabrics RetrieveByfabID(int ID)
        {
            try
            {
                SqlDataAdapter newDataAdapter = new SqlDataAdapter("SELECT * FROM fabrics WHERE fabID = @fabID", dbConnect.dbConnection());
                newDataAdapter.SelectCommand.Parameters.AddWithValue("@fabID", ID);
                DataTable dataResult = new DataTable();
                newDataAdapter.Fill(dataResult);

                // Prohibits an error if the last record is deleted
                if (dataResult.Rows.Count > 0)
                {
                    //Get the customer record from database
                    DataRow fabricRecord = dataResult.Rows[0];

                    fabrics newfabs = new fabrics(
                        (int)fabricRecord["fabID"],
                        fabricRecord["fabric"].ToString(),
                        (int)fabricRecord["length"],
                        (int)fabricRecord["quantity"]

                        );

                    return newfabs;
                }
                return null;
            }
            catch (Exception errorMessageText)
            {
                MessageBox.Show("problem with retriving fabrics by their ID" + errorMessageText);
                return null;
            }
        }

        public static bool AddFabric(fabrics newFabric)
        {

            try
            {
                string insertQuery =
                    "INSERT INTO fabrics " +
                    "(fabric,length,quantity) " +
                    "VALUES " +
                    "(@fabric,@length,@quantity)";

                SqlCommand insertCommand = new SqlCommand(insertQuery, dbConnect.dbConnection());

                insertCommand.Parameters.AddWithValue("@fabric", newFabric.Fabric);
                insertCommand.Parameters.AddWithValue("@length", newFabric.Length);
                insertCommand.Parameters.AddWithValue("@quantity", newFabric.Quantity);
                


                insertCommand.Connection.Open();
                insertCommand.ExecuteNonQuery();
                insertCommand.Connection.Close();
                insertCommand.Connection.Dispose();
                return true;

            }
            catch (Exception errorMessage)
            {

                MessageBox.Show("problem occured when adding new fabrics" + errorMessage);
            }
            return false;
        }


        #endregion

    }
}
