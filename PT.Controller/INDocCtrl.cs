using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PT.Helper;
using PT.DataInfo;

namespace PT.Controller
{
    public class INDocCtrl
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


    }
}
