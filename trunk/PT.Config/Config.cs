using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using System.Collections;
using System.Data.SqlClient;

namespace PT.Config
{
    public partial class Config : DevComponents.DotNetBar.Office2007Form
    {
       // SQLInformation sql = new SQLInformation();
        string _servername = "";
        string _username = "";
        string _password = "";
        string _database = "";
        public Config()
        {
            InitializeComponent();
        }

        private void PTConfig_Load(object sender, EventArgs e)
        {
            tbxServername.Text = "";
            btnConnect.Enabled = false;
        }
        public static List<string> GetDatabaseNames(string servername)
        {
            string connString = null;
            List<string> databaseNames = new List<string>();
           
            // Be sure to replace this with your connection string.
            connString = "Data Source=" + servername + ";Integrated Security=True";

            if (!string.IsNullOrEmpty(connString))
                
            {
                using (SqlConnection cn = new SqlConnection(connString))
                {
                    // Open the connection
                    try
                    {
                        cn.Open();
                    }
                    //catch (Exception ex)
                    //{
                    //    //MessageBox.Show("Login fail for user '" + username + "'", "Connect to server");
                    //    MessageBox.Show(ex.ToString());
                    //}
                    //System.InvalidOperationException
                    catch (System.InvalidOperationException ex)
                    {
                        string str;
                        str = "Source:" + ex.Source;
                        str += "\n" + "Message:" + ex.Message;
                        str += "\n" + "\n";
                        str += "\n" + "Stack Trace :" + ex.StackTrace;
                        MessageBox.Show(str, "Specific Exception");
                    }
                    catch (System.Data.SqlClient.SqlException ex)
                    {
                        string str;
                        str = "Source:" + ex.Source;
                        str += "\n" + "Message:" + ex.Message;
                        MessageBox.Show(str, "Database Exception");
                    }
                    catch (System.Exception ex)
                    {
                        string str;
                        str = "Source:" + ex.Source;
                        str += "\n" + "Message:" + ex.Message;
                        MessageBox.Show(str, "Generic Exception");
                    }
                    //finally
                    //{
                    //    if (cn.State == ConnectionState.Open)
                    //    //{
                    //    //    DataTable _datatable = new DataTable("Config");

                    //    //    _datatable.Columns.Add("Server", typeof(string));
                    //    //    _datatable.Columns.Add("Database", typeof(string));
                    //    //    _datatable.Columns.Add("Username", typeof(string));
                    //    //    _datatable.Columns.Add("Password", typeof(string));
                    //    //   // _datatable.Rows.Add(new DataRow("","","",""));
                    //    //    DataRow dr = _datatable.NewRow();
                    //    //    dr[0] = servername;
                    //    //    dr[1] = databaseNames;
                    //    //    dr[2] = 
                    //    //    PT.DB.ConfigCtrl.WriteXML(_datatable);
                    //        //cn.Close();t
                    //    }
                    //}

                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = cn;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "sp_databases";

                        using (SqlDataReader myReader = cmd.ExecuteReader())
                        {
                            while ((myReader.Read()))
                            {
                                databaseNames.Add(myReader.GetString(0));
                            }
                        }
                        cn.Close();
                    }

                }
            } 
            return databaseNames;
        }
        public static List<string> GetDatabaseNames(string servername,string username, string password)
        {
            string connString = null;
            List<string> databaseNames = new List<string>();

            // Be sure to replace this with your connection string.
            connString = "Data Source=" + servername + ";User ID=" + username + ";pwd=" + password + ";";

            if (!string.IsNullOrEmpty(connString))
            {
                using (SqlConnection cn = new SqlConnection(connString))
                {
                    // Open the connection
                    try
                    {
                        cn.Open();
                    }
                    catch (System.InvalidOperationException ex)
                    {
                        string str;
                        str = "Source:" + ex.Source;
                        str += "\n" + "Message:" + ex.Message;
                        str += "\n" + "\n";
                        str += "\n" + "Stack Trace :" + ex.StackTrace;
                        MessageBox.Show(str, "Specific Exception");
                    }
                    catch (System.Data.SqlClient.SqlException ex)
                    {
                        string str;
                        str = "Source:" + ex.Source;
                        str += "\n" + "Message:" + ex.Message;
                        MessageBox.Show(str,"Database Exception");
                    }
                    catch (System.Exception ex)
                    {
                        string str;
                        str = "Source:" + ex.Source;
                        str += "\n" + "Message:" + ex.Message;
                        MessageBox.Show(str, "Generic Exception");
                    }
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = cn;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "sp_databases";

                        using (SqlDataReader myReader = cmd.ExecuteReader())
                        {
                            while ((myReader.Read()))
                            {
                                databaseNames.Add(myReader.GetString(0));
                            }
                        }
                    }

                }
            }
            return databaseNames;
        }
        

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            _servername = tbxServername.Text.ToString().Trim();
            _username = tbxUsername.Text.ToString().Trim();
            _password = tbxPassword.Text.ToString().Trim();
            if (_servername == null || _servername == string.Empty || _servername == "")
            {
                MessageBox.Show( "Server Name Property not set","Login Fail");
                return;
            }            
            else
            {
                if (_username == null || _username == string.Empty || _username == "")
                {
                    MessageBox.Show("Login Property not set", "Login Fail");
                    return;
                }
                cbxDatabase.DataSource = GetDatabaseNames(_servername,_username,_password);
            }

        }

        private void tbxServername_TextChanged(object sender, EventArgs e)
        {
            if (tbxServername.Text != null || tbxServername.Text != string.Empty || tbxServername.Text != "")
                btnConnect.Enabled = true;
        }

        private void btnSaveSystemConfig_Click(object sender, EventArgs e)
        {
            //string _servername = tbxServername.Text.ToString().Trim();
            //string _username = tbxUsername.Text.ToString().Trim();
            //string _password = tbxPassword.Text.ToString().Trim();


            string _database = cbxDatabase.SelectedItem.ToString();
            if (_database == null || _database == string.Empty || _database == "")
            {
                MessageBox.Show("Chưa chọn Cơ sở dữ liệu", "Cấu hình hệ thống");
                return;
            }
            if (ConfigCtrl.WriteXML(_servername, _database, _username, _password))
            {
                MessageBox.Show("Lưu thông tin hệ thống thành công", "Cấu hình hệ thống");
            }
        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}