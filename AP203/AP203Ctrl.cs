using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PT.Helper;
using System.Data;
using PT.DataInfo;

namespace AP203
{
    class AP203Ctrl
    {
        public static DataTable FindAPADjust(string ProID, string UserID, string AdjNbr, DateTime FromDate, DateTime ToDate)
        {
            return ConnectDB.ExecuteReader("sp_APAdjustListGetByPara",
                new String[] { "ProID", "UserID", "AdjNbr", "FromDate", "ToDate" },
                new Object[] { ProID, UserID, AdjNbr, FromDate, ToDate });
        }
        public static DataTable FindAPADjustDet(string AdjNbr)
        {
            return ConnectDB.ExecuteReader("sp_APAdjustDetListGetByPara",
                new String[] { "AdjNbr"},
                new Object[] { AdjNbr });
        }
        public static DataTable GetCAAccount()
        {
            return ConnectDB.ExecuteReader("sp_CAAccountGetActive");
        }
        public static DataTable GetSIBranch()
        {
            return ConnectDB.GetAll("SIBranch");
        }
        public static DataTable GetSAUser()
        {
            return ConnectDB.GetAll("SAUser");
        }
        public static DataTable GetVendID()
        {
            return ConnectDB.ExecuteReader("sp_SIObjectGetVend");
        }
        public static DataTable GetAPAdjust(string BranchID, string AdjNbr)
        {
            return ConnectDB.ExecuteReader("sp_APAdjustGetByPara",
                 new String[] { "BranchID", "AdjNbr" },
                 new Object[] { BranchID, AdjNbr });

        }
        public static DataTable GetAPAdjustDet(string AdjNbr)
        {
            return ConnectDB.ExecuteReader("sp_APAdjustDetGetByPara",
                 new String[] { "AdjNbr" },
                 new Object[] { AdjNbr });
        }
        public static DataTable GetSASetupGetLastNbr(string Module, string FistChar)
        {
            return ConnectDB.ExecuteReader("sp_SASetupGetLastNbr", new String[] { "Module", "FistChar" }, new Object[] { Module, FistChar });
        }
        public static DataTable LoadADoc(string BrandID, string AdjNbr, string VendID, int Rlsed)
        {
            return ConnectDB.ExecuteReader("AP203_LoadADocList",
                new string[] { "BranchID", "AdjNbr", "VendID", "Rlsed"},
                new Object[] { BrandID, AdjNbr, VendID, Rlsed });
        }
        public static DataTable LoadNDoc(string BrandID, string AdjNbr, string VendID, int Rlsed)
        {
            return ConnectDB.ExecuteReader("AP203_LoadNDocList",
                new string[] { "BranchID", "AdjNbr", "VendID", "Rlsed" },
                new Object[] { BrandID, AdjNbr, VendID, Rlsed});
        }
        public static int SaveSASetup(SASetup info)
        {
            return ConnectDB.ExecuteScalar("sp_SASetupSave",
                new String[] { "Module", "FistChar", "LastNbr" },
                new Object[] { info.Module, info.FistChar, info.LastNbr });
        }
        public static int SaveAPAdjust(APAdjust info)
        {
            int kq = ConnectDB.ExecuteScalar("sp_APAdjustSave",
                new String[] {"BranchID","AdjNbr","AdjDate","AdjDesc","AdjAcct","AdjAmt"
                                ,"Rlsed","Note","FromDateTmp","ToDateTmp","VendIDTmp"
                                ,"Crtd_DateTime","Crtd_Prog","Crtd_User","LUpd_DateTime"
                                ,"LUpd_Prog","LUpd_User","Version" },
                new Object[] {info.BranchID,info.AdjNbr,info.AdjDate,info.AdjDesc,info.AdjAcct,info.AdjAmt
                                ,info.Rlsed,info.Note,info.FromDateTmp,info.ToDateTmp,info.VendIDTmp
                                ,info.Crtd_DateTime,info.Crtd_Prog,info.Crtd_User,info.LUpd_DateTime
                                ,info.LUpd_Prog,info.LUpd_User,info.Version});
            return kq;
        }
        public static int SaveAPAdjustDet(APAdjustDet info)
        {
            int kq = ConnectDB.ExecuteScalar("sp_APAdjustDetSave",
                new String[] { "BranchID","AdjNbr","LineRef","VendID","AdjDate","AdjAcct"
                                ,"AdjAmt","NDocNbr","NDocType","NDocDate","ADocNbr","ADocType"
                                ,"ADocDate","Rlsed","Crtd_DateTime","Crtd_Prog","Crtd_User"
                                ,"LUpd_DateTime","LUpd_Prog","LUpd_User","Version" },
                new Object[] { info.BranchID,info.AdjNbr,info.LineRef,info.VendID,info.AdjDate,info.AdjAcct
                                ,info.AdjAmt,info.NDocNbr,info.NDocType,info.NDocDate,info.ADocNbr,info.ADocType
                                ,info.ADocDate,info.Rlsed,info.Crtd_DateTime,info.Crtd_Prog,info.Crtd_User
                                ,info.LUpd_DateTime,info.LUpd_Prog,info.LUpd_User,info.Version });
            return kq;
        }
    }
}
