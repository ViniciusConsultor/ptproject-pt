﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace PT.DataInfo
{
    public class INDocDet
    {
        private string _BranchID;
        private string _DocNbr;
        private string _Module;
        private string _LineRef;
        private string _TranType;
        private string _WhID;
        private string _ToWhID;
        private string _LotID;
        private DateTime _TranDate;
        private string _ProductID;
        private string _TranDesc;
        private bool _FreeItem;
        private int _InvtMult;
        private string _ObjID;
        private string _ShipperID;
        private string _RsID;
        private int _Rlsed;
        private string _SONbr;
        private string _PONbr;
        private string _INUnit;
        private double _LineQty;
        private double _Cnvfact;
        private double _UnitRate;
        private double _DetailQty;
        private double _UnitCost;
        private double _TotalCost;
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
        public string BranchID { get { return _BranchID; } set { _BranchID = value; } }
        public string DocNbr { get { return _DocNbr; } set { _DocNbr = value; } }
        public string Module { get { return _Module; } set { _Module = value; } }
        public string LineRef { get { return _LineRef; } set { _LineRef = value; } }
        public string TranType { get { return _TranType; } set { _TranType = value; } }
        public string WhID { get { return _WhID; } set { _WhID = value; } }
        public string ToWhID { get { return _ToWhID; } set { _ToWhID = value; } }
        public string LotID { get { return _LotID; } set { _LotID = value; } }
        public DateTime TranDate { get { return _TranDate; } set { _TranDate = value; } }
        public string ProductID { get { return _ProductID; } set { _ProductID = value; } }
        public string TranDesc { get { return _TranDesc; } set { _TranDesc = value; } }
        public bool FreeItem { get { return _FreeItem; } set { _FreeItem = value; } }
        public int InvtMult { get { return _InvtMult; } set { _InvtMult = value; } }
        public string ObjID { get { return _ObjID; } set { _ObjID = value; } }
        public string ShipperID { get { return _ShipperID; } set { _ShipperID = value; } }
        public string RsID { get { return _RsID; } set { _RsID = value; } }
        public int Rlsed { get { return _Rlsed; } set { _Rlsed = value; } }
        public string SONbr { get { return _SONbr; } set { _SONbr = value; } }
        public string PONbr { get { return _PONbr; } set { _PONbr = value; } }
        public string INUnit { get { return _INUnit; } set { _INUnit = value; } }
        public double LineQty { get { return _LineQty; } set { _LineQty = value; } }
        public double Cnvfact { get { return _Cnvfact; } set { _Cnvfact = value; } }
        public double UnitRate { get { return _UnitRate; } set { _UnitRate = value; } }
        public double DetailQty { get { return _DetailQty; } set { _DetailQty = value; } }
        public double UnitCost { get { return _UnitCost; } set { _UnitCost = value; } }
        public double TotalCost { get { return _TotalCost; } set { _TotalCost = value; } }
        #region Pro+Date
        public DateTime Crtd_DateTime { get { return _Crtd_DateTime; } set { _Crtd_DateTime = value; } }
        public string Crtd_Prog { get { return _Crtd_Prog; } set { _Crtd_Prog = value; } }
        public string Crtd_User { get { return _Crtd_User; } set { _Crtd_User = value; } }
        public DateTime LUpd_DateTime { get { return _LUpd_DateTime; } set { _LUpd_DateTime = value; } }
        public string LUpd_Prog { get { return _LUpd_Prog; } set { _LUpd_Prog = value; } }
        public string LUpd_User { get { return _LUpd_User; } set { _LUpd_User = value; } }
        #endregion
        public void ConvertToINDocDet(DataRow dr)
        {
            _BranchID = dr["BranchID"].ToString().Trim();
            _DocNbr = dr["DocNbr"].ToString().Trim();
            _Module = dr["Module"].ToString().Trim();
            _LineRef = dr["LineRef"].ToString().Trim();
            _TranType = dr["TranType"].ToString().Trim();
            _WhID = dr["WhID"].ToString().Trim();
            _ToWhID = dr["ToWhID"].ToString().Trim();
            _LotID = dr["LotID"].ToString().Trim();
            _TranDate = DateTime.Parse(dr["TranDate"].ToString().Trim());
            _ProductID = dr["ProductID"].ToString().Trim();
            _TranDesc = dr["TranDesc"].ToString().Trim();
            _FreeItem = bool.Parse(dr["FreeItem"].ToString().Trim());
            _InvtMult = Int32.Parse(dr["InvtMult"].ToString().Trim());
            _ObjID = dr["ObjID"].ToString().Trim();
            _ShipperID = dr["ShipperID"].ToString().Trim();
            _RsID = dr["RsID"].ToString().Trim();
            _Rlsed = Int32.Parse(dr["Rlsed"].ToString().Trim());
            _SONbr = dr["SONbr"].ToString().Trim();
            _PONbr = dr["PONbr"].ToString().Trim();
            _INUnit = dr["INUnit"].ToString().Trim();
            _LineQty = double.Parse(dr["LineQty"].ToString().Trim());
            _Cnvfact = double.Parse(dr["Cnvfact"].ToString().Trim());
            _UnitRate = double.Parse(dr["UnitRate"].ToString().Trim());
            _DetailQty = double.Parse(dr["DetailQty"].ToString().Trim());
            _UnitCost = double.Parse(dr["UnitCost"].ToString().Trim());
            _TotalCost = double.Parse(dr["TotalCost"].ToString().Trim());
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
