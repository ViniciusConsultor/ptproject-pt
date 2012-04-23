using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data;

namespace PT.DataInfo
{
    public class POOrder
    {
        private string _BranchID;
        private string _PONbr;
        private string _POType;
        private DateTime _PODate;
        private string _Status;
        private DateTime _INDocDate;
        private DateTime _APDocDate;
        private string _InvcNbr;
        private string _InvcNote;
        private string _INDocNbr;
        private string _APDocNbr;
        private string _VendID;
        private string _PODescr;
        private double _PODiscAmt;
        private double _PODiscAmtPct;
        private double _PreTaxAmt;
        private double _TaxAmt;
        private double _POAmt;
        private double _POQty;
        private double _POWeight;
        private double _POVolume;
        private string _TimeLmtID;
        private DateTime _DueDate;
        private string _Note;

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
        public string PONbr { get { return _PONbr; } set { _PONbr = value; } }
        public string POType { get { return _POType; } set { _POType = value; } }
        public DateTime PODate { get { return _PODate; } set { _PODate = value; } }
        public string Status { get { return _Status; } set { _Status = value; } }
        public DateTime INDocDate { get { return _INDocDate; } set { _INDocDate = value; } }
        public DateTime APDocDate { get { return _APDocDate; } set { _APDocDate = value; } }
        public string InvcNbr { get { return _InvcNbr; } set { _InvcNbr = value; } }
        public string InvcNote { get { return _InvcNote; } set { _InvcNote = value; } }
        public string INDocNbr { get { return _INDocNbr; } set { _INDocNbr = value; } }
        public string APDocNbr { get { return _APDocNbr; } set { _APDocNbr = value; } }
        public string VendID { get { return _VendID; } set { _VendID = value; } }
        public string PODescr { get { return _PODescr; } set { _PODescr = value; } }
        public double PODiscAmt { get { return _PODiscAmt; } set { _PODiscAmt = value; } }
        public double PODiscAmtPct { get { return _PODiscAmtPct; } set { _PODiscAmtPct = value; } }
        public double PreTaxAmt { get { return _PreTaxAmt; } set { _PreTaxAmt = value; } }
        public double TaxAmt { get { return _TaxAmt; } set { _TaxAmt = value; } }
        public double POAmt { get { return _POAmt; } set { _POAmt = value; } }
        public double POQty { get { return _POQty; } set { _POQty = value; } }
        public double POWeight { get { return _POWeight; } set { _POWeight = value; } }
        public double POVolume { get { return _POVolume; } set { _POVolume = value; } }
        public string TimeLmtID { get { return _TimeLmtID; } set { _TimeLmtID = value; } }
        public DateTime DueDate { get { return _DueDate; } set { _DueDate = value; } }
        public string Note { get { return _Note; } set { _Note = value; } }
        #region Pro+Date
        public DateTime Crtd_DateTime { get { return _Crtd_DateTime; } set { _Crtd_DateTime = value; } }
        public string Crtd_Prog { get { return _Crtd_Prog; } set { _Crtd_Prog = value; } }
        public string Crtd_User { get { return _Crtd_User; } set { _Crtd_User = value; } }
        public DateTime LUpd_DateTime { get { return _LUpd_DateTime; } set { _LUpd_DateTime = value; } }
        public string LUpd_Prog { get { return _LUpd_Prog; } set { _LUpd_Prog = value; } }
        public string LUpd_User { get { return _LUpd_User; } set { _LUpd_User = value; } }
        #endregion
        public void ConvertToPOOrder(DataRow dr)
        {
            _BranchID = dr["BranchID"].ToString().Trim();
            _PONbr = dr["PONbr"].ToString().Trim();
            _POType = dr["POType"].ToString().Trim();
            _PODate = DateTime.Parse(dr["PODate"].ToString().Trim());
            _Status = dr["Status"].ToString().Trim();
            _INDocDate = DateTime.Parse(dr["INDocDate"].ToString().Trim());
            _APDocDate = DateTime.Parse(dr["APDocDate"].ToString().Trim());
            _InvcNbr = dr["InvcNbr"].ToString().Trim();
            _InvcNote = dr["InvcNote"].ToString().Trim();
            _INDocNbr = dr["INDocNbr"].ToString().Trim();
            _APDocNbr = dr["APDocNbr"].ToString().Trim();
            _VendID = dr["VendID"].ToString().Trim();
            _PODescr = dr["PODescr"].ToString().Trim();
            _PODiscAmt = double.Parse(dr["PODiscAmt"].ToString().Trim());
            _PODiscAmtPct = double.Parse(dr["PODiscAmtPct"].ToString().Trim());
            _PreTaxAmt = double.Parse(dr["PreTaxAmt"].ToString().Trim());
            _TaxAmt = double.Parse(dr["TaxAmt"].ToString().Trim());
            _POAmt = double.Parse(dr["POAmt"].ToString().Trim());
            _POQty = double.Parse(dr["POQty"].ToString().Trim());
            _POWeight = double.Parse(dr["POWeight"].ToString().Trim());
            _POVolume = double.Parse(dr["POVolume"].ToString().Trim());
            _TimeLmtID = dr["TimeLmtID"].ToString().Trim();
            _DueDate = DateTime.Parse(dr["DueDate"].ToString().Trim());
            _Note = dr["Note"].ToString().Trim();
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
