using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.WinForms.Drawing;
using PT.MainCtl;
using PT.Helper;
using System.Reflection;

using System.Diagnostics;
using System.Runtime.InteropServices;



namespace PT.Manager
{
    public partial class Main : DevComponents.DotNetBar.Office2007RibbonForm
    {
        private static DataTable _DataTableMenu = new DataTable();

        public Main()
        {
            InitializeComponent();
           
        }
      

        private void Main_Load(object sender, EventArgs e)
        {
            //SALanguageCtl.WriteXML();
            //SAMenuCtl.WriteXML();
            _DataTableMenu = SAMenuCtl.ReadXML();
            eplMain.Expanded = false;
           
        }

        private void btnWH_Click(object sender, EventArgs e)
        {
            Clear();
            ReFresh();
            Globals.PTManagerMenu = (int)Globals.MenuStatus.Kho_hanghoa;
            DataTable _dt = new DataTable();
            eplMain.TitleText = "Kho - Hàng Hóa";
            DataRow[] _dr = _DataTableMenu.Select("ModuleID='IN'");
            foreach (DataRow dr in _dr)
            {
                bool flag = false;
                foreach (ButtonItem  a in itemPanelList.Items)
                {
                    if (a.Text == dr["Descr"].ToString())
                    {
                        flag = true;
                        break;
                    }
                }
                foreach (ButtonItem a in itemPanelInPut.Items)
                {
                    if (a.Text == dr["Descr"].ToString())
                    {
                        flag = true;
                        break;
                    }
                }
                foreach (ButtonItem a in itemPanelLookup.Items)
                {
                    if (a.Text == dr["Descr"].ToString())
                    {
                        flag = true;
                        break;
                    }
                }
                foreach (ButtonItem a in itemPanelReport.Items)
                {
                    if (a.Text == dr["Descr"].ToString())
                    {
                        flag = true;
                        break;
                    }
                }
                if (flag == false)
                {
                    ButtonItem bt = new ButtonItem();
                    bt.Text = dr["Descr"].ToString();
                    bt.Name = dr["ScreenID"].ToString();                    
                    bt.Click += new EventHandler(bt_Click);

                    if (dr["MenuType"].ToString() == "LIST")
                        itemPanelList.Items.Add(bt);
                    else
                        if (dr["MenuType"].ToString() == "INPUT")
                            itemPanelInPut.Items.Add(bt);
                        else
                            if (dr["MenuType"].ToString() == "LOK")
                                itemPanelLookup.Items.Add(bt);
                            else
                                itemPanelReport.Items.Add(bt);


                }
                
            }

            ReFresh();

            
        }

        void bt_Click(object sender, EventArgs e)
        {
            
            ButtonItem bt = (ButtonItem)sender;
            //bt.Name = "Form1";
            //string assemblyName = "PT.Manager.DataForm";
            //object o = Activator.CreateInstance(assemblyName, "Form1", null);
            //((Form)o).Show();
            
            string typeName = "PT.Manager.DataForm." + bt.Name;
            //AP001.AP001 a = new AP001.AP001();
            //a.Show();
           
            //((Form)o).Activated += new EventHandler(Main_Activated);

            bool flag = false;
            foreach (Form a in MdiChildren)
            {
                if (a.Name == bt.Name)
                {
                    a.BringToFront();
                    //a.Activate();
            
                    //MessageBox.Show("Co roi");
                    flag = true;
                    return;
                }
            }
            if (flag == false)
            {
                
                
                object o = Assembly.GetExecutingAssembly().CreateInstance(typeName);                
                if (((Form)o) == null)
                {
                    MessageBox.Show("Man hinh nay bi loi hoac khong ton tai", "Canh bao");
                    return;
                }
                ((Form)o).WindowState = FormWindowState.Maximized;
                ((Form)o).Text = bt.Text;
                ((Form)o).Name = bt.Name;           
                ((Form)o).MdiParent = Main.ActiveForm;                
                ((Form)o).Show();
            }
        }

        void Main_Activated(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            ((Form)sender).WindowState = FormWindowState.Maximized;
        }
       

