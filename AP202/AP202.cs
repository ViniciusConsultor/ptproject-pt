using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PT.Helper;
using PT.Component;
using PT.DataInfo;
using PT.Master;
using System.Globalization;
using DevComponents.DotNetBar;


namespace AP202
{
    public partial class AP202 : PT.Master.GridEditIn
    {
        private DataTable _dtAPAdjust = new DataTable();
        private APAdjust _infoAPAdjust = new APAdjust();
        private DataTable _dtAPAdjustDet = new DataTable();
        private APAdjustDet _infoAPAdjustDet = new APAdjustDet();
        private string _strPro = "AP202";
        private string _strUser = PT.Helper.Globals.PTUserName;
        private DataTable _dtAPDoc, _dtAPDocTmp = new DataTable();
        private DataTable _dtSAUser = new DataTable();
        private DataTable _dtSIBranch = new DataTable();
        private DataTable _dtVend = new DataTable();
        private DataTable _dtCAAccount = new DataTable();
        private DataTable _dtPONbr = new DataTable();
        private string _strFistChar = "CC", _strLastNbr;

        public AP202()
        {
            InitializeComponent();
        }

        private void AP202_Load(object sender, EventArgs e)
        {
            
            _LoadData();
            _BindCtrl();
            dtmFromDate.Value = DateTime.Now.Date;
            dtmToDate.Value = DateTime.Now.Date;
            _BindGrid();

        }
        private void _BindGrid()
        {
            string strUser = cmbUser.SelectedValue.ToString().Trim();
            DateTime strFromDate = dtmFromDate.Value;
            DateTime strToDate = dtmToDate.Value;
            string strAdjNbrFind = txtAdjNbrFind.Text.ToString().Trim();            
            _dtAPAdjust = AP202Ctrl.FindAPADjust(_strPro, strUser, strAdjNbrFind, strFromDate, strToDate);
            dgv.DataSource = _dtAPAdjust;

        }
        private void _RefreshPanelInput()
        {
            if (txtAdjNbr.Text.ToString().Trim() != "")
            {
                cmbBranchID.SelectedValue = _infoAPAdjust.BranchID;
                cmbStatus.SelectedValue = _infoAPAdjust.Rlsed;
                txtAdjNbr.Text = _infoAPAdjust.AdjNbr;
                cmbAdjAcct.SelectedValue = _infoAPAdjust.AdjAcct;
                dtmAdjDate.Value = _infoAPAdjust.AdjDate;
                txtAdjAmt.Text = _infoAPAdjust.AdjAmt.ToString();
                txtAdjDescr.Text = _infoAPAdjust.AdjDesc;                
            }
            else
            {
                _BindCtrl();
                txtAdjNbr.Text = "";             
                dtmAdjDate.Value = DateTime.Now;
                txtAdjAmt.Text = "";
                txtAdjDescr.Text = "";
                dtmFromDateLoad.Value = DateTime.Now;
                dtmToDateLoad.Value = DateTime.Now;                   
                dgvDocList.DataSource = null;
            }
            _SetButtomStatus();

        }
        private void _ResetPanelInput()
        {
            _BindCtrl();
            txtAdjNbr.Text = "";
            dtmAdjDate.Value = DateTime.Now;
            txtAdjAmt.Text = "";
            txtAdjDescr.Text = "";
            dtmFromDateLoad.Value = DateTime.Now;
            dtmToDateLoad.Value = DateTime.Now;
            dgvDocList.DataSource = null;
            dtmFromDateLoad.Enabled = true;
            dtmToDateLoad.Enabled = true;
            txtVendIDLoad.Enabled = true;
            dgvDocList.Controls.Clear();
            pnldgv.Enabled = true;

        }
        private void _BindPanel(APAdjust info)
        {
            cmbBranchID.SelectedValue = info.BranchID;
            cmbStatus.SelectedValue = info.Rlsed;
            txtAdjNbr.Text = info.AdjNbr;
            cmbAdjAcct.SelectedValue = info.AdjAcct;
            dtmAdjDate.Value = info.AdjDate;
            txtAdjAmt.Text = info.AdjAmt.ToString();
            txtAdjDescr.Text = info.AdjDesc; 
        }
        private void _BindGridPanel(string brandid,string AdjNbr,DateTime fromdate,
                                    int Release, DateTime todate, string vendid)
        {            
            _dtAPDoc = AP202Ctrl.LoadAPADjDet(brandid, AdjNbr, vendid, Release, fromdate, todate);
            _dtAPDocTmp = _dtAPDoc.Copy();
            dgvDocList.DataSource = _dtAPDoc;

            //==================
            if ((dgvDocList.Columns[0].Name == "chk") && (dgvDocList.Rows.Count > 0))
            {
                //DataGridViewCheckBoxColumn checkboxColumn = new DataGridViewCheckBoxColumn();
                //checkboxColumn.Width = 30;
                //checkboxColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                //dgvDocList.Columns.Insert(0, checkboxColumn);
                dgvDocList.Columns[0].HeaderText = "";
                dgvDocList.Columns[0].Width = 18;
                // add checkbox header            
                Rectangle rect = dgvDocList.GetCellDisplayRectangle(0, -1, true);
                // set checkbox header to center of header cell. +1 pixel to position correctly.
                rect.X = rect.Location.X + (rect.Width / 4) - 2;
                rect.Y = rect.Y + 5;

                CheckBox checkboxHeader = new CheckBox();
                checkboxHeader.Name = "checkboxHeader";
                checkboxHeader.Size = new Size(13, 13);
                checkboxHeader.Location = rect.Location;
                //checkboxHeader.CheckedChanged += new EventHandler(checkboxHeader_CheckedChanged);
                checkboxHeader.Click += new EventHandler(checkboxHeader_Click);
                dgvDocList.Controls.Add(checkboxHeader);
                for (int i = 0; i < dgvDocList.Columns.Count; i++)
                {
                    dgvDocList.Columns[i].ReadOnly = true;
                }
                dgvDocList.Columns["Payment"].ReadOnly = false;
                dgvDocList.Columns[0].ReadOnly = false;

                bool kq = true;
                for (int i = 0; i < dgvDocList.RowCount; i++)
                {
                    if (dgvDocList.Rows[i].Cells["Docbal"].Value.ToString() == "0")
                        dgvDocList[0, i].Value = true;
                    else
                    {
                        dgvDocList[0, i].Value = false;
                        kq = false;
                    }

                }
                if (kq == true)
                    ((CheckBox)dgvDocList.Controls.Find("checkboxHeader", true)[0]).Checked = true;
                dgvDocList.EndEdit();
            }

            //==================

            //for (int i = 0; i < dgvDocList.Columns.Count; i++)
            //    dgvDocList.Columns[i].ReadOnly = true;
            //dgvDocList.Columns["Payment"].ReadOnly = false;
            //dgvDocList.Columns[0].ReadOnly = false;
            //==================
            
        }

       
        private void _BindCtrl()
        {
            cmbUser.DataSource = _dtSAUser;
            cmbUser.DisplayMember = "UserID";
            cmbUser.ValueMember = "UserID";
            cmbUser.ColumnNames = "UserID";
            cmbUser.ColumnWidths = "100";
            cmbUser.SelectedValue = "ALL";
            cmbUser.LinkedColumnIndex = 1;

            cmbBranchID.DataSource = _dtSIBranch;
            cmbBranchID.DisplayMember = "BranchID";
            cmbBranchID.ValueMember = "BranchID";
            cmbBranchID.ColumnNames = "BranchID,BranchName";
            cmbBranchID.ColumnWidths = "100,200";
            cmbBranchID.LinkedColumnIndex = 1;

            cmbAdjAcct.DataSource = _dtCAAccount;
            cmbAdjAcct.DisplayMember = "Acct";
            cmbAdjAcct.ValueMember = "Acct";
            cmbAdjAcct.ColumnNames = "Acct,AcctName";
            cmbAdjAcct.ColumnWidths = "100,150";

            DataTable dtStatus = new DataTable();
            dtStatus.Columns.Add("Rlease", typeof(int));
            dtStatus.Columns.Add("Descr", typeof(string));
            dtStatus.Rows.Add(-1, "Đã Hủy");
            dtStatus.Rows.Add(0, "Đang Treo");
            dtStatus.Rows.Add(1, "Đã Cập Nhật");
            cmbStatus.DataSource = dtStatus;
            cmbStatus.DisplayMember = "Descr";
            cmbStatus.ValueMember = "Rlease";
            cmbStatus.SelectedValue = 0;   
            //cmbStatus.ColumnNames = "Descr";
            //cmbStatus.ColumnWidths = "95";
            //cmbStatus.LinkedColumnIndex = 1;
           
            txtVendIDLoad.DataSource = _dtVend;
            txtVendIDLoad.ColumnWidths = "100,250";

        }
        private void _LoadData()
        {
            _dtCAAccount = AP202Ctrl.GetCAAccount();
            _dtSAUser = AP202Ctrl.GetSAUser();
            _dtSIBranch = AP202Ctrl.GetSIBranch();
            _dtVend = AP202Ctrl.GetVendID();
        }
        private APAdjust _GetPanel(int intRelease)
        {
            _infoAPAdjust.BranchID = cmbBranchID.SelectedValue.ToString().Trim();
            _infoAPAdjust.AdjNbr = txtAdjNbr.Text.ToString().Trim();
            _infoAPAdjust.AdjDate = dtmAdjDate.Value.Date;
            _infoAPAdjust.AdjDesc = txtAdjDescr.Text.ToString().Trim();
            _infoAPAdjust.AdjAcct = cmbAdjAcct.SelectedValue.ToString().Trim();
            _infoAPAdjust.AdjAmt = double.Parse(txtAdjAmt.Text.ToString().Trim());
            _infoAPAdjust.Rlsed = intRelease;
            _infoAPAdjust.FromDateTmp = dtmFromDateLoad.Value.Date;
            _infoAPAdjust.ToDateTmp = dtmToDateLoad.Value.Date;
            _infoAPAdjust.VendIDTmp = txtVendIDLoad.Text.ToString().Trim();
            _infoAPAdjust.Note = "";
            _infoAPAdjust.Crtd_DateTime = DateTime.Now;
            _infoAPAdjust.Crtd_Prog = _strPro;
            _infoAPAdjust.Crtd_User = _strUser;
            _infoAPAdjust.LUpd_DateTime = DateTime.Now;
            _infoAPAdjust.LUpd_Prog = _strPro;
            _infoAPAdjust.LUpd_User = _strUser;
            if (_infoAPAdjust.Version == null)
                _infoAPAdjust.Version = "";
            return _infoAPAdjust;
        }        
        private bool _CheckValid()
        {            
            if (cmbBranchID.SelectedValue.ToString() == "")
            {
                MessageBox.Show("Vui long nhap du lieu", "Thong bao");
                cmbBranchID.Focus();
                return false;
            }
            if (txtAdjAmt.Text.ToString() == "0")
            {
                MessageBox.Show("Vui long nhap du lieu", "Thong bao");
                dgvDocList.Focus();
                return false;
            }
            return true;
        }
        private int _SaveAPAdjust(int release)
        {
            _infoAPAdjust.Rlsed = release;
            return AP202Ctrl.SaveAPAdjust(_infoAPAdjust);

        }
        private int _SaveAPAdjustDet()
        {
            string strBrandID = cmbBranchID.SelectedValue.ToString().Trim();
            string strAdjNbr = txtAdjNbr.Text.ToString().Trim();                        
            DateTime dteAdjDate = dtmAdjDate.Value.Date;
            string strAdjAcct = cmbAdjAcct.SelectedValue.ToString().Trim();
            double dbeAdjAmt = double.Parse(txtAdjAmt.Text.ToString().Trim());
            //DataTable list = new DataTable();
            //list = AP202Ctrl.FindAPADjustDet("");
            if (dgvDocList.DataSource == _dtAPDoc)
            {                
                foreach (DataRow rows in _dtAPDoc.Rows)
                {
                    if (double.Parse(rows["Payment"].ToString().Trim() ) != 0)
                    {
                        APAdjustDet info = new APAdjustDet();
                        info.BranchID = strBrandID;
                        info.AdjNbr = strAdjNbr;
                        info.LineRef = "none";
                        info.VendID = rows["VendID"].ToString().Trim();
                        info.AdjDate = dteAdjDate;
                        info.AdjAcct = strAdjAcct;
                        info.AdjAmt = double.Parse(rows["Payment"].ToString().Trim());
                        info.NDocNbr = rows["DocNbr"].ToString().Trim();
                        info.NDocType = rows["DocType"].ToString().Trim();
                        info.NDocDate = DateTime.Parse(rows["DocDate"].ToString().Trim()).Date;
                        info.ADocNbr = "";
                        info.ADocType = "";
                        info.ADocDate = DateTime.Parse(rows["DocDate"].ToString().Trim()).Date; ;
                        info.Rlsed = 0;
                        info.Crtd_DateTime = DateTime.Now;
                        info.Crtd_Prog = _strPro;
                        info.Crtd_User = _strUser;
                        info.LUpd_DateTime = DateTime.Now;
                        info.LUpd_Prog = _strPro;
                        info.LUpd_User = _strUser;
                        info.Version = "";                        
                        AP202Ctrl.SaveAPAdjustDet(info);
                    }
                }
            }
            else if (dgvDocList.DataSource == _dtAPAdjustDet)
            {
                foreach (DataRow rows in _dtAPAdjustDet.Rows)
                {                   
                        APAdjustDet info = new APAdjustDet();
                        info.BranchID = strBrandID;
                        info.AdjNbr = strAdjAcct;
                        info.LineRef = rows["LineRef"].ToString().Trim();// intLineRef.ToString("00000");
                        info.VendID = rows["VendID"].ToString().Trim();
                        info.AdjDate = dteAdjDate;
                        info.AdjAcct = strAdjAcct;
                        info.AdjAmt = dbeAdjAmt;
                        info.NDocNbr = rows["NDocNbr"].ToString().Trim();
                        info.NDocType = rows["NDocType"].ToString().Trim();
                        info.NDocDate = DateTime.Parse(rows["NDocDate"].ToString().Trim()).Date;
                        info.ADocNbr = "";
                        info.ADocType = "";
                        //info.ADocDate = null;
                        info.Rlsed = 0;
                        info.Crtd_DateTime = DateTime.Now;
                        info.Crtd_Prog = _strPro;
                        info.Crtd_User = _strUser;
                        info.LUpd_DateTime = DateTime.Now;
                        info.LUpd_Prog = _strPro;
                        info.LUpd_User = _strUser;
                        info.Version = "";
                        AP202Ctrl.SaveAPAdjust(_infoAPAdjust);
                    
                }
            }
            return 1;

        }
        private void _SaveSASetup(string strModule, string strFistChar, string strLastNbr)
        {
            SASetup _sa = new SASetup();
            _sa.Module = strModule;
            _sa.FistChar = strFistChar;
            _sa.LastNbr = strLastNbr;
            int kq;
            if (_sa.Module != "" && _sa.FistChar != "")
                kq = AP202Ctrl.SaveSASetup(_sa);
        }
        private void _SetButtomStatus()
        {
            if (txtAdjNbr.Text.ToString().Trim() == "")
            {
                btnRelease.Enabled = false;
                btnDestroy.Enabled = false;
                btnCanAndCopy.Enabled = false;
                btnDelete.Enabled = false;
                btnSave.Enabled = true;
                btnBack.Enabled = true;
                foreach (Control c in pnl.Controls) //assuming this is a Form
                {
                    string name = c.Name.Substring(0, 5);
                    if (((name != "label") || (name == "btn")) && (name != "pnl"))
                        c.Enabled = true;
                }
            }
            if (pnl.Visible == true)
                btnBack.Enabled = true;
            if (cmbStatus.SelectedValue == null)
            {
                btnRelease.Enabled = true;
                btnDestroy.Enabled = false;
                btnCanAndCopy.Enabled = false;
                btnDelete.Enabled = true;
                btnBack.Enabled = true;
                foreach (Control c in pnl.Controls) //assuming this is a Form
                {
                    string name = c.Name.Substring(0, 5);
                    if (((name != "label") || (name == "btn")) && (name != "pnl"))
                        c.Enabled = true;
                }
            }
            if ((cmbStatus.SelectedValue.ToString() == "0") && (txtAdjNbr.Text.ToString().Trim() != ""))
            {
                btnSave.Enabled = true;
                btnRelease.Enabled = true;
                btnDestroy.Enabled = false;
                btnBack.Enabled = true;
                btnCanAndCopy.Enabled = false;
                btnDelete.Enabled = true;
                foreach (Control c in pnl.Controls) //assuming this is a Form
                {
                    string name = c.Name.Substring(0, 5);
                    if (((name != "label") || (name == "btn")) && (name != "pnl"))
                        c.Enabled = true;
                }
            }
            else if (cmbStatus.SelectedValue.ToString() == "1")
            {
                btnRelease.Enabled = false;
                btnDestroy.Enabled = true;
                btnCanAndCopy.Enabled = true;
                btnDelete.Enabled = false;
                btnBack.Enabled = true;
                foreach (Control c in pnl.Controls) //assuming this is a Form
                {
                    string name = c.Name.Substring(0, 5);
                    if (((name != "label") || (name == "btn")) && (name != "pnl"))
                        c.Enabled = false;
                }
            }
            else if (cmbStatus.SelectedValue.ToString() == "-1")
            {
                btnRelease.Enabled = false;
                btnDestroy.Enabled = false;
                btnCanAndCopy.Enabled = false;
                btnDelete.Enabled = false;
                btnBack.Enabled = true;
                foreach (Control c in pnl.Controls) //assuming this is a Form
                {
                    string name = c.Name.Substring(0, 5);
                    if (((name != "label") || (name == "btn")) && (name != "pnl"))
                        c.Enabled = false;
                }
            }
        }
        private void _FilterGrid()
        {
            string sql = string.Format("PONbr like '%{0}%' AND InvcNbr like '%{1}%'", txtPoNbr.Text.ToString().Trim(), txtInvcNbr.Text.ToString().Trim());
            _dtAPDoc.DefaultView.RowFilter = sql;
            ((CheckBox)dgvDocList.Controls.Find("checkboxHeader", true)[0]).Checked = false;
            int count = 0;
            for (int i = 0; i < dgvDocList.RowCount; i++)
            {
                if (double.Parse(dgvDocList.Rows[i].Cells["Docbal"].Value.ToString()) == 0)
                {
                    dgvDocList.Rows[i].Cells[0].Value = true;
                    count++;
                }
            }
            if (count == dgvDocList.RowCount)
                ((CheckBox)dgvDocList.Controls.Find("checkboxHeader", true)[0]).Checked = true;
            
        }
        private void _ComputeAmt()
        {
            //double totalAmt= 0;
            double totalPayment = 0;
            if (dgvDocList.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvDocList.Rows)
                {
                    //totalAmt += double.Parse(row.Cells["DocBal"].Value.ToString());
                    totalPayment += double.Parse(row.Cells["Payment"].Value.ToString());
                }
                txtAdjAmt.Text = totalPayment.ToString();
            }
        }
        private double[] _GetValue(string id)
        {
            double[] db = new double[2];
            string sql = string.Format("DocNbr = '{0}'", id);
            db[0] = double.Parse(_dtAPDocTmp.Select(sql)[0]["Payment"].ToString());
            db[1] = double.Parse(_dtAPDocTmp.Select(sql)[0]["DocBal"].ToString());
            return db;
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            _BindGrid();
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if (pnldgv.Visible == true)
                _BindGrid();
            else if (pnl.Visible == true)
            {
                _RefreshPanelInput();
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            _ResetPanelInput();
        }
        private void btnLoad_Click(object sender, EventArgs e)
        {
            DateTime fromdate = dtmFromDateLoad.Value;
            DateTime todate = dtmToDateLoad.Value;
            string vendid = txtVendIDLoad.Text.ToString().Trim();
            string brandid = cmbBranchID.SelectedValue.ToString().Trim();
            string adjnbr = txtAdjNbr.Text.ToString().Trim();
            int release = Int32.Parse(cmbStatus.SelectedValue.ToString().Trim());

            _BindGridPanel(brandid, adjnbr, fromdate,release, todate, vendid);
            

           
            _SetButtomStatus();
        }
        private void checkboxHeader_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvDocList.RowCount; i++)
            {
                dgvDocList[0, i].Value = ((CheckBox)dgvDocList.Controls.Find("checkboxHeader", true)[0]).Checked;

                object d = ((CheckBox)dgvDocList.Controls.Find("checkboxHeader", true)[0]).Checked;
                //if (double.Parse(dgvDocList.Rows[i].Cells["Docbal"].Value.ToString()) != 0)
                //{
                //    if ((bool)dgvDocList.Rows[i].Cells[0].FormattedValue)
                //    {
                //        dgvDocList.Rows[i].Cells["Payment"].Value = _dtAPDocTmp.Rows[i]["Docbal"].ToString();
                //        dgvDocList.Rows[i].Cells["Docbal"].Value = 0;
                //    }
                //    else
                //    {
                //        dgvDocList.Rows[i].Cells["Payment"].Value = 0;
                //        dgvDocList.Rows[i].Cells["Docbal"].Value = _dtAPDocTmp.Rows[i]["Docbal"].ToString();
                //    }
                //}
                //dgvDocList.EndEdit();
            }            
        }
        private void checkboxHeader_Click(object sender, EventArgs e)
        {
            dgvDocList.EndEdit();
            for (int i = 0; i < dgvDocList.RowCount; i++)
            {
                double payment = _GetValue(dgvDocList.Rows[i].Cells["DocNbr"].Value.ToString())[0];
                double docbal = _GetValue(dgvDocList.Rows[i].Cells["DocNbr"].Value.ToString())[1];
                dgvDocList[0, i].Value = ((CheckBox)dgvDocList.Controls.Find("checkboxHeader", true)[0]).Checked;
                //object d = ((CheckBox)dgvDocList.Controls.Find("checkboxHeader", true)[0]).Checked;
                //if (double.Parse(dgvDocList.Rows[i].Cells["Docbal"].Value.ToString()) != 0)
                //{
                if ((bool)dgvDocList.Rows[i].Cells[0].FormattedValue)
                {
                    if (double.Parse(dgvDocList.Rows[i].Cells["Docbal"].Value.ToString()) != 0)
                    {
                        dgvDocList.Rows[i].Cells["Payment"].Value = payment+docbal;
                        dgvDocList.Rows[i].Cells["Docbal"].Value = 0;
                    }
                }
                else
                {
                    dgvDocList.Rows[i].Cells["Docbal"].Value = payment + docbal;
                    dgvDocList.Rows[i].Cells["Payment"].Value = 0;
                    //if (_dtAPDocTmp.Rows[dgvDocList.Rows[i].Index]["Docbal"].ToString() != "0")
                    //{
                    //    dgvDocList.Rows[i].Cells["Payment"].Value = 0;
                    //    dgvDocList.Rows[i].Cells["Docbal"].Value = _dtAPDocTmp.Rows[dgvDocList.Rows[i].Index]["Docbal"].ToString();
                    //    ((CheckBox)dgvDocList.Controls.Find("checkboxHeader", true)[0]).Checked = false;
                    //}
                    //else
                    //{
                    //    dgvDocList.Rows[i].Cells["Payment"].Value = 0;
                    //    dgvDocList.Rows[i].Cells["Docbal"].Value = _dtAPDocTmp.Rows[dgvDocList.Rows[i].Index]["Payment"].ToString();
                    //    _dtAPDocTmp.Rows[dgvDocList.Rows[i].Index]["DocBal"] = _dtAPDocTmp.Rows[dgvDocList.Rows[i].Index]["Payment"];
                    //    ((CheckBox)dgvDocList.Controls.Find("checkboxHeader", true)[0]).Checked = false;
                    //}
                }
                //}
                dgvDocList.EndEdit();
            }
            //throw new NotImplementedException();
            _ComputeAmt();
        }
        private void dgvDocList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                double payment = _GetValue(dgvDocList.Rows[e.RowIndex].Cells["DocNbr"].Value.ToString())[0];
                double docbal = _GetValue(dgvDocList.Rows[e.RowIndex].Cells["DocNbr"].Value.ToString())[1];

                dgvDocList.EndEdit();                
                if (((bool)dgvDocList.Rows[e.RowIndex].Cells[0].FormattedValue == true) && (dgvDocList.Rows[e.RowIndex].Cells[0].FormattedValue != null))
                {
                    dgvDocList.Rows[e.RowIndex].Cells["Payment"].Value = payment+docbal;
                    dgvDocList.Rows[e.RowIndex].Cells["Docbal"].Value = 0;

                    //===============
                    bool kq = true;
                    foreach (DataGridViewRow row in dgvDocList.Rows)
                    {
                        if (bool.Parse(row.Cells[0].Value.ToString()) == false)
                        {
                            kq = false;
                            break;
                        }
                    }
                    if (kq == true)
                        ((CheckBox)dgvDocList.Controls.Find("checkboxHeader", true)[0]).Checked = true;
                    //===============
                }
                else if ((bool)dgvDocList.Rows[e.RowIndex].Cells[0].FormattedValue == false)
                {
                    dgvDocList.Rows[e.RowIndex].Cells["DocBal"].Value = payment + docbal;
                    dgvDocList.Rows[e.RowIndex].Cells["Payment"].Value = 0;
                //    if (_dtAPDocTmp.Rows[dgvDocList.Rows[e.RowIndex].Index]["Docbal"].ToString() != "0")
                //    {
                //        dgvDocList.Rows[e.RowIndex].Cells["Payment"].Value = 0;
                //        //dgvDocList.Rows[e.RowIndex].Cells["Docbal"].Value = _dtAPDocTmp.Rows[dgvDocList.Rows[e.RowIndex].Index]["Docbal"].ToString();
                //        dgvDocList.Rows[e.RowIndex].Cells["Docbal"].Value = double.Parse(_dtAPDocTmp.Rows[dgvDocList.Rows[e.RowIndex].Index]["Docbal"].ToString()) + double.Parse(_dtAPDocTmp.Rows[dgvDocList.Rows[e.RowIndex].Index]["Payment"].ToString());
                //        ((CheckBox)dgvDocList.Controls.Find("checkboxHeader", true)[0]).Checked = false;
                //    }
                //    else
                //    {
                //        dgvDocList.Rows[e.RowIndex].Cells["Payment"].Value = 0;
                //        dgvDocList.Rows[e.RowIndex].Cells["Docbal"].Value = _dtAPDocTmp.Rows[dgvDocList.Rows[e.RowIndex].Index]["Payment"].ToString();
                //        _dtAPDocTmp.Rows[dgvDocList.Rows[e.RowIndex].Index]["DocBal"] = _dtAPDocTmp.Rows[dgvDocList.Rows[e.RowIndex].Index]["Payment"];
                //        ((CheckBox)dgvDocList.Controls.Find("checkboxHeader", true)[0]).Checked = false;
                //    }
                }
                

            }
            dgvDocList.EndEdit();
            _ComputeAmt();
        }
        private void dgvDocList_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //double a = 0;
            //if (double.TryParse(dgvDocList.Rows[e.RowIndex].Cells["Payment"].Value.ToString(), out a) == false)
            //    dgvDocList.Rows[e.RowIndex].Cells["Payment"].Value = 0;
            
            if (e.ColumnIndex == dgvDocList.Columns["Payment"].Index)
            {
                double payment = _GetValue(dgvDocList.Rows[e.RowIndex].Cells["DocNbr"].Value.ToString())[0];
                double docbal = _GetValue(dgvDocList.Rows[e.RowIndex].Cells["DocNbr"].Value.ToString())[1];
                //dgvDocList.Rows[e.RowIndex].Cells["Docbal"].Value = double.Parse(_dtAPDocTmp.Rows[e.RowIndex]["Docbal"].ToString()) - double.Parse(dgvDocList.Rows[e.RowIndex].Cells["Payment"].Value.ToString());\
                dgvDocList.Rows[e.RowIndex].Cells["Docbal"].Value = (payment+docbal)-double.Parse(dgvDocList.Rows[e.RowIndex].Cells["Payment"].Value.ToString());
                if (double.Parse(dgvDocList.Rows[e.RowIndex].Cells["Docbal"].Value.ToString()) == 0)
                    dgvDocList[0, e.RowIndex].Value = true;
                else
                    dgvDocList[0, e.RowIndex].Value = false;

            }
            //===============
            bool kq = true;
            foreach (DataGridViewRow row in dgvDocList.Rows)
            {
                if (bool.Parse(row.Cells[0].Value.ToString()) == false)
                {
                    kq = false;
                    break;
                }
            }
            if (kq == true && dgvDocList.Rows.Count>0)
                ((CheckBox)dgvDocList.Controls.Find("checkboxHeader", true)[0]).Checked = true;
            //===============
            //double total = 0;
            //for (int i = 0; i < dgvDocList.RowCount; i++)
            //{
            //    total += double.Parse(dgvDocList["Payment", i].Value.ToString());
            //}
            //txtAdjAmt.Text = (double.Parse(_infoAPAdjust.AdjAmt.ToString()) + double.Parse(total.ToString())).ToString();
            _ComputeAmt();
        }
        private void dgvDocList_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                double payment = _GetValue(dgvDocList.Rows[e.RowIndex].Cells["DocNbr"].Value.ToString())[0];
                double docbal = _GetValue(dgvDocList.Rows[e.RowIndex].Cells["DocNbr"].Value.ToString())[1];

                dgvDocList.EndEdit();
                if (((bool)dgvDocList.Rows[e.RowIndex].Cells[0].FormattedValue == true) && (dgvDocList.Rows[e.RowIndex].Cells[0].FormattedValue != null))
                {
                    dgvDocList.Rows[e.RowIndex].Cells["Payment"].Value = payment + docbal;
                    dgvDocList.Rows[e.RowIndex].Cells["Docbal"].Value = 0;

                    //===============
                    bool kq = true;
                    foreach (DataGridViewRow row in dgvDocList.Rows)
                    {
                        if (bool.Parse(row.Cells[0].Value.ToString()) == false)
                        {
                            kq = false;
                            break;
                        }
                    }
                    if (kq == true)
                        ((CheckBox)dgvDocList.Controls.Find("checkboxHeader", true)[0]).Checked = true;
                    //===============
                }
                else if ((bool)dgvDocList.Rows[e.RowIndex].Cells[0].FormattedValue == false)
                {
                    dgvDocList.Rows[e.RowIndex].Cells["DocBal"].Value = payment + docbal;
                    dgvDocList.Rows[e.RowIndex].Cells["Payment"].Value = 0;
                    //    if (_dtAPDocTmp.Rows[dgvDocList.Rows[e.RowIndex].Index]["Docbal"].ToString() != "0")
                    //    {
                    //        dgvDocList.Rows[e.RowIndex].Cells["Payment"].Value = 0;
                    //        //dgvDocList.Rows[e.RowIndex].Cells["Docbal"].Value = _dtAPDocTmp.Rows[dgvDocList.Rows[e.RowIndex].Index]["Docbal"].ToString();
                    //        dgvDocList.Rows[e.RowIndex].Cells["Docbal"].Value = double.Parse(_dtAPDocTmp.Rows[dgvDocList.Rows[e.RowIndex].Index]["Docbal"].ToString()) + double.Parse(_dtAPDocTmp.Rows[dgvDocList.Rows[e.RowIndex].Index]["Payment"].ToString());
                    //        ((CheckBox)dgvDocList.Controls.Find("checkboxHeader", true)[0]).Checked = false;
                    //    }
                    //    else
                    //    {
                    //        dgvDocList.Rows[e.RowIndex].Cells["Payment"].Value = 0;
                    //        dgvDocList.Rows[e.RowIndex].Cells["Docbal"].Value = _dtAPDocTmp.Rows[dgvDocList.Rows[e.RowIndex].Index]["Payment"].ToString();
                    //        _dtAPDocTmp.Rows[dgvDocList.Rows[e.RowIndex].Index]["DocBal"] = _dtAPDocTmp.Rows[dgvDocList.Rows[e.RowIndex].Index]["Payment"];
                    //        ((CheckBox)dgvDocList.Controls.Find("checkboxHeader", true)[0]).Checked = false;
                    //    }
                }
                dgvDocList.EndEdit();
                _ComputeAmt();
            }
        }
        private void txtPoNbr_TextChanged(object sender, EventArgs e)
        {
            _FilterGrid();
        }
        private void txtInvcNbr_TextChanged(object sender, EventArgs e)
        {
            _FilterGrid();
        }        
        private void btnCheck_Click(object sender, EventArgs e)
        {
            //((CheckBox)dgvDocList.Controls.Find("checkboxHeader", true)[0]).Checked = true;
            for (int i = 0; i < dgvDocList.RowCount; i++)
            {
                dgvDocList[0, i].Value = true;
                dgvDocList.Rows[i].Cells["Payment"].Value = _dtAPDocTmp.Rows[i]["Docbal"].ToString();
                dgvDocList.Rows[i].Cells["Docbal"].Value = 0;
            }
            dgvDocList.EndEdit();
            txtInvcNbr.Text = "";
            txtPoNbr.Text = "";            
            _dtAPDoc.DefaultView.RowFilter = "";
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtAdjNbr.Text.ToString().Trim() == "")
            {
                DataTable _dtLastNbr = AP202Ctrl.GetSASetupGetLastNbr("AP", _strFistChar);
                _strLastNbr = _dtLastNbr.Rows[0]["LastNbr"].ToString();
                string strLastNbr = (Int16.Parse(_strLastNbr) + 1).ToString("000000");
                txtAdjNbr.Text = "AP" + _strFistChar + strLastNbr;
                _infoAPAdjust.AdjNbr ="AP" +_strFistChar + strLastNbr; 
                _SaveSASetup("AP", _strFistChar, strLastNbr);
                _GetPanel(0);
            }
            else
            {
                _GetPanel(0);
                _infoAPAdjust.LUpd_DateTime = DateTime.Now;
                _infoAPAdjust.LUpd_Prog = _strPro;
                _infoAPAdjust.LUpd_User = _strUser;
            }

            int kq = _SaveAPAdjust(0);
            if (kq != 0)
            {
                kq = _SaveAPAdjustDet();
                if (kq != 0)
                {
                    _infoAPAdjust.ConvertToAPAdjust(AP202Ctrl.GetAPAdjust(_infoAPAdjust.BranchID, _infoAPAdjust.AdjNbr).Rows[0]);
                    _SetButtomStatus();
                }
            }
            _BindGrid();
            _dtAPDoc.DefaultView.Sort = "DocBal ASC";
            _dtAPDocTmp.DefaultView.Sort = "DocBal ASC";

        }
        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            pnldgv.Visible = false;
            pnl.Visible = true;
            _infoAPAdjust.ConvertToAPAdjust(_dtAPAdjust.Rows[e.RowIndex]);
            _BindPanel(_infoAPAdjust);
            dtmFromDateLoad.Value = _infoAPAdjust.FromDateTmp;
            dtmToDateLoad.Value = _infoAPAdjust.ToDateTmp;
            txtVendIDLoad.Text = _infoAPAdjust.VendIDTmp;
            dtmToDateLoad.Enabled = false;
            dtmFromDateLoad.Enabled = false;
            txtVendIDLoad.Enabled = false;
            btnLoad.PerformClick();
        }
        private void btnRelease_Click(object sender, EventArgs e)
        {
            _GetPanel(1);
            _SaveAPAdjust(1);
            cmbStatus.SelectedValue = 1;
            _SetButtomStatus();
        }
        private void btnDestroy_Click(object sender, EventArgs e)
        {
            _GetPanel(-1);
            _SaveAPAdjust(-1);
            cmbStatus.SelectedValue = -1;
            _SetButtomStatus();
        }        
        private void btnBack_Click(object sender, EventArgs e)
        {
            dtmToDateLoad.Enabled = true;
            dtmFromDateLoad.Enabled = true;
            txtVendIDLoad.Enabled = true;
        }        
        private void btnCanAndCopy_Click(object sender, EventArgs e)
        {
            DateTime from = dtmFromDateLoad.Value;
            DateTime to = dtmToDateLoad.Value;
            string vendid = txtVendIDLoad.Text.ToString().Trim();
            _GetPanel(-1);
            _SaveAPAdjust(-1);
            cmbStatus.SelectedValue = -1;

            _ResetPanelInput();
            _BindPanel(_infoAPAdjust);
            txtAdjNbr.Text = "";
            cmbStatus.SelectedValue = 0;
            _SetButtomStatus();
        }
        private void dgvDocList_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
             double a = 0;
            if (a > double.Parse(dgvDocList.Rows[e.RowIndex].Cells["DocBal"].Value.ToString()))
                dgvDocList.Rows[e.RowIndex].Cells["Payment"].Value = double.Parse(dgvDocList.Rows[e.RowIndex].Cells["DocBal"].Value.ToString());     
        }

        private void dgvDocList_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            double a = 0;
            if (double.TryParse(dgvDocList.Rows[e.RowIndex].Cells["Payment"].Value.ToString(), out a) == false)
                dgvDocList.Rows[e.RowIndex].Cells["Payment"].Value = 0;
        }

        private void dgvDocList_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            dgvDocList.EndEdit();
            DataGridViewCell cuCell = dgvDocList.CurrentCell;
            string mainStr = dgvDocList.CurrentCell.Value.ToString();
            for (int scan = 0; scan < mainStr.Length; scan++)
            {
                if (Char.IsDigit(mainStr[scan])) { }
                else
                {
                    dgvDocList.CurrentCell.Value = 0;
                    dgvDocList.ClearSelection();
                    dgvDocList.CurrentCell = cuCell;
                    dgvDocList.CurrentCell.Selected = true;
                    return;
                }
            }
        }
    }
}
