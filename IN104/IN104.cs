using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PT.Master;
using PT.Helper;
using PT.DataInfo;

namespace IN104
{
    public partial class IN104 : GridEdit2
    {
        string _strPro = "IN104";

        DataTable _dt1 = new DataTable();
        DataTable _dt2 = new DataTable();

        public IN104()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txt2.Visible = false;
            lbl2.Visible = false;
            txtProgID.Text = "ProgID : " + _strPro;
            _BindGrid1("");
            _BindGridByGrid1("", "");
            txt1.DataSource = ConnectDB.ExecuteReader("sp_APVendorGet");//, new String[] { "APVendor" }, new Object[] { _strTableName });
        }
        private void _BindGrid1(string _strVendID)
        {
            _dt1 = IN104Ctrl.GetINProductClass1ByVendID(_strVendID);
            dgv1.DataSource = _dt1;
            dgv1.EndCell = 7;
            _SetColumVisible1();
            dgv1.Refresh();
            if (dgv1.RowCount > 0)
                _BindGridByGrid1(txt1.Text, dgv1.Rows[0].Cells["ClassID1"].FormattedValue.ToString());
        }
        private void _SetColumVisible1()
        {
            dgv1.Columns["VendID"].Visible = false;
            dgv1.Columns["Crtd_DateTime"].Visible = false;
            dgv1.Columns["Crtd_Prog"].Visible = false;
            dgv1.Columns["Crtd_User"].Visible = false;
            dgv1.Columns["LUpd_DateTime"].Visible = false;
            dgv1.Columns["LUpd_Prog"].Visible = false;
            dgv1.Columns["LUpd_User"].Visible = false;
            dgv1.Columns["Descr"].Width = 250;

        }

        private void _BindGridByGrid1(string _strVendID, string _strClassID1)
        {
            _dt2 = IN104Ctrl.GetINProductClass2ByClass1(_strVendID, _strClassID1);
            dgv2.DataSource = _dt2;
            dgv2.EndCell = 8;
            _SetColumVisible2();
            dgv2.Refresh();
            //_dt2.DefaultView.RowFilter = string.Format("VendID = '{0}'", _strVendID) + string.Format(" AND ClassID1 = '{0}'", _strClassID1);
        }
        private void _SetColumVisible2()
        {
            dgv2.Columns["VendID"].Visible = false;
            dgv2.Columns["ClassID1"].Visible = false;
            dgv2.Columns["Crtd_DateTime"].Visible = false;
            dgv2.Columns["Crtd_Prog"].Visible = false;
            dgv2.Columns["Crtd_User"].Visible = false;
            dgv2.Columns["LUpd_DateTime"].Visible = false;
            dgv2.Columns["LUpd_Prog"].Visible = false;
            dgv2.Columns["LUpd_User"].Visible = false;
            dgv2.Columns["Descr"].Width = 250;
        }

