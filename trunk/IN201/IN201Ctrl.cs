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

        public static DataTable GetINDocListByPara(string ProID, string UserID, string TranType, DateTime FromDate, DateTime ToDate)
        {
            return ConnectDB.ExecuteReader("sp_GetINDocListByPara", new String[] { "ProID", "UserID", "TranType", "FromDate", "ToDate" }, new Object[] { ProID, UserID, TranType, FromDate, ToDate });
        }
        public static DataTable GetINDocDetByDoc(string BranchID, string DocNbr,string Module)
        {
            return ConnectDB.ExecuteReader("sp_GetINDocDetByDoc", new String[] { "BranchID", "DocNbr","Module" }, new Object[] { BranchID, DocNbr, Module });
        }

        public static DataTable GetINDocByKey(string BranchID, string DocNbr, string Module)
        {
            return ConnectDB.ExecuteReader("sp_INDocDetGetByKey", new String[] { "BranchID", "DocNbr", "Module" }, new Object[] { BranchID, DocNbr, Module });
        }


        public static int DeleteINDocDet(string strBranchID, string strDocNbr, string strModule, string strLineRef)
        {
            return ConnectDB.ExecuteNonQuery("sp_INDocDetDelete", new String[] { "BranchID", "DocNbr", "Module", "Lineref" },
                                                                  new Object[] { strBranchID, strDocNbr, strModule, strLineRef });
        }
        public static int DeleteINDoc(string strBranchID, string strDocNbr, string strModule)
        {
            return ConnectDB.ExecuteNonQuery("sp_INDocDelete", new String[] { "BranchID", "DocNbr", "Module", "Lineref" },
                                                               new Object[] { strBranchID, strDocNbr, strModule });
        }

    }
}
