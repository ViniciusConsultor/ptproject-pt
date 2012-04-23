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


namespace AP201
{
    public partial class AP201 : PT.Master.GridEditIn
    {
        public string _DocType = "TN";
        private string _strPro = "AP201";
        private string _strUser = PT.Helper.Globals.PTUserName;
        private DataTable _dtAPDoc = new DataTable();
        private DataTable _dtSAUser = new DataTable();
        private DataTable _dtSIBranch = new DataTable();
        private DataTable _dtVend = new DataTable();
        private DataTable _dtSITax = new DataTable();
        private DataTable _dtCAAccount = new DataTable();
        private DataTable _dtPONbr = new DataTable();
        private string _strFistChar, _strLastNbr;
        private APDoc _info = new APDoc();
        
        public AP201()
        {
            InitializeComponent();
        }
        private void AP201_Load(object sender, EventArgs e)
        {
            dtmFromDate.Value = DateTime.Now;
            dtmToDate.Value = DateTime.Now;
            _LoadData();
            _BindCtrl();
            _BindGrid();            
            switch (_DocType)
            {
                case "TN":
                    {
                        this.Text = "Chứng từ tăng nợ";
                        cmbType.SelectedValue = "TN";
                        break;
                    }
                case "GN":
                    {
                        this.Text = "Chứng từ giảm nợ";
                        cmbType.SelectedValue = "GN";
                        break;
                    }
                case "TT":
                    {
                        this.Text = "Chứng từ thanh toán trước";
                        cmbType.SelectedValue = "TT";
                        break;
                    }
            }

        }
        private void _BindGrid()
        {
            string strUser = cmbUser.SelectedValue.ToString().Trim();
            DateTime strFromDate = dtmFromDate.Value;
            DateTime strToDate = dtmToDate.Value;
            string strDocNbrFind = txtDocNbrFind.Text.ToString().Trim();
            string strInvcNbrFind = txtInvcNbrFind.Text.ToString().Trim();
            _dtAPDoc = AP201Ctrl.FindAPDoc(_strPro,strUser, _DocType, strFromDate, strToDate, strDocNbrFind, strInvcNbrFind);
            dgv.DataSource = _dtAPDoc;
            
        }
        private void _ResetPanelInput()
        {
            cmbStatus.SelectedValue = 0;
            txtDocNbr.Text = "";
            txtInvcNbr.Text = "";
            txtPreTaxAmt.Text = "";
            txtDocDescr.Text = "";
            txtVendID.Text = "";
            txtInvcNote.Text = "";
            txtOrigDocAmt.Text = "";
            txtTaxAmt.Text = "";

            dtmDocDate.Value = DateTime.Now;
            dtmDueDate.Value = DateTime.Now;
            _SetButtomStatus();
            
        }
        private void _BindPanel(APDoc info)
        {
            cmbBranchID.SelectedValue = info.BranchID;
            txtDocNbr.Text = info.DocNbr;
            cmbType.SelectedValue = info.DocType;
            txtDocDescr.Text = info.DocDesc;
            cmbDocAcct.SelectedValue = info.DocAcct;
            txtVendID.Text = info.VendID;
            //info.DocBal = null;
            txtOrigDocAmt.Text = info.OrigDocAmt.ToString().Trim();
            dtmDocDate.Value = info.DocDate;
            //info.PONbr = "";
            txtInvcNbr.Text = info.InvcNbr;
            txtInvcNote.Text = info.InvcNote;
            cmbStatus.SelectedValue = info.Rlsed;
            cmbTaxID.SelectedValue = info.TaxId;
            txtPreTaxAmt.Text = info.PreTaxAmt.ToString().Trim();
            txtTaxAmt.Text = info.TaxAmt.ToString().Trim();
            //info.TimeLmtID = "";
            dtmDueDate.Value = info.DueDate;
            //info.Note = "";
            //info.Crtd_DateTime =
            //info.Crtd_Prog = _strPro;
            //info.Crtd_User = _strUser;
            //info.LUpd_DateTime = DateTime.Now;
            //info.LUpd_Prog = _strPro;
            //info.LUpd_User = _strUser;
            //info.Version = "";
            //return info;
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
            cmbBranchID.DisplayMember = "BranchName";
            cmbBranchID.ValueMember = "BranchID";
            cmbBranchID.ColumnNames = "BranchID,BranchName";
            cmbBranchID.ColumnWidths = "100,200";
            cmbBranchID.LinkedColumnIndex = 1;

            cmbTaxID.DataSource = _dtSITax;
            cmbTaxID.DisplayMember = "Descr";
            cmbTaxID.ValueMember = "TaxRate";
            cmbTaxID.ColumnNames = "TaxID,Descr,TaxRate";
            cmbTaxID.ColumnWidths = "100";
            cmbTaxID.LinkedColumnIndex = 1;

            cmbDocAcct.DataSource = _dtCAAccount;
            cmbDocAcct.DisplayMember = "Acct";
            cmbDocAcct.ValueMember = "Acct";
            cmbDocAcct.ColumnNames = "Acct,AcctName";
            cmbDocAcct.ColumnWidths = "100,150";

            DataTable dtStatus = new DataTable();
            dtStatus.Columns.Add("Rlease", typeof(int));
            dtStatus.Columns.Add("Descr", typeof(string));
            dtStatus.Rows.Add(-1, "Đã Hủy");
            dtStatus.Rows.Add(0, "Đang Treo");
            dtStatus.Rows.Add(1, "Đã Cập Nhật");
            cmbStatus.DataSource = dtStatus;
            cmbStatus.DisplayMember = "Descr";
            cmbStatus.ValueMember = "Rlease";
            //cmbStatus.ColumnNames = "Descr";
            //cmbStatus.ColumnWidths = "95";
            //cmbStatus.LinkedColumnIndex = 1;

            DataTable dtType = new DataTable();
            dtType.Columns.Add("Type", typeof(string));
            dtType.Columns.Add("Descr", typeof(string));
            dtType.Rows.Add("TN", "Tăng nợ");
            dtType.Rows.Add("GN", "Giảm nợ");
            dtType.Rows.Add("TT", "Thanh toán trước");
            cmbType.DataSource = dtType;
            cmbType.DisplayMember = "Descr";
            cmbType.ValueMember = "Type";
            //cmbStatus.ColumnNames = "Descr";
            //cmbStatus.ColumnWidths = "95";
            //cmbStatus.LinkedColumnIndex = 1;

            

            txtVendID.DataSource = _dtVend;
            txtVendID.ColumnWidths = "100,250";
            
        }
        private void _LoadData()
        {
            _dtCAAccount = AP201Ctrl.GetCAAccount();
            _dtSAUser = AP201Ctrl.GetSAUser();
            _dtSIBranch = AP201Ctrl.GetSIBranch();
            _dtSITax = AP201Ctrl.GetSITax();
            _dtVend = AP201Ctrl.GetVendID();
        }
        private APDoc _GetPanel(int intRelease)
        {
            _info.BranchID = cmbBranchID.SelectedValue.ToString();
            _info.DocNbr = txtDocNbr.Text.ToString().Trim();
            _info.DocType = cmbType.SelectedValue.ToString();
            _info.DocDesc = txtDocDescr.Text.ToString().Trim();
            _info.DocAcct = cmbDocAcct.SelectedValue.ToString();
            _info.VendID = txtVendID.Text.ToString().Trim();
            _info.DocBal = double.Parse(txtOrigDocAmt.Text);
            _info.OrigDocAmt = txtOrigDocAmt.Number;
            _info.DocDate = dtmDocDate.Value;            
            _info.InvcNbr = txtInvcNbr.Text.ToString().Trim();
            _info.InvcNote = txtInvcNote.Text.ToString().Trim();
            _info.Rlsed = intRelease;
            _info.TaxId = cmbTaxID.SelectedValue.ToString().Trim();
            _info.PreTaxAmt = txtPreTaxAmt.Number;
            _info.TaxAmt = txtTaxAmt.Number;
            _info.TimeLmtID = "";
            _info.DueDate = dtmDueDate.Value;
            _info.Note = "";
            _info.PONbr = "";
            _info.Crtd_DateTime = DateTime.Now;
            _info.Crtd_Prog = _strPro;
            _info.Crtd_User = _strUser;
            _info.LUpd_DateTime = DateTime.Now;
            _info.LUpd_Prog = _strPro;
            _info.LUpd_User = _strUser;
            if (_info.Version == null)
                _info.Version = "";
            return _info;
        }
        private bool _CheckValid()
        {
            if (txtVendID.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Vui long nhap du lieu", "Thong bao");
                txtVendID.Focus();
                return false;
            }
            if (cmbBranchID.SelectedValue.ToString() == "")
            {
                MessageBox.Show("Vui long nhap du lieu", "Thong bao");
                cmbBranchID.Focus();
                return false;
            }
            if (txtDocDescr.Text.Trim() == "")
            {
                MessageBox.Show("Vui long nhap du lieu", "Thong bao");
                txtDocDescr.Focus();
                return false;
            }
            if (txtInvcNbr.Text.Trim() == "")
            {
                MessageBox.Show("Vui long nhap du lieu", "Thong bao");
                txtInvcNbr.Focus();
                return false;
            }
            if (txtInvcNote.Text.Trim() == "")
            {
                MessageBox.Show("Vui long nhap du lieu", "Thong bao");
                txtInvcNote.Focus();
                return false;
            }
            if (txtPreTaxAmt.Text.Trim() == "")
            {
                MessageBox.Show("Vui long nhap du lieu", "Thong bao");
                txtPreTaxAmt.Focus();
                return false;
            }

            return true;
        }
        private int _SaveAPDoc(int release)
        {
            _info.Rlsed = release;
            return AP201Ctrl.SaveAPDoc(_info);
            
        }
        private void _SaveSASetup(string strModule, string strFistChar, string strLastNbr)
        {
            SASetup _sa = new SASetup();
            _sa.Module = strModule;
            _sa.FistChar = strFistChar;
            _sa.LastNbr = strLastNbr;
            int kq;
            if (_sa.Module != "" && _sa.FistChar != "")
                kq = AP201Ctrl.SaveSASetup(_sa);
        }
        private void _SetButtomStatus()
        {
            if (txtDocNbr.Text.ToString().Trim() == "")
            {
                btnRelease.Enabled = false;
                btnDestroy.Enabled = false;
                btnCanAndCopy.Enabled = false;
                btnDelete.Enabled = false;
                btnSave.Enabled = true;
                btnBack.Enabled = true;
                pnl.Enabled = true;
            }
            if (pnl.Visible == true)
                btnBack.Enabled = true;
            if (cmbStatus.SelectedValue == null)
            {
                btnRelease.Enabled = true;
                btnDestroy.Enabled = false;
                btnCanAndCopy.Enabled = false;
                btnDelete.Enabled = true;
                pnl.Enabled = true;
            }
            if ((cmbStatus.SelectedValue.ToString() == "0")&&(txtDocNbr.Text.ToString().Trim() != ""))
            {
                btnSave.Enabled = true;
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

        private void pnlhead_Click(object sender, EventArgs e)
        {
            _BindGrid();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            _info = new APDoc();
            _ResetPanelInput();
            _SetButtomStatus();
        }

        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //APDoc info = new APDoc();
            
            if (e.RowIndex > -1 && e.RowIndex < dgv.RowCount)            
            {
                _info.ConvertToAPDoc(_dtAPDoc.Rows[e.RowIndex]);
                _BindPanel( _info);
                pnl.Visible = true;
                pnldgv.Visible = false;                
            }
            _SetButtomStatus();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_CheckValid() == true)
            {
                
                if (txtDocNbr.Text.ToString().Trim() == "")
                {
                    
                    DataTable _dtLastNbr = AP201Ctrl.GetSASetupGetLastNbr("AP", _DocType);
                    _strLastNbr = _dtLastNbr.Rows[0]["LastNbr"].ToString();
                    string strLastNbr = (Int16.Parse(_strLastNbr) + 1).ToString("000000");
                    txtDocNbr.Text = _DocType + strLastNbr;
                    //info.DocNbr = _DocType + strLastNbr;
                    _SaveSASetup("AP", _DocType, strLastNbr);
                    _GetPanel(0);
                }
                else
                {
                    _GetPanel(0);
                    _info.LUpd_DateTime = DateTime.Now;
                    _info.LUpd_Prog = _strPro;
                    _info.LUpd_User = _strUser;
                }

                int kq = _SaveAPDoc(0);
                if (kq != 0)
                {
                    APDoc tmp = new APDoc();
                    tmp.ConvertToAPDoc( AP201Ctrl.GetAPDoc(_info.BranchID, _info.DocNbr).Rows[0]);
                    _info = tmp;
                    _SetButtomStatus();
                }
            }
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            _BindGrid();
        }

