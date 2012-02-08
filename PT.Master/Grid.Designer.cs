using System.ComponentModel;
using System.Windows.Forms.Design;
namespace PT.Master
{

    public partial class Grid
    {

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        public void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bar1 = new DevComponents.DotNetBar.Bar();
            this.btnAdd = new DevComponents.DotNetBar.ButtonItem();
            this.labelItem1 = new DevComponents.DotNetBar.LabelItem();
            this.btnSave = new DevComponents.DotNetBar.ButtonItem();
            this.labelItem2 = new DevComponents.DotNetBar.LabelItem();
            this.btnRefresh = new DevComponents.DotNetBar.ButtonItem();
            this.labelItem3 = new DevComponents.DotNetBar.LabelItem();
            this.btnDelete = new DevComponents.DotNetBar.ButtonItem();
            this.labelItem4 = new DevComponents.DotNetBar.LabelItem();
            this.barStatus = new DevComponents.DotNetBar.Bar();
            this.lblUserName = new DevComponents.DotNetBar.LabelItem();
            this.dgv = new PT.Component.DataGridView(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // bar1
            // 
            this.bar1.AntiAlias = true;
            this.bar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnAdd,
            this.labelItem1,
            this.btnSave,
            this.labelItem2,
            this.btnRefresh,
            this.labelItem3,
            this.btnDelete,
            this.labelItem4});
            this.bar1.Location = new System.Drawing.Point(0, 0);
            this.bar1.Name = "bar1";
            this.bar1.Size = new System.Drawing.Size(743, 25);
            this.bar1.Stretch = true;
            this.bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bar1.TabIndex = 0;
            this.bar1.TabStop = false;
            this.bar1.Text = "bar1";
            // 
            // btnAdd
            // 
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlN);
            this.btnAdd.Text = "Thêm";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // labelItem1
            // 
            this.labelItem1.Name = "labelItem1";
            this.labelItem1.Text = "|";
            // 
            // btnSave
            // 
            this.btnSave.Name = "btnSave";
            this.btnSave.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlS);
            this.btnSave.Text = "Lưu";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // labelItem2
            // 
            this.labelItem2.Name = "labelItem2";
            this.labelItem2.Text = "|";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F5);
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // labelItem3
            // 
            this.labelItem3.Name = "labelItem3";
            this.labelItem3.Text = "|";
            // 
            // btnDelete
            // 
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.Del);
            this.btnDelete.Text = "Xóa";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // labelItem4
            // 
            this.labelItem4.Name = "labelItem4";
            this.labelItem4.Text = "|";
            // 
            // barStatus
            // 
            this.barStatus.AntiAlias = true;
            this.barStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barStatus.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.lblUserName});
            this.barStatus.Location = new System.Drawing.Point(0, 344);
            this.barStatus.Name = "barStatus";
            this.barStatus.Size = new System.Drawing.Size(743, 19);
            this.barStatus.Stretch = true;
            this.barStatus.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.barStatus.TabIndex = 2;
            this.barStatus.TabStop = false;
            this.barStatus.Text = "bar2";
            // 
            // lblUserName
            // 
            this.lblUserName.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.lblUserName.Name = "lblUserName";
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AutoColumnHeadder = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.EndCell = 0;
            this.dgv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgv.Language = "Language1";
            this.dgv.Location = new System.Drawing.Point(0, 25);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(743, 319);
            this.dgv.TabIndex = 3;
            this.dgv.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgv_DataBindingComplete);
            // 
            // Grid
            // 
            this.ClientSize = new System.Drawing.Size(743, 363);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.barStatus);
            this.Controls.Add(this.bar1);
            this.DoubleBuffered = true;
            this.Name = "Grid";
            this.Text = "Grid";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Grid_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public DevComponents.DotNetBar.Bar bar1;
        public DevComponents.DotNetBar.ButtonItem btnAdd;
        public DevComponents.DotNetBar.ButtonItem btnDelete;
        public DevComponents.DotNetBar.ButtonItem btnSave;
        public DevComponents.DotNetBar.ButtonItem btnRefresh;
        public DevComponents.DotNetBar.LabelItem labelItem1;
        public DevComponents.DotNetBar.LabelItem labelItem2;
        public DevComponents.DotNetBar.LabelItem labelItem3;
        public DevComponents.DotNetBar.LabelItem labelItem4;
        private IContainer components;
        public DevComponents.DotNetBar.Bar barStatus;
        public PT.Component.DataGridView dgv;
        private DevComponents.DotNetBar.LabelItem lblUserName;
        
    }
}