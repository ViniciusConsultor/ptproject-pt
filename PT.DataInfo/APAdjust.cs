using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace PT.DataInfo
{
    public class APAdjust
    {
        private string _BranchID;
        private string _AdjNbr;
        private DateTime _AdjDate;
        private string _AdjDesc;
        private string _AdjAcct;
        private double _AdjAmt;
        private int _Rlsed;
        private string _Note;
        #region private Pro+Date
        private DateTime _Crtd_DateTime;
        private string _Crtd_Prog;
        private string _Crtd_User;
        private DateTime _LUpd_DateTime;
        private string _LUpd_Prog;
        private string _LUpd_User;
        private DateTime _FromDateTmp;
        private DateTime _ToDateTmp;
        private string _VendIDTmp;
        private string _Version;
        #endregion
        public string Version { get { return _Version; } set { _Version = value; }}
        public string BranchID { get { return _BranchID; } set { _BranchID = value; } }
        public string AdjNbr { get { return _AdjNbr; } set { _AdjNbr = value; } }
        public DateTime AdjDate { get { return _AdjDate; } set { _AdjDate = value; } }
        public string AdjDesc { get { return _AdjDesc; } set { _AdjDesc = value; } }
        public string AdjAcct { get { return _AdjAcct; } set { _AdjAcct = value; } }
        public double AdjAmt { get { return _AdjAmt; } set { _AdjAmt = value; } }
        public int Rlsed { get { return _Rlsed; } set { _Rlsed = value; } }
        public string Note { get { return _Note; } set { _Note = value; } }
        #region Pro+Date
        public DateTime Crtd_DateTime { get { return _Crtd_DateTime; } set { _Crtd_DateTime = value; } }
        public string Crtd_Prog { get { return _Crtd_Prog; } set { _Crtd_Prog = value; } }
        public string Crtd_User { get { return _Crtd_User; } set { _Crtd_User = value; } }
        public DateTime LUpd_DateTime { get { return _LUpd_DateTime; } set { _LUpd_DateTime = value; } }
        public string LUpd_Prog { get { return _LUpd_Prog; } set { _LUpd_Prog = value; } }
        public string LUpd_User { get { return _LUpd_User; } set { _LUpd_User = value; } }
        public string VendIDTmp { get { return _VendIDTmp; } set { _VendIDTmp = value; } }
        public DateTime FromDateTmp { get { return _FromDateTmp; } set { _FromDateTmp = value; } }
        public DateTime ToDateTmp { get { return _ToDateTmp; } set { _ToDateTmp = value; } }
        #endregion
        public void ConvertToAPAdjust(DataRow dr)
        {
            _BranchID = dr["BranchID"].ToString().Trim();
            _AdjNbr = dr["AdjNbr"].ToString().Trim();
            _AdjDate = DateTime.Parse(dr["AdjDate"].ToString().Trim());
            _AdjDesc = dr["AdjDesc"].ToString().Trim();
            _AdjAcct = dr["AdjAcct"].ToString().Trim();
            _AdjAmt = double.Parse(dr["AdjAmt"].ToString().Trim());
            _Rlsed = Int32.Parse(dr["Rlsed"].ToString().Trim());
            _Note = dr["Note"].ToString().Trim();
            _Crtd_DateTime = DateTime.Parse(dr["Crtd_DateTime"].ToString().Trim());
            _Crtd_Prog = dr["Crtd_Prog"].ToString().Trim();
            _Crtd_User = dr["Crtd_User"].ToString().Trim();
            _LUpd_DateTime = DateTime.Parse(dr["LUpd_DateTime"].ToString().Trim());
            _LUpd_Prog = dr["LUpd_Prog"].ToString().Trim();
            _LUpd_User = dr["LUpd_User"].ToString().Trim();
            _FromDateTmp = DateTime.Parse(dr["FromDateTmp"].ToString().Trim());
            _ToDateTmp = DateTime.Parse(dr["ToDateTmp"].ToString().Trim());
            _VendIDTmp = dr["VendIDTmp"].ToString().Trim();
             _Version = dr["Version"].ToString().Trim();
        }
    }
}
