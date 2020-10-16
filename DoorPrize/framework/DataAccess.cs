using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
//using System.Data.OracleClient;

namespace DoorPrize.framework
{
    public interface IDataAccess : IDisposable 
    {
        new void Dispose();
        DataTable ExecuteQuery(string query, Dictionary<string, object> param, IDbTransaction tran);
        DataTable ExecuteQuery(string query, Dictionary<string, object> param);
        DataTable CallProcedure(string SPName, Dictionary<string, object> param);
        int ExecuteNonQuery(string query, Dictionary<string, object> param, IDbTransaction tran);
        int ExecuteNonQuery(string query, Dictionary<string, object> param);
        int ExecuteNonQueryR(string query, Dictionary<string, object> param);
        IDbTransaction BeginTran();
    }

    //public class OracleDataAccess : IDataAccess,IDisposable
    //{
    //    private bool _isConnected = false;
    //    private OracleConnection con = null;
    //    private int comTimeOut = Convert.ToInt32(ConfigManager.GetSetting("commandTimeOut"));

    //    public OracleDataAccess()
    //    {
    //        Open();
    //    }

    //    /// <summary>
    //    /// Open Connection specified to TagName of connection
    //    /// </summary>
    //    /// <param name="conTagName">Tag Name of connection on XML.</param>
    //    public OracleDataAccess(string conTagName)
    //    {
    //        Open(conTagName);
    //    }

    //    public IDbTransaction BeginTran()
    //    {
    //        return this.con.BeginTransaction();
    //    }
                
    //    public OracleConnection Con
    //    {
    //        get { return con; }
    //        set { con = value; }
    //    }

    //    private void Open()
    //    {
    //        try
    //        {
    //            con = new OracleConnection(ConfigManager.GetSetting("connOracle"));
    //            if (con.State != System.Data.ConnectionState.Open) con.Open();
    //            _isConnected = true;
    //        }
    //        catch (Exception ex)
    //        {
    //            _isConnected = false;
    //            throw ex;
    //        }
    //    }

    //    private void Open(string conTagName)
    //    {
    //        try
    //        {
    //            con = new OracleConnection(ConfigManager.GetSetting("connOracle"));
    //            if (con.State != System.Data.ConnectionState.Open) con.Open();
    //            _isConnected = true;
    //        }
    //        catch (Exception ex)
    //        {
    //            _isConnected = false;
    //            throw ex;
    //        }
    //    }

    //    private void Close()
    //    {
    //        try
    //        {
    //            if (con.State == ConnectionState.Open)
    //            {
    //                con.Close();
    //                _isConnected = false;
    //            }
    //        }
    //        catch (Exception ex)
    //        {

    //        }
    //    }

    //    public void Dispose()
    //    {
    //        con.Dispose();
    //        GC.Collect();
    //    }

    //    private OracleType oraType(string tipe)
    //    {
    //        OracleType retval;
    //        switch(tipe)
    //        {
    //            case "Boolean":
    //                retval = OracleType.Char;
    //                break;
    //            case "ByteArray":
    //                retval = OracleType.Blob;
    //                break;
    //            case "String":
    //                retval = OracleType.Char;
    //                break;
    //            case "DateTime":
    //                retval = OracleType.DateTime;
    //                break;
    //            case "Decimal":
    //                retval = OracleType.Float;
    //                break;
    //            case "Int16":
    //                retval = OracleType.Int16;
    //                break;
    //            case "Int32":
    //                retval = OracleType.Int32;
    //                break;
    //            default :
    //                retval = OracleType.VarChar;
    //                break;
    //        }
    //        return retval;
    //    }

    //    public DataTable ExecuteQuery(string query, Dictionary<string, object> param, IDbTransaction tran)
    //    {
    //        DataTable dt = new DataTable();
    //        if (!_isConnected)
    //            Open();

    //        using (OracleCommand cmd = new OracleCommand(query, con))
    //        {
    //            cmd.CommandTimeout = comTimeOut;
    //            if (tran != null) cmd.Transaction = (OracleTransaction)tran;
    //            if (param != null)
    //            {
    //                foreach (var parItem in param)
    //                {
    //                    cmd.Parameters.AddWithValue(parItem.Key, parItem.Value);
    //                }
    //            }
    //            OracleDataReader da = cmd.ExecuteReader();
    //            dt.Load(da);
    //        }
    //        //Close();

    //        return dt;
    //    }

    //    public DataTable ExecuteQuery(string query, Dictionary<string, object> param)
    //    {
    //        DataTable dt = new DataTable();
    //        if (!_isConnected)
    //            Open();

    //        using (OracleCommand cmd = new OracleCommand(query, con))
    //        {
    //            cmd.CommandTimeout = comTimeOut;
    //            if (param != null)
    //            {
    //                foreach (var parItem in param)
    //                {
    //                    cmd.Parameters.AddWithValue(parItem.Key, parItem.Value);
    //                }                    
    //            }
    //            OracleDataReader da = cmd.ExecuteReader();
    //            dt.Load(da);
    //        }
    //        Close();

