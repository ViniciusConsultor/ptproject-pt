using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PT.DataInfo
{
    public class SASetup
    {
        private string _Module;
        private string _FistChar;
        private string _LastNbr;

        public string Module { get { return _Module; } set { _Module = value; } }
        public string FistChar { get { return _FistChar; } set { _FistChar = value; } }
        public string LastNbr { get { return _LastNbr; } set { _LastNbr = value; } }

    }
}
