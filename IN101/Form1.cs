using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PT.Master;
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
            dgv.DataSource = ConnectDB.GetAll("INProduct");            
        }

        private void dgv_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
  //          MessageBox.Show("add");
        }

        private void dgv_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            MessageBox.Show("add");

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
        }

    }
}
