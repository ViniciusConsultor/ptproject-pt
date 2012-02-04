using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PT.DataInfo
{
    public class RPRun
    {
        private int _RPID;
        private string _ScreenID;
        private string _ClientName;
        private string _ReportName;
        private string _ReportCap;
        private string _String1;
        private string _String2;
        private string _String3;
        private DateTime _Date1;
        private DateTime _Date2;
        private DateTime _Date3;
        private bool _Bool1;
        private bool _Bool2;
        private bool _Bool3;
        private string _UserID;
        private string _AppPath;

        public int RPID { get { return _RPID; } set { _RPID = value; } }
        public string ScreenID { get { return _ScreenID; } set { _ScreenID = value; } }
        public string ClientName { get { return _ClientName; } set { _ClientName = value; } }
        public string ReportName { get { return _ReportName; } set { _ReportName = value; } }
        public string ReportCap { get { return _ReportCap; } set { _ReportCap = value; } }
        public string String1 { get { return _String1; } set { _String1 = value; } }
        public string String2 { get { return _String2; } set { _String2 = value; } }
        public string String3 { get { return _String3; } set { _String3 = value; } }
        public DateTime Date1 { get { return _Date1; } set { _Date1 = value; } }
        public DateTime Date2 { get { return _Date2; } set { _Date2 = value; } }
        public DateTime Date3 { get { return _Date3; } set { _Date3 = value; } }
        public bool Bool1 { get { return _Bool1; } set { _Bool1 = value; } }
        public bool Bool2 { get { return _Bool2; } set { _Bool2 = value; } }
        public bool Bool3 { get { return _Bool3; } set { _Bool3 = value; } }
        public string UserID { get { return _UserID; } set { _UserID = value; } }
        public string AppPath { get { return _AppPath; } set { _AppPath = value; } }


    }
}
