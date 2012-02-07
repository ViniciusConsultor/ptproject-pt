using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PT.Helper;
using PT.DataInfo;

namespace PT.Controller
{
    public class INDocDetCtrl
    {
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
