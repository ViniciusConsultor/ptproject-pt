using System;   
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace PT.Component
{
    public partial class MultiDataGridView : DevComponents.DotNetBar.Controls.DataGridViewX
    {
        public MultiDataGridView()
        {
            InitializeComponent();
        }

        public MultiDataGridView(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
        protected override void  OnCellBeginEdit(System.Windows.Forms.DataGridViewCellCancelEventArgs e)
{
     //base.OnCellBeginEdit(e);
            int x, y;
            DataGridView dg = new DataGridView();
            dg.Height = 100;
            dg.Width = 100;
            dg.Visible = true;
            dg.BringToFront();
   // MessageBox.Show("SDF");
        }
    }
}