    //        return dt;
    //    }

    //    public DataTable CallProcedure(string SPName, Dictionary<string, object> param)
    //    {
    //        DataTable dt = new DataTable();
    //        if (!_isConnected)
    //            Open();

    //        using (OracleCommand cmd = new OracleCommand(SPName, con))
    //        {
                
    //            cmd.CommandTimeout = comTimeOut;
    //            cmd.CommandType = CommandType.StoredProcedure;
    //            if (param != null)
    //            {
    //                foreach (var parItem in param)
    //                {
    //                    cmd.Parameters.Add(new OracleParameter() { ParameterName = parItem.Key, Value = parItem.Value, OracleType = oraType(parItem.Value.GetType().BaseType.Name), Direction = ParameterDirection.Input });
    //                    //cmd.Parameters.AddWithValue(parItem.Key, parItem.Value);
    //                }
    //                object dtable = new object();
    //                cmd.Parameters.Add(new OracleParameter() { ParameterName = "p_recordset",Direction = ParameterDirection.Output, Size=100000 });
    //                //cmd.Parameters.AddWithValue(
    //            }
    //            OracleDataReader da = cmd.ExecuteReader();
    //            dt.Load(da);
    //        }
    //        Close();
    //        return dt;
    //    }

    //    public int ExecuteNonQuery(string query, Dictionary<string, object> param, IDbTransaction tran)
    //    {
    //        int result = 0;
    //        if (!_isConnected)
    //            Open();
    //        using (OracleCommand cmd = new OracleCommand(query, con))
    //        {
    //            if (tran != null) cmd.Transaction = (OracleTransaction)tran;
    //            cmd.CommandTimeout = comTimeOut;
    //            if (param != null)
    //            {
    //                foreach (var parItem in param)
    //                {
    //                    //SqlParameter parSQL = new SqlParameter(parItem.Key, parItem.Value);
    //                    cmd.Parameters.AddWithValue(parItem.Key, parItem.Value);
    //                    //cmd.Parameters.Add(parSQL);
    //                }
    //            }
    //            result = cmd.ExecuteNonQuery();
    //        }

    //        //Close();

    //        return result;
    //    }

    //    public int ExecuteNonQuery(string query, Dictionary<string, object> param)
    //    {
    //        int result = 0;
    //        if (!_isConnected)
    //            Open();

    //        using (OracleCommand cmd = new OracleCommand(query, con))
    //        {
    //            cmd.CommandTimeout = comTimeOut;
    //            if (param != null)
    //            {
    //                foreach (var parItem in param)
    //                {
    //                    cmd.Parameters.AddWithValue(parItem.Key, parItem.Value);
    //                }
    //            }
    //            result = cmd.ExecuteNonQuery();
    //        }
    //        Close();

    //        return result;
    //    }
    //}

    public class SQLDataAccess : IDataAccess,IDisposable
    {
        private bool _isConnected = false;
        private SqlConnection con = null;
        private int comTimeOut = Convert.ToInt32(ConfigManager.GetSetting("commandTimeOut"));

        public SQLDataAccess()
        {
            Open();
        }

        /// <summary>
        /// Open Connection specified to TagName of connection
        /// </summary>
        /// <param name="conTagName">Tag Name of connection on XML.</param>
        public SQLDataAccess(string conTagName)
        {
            Open(conTagName);
        }  

        public void Dispose()
        {
            con.Dispose();
            GC.Collect();
        }                

        public SqlConnection Con
        {
            get { return con; }
            set { con = value; }
        }

        protected void Open()
        {
            try
            {
                con = new SqlConnection(ConfigManager.GetSetting("connection"));
                if (con.State != System.Data.ConnectionState.Open) con.Open();
                _isConnected = true;                
            }
            catch (Exception ex)
            {
                _isConnected = false;
                throw ex;
            }
        }

        /// <summary>
        /// Open Connection specified to TagName of connection
        /// </summary>
        /// <param name="conTagName">Tag Name of connection on XML.</param>
        protected void Open(string conTagName)
        {
            try
            {
                con = new SqlConnection(ConfigManager.GetSetting(conTagName));
                if (con.State != System.Data.ConnectionState.Open) con.Open();
                _isConnected = true;
            }
            catch (Exception ex)
            {
                _isConnected = false;
                throw ex;
            }
        }

        public IDbTransaction BeginTran()
        {
            return this.con.BeginTransaction();
        }