        private void dgv1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string _strVendID = dgv1.Rows[e.RowIndex].Cells["VendID"].FormattedValue.ToString();
            string _strClassID1 = dgv1.Rows[e.RowIndex].Cells["ClassID1"].FormattedValue.ToString();
            _BindGridByGrid1(_strVendID, _strClassID1);
        }

        private void dgv1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string _strVendID = dgv1.Rows[e.RowIndex].Cells["VendID"].FormattedValue.ToString();
            string _strClassID1 = dgv1.Rows[e.RowIndex].Cells["ClassID1"].FormattedValue.ToString();
            _BindGridByGrid1(_strVendID, _strClassID1);
        }



        private void dgv1_KeyDown(object sender, KeyEventArgs e)
        {
            int index;
            string _strVendID;
            string _strClassID1;
            if (e.KeyCode == Keys.Up)
            {
                index = dgv1.CurrentRow.Index - 1;
                if (index > -1)
                {
                    _strVendID = dgv1.Rows[index].Cells["VendID"].FormattedValue.ToString();
                    _strClassID1 = dgv1.Rows[index].Cells["ClassID1"].FormattedValue.ToString();
                    _BindGridByGrid1(_strVendID, _strClassID1);
                }
            }

            if (e.KeyCode == Keys.Down)
            {
                index = dgv1.CurrentRow.Index + 1;
                if (index < dgv1.RowCount)
                {
                    _strVendID = dgv1.Rows[index].Cells["VendID"].FormattedValue.ToString();
                    _strClassID1 = dgv1.Rows[index].Cells["ClassID1"].FormattedValue.ToString();
                    _BindGridByGrid1(_strVendID, _strClassID1);
                }
            }
        }


        private void _DeleteRow(int row)
        {
            string _strVendID = dgv1.Rows[row].Cells["VendID"].Value.ToString();
            string _strClassID1 = dgv1.Rows[row].Cells["ClassID1"].Value.ToString();
            IN104Ctrl.DeleteINProductClass1(_strVendID, _strClassID1);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int index = dgv1.CurrentRow.Index;
            dgv1.Rows[index].Cells["VendID"].Value = txt1.Text;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            _BindGrid1(txt1.Text);
            if (dgv1.Rows.Count > 0)
            {
                dgv1.Columns["ClassID1"].ReadOnly = true;
            }
            if (dgv2.Rows.Count > 0)
            {
                dgv2.Columns["ClassID2"].ReadOnly = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dgv1 != null)
            {
                for (int i = 0; i < dgv1.Rows.Count; i++)
                {
                    INProductClass1 _cls1 = new INProductClass1();
                    _cls1.VendID = dgv1.Rows[i].Cells["VendID"].FormattedValue.ToString().Trim();
                    _cls1.ClassID1 = dgv1.Rows[i].Cells["ClassID1"].FormattedValue.ToString().Trim();
                    _cls1.Descr = dgv1.Rows[i].Cells["Descr"].FormattedValue.ToString().Trim();
                    _cls1.DfltTaxID = dgv1.Rows[i].Cells["DfltTaxID"].FormattedValue.ToString().Trim();
                    _cls1.DfltWhID = dgv1.Rows[i].Cells["DfltWhID"].FormattedValue.ToString().Trim();
                    _cls1.POUnit = dgv1.Rows[i].Cells["POUnit"].FormattedValue.ToString().Trim();
                    _cls1.SOUnit = dgv1.Rows[i].Cells["SOUnit"].FormattedValue.ToString().Trim();
                    _cls1.INUnit = dgv1.Rows[i].Cells["INUnit"].FormattedValue.ToString().Trim();
                    _cls1.Crtd_DateTime = DateTime.Now;
                    _cls1.Crtd_Prog = _strPro;
                    _cls1.Crtd_User = Globals.PTUserName;
                    _cls1.LUpd_DateTime = DateTime.Now;//Parse(dgv1.Rows[i].Cells["LUpd_DateTime"].FormattedValue.ToString().Trim());
                    _cls1.LUpd_Prog = dgv1.Rows[i].Cells["LUpd_Prog"].FormattedValue.ToString().Trim();
                    _cls1.LUpd_User = dgv1.Rows[i].Cells["LUpd_User"].FormattedValue.ToString().Trim();
                    int kq;
                    if (_cls1.VendID != "" && _cls1.ClassID1 != "")
                        kq = IN104Ctrl.SaveINProductClass1(_cls1);
                }
                btnRefresh.RaiseClick();

            }


        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            Int32 _intTotalRow = dgv1.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (_intTotalRow > 0)
            {
                if (MessageBox.Show("Bạn có muốn xóa '" + _intTotalRow + "' dòng được chọn không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    for (int i = 0; i < _intTotalRow; i++)
                    {
                        int _row = Int16.Parse(dgv1.SelectedRows[i].Index.ToString());
                        _DeleteRow(_row);
                    }
                    _BindGrid1(txt1.Text);
                }

            }
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgv1.RowCount > 0)
            {
                int index = dgv1.CurrentRow.Index;
                if (index > -1)
                {
                    string _strVendID = dgv1.Rows[index].Cells["VendID"].FormattedValue.ToString();
                    string _strClassID1 = dgv1.Rows[index].Cells["ClassID1"].FormattedValue.ToString();
                    _BindGridByGrid1(_strVendID, _strClassID1);
                }
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ((DataTable)dgv2.DataSource).Rows.Add("");
            dgv2.CurrentCell = dgv2.Rows[dgv2.Rows.Count - 1].Cells[2];
            dgv2.CurrentCell.ReadOnly = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = true;
        }
    }
}
