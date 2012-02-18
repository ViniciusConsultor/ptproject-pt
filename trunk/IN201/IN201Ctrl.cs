using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PT.Helper;
using System.Data;
using PT.DataInfo;

namespace IN201
{
    public class IN201Ctrl
    {
        public static DataTable GetSASetupGetLastNbr(string Module, string FistChar)
        {
            return ConnectDB.ExecuteReader("sp_SASetupGetLastNbr", new String[] { "Module", "FistChar" }, new Object[] { Module, FistChar });
        }

        public static int SaveSASetup(SASetup info)
        {
            return ConnectDB.ExecuteScalar("sp_SASetupSave",
                new String[] { "Module", "FistChar", "LastNbr" },
                new Object[] { info.Module, info.FistChar, info.LastNbr });
        }

        public static int SaveINDoc(INDoc info)
        {
            return ConnectDB.ExecuteScalar("sp_INDocSave",
                new String[] { 
                                "BranchID",
                                "DocNbr",
                                "DocDate",
                                "DocDescr",
                                "Module",
                                "TranType",
                                "WhID",
                                "ToWhID",
                                "TotQty",
                                "TotAmt",
                                "RsID",
                                "Rlsed",
                                "Note",
                    "Crtd_DateTime", "Crtd_Prog", "Crtd_User", "LUpd_DateTime", "LUpd_Prog", "LUpd_User" },
                new Object[] {
                            info.BranchID,
                            info.DocNbr,
                            info.DocDate,
                            info.DocDescr,
                            info.Module,
                            info.TranType,
                            info.WhID,
                            info.ToWhID,
                            info.TotQty,
                            info.TotAmt,
                            info.RsID,
                            info.Rlsed,
                            info.Note,
                    info.Crtd_DateTime, info.Crtd_Prog, info.Crtd_User, info.LUpd_DateTime, info.LUpd_Prog, info.LUpd_User });
        }

        public static int SaveINDocDet(INDocDet info)
        {
            return ConnectDB.ExecuteScalar("sp_INDocDetSave",
                new String[] { 
                                "BranchID",
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
                    "Crtd_DateTime", "Crtd_Prog", "Crtd_User", "LUpd_DateTime", "LUpd_Prog", "LUpd_User" },
                new Object[] {
                           info.BranchID,
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
                    info.Crtd_DateTime, info.Crtd_Prog, info.Crtd_User, info.LUpd_DateTime, info.LUpd_Prog, info.LUpd_User });
        }
    }
}
