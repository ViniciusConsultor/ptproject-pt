using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PT.DataInfo
{
    class Batch
    {
        private string _BranchID;
        private string _Module;
        private string _BatNbr;
        private double _TotAmt;
        private DateTime _BatDate;
        private string _Descr;
        private string _TranType;
        private string _Note;
        private string _RsID;
        private string _Status;
        private int _Rlsed;
        #region private Pro+Date
        private DateTime _Crtd_DateTime;
        private string _Crtd_Prog;
        private string _Crtd_User;
        private DateTime _LUpd_DateTime;
        private string _LUpd_Prog;
        private string _LUpd_User;
        #endregion

        public string BranchID { get { return _BranchID; } set { _BranchID = value; } }
        public string Module { get { return _Module; } set { _Module = value; } }
        public string BatNbr { get { return _BatNbr; } set { _BatNbr = value; } }
        public double TotAmt { get { return _TotAmt; } set { _TotAmt = value; } }
        public DateTime BatDate { get { return _BatDate; } set { _BatDate = value; } }
        public string Descr { get { return _Descr; } set { _Descr = value; } }
        public string TranType { get { return _TranType; } set { _TranType = value; } }
        public string Note { get { return _Note; } set { _Note = value; } }
        public string RsID { get { return _RsID; } set { _RsID = value; } }
        public string Status { get { return _Status; } set { _Status = value; } }
        public int Rlsed { get { return _Rlsed; } set { _Rlsed = value; } }
        #region public Pro+Date
        public DateTime Crtd_DateTime { get { return _Crtd_DateTime; } set { _Crtd_DateTime = value; } }
        public string Crtd_Prog { get { return _Crtd_Prog; } set { _Crtd_Prog = value; } }
        public string Crtd_User { get { return _Crtd_User; } set { _Crtd_User = value; } }
        public DateTime LUpd_DateTime { get { return _LUpd_DateTime; } set { _LUpd_DateTime = value; } }
        public string LUpd_Prog { get { return _LUpd_Prog; } set { _LUpd_Prog = value; } }
        public string LUpd_User { get { return _LUpd_User; } set { _LUpd_User = value; } }
        #endregion

    }
}
