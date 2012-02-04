﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PT.DataInfo
{
    class IN_ProductStatus
    {
        private string _ProductID;
        private string _WhID;
        private float _AvgCost;
        private float _QtyOnHand;
        private float _QtyOnPO;
        private float _QtyOnSO;
        private float _QtyOnIN;
        private float _QtyAvail;
        #region private Pro+Date
        private DateTime _Crtd_DateTime;
        private string _Crtd_Prog;
        private string _Crtd_User;
        private DateTime _LUpd_DateTime;
        private string _LUpd_Prog;
        private string _LUpd_User;
        #endregion

        public string ProductID { get { return _ProductID; } set { _ProductID = value; } }
        public string WhID { get { return _WhID; } set { _WhID = value; } }
        public float AvgCost { get { return _AvgCost; } set { _AvgCost = value; } }
        public float QtyOnHand { get { return _QtyOnHand; } set { _QtyOnHand = value; } }
        public float QtyOnPO { get { return _QtyOnPO; } set { _QtyOnPO = value; } }
        public float QtyOnSO { get { return _QtyOnSO; } set { _QtyOnSO = value; } }
        public float QtyOnIN { get { return _QtyOnIN; } set { _QtyOnIN = value; } }
        public float QtyAvail { get { return _QtyAvail; } set { _QtyAvail = value; } }
        #region public Pro+Date
        public DateTime Crtd_DateTime { get { return _Crtd_DateTime; } set { _Crtd_DateTime = value; } }
        public string Crtd_Prog { get { return _Crtd_Prog; } set { _Crtd_Prog = value; } }
        public string Crtd_User { get { return _Crtd_User; } set { _Crtd_User = value; } }
        public DateTime LUpd_DateTime { get { return _LUpd_DateTime; } set { _LUpd_DateTime = value; } }
        public string LUpd_Prog { get { return _LUpd_Prog; } set { _LUpd_Prog = value; } }
        public string LUpd_User { get { return _LUpd_User; } set { _LUpd_User = value; } }
        #endregion
    }
}