        private void Close()
        {
            try
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                    _isConnected = false;
                }
            }
            catch (Exception ex)
            {
          
            }
        }

        public DataTable ExecuteQuery(string query, Dictionary<string, object> param, IDbTransaction tran)
        {
            DataTable dt = new DataTable();
            if (!_isConnected)
                Open();
                       
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.CommandTimeout = comTimeOut;
                    if (tran != null) cmd.Transaction = (SqlTransaction)tran;
                    if (param != null)
                    {
                        foreach (var parItem in param)
                        {
                            cmd.Parameters.AddWithValue(parItem.Key, parItem.Value);
                        }
                    }
                    SqlDataReader da = cmd.ExecuteReader();
                    dt.Load(da);
                }
                //Close();
            
            return dt;
        }

        public DataTable ExecuteQuery(string query, Dictionary<string, object> param)
        {
            DataTable dt = new DataTable();
            if (!_isConnected)
                Open();

            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.CommandTimeout = comTimeOut;
                if (param != null)
                {
                    foreach (var parItem in param)
                    {
                        cmd.Parameters.AddWithValue(parItem.Key, parItem.Value);
                    }
                }
                SqlDataReader da = cmd.ExecuteReader();
                dt.Load(da);
            }
            Close();

            return dt;
        }

        public DataTable CallProcedure(string SPName, Dictionary<string, object> param)
        {
            DataTable dt = new DataTable();
            if (!_isConnected)
                Open();

            using (SqlCommand cmd = new SqlCommand(SPName, con))
            {
                cmd.CommandTimeout = comTimeOut;
                cmd.CommandType = CommandType.StoredProcedure;
                if (param != null)
                {
                    foreach (var parItem in param)
                    {
                        cmd.Parameters.AddWithValue(parItem.Key, parItem.Value);
                    }
                }
                SqlDataReader da = cmd.ExecuteReader();
                dt.Load(da);
            }
            Close();
            return dt;
        }

        public int ExecuteNonQuery(string query, Dictionary<string, object> param, IDbTransaction tran)
        {
            int result = 0;
            if (!_isConnected)
                Open();            
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    if (tran != null) cmd.Transaction = (SqlTransaction)tran;
                    cmd.CommandTimeout = comTimeOut;
                    if (param != null)
                    {
                        foreach (var parItem in param)
                        {
                            //SqlParameter parSQL = new SqlParameter(parItem.Key, parItem.Value);
                            cmd.Parameters.AddWithValue(parItem.Key, parItem.Value);
                            
                            //cmd.Parameters.Add(parSQL);
                        }
                    }
                    result = cmd.ExecuteNonQuery();                    
                }
                
                //Close();
            
            return result;
        }

        public int ExecuteNonQueryR(string query, Dictionary<string, object> param)
        {
            int result = 0;
            if (!_isConnected)
                Open();
            using (SqlCommand cmd = new SqlCommand(query, con))
            {               
                cmd.CommandTimeout = comTimeOut;
                cmd.CommandType = CommandType.StoredProcedure;
                if (param != null)
                {
                    foreach (var parItem in param)
                    {
                        cmd.Parameters.AddWithValue(parItem.Key, parItem.Value);                       
                    }
                }

                SqlParameter returnParameter = cmd.Parameters.Add("RetVal", SqlDbType.Int);
                returnParameter.Direction = ParameterDirection.ReturnValue;
                cmd.ExecuteNonQuery();
                result = (int)returnParameter.Value;
               
            }

            //Close();

            return result;
        }

        public int ExecuteNonQuery(string query, Dictionary<string, object> param)
        {
            int result = 0;
            if (!_isConnected)
                Open();

            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.CommandTimeout = comTimeOut;
                if (param != null)
                {
                    foreach (var parItem in param)
                    {
                        cmd.Parameters.AddWithValue(parItem.Key, parItem.Value);
                    }
                }
                result = cmd.ExecuteNonQuery();
            }
            Close();

            return result;
        }

        public void BulkSave(DataTable dt,string tablename)
        {
            using (SqlConnection sqlcon = con)
            {
                SqlBulkCopy bc = new SqlBulkCopy(con,
                    SqlBulkCopyOptions.TableLock |
                    SqlBulkCopyOptions.CheckConstraints |
                    SqlBulkCopyOptions.FireTriggers |
                    SqlBulkCopyOptions.KeepIdentity |
                    SqlBulkCopyOptions.UseInternalTransaction, null) 
                    { 
                        DestinationTableName = tablename,
                        BatchSize = Convert.ToInt32(ConfigManager.GetSetting("commitBatchSize"))
                    };
                bc.WriteToServer(dt);
            }
        }

        public void WriteToDB(DataTable dt, string tablename)
        {
            try
            {
                int batchSize = Convert.ToInt32(ConfigManager.GetSetting("commitBatchSize"));
                int pos = 0;
                if (dt.Rows.Count > 0)
                {
                    using (DataTable temp = new DataTable())
                    {
                        foreach (DataColumn dcol in dt.Columns)
                        {
                            temp.Columns.Add(dcol);
                        }
                        foreach(DataRow dr in dt.Rows)
                        {
                            temp.Rows.Add(dr);                            
                            if (pos % batchSize == 0)
                                BulkSave(temp,tablename);
                            pos++;
                        }                        
                    }
                }
            }
            catch (Exception ex)
            {                
                throw ex;
            }
        }
    }

    
    
}
