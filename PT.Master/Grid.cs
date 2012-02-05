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
        public Grid()
        {
            InitializeComponent();
        }

        private void Grid_Load(object sender, EventArgs e)
        {
            if (dgv.Rows.Count > 0)
            {
                dgv.Columns[0].ReadOnly = true;
            }
            //btnSave.Enabled = false;

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
            //MessageBox.Show("Save");
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
            if (msg.WParam.ToInt32() == (int)Keys.Tab)
            {
                if (dgv.CurrentCell == dgv.Rows[dgv.Rows.Count - 1].Cells[dgv.Columns.Count - 1])
                {
                    btnAdd.RaiseClick();
                    return true;
                }
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
       
        
    }
}