using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace PT.DataInfo
{
    public class SOOrderDet
    {
        private string _BranchID;
        private string _SONbr;
        private string _LineRef;
        private string _OrderType;
        private Boolean _FreeItem;
        private string _ProductID;
        private string _Descr;
        private string _WhID;
        private string _LotID;
        private string _SOUnit;
        private double _LineQty;
        private double _Cnvfact;
        private double _UnitRate;
        private double _DetailQty;
        private double _SOPrice;
        private double _LineDiscAmt;
        private double _LineDiscPct;
        private double _SODiscAmt;
        private string _PriceClassID;
        private double _PreTaxAmt;
        private double _TaxAmt;
        private string _TaxID;
        private double _LineAmt;
        private double _LineWeight;
        private double _LineVolume;
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
        public string LineRef { get { return _LineRef; } set { _LineRef = value; } }
        public string OrderType { get { return _OrderType; } set { _OrderType = value; } }
        public bool FreeItem { get { return _FreeItem; } set { _FreeItem = value; } }
        public string ProductID { get { return _ProductID; } set { _ProductID = value; } }
        public string Descr { get { return _Descr; } set { _Descr = value; } }
        public string WhID { get { return _WhID; } set { _WhID = value; } }
        public string LotID { get { return _LotID; } set { _LotID = value; } }
        public string SOUnit { get { return _SOUnit; } set { _SOUnit = value; } }
        public double LineQty { get { return _LineQty; } set { _LineQty = value; } }
        public double Cnvfact { get { return _Cnvfact; } set { _Cnvfact = value; } }
        public double UnitRate { get { return _UnitRate; } set { _UnitRate = value; } }
        public double DetailQty { get { return _DetailQty; } set { _DetailQty = value; } }
        public double SOPrice { get { return _SOPrice; } set { _SOPrice = value; } }
        public double LineDiscAmt { get { return _LineDiscAmt; } set { _LineDiscAmt = value; } }
        public double LineDiscPct { get { return _LineDiscPct; } set { _LineDiscPct = value; } }
        public double SODiscAmt { get { return _SODiscAmt; } set { _SODiscAmt = value; } }
        public string PriceClassID { get { return _PriceClassID; } set { _PriceClassID = value; } }
        public double PreTaxAmt { get { return _PreTaxAmt; } set { _PreTaxAmt = value; } }
        public double TaxAmt { get { return _TaxAmt; } set { _TaxAmt = value; } }
        public string TaxID { get { return _TaxID; } set { _TaxID = value; } }
        public double LineAmt { get { return _LineAmt; } set { _LineAmt = value; } }
        public double LineWeight { get { return _LineWeight; } set { _LineWeight = value; } }
        public double LineVolume { get { return _LineVolume; } set { _LineVolume = value; } }
        #region Pro+Date
        public DateTime Crtd_DateTime { get { return _Crtd_DateTime; } set { _Crtd_DateTime = value; } }
        public string Crtd_Prog { get { return _Crtd_Prog; } set { _Crtd_Prog = value; } }
        public string Crtd_User { get { return _Crtd_User; } set { _Crtd_User = value; } }
        public DateTime LUpd_DateTime { get { return _LUpd_DateTime; } set { _LUpd_DateTime = value; } }
        public string LUpd_Prog { get { return _LUpd_Prog; } set { _LUpd_Prog = value; } }
        public string LUpd_User { get { return _LUpd_User; } set { _LUpd_User = value; } }
        #endregion
        public void ConvertToSOOrderDet(DataRow dr)
        {
            _BranchID = dr["BranchID"].ToString().Trim();
            _SONbr = dr["SONbr"].ToString().Trim();
            _LineRef = dr["LineRef"].ToString().Trim();
            _OrderType = dr["OrderType"].ToString().Trim();
            _FreeItem = bool.Parse(dr["FreeItem"].ToString().Trim());
            _ProductID = dr["ProductID"].ToString().Trim();
            _Descr = dr["Descr"].ToString().Trim();
            _WhID = dr["WhID"].ToString().Trim();
            _LotID = dr["LotID"].ToString().Trim();
            _SOUnit = dr["SOUnit"].ToString().Trim();
            _LineQty = double.Parse(dr["LineQty"].ToString().Trim());
            _Cnvfact = double.Parse(dr["Cnvfact"].ToString().Trim());
            _UnitRate = double.Parse(dr["UnitRate"].ToString().Trim());
            _DetailQty = double.Parse(dr["DetailQty"].ToString().Trim());
            _SOPrice = double.Parse(dr["SOPrice"].ToString().Trim());
            _LineDiscAmt = double.Parse(dr["LineDiscAmt"].ToString().Trim());
            _LineDiscPct = double.Parse(dr["LineDiscPct"].ToString().Trim());
            _SODiscAmt = double.Parse(dr["SODiscAmt"].ToString().Trim());
            _PriceClassID = dr["PriceClassID"].ToString().Trim();
            _PreTaxAmt = double.Parse(dr["PreTaxAmt"].ToString().Trim());
            _TaxAmt = double.Parse(dr["TaxAmt"].ToString().Trim());
            _TaxID = dr["TaxID"].ToString().Trim();
            _LineAmt = double.Parse(dr["LineAmt"].ToString().Trim());
            _LineWeight = double.Parse(dr["LineWeight"].ToString().Trim());
            _LineVolume = double.Parse(dr["LineVolume"].ToString().Trim());
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
