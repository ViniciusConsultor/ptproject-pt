using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PT.Helper;
using System.Data;
using PT.DataInfo;

namespace IN104
{
    public class IN104Ctrl
    {
        public static DataTable GetINProductClass2ByClass1(string VendID, string ClassID1)
        {
            return ConnectDB.ExecuteReader("sp_INProductClass2GetByClass1", new String[] { "VendID", "ClassID1" }, new Object[] { VendID, ClassID1 });
        }

        public static DataTable GetINProductClass1ByVendID(string VendID)
        {
            return ConnectDB.ExecuteReader("sp_INProductClass1GetByVendID", new String[] { "VendID" }, new Object[] { VendID });
        }

        public static int SaveINProductClass1(INProductClass1 info)
        {
            return ConnectDB.ExecuteScalar("sp_INProductClass1Save",
                new String[] { 
                                "VendID",
                                "ClassID1",
                                "Descr",
                                "DfltTaxID",
                                "DfltWhID",
                                "POUnit",
                                "SOUnit",
                                "INUnit",
                    "Crtd_DateTime", "Crtd_Prog", "Crtd_User", "LUpd_DateTime", "LUpd_Prog", "LUpd_User" },
                new Object[] {
                            info.VendID,
                            info.ClassID1,
                            info.Descr,
                            info.DfltTaxID,
                            info.DfltWhID,
                            info.POUnit,
                            info.SOUnit,
                            info.INUnit,
                    info.Crtd_DateTime, info.Crtd_Prog, info.Crtd_User, info.LUpd_DateTime, info.LUpd_Prog, info.LUpd_User });
        }     

        public static int SaveINProductClass2(INProductClass2 info)
        {
            return ConnectDB.ExecuteScalar("sp_INProductClass2Save",
                new String[] { 
                                "VendID",
                                "ClassID1",
                                "ClassID2",
                                "Descr",
                                "DfltTaxID",
                                "DfltWhID",
                                "POUnit",
                                "SOUnit",
                                "INUnit",
                    "Crtd_DateTime", "Crtd_Prog", "Crtd_User", "LUpd_DateTime", "LUpd_Prog", "LUpd_User" },
                new Object[] {
                            info.VendID,
                            info.ClassID1,
                            info.ClassID2,
                            info.Descr,
                            info.DfltTaxID,
                            info.DfltWhID,
                            info.POUnit,
                            info.SOUnit,
                            info.INUnit,
                    info.Crtd_DateTime, info.Crtd_Prog, info.Crtd_User, info.LUpd_DateTime, info.LUpd_Prog, info.LUpd_User });
        }
        
        public static int DeleteINProductClass1(string _strVendID, string _strClassID1)
        {
            return ConnectDB.ExecuteNonQuery("sp_INProductClass1Delete", new String[] { "VendID","ClassID1" }, new Object[] { _strVendID,_strClassID1 });
        }

        public static int DeleteINProductClass2(string _strVendID, string _strClassID1, string _strClassID2)
        {
            return ConnectDB.ExecuteNonQuery("sp_INProductClass2Delete", new String[] { "VendID","ClassID1","ClassID2" }, new Object[] { _strVendID,_strClassID1,_strClassID2 });
        }

    }
}
