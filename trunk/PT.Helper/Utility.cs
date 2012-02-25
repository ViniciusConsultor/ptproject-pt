using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using System.Data;
using System.Xml.Linq;
using System.IO;
using PT.Helper;
using System.Windows.Forms;
using DevComponents.DotNetBar;


namespace PT.Helper
{
    public class Utility
    {
         //public static String virtualProductPath = "~/images/products/";       
        public static string ChangeLanguage(string _LgID, string _Language)
        {
             DataSet _dataset = new DataSet("Languages");
             DataTable _datatable = new DataTable("Language");

             _datatable.Columns.Add("LgID", typeof(string));
             _datatable.Columns.Add("Language1", typeof(string));
             _datatable.Columns.Add("Language2", typeof(string));
             _datatable.Columns.Add("Language3", typeof(string));

             _dataset.Tables.Add(_datatable);

             _dataset.ReadXml(Globals.PTXMLLanguage, XmlReadMode.IgnoreSchema);

             //DataTable _dt = _datatable;
             string _sql = string.Format("LgID = '{0}'", _LgID);
             DataRow[] _rows = _datatable.Select(_sql);
             if (_rows.Length == 0)
                 return _LgID;
             string _value = (string)_rows[0][_Language];
             if ((_value == "") || (_value == string.Empty) || (_value == null))
                 return _LgID;
             return _value;
        }
        private static string ReadMessage(string msid,string language)
        {

            string str = string.Empty ;
            SA_Message ms = new SA_Message();
            DataSet _dataset = new DataSet("Messages");
            DataTable _datatable = new DataTable("Message");

            _datatable.Columns.Add("MsID", typeof(string));
            _datatable.Columns.Add("Language1", typeof(string));
            _datatable.Columns.Add("Language2", typeof(string));
            _datatable.Columns.Add("Language3", typeof(string));
            _datatable.Columns.Add("Descr", typeof(string));

            _dataset.Tables.Add(_datatable);

            _dataset.ReadXml(Globals.PTXMLMessage, XmlReadMode.IgnoreSchema);

            DataRow[] dr =  _datatable.Select("MsID = '" + msid + "'");
            if (dr.Count() > 0)
                str = dr[0][language].ToString().Trim();

            return str;
        }
        public static DialogResult MessageShow(string msid, string language)
        {
            string str = ReadMessage(msid, language);
            string cap = string.Empty;
            return MessageBoxEx.Show(str,msid);
        }
        public static DialogResult MessageShow(string msid, string language,string value)
        {
            string str = ReadMessage(msid, language);
            return MessageBoxEx.Show(string.Format(str, value), msid, MessageBoxButtons.OKCancel);
        }
        public static DialogResult MessageShow(string msid, string language, string value1, string value2)
        {
            string str = ReadMessage(msid, language);
            return MessageBoxEx.Show(string.Format(str, value1, value2), msid, MessageBoxButtons.YesNo);
        }
        public static int IntParser(string value, int DefaultValue)
        {
            int kq = DefaultValue;
            if (value != null && int.TryParse(value, out kq) == false)
                kq = DefaultValue;

            return kq;
        }
        public static bool IsImage(string filename)
        {
            if (filename.Contains(".jpg") || filename.Contains(".gif") || filename.Contains(".jpeg"))
                return true;
            return false;
        }
        public static string MD5EncodePassword(string originalPassword)
        {
            Byte[] originalBytes;
            Byte[] encodedBytes;
            MD5 md5;

            // Conver the original password to bytes; then create the hash
            md5 = new MD5CryptoServiceProvider();
            originalBytes = Encoding.UTF8.GetBytes(originalPassword);

            encodedBytes = md5.ComputeHash(originalBytes);

            // Bytes to string
            string ret = "";

            foreach (byte a in encodedBytes)
            {
                if (a < 16)
                    ret += "0" + a.ToString("x");
                else
                    ret += a.ToString("x");
            }
            return ret;

        }        
        public static string EscapeQuote(string S)
        {
            if (S == null)
                return "''";

            StringBuilder sb = new StringBuilder("'", S.Length + 2);
            foreach (char c in S)
            {
                switch (c)
                {
                    case '\\':
                        sb.Append("\\\\");
                        break;
                    case '\'':
                        sb.Append("\\'");
                        break;
                    case '\r':
                        sb.Append("\\r");
                        break;
                    case '\n':
                        sb.Append("\\n");
                        break;
                    default:
                        //if (c > '~')
                        //    sb.Append("&#" + Convert.ToInt32(c) + ";");
                        //else
                        sb.Append(c);
                        break;
                }
            }
            sb.Append("'");
            return sb.ToString();
        }
        public static string FormatString(int count, string str)
        {
            if (str != null)
            {
                str = Regex.Replace(str, "<[^>]*>", "", RegexOptions.IgnoreCase | RegexOptions.Singleline);
                if (str.Length > count)
                {
                    str = str.Substring(0, count);
                    if (str.LastIndexOf(" ") > 0)
                        str = str.Substring(0, str.LastIndexOf(" ")) + "...";
                }
            }
            return str;
        }
        //public static Boolean CreateFoler(string name)
        //{
        //    if (System.IO.Directory.Exists(name) == false)
        //        try
        //        {
        //            System.IO.Directory.CreateDirectory(name);
        //            return true;
        //        }
        //        catch (Exception ex)
        //        {
                    
        //           // Log.Logger.Error(ex);
        //            return false;
        //        }
        //    return true;
        //}

        //public static Boolean WriteXML(DataTable datatable,string filePath)
        //{
        //    try
        //    {
        //        if (File.Exists(filePath))
        //            File.Delete(filePath);
        //        datatable.WriteXml(filePath, XmlWriteMode.IgnoreSchema);
        //        return true;
        //    }
        //    catch (Exception ex)
        //    {
        //      //  Log.Logger.Error(ex);
        //        return false;
        //    }    
        //}
        //public static DataTable ReadQuestionFromXML(string path)
        //{
        //    DataTable _datatable = new DataTable("Table");

        //    //_datatable.Columns.Add("Sequence", typeof(int));
        //    //_datatable.Columns.Add("QuestionID", typeof(int));
        //    //_datatable.Columns.Add("QuestionTypeID", typeof(int));
        //    //_datatable.Columns.Add("CourseName", typeof(string));
        //    //_datatable.Columns.Add("Content", typeof(string));
        //    //_datatable.Columns.Add("CorrectAnswer", typeof(string));
        //    //_datatable.Columns.Add("Explaination", typeof(string));
        //    //_datatable.Columns.Add("Answer", typeof(string));
        //    //_datatable.Columns.Add("UserAnswer", typeof(string));
        //    //_datatable.Columns.Add("Mark", typeof(int));

        //    //_dataset.Tables.Add(_datatable);
            

        //    _datatable.ReadXml(path);

        //    return _datatable;
        //}
        //public static void Alert(string message, Page page)
        //{
        //    if (message != string.Empty)
        //        page.ClientScript.RegisterStartupScript(typeof(Page), "AlertScript", "<script type='text/javascript'>alert(" + EscapeQuote(message) + ")</script>");
        //}
    }
}
