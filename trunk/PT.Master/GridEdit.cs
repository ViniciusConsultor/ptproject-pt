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
        public GridEdit()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            gdv.SendToBack();
            btnBack.Enabled = true;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            pnl.SendToBack();
            btnBack.Enabled = false;
        }

        private void GridEdit_Load(object sender, EventArgs e)
        {
            btnBack.Enabled = false;
            btnSave.Enabled = false;
            if (gdv.Rows.Count > 0)
                btnDelete.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (gdv.Rows.Count > 0)
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
    }
}