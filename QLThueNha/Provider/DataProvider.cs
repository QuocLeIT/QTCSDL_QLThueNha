using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Provider
{
    public class DataProvider
    {
     
        private string ServerName;
        private string UserName;
        private string UserPass;
        private string DatabaseName;

        private SqlCommand Cmd;
        private SqlConnection Cnn;

        public DataProvider()
        {
            GetConnect();
        }

        private void GetConnect()
        {          
            ServerName = ConnectConfig.dbServer;
            UserName = ConnectConfig.username;
            UserPass = ConnectConfig.pass;
            DatabaseName = ConnectConfig.dbName;
        }

        public string GetConnectionString()
        {            
            return "server=" + ServerName + ";database='" + DatabaseName + "';Uid='" + UserName + "';pwd='" + UserPass + "';";        
        }
                   
        private void OpenConnect()
        {           
            if (Cnn == null)
                Cnn = new SqlConnection(GetConnectionString());

            if (Cnn.State == ConnectionState.Open)
                return;

            Cnn.Open();
        }

        private void CloseConnect()
        {
            if (Cnn.State == ConnectionState.Closed)
                return;

            Cnn.Close();
        }
   
        public int MyExecuteNonQuery(string sql)
        {
            int result = 0;
            try
            {
                OpenConnect();
                Cmd = new SqlCommand();
                Cmd.Connection = Cnn;
                Cmd.CommandText = sql;
                Cmd.CommandType = CommandType.Text;
                Cmd.CommandTimeout = 100;
                result = Cmd.ExecuteNonQuery();
                CloseConnect();
            }
            catch (Exception ex)
            {
                result = -1;
            }
            return result;
        }

        public SqlCommand AddParameters(SqlCommand _cmd, string[] ParamName, object[] ParamValue)
        {
            for (int i = 0; i <= ParamName.Length - 1; i++)
            {
                if (ParamName[i] != null)
                {
                    _cmd.Parameters.AddWithValue(ParamName[i], ParamValue[i]);
                }
            }
            return _cmd;
        }
    
        public DataTable ReadDataAddPram(string sql, string[] ParamName, object[] ParamValue, int timeout)
        {

            OpenConnect();
          
            Cmd = new SqlCommand();
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.CommandText = sql;
            Cmd.Connection = Cnn;
            Cmd.CommandTimeout = timeout;
            Cmd = AddParameters(Cmd, ParamName, ParamValue);
            SqlDataAdapter da = new SqlDataAdapter(Cmd);
           
            DataTable ta = new DataTable();
            da.Fill(ta);
            Cmd.Dispose();
            da.Dispose();

            CloseConnect();
            return ta;

        }

        public DataTable ReadDataNoParam(string sql, int timeout)
        {
            OpenConnect();

            Cmd = new SqlCommand();
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.CommandText = sql;
            Cmd.Connection = Cnn;
            Cmd.CommandTimeout = timeout;
            SqlDataAdapter da = new SqlDataAdapter(Cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            Cmd.Dispose();
            da.Dispose();

            CloseConnect();
            return ds.Tables[0];
        }

        public int WriteDataAddParam(string sql, string[] ParamName, object[] ParamValue, int timeout)
        {
            try
            {
                OpenConnect();
            }
            catch (Exception ex)
            {
                return -1;
            }

            Cmd = new SqlCommand();
            Cmd.CommandText = sql;
            Cmd.Connection = Cnn;
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.CommandTimeout = timeout;
            Cmd = AddParameters(Cmd, ParamName, ParamValue);
            SqlParameter p = Cmd.Parameters.Add("@result", SqlDbType.NVarChar);
            p.Direction = ParameterDirection.ReturnValue;
            Cmd.ExecuteNonQuery();
            int result = (int)Cmd.Parameters["@result"].Value;
            Cmd.Dispose();

            CloseConnect();
            return result;
        }

        public DataTable Fillbang(string sql)
        {
            OpenConnect();
            
            SqlCommand cmd = new SqlCommand(sql, Cnn);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter adap = new SqlDataAdapter();
            adap.SelectCommand = cmd;
            DataTable bang = new DataTable();
            adap.Fill(bang);
            return bang;
        }
    }
}
