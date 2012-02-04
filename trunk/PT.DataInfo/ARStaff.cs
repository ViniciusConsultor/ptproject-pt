using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PT.DataInfo
{
    public class ARStaff
    {
        private string _StaffId;
        private string _Name;
        private string _Addr;
        private string _Phone;
        private string _EMailAddr;
        private string _Position;
        private bool _Status;
        private bool _WhCtrl;
        #region private Pro+Date
        private DateTime _Crtd_DateTime;
        private string _Crtd_Prog;
        private string _Crtd_User;
        private DateTime _LUpd_DateTime;
        private string _LUpd_Prog;
        private string _LUpd_User;
        #endregion

        public string StaffId { get { return _StaffId; } set { _StaffId = value; } }
        public string Name { get { return _Name; } set { _Name = value; } }
        public string Addr { get { return _Addr; } set { _Addr = value; } }
        public string Phone { get { return _Phone; } set { _Phone = value; } }
        public string EMailAddr { get { return _EMailAddr; } set { _EMailAddr = value; } }
        public string Position { get { return _Position; } set { _Position = value; } }
        public bool Status { get { return _Status; } set { _Status = value; } }
        public bool WhCtrl { get { return _WhCtrl; } set { _WhCtrl = value; } }
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
