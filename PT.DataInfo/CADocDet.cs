using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace PT.DataInfo
{
    public class CADocDet
    {
        private string _BranchID;
        private string _DocNbr;
        private string _LineRef;
        private string _CAType;
        private DateTime _DocDate;
        private string _TypeID;
        private string _TranDesc;
        private string _Acct;
        private string _CpdAcct;
        private string _VendID;
        private string _CustID;
        private string _StaffID;
        private DateTime _InvcDate;
        private string _InvcNbr;
        private string _InvcNote;
        private string _TaxRegNbr;
        private string _TaxID;
        private double _PreTaxAmt;
        private double _TaxAmt;
        private double _LineAmt;
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
        public string DocNbr { get { return _DocNbr; } set { _DocNbr = value; } }
        public string LineRef { get { return _LineRef; } set { _LineRef = value; } }
        public string CAType { get { return _CAType; } set { _CAType = value; } }
        public DateTime DocDate { get { return _DocDate; } set { _DocDate = value; } }
        public string TypeID { get { return _TypeID; } set { _TypeID = value; } }
        public string TranDesc { get { return _TranDesc; } set { _TranDesc = value; } }
        public string Acct { get { return _Acct; } set { _Acct = value; } }
        public string CpdAcct { get { return _CpdAcct; } set { _CpdAcct = value; } }
        public string VendID { get { return _VendID; } set { _VendID = value; } }
        public string CustID { get { return _CustID; } set { _CustID = value; } }
        public string StaffID { get { return _StaffID; } set { _StaffID = value; } }
        public DateTime InvcDate { get { return _InvcDate; } set { _InvcDate = value; } }
        public string InvcNbr { get { return _InvcNbr; } set { _InvcNbr = value; } }
        public string InvcNote { get { return _InvcNote; } set { _InvcNote = value; } }
        public string TaxRegNbr { get { return _TaxRegNbr; } set { _TaxRegNbr = value; } }
        public string TaxID { get { return _TaxID; } set { _TaxID = value; } }
        public double PreTaxAmt { get { return _PreTaxAmt; } set { _PreTaxAmt = value; } }
        public double TaxAmt { get { return _TaxAmt; } set { _TaxAmt = value; } }
        public double LineAmt { get { return _LineAmt; } set { _LineAmt = value; } }
        public int Rlsed { get { return _Rlsed; } set { _Rlsed = value; } }
        #region Pro+Date
        public DateTime Crtd_DateTime { get { return _Crtd_DateTime; } set { _Crtd_DateTime = value; } }
        public string Crtd_Prog { get { return _Crtd_Prog; } set { _Crtd_Prog = value; } }
        public string Crtd_User { get { return _Crtd_User; } set { _Crtd_User = value; } }
        public DateTime LUpd_DateTime { get { return _LUpd_DateTime; } set { _LUpd_DateTime = value; } }
        public string LUpd_Prog { get { return _LUpd_Prog; } set { _LUpd_Prog = value; } }
        public string LUpd_User { get { return _LUpd_User; } set { _LUpd_User = value; } }
        #endregion
        public void ConvertToCADocDet(DataRow dr)
        {
            _BranchID = dr["BranchID"].ToString().Trim();
            _DocNbr = dr["DocNbr"].ToString().Trim();
            _LineRef = dr["LineRef"].ToString().Trim();
            _CAType = dr["CAType"].ToString().Trim();
            _DocDate = DateTime.Parse(dr["DocDate"].ToString().Trim());
            _TypeID = dr["TypeID"].ToString().Trim();
            _TranDesc = dr["TranDesc"].ToString().Trim();
            _Acct = dr["Acct"].ToString().Trim();
            _CpdAcct = dr["CpdAcct"].ToString().Trim();
            _VendID = dr["VendID"].ToString().Trim();
            _CustID = dr["CustID"].ToString().Trim();
            _StaffID = dr["StaffID"].ToString().Trim();
            _InvcDate = DateTime.Parse(dr["InvcDate"].ToString().Trim());
            _InvcNbr = dr["InvcNbr"].ToString().Trim();
            _InvcNote = dr["InvcNote"].ToString().Trim();
            _TaxRegNbr = dr["TaxRegNbr"].ToString().Trim();
            _TaxID = dr["TaxID"].ToString().Trim();
            _PreTaxAmt = double.Parse(dr["PreTaxAm"].ToString().Trim());
            _TaxAmt = double.Parse(dr["TaxAmt"].ToString().Trim());
            _LineAmt = double.Parse(dr["LineAmt"].ToString().Trim());
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
