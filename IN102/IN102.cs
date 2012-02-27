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

namespace IN102
{
    public partial class IN102 : PT.Master.Grid
    {
        public IN102()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.strPro = "IN102";
            _BinGrid();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {

            if (dgv != null)
            {
                for (int i = 0; i < dgv.Rows.Count; i++)
                {
                    INUnit _rs = new INUnit();
                    _rs.Unit = dgv.Rows[i].Cells["Unit"].FormattedValue.ToString().Trim();
                    if (_rs.Unit != "")
                    {
                        _rs.Crtd_DateTime = DateTime.Now;
                        _rs.Crtd_Prog = this.strPro;
                        _rs.Crtd_User = Globals.PTUserName;
                        _rs.LUpd_DateTime = DateTime.Parse(dgv.Rows[i].Cells["LUpd_DateTime"].FormattedValue.ToString().Trim());
                        _rs.LUpd_Prog = dgv.Rows[i].Cells["LUpd_Prog"].FormattedValue.ToString().Trim();
                        _rs.LUpd_User = dgv.Rows[i].Cells["LUpd_User"].FormattedValue.ToString().Trim();
                        int kq;
                        kq = IN102Ctrl.SaveUnit(_rs);
                    }
                }
                _BinGrid();
            }
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
            else
                MessageBox.Show("Chon dong can xoa", "thong bao");
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
        private void _BinGrid()
        {
            DataTable _dtINReason = new DataTable();
            dgv.Visible = false;
            _dtINReason = IN102Ctrl.GetUnit();
            dgv.EndCell = 0;
            dgv.DataSource = _dtINReason;
            _SetColumnVisible();
            dgv.Refresh();
            dgv.Visible = true;
        }
        private void _DeleteRow(int row)
        {
            string _id = dgv.Rows[row].Cells["Unit"].Value.ToString();
            if (_CheckUnitUsed(_id) == true)
            {
                MessageBox.Show("Da duoc dung", "thong bao");
                return;
            }
            else
                IN102Ctrl.DeleteUnit(_id);
        }        
        public static bool _CheckUnitUsed(string UnitID)
        {
            string _sql1 = "Select COUNT(*) from INProductClass1 where POUnit = '" + UnitID +
                                                                    "' or SOUnit ='" + UnitID +
                                                                    "' or INUnit ='" + UnitID + "'";
            string _sql2 = "Select COUNT(*) from INProductClass2 where POUnit = '" + UnitID +
                                                                    "' or SOUnit ='" + UnitID +
                                                                    "' or INUnit ='" + UnitID + "'";
            string _sql3 = "Select COUNT(*) from INProduct where FromUnit = '" + UnitID +
                                                                    "' or ToUnit ='" + UnitID +
                                                                    "' or INUnit ='" + UnitID +
                                                                    "' or SOUnit ='" + UnitID +
                                                                    "' or POUnit ='" + UnitID + "'"; ;
            int _count1 = ConnectDB.ExecuteScalar(_sql1);
            int _count2 = ConnectDB.ExecuteScalar(_sql2);
            int _count3 = ConnectDB.ExecuteScalar(_sql3);
            if (_count1 > 0)
                return true;
            else if (_count2 > 0)
                return true;
            else if (_count3 > 0)
                return true;
            else
                return false;
        }
    }
}
