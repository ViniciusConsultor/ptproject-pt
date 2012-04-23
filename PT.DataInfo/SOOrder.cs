using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace PT.DataInfo
{
    public class SOOrder
    {
        private string _BranchID;
        private string _SONbr;
        private string _Status;
        private DateTime _SODate;
        private string _SOType;
        private string _SODesc;
        private string _ARDocNbr;
        private DateTime _ARDocDate;
        private string _INDocNbr;
        private DateTime _INDocDate;
        private string _CustID;
        private string _RcptPerson;
        private string _SOAddr1;
        private string _SOAdrr2;
        private DateTime _ShipDate;
        private string _ShipperID;
        private string _SlsPerID;
        private string _InvcNbr;
        private string _InvcNote;
        private double _SODiscAmt;
        private double _SODiscAmtPct;
        private double _SOPreTaxAmt;
        private double _SOTaxAmt;
        private double _SOAmt;
        private double _SOQty;
        private double _SOWeight;
        private string _Reason;
        private string _Note;
        private string _SOOldNbr;
        private string _TimeLmtID;
        private DateTime _DueDate;
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
        public string SONbr { get { return _SONbr; } set { _SONbr = value; } }
        public string Status { get { return _Status; } set { _Status = value; } }
        public DateTime SODate { get { return _SODate; } set { _SODate = value; } }
        public string SOType { get { return _SOType; } set { _SOType = value; } }
        public string SODesc { get { return _SODesc; } set { _SODesc = value; } }
        public string ARDocNbr { get { return _ARDocNbr; } set { _ARDocNbr = value; } }
        public DateTime ARDocDate { get { return _ARDocDate; } set { _ARDocDate = value; } }
        public string INDocNbr { get { return _INDocNbr; } set { _INDocNbr = value; } }
        public DateTime INDocDate { get { return _INDocDate; } set { _INDocDate = value; } }
        public string CustID { get { return _CustID; } set { _CustID = value; } }
        public string RcptPerson { get { return _RcptPerson; } set { _RcptPerson = value; } }
        public string SOAddr1 { get { return _SOAddr1; } set { _SOAddr1 = value; } }
        public string SOAdrr2 { get { return _SOAdrr2; } set { _SOAdrr2 = value; } }
        public DateTime ShipDate { get { return _ShipDate; } set { _ShipDate = value; } }
        public string ShipperID { get { return _ShipperID; } set { _ShipperID = value; } }
        public string SlsPerID { get { return _SlsPerID; } set { _SlsPerID = value; } }
        public string InvcNbr { get { return _InvcNbr; } set { _InvcNbr = value; } }
        public string InvcNote { get { return _InvcNote; } set { _InvcNote = value; } }
        public double SODiscAmt { get { return _SODiscAmt; } set { _SODiscAmt = value; } }
        public double SODiscAmtPct { get { return _SODiscAmtPct; } set { _SODiscAmtPct = value; } }
        public double SOPreTaxAmt { get { return _SOPreTaxAmt; } set { _SOPreTaxAmt = value; } }
        public double SOTaxAmt { get { return _SOTaxAmt; } set { _SOTaxAmt = value; } }
        public double SOAmt { get { return _SOAmt; } set { _SOAmt = value; } }
        public double SOQty { get { return _SOQty; } set { _SOQty = value; } }
        public double SOWeight { get { return _SOWeight; } set { _SOWeight = value; } }
        public string Reason { get { return _Reason; } set { _Reason = value; } }
        public string Note { get { return _Note; } set { _Note = value; } }
        public string SOOldNbr { get { return _SOOldNbr; } set { _SOOldNbr = value; } }
        public string TimeLmtID { get { return _TimeLmtID; } set { _TimeLmtID = value; } }
        public DateTime DueDate { get { return _DueDate; } set { _DueDate = value; } }
        #region Pro+Date
        public DateTime Crtd_DateTime { get { return _Crtd_DateTime; } set { _Crtd_DateTime = value; } }
        public string Crtd_Prog { get { return _Crtd_Prog; } set { _Crtd_Prog = value; } }
        public string Crtd_User { get { return _Crtd_User; } set { _Crtd_User = value; } }
        public DateTime LUpd_DateTime { get { return _LUpd_DateTime; } set { _LUpd_DateTime = value; } }
        public string LUpd_Prog { get { return _LUpd_Prog; } set { _LUpd_Prog = value; } }
        public string LUpd_User { get { return _LUpd_User; } set { _LUpd_User = value; } }
        #endregion
        public void ConvertToSOOrder(DataRow dr)
        {
            _BranchID = dr["BranchID"].ToString().Trim();
            _SONbr = dr["SONbr"].ToString().Trim();
            _Status = dr["Status"].ToString().Trim();
            _SODate = DateTime.Parse(dr["SODate"].ToString().Trim());
            _SOType = dr["SOType"].ToString().Trim();
            _SODesc = dr["SODesc"].ToString().Trim();
            _ARDocNbr = dr["ARDocNbr"].ToString().Trim();
            _ARDocDate = DateTime.Parse(dr["ARDocDate"].ToString().Trim());
            _INDocNbr = dr["INDocNbr"].ToString().Trim();
            _INDocDate = DateTime.Parse(dr["INDocDate"].ToString().Trim());
            _CustID = dr["CustID"].ToString().Trim();
            _RcptPerson = dr["RcptPerson"].ToString().Trim();
            _SOAddr1 = dr["SOAddr1"].ToString().Trim();
            _SOAdrr2 = dr["SOAdrr2"].ToString().Trim();
            _ShipDate = DateTime.Parse(dr["ShipDate"].ToString().Trim());
            _ShipperID = dr["ShipperID"].ToString().Trim();
            _SlsPerID = dr["SlsPerID"].ToString().Trim();
            _InvcNbr = dr["InvcNbr"].ToString().Trim();
            _InvcNote = dr["InvcNote"].ToString().Trim();
            _SODiscAmt = double.Parse(dr["SODiscAmt"].ToString().Trim());
            _SODiscAmtPct = double.Parse(dr["SODiscAmtPct"].ToString().Trim());
            _SOPreTaxAmt = double.Parse(dr["SOPreTaxAmt"].ToString().Trim());
            _SOTaxAmt = double.Parse(dr["SOTaxAmt"].ToString().Trim());
            _SOAmt = double.Parse(dr["SOAmt"].ToString().Trim());
            _SOQty = double.Parse(dr["SOQty"].ToString().Trim());
            _SOWeight = double.Parse(dr["SOWeight"].ToString().Trim());
            _Reason = dr["Reason"].ToString().Trim();
            _Note = dr["Note"].ToString().Trim();
            _SOOldNbr = dr["SOOldNbr"].ToString().Trim();
            _TimeLmtID = dr["TimeLmtID"].ToString().Trim();
            _DueDate = DateTime.Parse(dr["DueDate"].ToString().Trim());
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
