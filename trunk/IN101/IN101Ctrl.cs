using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PT.DataInfo;
using PT.Helper;
using System.Data;

namespace IN101
{
    public class IN101Ctrl
    {
        public static int SaveWarehouse(INWarehouse info)
        {
            return ConnectDB.ExecuteScalar("sp_WarehouseSave",
                new String[] { "WhID", "Name", "WhKeeper", "Addr", "Phone", "Type", "Crtd_DateTime", "Crtd_Prog", "Crtd_User", "LUpd_DateTime", "LUpd_Prog", "LUpd_User" },
                new Object[] { info.WhId, info.Name, info.WhKeeper, info.Addr, info.Phone, info.Type, info.Crtd_DateTime,info.Crtd_Prog,info.Crtd_User,info.LUpd_DateTime,info.LUpd_Prog,info.LUpd_User });
        }
        public static int DeleteWarehouse(string WhID)
        {
            return ConnectDB.ExecuteNonQuery("sp_WarehouseDelete", new String[] { "WhID" }, new Object[] { WhID });
        }
        public static DataTable GetWarehouse()
        {
            return ConnectDB.GetAll("INWarehouse");
        }
    }
}
