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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            dgv.CurrentCell = dgv.Rows[dgv.Rows.Count - 1].Cells[0];
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

        private void gdv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv.Rows.Count > 0)
                btnDelete.Enabled = true;
        }

        private void Grid_Load(object sender, EventArgs e)
        {
            if (dgv.Rows.Count > 0)
            {
                dgv.Columns[0].ReadOnly = true;
                btnDelete.Enabled = true;
                btnSave.Enabled = true;
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
        
    }
}