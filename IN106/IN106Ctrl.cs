using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PT.Helper;
using PT.DataInfo;
using System.Data;
using System.Data.SqlTypes;

namespace IN106
{
    public class IN106Ctrl
    {
        public static int SaveProduct( INProduct info)
        {
            SqlDateTime strPOPriEffDate;
            if (info.POPriEffDate.ToString() == "1/1/0001 12:00:00 AM")           
                strPOPriEffDate = SqlDateTime.Null;
            else
                strPOPriEffDate = info.POPriEffDate;
            SqlDateTime strSOPriEffDate;
            if (info.SOPriEffDate.ToString() == "1/1/0001 12:00:00 AM")
                strSOPriEffDate = SqlDateTime.Null;
            else
                strSOPriEffDate = info.SOPriEffDate;

            return ConnectDB.ExecuteScalar("sp_ProductSave",
                new String[] { "ProductID" ,"Descr","ClassID2" ,"ClassID1" ,"VendID" ,"Status" ,
                                "FromUnit" ,"ToUnit" ,"Cnvfact" ,"POFromUnitPrice" ,"POToUnitPrice" ,"POPriEffDate" ,
                                "SOFromUnitPrice" ,"SOToUnitPrice" ,"SOPriEffDate" ,"POUnit" ,"SOUnit" ,"INUnit" ,
                                "Color" ,"DfltWhID" ,"Picture" ,"Size" ,"Volume" ,"Weight" ,
                                "Style" ,"TaxID" ,"Crtd_DateTime" ,"Crtd_Prog" ,"Crtd_User" ,
                                "LUpd_DateTime" ,"LUpd_Prog" ,"LUpd_User"},
                new Object[] { info.ProductID, info.Descr, info.ClassID2, info.ClassID1, info.VendID, info.Status, 
                               info.FromUnit, info.ToUnit, info.Cnvfact, info.POFromUnitPrice, info.POToUnitPrice,strPOPriEffDate,
                               info.SOFromUnitPrice,info.SOToUnitPrice,strSOPriEffDate,info.POUnit,info.SOUnit,info.INUnit,
                               info.Color,info.DfltWhID,info.Picture,info.Size,info.Volume,info.Weight,
                               info.Style,info.TaxID,info.Crtd_DateTime,info.Crtd_Prog,info.Crtd_User,
                               info.LUpd_DateTime,info.LUpd_Prog,info.LUpd_User});
        }
        public static int DeleteProduct(string ProductID)
        {
            return ConnectDB.ExecuteNonQuery("sp_ProductDelete", new String[] { "ProductID" }, new Object[] { ProductID });
        }
        public static DataTable GetAllProduct()
        {
            return ConnectDB.GetAll("INProduct");
        }
        public static DataTable GetAll()
        {
            return ConnectDB.GetAll("INUnit");
        }
        public static INProduct GetProduct(string ProductID)
        {
            DataTable dt = new DataTable();
            dt =  ConnectDB.ExecuteReader("sp_ProductGetByProductID", new string[] { "ProductID" }, new object[] { ProductID });
            if (dt.Rows.Count > 0)
                return ConvertToInfo(dt.Rows[0]);
            else
                return null;
        }
        public static DataTable GetINProductClass1()
        {
            return ConnectDB.GetAll("INProductClass1");
        }
        public static DataTable GetINProductClass2()
        {
            return ConnectDB.GetAll("INProductClass2");
        }

        public static DataTable GetINUnit()
        {
            return ConnectDB.GetAll("INUnit");
        }
        public static DataTable GetAPVendor()
        {
            return ConnectDB.GetAll("APVendor");
        }
        public static DataTable GetTax()
        {
            return ConnectDB.GetAll("SITax");
        }
        public static DataTable GetINWarehouse()
        {
            return ConnectDB.GetAll("INWarehouse");
        }
        public static INProduct ConvertToInfo(DataRow dr)
        {
            INProduct _inproduct = new INProduct();
            _inproduct.ProductID = dr["ProductID"].ToString();
            _inproduct.Descr = dr["Descr"].ToString();
            _inproduct.ClassID1 = dr["ClassID1"].ToString();
            _inproduct.ClassID2 = dr["ClassID2"].ToString();
            _inproduct.VendID = dr["VendID"].ToString();
            _inproduct.Status = dr["Status"].ToString();
            _inproduct.FromUnit = dr["FromUnit"].ToString();
            _inproduct.ToUnit = dr["ToUnit"].ToString();
            _inproduct.Cnvfact = float.Parse(dr["Cnvfact"].ToString());
            _inproduct.POFromUnitPrice = float.Parse(dr["POFromUnitPrice"].ToString());
            _inproduct.POToUnitPrice = float.Parse(dr["POToUnitPrice"].ToString());
            if (dr["POPriEffDate"].ToString()!= "")
                _inproduct.POPriEffDate = DateTime.Parse(dr["POPriEffDate"].ToString());

            _inproduct.SOFromUnitPrice = float.Parse(dr["SOFromUnitPrice"].ToString());
            _inproduct.SOToUnitPrice = float.Parse(dr["SOToUnitPrice"].ToString());
            _inproduct.POUnit = dr["POUnit"].ToString();
            _inproduct.SOUnit = dr["SOUnit"].ToString();
            _inproduct.INUnit = dr["INUnit"].ToString();
            _inproduct.Color = dr["Color"].ToString();
            _inproduct.DfltWhID = dr["DfltWhID"].ToString();
            _inproduct.Picture = dr["Picture"].ToString();
            _inproduct.Size = dr["Size"].ToString();
            _inproduct.Volume = float.Parse(dr["Volume"].ToString());
            _inproduct.Weight = float.Parse(dr["Weight"].ToString());
            _inproduct.Style = dr["Style"].ToString();
            _inproduct.TaxID = dr["TaxID"].ToString();
            _inproduct.Crtd_DateTime = DateTime.Parse(dr["Crtd_DateTime"].ToString());
            _inproduct.Crtd_Prog = dr["Crtd_Prog"].ToString();
            _inproduct.Crtd_User = dr["Crtd_User"].ToString();
            return _inproduct;
        }

        public static INProductClass1 Class1toInfo(DataRow dr)
        {
            INProductClass1 info = new INProductClass1();
            info.VendID = dr["VendID"].ToString();
            info.ClassID1 = dr["ClassID1"].ToString();
            info.POUnit = dr["POUnit"].ToString();
            info.SOUnit = dr["SOUnit"].ToString();
            info.DfltTaxID = dr["DfltTaxID"].ToString();
            info.DfltWhID = dr["DfltWhID"].ToString();
            return info;
        }
        public static INProductClass2 Class2toInfo(DataRow dr)
        {
            INProductClass2 info = new INProductClass2();
            info.VendID = dr["VendID"].ToString();
            info.ClassID1 = dr["ClassID1"].ToString();
            info.ClassID2 = dr["ClassID2"].ToString();            
            info.POUnit = dr["POUnit"].ToString();
            info.SOUnit = dr["SOUnit"].ToString();
            info.DfltTaxID = dr["DfltTaxID"].ToString();
            info.DfltWhID = dr["DfltWhID"].ToString();
            return info;
        }
        public static bool CheckProductUsed(string ProductID)
        {
            string _sql = "Select COUNT(*) from INProductStatus  where ProductID = '" + ProductID + "'";
            int _count = ConnectDB.ExecuteScalar(_sql);
            if (_count > 0)
                return true;
            else
                return false;
        }

        

    }
}

