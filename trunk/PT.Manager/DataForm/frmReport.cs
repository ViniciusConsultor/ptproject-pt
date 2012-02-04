using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using PT.Manager.DataForm;
using PT.DataInfo;
using CrystalDecisions.Shared;
using PT.MainCtl;

namespace PT.Manager.DataForm
{
    public partial class frmReport : Form
    {
        public frmReport()
        {
            InitializeComponent();
            DataTable dt = PT.Helper.ConnectDB.ExecuteReader("pp_GetVendor");
            txtString1.DataSource = dt;
            DataTable dt2 = PT.Helper.ConnectDB.ExecuteReader("pp_GetInUnit");
            txtString2.DataSource = dt2;
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private string _strScreenID;
        private string _strUserID;
        private int _intRPID = 0;
        private string _strReportName;
        private string _strReportCap;
        private string _ClientName;

        private void frmReport_Load(object sender, EventArgs e)
        {
            
            _strScreenID = "IN401";
            _strUserID = "ADMIN";
            //frmReport frm = new frmReport();
            //this.Text = "Danh Mục Sản Phẩm";

            //Lay danh sach bao cao cua man hinh
            DataTable dt = new DataTable();
            dt = RPSetupCtrl.GetBy_ScreenID(_strScreenID);
            cmbReportList.DataSource = dt;
            cmbReportList.DisplayMember = "ReportCap";
            cmbReportList.ValueMember = "RPID";
            cmbReportList.Refresh();
            _ClientName = Environment.MachineName.ToString();
            dtmDate1.Value = DateTime.Today;
            dtmDate2.Value = DateTime.Today;
            dtmDate3.Value = DateTime.Today;

        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            #region Insert bang RPTRun
            RPRun _info = new RPRun();
            _info.RPID = Int32.Parse(cmbReportList.SelectedValue.ToString());
            _info.ScreenID = _strScreenID;
            _info.ClientName = _ClientName;
            _info.ReportName = _strReportName;
            _info.ReportCap = _strReportCap;
            _info.String1 = txtString1.Text;
            _info.String2 = txtString2.Text;
            _info.String3 = txtString3.Text;
            _info.Date1 = dtmDate1.Value;
            _info.Date2 = dtmDate1.Value;
            _info.Date3 = dtmDate1.Value;
            _info.Bool1 = chkBool1.Checked;
            _info.Bool2 = chkBool2.Checked;
            _info.Bool3 = chkBool3.Checked;
            _info.UserID = _strUserID;
            _info.AppPath = "";

            int kq = RPRunCtrl.InsertRPRun(_info);

            #endregion

            ReportDocument cryRpt = new ReportDocument();
            string _strReportLink = @"D:\ASP.NET\TaiLieu\PT.Manager\PT.Reports\" + _strReportName + ".rpt";
            //_strReportName = Application.StartupPath.ToString() + @"\Reports\" + _strReportName + ".rpt";
            cryRpt.Load(_strReportLink);
            cryRpt.SetParameterValue("@RPID", _intRPID);
            crystalReportViewer1.ReportSource = cryRpt;
            crystalReportViewer1.Refresh();
        }

        private void cmbReportList_SelectedValueChanged(object sender, EventArgs e)
        {
            RPRunCtrl.DeleteRPRun(_intRPID);
            txtString1.Text = null;
            txtString2.Text = null;
            txtString3.Text = null;
            chkBool1.Checked = false;
            chkBool2.Checked = false;
            chkBool3.Checked = false;
            string a = cmbReportList.SelectedValue.ToString();
            if (a == "System.Data.DataRowView")
                a = "";
            else
            {


                _intRPID = Int32.Parse(cmbReportList.SelectedValue.ToString());
                RPSetup _info = RPSetupCtrl.GetBy_RPID(_intRPID);
                // get report nam
                _strReportName = _info.ReportName;
                //Set status cho cac cotrol tham so bao cao khi chon bao cao
                if (_info != null)
                {
                    string _str1 = _info.String1;
                    string _str2 = _info.String2;
                    string _str3 = _info.String3;
                    string _bool1 = _info.Bool1;
                    string _bool2 = _info.Bool2;
                    string _bool3 = _info.Bool3;
                    string _date1 = _info.Date1;
                    string _date2 = _info.Date2;
                    string _date3 = _info.Date3;
                    string _list = _info.List;
                    _strReportCap = _info.ReportCap;
                    _strReportName = _info.ReportName;

                    #region Chuỗi
                    if (_str1 != "")
                    {
                        txtString1.Enabled = true;
                        lblString1.Text = _str1;
                    }
                    else
                    {
                        txtString1.Enabled = false;
                        lblString1.Text = null;
                    }
                    if (_str2 != "")
                    {
                        txtString2.Enabled = true;
                        lblString2.Text = _str2;
                    }
                    else
                    {
                        txtString2.Enabled = false;
                        lblString2.Text = null;
                    }
                    if (_str3 != "")
                    {
                        txtString3.Enabled = true;
                        lblString3.Text = _str3;
                    }
                    else
                    {
                        txtString3.Enabled = false;
                        lblString3.Text = null;
                    }
                    #endregion
                    #region Ngày
                    if (_date1 != "")
                    {
                        dtmDate1.Enabled = true;
                        lblDate1.Text = _date1;
                    }
                    else
                    {
                        dtmDate1.Enabled = false;
                        lblDate1.Text = null;
                    }
                    if (_date2 != "")
                    {
                        dtmDate2.Enabled = true;
                        lblDate2.Text = _date2;
                    }
                    else
                    {
                        dtmDate2.Enabled = false;
                        lblDate2.Text = null;
                    }
                    if (_date3 != "")
                    {
                        dtmDate3.Enabled = true;
                        lblDate3.Text = _date3;
                    }
                    else
                    {
                        dtmDate3.Enabled = false;
                        lblDate3.Text = null;
                    }
                    #endregion
                    #region Check
                    if (_bool1 != "")
                    {
                        chkBool1.Enabled = true;
                        chkBool1.Text = _bool1;
                    }
                    else
                    {
                        chkBool1.Enabled = false;
                        chkBool1.Text = null;
                    }
                    if (_bool2 != "")
                    {
                        chkBool2.Enabled = true;
                        chkBool2.Text = _bool2;
                    }
                    else
                    {
                        chkBool2.Enabled = false;
                        chkBool2.Text = null;
                    }

                    if (_bool3 != "")
                    {
                        chkBool3.Enabled = true;
                        chkBool3.Text = _bool3;
                    }
                    else
                    {
                        chkBool3.Enabled = false;
                        chkBool3.Text = null;
                    }

                    #endregion

                    if (_list != "")
                    {
                        //grpFilter.Enabled = true;
                        lblList.Text = _list;
                        if (this.Height + 260 < 520)
                            this.Height = this.Height + 260;
                    }
                    else
                    {
                        //grpFilter.Enabled = false;
                        lblList.Text = "";
                        //grpFilter.Enabled = false;
                        if (this.Height - 260 > 0)
                            this.Height = this.Height - 260;
                    }

                }
            }
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            if (pnlFilter.Visible == true)
            {
                btnBack.Text = "Hiện Điều Kiện Lọc";
                pnlFilter.Visible = false;
            }
            else
            {
                btnBack.Text = "Hiện Toàn Màn Hình";
                pnlFilter.Visible = true;
            }
        }

        private void crystalReportViewer1_ReportRefresh(object source, CrystalDecisions.Windows.Forms.ViewerEventArgs e)
        {
            e.Handled = true;
            crystalReportViewer1.Refresh();
        }

        private void frmReport_FormClosing(object sender, FormClosingEventArgs e)
        {
            RPRunCtrl.DeleteRPRun(_intRPID);
        }

        private void txtString2_TextChanged(object sender, EventArgs e)
        {

        }




    }
}
