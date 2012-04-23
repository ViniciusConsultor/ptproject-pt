using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;


namespace PT.DataInfo
{
    public class APDoc
    {
        private string _BranchID;
        private string _DocNbr;
        private string _DocType;
        private string _DocDesc;
        private string _DocAcct;
        private string _VendID;
        private double _DocBal;
        private double _OrigDocAmt;
        private DateTime _DocDate;
        private string _PONbr;
        private string _InvcNbr;
        private string _InvcNote;
        private int _Rlsed;
        private string _TaxId;
        private double _PreTaxAmt;
        private double _TaxAmt;
        private string _TimeLmtID;
        private DateTime _DueDate;
        private string _Note;
        private DateTime _Crtd_DateTime;
        private string _Crtd_Prog;
        private string _Crtd_User;
        private DateTime _LUpd_DateTime;
        private string _LUpd_Prog;
        private string _LUpd_User;
        private string _Version;

        public string BranchID { get { return _BranchID; } set { _BranchID = value; } }
        public string DocNbr { get { return _DocNbr; } set { _DocNbr = value; } }
        public string DocType { get { return _DocType; } set { _DocType = value; } }
        public string DocDesc { get { return _DocDesc; } set { _DocDesc = value; } }
        public string DocAcct { get { return _DocAcct; } set { _DocAcct = value; } }
        public string VendID { get { return _VendID; } set { _VendID = value; } }
        public double DocBal { get { return _DocBal; } set { _DocBal = value; } }
        public double OrigDocAmt { get { return _OrigDocAmt; } set { _OrigDocAmt = value; } }
        public DateTime DocDate { get { return _DocDate; } set { _DocDate = value; } }
        public string PONbr { get { return _PONbr; } set { _PONbr = value; } }
        public string InvcNbr { get { return _InvcNbr; } set { _InvcNbr = value; } }
        public string InvcNote { get { return _InvcNote; } set { _InvcNote = value; } }
        public int Rlsed { get { return _Rlsed; } set { _Rlsed = value; } }
        public string TaxId { get { return _TaxId; } set { _TaxId = value; } }
        public double PreTaxAmt { get { return _PreTaxAmt; } set { _PreTaxAmt = value; } }
        public double TaxAmt { get { return _TaxAmt; } set { _TaxAmt = value; } }
        public string TimeLmtID { get { return _TimeLmtID; } set { _TimeLmtID = value; } }
        public DateTime DueDate { get { return _DueDate; } set { _DueDate = value; } }
        public string Note { get { return _Note; } set { _Note = value; } }
        public DateTime Crtd_DateTime { get { return _Crtd_DateTime; } set { _Crtd_DateTime = value; } }
        public string Crtd_Prog { get { return _Crtd_Prog; } set { _Crtd_Prog = value; } }
        public string Crtd_User { get { return _Crtd_User; } set { _Crtd_User = value; } }
        public DateTime LUpd_DateTime { get { return _LUpd_DateTime; } set { _LUpd_DateTime = value; } }
        public string LUpd_Prog { get { return _LUpd_Prog; } set { _LUpd_Prog = value; } }
        public string LUpd_User { get { return _LUpd_User; } set { _LUpd_User = value; } }
        public string Version { get { return _Version; } set { _Version = value; } }

        public void ConvertToAPDoc(DataRow dr)
        {
            _BranchID = dr["BranchID"].ToString().Trim();
            _DocNbr = dr["DocNbr"].ToString().Trim();
            _DocType = dr["DocType"].ToString().Trim();
            _DocDesc = dr["DocDesc"].ToString().Trim();
            _DocAcct = dr["DocAcct"].ToString().Trim();
            _VendID = dr["VendID"].ToString().Trim();
            _DocBal = double.Parse(dr["DocBal"].ToString().Trim());
            _OrigDocAmt = double.Parse(dr["OrigDocAmt"].ToString().Trim());
            _DocDate = DateTime.Parse(dr["DocDate"].ToString().Trim());
            _PONbr = dr["PONbr"].ToString().Trim();
            _InvcNbr = dr["InvcNbr"].ToString().Trim();
            _InvcNote = dr["InvcNote"].ToString().Trim();
            _Rlsed = Int32.Parse(dr["Rlsed"].ToString().Trim());
            _TaxId = dr["TaxId"].ToString().Trim();
            _PreTaxAmt = double.Parse(dr["PreTaxAmt"].ToString().Trim());
            _TaxAmt = double.Parse(dr["TaxAmt"].ToString().Trim());
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
