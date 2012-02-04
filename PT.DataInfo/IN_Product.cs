using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PT.DataInfo
{
    class IN_Product
    {
        private static string _ProductID;
        private static string _Descr;
        private static string _ClassID;
        private static string _VendID;
        private static string _Status;
        private static string _FromUnit;
        private static string _ToUnit;
        private static float _Cnvfact;
        private static float _POFromUnitPrice;
        private static float _POToUnitPrice;
        private static DateTime _POPriStartDate;
        private static float _SOFromUnitPrice;
        private static float _SOToUnitPrice;
        private static DateTime _SOPriStartDate;
        private static string _Color;
        private static string _StkUnit;
        private static string _DfltPOUnit;
        private static string _DfltSOUnit;
        private static string _DfltSite;
        private static string _Picture;
        private static string _Size;
        private static float _StkVol;
        private static float _StkWt;
        private static string _Style;
        private static string _DfltTax;
        #region private static Pro+Date
        private static DateTime _Crtd_DateTime;
        private static string _Crtd_Prog;
        private static string _Crtd_User;
        private static DateTime _LUpd_DateTime;
        private static string _LUpd_Prog;
        private static string _LUpd_User;
        #endregion


        public static string ProductID { get { return _ProductID; } set { _ProductID = value; } }
        public static string Descr { get { return _Descr; } set { _Descr = value; } }
        public static string ClassID { get { return _ClassID; } set { _ClassID = value; } }
        public static string VendID { get { return _VendID; } set { _VendID = value; } }
        public static string Status { get { return _Status; } set { _Status = value; } }
        public static string FromUnit { get { return _FromUnit; } set { _FromUnit = value; } }
        public static string ToUnit { get { return _ToUnit; } set { _ToUnit = value; } }
        public static float Cnvfact { get { return _Cnvfact; } set { _Cnvfact = value; } }
        public static float POFromUnitPrice { get { return _POFromUnitPrice; } set { _POFromUnitPrice = value; } }
        public static float POToUnitPrice { get { return _POToUnitPrice; } set { _POToUnitPrice = value; } }
        public static DateTime POPriStartDate { get { return _POPriStartDate; } set { _POPriStartDate = value; } }
        public static float SOFromUnitPrice { get { return _SOFromUnitPrice; } set { _SOFromUnitPrice = value; } }
        public static float SOToUnitPrice { get { return _SOToUnitPrice; } set { _SOToUnitPrice = value; } }
        public static DateTime SOPriStartDate { get { return _SOPriStartDate; } set { _SOPriStartDate = value; } }
        public static string Color { get { return _Color; } set { _Color = value; } }
        public static string StkUnit { get { return _StkUnit; } set { _StkUnit = value; } }
        public static string DfltPOUnit { get { return _DfltPOUnit; } set { _DfltPOUnit = value; } }
        public static string DfltSOUnit { get { return _DfltSOUnit; } set { _DfltSOUnit = value; } }
        public static string DfltSite { get { return _DfltSite; } set { _DfltSite = value; } }
        public static string Picture { get { return _Picture; } set { _Picture = value; } }
        public static string Size { get { return _Size; } set { _Size = value; } }
        public static float StkVol { get { return _StkVol; } set { _StkVol = value; } }
        public static float StkWt { get { return _StkWt; } set { _StkWt = value; } }
        public static string Style { get { return _Style; } set { _Style = value; } }
        public static string DfltTax { get { return _DfltTax; } set { _DfltTax = value; } }
        #region public Pro+Date
        public static DateTime Crtd_DateTime { get { return _Crtd_DateTime; } set { _Crtd_DateTime = value; } }
        public static string Crtd_Prog { get { return _Crtd_Prog; } set { _Crtd_Prog = value; } }
        public static string Crtd_User { get { return _Crtd_User; } set { _Crtd_User = value; } }
        public static DateTime LUpd_DateTime { get { return _LUpd_DateTime; } set { _LUpd_DateTime = value; } }
        public static string LUpd_Prog { get { return _LUpd_Prog; } set { _LUpd_Prog = value; } }
        public static string LUpd_User { get { return _LUpd_User; } set { _LUpd_User = value; } }
        #endregion

    }
}
