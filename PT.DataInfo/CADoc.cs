using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace PT.DataInfo
{
    public class CADoc
    {
        private string _BranchID;
        private string _DocNbr;
        private string _CAType;
        private DateTime _DocDate;
        private string _TypeID;
        private string _DocDesc;
        private string _DocPerson;
        private string _DocPerAddr;
        private string _Acct;
        private double _CAAmt;
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
        public string CAType { get { return _CAType; } set { _CAType = value; } }
        public DateTime DocDate { get { return _DocDate; } set { _DocDate = value; } }
        public string TypeID { get { return _TypeID; } set { _TypeID = value; } }
        public string DocDesc { get { return _DocDesc; } set { _DocDesc = value; } }
        public string DocPerson { get { return _DocPerson; } set { _DocPerson = value; } }
        public string DocPerAddr { get { return _DocPerAddr; } set { _DocPerAddr = value; } }
        public string Acct { get { return _Acct; } set { _Acct = value; } }
        public double CAAmt { get { return _CAAmt; } set { _CAAmt = value; } }
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
        public void ConvertToCADoc(DataRow dr)
        {
            _BranchID = dr["BranchID"].ToString().Trim();
            _DocNbr = dr["DocNbr"].ToString().Trim();
            _CAType = dr["CAType"].ToString().Trim();
            _DocDate = DateTime.Parse(dr["DocDate"].ToString().Trim());
            _TypeID = dr["TypeID"].ToString().Trim();
            _DocDesc = dr["DocDesc"].ToString().Trim();
            _DocPerson = dr["DocPerson"].ToString().Trim();
            _DocPerAddr = dr["DocPerAddr"].ToString().Trim();
            _Acct = dr["Acct"].ToString().Trim();
            _CAAmt = double.Parse(dr["CAAmt"].ToString().Trim());
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
