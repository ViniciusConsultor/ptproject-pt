using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PT.DataInfo
{
    public class SAMessage
    {
        private string _MsID;
        private string _Language1;
        private string _Language2;
        private string _Language3;
        private string _Descr;
        public string MsID { get { return _MsID; } set { _MsID = value; } }
        public string Language1 { get { return _Language1; } set { _Language1 = value; } }
        public string Language2 { get { return _Language2; } set { _Language2 = value; } }
        public string Language3 { get { return _Language3; } set { _Language3 = value; } }
        public string Descr { get { return _Descr; } set { _Descr = value; } }
    }
}
