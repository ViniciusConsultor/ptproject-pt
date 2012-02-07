using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PT.DataInfo;
using PT.Helper;

namespace IN103
{
    public class IN103Ctrl
    {
        public static int SaveINReason(INReason info)
        {
            return ConnectDB.ExecuteScalar("sp_INReasonSave",
                new String[] { "RsID", "Descr",  "Crtd_Prog", "Crtd_User", "LUpd_DateTime", "LUpd_Prog", "LUpd_User" },
                new Object[] { info.RsID, info.Descr, info.Crtd_Prog, info.Crtd_User, info.LUpd_DateTime, info.LUpd_Prog, info.LUpd_User });
        }
        public static int DeleteINReason(string _strRsID)
        {
            return ConnectDB.ExecuteNonQuery("sp_INReasonDelete", new String[] { "RsID" }, new Object[] { _strRsID });
        }
    }
}
