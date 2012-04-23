using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

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
        private double _Cnvfact;
        private double _POFromUnitPrice;
        private double _POToUnitPrice;
        private DateTime _POPriEffDate;
        private double _SOFromUnitPrice;
        private double _SOToUnitPrice;
        private DateTime _SOPriEffDate;
        private string _POUnit;
        private string _SOUnit;
        private string _INUnit;
        private string _Color;
        private string _DfltWhID;
        private string _Picture;
        private string _PriceClassID;
        private string _Size;
        private double _Volume;
        private double _Weight;
        private string _Style;
        private string _TaxID;
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
        public string ProductID { get { return _ProductID; } set { _ProductID = value; } }
        public string Descr { get { return _Descr; } set { _Descr = value; } }
        public string ClassID2 { get { return _ClassID2; } set { _ClassID2 = value; } }
        public string ClassID1 { get { return _ClassID1; } set { _ClassID1 = value; } }
        public string VendID { get { return _VendID; } set { _VendID = value; } }
        public string Status { get { return _Status; } set { _Status = value; } }
        public string FromUnit { get { return _FromUnit; } set { _FromUnit = value; } }
        public string ToUnit { get { return _ToUnit; } set { _ToUnit = value; } }
        public double Cnvfact { get { return _Cnvfact; } set { _Cnvfact = value; } }
        public double POFromUnitPrice { get { return _POFromUnitPrice; } set { _POFromUnitPrice = value; } }
        public double POToUnitPrice { get { return _POToUnitPrice; } set { _POToUnitPrice = value; } }
        public DateTime POPriEffDate { get { return _POPriEffDate; } set { _POPriEffDate = value; } }
        public double SOFromUnitPrice { get { return _SOFromUnitPrice; } set { _SOFromUnitPrice = value; } }
        public double SOToUnitPrice { get { return _SOToUnitPrice; } set { _SOToUnitPrice = value; } }
        public DateTime SOPriEffDate { get { return _SOPriEffDate; } set { _SOPriEffDate = value; } }
        public string POUnit { get { return _POUnit; } set { _POUnit = value; } }
        public string SOUnit { get { return _SOUnit; } set { _SOUnit = value; } }
        public string INUnit { get { return _INUnit; } set { _INUnit = value; } }
        public string Color { get { return _Color; } set { _Color = value; } }
        public string DfltWhID { get { return _DfltWhID; } set { _DfltWhID = value; } }
        public string Picture { get { return _Picture; } set { _Picture = value; } }
        public string PriceClassID { get { return _PriceClassID; } set { _PriceClassID = value; } }
        public string Size { get { return _Size; } set { _Size = value; } }
        public double Volume { get { return _Volume; } set { _Volume = value; } }
        public double Weight { get { return _Weight; } set { _Weight = value; } }
        public string Style { get { return _Style; } set { _Style = value; } }
        public string TaxID { get { return _TaxID; } set { _TaxID = value; } }
        #region Pro+Date
        public DateTime Crtd_DateTime { get { return _Crtd_DateTime; } set { _Crtd_DateTime = value; } }
        public string Crtd_Prog { get { return _Crtd_Prog; } set { _Crtd_Prog = value; } }
        public string Crtd_User { get { return _Crtd_User; } set { _Crtd_User = value; } }
        public DateTime LUpd_DateTime { get { return _LUpd_DateTime; } set { _LUpd_DateTime = value; } }
        public string LUpd_Prog { get { return _LUpd_Prog; } set { _LUpd_Prog = value; } }
        public string LUpd_User { get { return _LUpd_User; } set { _LUpd_User = value; } }
        #endregion
        public void ConvertToINProduct(DataRow dr)
        {
            _ProductID = dr["ProductID"].ToString().Trim();
            _Descr = dr["Descr"].ToString().Trim();
            _ClassID2 = dr["ClassID2"].ToString().Trim();
            _ClassID1 = dr["ClassID1"].ToString().Trim();
            _VendID = dr["VendID"].ToString().Trim();
            _Status = dr["Status"].ToString().Trim();
            _FromUnit = dr["FromUnit"].ToString().Trim();
            _ToUnit = dr["ToUnit"].ToString().Trim();
            _Cnvfact = double.Parse(dr["Cnvfact"].ToString().Trim());
            _POFromUnitPrice = double.Parse(dr["POFromUnitPrice"].ToString().Trim());
            _POToUnitPrice = double.Parse(dr["POToUnitPrice"].ToString().Trim());
            _POPriEffDate = DateTime.Parse(dr["POPriEffDate"].ToString().Trim());
            _SOFromUnitPrice = double.Parse(dr["SOFromUnitPrice"].ToString().Trim());
            _SOToUnitPrice = double.Parse(dr["SOToUnitPrice"].ToString().Trim());
            _SOPriEffDate = DateTime.Parse(dr["SOPriEffDate"].ToString().Trim());
            _POUnit = dr["POUnit"].ToString().Trim();
            _SOUnit = dr["SOUnit"].ToString().Trim();
            _INUnit = dr["INUnit"].ToString().Trim();
            _Color = dr["Color"].ToString().Trim();
            _DfltWhID = dr["DfltWhID"].ToString().Trim();
            _Picture = dr["Picture"].ToString().Trim();
            _PriceClassID = dr["PriceClassID"].ToString().Trim();
            _Size = dr["Size"].ToString().Trim();
            _Volume = double.Parse(dr["Volume"].ToString().Trim());
            _Weight = double.Parse(dr["Weight"].ToString().Trim());
            _Style = dr["Style"].ToString().Trim();
            _TaxID = dr["TaxID"].ToString().Trim();
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
