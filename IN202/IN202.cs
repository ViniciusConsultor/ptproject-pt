using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PT.Helper;
using PT.Component;
using PT.DataInfo;
using PT.Master;

namespace IN202
{
    public partial class IN202 : PT.Master.GridEdit
    {
        string _strUser = "ADMIN";
        string _strPro = "IN103";

        public IN202()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
