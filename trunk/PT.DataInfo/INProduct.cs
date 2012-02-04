using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PT.DataInfo
{
    public class INProduct
    {
        private string _ProductID;
        private string _Descr;
        private string _ClassID2;
        private string _ClassID1;
        private string _VendID;
        private string _Status;
        private string _FromUnit;
        private string _ToUnit;
        private float _Cnvfact;
        private float _POFromUnitPrice;
        private float _POToUnitPrice;
        private DateTime _POPriEffDate;
        private float _SOFromUnitPrice;
        private float _SOToUnitPrice;
        private DateTime _SOPriEffDate;
        private string _POUnit;
        private string _SOUnit;
        private string _INUnit;
        private string _Color;
        private string _DfltWhID;
        private string _Picture;
        private string _PriceClassID;
        private string _Size;
        private float _Volume;
        private float _Weight;
        private float _Style;
        private string _TaxID;
        #region private Pro+Date
        private DateTime _Crtd_DateTime;
        private string _Crtd_Prog;
        private string _Crtd_User;
        private DateTime _LUpd_DateTime;
        private string _LUpd_Prog;
        private string _LUpd_User;
        #endregion

        public string ProductID { get { return _ProductID; } set { _ProductID = value; } }
        public string Descr { get { return _Descr; } set { _Descr = value; } }
        public string ClassID2 { get { return _ClassID2; } set { _ClassID2 = value; } }
        public string ClassID1 { get { return _ClassID1; } set { _ClassID1 = value; } }
        public string VendID { get { return _VendID; } set { _VendID = value; } }
        public string Status { get { return _Status; } set { _Status = value; } }
        public string FromUnit { get { return _FromUnit; } set { _FromUnit = value; } }
        public string ToUnit { get { return _ToUnit; } set { _ToUnit = value; } }
        public float Cnvfact { get { return _Cnvfact; } set { _Cnvfact = value; } }
        public float POFromUnitPrice { get { return _POFromUnitPrice; } set { _POFromUnitPrice = value; } }
        public float POToUnitPrice { get { return _POToUnitPrice; } set { _POToUnitPrice = value; } }
        public DateTime POPriEffDate { get { return _POPriEffDate; } set { _POPriEffDate = value; } }
        public float SOFromUnitPrice { get { return _SOFromUnitPrice; } set { _SOFromUnitPrice = value; } }
        public float SOToUnitPrice { get { return _SOToUnitPrice; } set { _SOToUnitPrice = value; } }
        public DateTime SOPriEffDate { get { return _SOPriEffDate; } set { _SOPriEffDate = value; } }
        public string POUnit { get { return _POUnit; } set { _POUnit = value; } }
        public string SOUnit { get { return _SOUnit; } set { _SOUnit = value; } }
        public string INUnit { get { return _INUnit; } set { _INUnit = value; } }
        public string Color { get { return _Color; } set { _Color = value; } }
        public string DfltWhID { get { return _DfltWhID; } set { _DfltWhID = value; } }
        public string Picture { get { return _Picture; } set { _Picture = value; } }
        public string PriceClassID { get { return _PriceClassID; } set { _PriceClassID = value; } }
        public string Size { get { return _Size; } set { _Size = value; } }
        public float Volume { get { return _Volume; } set { _Volume = value; } }
        public float Weight { get { return _Weight; } set { _Weight = value; } }
        public float Style { get { return _Style; } set { _Style = value; } }
        public string TaxID { get { return _TaxID; } set { _TaxID = value; } }
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
