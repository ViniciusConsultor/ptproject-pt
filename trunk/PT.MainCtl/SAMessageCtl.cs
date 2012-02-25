using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using PT.Helper;
using PT.DataInfo;
namespace PT.MainCtl
{
    public class SAMessageCtl
    {
        public static DataTable GetAllSAMenu()
        {
            DataTable _dataTable = new DataTable("Message");
            string store = "sp_SAMenu_GetAll";
            _dataTable = ConnectDB.ExecuteReader(store);
            return _dataTable;
        }
        public static bool WriteXML()
        {

            DataSet _dataSet = new DataSet("Messages");
            DataTable _dataTable = new DataTable("Message");

            _dataTable = ConnectDB.GetAll("SAMessage");
            _dataTable.TableName = "Message";
            _dataSet.Tables.Add(_dataTable);
            _dataSet.WriteXml(Globals.PTXMLMessage, XmlWriteMode.IgnoreSchema);

            return true;
        }
        public static DataTable ReadXML()
        {
            DataSet _dataset = new DataSet("Messages");
            DataTable _datatable = new DataTable("Message");

            _datatable.Columns.Add("MsID", typeof(string));
            _datatable.Columns.Add("Language1", typeof(string));
            _datatable.Columns.Add("Language2", typeof(string));
            _datatable.Columns.Add("Language3", typeof(string));
            _datatable.Columns.Add("Descr", typeof(string));

            _dataset.Tables.Add(_datatable);

            _dataset.ReadXml(Globals.PTXMLMessage, XmlReadMode.IgnoreSchema);

            return _datatable;
        }
        public static SAMessage ConvertDataRow(DataRow dr)
        {
            SAMessage _SA_Message = new SAMessage();
            try
            {
                
                _SA_Message.MsID = (string)dr["MsID"];
                _SA_Message.Language1 = (string)dr["Language1"];
                _SA_Message.Language2 = (string)dr["Language2"];
                _SA_Message.Language3 = (string)dr["Language3"];
                _SA_Message.Descr = (string)dr["Descr"];

            }
            catch (Exception ex)
            {
                //Log.Logger.Error(ex);
                _SA_Message = null;
            }

            return _SA_Message;
        }
    }
}
