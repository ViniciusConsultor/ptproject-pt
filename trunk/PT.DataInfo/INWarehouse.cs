using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace PT.DataInfo
{
    public class INWarehouse
    {
        private string _WhId;
        private string _Name;
        private string _WhKeeper;
        private string _Addr;
        private string _Phone;
        private string _Type;
        #region private Pro+Date
        private DateTime _Crtd_DateTime;
        private string _Crtd_Prog;
        private string _Crtd_User;
        private DateTime _LUpd_DateTime;
        private string _LUpd_Prog;
        private string _LUpd_User;
        private string _Version;
        #endregion

        public string Version { get { return _Version; } set { _Version = value; } }
        public string WhId { get { return _WhId; } set { _WhId = value; } }
        public string Name { get { return _Name; } set { _Name = value; } }
        public string WhKeeper { get { return _WhKeeper; } set { _WhKeeper = value; } }
        public string Addr { get { return _Addr; } set { _Addr = value; } }
        public string Phone { get { return _Phone; } set { _Phone = value; } }
        public string Type { get { return _Type; } set { _Type = value; } }
        #region public Pro+Date
        public DateTime Crtd_DateTime { get { return _Crtd_DateTime; } set { _Crtd_DateTime = value; } }
        public string Crtd_Prog { get { return _Crtd_Prog; } set { _Crtd_Prog = value; } }
        public string Crtd_User { get { return _Crtd_User; } set { _Crtd_User = value; } }
        public DateTime LUpd_DateTime { get { return _LUpd_DateTime; } set { _LUpd_DateTime = value; } }
        public string LUpd_Prog { get { return _LUpd_Prog; } set { _LUpd_Prog = value; } }
        public string LUpd_User { get { return _LUpd_User; } set { _LUpd_User = value; } }
        #endregion
        public void ConvertToINWarehouse(DataRow dr)
        {
            _WhId = dr["WhId"].ToString().Trim();
            _Name = dr["Name"].ToString().Trim();
            _WhKeeper = dr["WhKeeper"].ToString().Trim();
            _Addr = dr["Addr"].ToString().Trim();
            _Phone = dr["Phone"].ToString().Trim();
            _Type = dr["Type"].ToString().Trim();
            _Crtd_DateTime = DateTime.Parse(dr["Crtd_DateTime"].ToString().Trim());
            _Crtd_Prog = dr["Crtd_Prog"].ToString().Trim();
            _Crtd_User = dr["Crtd_User"].ToString().Trim();
            _LUpd_DateTime = DateTime.Parse(dr["LUpd_DateTime"].ToString().Trim());
            _LUpd_Prog = dr["LUpd_Prog"].ToString().Trim();
            _LUpd_User = dr["LUpd_User"].ToString().Trim();
            _Version = dr["Version"].ToString().Trim();
        }
    }
}
