using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data.SqlTypes;
using System.Data;
using System.Data.SqlClient;

namespace PT.Helper
{
    public class ConnectDB
    {
        public static string connectionString = "";
        private static string ReadDB()
        {
            DataSet _dataset = new DataSet("Configs");
            DataTable _datatable = new DataTable("Config");

            _datatable.Columns.Add("Server", typeof(string));
            _datatable.Columns.Add("Database", typeof(string));
            _datatable.Columns.Add("Username", typeof(string));
            _datatable.Columns.Add("Password", typeof(string));

            _dataset.Tables.Add(_datatable);

            _dataset.ReadXml(Globals.PTXMLConfig, XmlReadMode.IgnoreSchema);
            string _servername = _datatable.Rows[0]["Server"].ToString();
            string _database = _datatable.Rows[0]["Database"].ToString();
            string _username = _datatable.Rows[0]["Username"].ToString();
            string _password = _datatable.Rows[0]["Password"].ToString();
            string str = "";
            if (_username == null || _username == string.Empty || _username == "")
                str = "Data Source=" + _servername + ";Database=" + _database +  ";Integrated Security=True";
            else
                str = "Data Source=" + _servername + "Database=" + _database + ";User ID=" + _username + ";pwd=" + _password + ";";
            return str;
        }
        static ConnectDB()
        {
           // if (connectionString == null)
          //     connectionString = "Data Source=LTPHUOC-PC\\SQLEXPRESS10;User ID=sa;pwd=1234567;Initial Catalog=PT.Manager;";
            connectionString = ReadDB();
           
        }

        public static void DefineSqlParameter(SqlCommand cmd, String[] parameterNames, Object[] parameterValues)
        {
            SqlParameter parameter;
            if (parameterNames != null)
            {
                for (int i = 0; i < parameterNames.Length; i++)
                {
                    parameter = new SqlParameter();
                    parameter.ParameterName = parameterNames[i];
                    parameter.SqlValue = parameterValues[i];
                    cmd.Parameters.Add(parameter);
                }
            }
        }

        public static int ExecuteNonQuery(String StoreProcedureName, String[] parameterNames, Object[] parameterValues)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand();
            int kq = 0;
            try
            {
                DefineSqlParameter(cmd,parameterNames,parameterValues);
                connection.Open();
                cmd.Connection = connection;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = StoreProcedureName;
                kq=cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {                
                throw ex;
            }
            finally {
                connection.Close();
            }

            return kq;
        }
        public static int ExecuteNonQuery(String StoreProcedureName)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand();
            int kq = 0;
            try
            {               
                connection.Open();
                cmd.Connection = connection;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = StoreProcedureName;
                kq = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }

            return kq;
        }

        public static int ExecuteScalar(String StoreProcedureName, String[] parameterNames, Object[] parameterValues)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand();
            int kq = 0;
            try
            {
                DefineSqlParameter(cmd, parameterNames, parameterValues);
                connection.Open();
                cmd.Connection = connection;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = StoreProcedureName;
                kq = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }

            return kq;
        }

        public static DataTable ExecuteReader(String StoreProcedureName, String[] parameterNames, Object[] parameterValues)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand();  
            SqlDataAdapter adapter;
            DataTable kq=new DataTable();
            try
            {
                DefineSqlParameter(cmd, parameterNames, parameterValues);
                connection.Open();
                cmd.Connection = connection;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = StoreProcedureName;
                adapter = new SqlDataAdapter(cmd);
                adapter.Fill(kq);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }

            return kq;
        }
        public static DataTable ExecuteReader(String StoreProcedureName)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter adapter;
            DataTable kq = new DataTable();
            try
            {                
                connection.Open();
                cmd.Connection = connection;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = StoreProcedureName;
                adapter = new SqlDataAdapter(cmd);
                adapter.Fill(kq);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }

            return kq;
        }

        public static DataTable GetAll(string _strTableName)
        {
            return ExecuteReader("sp_GetAll", new String[] { "TableName" }, new Object[] { _strTableName });
        }

       
        //private static string stconnect = "Data Source=LTPHUOC-PC\\SQLEXPRESS10;User ID=sa;pwd=1234567;Initial Catalog=PT.Manager;";
        ////private static string stconnect = "server=(local);uid=sa;database=qlbh;pwd=sa";
        //private static SqlConnection conn;
        //private static SqlCommand cmd;
        //private static SqlDataAdapter da;
        //private static DataSet ds;

        //public static Boolean Connect()
        //{
        //    conn = new SqlConnection(stconnect);
        //    try
        //    {
        //        conn.Open();
        //    }
        //    catch (Exception ex)
        //    {
        //        System.Windows.Forms.MessageBox.Show("Connection failed. View Details " + ex.Message);
        //    }
        //    return true;
        //}
        //public static void CloseConnection()
        //{
        //    if (conn.State == ConnectionState.Open)
        //    {
        //        conn.Close();
        //    }
        //    conn.Dispose();
        //}
        //public static void ExcuteCmd(string strSql)
        //{
        //    cmd = new SqlCommand();
        //    Connect();
        //    cmd.Connection = conn;
        //    cmd.CommandText = strSql;
        //    cmd.ExecuteNonQuery();
        //    CloseConnection();
        //}
        //public static SqlDataReader ExcuteReader(string select)
        //{
        //    cmd = new SqlCommand(select, conn);
        //    try
        //    {
        //        return cmd.ExecuteReader();
        //    }
        //    catch (SqlException)
        //    {
        //        return null;
        //    }
        //} 
        //public static DataSet GetDataSet(string select)
        //{
        
        //    Connect();
        //    da = new SqlDataAdapter(select, conn);
        //    ds = new DataSet();
        //    try
        //    {
        //        da.Fill(ds);
        //        return ds;

        //    }
        //    catch (SqlException)
        //    {
        //        return null;
        //    }
           
        //}
        //public static DataTable GetDataTable(string strSql)
        //{
        //    DataTable dt = new DataTable();
        //    Connect();           
        //    cmd = new SqlCommand(strSql, conn);
        //    SqlDataAdapter da = new SqlDataAdapter(cmd);
        //    da.Fill(dt);
        //    CloseConnection();
        //    return dt;
        //}
    }
}
