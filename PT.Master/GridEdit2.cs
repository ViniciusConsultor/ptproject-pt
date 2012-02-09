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
    public partial class GridEdit2 : DevComponents.DotNetBar.Office2007Form
    {
        private int _EndCell;
        private string _strPro;
        public bool _IsChange = false;
        private string _strCell = "";

        public GridEdit2()
        {
            InitializeComponent();
            panelEx2.Dock = DockStyle.Top;
            dgv1.Dock = DockStyle.Top;
            dgv1.Height = this.Width / 2;
            dgv2.Dock = DockStyle.Fill;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ((DataTable)dgv1.DataSource).Rows.Add("");
            dgv1.CurrentCell = dgv1.Rows[dgv1.Rows.Count - 1].Cells[1];
            dgv1.CurrentCell.ReadOnly = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = true;
        }

        private void GridEdit2_Load(object sender, EventArgs e)
        {
            if (dgv1.Rows.Count > 0)
            {
                dgv1.Columns[1].ReadOnly = true;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if (dgv1.Rows.Count > 0)
            {
                btnDelete.Enabled = true;
                btnSave.Enabled = true;
            }
        }
        protected override bool ProcessCmdKey(ref System.Windows.Forms.Message msg, System.Windows.Forms.Keys keyData)
        {
            int _endcell = dgv1.EndCell;
            if (_endcell == 0)
                _endcell = dgv1.Rows.Count - 1;
            if (msg.WParam.ToInt32() == (int)Keys.Tab)
            {
                if (dgv1.CurrentCell == dgv1.Rows[dgv1.Rows.Count - 1].Cells[_endcell])
                {
                    btnAdd.RaiseClick();
                    return true;
                }
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void dgv1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (dgv1.Rows.Count > 0)
            {
                dgv1.Columns[0].ReadOnly = true;
                btnDelete.Enabled = true;
                btnSave.Enabled = true;
            }
        }

        private void dgv1_DataSourceChanged(object sender, EventArgs e)
        {
            if (dgv1.Rows.Count > 0)
            {
                dgv1.Columns[0].ReadOnly = true;
                btnDelete.Enabled = true;
                btnSave.Enabled = true;
            }
        }



        private void dgv1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            string _strCrtUser = dgv1.Rows[e.RowIndex].Cells["Crtd_User"].FormattedValue.ToString();
            string _strMdfUser = dgv1.Rows[e.RowIndex].Cells["LUpd_User"].FormattedValue.ToString();
            string _strCrtTime = dgv1.Rows[e.RowIndex].Cells["Crtd_DateTime"].FormattedValue.ToString();
            string _strMdfTime = dgv1.Rows[e.RowIndex].Cells["LUpd_DateTime"].FormattedValue.ToString();

            lblCrtUser.Text = " by " + _strCrtUser;
            lblMdfUser.Text = " by " + _strMdfUser;
            lblCrtTime.Text = "Created at " + _strCrtTime;
            lblMdfTime.Text = "Modified at " + _strMdfTime;

        }

        private void dgv1_KeyDown_1(object sender, KeyEventArgs e)
        {
            int index;
            if (e.KeyCode == Keys.Up)
            {
                index = dgv1.CurrentRow.Index - 1;
                if (index > -1)
                {
                    string _strCrtUser = dgv1.Rows[index].Cells["Crtd_User"].FormattedValue.ToString();
                    string _strMdfUser = dgv1.Rows[index].Cells["LUpd_User"].FormattedValue.ToString();
                    string _strCrtTime = dgv1.Rows[index].Cells["Crtd_DateTime"].FormattedValue.ToString();
                    string _strMdfTime = dgv1.Rows[index].Cells["LUpd_DateTime"].FormattedValue.ToString();

                    lblCrtUser.Text = " by " + _strCrtUser;
                    lblMdfUser.Text = " by " + _strMdfUser;
                    lblCrtTime.Text = "Created at " + _strCrtTime;
                    lblMdfTime.Text = "Modified at " + _strMdfTime;
                }
            }

            if (e.KeyCode == Keys.Down)
            {
                index = dgv1.CurrentRow.Index + 1;
                if (index < dgv1.RowCount)
                {
                    string _strCrtUser = dgv1.Rows[index].Cells["Crtd_User"].FormattedValue.ToString();
                    string _strMdfUser = dgv1.Rows[index].Cells["LUpd_User"].FormattedValue.ToString();
                    string _strCrtTime = dgv1.Rows[index].Cells["Crtd_DateTime"].FormattedValue.ToString();
                    string _strMdfTime = dgv1.Rows[index].Cells["LUpd_DateTime"].FormattedValue.ToString();

                    lblCrtUser.Text = " by " + _strCrtUser;
                    lblMdfUser.Text = " by " + _strMdfUser;
                    lblCrtTime.Text = "Created at " + _strCrtTime;
                    lblMdfTime.Text = "Modified at " + _strMdfTime;
                }
            }
        }

        private void txt1_TextChanged(object sender, EventArgs e)
        {
            btnRefresh.RaiseClick();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
      
    }
}