        private void txtPreTaxAmt_Leave(object sender, EventArgs e)
        {
            if (txtPreTaxAmt.Text.Trim() != "")
            {                
                double TaxID = double.Parse(cmbTaxID.SelectedValue.ToString());
                double taxamt = txtPreTaxAmt.Number * TaxID;
                txtTaxAmt.Text = taxamt.ToString();
                txtOrigDocAmt.Text = (txtPreTaxAmt.Number + txtTaxAmt.Number).ToString();
            }
        }

        private void cmbTaxID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtPreTaxAmt.Text.Trim() != "")
            {
                double TaxID = double.Parse(cmbTaxID.SelectedValue.ToString());
                double taxamt = txtPreTaxAmt.Number * TaxID;
                txtTaxAmt.Text = taxamt.ToString();
                txtOrigDocAmt.Text = (txtPreTaxAmt.Number + txtTaxAmt.Number).ToString();
            }
        }

        private void btnRelease_Click(object sender, EventArgs e)
        {
            _GetPanel(1);            
            _info.LUpd_DateTime = DateTime.Now;
            _info.LUpd_Prog = _strPro;
            _info.LUpd_User = _strUser;
            int kq = _SaveAPDoc(1);
            if (kq == 1)
            {
                cmbStatus.SelectedValue = 1;
                MessageBox.Show("Cap nhat thanh cong", "Thong bao");
            }
            _SetButtomStatus();
        }

        private void btnDestroy_Click(object sender, EventArgs e)
        {
           
            PT.Component.InputBoxForm ib = new PT.Component.InputBoxForm("Bạn có muốn hủy?", "default", "Chuyển Kho");
            if (ib.ShowDialog() == DialogResult.OK)
            {
               // _GetPanel(-1);
                _info.Note = ib.txtOut.Text.ToString();
                _info.LUpd_DateTime = DateTime.Now;
                _info.LUpd_Prog = _strPro;
                _info.LUpd_User = _strUser;
                int kq = _SaveAPDoc(-1);
                if (kq == 1)
                {                    
                    cmbStatus.SelectedValue = -1;
                    MessageBox.Show("Huy thanh cong", "Thong bao");
                }
                
            }
            _SetButtomStatus();
        }

        private void btnCanAndCopy_Click(object sender, EventArgs e)
        {
            PT.Component.InputBoxForm ib = new PT.Component.InputBoxForm("Bạn có muốn hủy?", "default", "Chuyển Kho");
            if (ib.ShowDialog() == DialogResult.OK)
            {
                // _GetPanel(-1);
                _info.Note = ib.txtOut.Text.ToString();
                _info.LUpd_DateTime = DateTime.Now;
                _info.LUpd_Prog = _strPro;
                _info.LUpd_User = _strUser;
                int kq = _SaveAPDoc(-1);
                if (kq == 1)
                {
                    cmbStatus.SelectedValue = -1;
                    MessageBox.Show("Huy thanh cong", "Thong bao");

                    _info.DocNbr = "";
                    _info.Rlsed = 0;
                    _info.DocType = _DocType;
                    _info.Crtd_DateTime = DateTime.Now;
                    _info.Crtd_Prog = _strPro;
                    _info.Crtd_User = _strUser;
                    _info.LUpd_DateTime = DateTime.Now;
                    _info.LUpd_Prog = _strPro;
                    _info.LUpd_User = _strUser;
                    _BindPanel(_info);
                }

            }
            _SetButtomStatus();
        }

    }
}
//C# .NET - check all and uncheck all checkbox in datagridview in window application
//Asked By Monoj Kumar Muchahari
//02-Feb-09 07:46 AM
//I am working on a window application in which i have checkboxes, i want that when i check the last row of the datagridview all the above checkboxes should also be checked. plz help.
//Advertisement - WPF Resource Washer
//re  re
//02-Feb-09 08:03 AM

