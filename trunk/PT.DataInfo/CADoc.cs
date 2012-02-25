using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
        #endregion

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
    }
}
