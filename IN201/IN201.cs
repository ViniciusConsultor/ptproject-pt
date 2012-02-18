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

namespace IN201
{
    public partial class IN201 : PT.Master.GridEditIn
    {
        private string _strUser = PT.Helper.Globals.PTUserName;
        private DateTime _dtmWorkDate = PT.Helper.Globals.PTWorkingDate;
        private DataTable _dtUserList = new DataTable();
        private DataTable _dtBranchList = new DataTable();
        private DataTable _dtWhList = new DataTable();
        private DataTable _dtToWhList = new DataTable();
        private DataTable _dtReason = new DataTable();
        private DataTable _dtProductList = new DataTable();
        private DataTable _dtProductInfo = new DataTable();
        private DataTable _dtDocDet = new DataTable();
        private string _strPro = "IN204";
        private string _strProductID, _strTranDescr;
        private int _intLineRef = 0;
        private float _fltQty = 0, _fltUnitCost = 0, _fltTotQty = 0, _fltTotalAmt = 0;

        public IN201()
        {
            InitializeComponent();
        }
        protected override bool ProcessCmdKey(ref System.Windows.Forms.Message msg, System.Windows.Forms.Keys keyData)
        {
            if (txtProductID.Focused == true || txtLotID.Focused == true || cmbINUnit.Focused == true || txtQty.Focused == true
                || txtUnitCost.Focused == true || txtTotalCost.Focused == true)
                if (msg.WParam.ToInt32() == (int)Keys.Enter)
                {
                    SendKeys.Send("{tab}");
                    return true;
                }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _BindTxtProductList();
            _BindDataToCtrl();
            _SetInfoDefault();
            _SetCheckBox();
            _BindDocList();
            _BindDocDet();
        }

        private void _BindTxtProductList()
        {
            _dtProductList = ConnectDB.ExecuteReader("sp_GetProductAll");
            txtProductID.DataSource = _dtProductList;
        }
        private void _BindDataToCtrl()
        {
            _GetTableData();
            //cmbUser
            cmbUser.DataSource = _dtUserList;
            cmbUser.DisplayMember = "UserID";
            cmbUser.ValueMember = "UserID";            
            cmbUser.ColumnNames = "UserID";
            cmbUser.ColumnWidths = "100";
            cmbUser.LinkedColumnIndex = 1;

            //cmbBranch
            cmbBranchID.DataSource = _dtBranchList;
            cmbBranchID.DisplayMember = "BranchID";
            cmbBranchID.ValueMember = "BranchID";
            cmbBranchID.ColumnNames = "BranchID,BranchName";
            cmbBranchID.ColumnWidths = "95,350";
            cmbBranchID.LinkedColumnIndex = 1;
            //cmbWhID
            cmbWhID.DataSource = _dtWhList;
            cmbWhID.DisplayMember = "WhID";
            cmbWhID.ValueMember = "WhID";
            cmbWhID.ColumnNames = "WhID,Name";
            cmbWhID.ColumnWidths = "95,150";
            cmbWhID.LinkedColumnIndex = 1;

            //cmbReason
            cmbReason.DataSource = _dtReason;
            cmbReason.DisplayMember = "RsID";
            cmbReason.ValueMember = "RsID";
            cmbReason.ColumnNames = "RsID,Descr";
            cmbReason.ColumnWidths = "95,150";
            cmbReason.LinkedColumnIndex = 1;

            //cmbDoctype
            cmbType.Items.Add("NK-Nhập");
            cmbType.Items.Add("XK-Xuất");

            //cmbDoctype
            cmbDocType1.Items.Add("NK-Nhập");
            cmbDocType1.Items.Add("XK-Xuất");

        }
        private void _BindDocList()
        {
            dgv.DataSource = ConnectDB.GetAll("INDoc");
            dgv.ReadOnly = true;
            _SetDocListColumStyle();
            dgv.Refresh();
        }
        private void _BindDocDet()
        {
            _dtDocDet = ConnectDB.GetAll("INDocDet");
            dgvDocDet.DataSource = _dtDocDet;
            dgvDocDet.ReadOnly = true;
            _SetDocDetColumStyle();
            dgvDocDet.Refresh();
        }

