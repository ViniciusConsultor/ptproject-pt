using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace PT.DataInfo
{
    public class SIObject
    {
        private string _ObjID;
        private string _Name;
        private string _ObjType;
        private string _Position;
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
        private Boolean _WhCtrl;
        private double _CrLmtfloat;
        private Boolean _CrLmtCheck;
        private string _TimeLmtID;
        private Boolean _TimeLmtCheck;
        private string _SlsperID;
        private string _DeliveryID;
        private Boolean _Status;
        private DateTime _Crtd_DateTime;
        private string _Crtd_Prog;
        private string _Crtd_User;
        private DateTime _LUpd_DateTime;
        private string _LUpd_Prog;
        private string _LUpd_User;
        private string _Version;

        public string ObjID { get { return _ObjID; } set { _ObjID = value; } }
        public string Name { get { return _Name; } set { _Name = value; } }
        public string ObjType { get { return _ObjType; } set { _ObjType = value; } }
        public string Position { get { return _Position; } set { _Position = value; } }
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
        public Boolean WhCtrl { get { return _WhCtrl; } set { _WhCtrl = value; } }
        public double CrLmtfloat { get { return _CrLmtfloat; } set { _CrLmtfloat = value; } }
        public Boolean CrLmtCheck { get { return _CrLmtCheck; } set { _CrLmtCheck = value; } }
        public string TimeLmtID { get { return _TimeLmtID; } set { _TimeLmtID = value; } }
        public Boolean TimeLmtCheck { get { return _TimeLmtCheck; } set { _TimeLmtCheck = value; } }
        public string SlsperID { get { return _SlsperID; } set { _SlsperID = value; } }
        public string DeliveryID { get { return _DeliveryID; } set { _DeliveryID = value; } }
        public Boolean Status { get { return _Status; } set { _Status = value; } }
        public DateTime Crtd_DateTime { get { return _Crtd_DateTime; } set { _Crtd_DateTime = value; } }
        public string Crtd_Prog { get { return _Crtd_Prog; } set { _Crtd_Prog = value; } }
        public string Crtd_User { get { return _Crtd_User; } set { _Crtd_User = value; } }
        public DateTime LUpd_DateTime { get { return _LUpd_DateTime; } set { _LUpd_DateTime = value; } }
        public string LUpd_Prog { get { return _LUpd_Prog; } set { _LUpd_Prog = value; } }
        public string LUpd_User { get { return _LUpd_User; } set { _LUpd_User = value; } }
        public string Version { get { return _Version; } set { _Version = value; } }

        public void ConvertToSIObject(DataRow dr)
        {
            _ObjID = dr["ObjID"].ToString().Trim();
            _Name = dr["Name"].ToString().Trim();
            _ObjType = dr["ObjType"].ToString().Trim();
            _Position = dr["Position"].ToString().Trim();
            _ClassID = dr["ClassID"].ToString().Trim();
            _RepPerson = dr["RepPerson"].ToString().Trim();
            _Addr1 = dr["Addr1"].ToString().Trim();
            _Addr2 = dr["Addr2"].ToString().Trim();
            _Phone = dr["Phone"].ToString().Trim();
            _EMailAddr = dr["EMailAddr"].ToString().Trim();
            _TaxRegNbr = dr["TaxRegNbr"].ToString().Trim();
            _Fax = dr["Fax"].ToString().Trim();
            _PriceClassID = dr["PriceClassID"].ToString().Trim();
            _SalesRouteID = dr["SalesRouteID"].ToString().Trim();
            _ChannelID = dr["ChannelID"].ToString().Trim();
            _CustTypeID = dr["CustTypeID"].ToString().Trim();
            _CountryID = dr["CountryID"].ToString().Trim();
            _ProvinceID = dr["ProvinceID"].ToString().Trim();
            _DistrictID = dr["DistrictID"].ToString().Trim();
            _WhCtrl = Boolean.Parse(dr["WhCtrl"].ToString().Trim());
            _CrLmtfloat = double.Parse(dr["CrLmtfloat"].ToString().Trim());
            _CrLmtCheck = Boolean.Parse(dr["CrLmtCheck"].ToString().Trim());
            _TimeLmtID = dr["TimeLmtID"].ToString().Trim();
            _TimeLmtCheck = Boolean.Parse(dr["TimeLmtCheck"].ToString().Trim());
            _SlsperID = dr["SlsperID"].ToString().Trim();
            _DeliveryID = dr["DeliveryID"].ToString().Trim();
            _Status = Boolean.Parse(dr["Status"].ToString().Trim());
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
