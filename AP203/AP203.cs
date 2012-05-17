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
namespace AP203
{
    public partial class AP203 : PT.Master.GridEditIn
    {
        private DataTable _dtAPAdjust = new DataTable();
        private APAdjust _infoAPAdjust = new APAdjust();
        private DataTable _dtAPAdjustDet = new DataTable();
        private APAdjustDet _infoAPAdjustDet = new APAdjustDet();
        private string _strPro = "AP202";
        private string _strUser = PT.Helper.Globals.PTUserName;
        private DataTable _dtADoc, _dtNDoc, _dtADocTmp, _dtNDocTmp = new DataTable();
        private DataTable _dtSAUser = new DataTable();
        private DataTable _dtSIBranch = new DataTable();
        private DataTable _dtVend = new DataTable();
        private DataTable _dtCAAccount = new DataTable();
        private DataTable _dtPONbr = new DataTable();
        private string _strFistChar = "CT", _strLastNbr;
        public AP203()
        {
            InitializeComponent();
        }
        private void AP203_Load(object sender, EventArgs e)
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
            string strAdjNbrFind = txtAdjdNbrFind.Text.ToString().Trim();
            _dtAPAdjust = AP203Ctrl.FindAPADjust(_strPro, strUser, strAdjNbrFind, strFromDate, strToDate);
               
            dgv.DataSource = _dtAPAdjust;

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

