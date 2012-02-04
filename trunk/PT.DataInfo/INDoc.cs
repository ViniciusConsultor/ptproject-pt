using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PT.DataInfo
{
    public class INDoc
    {
        private string _BranchID;
        private string _DocNbr;
        private string _Module;
        private string _TranType;
        private float _TotQty;
        private string _WhID;
        private string _ToWhID;
        private float _TotAmt;
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
        #endregion

        public string BranchID { get { return _BranchID; } set { _BranchID = value; } }
        public string DocNbr { get { return _DocNbr; } set { _DocNbr = value; } }
        public string Module { get { return _Module; } set { _Module = value; } }
        public string TranType { get { return _TranType; } set { _TranType = value; } }
        public float TotQty { get { return _TotQty; } set { _TotQty = value; } }
        public string WhID { get { return _WhID; } set { _WhID = value; } }
        public string ToWhID { get { return _ToWhID; } set { _ToWhID = value; } }
        public float TotAmt { get { return _TotAmt; } set { _TotAmt = value; } }
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
    }
}
