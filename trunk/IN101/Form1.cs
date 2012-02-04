using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using PT.Helper;

namespace IN101
{
    public partial class Form1 : PT.Master.GridEdit
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //DataTable _dt_grdWH = new DataTable();
            //_dt_grdWH = 
            gdv.DataSource = ConnectDB.GetAll("INProduct");
            //_SetGridColumVisible();
            //_setColumSite();
            //_AutoNumberForGrid(grdWH);
            //grdWH.Refresh();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