            txtVendID.DataSource = _dtVend;
        }
        private void _BindPanel(APAdjust info)
        {
            cmbBranchID.SelectedValue = info.BranchID;
            cmbStatus.SelectedValue = info.Rlsed;
            txtAdjNbr.Text = info.AdjNbr;
            dtmAdjDate.Value = info.AdjDate;
            txtAdjAmt.Text = info.AdjAmt.ToString();
            txtAdjDescr.Text = info.AdjDesc;
            txtVendID.Text = info.VendIDTmp;
        }
        private void _LoadData()
        {
            _dtCAAccount = AP203Ctrl.GetCAAccount();
            _dtSAUser = AP203Ctrl.GetSAUser();
            _dtSIBranch = AP203Ctrl.GetSIBranch();
            _dtVend = AP203Ctrl.GetVendID();
        }
        private void _BindADocGrid()
        {            
            string brandid = cmbBranchID.SelectedValue.ToString();
            string AdjNbr = txtAdjNbr.Text.ToString();
            string vendid = txtVendID.Text.ToString();
            int Release = Int32.Parse(cmbStatus.SelectedValue.ToString());
            _dtADoc = AP203Ctrl.LoadADoc(brandid, AdjNbr, vendid, Release);
            _dtADocTmp = _dtADoc.Copy();
            dgvADocList.DataSource = _dtADoc;

            //==================
            if ((dgvADocList.Columns[0].Name == "chk") && (dgvADocList.Rows.Count > 0))
            {
                dgvADocList.Columns[0].HeaderText = "";
                dgvADocList.Columns[0].Width = 18;
                // add checkbox header            
                Rectangle rect = dgvADocList.GetCellDisplayRectangle(0, -1, true);
                // set checkbox header to center of header cell. +1 pixel to position correctly.
                rect.X = rect.Location.X + (rect.Width / 4) - 2;
                rect.Y = rect.Y + 5;

                CheckBox AcheckboxHeader = new CheckBox();
                AcheckboxHeader.Name = "AcheckboxHeader";
                AcheckboxHeader.Size = new Size(13, 13);
                AcheckboxHeader.Location = rect.Location;
                AcheckboxHeader.Click += new EventHandler(AcheckboxHeader_Click);
                dgvADocList.Controls.Add(AcheckboxHeader);
                for (int i = 0; i < dgvADocList.Columns.Count; i++)
                {
                    dgvADocList.Columns[i].ReadOnly = true;
                }
                dgvADocList.Columns["Payment"].ReadOnly = false;
                dgvADocList.Columns[0].ReadOnly = false;

                bool kq = true;
                double total = 0;
                for (int i = 0; i < dgvADocList.RowCount; i++)
                {
                    total += double.Parse(dgvADocList.Rows[i].Cells["Docbal"].Value.ToString());
                    if (dgvADocList.Rows[i].Cells["Docbal"].Value.ToString() == "0")
                        dgvADocList[0, i].Value = true;
                    else
                    {
                        dgvADocList[0, i].Value = false;
                        kq = false;
                    }

                }
                if (kq == true)
                    ((CheckBox)dgvADocList.Controls.Find("AcheckboxHeader", true)[0]).Checked = true;
                dgvADocList.EndEdit();
                txtTotalAAmt.Text = total.ToString();
            }

            //==================

        }        
        private void _BindNDocGrid()
        {
            string brandid = cmbBranchID.SelectedValue.ToString();
            string AdjNbr = txtAdjNbr.Text.ToString();
            string vendid = txtVendID.Text.ToString();
            int Release = Int32.Parse(cmbStatus.SelectedValue.ToString());
            _dtNDoc = AP203Ctrl.LoadNDoc(brandid, AdjNbr, vendid, Release);
            _dtNDocTmp = _dtNDoc.Copy();
            dgvNDocList.DataSource = _dtNDoc;

            //==================
            if ((dgvNDocList.Columns[0].Name == "chk") && (dgvNDocList.Rows.Count > 0))
            {
                dgvNDocList.Columns[0].HeaderText = "";
                dgvNDocList.Columns[0].Width = 18;
                // add checkbox header            
                Rectangle rect = dgvNDocList.GetCellDisplayRectangle(0, -1, true);
                // set checkbox header to center of header cell. +1 pixel to position correctly.
                rect.X = rect.Location.X + (rect.Width / 4) - 2;
                rect.Y = rect.Y + 5;

                CheckBox NcheckboxHeader = new CheckBox();
                NcheckboxHeader.Name = "NcheckboxHeader";
                NcheckboxHeader.Size = new Size(13, 13);
                NcheckboxHeader.Location = rect.Location;
                NcheckboxHeader.Click += new EventHandler(NcheckboxHeader_Click);
                dgvNDocList.Controls.Add(NcheckboxHeader);
                for (int i = 0; i < dgvNDocList.Columns.Count; i++)
                {
                    dgvNDocList.Columns[i].ReadOnly = true;
                }
                dgvNDocList.Columns["Payment"].ReadOnly = false;
                dgvNDocList.Columns[0].ReadOnly = false;

                bool kq = true;
                double total = 0;
                for (int i = 0; i < dgvNDocList.RowCount; i++)
                {
                                        total += double.Parse(dgvNDocList.Rows[i].Cells["Docbal"].Value.ToString());
                    if (dgvNDocList.Rows[i].Cells["Docbal"].Value.ToString() == "0")
                        dgvNDocList[0, i].Value = true;
                    else
                    {
                        dgvNDocList[0, i].Value = false;
                        kq = false;
                    }

                }
                if (kq == true)
                    ((CheckBox)dgvNDocList.Controls.Find("NcheckboxHeader", true)[0]).Checked = true;
                dgvNDocList.EndEdit();
                 txtTotalNAmt.Text = total.ToString();
            }

            //==================
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
                dgvADocList.Focus();
                return false;
            }
            return true;
        }
        private int _SaveAPAdjust(int release)
        {
            _infoAPAdjust.Rlsed = release;
            return AP203Ctrl.SaveAPAdjust(_infoAPAdjust);

        }
        private int _SaveAPAdjustDet()
        {
            string strBrandID = cmbBranchID.SelectedValue.ToString().Trim();
            string strAdjNbr = txtAdjNbr.Text.ToString().Trim();
            //string strAdjNbr = "tmp";
            DateTime dteAdjDate = dtmAdjDate.Value.Date;
            string strAdjAcct = "";
            double dbeAdjAmt = double.Parse(txtAdjAmt.Text.ToString().Trim());
            //DataTable list = new DataTable();
            //list = AP202Ctrl.FindAPADjustDet("");
            if (dgvADocList.DataSource == _dtADoc)
            {
                DataTable t1 = new DataTable();
                string sql1 = string.Format("Payment > 0 ");
                t1 = _dtADoc.Copy();
                t1.DefaultView.RowFilter = sql1;
                t1.DefaultView.Sort = "Payment DESC";
                t1 = t1.DefaultView.ToTable();
                DataTable t2 = new DataTable();
                string sql2 = string.Format("Payment > 0 ");
                t2 = _dtNDoc.Copy();
                t2.DefaultView.RowFilter = sql2;
                t2.DefaultView.Sort = "Payment DESC";
                t2 = t2.DefaultView.ToTable();


                foreach (DataRow rows in t1.Rows)
                {
                    foreach (DataRow rows2 in t2.Rows)
                    {
                        double s1 = double.Parse(rows["Payment"].ToString().Trim());
                        double s2 = double.Parse(rows2["Payment"].ToString().Trim());
                        if (s1 > 0 && s2 > 0)
                        {
                            if (s1 > s2 && s2 > 0)
                            {
                                APAdjustDet info = new APAdjustDet();
                                info.BranchID = strBrandID;
                                info.AdjNbr = strAdjNbr;
                                info.LineRef = "none";
                                info.VendID = rows["VendID"].ToString().Trim();
                                info.AdjDate = dteAdjDate;
                                info.AdjAcct = strAdjAcct;
                                info.AdjAmt = s2;
                                info.ADocNbr = rows["DocNbr"].ToString().Trim();
                                info.ADocType = rows["DocType"].ToString().Trim();
                                info.ADocDate = DateTime.Parse(rows["DocDate"].ToString().Trim()).Date;
                                info.NDocNbr = rows2["DocNbr"].ToString().Trim();
                                info.NDocType = rows2["DocType"].ToString().Trim();
                                info.NDocDate = DateTime.Parse(rows2["DocDate"].ToString().Trim()).Date;
                                info.Rlsed = 0;
                                info.Crtd_DateTime = DateTime.Now;
                                info.Crtd_Prog = _strPro;
                                info.Crtd_User = _strUser;
                                info.LUpd_DateTime = DateTime.Now;
                                info.LUpd_Prog = _strPro;
                                info.LUpd_User = _strUser;
                                info.Version = "";
                                AP203Ctrl.SaveAPAdjustDet(info);
                                rows["Payment"] = s1 - s2;
                                rows2["Payment"] = 0;
                            }
                            else if (s1 > 0)
                            {
                                APAdjustDet info = new APAdjustDet();
                                info.BranchID = strBrandID;
                                info.AdjNbr = strAdjNbr;
                                info.LineRef = "none";
                                info.VendID = rows["VendID"].ToString().Trim();
                                info.AdjDate = dteAdjDate;
                                info.AdjAcct = strAdjAcct;
                                info.AdjAmt = s1;
                                info.ADocNbr = rows["DocNbr"].ToString().Trim();
                                info.ADocType = rows["DocType"].ToString().Trim();
                                info.ADocDate = DateTime.Parse(rows["DocDate"].ToString().Trim()).Date;
                                info.NDocNbr = rows2["DocNbr"].ToString().Trim();
                                info.NDocType = rows2["DocType"].ToString().Trim();
                                info.NDocDate = DateTime.Parse(rows2["DocDate"].ToString().Trim()).Date;
                                info.Rlsed = 0;
                                info.Crtd_DateTime = DateTime.Now;
                                info.Crtd_Prog = _strPro;
                                info.Crtd_User = _strUser;
                                info.LUpd_DateTime = DateTime.Now;
                                info.LUpd_Prog = _strPro;
                                info.LUpd_User = _strUser;
                                info.Version = "";
                                AP203Ctrl.SaveAPAdjustDet(info);
                                rows["Payment"] = 0;
                                rows2["Payment"] = s2 - s1;
                            }
                        }
                    }
                }
            }
            //else if (dgvDocList.DataSource == _dtAPAdjustDet)
            //{
            //    foreach (DataRow rows in _dtAPAdjustDet.Rows)
            //    {
            //        APAdjustDet info = new APAdjustDet();
            //        info.BranchID = strBrandID;
            //        info.AdjNbr = strAdjAcct;
            //        info.LineRef = rows["LineRef"].ToString().Trim();// intLineRef.ToString("00000");
            //        info.VendID = rows["VendID"].ToString().Trim();
            //        info.AdjDate = dteAdjDate;
            //        info.AdjAcct = strAdjAcct;
            //        info.AdjAmt = dbeAdjAmt;
            //        info.NDocNbr = rows["NDocNbr"].ToString().Trim();
            //        info.NDocType = rows["NDocType"].ToString().Trim();
            //        info.NDocDate = DateTime.Parse(rows["NDocDate"].ToString().Trim()).Date;
            //        info.ADocNbr = "";
            //        info.ADocType = "";
            //        //info.ADocDate = null;
            //        info.Rlsed = 0;
            //        info.Crtd_DateTime = DateTime.Now;
            //        info.Crtd_Prog = _strPro;
            //        info.Crtd_User = _strUser;
            //        info.LUpd_DateTime = DateTime.Now;
            //        info.LUpd_Prog = _strPro;
            //        info.LUpd_User = _strUser;
            //        info.Version = "";
            //        AP202Ctrl.SaveAPAdjust(_infoAPAdjust);

            //    }
            //}
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
                kq = AP203Ctrl.SaveSASetup(_sa);
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
                    if (c.Name.ToString().Length >= 5)
                    {
                        string name = c.Name.Substring(0, 5);
                        if (((name != "label") || (name == "btn")) && (name != "pnl"))
                            c.Enabled = true;
                    }
                }
            }
            else
                txtVendID.Enabled = false;
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
                    if (c.Name.ToString().Length >= 5)
                    {
                        string name = c.Name.Substring(0, 5);
                        if (((name != "label") || (name == "btn")) && (name != "pnl"))
                            c.Enabled = true;
                    }
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
                    if (c.Name.ToString().Length >= 5)
                    {
                        string name = c.Name.Substring(0, 5);
                        if (((name != "label") || (name == "btn")) && (name != "pnl"))
                            c.Enabled = true;
                    }
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
                    if (c.Name.ToString().Length >= 5)
                    {
                        string name = c.Name.Substring(0, 5);
                        if (((name != "label") || (name == "btn")) && (name != "pnl"))
                            c.Enabled = false;
                    }
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
                    if (c.Name.ToString().Length >= 5)
                    {
                        string name = c.Name.Substring(0, 5);
                        if (((name != "label") || (name == "btn")) && (name != "pnl"))
                            c.Enabled = false;
                    }
                }
            }
        }       
        private void _SumADoc()
        {
            //double totalAmt= 0;
            double totalPayment = 0;
            if (dgvADocList.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvADocList.Rows)
               {
                   //totalAmt += double.Parse(row.Cells["DocBal"].Value.ToString());
                   totalPayment += double.Parse(row.Cells["Payment"].Value.ToString());
               }
               txtTotalACheck.Text = totalPayment.ToString();
            }
        }
        private double _SumNDoc()
        {
            ////double totalAmt= 0;
            double totalPayment = 0;
            if (dgvNDocList.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvNDocList.Rows)
                {
                    totalPayment += double.Parse(row.Cells["Payment"].Value.ToString());
                }                
                txtTotalNCheck.Text = totalPayment.ToString();
                txtAdjAmt.Text = totalPayment.ToString();
            }
            return totalPayment;
        }
        private double[] _GetAValue(string id)
        {
            double[] db = new double[2];
            string sql = string.Format("DocNbr = '{0}'", id);
            db[0] = double.Parse(_dtADocTmp.Select(sql)[0]["Payment"].ToString());
            db[1] = double.Parse(_dtADocTmp.Select(sql)[0]["DocBal"].ToString());
            return db;
        }
        private double[] _GetNValue(string id)
        {
            double[] db = new double[2];
            string sql = string.Format("DocNbr = '{0}'", id);
             /////////db[0] = double.Parse(_dtNDocTmp.Select(sql)[0]["Payment"].ToString());
            db[1] = double.Parse(_dtNDocTmp.Select(sql)[0]["DocBal"].ToString());
            return db;
        }
        private APAdjust _GetPanel(int intRelease)
        {
            _infoAPAdjust.BranchID = cmbBranchID.SelectedValue.ToString().Trim();
            _infoAPAdjust.AdjNbr = txtAdjNbr.Text.ToString().Trim();
            _infoAPAdjust.AdjDate = dtmAdjDate.Value.Date;
            _infoAPAdjust.AdjDesc = txtAdjDescr.Text.ToString().Trim();
            _infoAPAdjust.AdjAcct = "";
            _infoAPAdjust.AdjAmt = double.Parse(txtAdjAmt.Text.ToString().Trim());
            _infoAPAdjust.Rlsed = intRelease;
            _infoAPAdjust.FromDateTmp = DateTime.Now;
            _infoAPAdjust.ToDateTmp = DateTime.Now;
            _infoAPAdjust.VendIDTmp = txtVendID.Text.ToString().Trim();
            _infoAPAdjust.Note = "";
            if (_infoAPAdjust.Crtd_DateTime == DateTime.MinValue)
                _infoAPAdjust.Crtd_DateTime = DateTime.Now;
            if (_infoAPAdjust.Crtd_Prog == null)
            _infoAPAdjust.Crtd_Prog = _strPro;
            if (_infoAPAdjust.Crtd_User == null)
            _infoAPAdjust.Crtd_User = _strUser;
            _infoAPAdjust.LUpd_DateTime = DateTime.Now;
            _infoAPAdjust.LUpd_Prog = _strPro;
            _infoAPAdjust.LUpd_User = _strUser;
            if (_infoAPAdjust.Version == null)
                _infoAPAdjust.Version = "";
            return _infoAPAdjust;
        }     
        private void _ResetPanel()
        {
            _LoadData();
            _BindCtrl();
            dtmAdjDate.Value = DateTime.Now;
            txtAdjDescr.Text = "";
            txtAdjAmt.Text = "";
            txtTotalAAmt.Text = "";
            txtTotalNAmt.Text = "";
            txtTotalACheck.Text = "";
            txtVendID.Text = "";
            cmbBranchID.Focus();

            dgvADocList.DataSource = null;
            dgvADocList.Controls.Clear();
            dgvNDocList.DataSource = null;
            dgvNDocList.Controls.Clear();
            //_BindADocGrid();
            //_BindNDocGrid();
        }

        private void NcheckboxHeader_Click(object sender, EventArgs e)
        {            
            for (int i = 0; i < dgvNDocList.RowCount; i++)
            {
                //if (txtTotalACheck.Text.ToString().Trim() == "0")
                //{
                //    dgvNDocList.EndEdit();
                //    //dgvADocList.CancelEdit();
                //    //dgvNDocList.Rows[e.RowIndex].Cells["chk"].Value = false;
                //    MessageBox.Show("Vui long chon don can thanh toan");
                //    dgvADocList.Focus();
                //    dgvNDocList.EndEdit();
                //    return;
                //}
                double payment = _GetNValue(dgvNDocList.Rows[i].Cells["DocNbr"].Value.ToString())[0];
                double docbal = _GetNValue(dgvNDocList.Rows[i].Cells["DocNbr"].Value.ToString())[1];
                dgvNDocList[0, i].Value = ((CheckBox)dgvNDocList.Controls.Find("NcheckboxHeader", true)[0]).Checked;

                object d = ((CheckBox)dgvNDocList.Controls.Find("NcheckboxHeader", true)[0]).Checked;

                if ((bool)dgvNDocList.Rows[i].Cells[0].FormattedValue)
                {
                    if (double.Parse(dgvNDocList.Rows[i].Cells["Docbal"].Value.ToString()) != 0)
                    {
                        dgvNDocList.Rows[i].Cells["Payment"].Value = payment + docbal;
                        dgvNDocList.Rows[i].Cells["Docbal"].Value = 0;
                    }
                }
                else
                {
                    dgvNDocList.Rows[i].Cells["Docbal"].Value = payment + docbal;
                    dgvNDocList.Rows[i].Cells["Payment"].Value = 0;
                }
            }
            dgvNDocList.EndEdit();
            _SumNDoc();
        }
        private void AcheckboxHeader_Click(object sender, EventArgs e)
        {
            //if (((CheckBox)dgvADocList.Controls.Find("AcheckboxHeader", true)[0]).Checked == false )
            //{
            //    dgvNDocList.EndEdit();
            //    //dgvADocList.CancelEdit();
            //    dgvNDocList.Rows[e.RowIndex].Cells["chk"].Value = false;
            //    MessageBox.Show("Vui long chon don can thanh toan");
            //    dgvADocList.Focus();
            //    dgvNDocList.EndEdit();
            //    return;
            //}
            for (int i = 0; i < dgvADocList.RowCount; i++)
            {
                double payment = _GetAValue(dgvADocList.Rows[i].Cells["DocNbr"].Value.ToString())[0];
                double docbal = _GetAValue(dgvADocList.Rows[i].Cells["DocNbr"].Value.ToString())[1];
                dgvADocList[0, i].Value = ((CheckBox)dgvADocList.Controls.Find("AcheckboxHeader", true)[0]).Checked;

                object d = ((CheckBox)dgvADocList.Controls.Find("AcheckboxHeader", true)[0]).Checked;

                if ((bool)dgvADocList.Rows[i].Cells[0].FormattedValue)
                {
                    if (double.Parse(dgvADocList.Rows[i].Cells["Docbal"].Value.ToString()) != 0)
                    {
                        dgvADocList.Rows[i].Cells["Payment"].Value = payment + docbal;
                        dgvADocList.Rows[i].Cells["Docbal"].Value = 0;
                    }
                }
                else
                {
                    dgvADocList.Rows[i].Cells["Docbal"].Value = payment + docbal;
                    dgvADocList.Rows[i].Cells["Payment"].Value = 0;
                }
            }
            dgvADocList.EndEdit();
            _SumADoc();
        }
        private void pnl_SizeChanged(object sender, EventArgs e)
        {
            labelX11.Left = pnlB.Left;
            int pnlW = pnl.Width;
            pnlA.Width = pnlW / 2 - 2;
            pnlB.Width = pnlW / 2 - 2;
            labelX11.Left = pnlA.Width + 10;
            txtTotalNAmt.Left = labelX11.Left + labelX11.Width + 10;
            labelX12.Left = txtTotalNAmt.Left + txtTotalNAmt.Width + 10;
            txtTotalNCheck.Left = labelX12.Left + labelX12.Width + 10;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            _ResetPanel();
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
           
        }
        private void txtVendID_TextChanged(object sender, EventArgs e)
        {
            _BindADocGrid();
            _BindNDocGrid();
        }
        private void dgvADocList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                double payment = _GetAValue(dgvADocList.Rows[e.RowIndex].Cells["DocNbr"].Value.ToString())[0];
                double docbal = _GetAValue(dgvADocList.Rows[e.RowIndex].Cells["DocNbr"].Value.ToString())[1];

                dgvADocList.EndEdit();
                if (((bool)dgvADocList.Rows[e.RowIndex].Cells[0].FormattedValue == true) && (dgvADocList.Rows[e.RowIndex].Cells[0].FormattedValue != null))
                {
                    dgvADocList.Rows[e.RowIndex].Cells["Payment"].Value = payment + docbal;
                    dgvADocList.Rows[e.RowIndex].Cells["Docbal"].Value = 0;

                    //===============
                    bool kq = true;
                    foreach (DataGridViewRow row in dgvADocList.Rows)
                    {
                        if (bool.Parse(row.Cells[0].Value.ToString()) == false)
                        {
                            kq = false;
                            break;
                        }
                    }
                    if (kq == true)
                        ((CheckBox)dgvADocList.Controls.Find("AcheckboxHeader", true)[0]).Checked = true;
                    else
                        ((CheckBox)dgvADocList.Controls.Find("AcheckboxHeader", true)[0]).Checked = false;
                    //===============
                }
                else if ((bool)dgvADocList.Rows[e.RowIndex].Cells[0].FormattedValue == false)
                {
                    ((CheckBox)dgvADocList.Controls.Find("AcheckboxHeader", true)[0]).Checked = false;
                    dgvADocList.Rows[e.RowIndex].Cells["DocBal"].Value = payment + docbal;
                    dgvADocList.Rows[e.RowIndex].Cells["Payment"].Value = 0;                    
                }


            }
            dgvADocList.EndEdit();
            _SumADoc();
        }
        private void dgvADocList_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                double payment = _GetAValue(dgvADocList.Rows[e.RowIndex].Cells["DocNbr"].Value.ToString())[0];
                double docbal = _GetAValue(dgvADocList.Rows[e.RowIndex].Cells["DocNbr"].Value.ToString())[1];

                dgvADocList.EndEdit();
                if (((bool)dgvADocList.Rows[e.RowIndex].Cells[0].FormattedValue == true) && (dgvADocList.Rows[e.RowIndex].Cells[0].FormattedValue != null))
                {
                    dgvADocList.Rows[e.RowIndex].Cells["Payment"].Value = payment + docbal;
                    dgvADocList.Rows[e.RowIndex].Cells["Docbal"].Value = 0;

                    //===============
                    bool kq = true;
                    foreach (DataGridViewRow row in dgvADocList.Rows)
                    {
                        if (bool.Parse(row.Cells[0].Value.ToString()) == false)
                        {
                            kq = false;
                            break;
                        }
                    }
                    if (kq == true)
                        ((CheckBox)dgvADocList.Controls.Find("AcheckboxHeader", true)[0]).Checked = true;
                    //===============
                }
                else if ((bool)dgvADocList.Rows[e.RowIndex].Cells[0].FormattedValue == false)
                {
                    ((CheckBox)dgvADocList.Controls.Find("AcheckboxHeader", true)[0]).Checked = false;
                    dgvADocList.Rows[e.RowIndex].Cells["DocBal"].Value = payment + docbal;
                    dgvADocList.Rows[e.RowIndex].Cells["Payment"].Value = 0;                    
                }


            }
            dgvADocList.EndEdit();
            _SumADoc();
        }
        private void dgvNDocList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvNDocList.EndEdit();
            if (e.ColumnIndex == 0)
            {
                dgvNDocList.BeginEdit(true);
                if (txtTotalACheck.Text.ToString().Trim() == "0")
                {
                    //dgvNDocList.EndEdit();
                    dgvNDocList.Rows[e.RowIndex].Cells["chk"].Value = false;
                    ((CheckBox)dgvNDocList.Controls.Find("NcheckboxHeader", true)[0]).Checked = false;
                    MessageBox.Show("Vui long chon don can thanh toan");
                    dgvADocList.Focus();
                    dgvNDocList.EndEdit();
                    return;
                }
                else
                {
                    //dgvNDocList.EndEdit();
                    double payment = _GetNValue(dgvNDocList.Rows[e.RowIndex].Cells["DocNbr"].Value.ToString())[0];
                    double docbal = _GetNValue(dgvNDocList.Rows[e.RowIndex].Cells["DocNbr"].Value.ToString())[1];
                    if (payment + docbal > txtTotalACheck.Number - txtTotalNCheck.Number)
                    {
                        dgvNDocList.Rows[e.RowIndex].Cells["chk"].Value = false;
                        ((CheckBox)dgvNDocList.Controls.Find("NcheckboxHeader", true)[0]).Checked = false;
                        MessageBox.Show("Qua gioi han thanh toan");
                        dgvADocList.Focus();
                        dgvNDocList.EndEdit();
                        return;
                    }
                    else
                    {
                        
                        if (((bool)dgvNDocList.Rows[e.RowIndex].Cells[0].FormattedValue == true) && (dgvNDocList.Rows[e.RowIndex].Cells[0].FormattedValue != null))
                        {
                            dgvNDocList.Rows[e.RowIndex].Cells["Payment"].Value = payment + docbal;
                            dgvNDocList.Rows[e.RowIndex].Cells["Docbal"].Value = 0;
                            //===============
                            bool kq = true;
                            foreach (DataGridViewRow row in dgvNDocList.Rows)
                            {
                                if (bool.Parse(row.Cells[0].Value.ToString()) == false)
                                {
                                    kq = false;
                                    break;
                                }
                            }
                            if (kq == true)
                                ((CheckBox)dgvNDocList.Controls.Find("NcheckboxHeader", true)[0]).Checked = true;
                            //===============
                        }
                        else if ((bool)dgvNDocList.Rows[e.RowIndex].Cells[0].FormattedValue == false)
                        {
                            ((CheckBox)dgvNDocList.Controls.Find("NcheckboxHeader", true)[0]).Checked = false;
                            dgvNDocList.Rows[e.RowIndex].Cells["DocBal"].Value = payment + docbal;
                            dgvNDocList.Rows[e.RowIndex].Cells["Payment"].Value = 0;
                        }
                    }
                }
                //dgvNDocList.CommitEdit(DataGridViewDataErrorContexts.Display);
            }
            dgvNDocList.EndEdit();
            _SumNDoc();
        }
        private void dgvNDocList_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                if (txtTotalACheck.Text.ToString().Trim() == "0")
                {
                    dgvNDocList.EndEdit();
                    //dgvADocList.CancelEdit();
                    dgvNDocList.Rows[e.RowIndex].Cells["chk"].Value = false;
                    MessageBox.Show("Vui long chon don can thanh toan");
                    dgvADocList.Focus();
                    dgvNDocList.EndEdit();
                    return;
                }
                else
                {
                    dgvNDocList.EndEdit();
                    double payment = _GetNValue(dgvNDocList.Rows[e.RowIndex].Cells["DocNbr"].Value.ToString())[0];
                    double docbal = _GetNValue(dgvNDocList.Rows[e.RowIndex].Cells["DocNbr"].Value.ToString())[1];
                    if (payment + docbal > txtTotalACheck.Number - txtTotalNCheck.Number)
                    {
                        dgvNDocList.Rows[e.RowIndex].Cells["chk"].Value = false;
                        MessageBox.Show("Qua gioi han thanh toan");
                        dgvADocList.Focus();
                        dgvNDocList.EndEdit();
                        return;
                    }
                    else
                    {

                        if (((bool)dgvNDocList.Rows[e.RowIndex].Cells[0].FormattedValue == true) && (dgvNDocList.Rows[e.RowIndex].Cells[0].FormattedValue != null))
                        {
                            dgvNDocList.Rows[e.RowIndex].Cells["Payment"].Value = payment + docbal;
                            dgvNDocList.Rows[e.RowIndex].Cells["Docbal"].Value = 0;

                            //===============
                            bool kq = true;
                            foreach (DataGridViewRow row in dgvNDocList.Rows)
                            {
                                if (bool.Parse(row.Cells[0].Value.ToString()) == false)
                                {
                                    kq = false;
                                    break;
                                }
                            }
                            if (kq == true)
                                ((CheckBox)dgvNDocList.Controls.Find("NcheckboxHeader", true)[0]).Checked = true;
                            //===============
                        }
                        else if ((bool)dgvNDocList.Rows[e.RowIndex].Cells[0].FormattedValue == false)
                        {
                            ((CheckBox)dgvNDocList.Controls.Find("NcheckboxHeader", true)[0]).Checked = false;
                            dgvNDocList.Rows[e.RowIndex].Cells["DocBal"].Value = payment + docbal;
                            dgvNDocList.Rows[e.RowIndex].Cells["Payment"].Value = 0;
                        }
                    }
                }
            }
            dgvNDocList.EndEdit();
            _SumNDoc();
        }
        private void dgvADocList_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvADocList.Columns["Payment"].Index)
            {
                double payment = _GetAValue(dgvADocList.Rows[e.RowIndex].Cells["DocNbr"].Value.ToString())[0];
                double docbal = _GetAValue(dgvADocList.Rows[e.RowIndex].Cells["DocNbr"].Value.ToString())[1];
                if (double.Parse(dgvADocList.Rows[e.RowIndex].Cells["Payment"].Value.ToString()) > docbal)
                    dgvADocList.Rows[e.RowIndex].Cells["Payment"].Value = docbal;
                dgvADocList.Rows[e.RowIndex].Cells["Docbal"].Value = (payment + docbal) - double.Parse(dgvADocList.Rows[e.RowIndex].Cells["Payment"].Value.ToString());
                if (double.Parse(dgvADocList.Rows[e.RowIndex].Cells["Docbal"].Value.ToString()) == 0)
                    dgvADocList[0, e.RowIndex].Value = true;
                else
                    dgvADocList[0, e.RowIndex].Value = false;

            }
            //===============
            bool kq = true;
            foreach (DataGridViewRow row in dgvADocList.Rows)
            {
                if (bool.Parse(row.Cells[0].Value.ToString()) == false)
                {
                    kq = false;
                    break;
                }
            }
            if (kq == true && dgvADocList.Rows.Count > 0)
                ((CheckBox)dgvADocList.Controls.Find("AcheckboxHeader", true)[0]).Checked = true;
            _SumADoc();
        }

        private void dgvNDocList_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvNDocList.Columns["Payment"].Index)
            {
                double payment = _GetNValue(dgvNDocList.Rows[e.RowIndex].Cells["DocNbr"].Value.ToString())[0];
                double docbal = _GetNValue(dgvNDocList.Rows[e.RowIndex].Cells["DocNbr"].Value.ToString())[1];
                if (txtTotalACheck.Text.ToString().Trim() == "0")
                {
                    MessageBox.Show("Vui long chon don can thanh toan");
                    dgvNDocList.Rows[e.RowIndex].Cells["Payment"].Value = payment;
                    dgvNDocList.Rows[e.RowIndex].Cells["Docbal"].Value = docbal;
                    dgvADocList.Focus();
                    return;
                }
                else
                {
                    if (double.Parse(dgvNDocList.Rows[e.RowIndex].Cells["Payment"].Value.ToString()) > docbal)
                        dgvNDocList.Rows[e.RowIndex].Cells["Payment"].Value = docbal;
                    dgvNDocList.Rows[e.RowIndex].Cells["Docbal"].Value = (payment + docbal) - double.Parse(dgvNDocList.Rows[e.RowIndex].Cells["Payment"].Value.ToString());
                    if (double.Parse(dgvNDocList.Rows[e.RowIndex].Cells["Payment"].Value.ToString()) > txtTotalACheck.Number - txtTotalNCheck.Number)
                    {
                        dgvNDocList.Rows[e.RowIndex].Cells["Payment"].Value = txtTotalACheck.Number - txtTotalNCheck.Number;
                        dgvNDocList.Rows[e.RowIndex].Cells["Docbal"].Value = (payment + docbal) - double.Parse(dgvNDocList.Rows[e.RowIndex].Cells["Payment"].Value.ToString());
                        dgvNDocList.EndEdit();
                    }
                    if (double.Parse(dgvNDocList.Rows[e.RowIndex].Cells["Docbal"].Value.ToString()) == 0)
                        dgvNDocList[0, e.RowIndex].Value = true;
                    else
                        dgvNDocList[0, e.RowIndex].Value = false;
                }
            }

            bool kq = true;
            foreach (DataGridViewRow row in dgvNDocList.Rows)
            {
                if (bool.Parse(row.Cells[0].Value.ToString()) == false)
                {
                    kq = false;
                    break;
                }
            }
            if (kq == true && dgvNDocList.Rows.Count > 0)
                ((CheckBox)dgvNDocList.Controls.Find("NcheckboxHeader", true)[0]).Checked = true;
            else
                ((CheckBox)dgvNDocList.Controls.Find("NcheckboxHeader", true)[0]).Checked = false;
            _SumNDoc();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            dgvADocList.EndEdit();
            dgvNDocList.EndEdit();
            _dtNDoc.AcceptChanges();
            //_SaveAPAdjustDet();
            if (txtAdjNbr.Text.ToString().Trim() == "")
            {
                DataTable _dtLastNbr = AP203Ctrl.GetSASetupGetLastNbr("AP", _strFistChar);
                _strLastNbr = _dtLastNbr.Rows[0]["LastNbr"].ToString();
                string strLastNbr = (Int16.Parse(_strLastNbr) + 1).ToString("000000");
                txtAdjNbr.Text = "AP" + _strFistChar + strLastNbr;
                _infoAPAdjust.AdjNbr = "AP" + _strFistChar + strLastNbr;
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
                    _infoAPAdjust.ConvertToAPAdjust(AP203Ctrl.GetAPAdjust(_infoAPAdjust.BranchID, _infoAPAdjust.AdjNbr).Rows[0]);
                    _SetButtomStatus();
                }
            }
            _BindGrid();
            _dtADoc.DefaultView.Sort = "Payment ASC";
            _dtNDoc.DefaultView.Sort = "Payment ASC";
        }

        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            pnldgv.Visible = false;
            pnl.Visible = true;
            _infoAPAdjust.ConvertToAPAdjust(_dtAPAdjust.Rows[e.RowIndex]);
            _BindPanel(_infoAPAdjust);
            txtVendID.Enabled = false;
            _BindADocGrid();
            _BindNDocGrid();
            //dtmFromDateLoad.Value = _infoAPAdjust.FromDateTmp;
            //dtmToDateLoad.Value = _infoAPAdjust.ToDateTmp;
            //txtVendIDLoad.Text = _infoAPAdjust.VendIDTmp;
            //dtmToDateLoad.Enabled = false;
            //dtmFromDateLoad.Enabled = false;
            //txtVendIDLoad.Enabled = false;
            //btnLoad.PerformClick();
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

        private void btnCanAndCopy_Click(object sender, EventArgs e)
        {            
            string vendid = txtVendID.Text.ToString().Trim();
            _GetPanel(-1);
            _SaveAPAdjust(-1);
            //_ResetPanelInput();
            _BindPanel(_infoAPAdjust);
            txtAdjNbr.Text = "";
            txtVendID.Enabled = true;
            cmbStatus.SelectedValue = 0;
            _SetButtomStatus();
        }
        
    }
}
