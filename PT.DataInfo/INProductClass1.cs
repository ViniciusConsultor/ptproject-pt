using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PT.DataInfo
{
    class INProductClass1
    {
        private string _VendID;
        private string _ClassID1;
        private string _Descr;
        private string _DfltTaxID;
        private string _DfltWhID;
        private string _POUnit;
        private string _SOUnit;
        private string _INUnit;
        #region private Pro+Date
        private DateTime _Crtd_DateTime;
        private string _Crtd_Prog;
        private string _Crtd_User;
        private DateTime _LUpd_DateTime;
        private string _LUpd_Prog;
        private string _LUpd_User;
        #endregion

        public string VendID { get { return _VendID; } set { _VendID = value; } }
        public string ClassID1 { get { return _ClassID1; } set { _ClassID1 = value; } }
        public string Descr { get { return _Descr; } set { _Descr = value; } }
        public string DfltTaxID { get { return _DfltTaxID; } set { _DfltTaxID = value; } }
        public string DfltWhID { get { return _DfltWhID; } set { _DfltWhID = value; } }
        public string POUnit { get { return _POUnit; } set { _POUnit = value; } }
        public string SOUnit { get { return _SOUnit; } set { _SOUnit = value; } }
        public string INUnit { get { return _INUnit; } set { _INUnit = value; } }
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
