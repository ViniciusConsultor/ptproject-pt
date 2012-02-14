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
            pnldgv.Dock = DockStyle.Fill;
            pnl.Dock = DockStyle.None;
            pnl.SendToBack();
         
            btnBack.Enabled = false;
            btnSave.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {            
            pnl.Dock = DockStyle.Fill;
            pnldgv.Dock = DockStyle.None;
            pnldgv.SendToBack();
            btnBack.Enabled = true;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {            
            pnl.SendToBack();
            pnldgv.Dock = DockStyle.Fill;
            pnl.Dock = DockStyle.None;
            btnBack.Enabled = false;
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