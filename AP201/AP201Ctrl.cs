using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using PT.Helper;
using PT.DataInfo;

namespace AP201
{
    public class AP201Ctrl
    {
        public static DataTable FindAPDoc(string ProID, string UserID, string DocType, DateTime FromDate, DateTime ToDate, string DocNbr, string InvcNbr)
        {
            //DataTable APdoc = new DataTable();

            return ConnectDB.ExecuteReader("sp_APDocListGetByPara",
                new String[] { "ProID","UserID","DocType","FromDate","ToDate","DocNbr", "InvcNbr" },
                new Object[] { ProID, UserID,DocType, FromDate, ToDate,DocNbr,InvcNbr });
            //return APdoc;
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
        public static DataTable GetSITax()
        {
            return ConnectDB.GetAll("SITax");
        }
        public static DataTable GetVendID()
        {
            return ConnectDB.ExecuteReader("sp_SIObjectGetVend");
        }
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
        public static DataTable GetAPDoc(string BranchID, string DocNbr)
        {
            return ConnectDB.ExecuteReader("sp_APDocGetVersion",
                new String[] { "BranchID", "DocNbr" },
                new Object[] { BranchID,DocNbr });
        }
        public static int SaveAPDoc(APDoc info)
        {
            int kq = ConnectDB.ExecuteScalar("sp_APDocSave",
                new String[] { "BranchID","DocNbr","DocType","DocDesc","DocAcct","VendID",
                    "DocBal","OrigDocAmt","DocDate","PONbr","InvcNbr","InvcNote","Rlsed","TaxId",
                    "PreTaxAmt","TaxAmt","TimeLmtID","DueDate","Note","Crtd_DateTime","Crtd_Prog",
                    "Crtd_User","LUpd_DateTime","LUpd_Prog","LUpd_User","Version"},
                new Object[] { info.BranchID,info.DocNbr,info.DocType,info.DocDesc,info.DocAcct,info.VendID,
                    info.DocBal,info.OrigDocAmt,info.DocDate,info.PONbr,info.InvcNbr,info.InvcNote,info.Rlsed,info.TaxId,
                    info.PreTaxAmt,info.TaxAmt,info.TimeLmtID,info.DueDate,info.Note,info.Crtd_DateTime,info.Crtd_Prog,
                    info.Crtd_User,info.LUpd_DateTime,info.LUpd_Prog,info.LUpd_User,info.Version});
            return kq;
        }
    }
}
