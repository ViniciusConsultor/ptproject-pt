using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace PT.Helper
{
    public class Globals
    {
       // public static string PTManagerConnectionString = "Data Source=LTPHUOC-PC\\SQLEXPRESS10;User ID=sa;pwd=123456;Initial Catalog=PT.Manager;";
        public static int PTManagerMenu = 1; //Menu Cha dang duoc mo (su dung trong main)
        public static string PTXMLLanguage = "../../../PT.Manager/Resources/XMLs/Language.manger";
        public static string PTXMLLog = "../../../PT.Manager/Resources/XMLs/Log.manger";
        public static string PTXMLMenu = "../../../PT.Manager/Resources/XMLs/Menu.manger";
        public static string PTXMLConfig = "../../../PT.Manager/Resources/XMLs/Config.manger";
        public static string PTLanguage = "Language1"; //Ngon ngu mac dinh cua chuong trinh (dung de thay doi ngon ngu)
        public static string PTUserName = "Admin"; //Userdang su dung chuong trinh
        public static DateTime PTWorkingDate = DateTime.Now; //Ngay gio hien tai cua he thong, cho phep user thay doi
        public static DateTime PTDateLock = DateTime.Parse("2011/11/11"); //tức là từ thới gian này trở về trước ko dc chỉnh sửa nữa
        public static bool PTUseLot = false; //[3:08:33 PM] Tuấn BK: biến này để cài đặt nó có sử dụng Lot để phân biệt lô hàng hay ko

        public enum OrderStatus 
        {
            Pending = 0,
            Finish = 1,
            Shipping = 2
        }

        // 
        public enum MenuStatus 
        {
            Kho_hanghoa =1,
            Muahang = 2,
            Ketoanphaitra =3,
            Banhang = 4,
            Ketoanphaithu = 5,
            Soquy=6,
            Quantrimenu =7

        }
    }


    public partial class SA_Language
    {
        public string LgID;
        public string Language1;
        public string Language2;
        public string Language3;
    }

    public partial class SA_Menu
    {
        public string ModuleID;
        public string MenuType;
        public string ScreenID;
        public string Descr;
    }
}

