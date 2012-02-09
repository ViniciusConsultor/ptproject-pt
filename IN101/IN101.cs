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
using System.Text.RegularExpressions;


namespace IN101
{
    public partial class IN101 : PT.Master.Grid
    {
        public IN101()
        {
            InitializeComponent();
        }

        private void IN101_Load(object sender, EventArgs e)
        {
            this.strPro = "IN101";
            _BinGrid();
            _SetColumnVisible();
        }
        private void _SetColumnVisible()
        {
            dgv.Columns["Crtd_DateTime"].Visible = false;
            dgv.Columns["Crtd_Prog"].Visible = false;
            dgv.Columns["Crtd_User"].Visible = false;
            dgv.Columns["LUpd_DateTime"].Visible = false;
            dgv.Columns["LUpd_Prog"].Visible = false;
            dgv.Columns["LUpd_User"].Visible = false;            
        }


         

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Int32 _intTotalRow = dgv.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (_intTotalRow > 0)
            {
                if (MessageBox.Show("Bạn có muốn xóa '" + _intTotalRow + "' dòng được chọn không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    for (int i = 0; i < _intTotalRow; i++)
                    {
                        int _row = Int16.Parse(dgv.SelectedRows[i].Index.ToString());
                        _DeleteRow(_row);
                    }
                    _BinGrid();
                }
                
            }

        }
        private void _BinGrid()
        {
            DataTable _dtINReason = new DataTable();
            dgv.Visible = false;
            _dtINReason = IN101Ctrl.GetWarehouse();
            dgv.EndCell = 5;
            dgv.DataSource = _dtINReason;

            dgv.Refresh();
            dgv.Visible = true;
        }

        private void _DeleteRow(int row)
        {
            string _id = dgv.Rows[row].Cells["WhID"].Value.ToString();
            string _strRsId = dgv.Rows[row].Cells[0].FormattedValue.ToString();
            IN101Ctrl.DeleteWarehouse(_strRsId);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            _BinGrid();
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dgv != null)
            {
                for (int i = 0; i < dgv.Rows.Count; i++)
                {
                    INWarehouse _rs = new INWarehouse();
                    _rs.WhId = dgv.Rows[i].Cells["WhId"].FormattedValue.ToString().Trim();
                    _rs.Name = dgv.Rows[i].Cells["Name"].FormattedValue.ToString().Trim();
                    _rs.WhKeeper = dgv.Rows[i].Cells["WhKeeper"].FormattedValue.ToString().Trim();
                    _rs.Addr = dgv.Rows[i].Cells["Addr"].FormattedValue.ToString().Trim();
                    _rs.Phone = dgv.Rows[i].Cells["Phone"].FormattedValue.ToString().Trim();
                    _rs.Type = dgv.Rows[i].Cells["Type"].FormattedValue.ToString().Trim();
                    _rs.Crtd_DateTime = DateTime.Now;
                    _rs.Crtd_Prog = this.strPro ;
                    _rs.Crtd_User = Globals.PTUserName;
                    _rs.LUpd_DateTime = DateTime.Parse(dgv.Rows[i].Cells["LUpd_DateTime"].FormattedValue.ToString().Trim());
                    _rs.LUpd_Prog = dgv.Rows[i].Cells["LUpd_Prog"].FormattedValue.ToString().Trim();
                    _rs.LUpd_User = dgv.Rows[i].Cells["LUpd_User"].FormattedValue.ToString().Trim();
                    int kq;
                    if (_rs.WhId!= "")
                        kq = IN101Ctrl.SaveWarehouse(_rs);
                }
                _BinGrid();
            }
        }
        private bool _CheckCell(int _row, int _cell)
        {
            long a = 0;            
            if (_cell == 4)
                if (long.TryParse(dgv.Rows[_row].Cells[_cell].Value.ToString(), out a) == true)
                    return true;
                else
                {
                    MessageBox.Show("Số điện thoại không hợp lệ", "Thông báo");
                    SendKeys.Send("+{tab}");
                    return false;
                }
            return true;
        }

        private void dgv_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            _CheckCell(dgv.CurrentRow.Index, dgv.CurrentCell.ColumnIndex);
        }
    }
}
