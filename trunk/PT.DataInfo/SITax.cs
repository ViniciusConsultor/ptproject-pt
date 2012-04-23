using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace PT.DataInfo
{
    public class SITax
    {
        private string _TaxID;
        private string _Descr;
        private double _TaxRate;
        public string TaxID { get { return _TaxID; } set { _TaxID = value; } }
        public string Descr { get { return _Descr; } set { _Descr = value; } }
        public double TaxRate { get { return _TaxRate; } set { _TaxRate = value; } }
        public void ConvertToSITax(DataRow dr)
        {
            _TaxID = dr["TaxID"].ToString().Trim();
            _Descr = dr["Descr"].ToString().Trim();
            _TaxRate = double.Parse(dr["TaxRate"].ToString().Trim());

        }
    }
}