        private void _GetTableData()
        {
            _dtUserList = ConnectDB.GetAll("SAUser");
            _dtBranchList = ConnectDB.GetAll("SIBranch");
            _dtWhList = ConnectDB.GetAll("INWarehouse");
            _dtToWhList = ConnectDB.GetAll("INWarehouse");
            _dtReason = ConnectDB.GetAll("INReason");
        }
        private void _SetDocDetColumStyle()
        {
            dgvDocDet.Columns["BranchID"].Visible = false;
            dgvDocDet.Columns["DocNbr"].Visible = false;
            dgvDocDet.Columns["Module"].Visible = false;
            dgvDocDet.Columns["LineRef"].Visible = false;
            dgvDocDet.Columns["TranType"].Visible = false;
            dgvDocDet.Columns["TranDate"].Visible = false;
            dgvDocDet.Columns["WhID"].Visible = false;
            dgvDocDet.Columns["ToWhID"].Visible = false;
            dgvDocDet.Columns["FreeItem"].Visible = false;
            //dgvDocDet.Columns["ProductID"].Visible = false;
            //dgvDocDet.Columns["TranDesc"].Visible = false;
            //dgvDocDet.Columns["LotID"].Visible = false;
            //dgvDocDet.Columns["INUnit"].Visible = false;
            //dgvDocDet.Columns["LineQty"].Visible = false;
            //dgvDocDet.Columns["UnitCost"].Visible = false;
            //dgvDocDet.Columns["TotalCost"].Visible = false;
            dgvDocDet.Columns["InvtMult"].Visible = false;
            dgvDocDet.Columns["ObjID"].Visible = false;
            dgvDocDet.Columns["ShipperID"].Visible = false;
            dgvDocDet.Columns["RsID"].Visible = false;
            dgvDocDet.Columns["Rlsed"].Visible = false;
            dgvDocDet.Columns["SONbr"].Visible = false;
            dgvDocDet.Columns["PONbr"].Visible = false;
            dgvDocDet.Columns["Cnvfact"].Visible = false;
            dgvDocDet.Columns["UnitRate"].Visible = false;
            dgvDocDet.Columns["DetailQty"].Visible = false;
            dgvDocDet.Columns["Crtd_DateTime"].Visible = false;
            dgvDocDet.Columns["Crtd_Prog"].Visible = false;
            dgvDocDet.Columns["Crtd_User"].Visible = false;
            dgvDocDet.Columns["LUpd_DateTime"].Visible = false;
            dgvDocDet.Columns["LUpd_Prog"].Visible = false;
            dgvDocDet.Columns["LUpd_User"].Visible = false;

            dgvDocDet.Columns["TranDesc"].Width = 200;
            dgvDocDet.Columns["LineQty"].Width = 70;
            dgvDocDet.Columns["UnitCost"].Width = 70;
            dgvDocDet.Columns["INUnit"].Width = 70;
            dgvDocDet.Columns["LotID"].Width = 70;

            this.dgvDocDet.Columns["LineQty"].DefaultCellStyle.Format = "N0";
            this.dgvDocDet.Columns["LineQty"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.dgvDocDet.Columns["UnitCost"].DefaultCellStyle.Format = "N0";
            this.dgvDocDet.Columns["UnitCost"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.dgvDocDet.Columns["TotalCost"].DefaultCellStyle.Format = "N0";
            this.dgvDocDet.Columns["TotalCost"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

        }
        private void _SetDocListColumStyle()
        {
            //dgv.Columns["BranchID"].Visible = false;
            //dgv.Columns["DocNbr"].Visible = false;
            dgv.Columns["Module"].Visible = false;
            dgv.Columns["TranType"].Visible = false;
            //dgv.Columns["TotQty"].Visible = false;
            //dgv.Columns["WhID"].Visible = false;
            dgv.Columns["ToWhID"].Visible = false;
            //dgv.Columns["TotAmt"].Visible = false;
            //dgv.Columns["DocDate"].Visible = false;
            //dgv.Columns["DocDescr"].Visible = false;
            dgv.Columns["RsID"].Visible = false;
            //dgv.Columns["Rlsed"].Visible = false;
            //dgv.Columns["Note"].Visible = false;
            dgv.Columns["Crtd_DateTime"].Visible = false;
            dgv.Columns["Crtd_Prog"].Visible = false;
            dgv.Columns["Crtd_User"].Visible = false;
            dgv.Columns["LUpd_DateTime"].Visible = false;
            dgv.Columns["LUpd_Prog"].Visible = false;
            dgv.Columns["LUpd_User"].Visible = false;

            dgv.Columns["BranchID"].Width = 70;
            dgv.Columns["DocNbr"].Width = 70;
            dgv.Columns["WhID"].Width = 70;
            dgv.Columns["DocDescr"].Width = 200;
            dgv.Columns["RsID"].Width = 70;

            dgv.Columns["TotQty"].DefaultCellStyle.Format = "N0";
            dgv.Columns["TotQty"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgv.Columns["TotAmt"].DefaultCellStyle.Format = "N0";
            dgv.Columns["TotAmt"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgv.Columns["Rlsed"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


        }
        private void _SetInfoDefault()
        {
            dtmDocDate.Value = _dtmWorkDate;
            dtmFromDate.Value = _dtmWorkDate;
            dmtToDate.Value = _dtmWorkDate;
            cmbUser.SelectedValue = _strUser;
            cmbReason.SelectedValue = "DC";
            txtStatus.Text = "None";
        }
        private void _ResetPanelInput()
        {
            txtProductID.Text = "";
            //txtLotID.Text = "";
            txtQty.Text = "";
            txtUnitCost.Text = "";
            txtTotalCost.Text = "";
            cmbINUnit.Text = "";
        }

        private void btnAddRow_Click(object sender, EventArgs e)
        {
            if (txtProductID.Text.Trim() == "")
            {
                MessageBoxEx.Show("Hãy nhập Mã sản phẩm", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtProductID.Focus();
            }
            else if (txtQty.Text.Trim() == "")
            {
                MessageBoxEx.Show("Hãy nhập Số lượng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtQty.Focus();
            }
            else
            {
                _intLineRef += 1;
                _AddRowToDocDetGrid();
                //       dgvDocDet.setr
                _ResetPanelInput();
                txtProductID.Focus();
            }
        }
        private void _AddRowToDocDetGrid()
        {
            DataRow _r = _dtDocDet.NewRow();

            _r["LineRef"] = _intLineRef.ToString("00000");
            _r["ProductID"] = _strProductID;
            _r["TranDesc"] = _strTranDescr;
            _r["LotID"] = txtLotID.Text;
            _r["INUnit"] = cmbINUnit.SelectedItem.ToString();
            _r["LineQty"] = float.Parse(txtQty.Number);
            _r["UnitCost"] = float.Parse(txtUnitCost.Number);
            _r["TotalCost"] = float.Parse(txtTotalCost.Number);

            _dtDocDet.Rows.Add(_r);
            _dtDocDet.AcceptChanges();
            //dgvDocDet.DataSource = _dtDocDet;
            dgvDocDet.CurrentCell = dgvDocDet.Rows[dgvDocDet.RowCount - 1].Cells["ProductID"];
            dgvDocDet.FirstDisplayedScrollingRowIndex = dgvDocDet.RowCount - 1;
            dgvDocDet.Rows[dgvDocDet.RowCount - 1].Selected = true;
            // dgvDocDet.ColumnHeadersDefaultCellStyle.SelectionBackColor=


            //dgvDocDet.Refresh();

        }
        private void btnAddRow_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnAdd.RaiseClick();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _UpdateRowDocDetGrid();
        }
        private void _UpdateRowDocDetGrid()
        {
            int _rUpd;
            if (dgvDocDet.RowCount > 0 && txtProductID.Text.Trim() != "" && txtQty.Text.Trim() != "")
            {
                _rUpd = dgvDocDet.CurrentRow.Index;
                _dtDocDet.Rows[_rUpd]["ProductID"] = _strProductID;
                _dtDocDet.Rows[_rUpd]["TranDesc"] = _strTranDescr;
                _dtDocDet.Rows[_rUpd]["LotID"] = txtLotID.Text;
                _dtDocDet.Rows[_rUpd]["INUnit"] = cmbINUnit.SelectedItem.ToString();
                _dtDocDet.Rows[_rUpd]["LineQty"] = float.Parse(txtQty.Number);
                _dtDocDet.Rows[_rUpd]["UnitCost"] = float.Parse(txtUnitCost.Number);
                _dtDocDet.Rows[_rUpd]["TotalCost"] = float.Parse(txtTotalCost.Number);

                _dtDocDet.AcceptChanges();
            }
        }



        private void txtProductID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //txtLotID.Focus();
                SendKeys.Send("{tab}");
                //        return true;
            }
        }

        //Tinh toan so lieu nhap
        private void txtQty_Leave(object sender, EventArgs e)
        {
            if (txtQty.Text.Trim() != "")
                _fltQty = float.Parse(txtQty.Number);
            else
                _fltQty = 0;

            if (txtUnitCost.Text.Trim() != "")
                _fltUnitCost = float.Parse(txtUnitCost.Number);
            else
                _fltUnitCost = 0;
            txtTotalCost.Text = (_fltQty * _fltUnitCost).ToString();
        }
        private void txtUnitCost_Leave(object sender, EventArgs e)
        {
            if (txtQty.Text.Trim() != "")
                _fltQty = float.Parse(txtQty.Number);
            else
                _fltQty = 0;

            if (txtUnitCost.Text.Trim() != "")
                _fltUnitCost = float.Parse(txtUnitCost.Number);
            else
                _fltUnitCost = 0;
            txtTotalCost.Text = (_fltQty * _fltUnitCost).ToString();
        }
        private void txtTotalCost_Leave(object sender, EventArgs e)
        {
            if (txtQty.Text.Trim() != "")
                txtUnitCost.Text = (float.Parse(txtTotalCost.Number) / float.Parse(txtQty.Number)).ToString();
            //if (txtUnitCost.Text.Trim() != "")
            //    _fltUnitCost = float.Parse(txtUnitCost.Number);
        }

        private void txtProductID_TextChanged(object sender, EventArgs e)
        {
            if (txtProductID.Text.Trim() != "")
            {
                _dtProductInfo = ConnectDB.ExecuteReader("sp_GetProductInfoAndStatus", new String[] { "UserID", "ProductID" }, new Object[] { _strUser, txtProductID.Text });
                if (_dtProductInfo.Rows.Count > 0)
                {
                    if (cmbINUnit.Items.Count > 0)
                        for (int i = 0; i <= cmbINUnit.Items.Count; i++)
                            cmbINUnit.Items.RemoveAt(0);
                    DataRow _dr = _dtProductInfo.Rows[0];
                    _strProductID = _dr["ProductID"].ToString();
                    _strTranDescr = _dr["Descr"].ToString();
                    cmbINUnit.Items.Add(_dr["FromUnit"].ToString());
                    cmbINUnit.Items.Add(_dr["ToUnit"].ToString());
                    cmbINUnit.Text = _dr["INUnit"].ToString();
                    txtUnitCost.Text = "";
                    txtQty.Text = "";
                    txtTotalCost.Text = "";
                }
            }

        }

        private void dgvDocDet_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtProductID.Text = dgvDocDet.Rows[e.RowIndex].Cells["ProductID"].FormattedValue.ToString();
            cmbINUnit.Text = dgvDocDet.Rows[e.RowIndex].Cells["INUnit"].FormattedValue.ToString();
            txtLotID.Text = dgvDocDet.Rows[e.RowIndex].Cells["LotID"].FormattedValue.ToString();
            txtQty.Text = dgvDocDet.Rows[e.RowIndex].Cells["LineQty"].FormattedValue.ToString();
            txtUnitCost.Text = dgvDocDet.Rows[e.RowIndex].Cells["UnitCost"].FormattedValue.ToString();
            txtTotalCost.Text = dgvDocDet.Rows[e.RowIndex].Cells["TotalCost"].FormattedValue.ToString();
        }

        private void dgvDocDet_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //tăng giá trị header
            _fltTotQty = 0;
            _fltTotalAmt = 0;
            if (dgvDocDet.RowCount > 0)
            {
                for (int i = 0; i < dgvDocDet.RowCount; i++)
                {
                    float tempQty = float.Parse(dgvDocDet.Rows[i].Cells["LineQty"].FormattedValue.ToString());
                    float temAmt = float.Parse(dgvDocDet.Rows[i].Cells["TotalCost"].FormattedValue.ToString());
                    _fltTotQty = _fltTotQty + tempQty;
                    _fltTotalAmt = _fltTotalAmt + temAmt;
                }
                txtTotalQty.Text = _fltTotQty.ToString();
                txtTotalAmt.Text = _fltTotalAmt.ToString();
            }
        }

        private void btnDelRow_Click(object sender, EventArgs e)
        {
            _DeleteRowDetOnGrid();
        }
        private void _DeleteRowDetOnGrid()
        {
            if (dgvDocDet.SelectedRows.Count == 0)
                MessageBoxEx.Show("Hãy chọn dòng cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                foreach (DataGridViewRow row in dgvDocDet.SelectedRows)
                {
                    dgvDocDet.Rows.Remove(row);
                }
                _ResetPanelInput();
            }
        }

        private void dgvDocDet_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDocDet.Focused == true)
            {
                int _rSelect = dgvDocDet.CurrentRow.Index;
                txtProductID.Text = dgvDocDet.Rows[_rSelect].Cells["ProductID"].FormattedValue.ToString();
                cmbINUnit.Text = dgvDocDet.Rows[_rSelect].Cells["INUnit"].FormattedValue.ToString();
                txtLotID.Text = dgvDocDet.Rows[_rSelect].Cells["LotID"].FormattedValue.ToString();
                txtQty.Text = dgvDocDet.Rows[_rSelect].Cells["LineQty"].FormattedValue.ToString();
                txtUnitCost.Text = dgvDocDet.Rows[_rSelect].Cells["UnitCost"].FormattedValue.ToString();
                txtTotalCost.Text = dgvDocDet.Rows[_rSelect].Cells["TotalCost"].FormattedValue.ToString();
            }
        }

        private void _SetCheckBox()
        {
            chk1.Checked = true;
            chk2.Checked = true;
            chk3.Checked = true;
            chk4.Checked = true;
            chk5.Checked = true;
            chk6.Checked = true;
        }
        private void chk1_CheckedChanged(object sender, EventArgs e)
        {
            if (chk1.Checked == false)
                txtProductID.TabIndex = 1002;
            else
                txtProductID.TabIndex = 12;
        }
        private void chk2_CheckedChanged(object sender, EventArgs e)
        {
            if (chk2.Checked == false)
                txtLotID.TabIndex = 1003;
            else
                txtLotID.TabIndex = 13;
        }
        private void chk3_CheckedChanged(object sender, EventArgs e)
        {
            if (chk3.Checked == false)
                cmbINUnit.TabIndex = 1004;
            else
                cmbINUnit.TabIndex = 14;
        }
        private void chk4_CheckedChanged(object sender, EventArgs e)
        {
            if (chk4.Checked == false)
                txtQty.TabIndex = 1005;
            else
                cmbINUnit.TabIndex = 15;
        }
        private void chk5_CheckedChanged(object sender, EventArgs e)
        {
            if (chk5.Checked == false)
                txtUnitCost.TabIndex = 1006;
            else
                txtUnitCost.TabIndex = 16;
        }
        private void chk6_CheckedChanged(object sender, EventArgs e)
        {
            if (chk6.Checked == false)
                txtTotalCost.TabIndex = 1007;
            else
                txtTotalCost.TabIndex = 17;
        }

        private void txtProductID_Enter(object sender, EventArgs e)
        {
            if (cmbType.SelectedItem == null)
            {
                MessageBoxEx.Show("Hãy chọn loại chứng từ điều chỉnh !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbType.Focus();
            }
        }

        string _strFistChar, _strLastNbr;
        private void _SaveINDoc()
        {
            INDoc _infoDoc = new INDoc();
            _infoDoc.BranchID = cmbBranchID.SelectedValue.ToString();

            if (txtDocNbr.Text == "")
                _infoDoc.DocNbr = _strFistChar + (Int16.Parse(_strLastNbr) + 1).ToString("000000");
            else
                _infoDoc.DocNbr = txtDocNbr.Text;

            _infoDoc.Module = "IN";
            _infoDoc.TranType = _strFistChar;
            _infoDoc.TotQty = float.Parse(txtTotalQty.Number);
            _infoDoc.WhID = cmbWhID.SelectedValue.ToString();
            _infoDoc.ToWhID = "";
            _infoDoc.TotAmt = float.Parse(txtTotalAmt.Number);
            _infoDoc.DocDate = dtmDocDate.Value.Date;
            _infoDoc.DocDescr = txtDocDescr.Text;
            _infoDoc.RsID = cmbReason.SelectedValue.ToString();
            _infoDoc.Rlsed = 0;
            _infoDoc.Note = "";
            _infoDoc.Crtd_DateTime = DateTime.Now;
            _infoDoc.Crtd_Prog = _strPro;
            _infoDoc.Crtd_User = _strUser;
            _infoDoc.LUpd_DateTime = DateTime.Now;
            _infoDoc.LUpd_Prog = _strPro;
            _infoDoc.LUpd_User = _strUser;
            int kq;
            if (_infoDoc.DocNbr != "" && _infoDoc.DocNbr != "")
                kq = IN201Ctrl.SaveINDoc(_infoDoc);
            if (txtDocNbr.Text == "")
                txtDocNbr.Text = _strFistChar + (Int16.Parse(_strLastNbr) + 1).ToString("000000");
        }
        private void _SaveSASetup()
        {
            SASetup _sa = new SASetup();
            _sa.Module = "IN";
            _sa.FistChar = _strFistChar;
            _sa.LastNbr = (Int16.Parse(_strLastNbr) + 1).ToString("000000");
            int kq;
            if (_sa.Module != "" && _sa.FistChar != "")
                kq = IN201Ctrl.SaveSASetup(_sa);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cmbType.SelectedItem != null)
            {
                _strFistChar = cmbType.SelectedItem.ToString().Substring(0, 2);
                DataTable _dtLastNbr = IN201Ctrl.GetSASetupGetLastNbr("IN", _strFistChar);
                _strLastNbr = _dtLastNbr.Rows[0]["LastNbr"].ToString();
                _SaveINDoc();
                if (txtDocNbr.Text == "")
                    _SaveSASetup();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            _BindDocList();
        }



    }
}
