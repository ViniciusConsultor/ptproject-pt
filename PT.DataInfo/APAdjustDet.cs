using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace PT.DataInfo
{
    public class APAdjustDet
    {
        private string _BranchID;
        private string _AdjNbr;
        private string _LineRef;
        private DateTime _AdjDate;
        private string _VendID;
        private string _AdjAcct;
        private double _AdjAmt;
        private string _NDocNbr;
        private string _NDocType;
        private DateTime _NDocDate;
        private string _ADocNbr;
        private string _ADocType;
        private DateTime _ADocDate;
        private int _Rlsed;
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
        public string AdjNbr { get { return _AdjNbr; } set { _AdjNbr = value; } }
        public string LineRef { get { return _LineRef; } set { _LineRef = value; } }
        public DateTime AdjDate { get { return _AdjDate; } set { _AdjDate = value; } }
        public string VendID { get { return _VendID; } set { _VendID = value; } }
        public string AdjAcct { get { return _AdjAcct; } set { _AdjAcct = value; } }
        public double AdjAmt { get { return _AdjAmt; } set { _AdjAmt = value; } }
        public string NDocNbr { get { return _NDocNbr; } set { _NDocNbr = value; } }
        public string NDocType { get { return _NDocType; } set { _NDocType = value; } }
        public DateTime NDocDate { get { return _NDocDate; } set { _NDocDate = value; } }
        public string ADocNbr { get { return _ADocNbr; } set { _ADocNbr = value; } }
        public string ADocType { get { return _ADocType; } set { _ADocType = value; } }
        public DateTime ADocDate { get { return _ADocDate; } set { _ADocDate = value; } }
        public int Rlsed { get { return _Rlsed; } set { _Rlsed = value; } }
        #region Pro+Date
        public DateTime Crtd_DateTime { get { return _Crtd_DateTime; } set { _Crtd_DateTime = value; } }
        public string Crtd_Prog { get { return _Crtd_Prog; } set { _Crtd_Prog = value; } }
        public string Crtd_User { get { return _Crtd_User; } set { _Crtd_User = value; } }
        public DateTime LUpd_DateTime { get { return _LUpd_DateTime; } set { _LUpd_DateTime = value; } }
        public string LUpd_Prog { get { return _LUpd_Prog; } set { _LUpd_Prog = value; } }
        public string LUpd_User { get { return _LUpd_User; } set { _LUpd_User = value; } }
        #endregion
        public void ConvertToAPAdjustDet(DataRow dr)
        {
            _BranchID = dr["BranchID"].ToString().Trim();
            _AdjNbr = dr["AdjNbr"].ToString().Trim();
            _LineRef = dr["LineRef"].ToString().Trim();
            _AdjDate = DateTime.Parse(dr["AdjDate"].ToString().Trim());
            _VendID = dr["VendID"].ToString().Trim();
            _AdjAcct = dr["AdjAcct"].ToString().Trim();
            _AdjAmt = double.Parse(dr["AdjAmt"].ToString().Trim());
            _NDocNbr = dr["NDocNbr"].ToString().Trim();
            _NDocType = dr["NDocType"].ToString().Trim();
            _NDocDate = DateTime.Parse(dr["NDocDate"].ToString().Trim());
            _ADocNbr = dr["ADocNbr"].ToString().Trim();
            _ADocType = dr["ADocType"].ToString().Trim();
            _ADocDate = DateTime.Parse(dr["ADocDate"].ToString().Trim());
            _Rlsed = Int32.Parse(dr["Rlsed"].ToString().Trim());
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
