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
        private string _strFistChar = "CC", _strLastNbr;
        public AP203()
        {
            InitializeComponent();
        }

        private void AP203_Load(object sender, EventArgs e)
        {
           // _LoadData();
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

            //cmbAdjAcct.DataSource = _dtCAAccount;
            //cmbAdjAcct.DisplayMember = "Acct";
            //cmbAdjAcct.ValueMember = "Acct";
            //cmbAdjAcct.ColumnNames = "Acct,AcctName";
            //cmbAdjAcct.ColumnWidths = "100,150";

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

            //txtVendIDLoad.DataSource = _dtVend;
            //txtVendIDLoad.ColumnWidths = "100,250";

        }
        private void _LoadData()
        {
            _dtCAAccount = AP203Ctrl.GetCAAccount();
            _dtSAUser = AP203Ctrl.GetSAUser();
            _dtSIBranch = AP203Ctrl.GetSIBranch();
            _dtVend = AP203Ctrl.GetVendID();
        }
        private void _BindADocGrid(string brandid, string AdjNbr,string vendid,int Release )
        {
            _dtADoc = AP203Ctrl.LoadADoc(brandid, AdjNbr, vendid, Release);
            _dtADocTmp = _dtADoc.Copy();
            dgvADocList.DataSource = _dtADoc;

            //==================
            if (dgvADocList.Columns[0].Name != "")
            {
                DataGridViewCheckBoxColumn checkboxColumn = new DataGridViewCheckBoxColumn();
                checkboxColumn.Width = 30;
                checkboxColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvADocList.Columns.Insert(0, checkboxColumn);

                // add checkbox header            
                Rectangle rect = dgvADocList.GetCellDisplayRectangle(0, -1, true);
                // set checkbox header to center of header cell. +1 pixel to position correctly.
                rect.X = rect.Location.X + (rect.Width / 4);

                CheckBox checkboxHeader = new CheckBox();
                checkboxHeader.Name = "checkboxHeaderADoc";
                checkboxHeader.Size = new Size(18, 18);
                checkboxHeader.Location = rect.Location;
                checkboxHeader.CheckedChanged += new EventHandler(checkboxHeaderADoc_CheckedChanged);

                dgvADocList.Controls.Add(checkboxHeader);
            }
            //==================

            for (int i = 0; i < dgvADocList.Columns.Count; i++)
                dgvADocList.Columns[i].ReadOnly = true;
            dgvADocList.Columns["Payment"].ReadOnly = false;
            dgvADocList.Columns[0].ReadOnly = false;
            //==================

            for (int i = 0; i < dgvADocList.RowCount; i++)
            {
                if (dgvADocList.Rows[i].Cells["Docbal"].Value.ToString() == "0")
                    dgvADocList[0, i].Value = true;
                else
                    dgvADocList[0, i].Value = false;
            }
        }
        private void checkboxHeaderADoc_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvADocList.RowCount; i++)
            {
                dgvADocList[0, i].Value = ((CheckBox)dgvADocList.Controls.Find("checkboxHeaderADoc", true)[0]).Checked;
                if (double.Parse(dgvADocList.Rows[i].Cells["Docbal"].Value.ToString()) != 0)
                {
                    if ((bool)dgvADocList.Rows[i].Cells[0].FormattedValue)
                    {
                        dgvADocList.Rows[i].Cells["Payment"].Value = _dtADocTmp.Rows[i]["Docbal"].ToString();
                        dgvADocList.Rows[i].Cells["Docbal"].Value = 0;
                    }
                    else
                    {
                        dgvADocList.Rows[i].Cells["Payment"].Value = 0;
                        dgvADocList.Rows[i].Cells["Docbal"].Value = _dtADocTmp.Rows[i]["Docbal"].ToString();
                    }
                }
            }
            dgvADocList.EndEdit();
        }
        private void _BindNDocGrid(string brandid, string AdjNbr, string vendid, int Release)
        {
            _dtNDoc = AP203Ctrl.LoadNDoc(brandid, AdjNbr, vendid, Release);
            _dtNDocTmp = _dtNDoc.Copy();
            dgvADocList.DataSource = _dtADoc;

            //==================
            if (dgvNDocList.Columns[0].Name != "")
            {
                DataGridViewCheckBoxColumn checkboxColumn = new DataGridViewCheckBoxColumn();
                checkboxColumn.Width = 30;
                checkboxColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvNDocList.Columns.Insert(0, checkboxColumn);

                // add checkbox header            
                Rectangle rect = dgvNDocList.GetCellDisplayRectangle(0, -1, true);
                // set checkbox header to center of header cell. +1 pixel to position correctly.
                rect.X = rect.Location.X + (rect.Width / 4);

                CheckBox checkboxHeader = new CheckBox();
                checkboxHeader.Name = "checkboxHeaderADoc";
                checkboxHeader.Size = new Size(18, 18);
                checkboxHeader.Location = rect.Location;
                checkboxHeader.CheckedChanged += new EventHandler(checkboxHeaderNDoc_CheckedChanged);

                dgvNDocList.Controls.Add(checkboxHeader);
            }
            //==================

            for (int i = 0; i < dgvNDocList.Columns.Count; i++)
                dgvNDocList.Columns[i].ReadOnly = true;
            dgvNDocList.Columns["Payment"].ReadOnly = false;
            dgvNDocList.Columns[0].ReadOnly = false;
            //==================

            for (int i = 0; i < dgvNDocList.RowCount; i++)
            {
                if (dgvNDocList.Rows[i].Cells["Docbal"].Value.ToString() == "0")
                    dgvNDocList[0, i].Value = true;
                else
                    dgvNDocList[0, i].Value = false;
            }
        }
        private void checkboxHeaderNDoc_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvADocList.RowCount; i++)
            {
                dgvADocList[0, i].Value = ((CheckBox)dgvADocList.Controls.Find("checkboxHeaderADoc", true)[0]).Checked;
                if (double.Parse(dgvADocList.Rows[i].Cells["Docbal"].Value.ToString()) != 0)
                {
                    if ((bool)dgvADocList.Rows[i].Cells[0].FormattedValue)
                    {
                        dgvADocList.Rows[i].Cells["Payment"].Value = _dtADocTmp.Rows[i]["Docbal"].ToString();
                        dgvADocList.Rows[i].Cells["Docbal"].Value = 0;
                    }
                    else
                    {
                        dgvADocList.Rows[i].Cells["Payment"].Value = 0;
                        dgvADocList.Rows[i].Cells["Docbal"].Value = _dtADocTmp.Rows[i]["Docbal"].ToString();
                    }
                }
            }
            dgvNDocList.EndEdit();
        }
    }
}
