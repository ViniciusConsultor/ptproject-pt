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
        private string _strPro = "IN201";
        private string _strProductID, _strTranDescr;
        private int _intLineRef = 0;
        private float _fltQty = 0, _fltUnitCost = 0, _fltTotQty = 0, _fltTotalAmt = 0;
        string _strFistChar, _strLastNbr;
        float _fltCnvFact, _fltUnitRate;
        DataRow _dr0;

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
            txtProgID.Text = "IN201";
            _BindTxtProductList();
            _BindDataToCtrl();
            _SetInfoDefault();
            _SetCheckBox();
            _BindDocList();
            _BindDocDet("", "");
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
                if (dgvDocDet.RowCount == 0)
                    _intLineRef = 1;
                else
                    _intLineRef = Convert.ToInt32(_dtDocDet.Compute("max(LineRef)", string.Empty)) + 1;

                _AddRowToDocDetGrid();
                //       dgvDocDet.setr
                _ResetPanelInput();
                txtProductID.Focus();
            }
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
        private void txtProductID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //txtLotID.Focus();
                SendKeys.Send("{tab}");
                //        return true;
            }
        }
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
            ;
            if (txtProductID.Text.Trim() != "")
            {
                _dtProductInfo = ConnectDB.ExecuteReader("sp_GetProductInfoAndStatus", new String[] { "UserID", "ProductID" }, new Object[] { _strUser, txtProductID.Text });
                if (_dtProductInfo.Rows.Count > 0)
                {
                    if (cmbINUnit.Items.Count > 0)
                        for (int i = 0; i <= cmbINUnit.Items.Count; i++)
                            cmbINUnit.Items.RemoveAt(0);
                    _dr0 = _dtProductInfo.Rows[0];
                    _strProductID = _dr0["ProductID"].ToString();
                    _strTranDescr = _dr0["Descr"].ToString();
                    cmbINUnit.Items.Add(_dr0["FromUnit"].ToString());
                    cmbINUnit.Items.Add(_dr0["ToUnit"].ToString());
                    cmbINUnit.Text = _dr0["INUnit"].ToString();
                    _fltCnvFact = float.Parse(_dr0["Cnvfact"].ToString());
                    txtUnitCost.Text = "";
                    txtQty.Text = "";
                    txtTotalCost.Text = "";
                }
            }

        }
        private void dgvDocDet_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.RowIndex < dgvDocDet.RowCount)
            {
                txtProductID.Text = dgvDocDet.Rows[e.RowIndex].Cells["ProductID"].FormattedValue.ToString();
                cmbINUnit.Text = dgvDocDet.Rows[e.RowIndex].Cells["INUnit"].FormattedValue.ToString();
                txtLotID.Text = dgvDocDet.Rows[e.RowIndex].Cells["LotID"].FormattedValue.ToString();
                txtQty.Text = dgvDocDet.Rows[e.RowIndex].Cells["LineQty"].FormattedValue.ToString();
                txtUnitCost.Text = dgvDocDet.Rows[e.RowIndex].Cells["UnitCost"].FormattedValue.ToString();
                txtTotalCost.Text = dgvDocDet.Rows[e.RowIndex].Cells["TotalCost"].FormattedValue.ToString();
            }
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
            _DeleteRowDetOnDataBase();
            _DeleteRowDetOnGrid();
        }
        private void dgvDocDet_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDocDet.Focused == true)
            {
                if (dgvDocDet.CurrentRow != null)
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
        }
        private void txtProductID_Enter(object sender, EventArgs e)
        {
            if (cmbType.SelectedValue == null)
            {
                MessageBoxEx.Show("Hãy chọn loại chứng từ điều chỉnh !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbType.Focus();
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cmbType.SelectedValue != null)
            {
                DataTable _dtLastNbr = IN201Ctrl.GetSASetupGetLastNbr("IN", _strFistChar);
                _strLastNbr = _dtLastNbr.Rows[0]["LastNbr"].ToString();
                _SaveINDoc();
            }
            else
                MessageBoxEx.Show("Hãy nhập dữ liệu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            _BindDocList();
        }
        private void cmbINUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            string a = _dr0["FromUnit"].ToString();
            if (cmbINUnit.SelectedItem.ToString() == _dr0["FromUnit"].ToString())
                _fltUnitRate = float.Parse(_dr0["Cnvfact"].ToString());
            else
                _fltUnitRate = 1;
        }
        #region Set Chekbox
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
        #endregion

        #region Bind Data
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

            //cmbType
            DataTable dtType2 = new DataTable();
            dtType2.Columns.Add("TranType", typeof(string));
            dtType2.Columns.Add("Descr", typeof(string));
            dtType2.Rows.Add("NK", "Nhập Kho");
            dtType2.Rows.Add("XK", "Xuất Kho");
            cmbType.DataSource = dtType2;
            cmbType.DisplayMember = "Descr";
            cmbType.ValueMember = "TranType";
            cmbType.ColumnNames = "Descr";
            cmbType.ColumnWidths = "95";
            cmbType.LinkedColumnIndex = 1;

            //cmbDoctype
            DataTable dtType1 = new DataTable();
            dtType1.Columns.Add("TranType", typeof(string));
            dtType1.Columns.Add("Descr", typeof(string));
            dtType1.Rows.Add("AL", "Tất Cả");
            dtType1.Rows.Add("NK", "Nhập Kho");
            dtType1.Rows.Add("XK", "Xuất Kho");
            cmbDocType1.DataSource = dtType1;
            cmbDocType1.DisplayMember = "Descr";
            cmbDocType1.ValueMember = "TranType";
            cmbDocType1.ColumnNames = "Descr";
            cmbDocType1.ColumnWidths = "95";
            cmbDocType1.LinkedColumnIndex = 1;

            //cmbDoctype
            DataTable dtStatus = new DataTable();
            dtStatus.Columns.Add("Rlease", typeof(int));
            dtStatus.Columns.Add("Descr", typeof(string));
            dtStatus.Rows.Add(-1, "Đã Hủy");
            dtStatus.Rows.Add(0, "Đang Treo");
            dtStatus.Rows.Add(1, "Đã Cập Nhật");
            cmbStatus.DataSource = dtStatus;
            cmbStatus.DisplayMember = "Descr";
            cmbStatus.ValueMember = "Rlease";
            cmbStatus.ColumnNames = "Descr";
            cmbStatus.ColumnWidths = "95";
            cmbStatus.LinkedColumnIndex = 1;

        }
        private void _BindDocList()
        {
            string strTranType;
            if (cmbDocType1.SelectedItem == null)
                strTranType = "";
            else
                strTranType = cmbDocType1.SelectedValue.ToString();
            dgv.DataSource = IN201Ctrl.GetINDocListByPara("IN201", _strUser, strTranType, dtmFromDate.Value.Date, dtmToDate.Value.Date);
            dgv.ReadOnly = true;
            _SetDocListColumStyle();
            dgv.Refresh();
        }
        private void _BindDocDet(string BranchID, string DocNbr)
        {
            _dtDocDet = IN201Ctrl.GetINDocDetByDoc(BranchID, DocNbr, "IN");
            dgvDocDet.DataSource = _dtDocDet;
            dgvDocDet.ReadOnly = true;
            _SetDocDetColumStyle();
            dgvDocDet.Refresh();
        }
        #endregion

        private void _DeleteDocDet(int row)
        {
            string strBranhID = cmbBranchID.SelectedValue.ToString();
            string strDocNbr = txtDocNbr.Text;
            string strModule = "IN";
            string strLineRef = dgvDocDet.Rows[row].Cells["LineRef"].Value.ToString();
            IN201Ctrl.DeleteINDocDet(strBranhID, strDocNbr, strModule, strLineRef);
        }
        private void _DeleteRowDetOnDataBase()
        {
            Int32 _intTotalRow = dgvDocDet.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (_intTotalRow > 0)
            {
                for (int i = 0; i < _intTotalRow; i++)
                {
                    int _row = Int16.Parse(dgvDocDet.SelectedRows[i].Index.ToString());
                    _DeleteDocDet(_row);
                }

            }
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

            this.dgvDocDet.Columns["Cnvfact"].DefaultCellStyle.Format = "N0";
            this.dgvDocDet.Columns["UnitRate"].DefaultCellStyle.Format = "N0";
            this.dgvDocDet.Columns["DetailQty"].DefaultCellStyle.Format = "N0";

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
            dtmToDate.Value = _dtmWorkDate;
            cmbUser.SelectedValue = _strUser;
            cmbReason.SelectedValue = "DC";
            cmbStatus.Text = "None";

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
            switch (_strFistChar)
            {
                case "XK":
                    _r["InvtMult"] = -1;
                    break;
                default:
                    _r["InvtMult"] = 1;
                    break;
            }
            _r["Cnvfact"] = _fltCnvFact;
            _r["UnitRate"] = _fltUnitRate;
            _r["DetailQty"] = float.Parse(txtQty.Number) * _fltUnitRate;



            _dtDocDet.Rows.Add(_r);
            _dtDocDet.AcceptChanges();
            //dgvDocDet.DataSource = _dtDocDet;
            dgvDocDet.CurrentCell = dgvDocDet.Rows[dgvDocDet.RowCount - 1].Cells["ProductID"];
            dgvDocDet.FirstDisplayedScrollingRowIndex = dgvDocDet.RowCount - 1;
            dgvDocDet.Rows[dgvDocDet.RowCount - 1].Selected = true;
            // dgvDocDet.ColumnHeadersDefaultCellStyle.SelectionBackColor=


            //dgvDocDet.Refresh();

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

                switch (_strFistChar)
                {
                    case "XK":
                        _dtDocDet.Rows[_rUpd]["InvtMult"] = -1;
                        break;
                    default:
                        _dtDocDet.Rows[_rUpd]["InvtMult"] = 1;
                        break;
                }
                _dtDocDet.Rows[_rUpd]["Cnvfact"] = _fltCnvFact;
                _dtDocDet.Rows[_rUpd]["UnitRate"] = _fltUnitRate;
                _dtDocDet.Rows[_rUpd]["DetailQty"] = float.Parse(txtQty.Number) * _fltUnitRate;

                _dtDocDet.AcceptChanges();
            }
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
        private void _SetCheckBox()
        {
            chk1.Checked = true;
            chk2.Checked = true;
            chk3.Checked = true;
            chk4.Checked = true;
            chk5.Checked = true;
            chk6.Checked = true;
        }
        #region Save
        private void _SaveINDoc()
        {
            if (dgvDocDet.RowCount == 0)
                MessageBoxEx.Show("Đơn hàng không có chi tiết, không thể Save", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            else
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
                {
                    string strLastNbr = (Int16.Parse(_strLastNbr) + 1).ToString("000000");
                    txtDocNbr.Text = _strFistChar + strLastNbr;
                    _SaveSASetup("IN", _strFistChar, strLastNbr);
                }
                _SaveINDocDet();
                _BindDocList();
                _BinEditPanel(cmbBranchID.SelectedValue.ToString(), txtDocNbr.Text, "IN");
            }
        }
        private void _SaveINDocDet()
        {
            INDocDet infoDocDet = new INDocDet();
            //thong tin giong nhau cua cac dong
            infoDocDet.BranchID = cmbBranchID.SelectedValue.ToString();
            if (txtDocNbr.Text == "")
                infoDocDet.DocNbr = _strFistChar + (Int16.Parse(_strLastNbr) + 1).ToString("000000");
            else
                infoDocDet.DocNbr = txtDocNbr.Text;
            infoDocDet.Module = "IN";
            infoDocDet.TranType = _strFistChar;
            infoDocDet.WhID = cmbWhID.SelectedValue.ToString();
            infoDocDet.ToWhID = "";
            infoDocDet.TranDate = dtmDocDate.Value.Date;
            infoDocDet.FreeItem = false;
            infoDocDet.ObjID = "";
            infoDocDet.ShipperID = "";
            infoDocDet.RsID = cmbReason.SelectedValue.ToString();
            infoDocDet.Rlsed = 0;
            infoDocDet.SONbr = "";
            infoDocDet.PONbr = "";
            infoDocDet.Crtd_DateTime = DateTime.Now;
            infoDocDet.Crtd_Prog = _strPro;
            infoDocDet.Crtd_User = _strUser;
            infoDocDet.LUpd_DateTime = DateTime.Now;
            infoDocDet.LUpd_Prog = _strPro;
            infoDocDet.LUpd_User = _strUser;
            //thong tin rieng tung dong
            if (dgvDocDet != null)
            {
                for (int i = 0; i < dgvDocDet.Rows.Count; i++)
                {
                    infoDocDet.LotID = dgvDocDet.Rows[i].Cells["LotID"].FormattedValue.ToString().Trim();
                    infoDocDet.ProductID = dgvDocDet.Rows[i].Cells["ProductID"].FormattedValue.ToString().Trim();
                    infoDocDet.TranDesc = dgvDocDet.Rows[i].Cells["TranDesc"].FormattedValue.ToString().Trim();
                    infoDocDet.LineRef = dgvDocDet.Rows[i].Cells["LineRef"].FormattedValue.ToString().Trim();
                    infoDocDet.InvtMult = int.Parse(dgvDocDet.Rows[i].Cells["InvtMult"].FormattedValue.ToString());
                    infoDocDet.INUnit = dgvDocDet.Rows[i].Cells["INUnit"].FormattedValue.ToString().Trim();
                    infoDocDet.LineQty = float.Parse(dgvDocDet.Rows[i].Cells["LineQty"].FormattedValue.ToString());
                    infoDocDet.Cnvfact = float.Parse(dgvDocDet.Rows[i].Cells["Cnvfact"].FormattedValue.ToString());
                    infoDocDet.UnitRate = float.Parse(dgvDocDet.Rows[i].Cells["UnitRate"].FormattedValue.ToString());
                    infoDocDet.DetailQty = float.Parse(dgvDocDet.Rows[i].Cells["DetailQty"].FormattedValue.ToString());
                    infoDocDet.UnitCost = float.Parse(dgvDocDet.Rows[i].Cells["UnitCost"].FormattedValue.ToString());
                    infoDocDet.TotalCost = float.Parse(dgvDocDet.Rows[i].Cells["TotalCost"].FormattedValue.ToString());
                    int kq;
                    kq = IN201Ctrl.SaveINDocDet(infoDocDet);
                }

            }
        }
        private void _SaveSASetup(string strModule, string strFistChar, string strLastNbr)
        {
            SASetup _sa = new SASetup();
            _sa.Module = strModule;
            _sa.FistChar = strFistChar;
            _sa.LastNbr = strLastNbr;
            int kq;
            if (_sa.Module != "" && _sa.FistChar != "")
                kq = IN201Ctrl.SaveSASetup(_sa);
        }
        #endregion

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _intLineRef = 0;
            txtDocNbr.Text = "";
            cmbType.Text = "";
            txtDocDescr.Text = "";
            txtTotalAmt.Text = "";
            txtTotalQty.Text = "";
            _ResetPanelInput();
            cmbType.Focus();
            cmbStatus.Text = "None";
            _dtDocDet.Clear();
            _dtDocDet.AcceptChanges();
        }

        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.RowIndex < dgv.RowCount)
            {
                pnldgv.Visible = false;
                pnl.Dock = DockStyle.Fill;
                pnldgv.Dock = DockStyle.None;
                pnl.Visible = true;
                pnldgv.Visible = false;
                btnBack.Enabled = true;
                btnSave.Enabled = true;
                btnPrint.Enabled = true;

                string strBran = dgv.Rows[e.RowIndex].Cells["BranchID"].FormattedValue.ToString();
                string strDoc = dgv.Rows[e.RowIndex].Cells["DocNbr"].FormattedValue.ToString();
                _BinEditPanel(strBran, strDoc, "IN");
                _SetButtomStatus();
            }
        }

        private void _BinEditPanel(string BranchID, string DocNbr, string Module)
        {
            DataTable _dtDocEdit = new DataTable();
            _dtDocEdit = IN201Ctrl.GetINDocByKey(BranchID, DocNbr, "IN");

            string strBran = _dtDocEdit.Rows[0]["BranchID"].ToString();
            string strDoc = _dtDocEdit.Rows[0]["DocNbr"].ToString();

            cmbBranchID.SelectedValue = strBran;
            txtDocNbr.Text = strDoc;
           
            cmbStatus.SelectedValue = int.Parse(_dtDocEdit.Rows[0]["Rlsed"].ToString());
            
            dtmDocDate.Value = DateTime.Parse(_dtDocEdit.Rows[0]["DocDate"].ToString());
            txtDocDescr.Text = _dtDocEdit.Rows[0]["DocDescr"].ToString();
            cmbWhID.SelectedItem = _dtDocEdit.Rows[0]["WhID"].ToString();
            if (_dtDocEdit.Rows[0]["TranType"].ToString() == "NK")
                cmbType.SelectedValue = "NK";
            else
                cmbType.SelectedValue = "XK";
            cmbReason.SelectedValue = _dtDocEdit.Rows[0]["RsID"].ToString();
            txtTotalQty.Text = _dtDocEdit.Rows[0]["TotQty"].ToString();
            txtTotalAmt.Text = _dtDocEdit.Rows[0]["TotAmt"].ToString();
            _BindDocDet(strBran, strDoc);

        }

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            _strFistChar = cmbType.SelectedValue.ToString();
        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            _SetButtomStatus();
        }
        private void _SetButtomStatus()
        {
            if (cmbStatus.SelectedValue.ToString() == "0")
            {
                btnRelease.Enabled = true;
                btnDestroy.Enabled = false;
                btnCanAndCopy.Enabled = false;
                btnDelete.Enabled = true;
                pnl.Enabled = true;
            }
            else if (cmbStatus.SelectedValue.ToString() == "1")
            {
                btnRelease.Enabled = false;
                btnDestroy.Enabled = true;
                btnCanAndCopy.Enabled = true;
                btnDelete.Enabled = false;
                pnl.Enabled = false;
            }
            else if (cmbStatus.SelectedValue.ToString() == "-1")
            {
                btnRelease.Enabled = false;
                btnDestroy.Enabled = false;
                btnCanAndCopy.Enabled = false;
                btnDelete.Enabled = false;
                pnl.Enabled = false;
            }
        }

        private void btnRelease_Click(object sender, EventArgs e)
        {
            if (dgvDocDet.RowCount == 0)
                MessageBoxEx.Show("Đơn hàng không có chi tiết, không thể Cập nhật", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            else
            {
                INDoc _infoDoc = new INDoc();
                _infoDoc.BranchID = cmbBranchID.SelectedValue.ToString();

                if (txtDocNbr.Text != "")
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
                _infoDoc.Rlsed = 1;
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
                _BindDocList();
                _BinEditPanel(cmbBranchID.SelectedValue.ToString(), txtDocNbr.Text, "IN");
            }
        }

        private void btnDestroy_Click(object sender, EventArgs e)
        {
            INDoc _infoDoc = new INDoc();
            _infoDoc.BranchID = cmbBranchID.SelectedValue.ToString();

            if (txtDocNbr.Text != "")
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
            _infoDoc.Rlsed = -1;
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
            _BindDocList();
            _BinEditPanel(cmbBranchID.SelectedValue.ToString(), txtDocNbr.Text, "IN");

        }

        private void txtDocNbr_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

    }
}
