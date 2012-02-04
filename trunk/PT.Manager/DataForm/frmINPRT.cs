using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using PT.MainCtl;

namespace PT.Manager.DataForm
{
    public partial class frmINPRT : DevComponents.DotNetBar.Office2007Form
    {
        DataTable dt = new DataTable();
        public frmINPRT()
        {
            InitializeComponent();
        }

        private void frmINPRT_Load(object sender, EventArgs e)
        {
            pnlView.Dock = DockStyle.Fill;
            //dt = PT.DataController.IN_ProductCtrl.GetDatatable();
            dataGridViewX1.DataSource = dt;
            dataGridViewX1.Refresh();
            _SetGridColumVisible();
            _SetColumSize();
        }

        private void multiColumnComboBox1_DropDown(object sender, EventArgs e)
        {
         //   multiColumnComboBox1.DataSource = PT.DataController.AP_VendorCtl.GetDatatable();
            multiColumnComboBox1.ColumnNames = "VendID,VendName";
            multiColumnComboBox1.DisplayMember = "VendID";
            multiColumnComboBox1.ValueMember = "VendName";
            multiColumnComboBox1.ColumnWidths = "70,200";
            multiColumnComboBox1.AutoComplete = true;
            multiColumnComboBox1.LinkedColumnIndex = 1;
        }

        private void multiColumnComboBox2_DropDown(object sender, EventArgs e)
        {

            String _strVendID = multiColumnComboBox1.Text;
          //  multiColumnComboBox2.DataSource = PT.DataController.IN_ProductClassCtrl.GetByKey(_strVendID);
            multiColumnComboBox2.ColumnNames = "ClassID,Descr";
            multiColumnComboBox2.DisplayMember = "ClassID";
            multiColumnComboBox2.ValueMember = "Descr";
            multiColumnComboBox2.ColumnWidths = "70,200";
            multiColumnComboBox2.AutoComplete = true;
            multiColumnComboBox2.LinkedColumnIndex = 1;
        }

        private void multiColumnComboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            dt.DefaultView.RowFilter = string.Format("VendID like '%{0}%'", multiColumnComboBox1.Text) + string.Format("AND Descr LIKE '%{0}%'", textBoxX1.Text);
            multiColumnComboBox2.Text = "";
        }

        private void multiColumnComboBox2_SelectedValueChanged(object sender, EventArgs e)
        {
            dt.DefaultView.RowFilter = string.Format("ClassID like '%{0}%'", multiColumnComboBox2.Text) + string.Format("AND Descr LIKE '%{0}%'", textBoxX1.Text);
            multiColumnComboBox2.Text = "";
        }

        private void textBoxX1_TextChanged(object sender, EventArgs e)
        {
            dt.DefaultView.RowFilter = string.Format("Descr LIKE '%{0}%'", textBoxX1.Text) + string.Format(" AND ClassID like '%{0}%'", multiColumnComboBox2.Text) +
                string.Format(" AND VendID like '%{0}%'", multiColumnComboBox1.Text);
        }

        protected void _SetGridColumVisible()
        {
            dataGridViewX1.Columns["ClassID"].Visible = false;
            dataGridViewX1.Columns["VendID"].Visible = false;
            dataGridViewX1.Columns["POFromUnitPrice"].Visible = false;
            dataGridViewX1.Columns["POToUnitPrice"].Visible = false;
            dataGridViewX1.Columns["POPriStartDate"].Visible = false;
            dataGridViewX1.Columns["SOFromUnitPrice"].Visible = false;
            dataGridViewX1.Columns["SOToUnitPrice"].Visible = false;
            dataGridViewX1.Columns["SOPriStartDate"].Visible = false;
            dataGridViewX1.Columns["Color"].Visible = false;
            dataGridViewX1.Columns["DfltPOUnit"].Visible = false;
            dataGridViewX1.Columns["DfltSOUnit"].Visible = false;
            dataGridViewX1.Columns["Picture"].Visible = false;
            dataGridViewX1.Columns["PriceClassID"].Visible = false;
            dataGridViewX1.Columns["Size"].Visible = false;
            dataGridViewX1.Columns["StkVol"].Visible = false;
            dataGridViewX1.Columns["StkWt"].Visible = false;
            dataGridViewX1.Columns["Style"].Visible = false;
            dataGridViewX1.Columns["Crtd_DateTime"].Visible = false;
            dataGridViewX1.Columns["Crtd_Prog"].Visible = false;
            dataGridViewX1.Columns["Crtd_User"].Visible = false;
            dataGridViewX1.Columns["LUpd_DateTime"].Visible = false;
            dataGridViewX1.Columns["LUpd_Prog"].Visible = false;
            dataGridViewX1.Columns["LUpd_User"].Visible = false;
        }

        protected void _SetColumSize()
        {
            //dataGridViewX1.Columns["ProductID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewX1.Columns["Descr"].Width = 250;
            //dataGridViewX1.Columns["Status"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            //dataGridViewX1.Columns["FromUnit"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            //dataGridViewX1.Columns["ToUnit"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            //dataGridViewX1.Columns["Cnvfact"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            //dataGridViewX1.Columns["StkUnit"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            //dataGridViewX1.Columns["DfltSite"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            //dataGridViewX1.Columns["DfltTax"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            //dataGridViewX1.Columns["ClassName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewX1.Columns["VendName"].Width = 200;

        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            pnlView.Visible = false;
            pnlEdit.Visible = true;
            pnlEdit.Dock = DockStyle.Fill;
        }

        private void buttonX5_Click(object sender, EventArgs e)
        {
            pnlView.Visible = true;
            pnlEdit.Visible = false;
            //pnlEdit.Dock = DockStyle.Fill;
        }

        private void comboBoxEx1_SelectedIndexChanged(object sender, EventArgs e)
        {
           // comboBoxEx1.DataSource = PT.DataController.AP_VendorCtl.GetDatatable();
            comboBoxEx1.DisplayMember = "VendID";
            comboBoxEx1.ValueMember = "VendName";
        }

        private void frmINPRT_KeyDown(object sender, KeyEventArgs e)
        {
                
         
        }

        private void multiColumnComboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void multiColumnComboBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void multiColumnComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}