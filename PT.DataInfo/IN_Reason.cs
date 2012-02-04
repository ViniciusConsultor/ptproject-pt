using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PT.DataInfo
{
    class IN_Reason
    {
        private string _RsID;
        private string _Descr;
        #region private Pro+Date
        private DateTime _Crtd_DateTime;
        private string _Crtd_Prog;
        private string _Crtd_User;
        private DateTime _LUpd_DateTime;
        private string _LUpd_Prog;
        private string _LUpd_User;
        #endregion

        public string VendID
        {
            get
            {
                return _RsID;
            }
            set
            {
                _RsID = value;
            }
        }
        public string VendName
        {
            get
            {
                return _Descr;
            }
            set
            {
                _Descr = value;
            }
        }
        #region public Pro+Date
        public DateTime Crtd_DateTime
        {
            get
            {
                return _Crtd_DateTime;
            }
            set
            {
                _Crtd_DateTime = value;
            }
        }
        public string Crtd_Prog
        {
            get
            {
                return _Crtd_Prog;
            }
            set
            {
                _Crtd_Prog = value;
            }
        }
        public string Crtd_User
        {
            get
            {
                return _Crtd_User;
            }
            set
            {
                _Crtd_User = value;
            }
        }
        public DateTime LUpd_DateTime
        {
            get
            {
                return _LUpd_DateTime;
            }
            set
            {
                _LUpd_DateTime = value;
            }
        }
        public string LUpd_Prog
        {
            get
            {
                return _LUpd_Prog;
            }
            set
            {
                _LUpd_Prog = value;
            }
        }
        public string LUpd_User
        {
            get
            {
                return _LUpd_User;
            }
            set
            {
                _LUpd_User = value;
            }
        }
        #endregion
    }
}
