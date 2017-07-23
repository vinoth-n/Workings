using System;
using System.Configuration;
using System.Data;
using System.Data.OleDb;

namespace BillingSystem
{
    public class CommonClass
    {
        public static OleDbConnection fnGetConnection()
        {
            OleDbConnection OleDbConn = new OleDbConnection();
            OleDbConn.ConnectionString = Convert.ToString(ConfigurationManager.AppSettings["SqlConnectionString"]);
            if (OleDbConn.State == ConnectionState.Closed)
            { OleDbConn.Open(); }
            return OleDbConn;
        }

        public static string BasePath = Convert.ToString(ConfigurationManager.AppSettings["BasePath"]);
        public static string ResourcePath = Convert.ToString(ConfigurationManager.AppSettings["ResourcePath"]);
    }
}
