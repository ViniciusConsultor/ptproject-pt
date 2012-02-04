using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace PT.Component
{
    [Designer(typeof(ControlDesigner))]   
    public partial class DataGridView : DevComponents.DotNetBar.Controls.DataGridViewX
    {
        public DataGridView() : base()
        {
        }

        public DataGridView(IContainer container)
        {
            container.Add(this);            
            InitializeComponent();            
        }
        private void _AutoNumberForGrid()
        {
            for (int i = 0; i < this.Rows.Count; i++)
            {
                Rows[i].HeaderCell.Value = (i + 1).ToString();
            }
            RowHeadersWidth = 55;
            RowHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            
        }
        protected override void OnDataSourceChanged(EventArgs e)
        {
            base.OnDataSourceChanged(e);
            _AutoNumberForGrid();

            
        }
        protected override void OnRowsAdded(DataGridViewRowsAddedEventArgs e)
        {
            base.OnRowsAdded(e);
            _AutoNumberForGrid();
        }
        
        protected override void OnCellEnter(DataGridViewCellEventArgs e)
        {
           
            base.OnCellEnter(e);            
        }

        protected override bool ProcessCmdKey(ref System.Windows.Forms.Message msg, System.Windows.Forms.Keys keyData)
        {
            if(msg.WParam.ToInt32() == (int) Keys.Enter)
            {
                    SendKeys.Send("{tab}");
                return true;
            }
             return base.ProcessCmdKey(ref msg, keyData);            
        }         
    }
}
