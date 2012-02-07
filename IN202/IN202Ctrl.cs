using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PT.DataInfo;
using PT.Helper;

namespace IN202
{
    public class IN202Ctrl
    {
        public static int SaveINDoc(INDoc info)
        {
            return ConnectDB.ExecuteScalar("sp_INDocSave",
                new String[] { "BranchID",
                                "DocNbr",
                                "Module",
                                "TranType",
                                "TotQty",
                                "WhID",
                                "ToWhID",
                                "TotAmt",
                                "DocDate",
                                "DocDescr",
                                "RsID",
                                "Rlsed",
                                "Note",
                                "Crtd_Prog", "Crtd_User", "LUpd_DateTime", "LUpd_Prog", "LUpd_User" },
                new Object[] { info.BranchID,
                                info.DocNbr,
                                info.Module,
                                info.TranType,
                                info.TotQty,
                                info.WhID,
                                info.ToWhID,
                                info.TotAmt,
                                info.DocDate,
                                info.DocDescr,
                                info.RsID,
                                info.Rlsed,
                                info.Note,
                                info.Crtd_Prog, info.Crtd_User, info.LUpd_DateTime, info.LUpd_Prog, info.LUpd_User });
        }

        public static int DeleteINDoc(string _BranchID, string _DocNbr, string _Module)
        {
            return ConnectDB.ExecuteNonQuery("sp_INDocDelete", new String[] { "BranchID", "DocNbr", "Module" }, new Object[] { _BranchID, _DocNbr, _Module });
        }


        public static int SaveINDocDet(INDocDet info)
        {
            return ConnectDB.ExecuteScalar("sp_INDocDetSave",
                new String[] { "BranchID",
                                "DocNbr",
                                "Module",
                                "LineRef",
                                "TranType",
                                "TranDate",
                                "WhID",
                                "ToWhID",
                                "FreeItem",
                                "ProductID",
                                "TranDesc",
                                "LotID",
                                "INUnit",
                                "LineQty",
                                "UnitCost",
                                "TotalCost",
                                "InvtMult",
                                "ObjID",
                                "ShipperID",
                                "RsID",
                                "Rlsed",
                                "SONbr",
                                "PONbr",
                                "Cnvfact",
                                "UnitRate",
                                "DetailQty",
                                "Crtd_Prog", "Crtd_User", "LUpd_DateTime", "LUpd_Prog", "LUpd_User" },
                new Object[] { info.BranchID,
                                info.DocNbr,
                                info.Module,
                                info.LineRef,
                                info.TranType,
                                info.TranDate,
                                info.WhID,
                                info.ToWhID,
                                info.FreeItem,
                                info.ProductID,
                                info.TranDesc,
                                info.LotID,
                                info.INUnit,
                                info.LineQty,
                                info.UnitCost,
                                info.TotalCost,
                                info.InvtMult,
                                info.ObjID,
                                info.ShipperID,
                                info.RsID,
                                info.Rlsed,
                                info.SONbr,
                                info.PONbr,
                                info.Cnvfact,
                                info.UnitRate,
                                info.DetailQty,
                                info.Crtd_Prog, info.Crtd_User, info.LUpd_DateTime, info.LUpd_Prog, info.LUpd_User });
        }

        public static int DeleteINDocDet(string _BranchID, string _DocNbr, string _Module, string _LineRef)
        {
            return ConnectDB.ExecuteNonQuery("sp_INDocDetDelete", new String[] { "BranchID", "DocNbr", "Module", "LineRef" }, new Object[] { _BranchID, _DocNbr, _Module });
        }
    }
}