//use this

//// customize dataviewgrid, add checkbox column
//DataGridViewCheckBoxColumn checkboxColumn = new DataGridViewCheckBoxColumn();
//checkboxColumn.Width = 30;
//checkboxColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
//list.Columns.Insert(0, checkboxColumn);
 
//// add checkbox header
//Rectangle rect = list.GetCellDisplayRectangle(0, -1, true);
//// set checkbox header to center of header cell. +1 pixel to position correctly.
//rect.X = rect.Location.X + (rect.Width / 4);
 
//CheckBox checkboxHeader = new CheckBox();
//checkboxHeader.Name = "checkboxHeader";
//checkboxHeader.Size = new Size(18, 18);
//checkboxHeader.Location = rect.Location;
//checkboxHeader.CheckedChanged += new EventHandler(checkboxHeader_CheckedChanged);
 
//list.Controls.Add(checkboxHeader);   

//private void checkboxHeader_CheckedChanged(object sender, EventArgs e) {
//    for (int i = 0; i < list.RowCount; i++) {
//    list[0, i].Value = ((CheckBox) list.Controls.Find("checkboxHeader", true)[0]).Checked;
//    }
//    list.EndEdit();
//}

//http://tech.chitgoks.com/2008/11/17/c-add-select-all-deselect-all-checkbox-in-column-header-in-datagridview-control/

