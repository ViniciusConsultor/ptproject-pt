using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
        private float _LineQty;
        private float _Cnvfact;
        private float _UnitRate;
        private float _DetailQty;
        private float _UnitCost;
        private float _TotalCost;
        #region private Pro+Date
        private DateTime _Crtd_DateTime;
        private string _Crtd_Prog;
        private string _Crtd_User;
        private DateTime _LUpd_DateTime;
        private string _LUpd_Prog;
        private string _LUpd_User;
        #endregion

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
        public float LineQty { get { return _LineQty; } set { _LineQty = value; } }
        public float Cnvfact { get { return _Cnvfact; } set { _Cnvfact = value; } }
        public float UnitRate { get { return _UnitRate; } set { _UnitRate = value; } }
        public float DetailQty { get { return _DetailQty; } set { _DetailQty = value; } }
        public float UnitCost { get { return _UnitCost; } set { _UnitCost = value; } }
        public float TotalCost { get { return _TotalCost; } set { _TotalCost = value; } }
        #region Pro+Date
        public DateTime Crtd_DateTime { get { return _Crtd_DateTime; } set { _Crtd_DateTime = value; } }
        public string Crtd_Prog { get { return _Crtd_Prog; } set { _Crtd_Prog = value; } }
        public string Crtd_User { get { return _Crtd_User; } set { _Crtd_User = value; } }
        public DateTime LUpd_DateTime { get { return _LUpd_DateTime; } set { _LUpd_DateTime = value; } }
        public string LUpd_Prog { get { return _LUpd_Prog; } set { _LUpd_Prog = value; } }
        public string LUpd_User { get { return _LUpd_User; } set { _LUpd_User = value; } }
        #endregion
    }
}
