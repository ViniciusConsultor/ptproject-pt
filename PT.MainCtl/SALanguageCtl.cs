using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using PT.Helper;

namespace PT.MainCtl
{
    public class SALanguageCtl
    {
        public static DataTable GetAllSAMenu()
        {
            DataTable _dataTable = new DataTable("Language");
            string store = "sp_SA_LanguageGetAll";
            _dataTable = ConnectDB.ExecuteReader(store);
            return _dataTable;
        }
        public static bool WriteXML()
        {

            DataSet _dataSet = new DataSet("Languages");
            DataTable _dataTable = GetAllSAMenu();
            _dataTable.TableName = "Language";
            _dataSet.Tables.Add(_dataTable);
            _dataSet.WriteXml(Globals.PTXMLFile, XmlWriteMode.IgnoreSchema);

            return true;
        }
        public static DataTable ReadXML()
        {
            DataSet _dataset = new DataSet("Languages");
            DataTable _datatable = new DataTable("Language");

            _datatable.Columns.Add("LgID", typeof(string));
            _datatable.Columns.Add("Language1", typeof(string));
            _datatable.Columns.Add("Language2", typeof(string));
            _datatable.Columns.Add("Language3", typeof(string));
           
            _dataset.Tables.Add(_datatable);

            _dataset.ReadXml(Globals.PTXMLFile, XmlReadMode.IgnoreSchema);

            return _datatable; 
        }
        public static SA_Language ConvertDataRow(DataRow dr)
        {
            SA_Language _SA_Language = new SA_Language();
            try
            {

                _SA_Language.LgID = (string)dr["LgID"];
                _SA_Language.Language1 = (string)dr["Language1"];
                _SA_Language.Language2 = (string)dr["Language2"];
                _SA_Language.Language3 = (string)dr["Language3"];                
                
            }
            catch (Exception ex)
            {
             //   Log.Logger.Error(ex);
                _SA_Language = null;
            }

            return _SA_Language;
        }
    }
}
