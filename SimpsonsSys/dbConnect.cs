using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace SimpsonsSys
{
    class dbConnect
    {
        
        public static SqlConnection dbConnection()
        {
            string strConnect = Properties.Settings.Default.ConString;
            string dbPath = @"=""" + Environment.CurrentDirectory + @"\dbSimpsons.mdf";

            strConnect = strConnect.Replace(@"=""", dbPath);
            return new SqlConnection(strConnect);
        }
        
    }
}
