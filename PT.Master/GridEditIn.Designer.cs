namespace PT.Master
{
    partial class GridEditIn
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
            this.buttonItem1 = new DevComponents.DotNetBar.ButtonItem();
            this.labelItem6 = new DevComponents.DotNetBar.LabelItem();
            this.buttonItem2 = new DevComponents.DotNetBar.ButtonItem();
            this.labelItem1 = new DevComponents.DotNetBar.LabelItem();
            this.btnBack = new DevComponents.DotNetBar.ButtonItem();
            this.labelItem7 = new DevComponents.DotNetBar.LabelItem();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.pnldgv = new DevComponents.DotNetBar.PanelEx();
            this.dgv = new PT.Component.DataGridView(this.components);
            this.pnlhead = new DevComponents.DotNetBar.PanelEx();
            this.pnl = new DevComponents.DotNetBar.PanelEx();
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).BeginInit();
            this.panelEx1.SuspendLayout();
            this.pnldgv.SuspendLayout();
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
            this.buttonItem1,
            this.labelItem6,
            this.buttonItem2,
            this.labelItem1,
            this.btnBack,
            this.labelItem7});
            this.bar1.Location = new System.Drawing.Point(0, 0);
            this.bar1.Name = "bar1";
            this.bar1.Size = new System.Drawing.Size(684, 25);
            this.bar1.Stretch = true;
            this.bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bar1.TabIndex = 4;
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
            // buttonItem1
            // 
            this.buttonItem1.Enabled = false;
            this.buttonItem1.Name = "buttonItem1";
            this.buttonItem1.Text = "Cập nhật";
            // 
            // labelItem6
            // 
            this.labelItem6.Name = "labelItem6";
            this.labelItem6.Text = "|";
            // 
            // buttonItem2
            // 
            this.buttonItem2.Enabled = false;
            this.buttonItem2.Name = "buttonItem2";
            this.buttonItem2.Text = "Hủy";
            // 
            // labelItem1
            // 
            this.labelItem1.Name = "labelItem1";
            this.labelItem1.Text = "|";
            // 
            // btnBack
            // 
            this.btnBack.Name = "btnBack";
            this.btnBack.Text = "Quay lại";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // labelItem7
            // 
            this.labelItem7.Name = "labelItem7";
            this.labelItem7.Text = "|";
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.pnldgv);
            this.panelEx1.Controls.Add(this.pnl);
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 25);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(684, 537);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 5;
            // 
            // pnldgv
            // 
            this.pnldgv.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnldgv.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.pnldgv.Controls.Add(this.dgv);
            this.pnldgv.Controls.Add(this.pnlhead);
            this.pnldgv.Location = new System.Drawing.Point(12, 6);
            this.pnldgv.Name = "pnldgv";
            this.pnldgv.Size = new System.Drawing.Size(105, 80);
            this.pnldgv.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.pnldgv.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.pnldgv.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.pnldgv.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.pnldgv.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnldgv.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnldgv.Style.GradientAngle = 90;
            this.pnldgv.TabIndex = 1;
            this.pnldgv.Text = "pnldgv";
            // 
            // dgv
            // 
            this.dgv.AutoColumnHeadder = true;
            this.dgv.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.EndCell = 0;
            this.dgv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgv.Language = "Language1";
            this.dgv.Location = new System.Drawing.Point(0, 45);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(105, 35);
            this.dgv.TabIndex = 1;
            // 
            // pnlhead
            // 
            this.pnlhead.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnlhead.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.pnlhead.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlhead.Location = new System.Drawing.Point(0, 0);
            this.pnlhead.Name = "pnlhead";
            this.pnlhead.Size = new System.Drawing.Size(105, 45);
            this.pnlhead.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.pnlhead.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.pnlhead.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.pnlhead.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.pnlhead.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnlhead.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnlhead.Style.GradientAngle = 90;
            this.pnlhead.TabIndex = 0;
            // 
            // pnl
            // 
            this.pnl.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnl.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.pnl.Location = new System.Drawing.Point(46, 240);
            this.pnl.Name = "pnl";
            this.pnl.Size = new System.Drawing.Size(356, 127);
            this.pnl.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.pnl.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.pnl.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.pnl.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.pnl.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnl.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnl.Style.GradientAngle = 90;
            this.pnl.TabIndex = 0;
            this.pnl.Text = "pnl";
            // 
            // GridEditIn
            // 
            this.ClientSize = new System.Drawing.Size(684, 562);
            this.Controls.Add(this.panelEx1);
            this.Controls.Add(this.bar1);
            this.Name = "GridEditIn";
            this.Text = "GridEditIn";
            this.Load += new System.EventHandler(this.GridEditIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).EndInit();
            this.panelEx1.ResumeLayout(false);
            this.pnldgv.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public DevComponents.DotNetBar.Bar bar1;
        public DevComponents.DotNetBar.ButtonItem btnAdd;
        private DevComponents.DotNetBar.LabelItem labelItem5;
        public DevComponents.DotNetBar.ButtonItem btnSave;
        private DevComponents.DotNetBar.LabelItem labelItem4;
        public DevComponents.DotNetBar.ButtonItem btnRefresh;
        private DevComponents.DotNetBar.LabelItem labelItem3;
        public DevComponents.DotNetBar.ButtonItem btnDelete;
        private DevComponents.DotNetBar.LabelItem labelItem2;
        private DevComponents.DotNetBar.ButtonItem buttonItem1;
        private DevComponents.DotNetBar.LabelItem labelItem6;
        private DevComponents.DotNetBar.ButtonItem buttonItem2;
        private DevComponents.DotNetBar.LabelItem labelItem1;
        public DevComponents.DotNetBar.ButtonItem btnBack;
        private DevComponents.DotNetBar.LabelItem labelItem7;
        private DevComponents.DotNetBar.PanelEx panelEx1;
        public DevComponents.DotNetBar.PanelEx pnldgv;
        public DevComponents.DotNetBar.PanelEx pnl;
        public DevComponents.DotNetBar.PanelEx pnlhead;
        public PT.Component.DataGridView dgv;
    }
}