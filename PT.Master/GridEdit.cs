using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace PT.Master
{
    public partial class GridEdit : DevComponents.DotNetBar.Office2007Form
    {
        private string _strPro;
        public GridEdit()
        {
            InitializeComponent();
        }
        public string strPro
        {
            get { return _strPro; }
            set { _strPro = value; }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
           
            pnl.Visible = true;
            dgv.Visible = false;
            btnBack.Enabled = true;
            btnSave.Enabled = true;

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            pnl.Visible = false;
            dgv.Visible = true;
            btnBack.Enabled = false;
        }

        private void GridEdit_Load(object sender, EventArgs e)
        {
            pnl.Visible = false;
            dgv.Dock = DockStyle.Fill;
            pnl.Dock = DockStyle.Fill;
            dgv.Visible = true;
            dgv.BringToFront();
            pnl.SendToBack();
            pnl.Visible = true;
            
            btnBack.Enabled = false;
            btnSave.Enabled = false;
            if (dgv.Rows.Count > 0)
            {
                btnDelete.Enabled = true;
                _SetVisibleGridColumn();
            }
            dgv.ReadOnly = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dgv.Rows.Count > 0)
                btnDelete.Enabled = true;
        }
        protected override bool ProcessCmdKey(ref System.Windows.Forms.Message msg, System.Windows.Forms.Keys keyData)
        {
            if (msg.WParam.ToInt32() == (int)Keys.Escape)
            {
                btnBack.RaiseClick();

                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        private void dgv_KeyDown(object sender, KeyEventArgs e)
        {
            int index;
            if (e.KeyCode == Keys.Up)
            {
                index = dgv.CurrentRow.Index - 1;
                if (index > -1)
                {
                    _DisplayStatusBar(index);
                }
            }

            if (e.KeyCode == Keys.Down)
            {
                index = dgv.CurrentRow.Index + 1;
                if (index < dgv.RowCount)
                {
                    _DisplayStatusBar(index);
                }
            }
        }
        private void _DisplayStatusBar(int row)
        {
            string _strCrtUser = dgv.Rows[row].Cells["Crtd_User"].FormattedValue.ToString();
            string _strMdfUser = dgv.Rows[row].Cells["LUpd_User"].FormattedValue.ToString();
            string _strCrtTime = dgv.Rows[row].Cells["Crtd_DateTime"].FormattedValue.ToString();
            string _strMdfTime = dgv.Rows[row].Cells["LUpd_DateTime"].FormattedValue.ToString();
            string _strCrtd_Prog = dgv.Rows[row].Cells["Crtd_Prog"].FormattedValue.ToString();

            txtProgID.Text = _strCrtd_Prog;
            txtCrtUser.Text = " by " + _strCrtUser;
            txtMdfUser.Text = " by " + _strMdfUser;
            txtCrtTime.Text = "Created at " + _strCrtTime;
            txtMdfTime.Text = "Modified at " + _strMdfTime;
        }
        private void _SetVisibleGridColumn()
        {
            dgv.Columns["Crtd_Prog"].Visible = false;
            dgv.Columns["Crtd_User"].Visible = false;
            dgv.Columns["LUpd_User"].Visible = false;
            dgv.Columns["Crtd_DateTime"].Visible = false;
            dgv.Columns["LUpd_DateTime"].Visible = false;
            dgv.Columns["Crtd_Prog"].Visible = false;
        }

        private void dgv_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgv.Dock = DockStyle.Fill;
            pnl.Dock = DockStyle.Fill;
            if (dgv.Rows.Count > 0)
            {
                _SetVisibleGridColumn();
                if (dgv.Rows.Count > 0 )
                    _DisplayStatusBar(dgv.CurrentRow.Index);
                btnDelete.Enabled = true;
                btnSave.Enabled = true;
            }
            pnl.Visible = false;
            dgv.Visible = true;
            // btnBack.Enabled = false;

            
            dgv.ReadOnly = true;
        }

        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            pnl.Visible = true;
            dgv.Visible = false;
            btnBack.Enabled = true;
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
                _DisplayStatusBar(e.RowIndex);
            
        }

    }
}