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
        private string _strPro = "IN204";

        public IN201()
        {
            InitializeComponent();
        }
        //protected override bool ProcessCmdKey(ref System.Windows.Forms.Message msg, System.Windows.Forms.Keys keyData)
        //{
        //    if (msg.WParam.ToInt32() == (int)Keys.Enter)
        //    {
        //        SendKeys.Send("{tab}");
        //        return true;
        //    }
        //    return base.ProcessCmdKey(ref msg, keyData);
        //}

        private void Form1_Load(object sender, EventArgs e)
        {
            _BindTxtProductList();
            _BindDataToCtrl();
            _SetInfoDefault();
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
            cmbUser.DisplayMember = "UserName";
            cmbUser.ValueMember = "UserID";

            //cmbUser
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

        }
        private void _BindDocList()
        {
            dgv.DataSource = ConnectDB.GetAll("INDoc");
            dgv.ReadOnly = true;
            _SetDocListVisible();
            dgv.Refresh();
        }
        private void _BindDocDet()
        {
            dgvDocDet.DataSource = ConnectDB.GetAll("INDocDet");
            dgvDocDet.ReadOnly = true;
            _SetDocDetVisible();
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
        private void _SetDocDetVisible()
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

        }
        private void _SetDocListVisible()
        {
            //dgv.Columns["BranchID"].Visible = false;
            //dgv.Columns["DocNbr"].Visible = false;
            dgv.Columns["Module"].Visible = false;
            dgv.Columns["TranType"].Visible = false;
            //dgv.Columns["TotQty"].Visible = false;
            //dgv.Columns["WhID"].Visible = false;
            //dgv.Columns["ToWhID"].Visible = false;
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

        }
        private void _SetInfoDefault()
        {
            dtmDocDate.Value = _dtmWorkDate;
            dtmFromDate.Value = _dtmWorkDate;
            dmtToDate.Value = _dtmWorkDate;
            cmbUser.SelectedValue = _strUser;
            cmbReason.SelectedValue = "CK";
            txtStatus.Text = "None";
        }
        private void _ResetPanelInput()
        {
            txtProductID.Text = "";
            //txtLotID.Text = "";
            txtQty.Text = "";
            txtUnitCost.Text = "";
            txtTotalCost.Text = "";
            cmbIUnit.Text = "";
        }

        private void btnAddRow_Click(object sender, EventArgs e)
        {
            txtProductID.Focus();
            _ResetPanelInput();
        }

        private void btnAddRow_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnAdd.RaiseClick();
        }
        private DataRow _dr;

        private void txtProductID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //txtLotID.Focus();
                SendKeys.Send("{tab}");
                //        return true;
            }
        }

        float _fltQty, _fltUnitCost;

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
                txtUnitCost.Text = (float.Parse(txtTotalCost.Number)/float.Parse(txtQty.Number)).ToString();
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
                    if (cmbIUnit.Items.Count > 0)
                        for (int i = 0; i <= cmbIUnit.Items.Count; i++)
                            cmbIUnit.Items.RemoveAt(0);
                    _dr = _dtProductInfo.Rows[0];
                    cmbIUnit.Items.Add(_dr["FromUnit"].ToString());
                    cmbIUnit.Items.Add(_dr["ToUnit"].ToString());
                    cmbIUnit.Text = _dr["INUnit"].ToString();
                }
            }
            
        }



    }
}
