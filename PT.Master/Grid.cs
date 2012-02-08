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
    public partial class Grid : DevComponents.DotNetBar.Office2007Form
    {
        private int _EndCell;
        private string _strPro;
        public Grid()
        {
            InitializeComponent();
        }
        public string strPro
        {
            get { return _strPro; }
            set { _strPro = value; }
        }
        private void Grid_Load(object sender, EventArgs e)
        {
            if (dgv.Rows.Count > 0)
            {
                dgv.Columns[0].ReadOnly = true;
            }
           
        }

        private void dgv_DataSourceChanged(object sender, EventArgs e)
        {           
            if (dgv.Rows.Count > 0)
            {
                dgv.Columns[0].ReadOnly = true;
                btnDelete.Enabled = true;
                btnSave.Enabled = true;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {            
            ((DataTable)dgv.DataSource).Rows.Add("");
            dgv.CurrentCell = dgv.Rows[dgv.Rows.Count - 1].Cells[0];
            dgv.CurrentCell.ReadOnly = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = true;
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgv.Rows.Count > 0)
            {
                btnDelete.Enabled = true;
                btnSave.Enabled = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            
            if (dgv.Rows.Count > 0)
            {            
                btnDelete.Enabled = true;
                btnSave.Enabled = true;
            }
        }

        

        protected override bool ProcessCmdKey(ref System.Windows.Forms.Message msg, System.Windows.Forms.Keys keyData)
        {
            int _endcell = dgv.EndCell;
            if (_endcell == 0)
                _endcell = dgv.Rows.Count - 1;
            if (msg.WParam.ToInt32() == (int)Keys.Tab)
            {
                if (dgv.CurrentCell == dgv.Rows[dgv.Rows.Count - 1].Cells[_endcell])
                {
                    btnAdd.RaiseClick();
                    return true;
                }
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void dgv_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (dgv.Rows.Count > 0)
            {
                dgv.Columns[0].ReadOnly = true;
                btnDelete.Enabled = true;
                btnSave.Enabled = true;
            }
        }

       
        
    }
}