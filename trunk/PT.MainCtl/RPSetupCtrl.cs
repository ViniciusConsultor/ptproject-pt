using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using PT.Helper;
using PT.DataInfo;

namespace PT.MainCtl
{
    public class RPSetupCtrl
    {
       
        public static DataTable GetBy_ScreenID(string ScreenID)
        {
            return ConnectDB.ExecuteReader("pr_RPSetup_GetByScreen", new String[] { "ScreenID" }, new Object[] { ScreenID });
        }

        //public static DataTable GetBy_RPID(int RPID)
        //{
        //    return ConnectDB.ExecuteReader("pr_RPSetup_GetByRPID", new String[] { "RPID" }, new Object[] { RPID });
        //}

        public static RPSetup GetBy_RPID(int RPID)
        {
            DataTable tb = ConnectDB.ExecuteReader("pr_RPSetup_GetByRPID", new String[] { "RPID" }, new Object[] { RPID });
            RPSetup info = new RPSetup();
            if (tb.Rows.Count > 0)
                info = ConvertToRPSetup(tb.Rows[0]);

            return info;
        }

        public static RPSetup ConvertToRPSetup(DataRow row)
        {
            RPSetup info = new RPSetup();
            try
            {
                info.ScreenID =row["ScreenID"].ToString() ;
                info.RPID = Convert.ToInt32(row["RPID"]);
                info.ReportName = row["ReportName"].ToString();
                info.ReportCap = row["ReportCap"].ToString();
                info.String1 = row["String1"].ToString();
                info.String1Pro = row["String1Pro"].ToString();
                info.String2 = row["String2"].ToString();
                info.String2Pro = row["String2Pro"].ToString();
                info.String3 = row["String3"].ToString();
                info.String3Pro = row["String3Pro"].ToString();
                info.Date1 = row["Date1"].ToString();
                info.Date2 = row["Date2"].ToString();
                info.Date3 = row["Date3"].ToString();
                info.Bool1 = row["Bool1"].ToString();
                info.Bool2 = row["Bool2"].ToString();
                info.Bool3 = row["Bool3"].ToString();
                info.List = row["List"].ToString();
                info.ListPro = row["ListPro"].ToString();
            }
            catch
            {
                info = null;
            }
            return info;
        }
        
    }
}
