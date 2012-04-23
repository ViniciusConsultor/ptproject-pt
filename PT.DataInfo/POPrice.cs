using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace PT.DataInfo
{
    public class POPrice
    {
        private string _InvtID;
        private DateTime _EffDate;
        private string _FromUnit;
        private double _POFromUnitPrice;
        private string _ToUnit;
        private double _POToUnitPrice;
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
        public string InvtID { get { return _InvtID; } set { _InvtID = value; } }
        public DateTime EffDate { get { return _EffDate; } set { _EffDate = value; } }
        public string FromUnit { get { return _FromUnit; } set { _FromUnit = value; } }
        public double POFromUnitPrice { get { return _POFromUnitPrice; } set { _POFromUnitPrice = value; } }
        public string ToUnit { get { return _ToUnit; } set { _ToUnit = value; } }
        public double POToUnitPrice { get { return _POToUnitPrice; } set { _POToUnitPrice = value; } }
        #region Pro+Date
        public DateTime Crtd_DateTime { get { return _Crtd_DateTime; } set { _Crtd_DateTime = value; } }
        public string Crtd_Prog { get { return _Crtd_Prog; } set { _Crtd_Prog = value; } }
        public string Crtd_User { get { return _Crtd_User; } set { _Crtd_User = value; } }
        public DateTime LUpd_DateTime { get { return _LUpd_DateTime; } set { _LUpd_DateTime = value; } }
        public string LUpd_Prog { get { return _LUpd_Prog; } set { _LUpd_Prog = value; } }
        public string LUpd_User { get { return _LUpd_User; } set { _LUpd_User = value; } }
        #endregion
        public void ConvertToPOPrice(DataRow dr)
        {
            _InvtID = dr["InvtID"].ToString().Trim();
            _EffDate = DateTime.Parse(dr["EffDate"].ToString().Trim());
            _FromUnit = dr["FromUnit"].ToString().Trim();
            _POFromUnitPrice = double.Parse(dr["POFromUnitPrice"].ToString().Trim());
            _ToUnit = dr["ToUni"].ToString().Trim();
            _POToUnitPrice = double.Parse(dr["POToUnitPrice"].ToString().Trim());
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
