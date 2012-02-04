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
       // public string _DataSource = "";
        public DataGridView() : base()
        { }

        //public DataGridView()
        //{
        //    InitializeComponent();
        //    //_AutoNumberForGrid();
        //}

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
        //protected override void OnKeyDown(KeyEventArgs e)
        //{
        //    base.OnKeyDown(e);
        //    if (e.KeyCode == Keys.Enter)
        //    {
        //        MessageBox.Show("OnKeyDown",this.CurrentCell.Value.ToString());
        //    }
        //}
        //protected override void OnKeyPress(KeyPressEventArgs e)
        //{
        //    base.OnKeyPress(e);
        //    if (e.KeyChar  == (char)Keys.Enter)
        //    {
        //        MessageBox.Show("OnKeyDown",this.CurrentCell.Value.ToString());
        //    }
        //}
        //protected override void OnKeyUp(KeyEventArgs e)
        //{
        //    base.OnKeyUp(e);
        //    if (e.KeyCode == Keys.Enter)
        //    {
        //        MessageBox.Show("OnKeyUp", this.CurrentCell.Value.ToString());
        //        SendKeys.SendWait("{right}");
        //    }
        //}
        protected override void OnCellEnter(DataGridViewCellEventArgs e)
        {
           
            base.OnCellEnter(e);
            //this.BeginEdit(true);
            
            
            
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
