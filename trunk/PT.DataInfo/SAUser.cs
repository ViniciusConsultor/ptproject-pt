using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PT.DataInfo
{
    public class SAUser
    {
        private string _UserID;
        private string _UserName;
        private string _Password;
        private string _Address;
        private string _Tel;
        private string _Email;

        public string UserID { get { return _UserID; } set { _UserID = value; } }
        public string UserName { get { return _UserName; } set { _UserName = value; } }
        public string Password { get { return _Password; } set { _Password = value; } }
        public string Address { get { return _Address; } set { _Address = value; } }
        public string Tel { get { return _Tel; } set { _Tel = value; } }
        public string Email { get { return _Email; } set { _Email = value; } }

    }
}
