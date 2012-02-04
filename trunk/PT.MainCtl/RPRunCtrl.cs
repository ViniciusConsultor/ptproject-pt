using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PT.DataInfo;
using PT.Helper;

namespace PT.MainCtl
{
    public class RPRunCtrl
    {
        public static int InsertRPRun(RPRun info)
        {
            return ConnectDB.ExecuteScalar("sp_RPRunInsert",
                new String[] { "RPID", "ScreenID", "ClientName", "ReportName", "ReportCap", "String1", "String2", "String3", "Date1", "Date2" ,"Date3","Bool1","Bool2","Bool3","UserID","AppPath"},
                new Object[] { info.RPID, info.ScreenID, info.ClientName, info.ReportName, info.ReportCap, info.String1, info.String2, info.String3, info.Date1, info.Date2,info.Date3,info.Bool1,info.Bool2,info.Bool3,info.UserID,info.AppPath });
        }

        public static int DeleteRPRun(int RPID)
        {
            return ConnectDB.ExecuteNonQuery("sp_RPRunDelete", new String[] { "RPID" }, new Object[] { RPID });
        }
    }
}
