using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PT.DataInfo
{
    public class POOrderDet
    {
        private string _BranchID;
        private string _PONbr;
        private string _LineRef;
        private string _TranType;
        private string _WhID;
        private string _LotID;
        private string _ProductID;
        private string _TranDesc;
        private bool _FreeItem;
        private string _POUnit;
        private double _LineQty;
        private double _UnitRate;
        private double _Cnvfact;
        private double _DetailQty;
        private double _POPrice;
        private double _LineDiscAmt;
        private double _LineDiscPct;
        private double _PODiscAmt;
        private double _PreTaxAmt;
        private double _TaxAmt;
        private string _TaxID;
        private double _LineAmt;
        private double _UnitCost;
        private double _LineWeight;
        private double _LineVolume;
        private int _Rlsed;
        #region private Pro+Date
        private DateTime _Crtd_DateTime;
        private string _Crtd_Prog;
        private string _Crtd_User;
        private DateTime _LUpd_DateTime;
        private string _LUpd_Prog;
        private string _LUpd_User;
        #endregion

        public string BranchID { get { return _BranchID; } set { _BranchID = value; } }
        public string PONbr { get { return _PONbr; } set { _PONbr = value; } }
        public string LineRef { get { return _LineRef; } set { _LineRef = value; } }
        public string TranType { get { return _TranType; } set { _TranType = value; } }
        public string WhID { get { return _WhID; } set { _WhID = value; } }
        public string LotID { get { return _LotID; } set { _LotID = value; } }
        public string ProductID { get { return _ProductID; } set { _ProductID = value; } }
        public string TranDesc { get { return _TranDesc; } set { _TranDesc = value; } }
        public bool FreeItem { get { return _FreeItem; } set { _FreeItem = value; } }
        public string POUnit { get { return _POUnit; } set { _POUnit = value; } }
        public double LineQty { get { return _LineQty; } set { _LineQty = value; } }
        public double UnitRate { get { return _UnitRate; } set { _UnitRate = value; } }
        public double Cnvfact { get { return _Cnvfact; } set { _Cnvfact = value; } }
        public double DetailQty { get { return _DetailQty; } set { _DetailQty = value; } }
        public double POPrice { get { return _POPrice; } set { _POPrice = value; } }
        public double LineDiscAmt { get { return _LineDiscAmt; } set { _LineDiscAmt = value; } }
        public double LineDiscPct { get { return _LineDiscPct; } set { _LineDiscPct = value; } }
        public double PODiscAmt { get { return _PODiscAmt; } set { _PODiscAmt = value; } }
        public double PreTaxAmt { get { return _PreTaxAmt; } set { _PreTaxAmt = value; } }
        public double TaxAmt { get { return _TaxAmt; } set { _TaxAmt = value; } }
        public string TaxID { get { return _TaxID; } set { _TaxID = value; } }
        public double LineAmt { get { return _LineAmt; } set { _LineAmt = value; } }
        public double UnitCost { get { return _UnitCost; } set { _UnitCost = value; } }
        public double LineWeight { get { return _LineWeight; } set { _LineWeight = value; } }
        public double LineVolume { get { return _LineVolume; } set { _LineVolume = value; } }
        public int Rlsed { get { return _Rlsed; } set { _Rlsed = value; } }
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
