using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PT.DataInfo
{
    public class APAdjust
    {
        private string _BranchID;
        private string _AdjNbr;
        private DateTime _AdjDate;
        private string _AdjDesc;
        private string _AdjAcct;
        private float _AdjAmt;
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
        public string AdjNbr { get { return _AdjNbr; } set { _AdjNbr = value; } }
        public DateTime AdjDate { get { return _AdjDate; } set { _AdjDate = value; } }
        public string AdjDesc { get { return _AdjDesc; } set { _AdjDesc = value; } }
        public string AdjAcct { get { return _AdjAcct; } set { _AdjAcct = value; } }
        public float AdjAmt { get { return _AdjAmt; } set { _AdjAmt = value; } }
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
