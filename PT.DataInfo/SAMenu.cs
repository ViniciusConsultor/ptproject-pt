using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PT.DataInfo
{  
    class SAMenu
    {
        private string _ModuleID;
        private string _MenuType;
        private string _ScreenID;
        private string _Descr;
        public string ModuleID { get { return _ModuleID; } set { _ModuleID = value; } }
        public string MenuType { get { return _MenuType; } set { _MenuType = value; } }
        public string ScreenID { get { return _ScreenID; } set { _ScreenID = value; } }
        public string Descr { get { return _Descr; } set { _Descr = value; } }
    }
}