        private void btnWH_Product_Input_Click(object sender, EventArgs e)
        {
            Clear();
            ReFresh();
            
            eplMain.TitleText = "Mua Hàng";
            
            Globals.PTManagerMenu = (int)Globals.MenuStatus.Kho_hanghoa;
            DataTable _dt = new DataTable();

            DataRow[] _dr = _DataTableMenu.Select("ModuleID='OUT'");
            foreach (DataRow dr in _dr)
            {
                bool flag = false;
                foreach (ButtonItem a in itemPanelList.Items)
                {
                    if (a.Name == dr["ScreenID"].ToString())
                    {
                        flag = true;
                        break;
                    }
                }
                foreach (ButtonItem a in itemPanelInPut.Items)
                {
                    if (a.Name == dr["ScreenID"].ToString())
                    {
                        flag = true;
                        break;
                    }
                }
                foreach (ButtonItem a in itemPanelLookup.Items)
                {
                    if (a.Name == dr["ScreenID"].ToString())
                    {
                        flag = true;
                        break;
                    }
                }
                foreach (ButtonItem a in itemPanelReport.Items)
                {
                    if (a.Name == dr["ScreenID"].ToString())
                    {
                        flag = true;
                        break;
                    }
                }
                if (flag == false)
                {
                    ButtonItem bt = new ButtonItem();
                    bt.Text = dr["Descr"].ToString();
                    bt.Name = dr["ScreenID"].ToString();
                    bt.Click += new EventHandler(bt_Click);

                    if (dr["MenuType"].ToString() == "LIST")
                        itemPanelList.Items.Add(bt);
                    else
                        if (dr["MenuType"].ToString() == "INPUT")
                            itemPanelInPut.Items.Add(bt);
                        else
                            if (dr["MenuType"].ToString() == "LOK")
                                itemPanelLookup.Items.Add(bt);
                            else
                                itemPanelReport.Items.Add(bt);


                }

            }


            ReFresh();
        }

        private void btnSys_Menu_Click(object sender, EventArgs e)
        {

            Globals.PTManagerMenu = (int)Globals.MenuStatus.Quantrimenu;
            eplMain.TitleText = "Mua hang";
            eplMain.Expanded = true;
            eplList.TitleText = "Menu";
            
            eplInput.Visible = false;
            eplLookup.Visible = false;
            eplReport.Visible = false;
            eplMain.Refresh();
        }

       

        private void rclMain_Click(object sender, EventArgs e)
        {

        }
        private void ReFresh()
        {
            eplMain.Expanded = true;
            eplLookup.Visible = true;
            eplList.Visible = true;
            eplReport.Visible = true;
            eplInput.Visible = true;
            eplMain.Visible = true;
            eplMain.Refresh();
            eplLookup.Refresh();
            eplList.Refresh();
            eplReport.Refresh();
            eplInput.Refresh();
            eplMain.Refresh();
            itemPanelList.AutoSize = true;
            eplList.Height = itemPanelList.Height + eplList.TitleHeight;
            itemPanelInPut.AutoSize = true;
            eplInput.Height = itemPanelInPut.Height + eplInput.TitleHeight;
            itemPanelLookup.AutoSize = true;
            eplLookup.Height = itemPanelLookup.Height + eplLookup.TitleHeight;
            itemPanelReport.AutoSize = true;
            eplReport.Height = itemPanelReport.Height + eplReport.TitleHeight;
        }
        private void ReDraw()
        {
            
        }
        private void Clear()
        {
            itemPanelList.AutoSize = true;
            itemPanelList.Height = 0;
            itemPanelList.Items.Clear();
            itemPanelList.ResetText();
            itemPanelList.Refresh();
            itemPanelInPut.Items.Clear();
            itemPanelInPut.Refresh();
            itemPanelLookup.Items.Clear();
            itemPanelLookup.Refresh();
            itemPanelReport.Items.Clear();
            itemPanelReport.Refresh();
            itemPanelReport.Height = 0;
        }

        //[DllImport("user32.dll", SetLastError = true)]
        //private static extern uint SetParent(IntPtr hWndChild, IntPtr hWndNewParent);
        private void btnWH_Product_Lookup_Click(object sender, EventArgs e)
        {
            // string str = @"C:\windows\system32\notepad.exe";
            // string str = @"C:\windows\system32\winamp.exe";

            string str = @"D:\ap002.exe";
            this.Focus();
            Native.LoadProcessInControl("notepad.exe",this);
            //System.Diagnostics.Process p = System.Diagnostics.Process.Start(str);
            //p.WaitForInputIdle();

            //SetParent(p.MainWindowHandle, this.eplReport.Handle);
            
           
        //    Process process = new Process();
        //    process.StartInfo.FileName = str;
            
        //    process.Start();
        }
    }
}
       


