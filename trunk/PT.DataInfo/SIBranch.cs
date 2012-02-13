using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PT.DataInfo
{
    public class SIBranch
    {
        private string _BranchID;
        private string _BranchName;
        private string _Addr;
        private string _Tel;
        private string _Fax;
        private string _Email;
        private string _TaxRegNbr;
        private string _ChiefOfficer;
        private string _ChiefAccountant;
        private string _Cashier;
        private string _Director;
        private string _Province;
        private string _State;
        private string _Country;
        private string _SOPrice;

        public string BranchID { get { return _BranchID; } set { _BranchID = value; } }
        public string BranchName { get { return _BranchName; } set { _BranchName = value; } }
        public string Addr { get { return _Addr; } set { _Addr = value; } }
        public string Tel { get { return _Tel; } set { _Tel = value; } }
        public string Fax { get { return _Fax; } set { _Fax = value; } }
        public string Email { get { return _Email; } set { _Email = value; } }
        public string TaxRegNbr { get { return _TaxRegNbr; } set { _TaxRegNbr = value; } }
        public string ChiefOfficer { get { return _ChiefOfficer; } set { _ChiefOfficer = value; } }
        public string ChiefAccountant { get { return _ChiefAccountant; } set { _ChiefAccountant = value; } }
        public string Cashier { get { return _Cashier; } set { _Cashier = value; } }
        public string Director { get { return _Director; } set { _Director = value; } }
        public string Province { get { return _Province; } set { _Province = value; } }
        public string State { get { return _State; } set { _State = value; } }
        public string Country { get { return _Country; } set { _Country = value; } }
        public string SOPrice { get { return _SOPrice; } set { _SOPrice = value; } }

    }
}
