using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace PT.DataInfo
{
    public class INProductStatus
    {
        private string _ProductID;
        private string _WhID;
        private string _LotID;
        private double _AvgCost;
        private double _TotalCost;
        private double _QtyOnHand;
        private double _QtyOnPO;
        private double _QtyOnSO;
        private double _QtyOnIN;
        private double _QtyAvail;
        #region private Pro+Date
        private DateTime _Crtd_DateTime;
        private string _Crtd_Prog;
        private string _Crtd_User;
        private DateTime _LUpd_DateTime;
        private string _LUpd_Prog;
        private string _LUpd_User;
        private string _Version;
        #endregion

        public string Version { get { return _Version; } set { _Version = value; } }
        public string ProductID { get { return _ProductID; } set { _ProductID = value; } }
        public string WhID { get { return _WhID; } set { _WhID = value; } }
        public string LotID { get { return _LotID; } set { _LotID = value; } }
        public double AvgCost { get { return _AvgCost; } set { _AvgCost = value; } }
        public double TotalCost { get { return _TotalCost; } set { _TotalCost = value; } }
        public double QtyOnHand { get { return _QtyOnHand; } set { _QtyOnHand = value; } }
        public double QtyOnPO { get { return _QtyOnPO; } set { _QtyOnPO = value; } }
        public double QtyOnSO { get { return _QtyOnSO; } set { _QtyOnSO = value; } }
        public double QtyOnIN { get { return _QtyOnIN; } set { _QtyOnIN = value; } }
        public double QtyAvail { get { return _QtyAvail; } set { _QtyAvail = value; } }
        #region Pro+Date
        public DateTime Crtd_DateTime { get { return _Crtd_DateTime; } set { _Crtd_DateTime = value; } }
        public string Crtd_Prog { get { return _Crtd_Prog; } set { _Crtd_Prog = value; } }
        public string Crtd_User { get { return _Crtd_User; } set { _Crtd_User = value; } }
        public DateTime LUpd_DateTime { get { return _LUpd_DateTime; } set { _LUpd_DateTime = value; } }
        public string LUpd_Prog { get { return _LUpd_Prog; } set { _LUpd_Prog = value; } }
        public string LUpd_User { get { return _LUpd_User; } set { _LUpd_User = value; } }
        #endregion
        public void ConvertToINProductStatus(DataRow dr)
        {
            _ProductID = dr["ProductID"].ToString().Trim();
            _WhID = dr["WhID"].ToString().Trim();
            _LotID = dr["LotID"].ToString().Trim();
            _AvgCost = double.Parse(dr["AvgCost"].ToString().Trim());
            _TotalCost = double.Parse(dr["TotalCost"].ToString().Trim());
            _QtyOnHand = double.Parse(dr["QtyOnHand"].ToString().Trim());
            _QtyOnPO = double.Parse(dr["QtyOnPO"].ToString().Trim());
            _QtyOnSO = double.Parse(dr["QtyOnSO"].ToString().Trim());
            _QtyOnIN = double.Parse(dr["QtyOnIN"].ToString().Trim());
            _QtyAvail = double.Parse(dr["QtyAvail"].ToString().Trim());
            _Crtd_DateTime = DateTime.Parse(dr["Crtd_DateTime"].ToString().Trim());
            _Crtd_Prog = dr["Crtd_Prog"].ToString().Trim();
            _Crtd_User = dr["Crtd_User"].ToString().Trim();
            _LUpd_DateTime = DateTime.Parse(dr["LUpd_DateTime"].ToString().Trim());
            _LUpd_Prog = dr["LUpd_Prog"].ToString().Trim();
            _LUpd_User = dr["LUpd_User"].ToString().Trim();
            _Version = dr["Version"].ToString().Trim();
        }
    }
}
