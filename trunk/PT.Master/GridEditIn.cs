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
    public partial class GridEditIn : DevComponents.DotNetBar.Office2007Form
    {
        public GridEditIn()
        {
            InitializeComponent();
        }

        private void GridEditIn_Load(object sender, EventArgs e)
        {
            //pnldgv.Visible = false;
            //pnldgv.Dock = DockStyle.Fill;
            //pnl.Visible = false;
            pnl.Dock = DockStyle.None;
            pnldgv.Visible = true;
            btnBack.Enabled = false;
            btnSave.Enabled = false;
            btnPrint.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            pnldgv.Visible = false;
            pnl.Dock = DockStyle.Fill;
            pnldgv.Dock = DockStyle.None;
            pnl.Visible = true;
            pnl.Enabled = true;
            pnldgv.Visible = false;
            btnBack.Enabled = true;
            btnSave.Enabled = true;
            btnPrint.Enabled = true;

            txtCrtUser.Text = "-";
            txtMdfUser.Text = "-";
            txtCrtTime.Text = "-";
            txtMdfTime.Text = "-";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            pnl.Visible = false;
            pnldgv.Dock = DockStyle.Fill;
            pnl.Dock = DockStyle.None;
            pnldgv.Visible = true;
            btnBack.Enabled = false;
            btnSave.Enabled = false;
            btnRelease.Enabled = false;
            btnDestroy.Enabled = false;
            btnCanAndCopy.Enabled = false;
            btnPrint.Enabled = false;
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

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                string _strCrtUser = dgv.Rows[e.RowIndex].Cells["Crtd_User"].FormattedValue.ToString();
                string _strMdfUser = dgv.Rows[e.RowIndex].Cells["LUpd_User"].FormattedValue.ToString();
                string _strCrtTime = dgv.Rows[e.RowIndex].Cells["Crtd_DateTime"].FormattedValue.ToString();
                string _strMdfTime = dgv.Rows[e.RowIndex].Cells["LUpd_DateTime"].FormattedValue.ToString();

                txtCrtUser.Text = " by " + _strCrtUser;
                txtMdfUser.Text = " by " + _strMdfUser;
                txtCrtTime.Text = "Created at " + _strCrtTime;
                txtMdfTime.Text = "Modified at " + _strMdfTime;
            }
        }

        private void dgv_KeyDown(object sender, KeyEventArgs e)
        {
            int index;
            if (e.KeyCode == Keys.Up)
            {
                index = dgv.CurrentRow.Index - 1;
                if (index > -1)
                {
                    string _strCrtUser = dgv.Rows[index].Cells["Crtd_User"].FormattedValue.ToString();
                    string _strMdfUser = dgv.Rows[index].Cells["LUpd_User"].FormattedValue.ToString();
                    string _strCrtTime = dgv.Rows[index].Cells["Crtd_DateTime"].FormattedValue.ToString();
                    string _strMdfTime = dgv.Rows[index].Cells["LUpd_DateTime"].FormattedValue.ToString();

                    txtCrtUser.Text = " by " + _strCrtUser;
                    txtMdfUser.Text = " by " + _strMdfUser;
                    txtCrtTime.Text = "Created at " + _strCrtTime;
                    txtMdfTime.Text = "Modified at " + _strMdfTime;
                }
            }

            if (e.KeyCode == Keys.Down)
            {
                index = dgv.CurrentRow.Index + 1;
                if (index < dgv.RowCount)
                {
                    string _strCrtUser = dgv.Rows[index].Cells["Crtd_User"].FormattedValue.ToString();
                    string _strMdfUser = dgv.Rows[index].Cells["LUpd_User"].FormattedValue.ToString();
                    string _strCrtTime = dgv.Rows[index].Cells["Crtd_DateTime"].FormattedValue.ToString();
                    string _strMdfTime = dgv.Rows[index].Cells["LUpd_DateTime"].FormattedValue.ToString();

                    txtCrtUser.Text = " by " + _strCrtUser;
                    txtMdfUser.Text = " by " + _strMdfUser;
                    txtCrtTime.Text = "Created at " + _strCrtTime;
                    txtMdfTime.Text = "Modified at " + _strMdfTime;
                }
            }
        }

        private void btnRelease_Click(object sender, EventArgs e)
        {
            btnDestroy.Enabled = true;
            btnCanAndCopy.Enabled = true;
            pnl.Enabled = false;
        }

        private void btnDestroy_Click(object sender, EventArgs e)
        {

        }
      
    }
}