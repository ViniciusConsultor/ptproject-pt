using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using PT.Helper;


namespace PT.Config
{
    public class ConfigCtrl
    {
        //public static string GetAllSAMenu()
        //{
        //    DataTable _dataTable = new DataTable("Menu");
        //    string store = "sp_SAMenu_GetAll";
        //    _dataTable = ConnectDB.ExecuteReader(store);
        //    return _dataTable;
        //}
        public static bool WriteXML(string server, string database, string username, string password)
        {

            DataSet _dataSet = new DataSet("Configs");
            DataTable _dataTable = new DataTable("Config");

            _dataTable.Columns.Add("Server", typeof(string));
            _dataTable.Columns.Add("Database", typeof(string));
            _dataTable.Columns.Add("Username", typeof(string));
            _dataTable.Columns.Add("Password", typeof(string));
            // _datatable.Rows.Add(new DataRow("","","",""));
            DataRow dr = _dataTable.NewRow();
            dr[0] = server;
            dr[1] = database;
            dr[2] = username;
            dr[3] = password;


            _dataTable.Rows.Add(dr);
            _dataTable.TableName = "Config";
            _dataSet.Tables.Add(_dataTable);
            _dataSet.WriteXml(Globals.PTXMLConfig, XmlWriteMode.IgnoreSchema);

            return true;
        }
        public static DataTable ReadXML()
        {
            DataSet _dataset = new DataSet("Configs");
            DataTable _datatable = new DataTable("Config");

            _datatable.Columns.Add("Server", typeof(string));
            _datatable.Columns.Add("Database", typeof(string));
            _datatable.Columns.Add("Username", typeof(string));
            _datatable.Columns.Add("Password", typeof(string));

            _dataset.Tables.Add(_datatable);

            _dataset.ReadXml(Globals.PTXMLConfig, XmlReadMode.IgnoreSchema);

            return _datatable;
        }
        public partial class Config
        {
            public string Server;
            public string Database;
            public string Username;
            public string Password;
        }
        public static Config ConvertDataRow(DataRow dr)
        {
            Config _Config = new Config();
            try
            {

                _Config.Server = (string)dr["Server"];
                _Config.Database = (string)dr["Database"];
                _Config.Username = (string)dr["Username"];
                _Config.Password = (string)dr["Password"];

            }
            catch (Exception ex)
            {
                //Log.Logger.Error(ex);
                _Config = null;
            }

            return _Config;
        }
    }
}