//re  re
//02-Feb-09 08:03 AM
//http://social.msdn.microsoft.com/Forums/en-US/winforms/thread/68b5ed2f-d924-4e26-a354-7be30ac08ef6/
//Reply  Reply
//02-Feb-09 11:14 AM

//protected override void OnMouseClick(DataGridViewCellMouseEventArgs e)
//        {
//            //Convert the CheckBoxRegion
//            Rectangle rec = new Rectangle(new Point(0, 0), this.CheckBoxRegion.Size);
//            this.checkAll = !this.checkAll;
//            if (rec.Contains(e.Location))
//            {
//                this.DataGridView.Invalidate();
//            }
//            base.OnMouseClick(e);
//        }

//        public bool CheckAll
//        {
//            get { return this.checkAll; }
//            set { this.checkAll = value; }
//        }

//private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
//        {
//            if (e.ColumnIndex == 0)
//            {
//                for (int i = 0; i < dataGridView1.Rows.Count; i++)
//                {
//                    dataGridView1.Rows[i].Cells[0].Value = dgvColumnHeader.CheckAll;
//                }
//            }
//        }
//  Vasanthakumar D replied to Monoj Kumar Muchahari
//02-Feb-09 12:43 PM

//Hi,

//try this...

 

//private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
//        {
//            if (e.ColumnIndex == 3 && e.RowIndex == dataGridView1.Rows.Count - 1)
//            {
//                if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "true")
//                {
//                    for (int count = 0; count < dataGridView1.Rows.Count - 1; count++)
//                    {
//                        dataGridView1.Rows[count].Cells[e.ColumnIndex].Value = true;
//                    }
//                }

//                else

//                 {

//                              for (int count = 0; count < dataGridView1.Rows.Count - 1; count++)
//                             {
//                                 dataGridView1.Rows[count].Cells[e.ColumnIndex].Value = false;
//                             }
                         

//                 }        
//            }
//        }

//check all and uncheck all checkbox in datagridview in window application  check all and uncheck all checkbox in datagridview in window application
//21-Apr-09 12:36 AM

//Hi , use this code

//private void grd_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)

//{

//try

//{

//DataGridView dgv = (DataGridView)sender;

//if (e.ColumnIndex == dgv.Columns[0].Index)

//{

//if (e.RowIndex < 0)

//{

//for (int i = 0; i < dgv.Rows.Count; i++)

//{

//dgv.Rows[i].Cells[0].Value = !lastDRGridCheckAllSelected;

//}

//lastDRGridCheckAllSelected = !lastDRGridCheckAllSelected;

//dgv.Refresh();

//}

//}

//}

//catch (Exception exp)

//{

//MessageBox.Show(exp.Message);

//}

//}

 
//Error  Error
//13-Aug-09 02:11 AM
//dgvAttendance.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString()
//it shows error
