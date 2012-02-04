using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PT.DataInfo
{
    public class ARCustomer
    {
        private string _CustID;
        private string _CustName;
        private string _ClassID;
        private string _RepPerson;
        private string _Addr1;
        private string _Addr2;
        private string _Phone;
        private string _EMailAddr;
        private string _TaxRegNbr;
        private string _Fax;
        private string _PriceClassID;
        private string _SalesRouteID;
        private string _ChannelID;
        private string _CustTypeID;
        private string _CountryID;
        private string _ProvinceID;
        private string _DistrictID;
        private float _CrLmt;
        private bool _CrLmtCheck;
        private string _TimeLmtID;
        private bool _TimeLmtCheck;
        private string _SlsperID;
        private string _DeliveryID;
        private bool _Status;
        #region private Pro+Date
        private DateTime _Crtd_DateTime;
        private string _Crtd_Prog;
        private string _Crtd_User;
        private DateTime _LUpd_DateTime;
        private string _LUpd_Prog;
        private string _LUpd_User;
        #endregion

        public string CustID { get { return _CustID; } set { _CustID = value; } }
        public string CustName { get { return _CustName; } set { _CustName = value; } }
        public string ClassID { get { return _ClassID; } set { _ClassID = value; } }
        public string RepPerson { get { return _RepPerson; } set { _RepPerson = value; } }
        public string Addr1 { get { return _Addr1; } set { _Addr1 = value; } }
        public string Addr2 { get { return _Addr2; } set { _Addr2 = value; } }
        public string Phone { get { return _Phone; } set { _Phone = value; } }
        public string EMailAddr { get { return _EMailAddr; } set { _EMailAddr = value; } }
        public string TaxRegNbr { get { return _TaxRegNbr; } set { _TaxRegNbr = value; } }
        public string Fax { get { return _Fax; } set { _Fax = value; } }
        public string PriceClassID { get { return _PriceClassID; } set { _PriceClassID = value; } }
        public string SalesRouteID { get { return _SalesRouteID; } set { _SalesRouteID = value; } }
        public string ChannelID { get { return _ChannelID; } set { _ChannelID = value; } }
        public string CustTypeID { get { return _CustTypeID; } set { _CustTypeID = value; } }
        public string CountryID { get { return _CountryID; } set { _CountryID = value; } }
        public string ProvinceID { get { return _ProvinceID; } set { _ProvinceID = value; } }
        public string DistrictID { get { return _DistrictID; } set { _DistrictID = value; } }
        public float CrLmt { get { return _CrLmt; } set { _CrLmt = value; } }
        public bool CrLmtCheck { get { return _CrLmtCheck; } set { _CrLmtCheck = value; } }
        public string TimeLmtID { get { return _TimeLmtID; } set { _TimeLmtID = value; } }
        public bool TimeLmtCheck { get { return _TimeLmtCheck; } set { _TimeLmtCheck = value; } }
        public string SlsperID { get { return _SlsperID; } set { _SlsperID = value; } }
        public string DeliveryID { get { return _DeliveryID; } set { _DeliveryID = value; } }
        public bool Status { get { return _Status; } set { _Status = value; } }
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
