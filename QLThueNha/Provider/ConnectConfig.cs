using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace Provider
{
    public static class ConnectConfig
    {
        public static String dbServer = @".\SQL2014EXPRESS";
        public static String dbName = "QLThueNha";
        public static String username = "sa";
        public static String pass = "123";   
       
        public static SqlConnectionStringBuilder GetConnectstring()
        {
            SqlConnectionStringBuilder connStringBuilder = new SqlConnectionStringBuilder();
            connStringBuilder.DataSource = dbServer;
            connStringBuilder.UserID = username;
            connStringBuilder.Password = pass;
            connStringBuilder.InitialCatalog = dbName;
            // connStringBuilder.IntegratedSecurity = true;
            return connStringBuilder;
        }
    }
}
