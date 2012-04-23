using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace PT.DataInfo
{
    public class INDoc
    {
        private string _BranchID;
        private string _DocNbr;
        private string _Module;
        private string _TranType;
        private double _TotQty;
        private string _WhID;
        private string _ToWhID;
        private double _TotAmt;
        private DateTime _DocDate;
        private string _DocDescr;
        private string _RsID;
        private int _Rlsed;
        private string _Note;
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
        public string BranchID { get { return _BranchID; } set { _BranchID = value; } }
        public string DocNbr { get { return _DocNbr; } set { _DocNbr = value; } }
        public string Module { get { return _Module; } set { _Module = value; } }
        public string TranType { get { return _TranType; } set { _TranType = value; } }
        public double TotQty { get { return _TotQty; } set { _TotQty = value; } }
        public string WhID { get { return _WhID; } set { _WhID = value; } }
        public string ToWhID { get { return _ToWhID; } set { _ToWhID = value; } }
        public double TotAmt { get { return _TotAmt; } set { _TotAmt = value; } }
        public DateTime DocDate { get { return _DocDate; } set { _DocDate = value; } }
        public string DocDescr { get { return _DocDescr; } set { _DocDescr = value; } }
        public string RsID { get { return _RsID; } set { _RsID = value; } }
        public int Rlsed { get { return _Rlsed; } set { _Rlsed = value; } }
        public string Note { get { return _Note; } set { _Note = value; } }
        #region Pro+Date
        public DateTime Crtd_DateTime { get { return _Crtd_DateTime; } set { _Crtd_DateTime = value; } }
        public string Crtd_Prog { get { return _Crtd_Prog; } set { _Crtd_Prog = value; } }
        public string Crtd_User { get { return _Crtd_User; } set { _Crtd_User = value; } }
        public DateTime LUpd_DateTime { get { return _LUpd_DateTime; } set { _LUpd_DateTime = value; } }
        public string LUpd_Prog { get { return _LUpd_Prog; } set { _LUpd_Prog = value; } }
        public string LUpd_User { get { return _LUpd_User; } set { _LUpd_User = value; } }
        #endregion
        public void ConvertToINDoc(DataRow dr)
        {
            _BranchID = dr["BranchID"].ToString().Trim();
            _DocNbr = dr["DocNbr"].ToString().Trim();
            _Module = dr["Module"].ToString().Trim();
            _TranType = dr["TranType"].ToString().Trim();
            _TotQty = double.Parse(dr["TotQty"].ToString().Trim());
            _WhID = dr["WhID"].ToString().Trim();
            _ToWhID = dr["ToWhID"].ToString().Trim();
            _TotAmt = double.Parse(dr["TotAmt"].ToString().Trim());
            _DocDate = DateTime.Parse(dr["DocDate"].ToString().Trim());
            _DocDescr = dr["DocDescr"].ToString().Trim();
            _RsID = dr["RsID"].ToString().Trim();
            _Rlsed = Int32.Parse(dr["Rlsed"].ToString().Trim());
            _Note = dr["Note"].ToString().Trim();
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
