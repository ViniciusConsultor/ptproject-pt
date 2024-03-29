namespace PT.Master
{
    partial class GridEdit2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bar1 = new DevComponents.DotNetBar.Bar();
            this.btnAdd = new DevComponents.DotNetBar.ButtonItem();
            this.labelItem5 = new DevComponents.DotNetBar.LabelItem();
            this.btnSave = new DevComponents.DotNetBar.ButtonItem();
            this.labelItem4 = new DevComponents.DotNetBar.LabelItem();
            this.btnRefresh = new DevComponents.DotNetBar.ButtonItem();
            this.labelItem3 = new DevComponents.DotNetBar.LabelItem();
            this.btnDelete = new DevComponents.DotNetBar.ButtonItem();
            this.labelItem2 = new DevComponents.DotNetBar.LabelItem();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.dgv2 = new PT.Component.DataGridView(this.components);
            this.dgv1 = new PT.Component.DataGridView(this.components);
            this.panelEx2 = new DevComponents.DotNetBar.PanelEx();
            this.txt2 = new PT.Component.MultiDropDownTextBox(this.components);
            this.txt1 = new PT.Component.MultiDropDownTextBox(this.components);
            this.lbl2 = new DevComponents.DotNetBar.LabelX();
            this.lbl1 = new DevComponents.DotNetBar.LabelX();
            this.barStatus = new DevComponents.DotNetBar.Bar();
            this.txtProgID = new DevComponents.DotNetBar.LabelItem();
            this.lblUserName = new DevComponents.DotNetBar.LabelItem();
            this.labelItem6 = new DevComponents.DotNetBar.LabelItem();
            this.txtCrtTime = new DevComponents.DotNetBar.LabelItem();
            this.txtCrtUser = new DevComponents.DotNetBar.LabelItem();
            this.labelItem7 = new DevComponents.DotNetBar.LabelItem();
            this.txtMdfTime = new DevComponents.DotNetBar.LabelItem();
            this.txtMdfUser = new DevComponents.DotNetBar.LabelItem();
            this.bar2 = new DevComponents.DotNetBar.Bar();
            this.lblProgID = new DevComponents.DotNetBar.LabelItem();
            this.labelItem9 = new DevComponents.DotNetBar.LabelItem();
            this.labelItem10 = new DevComponents.DotNetBar.LabelItem();
            this.lblCrtTime = new DevComponents.DotNetBar.LabelItem();
            this.lblCrtUser = new DevComponents.DotNetBar.LabelItem();
            this.labelItem13 = new DevComponents.DotNetBar.LabelItem();
            this.lblMdfTime = new DevComponents.DotNetBar.LabelItem();
            this.lblMdfUser = new DevComponents.DotNetBar.LabelItem();
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).BeginInit();
            this.panelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.panelEx2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bar2)).BeginInit();
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
            this.labelItem2});
            this.bar1.Location = new System.Drawing.Point(0, 0);
            this.bar1.Name = "bar1";
            this.bar1.Size = new System.Drawing.Size(569, 25);
            this.bar1.Stretch = true;
            this.bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bar1.TabIndex = 3;
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
            // 
            // labelItem2
            // 
            this.labelItem2.Name = "labelItem2";
            this.labelItem2.Text = "|";
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.dgv2);
            this.panelEx1.Controls.Add(this.dgv1);
            this.panelEx1.Controls.Add(this.panelEx2);
            this.panelEx1.Controls.Add(this.barStatus);
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 25);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(569, 237);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 4;
            this.panelEx1.Text = "panelEx1";
            // 
            // dgv2
            // 
            this.dgv2.AutoColumnHeadder = true;
            this.dgv2.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv2.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv2.EndCell = 0;
            this.dgv2.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgv2.Language = "Language1";
            this.dgv2.Location = new System.Drawing.Point(32, 135);
            this.dgv2.Name = "dgv2";
            this.dgv2.Size = new System.Drawing.Size(240, 58);
            this.dgv2.TabIndex = 6;
            this.dgv2.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgv2_DataBindingComplete);
            this.dgv2.DataSourceChanged += new System.EventHandler(this.dgv2_DataSourceChanged);
            // 
            // dgv1
            // 
            this.dgv1.AutoColumnHeadder = true;
            this.dgv1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv1.EndCell = 0;
            this.dgv1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgv1.Language = "Language1";
            this.dgv1.Location = new System.Drawing.Point(13, 73);
            this.dgv1.Name = "dgv1";
            this.dgv1.Size = new System.Drawing.Size(240, 56);
            this.dgv1.TabIndex = 5;
            // 
            // panelEx2
            // 
            this.panelEx2.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx2.Controls.Add(this.txt2);
            this.panelEx2.Controls.Add(this.txt1);
            this.panelEx2.Controls.Add(this.lbl2);
            this.panelEx2.Controls.Add(this.lbl1);
            this.panelEx2.Location = new System.Drawing.Point(13, 22);
            this.panelEx2.Name = "panelEx2";
            this.panelEx2.Size = new System.Drawing.Size(476, 45);
            this.panelEx2.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx2.Style.GradientAngle = 90;
            this.panelEx2.TabIndex = 4;
            // 
            // txt2
            // 
            this.txt2.AutoComplete = false;
            this.txt2.AutoReSizeColumn = false;
            // 
            // 
            // 
            this.txt2.Border.Class = "TextBoxBorder";
            this.txt2.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt2.ColumnHeaders = "";
            this.txt2.ColumnNames = "";
            this.txt2.ColumnWidthDefault = 75;
            this.txt2.ColumnWidths = "";
            this.txt2.DataSource = null;
            this.txt2.Language = "Language1";
            this.txt2.Location = new System.Drawing.Point(260, 11);
            this.txt2.Name = "txt2";
            this.txt2.RowsDisplay = 10;
            this.txt2.Size = new System.Drawing.Size(100, 20);
            this.txt2.TabIndex = 6;
            // 
            // txt1
            // 
            this.txt1.AutoComplete = false;
            this.txt1.AutoReSizeColumn = false;
            // 
            // 
            // 
            this.txt1.Border.Class = "TextBoxBorder";
            this.txt1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt1.ColumnHeaders = "";
            this.txt1.ColumnNames = "";
            this.txt1.ColumnWidthDefault = 75;
            this.txt1.ColumnWidths = "";
            this.txt1.DataSource = null;
            this.txt1.Language = "Language1";
            this.txt1.Location = new System.Drawing.Point(61, 11);
            this.txt1.Name = "txt1";
            this.txt1.RowsDisplay = 10;
            this.txt1.Size = new System.Drawing.Size(100, 20);
            this.txt1.TabIndex = 5;
            // 
            // lbl2
            // 
            // 
            // 
            // 
            this.lbl2.BackgroundStyle.Class = "";
            this.lbl2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl2.Location = new System.Drawing.Point(215, 11);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(64, 23);
            this.lbl2.TabIndex = 4;
            this.lbl2.Text = "labelX1";
            // 
            // lbl1
            // 
            // 
            // 
            // 
            this.lbl1.BackgroundStyle.Class = "";
            this.lbl1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl1.Location = new System.Drawing.Point(19, 11);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(64, 23);
            this.lbl1.TabIndex = 4;
            this.lbl1.Text = "labelX1";
            // 
            // barStatus
            // 
            this.barStatus.AntiAlias = true;
            this.barStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barStatus.DockSide = DevComponents.DotNetBar.eDockSide.Document;
            this.barStatus.Location = new System.Drawing.Point(0, 235);
            this.barStatus.Name = "barStatus";
            this.barStatus.Size = new System.Drawing.Size(569, 2);
            this.barStatus.Stretch = true;
            this.barStatus.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.barStatus.TabIndex = 3;
            this.barStatus.TabStop = false;
            this.barStatus.Text = "bar2";
            // 
            // txtProgID
            // 
            this.txtProgID.Name = "txtProgID";
            this.txtProgID.Text = "ProgID";
            // 
            // lblUserName
            // 
            this.lblUserName.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.lblUserName.Name = "lblUserName";
            // 
            // labelItem6
            // 
            this.labelItem6.Name = "labelItem6";
            this.labelItem6.Text = "||";
            // 
            // txtCrtTime
            // 
            this.txtCrtTime.Name = "txtCrtTime";
            this.txtCrtTime.Text = "CrtTime";
            // 
            // txtCrtUser
            // 
            this.txtCrtUser.Name = "txtCrtUser";
            this.txtCrtUser.Text = "CrtUser";
            // 
            // labelItem7
            // 
            this.labelItem7.Name = "labelItem7";
            this.labelItem7.Text = "|";
            // 
            // txtMdfTime
            // 
            this.txtMdfTime.Name = "txtMdfTime";
            this.txtMdfTime.Text = "MdfTime";
            // 
            // txtMdfUser
            // 
            this.txtMdfUser.Name = "txtMdfUser";
            this.txtMdfUser.Text = "MdfUser";
            // 
            // bar2
            // 
            this.bar2.AntiAlias = true;
            this.bar2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bar2.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.lblProgID,
            this.labelItem9,
            this.labelItem10,
            this.lblCrtTime,
            this.lblCrtUser,
            this.labelItem13,
            this.lblMdfTime,
            this.lblMdfUser});
            this.bar2.Location = new System.Drawing.Point(0, 243);
            this.bar2.Name = "bar2";
            this.bar2.Size = new System.Drawing.Size(569, 19);
            this.bar2.Stretch = true;
            this.bar2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bar2.TabIndex = 6;
            this.bar2.TabStop = false;
            this.bar2.Text = "bar2";
            // 
            // lblProgID
            // 
            this.lblProgID.Name = "lblProgID";
            this.lblProgID.Text = "ProgID";
            // 
            // labelItem9
            // 
            this.labelItem9.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.labelItem9.Name = "labelItem9";
            // 
            // labelItem10
            // 
            this.labelItem10.Name = "labelItem10";
            this.labelItem10.Text = "||";
            // 
            // lblCrtTime
            // 
            this.lblCrtTime.Name = "lblCrtTime";
            this.lblCrtTime.Text = "CrtTime";
            // 
            // lblCrtUser
            // 
            this.lblCrtUser.Name = "lblCrtUser";
            this.lblCrtUser.Text = "CrtUser";
            // 
            // labelItem13
            // 
            this.labelItem13.Name = "labelItem13";
            this.labelItem13.Text = "|";
            // 
            // lblMdfTime
            // 
            this.lblMdfTime.Name = "lblMdfTime";
            this.lblMdfTime.Text = "MdfTime";
            // 
            // lblMdfUser
            // 
            this.lblMdfUser.Name = "lblMdfUser";
            this.lblMdfUser.Text = "MdfUser";
            // 
            // GridEdit2
            // 
            this.ClientSize = new System.Drawing.Size(569, 262);
            this.Controls.Add(this.bar2);
            this.Controls.Add(this.panelEx1);
            this.Controls.Add(this.bar1);
            this.Name = "GridEdit2";
            this.Text = "GridEdit2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.GridEdit2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).EndInit();
            this.panelEx1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.panelEx2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.barStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bar2)).EndInit();
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
        private DevComponents.DotNetBar.PanelEx panelEx1;
        public DevComponents.DotNetBar.Bar barStatus;
        public DevComponents.DotNetBar.LabelItem txtProgID;
        private DevComponents.DotNetBar.LabelItem lblUserName;
        private DevComponents.DotNetBar.LabelItem labelItem6;
        private DevComponents.DotNetBar.LabelItem txtCrtTime;
        private DevComponents.DotNetBar.LabelItem txtCrtUser;
        private DevComponents.DotNetBar.LabelItem labelItem7;
        private DevComponents.DotNetBar.LabelItem txtMdfTime;
        private DevComponents.DotNetBar.LabelItem txtMdfUser;
        public DevComponents.DotNetBar.Bar bar2;
        public DevComponents.DotNetBar.LabelItem lblProgID;
        private DevComponents.DotNetBar.LabelItem labelItem9;
        private DevComponents.DotNetBar.LabelItem labelItem10;
        private DevComponents.DotNetBar.LabelItem lblCrtTime;
        private DevComponents.DotNetBar.LabelItem lblCrtUser;
        private DevComponents.DotNetBar.LabelItem labelItem13;
        private DevComponents.DotNetBar.LabelItem lblMdfTime;
        private DevComponents.DotNetBar.LabelItem lblMdfUser;
        private DevComponents.DotNetBar.PanelEx panelEx2;
        public PT.Component.DataGridView dgv1;
        public PT.Component.DataGridView dgv2;
        public DevComponents.DotNetBar.LabelX lbl2;
        public DevComponents.DotNetBar.LabelX lbl1;
        public PT.Component.MultiDropDownTextBox txt1;
        public PT.Component.MultiDropDownTextBox txt2;
    }
}