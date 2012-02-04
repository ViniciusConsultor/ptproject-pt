using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PT.DataInfo;
using PT.Helper;


namespace IN101
{
    public partial class IN101 : Form
    {
        string _strUser = "ADMIN";
        string _strPro = "IN101";

        public IN101()
        {
            InitializeComponent();
        }
        private DataTable _dt_grdWH = new DataTable();

        private void IN101_Load(object sender, EventArgs e)
        {
            _BinGridWH();
        }
        //
        private void _BinGridWH()
        {
            _dt_grdWH = ConnectDB.ExecuteReader("sp_GetAll", new String[] { "TableName" }, new Object[] { "INWarehouse" });
            grdWH.DataSource = _dt_grdWH;
            _SetGridColumVisible();
            _setColumSite();
            _AutoNumberForGrid(grdWH);
            grdWH.Refresh();
        }

        private void _SetGridColumVisible()
        {
            grdWH.Columns["Type"].Visible = false;
            grdWH.Columns["Crtd_DateTime"].Visible = false;
            grdWH.Columns["Crtd_Prog"].Visible = false;
            grdWH.Columns["Crtd_User"].Visible = false;
            grdWH.Columns["LUpd_DateTime"].Visible = false;
            grdWH.Columns["LUpd_Prog"].Visible = false;
            grdWH.Columns["LUpd_User"].Visible = false;
        }

        private void _AutoNumberForGrid(DataGridView dataGridView)
        {
            if (dataGridView != null)
            {

                for (int i = 0; i < dataGridView.Rows.Count; i++)
                {
                    dataGridView.Rows[i].HeaderCell.Value = (i + 1).ToString();
                }
            }
        }

        private void _setColumSite()
        {
            grdWH.Columns[1].Width = 200;
            grdWH.Columns[2].Width = 150;
            grdWH.Columns[3].Width = 150;
            grdWH.Columns[4].Width = 150;
        }

        private void _saveGridWH()
        {
            if (grdWH != null)
            {
                for (int i = 0; i < grdWH.Rows.Count - 1; i++)
                {
                    INWarehouse _info = new INWarehouse();
                    _info.WhId = grdWH.Rows[i].Cells["WhId"].FormattedValue.ToString().Trim();
                    _info.Name = grdWH.Rows[i].Cells["Name"].FormattedValue.ToString().Trim();
                    _info.WhKeeper = grdWH.Rows[i].Cells["WhKeeper"].FormattedValue.ToString().Trim();
                    _info.Addr = grdWH.Rows[i].Cells["Addr"].FormattedValue.ToString().Trim();
                    _info.Phone = grdWH.Rows[i].Cells["Phone"].FormattedValue.ToString().Trim();
                    _info.Type = "ST";
                    _info.Crtd_DateTime = DateTime.Now;
                    _info.Crtd_Prog = _strPro;
                    _info.Crtd_User = _strUser;
                    _info.LUpd_DateTime = DateTime.Now;
                    _info.LUpd_Prog = _strPro;
                    _info.LUpd_User = _strUser;

                    int kq;
                    if (_info.WhId != "")
                        kq = INWarehouseCtr.SaveWarehouse(_info);
                }
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            _saveGridWH();
        }
        //
        private void grdWH_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            _AutoNumberForGrid(grdWH);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            _BinGridWH();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _saveGridWH();
            _BinGridWH();
        }
        private void _deleteGridRow(int row)
        {
            string _strWhId = grdWH.Rows[row].Cells[0].FormattedValue.ToString();
            INWarehouseCtr.DeleteWarehouse(_strWhId);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Int32 _intTotalRow = grdWH.Rows.GetRowCount(DataGridViewElementStates.Selected);

            if (_intTotalRow > 0)
            {
                DialogResult _kq;
                _kq = MessageBox.Show("Bạn muốn xóa " + _intTotalRow.ToString() + " dòng được chọn", "Thông báo !", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (_kq == DialogResult.Yes)
                    for (int i = 0; i < _intTotalRow; i++)
                    {
                        int _row = Int16.Parse(grdWH.SelectedRows[i].Index.ToString());
                        _deleteGridRow(_row);
                    }
                _BinGridWH();
            }
        }

        private void grdWH_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //if (e.ColumnIndex > -1 && e.RowIndex > -1)
            //{
            //    this.grdWH.CurrentCell = this.grdWH[e.ColumnIndex, e.RowIndex];
            //    this.grdWH.BeginEdit(true);
            //}
        }

        private void grdWH_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            Int32 _intTotalRow = grdWH.Rows.GetRowCount(DataGridViewElementStates.Selected);

            if (_intTotalRow > 0)
            {
                DialogResult _kq;
                _kq = MessageBox.Show("Bạn muốn xóa " + _intTotalRow.ToString() + " dòng được chọn", "Thông báo !", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (_kq == DialogResult.Yes)
                    for (int i = 0; i < _intTotalRow; i++)
                    {
                        int _row = Int16.Parse(grdWH.SelectedRows[i].Index.ToString());
                        _deleteGridRow(_row);
                    }
                _BinGridWH();
            }
        }

        private void grdWH_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                MessageBox.Show("Enter key pressed");
            }
        }

        private void grdWH_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
         //   SendKeys.SendWait("{right}");
            //MessageBox.Show("a");
        }

        private void grdWH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        //{
        //    const int WM_KEYDOWN = 0x100;
        //    const int WM_SYSKEYDOWN = 0x104;

        //    if ((msg.Msg == WM_KEYDOWN) || (msg.Msg == WM_SYSKEYDOWN))
        //    {
        //        if (ActiveControl.Name == "grdWH")
        //        {
        //            if (keyData == Keys.Enter)
        //            {
        //                SendKeys.SendWait("{right}");
        //                return true;
        //            }
        //        }
        //    }
        //    return base.ProcessCmdKey(ref msg, keyData);
        //} 





    }
}
