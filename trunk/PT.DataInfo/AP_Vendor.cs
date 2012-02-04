using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace PT.DataInfo
{
    class AP_Vendor
    {
        private static string _VendID;
        private static string _VendName;
        private static string _Addr;
        private static string _EMailAddr;
        private static string _Fax;
        private static string _Phone;
        private static string _Attn;
        private static string _Status;
        private static DateTime _Crtd_DateTime;
        private static string _Crtd_Prog;
        private static string _Crtd_User;
        private static DateTime _LUpd_DateTime;
        private static string _LUpd_Prog;
        private static string _LUpd_User;
    #region Public Properties
        public static string VendID
        {
            get{return _VendID;}
            set{_VendID = value;}
        }
        public static string VendName
        {
            get{return _VendName ;}
            set{_VendName = value;}
        }
        public static string Addr
        {
            get{return _Addr;}
            set{_Addr = value;}
        }
        public static string EMailAddr
        {
            get{return _EMailAddr;}
            set{_EMailAddr = value;}
        }
        public static string Fax
        {
            get{return _Fax;}
            set{_Fax = value;}
        }
        public static string Phone
        {
            get{return _Phone;}
            set{_Phone = value;}
        }
        public static string Attn
        {
            get{return _Attn;}
            set{_Attn = value;}
        }
        public static string Status
        {
            get{return _Status;}
            set{_Status = value;}
        }
        public static DateTime Crtd_DateTime
        {
            get{return _Crtd_DateTime;}
            set{_Crtd_DateTime = value;}
        }
        public static string Crtd_Prog
        {
            get{return _Crtd_Prog;}
            set{_Crtd_Prog = value;}
        }
        public static string Crtd_User
        {
            get{return _Crtd_User;}
            set{_Crtd_User = value;}
        }
        public static DateTime LUpd_DateTime
        {
            get{return _LUpd_DateTime;}
            set{_LUpd_DateTime = value;}
        }
        public static string LUpd_Prog
        {
            get {return _LUpd_Prog;}
            set{_LUpd_Prog = value;}
        }
        public static string LUpd_User
        {
            get{return _LUpd_User;}
            set{_LUpd_User = value;}
        }
    #endregion
    }
}
