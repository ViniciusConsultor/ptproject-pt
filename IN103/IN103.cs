using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PT.Helper;
using PT.DataInfo;
using PT.Master;


namespace IN103
{
    public partial class IN103 : Grid
    {
        string _strUser = PT.Helper.Globals.PTUserName;
        DateTime _dtmWorkDate = PT.Helper.Globals.PTWorkingDate;
        string _strPro = "IN103";

        public IN103()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtProgID.Text = "ProgID : " + _strPro;
            _BinGrid();
            _SetColumVisible();
        }

        private void _BinGrid()
        {
            DataTable _dtINReason = new DataTable();
            dgv.Visible = false;
            _dtINReason = ConnectDB.GetAll("INReason");
            dgv.EndCell = 1;
            dgv.DataSource = _dtINReason;
            dgv.Refresh();
            dgv.Visible = true;
        }

        private void _SetColumVisible()
        {
            dgv.Columns["Crtd_DateTime"].Visible = false;
            dgv.Columns["Crtd_Prog"].Visible = false;
            dgv.Columns["Crtd_User"].Visible = false;
            dgv.Columns["LUpd_DateTime"].Visible = false;
            dgv.Columns["LUpd_Prog"].Visible = false;
            dgv.Columns["LUpd_User"].Visible = false;
            dgv.Columns["Descr"].Width = 500;

        }
        private void _SaveGrid()
        {
            if (dgv != null)
            {
                for (int i = 0; i < dgv.Rows.Count; i++)
                {
                    INReason _rs = new INReason();
                    _rs.RsID = dgv.Rows[i].Cells["RsId"].FormattedValue.ToString().Trim();
                    _rs.Descr = dgv.Rows[i].Cells["Descr"].FormattedValue.ToString().Trim();
                    _rs.Crtd_DateTime = _dtmWorkDate;
                    _rs.Crtd_Prog = _strPro;
                    _rs.Crtd_User = _strUser;
                    _rs.LUpd_DateTime = _dtmWorkDate;
                    _rs.LUpd_Prog = _strPro;
                    _rs.LUpd_User = _strUser;
                    int kq;
                    if (_rs.RsID != "")
                        kq = IN103Ctrl.SaveINReason(_rs);
                }
                _BinGrid();
            }
        }

        private void _DeleteRow(int row)
        {
            string _strRsId = dgv.Rows[row].Cells[0].FormattedValue.ToString();
            if (_strRsId != "CK" && _strRsId != "DC")
                IN103Ctrl.DeleteINReason(_strRsId);
            else
                MessageBox.Show(_strRsId + " là dữ liệu mặc định, không được phép xóa","Thông báo" ,MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            _SaveGrid();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Int32 _intTotalRow = dgv.Rows.GetRowCount(DataGridViewElementStates.Selected);

            if (_intTotalRow > 0)
            {
                DialogResult _kq;
                _kq = MessageBox.Show("Bạn muốn xóa " + _intTotalRow.ToString() + " dòng được chọn", "Thông báo !", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (_kq == DialogResult.Yes)
                    for (int i = 0; i < _intTotalRow; i++)
                    {
                        int _row = Int16.Parse(dgv.SelectedRows[i].Index.ToString());
                        _DeleteRow(_row);
                    }
                _BinGrid();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            _BinGrid();
        }

    }
}
