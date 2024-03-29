﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace PT.DataInfo
{
    public class INProductClass2
    {
        private string _VendID;
        private string _ClassID1;
        private string _ClassID2;
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
        private string _Version;
        #endregion

        public string Version { get { return _Version; } set { _Version = value; } }
        public string VendID { get { return _VendID; } set { _VendID = value; } }
        public string ClassID1 { get { return _ClassID1; } set { _ClassID1 = value; } }
        public string ClassID2 { get { return _ClassID2; } set { _ClassID2 = value; } }
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
        public void ConvertToINProductClass2(DataRow dr)
        {
            _VendID = dr["VendID"].ToString().Trim();
            _ClassID1 = dr["ClassID1"].ToString().Trim();
            _ClassID2 = dr["ClassID2"].ToString().Trim();
            _Descr = dr["Descr"].ToString().Trim();
            _DfltTaxID = dr["DfltTaxID"].ToString().Trim();
            _DfltWhID = dr["DfltWhID"].ToString().Trim();
            _POUnit = dr["POUnit"].ToString().Trim();
            _SOUnit = dr["SOUnit"].ToString().Trim();
            _INUnit = dr["INUnit"].ToString().Trim();
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
