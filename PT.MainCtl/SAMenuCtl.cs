using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PT.Helper;
using PT.DataInfo;
using System.Data;

namespace PT.MainCtl
{
    public class SAMenuCtl
    {
        public static DataTable GetAllSAMenu()
        {
            DataTable _dataTable = new DataTable("Menu");
            string store = "sp_SAMenu_GetAll";
            _dataTable = ConnectDB.ExecuteReader(store);            
            return _dataTable;
        }
        public static bool WriteXML()
        {

            DataSet _dataSet = new DataSet("Menus");
            DataTable _dataTable = new DataTable("Menu");
            
            string store = "sp_SAMenu_GetAll";
            _dataTable = ConnectDB.ExecuteReader(store);
            _dataTable.TableName = "Menu";
            _dataSet.Tables.Add(_dataTable);
            _dataSet.WriteXml(Globals.PTXMLMenu, XmlWriteMode.IgnoreSchema);

            return true;
        }
        public static DataTable ReadXML()
        {
            DataSet _dataset = new DataSet("Menus");
            DataTable _datatable = new DataTable("Menu");

            _datatable.Columns.Add("ModuleID", typeof(string));
            _datatable.Columns.Add("MenuType", typeof(string));
            _datatable.Columns.Add("ScreenID", typeof(string));
            _datatable.Columns.Add("Descr", typeof(string));

            _dataset.Tables.Add(_datatable);

            _dataset.ReadXml(Globals.PTXMLMenu, XmlReadMode.IgnoreSchema);

            return _datatable;
        }
        public static SA_Menu ConvertDataRow(DataRow dr)
        {
            SA_Menu _SA_Menu = new SA_Menu();
            try
            {

                _SA_Menu.ModuleID = (string)dr["ModuleID"];
                _SA_Menu.MenuType = (string)dr["MenuType"];
                _SA_Menu.ScreenID = (string)dr["ScreenID"];
                _SA_Menu.Descr = (string)dr["Descr"];

            }
            catch (Exception ex)
            {
                //Log.Logger.Error(ex);
                _SA_Menu = null;
            }

            return _SA_Menu;
        }

    }
}
