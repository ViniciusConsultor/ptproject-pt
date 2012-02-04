namespace PT.Master
{
    public partial class GridEdit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bar1 = new DevComponents.DotNetBar.Bar();
            this.btnAdd = new DevComponents.DotNetBar.ButtonItem();
            this.labelItem5 = new DevComponents.DotNetBar.LabelItem();
            this.btnSave = new DevComponents.DotNetBar.ButtonItem();
            this.labelItem4 = new DevComponents.DotNetBar.LabelItem();
            this.btnRefresh = new DevComponents.DotNetBar.ButtonItem();
            this.labelItem3 = new DevComponents.DotNetBar.LabelItem();
            this.btnDelete = new DevComponents.DotNetBar.ButtonItem();
            this.labelItem2 = new DevComponents.DotNetBar.LabelItem();
            this.btnBack = new DevComponents.DotNetBar.ButtonItem();
            this.labelItem1 = new DevComponents.DotNetBar.LabelItem();
            this.pnl1 = new DevComponents.DotNetBar.PanelEx();
            this.pnl = new DevComponents.DotNetBar.PanelEx();
            this.dgv = new PT.Component.DataGridView(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).BeginInit();
            this.pnl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // bar1
            // 
            this.bar1.AntiAlias = true;
            this.bar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnAdd,
            this.labelItem5,
            this.btnSave,
            this.labelItem4,
            this.btnRefresh,
            this.labelItem3,
            this.btnDelete,
            this.labelItem2,
            this.btnBack,
            this.labelItem1});
            this.bar1.Location = new System.Drawing.Point(0, 0);
            this.bar1.Name = "bar1";
            this.bar1.Size = new System.Drawing.Size(670, 25);
            this.bar1.Stretch = true;
            this.bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bar1.TabIndex = 2;
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
            // labelItem5
            // 
            this.labelItem5.Name = "labelItem5";
            this.labelItem5.Text = "|";
            // 
            // btnSave
            // 
            this.btnSave.Name = "btnSave";
            this.btnSave.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlS);
            this.btnSave.Text = "Lưu";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // labelItem4
            // 
            this.labelItem4.Name = "labelItem4";
            this.labelItem4.Text = "|";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F5);
            this.btnRefresh.Text = "Refresh";
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
            // 
            // labelItem2
            // 
            this.labelItem2.Name = "labelItem2";
            this.labelItem2.Text = "|";
            // 
            // btnBack
            // 
            this.btnBack.Name = "btnBack";
            this.btnBack.Text = "Quay lại";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // labelItem1
            // 
            this.labelItem1.Name = "labelItem1";
            this.labelItem1.Text = "|";
            // 
            // pnl1
            // 
            this.pnl1.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnl1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.pnl1.Controls.Add(this.pnl);
            this.pnl1.Controls.Add(this.dgv);
            this.pnl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl1.Location = new System.Drawing.Point(0, 25);
            this.pnl1.Name = "pnl1";
            this.pnl1.Size = new System.Drawing.Size(670, 269);
            this.pnl1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.pnl1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.pnl1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.pnl1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.pnl1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnl1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnl1.Style.GradientAngle = 90;
            this.pnl1.TabIndex = 3;
            this.pnl1.Text = "panelEx1";
            // 
            // pnl
            // 
            this.pnl.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnl.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.pnl.Location = new System.Drawing.Point(12, 36);
            this.pnl.Name = "pnl";
            this.pnl.Size = new System.Drawing.Size(646, 221);
            this.pnl.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.pnl.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.pnl.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.pnl.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.pnl.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnl.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnl.Style.GradientAngle = 90;
            this.pnl.TabIndex = 1;
            this.pnl.Text = "panelEx1";
            // 
            // dgv
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgv.Location = new System.Drawing.Point(602, 6);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.Size = new System.Drawing.Size(56, 24);
            this.dgv.TabIndex = 0;
            this.dgv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellDoubleClick);
            this.dgv.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_RowHeaderMouseDoubleClick);
            // 
            // GridEdit
            // 
            this.ClientSize = new System.Drawing.Size(670, 294);
            this.Controls.Add(this.pnl1);
            this.Controls.Add(this.bar1);
            this.DoubleBuffered = true;
            this.Name = "GridEdit";
            this.Text = "GridEdit";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.GridEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).EndInit();
            this.pnl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public DevComponents.DotNetBar.Bar bar1;
        public DevComponents.DotNetBar.ButtonItem btnAdd;
        public DevComponents.DotNetBar.ButtonItem btnSave;
        public DevComponents.DotNetBar.ButtonItem btnRefresh;
        public DevComponents.DotNetBar.ButtonItem btnDelete;
        private DevComponents.DotNetBar.LabelItem labelItem5;
        private DevComponents.DotNetBar.LabelItem labelItem4;
        private DevComponents.DotNetBar.LabelItem labelItem3;
        private DevComponents.DotNetBar.LabelItem labelItem2;
        public DevComponents.DotNetBar.ButtonItem btnBack;
        private DevComponents.DotNetBar.LabelItem labelItem1;
        public DevComponents.DotNetBar.PanelEx pnl1;
        public PT.Component.DataGridView dgv;
        private DevComponents.DotNetBar.PanelEx pnl;
    }
}