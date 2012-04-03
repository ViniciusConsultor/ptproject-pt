using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PT.Helper;
using PT.DataInfo;
using System.Data;

namespace IN102
{
    public class IN102Ctrl
    {
        public static int SaveUnit(INUnit info)
        {
            return ConnectDB.ExecuteScalar("sp_UnitSave",
                new String[] {"Unit","Crtd_DateTime","Crtd_Prog","Crtd_User","LUpd_DateTime","LUpd_Prog","LUpd_User"},
                new Object[] { info.Unit, info.Crtd_DateTime, info.Crtd_Prog, info.Crtd_User, info.LUpd_DateTime, info.LUpd_Prog, info.LUpd_User});
        }
        public static int DeleteUnit(string Unit)
        {
            return ConnectDB.ExecuteNonQuery("sp_UnitDelete", new String[] { "Unit" }, new Object[] { Unit });
        }
        public static DataTable GetUnit()
        {
            return ConnectDB.GetAll("INUnit");
        }
    }
}
