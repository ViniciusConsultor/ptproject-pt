using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PT.DataInfo
{
    class IN_ProductClass
    {
        private string _VendID;
        private string _ClassID;
        private string _Descr;
        private string _DfltStkUnit;
        private string _DfltPOUnit;
        private string _DfltSOUnit;
        private string _DfltTax;
        private string _DfltSite;
        #region private Pro+Date
        private DateTime _Crtd_DateTime;
        private string _Crtd_Prog;
        private string _Crtd_User;
        private DateTime _LUpd_DateTime;
        private string _LUpd_Prog;
        private string _LUpd_User;
        #endregion

        public string VendID { get { return _VendID; } set { _VendID = value; } }
        public string ClassID { get { return _ClassID; } set { _ClassID = value; } }
        public string Descr { get { return _Descr; } set { _Descr = value; } }
        public string DfltStkUnit { get { return _DfltStkUnit; } set { _DfltStkUnit = value; } }
        public string DfltPOUnit { get { return _DfltPOUnit; } set { _DfltPOUnit = value; } }
        public string DfltSOUnit { get { return _DfltSOUnit; } set { _DfltSOUnit = value; } }
        public string DfltTax { get { return _DfltTax; } set { _DfltTax = value; } }
        public string DfltSite { get { return _DfltSite; } set { _DfltSite = value; } }
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
