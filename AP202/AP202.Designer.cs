namespace AP202
{
    partial class AP202
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cmbUser = new PT.Component.MultiColumnComboBox();
            this.labelX14 = new PT.Component.NormalLabel();
            this.dtmToDate = new PT.Component.NormalDateTimeInput();
            this.labelX17 = new PT.Component.NormalLabel();
            this.labelX1 = new PT.Component.NormalLabel();
            this.cmbAdjAcct = new PT.Component.MultiColumnComboBox();
            this.labelX5 = new PT.Component.NormalLabel();
            this.cmbStatus = new PT.Component.MultiColumnComboBox();
            this.cmbBranchID = new PT.Component.MultiColumnComboBox();
            this.dtmAdjDate = new PT.Component.NormalDateTimeInput();
            this.labelX8 = new PT.Component.NormalLabel();
            this.labelX4 = new PT.Component.NormalLabel();
            this.labelX9 = new PT.Component.NormalLabel();
            this.labelBranchID = new PT.Component.NormalLabel();
            this.txtAdjAmt = new PT.Component.NumericTextBox();
            this.labelX2 = new PT.Component.NormalLabel();
            this.panelEx2 = new DevComponents.DotNetBar.PanelEx();
            this.txtAdjNbr = new PT.Component.NormalTextBox();
            this.txtAdjDescr = new PT.Component.NormalTextBox();
            this.panelEx3 = new DevComponents.DotNetBar.PanelEx();
            this.dtmToDateLoad = new PT.Component.NormalDateTimeInput();
            this.btnLoad = new DevComponents.DotNetBar.ButtonX();
            this.txtVendIDLoad = new PT.Component.MultiDropDownTextBox(this.components);
            this.dtmFromDateLoad = new PT.Component.NormalDateTimeInput();
            this.labelX6 = new PT.Component.NormalLabel();
            this.labelVendID = new PT.Component.NormalLabel();
            this.labelX10 = new PT.Component.NormalLabel();
            this.PONbr = new PT.Component.NormalLabel();
            this.labelX3 = new PT.Component.NormalLabel();
            this.btnCheck = new DevComponents.DotNetBar.ButtonX();
            this.txtInvcNbr = new PT.Component.NormalTextBox();
            this.txtPoNbr = new PT.Component.NormalTextBox();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.dgvDocList = new PT.Component.DataGridView(this.components);
            this.txtAdjNbrFind = new PT.Component.NormalTextBox();
            this.normalLabel1 = new PT.Component.NormalLabel();
            this.normalLabel2 = new PT.Component.NormalLabel();
            this.dtmFromDate = new PT.Component.NormalDateTimeInput();
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).BeginInit();
            this.pnldgv.SuspendLayout();
            this.pnl.SuspendLayout();
            this.pnlhead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barStatus)).BeginInit();
            this.panelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtmToDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtmAdjDate)).BeginInit();
            this.panelEx2.SuspendLayout();
            this.panelEx3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtmToDateLoad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtmFromDateLoad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtmFromDate)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSave
            // 
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // 
            // btnBack
            // 
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // pnldgv
            // 
            this.pnldgv.Size = new System.Drawing.Size(555, 58);
            this.pnldgv.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.pnldgv.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.pnldgv.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.pnldgv.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.pnldgv.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnldgv.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnldgv.Style.GradientAngle = 90;
            // 
            // pnl
            // 
            this.pnl.Controls.Add(this.dgvDocList);
            this.pnl.Controls.Add(this.panelEx3);
            this.pnl.Controls.Add(this.panelEx2);
            this.pnl.Location = new System.Drawing.Point(15, 92);
            this.pnl.Size = new System.Drawing.Size(757, 397);
            this.pnl.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.pnl.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.pnl.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.pnl.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.pnl.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnl.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnl.Style.GradientAngle = 90;
            // 
            // pnlhead
            // 
            this.pnlhead.Controls.Add(this.dtmFromDate);
            this.pnlhead.Controls.Add(this.normalLabel2);
            this.pnlhead.Controls.Add(this.normalLabel1);
            this.pnlhead.Controls.Add(this.txtAdjNbrFind);
            this.pnlhead.Controls.Add(this.cmbUser);
            this.pnlhead.Controls.Add(this.labelX17);
            this.pnlhead.Controls.Add(this.dtmToDate);
            this.pnlhead.Controls.Add(this.labelX14);
            this.pnlhead.Size = new System.Drawing.Size(555, 54);
            this.pnlhead.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.pnlhead.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.pnlhead.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.pnlhead.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.pnlhead.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnlhead.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnlhead.Style.GradientAngle = 90;
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.Location = new System.Drawing.Point(0, 54);
            this.dgv.ReadOnly = true;
            this.dgv.Size = new System.Drawing.Size(555, 4);
            this.dgv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellDoubleClick);
            // 
            // btnRelease
            // 
            this.btnRelease.Click += new System.EventHandler(this.btnRelease_Click);
            // 
            // panelEx1
            // 
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            // 
            // btnDestroy
            // 
            this.btnDestroy.Click += new System.EventHandler(this.btnDestroy_Click);
            // 
            // btnCanAndCopy
            // 
            this.btnCanAndCopy.Click += new System.EventHandler(this.btnCanAndCopy_Click);
            // 
            // cmbUser
            // 
            this.cmbUser.AutoComplete = false;
            this.cmbUser.AutoDropdown = false;
            this.cmbUser.BackColorEven = System.Drawing.Color.White;
            this.cmbUser.BackColorOdd = System.Drawing.Color.White;
            this.cmbUser.ColumnNames = "";
            this.cmbUser.ColumnWidthDefault = 75;
            this.cmbUser.ColumnWidths = "";
            this.cmbUser.DisplayMember = "Text";
            this.cmbUser.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbUser.FormattingEnabled = true;
            this.cmbUser.ItemHeight = 14;
            this.cmbUser.LinkedColumnIndex = 0;
            this.cmbUser.LinkedTextBox = null;
            this.cmbUser.Location = new System.Drawing.Point(12, 24);
            this.cmbUser.Name = "cmbUser";
            this.cmbUser.Size = new System.Drawing.Size(100, 20);
            this.cmbUser.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmbUser.TabIndex = 36;
            // 
            // labelX14
            // 
            // 
            // 
            // 
            this.labelX14.BackgroundStyle.Class = "";
            this.labelX14.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX14.Location = new System.Drawing.Point(382, 5);
            this.labelX14.Name = "labelX14";
            this.labelX14.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelX14.Size = new System.Drawing.Size(100, 20);
            this.labelX14.TabIndex = 34;
            this.labelX14.Text = "AdjdNbr";
            // 
            // dtmToDate
            // 
            // 
            // 
            // 
            this.dtmToDate.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtmToDate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtmToDate.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtmToDate.ButtonDropDown.Visible = true;
            this.dtmToDate.IsPopupCalendarOpen = false;
            this.dtmToDate.Location = new System.Drawing.Point(260, 24);
            // 
            // 
            // 
            this.dtmToDate.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtmToDate.MonthCalendar.BackgroundStyle.Class = "";
            this.dtmToDate.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtmToDate.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtmToDate.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtmToDate.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtmToDate.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtmToDate.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtmToDate.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtmToDate.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtmToDate.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.dtmToDate.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtmToDate.MonthCalendar.DisplayMonth = new System.DateTime(2012, 2, 1, 0, 0, 0, 0);
            this.dtmToDate.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dtmToDate.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtmToDate.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtmToDate.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtmToDate.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtmToDate.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.dtmToDate.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtmToDate.MonthCalendar.TodayButtonVisible = true;
            this.dtmToDate.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dtmToDate.Name = "dtmToDate";
            this.dtmToDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dtmToDate.Size = new System.Drawing.Size(100, 20);
            this.dtmToDate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtmToDate.TabIndex = 30;
            // 
            // labelX17
            // 
            // 
            // 
            // 
            this.labelX17.BackgroundStyle.Class = "";
            this.labelX17.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX17.Location = new System.Drawing.Point(260, 5);
            this.labelX17.Name = "labelX17";
            this.labelX17.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelX17.Size = new System.Drawing.Size(100, 20);
            this.labelX17.TabIndex = 32;
            this.labelX17.Text = "ToDate";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(408, 16);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(50, 15);
            this.labelX1.TabIndex = 71;
            this.labelX1.Text = "AdjAcct";
            // 
            // cmbAdjAcct
            // 
            this.cmbAdjAcct.AutoComplete = false;
            this.cmbAdjAcct.AutoDropdown = false;
            this.cmbAdjAcct.BackColorEven = System.Drawing.Color.White;
            this.cmbAdjAcct.BackColorOdd = System.Drawing.Color.White;
            this.cmbAdjAcct.ColumnNames = "";
            this.cmbAdjAcct.ColumnWidthDefault = 75;
            this.cmbAdjAcct.ColumnWidths = "";
            this.cmbAdjAcct.DisplayMember = "Text";
            this.cmbAdjAcct.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbAdjAcct.FormattingEnabled = true;
            this.cmbAdjAcct.ItemHeight = 14;
            this.cmbAdjAcct.LinkedColumnIndex = 0;
            this.cmbAdjAcct.LinkedTextBox = null;
            this.cmbAdjAcct.Location = new System.Drawing.Point(467, 13);
            this.cmbAdjAcct.Name = "cmbAdjAcct";
            this.cmbAdjAcct.Size = new System.Drawing.Size(100, 20);
            this.cmbAdjAcct.TabIndex = 70;
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.Class = "";
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(10, 72);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(50, 15);
            this.labelX5.TabIndex = 68;
            this.labelX5.Text = "DocDescr";
            // 
            // cmbStatus
            // 
            this.cmbStatus.AutoComplete = false;
            this.cmbStatus.AutoDropdown = false;
            this.cmbStatus.BackColorEven = System.Drawing.Color.White;
            this.cmbStatus.BackColorOdd = System.Drawing.Color.White;
            this.cmbStatus.ColumnNames = "";
            this.cmbStatus.ColumnWidthDefault = 75;
            this.cmbStatus.ColumnWidths = "";
            this.cmbStatus.DisplayMember = "Text";
            this.cmbStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbStatus.Enabled = false;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.ItemHeight = 14;
            this.cmbStatus.LinkedColumnIndex = 0;
            this.cmbStatus.LinkedTextBox = null;
            this.cmbStatus.Location = new System.Drawing.Point(69, 40);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(100, 20);
            this.cmbStatus.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmbStatus.TabIndex = 67;
            // 
            // cmbBranchID
            // 
            this.cmbBranchID.AutoComplete = false;
            this.cmbBranchID.AutoDropdown = false;
            this.cmbBranchID.BackColorEven = System.Drawing.Color.White;
            this.cmbBranchID.BackColorOdd = System.Drawing.Color.White;
            this.cmbBranchID.ColumnNames = "";
            this.cmbBranchID.ColumnWidthDefault = 75;
            this.cmbBranchID.ColumnWidths = "";
            this.cmbBranchID.DisplayMember = "Text";
            this.cmbBranchID.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbBranchID.FormattingEnabled = true;
            this.cmbBranchID.ItemHeight = 14;
            this.cmbBranchID.LinkedColumnIndex = 0;
            this.cmbBranchID.LinkedTextBox = null;
            this.cmbBranchID.Location = new System.Drawing.Point(69, 13);
            this.cmbBranchID.Name = "cmbBranchID";
            this.cmbBranchID.Size = new System.Drawing.Size(100, 20);
            this.cmbBranchID.TabIndex = 58;
            // 
            // dtmAdjDate
            // 
            // 
            // 
            // 
            this.dtmAdjDate.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtmAdjDate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtmAdjDate.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtmAdjDate.ButtonDropDown.Visible = true;
            this.dtmAdjDate.IsPopupCalendarOpen = false;
            this.dtmAdjDate.Location = new System.Drawing.Point(268, 42);
            // 
            // 
            // 
            this.dtmAdjDate.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtmAdjDate.MonthCalendar.BackgroundStyle.Class = "";
            this.dtmAdjDate.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtmAdjDate.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtmAdjDate.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtmAdjDate.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtmAdjDate.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtmAdjDate.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtmAdjDate.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtmAdjDate.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtmAdjDate.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.dtmAdjDate.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtmAdjDate.MonthCalendar.DisplayMonth = new System.DateTime(2012, 2, 1, 0, 0, 0, 0);
            this.dtmAdjDate.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dtmAdjDate.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtmAdjDate.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtmAdjDate.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtmAdjDate.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtmAdjDate.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.dtmAdjDate.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtmAdjDate.MonthCalendar.TodayButtonVisible = true;
            this.dtmAdjDate.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dtmAdjDate.Name = "dtmAdjDate";
            this.dtmAdjDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dtmAdjDate.Size = new System.Drawing.Size(100, 20);
            this.dtmAdjDate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtmAdjDate.TabIndex = 62;
            // 
            // labelX8
            // 
            // 
            // 
            // 
            this.labelX8.BackgroundStyle.Class = "";
            this.labelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX8.Location = new System.Drawing.Point(10, 42);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(50, 15);
            this.labelX8.TabIndex = 64;
            this.labelX8.Text = "Status";
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.Class = "";
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(209, 18);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(50, 15);
            this.labelX4.TabIndex = 63;
            this.labelX4.Text = "AdjNbr";
            // 
            // labelX9
            // 
            // 
            // 
            // 
            this.labelX9.BackgroundStyle.Class = "";
            this.labelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX9.Location = new System.Drawing.Point(209, 45);
            this.labelX9.Name = "labelX9";
            this.labelX9.Size = new System.Drawing.Size(50, 15);
            this.labelX9.TabIndex = 60;
            this.labelX9.Text = "AdjDate";
            // 
            // labelBranchID
            // 
            // 
            // 
            // 
            this.labelBranchID.BackgroundStyle.Class = "";
            this.labelBranchID.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelBranchID.Location = new System.Drawing.Point(10, 15);
            this.labelBranchID.Name = "labelBranchID";
            this.labelBranchID.Size = new System.Drawing.Size(50, 15);
            this.labelBranchID.TabIndex = 59;
            this.labelBranchID.Text = "BranchID";
            // 
            // txtAdjAmt
            // 
            this.txtAdjAmt.AllowSpace = false;
            // 
            // 
            // 
            this.txtAdjAmt.Border.Class = "TextBoxBorder";
            this.txtAdjAmt.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtAdjAmt.Location = new System.Drawing.Point(467, 43);
            this.txtAdjAmt.Name = "txtAdjAmt";
            this.txtAdjAmt.Size = new System.Drawing.Size(100, 20);
            this.txtAdjAmt.TabIndex = 72;
            this.txtAdjAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.Class = "";
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(408, 47);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(50, 15);
            this.labelX2.TabIndex = 73;
            this.labelX2.Text = "AdjAmt";
            // 
            // panelEx2
            // 
            this.panelEx2.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx2.Controls.Add(this.txtAdjNbr);
            this.panelEx2.Controls.Add(this.txtAdjDescr);
            this.panelEx2.Controls.Add(this.labelX2);
            this.panelEx2.Controls.Add(this.txtAdjAmt);
            this.panelEx2.Controls.Add(this.labelX1);
            this.panelEx2.Controls.Add(this.cmbAdjAcct);
            this.panelEx2.Controls.Add(this.labelX5);
            this.panelEx2.Controls.Add(this.cmbBranchID);
            this.panelEx2.Controls.Add(this.cmbStatus);
            this.panelEx2.Controls.Add(this.labelBranchID);
            this.panelEx2.Controls.Add(this.dtmAdjDate);
            this.panelEx2.Controls.Add(this.labelX9);
            this.panelEx2.Controls.Add(this.labelX8);
            this.panelEx2.Controls.Add(this.labelX4);
            this.panelEx2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEx2.Location = new System.Drawing.Point(0, 0);
            this.panelEx2.Name = "panelEx2";
            this.panelEx2.Size = new System.Drawing.Size(757, 101);
            this.panelEx2.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx2.Style.GradientAngle = 90;
            this.panelEx2.TabIndex = 74;
            // 
            // txtAdjNbr
            // 
            // 
            // 
            // 
            this.txtAdjNbr.Border.Class = "TextBoxBorder";
            this.txtAdjNbr.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtAdjNbr.Location = new System.Drawing.Point(266, 18);
            this.txtAdjNbr.Name = "txtAdjNbr";
            this.txtAdjNbr.Size = new System.Drawing.Size(100, 20);
            this.txtAdjNbr.TabIndex = 75;
            // 
            // txtAdjDescr
            // 
            // 
            // 
            // 
            this.txtAdjDescr.Border.Class = "TextBoxBorder";
            this.txtAdjDescr.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtAdjDescr.Location = new System.Drawing.Point(69, 67);
            this.txtAdjDescr.Name = "txtAdjDescr";
            this.txtAdjDescr.Size = new System.Drawing.Size(299, 20);
            this.txtAdjDescr.TabIndex = 74;
            // 
            // panelEx3
            // 
            this.panelEx3.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx3.Controls.Add(this.dtmToDateLoad);
            this.panelEx3.Controls.Add(this.btnLoad);
            this.panelEx3.Controls.Add(this.txtVendIDLoad);
            this.panelEx3.Controls.Add(this.dtmFromDateLoad);
            this.panelEx3.Controls.Add(this.labelX6);
            this.panelEx3.Controls.Add(this.labelVendID);
            this.panelEx3.Controls.Add(this.labelX10);
            this.panelEx3.Controls.Add(this.PONbr);
            this.panelEx3.Controls.Add(this.labelX3);
            this.panelEx3.Controls.Add(this.btnCheck);
            this.panelEx3.Controls.Add(this.txtInvcNbr);
            this.panelEx3.Controls.Add(this.txtPoNbr);
            this.panelEx3.Controls.Add(this.shapeContainer1);
            this.panelEx3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEx3.Location = new System.Drawing.Point(0, 101);
            this.panelEx3.Name = "panelEx3";
            this.panelEx3.Size = new System.Drawing.Size(757, 58);
            this.panelEx3.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx3.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx3.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx3.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx3.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx3.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx3.Style.GradientAngle = 90;
            this.panelEx3.TabIndex = 75;
            // 
            // dtmToDateLoad
            // 
            // 
            // 
            // 
            this.dtmToDateLoad.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtmToDateLoad.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtmToDateLoad.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtmToDateLoad.ButtonDropDown.Visible = true;
            this.dtmToDateLoad.IsPopupCalendarOpen = false;
            this.dtmToDateLoad.Location = new System.Drawing.Point(139, 27);
            // 
            // 
            // 
            this.dtmToDateLoad.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtmToDateLoad.MonthCalendar.BackgroundStyle.Class = "";
            this.dtmToDateLoad.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtmToDateLoad.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtmToDateLoad.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtmToDateLoad.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtmToDateLoad.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtmToDateLoad.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtmToDateLoad.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtmToDateLoad.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtmToDateLoad.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.dtmToDateLoad.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtmToDateLoad.MonthCalendar.DisplayMonth = new System.DateTime(2012, 2, 1, 0, 0, 0, 0);
            this.dtmToDateLoad.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dtmToDateLoad.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtmToDateLoad.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtmToDateLoad.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtmToDateLoad.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtmToDateLoad.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.dtmToDateLoad.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtmToDateLoad.MonthCalendar.TodayButtonVisible = true;
            this.dtmToDateLoad.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dtmToDateLoad.Name = "dtmToDateLoad";
            this.dtmToDateLoad.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dtmToDateLoad.Size = new System.Drawing.Size(100, 20);
            this.dtmToDateLoad.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtmToDateLoad.TabIndex = 59;
            // 
            // btnLoad
            // 
            this.btnLoad.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnLoad.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnLoad.Location = new System.Drawing.Point(380, 26);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnLoad.TabIndex = 64;
            this.btnLoad.Text = "Load";
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // txtVendIDLoad
            // 
            this.txtVendIDLoad.AutoComplete = false;
            this.txtVendIDLoad.AutoReSizeColumn = true;
            // 
            // 
            // 
            this.txtVendIDLoad.Border.Class = "TextBoxBorder";
            this.txtVendIDLoad.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtVendIDLoad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtVendIDLoad.ColumnHeaders = "";
            this.txtVendIDLoad.ColumnNames = "";
            this.txtVendIDLoad.ColumnWidthDefault = 75;
            this.txtVendIDLoad.ColumnWidths = "";
            this.txtVendIDLoad.DataSource = null;
            this.txtVendIDLoad.Language = "Language1";
            this.txtVendIDLoad.Location = new System.Drawing.Point(264, 27);
            this.txtVendIDLoad.Name = "txtVendIDLoad";
            this.txtVendIDLoad.RowsDisplay = 10;
            this.txtVendIDLoad.Size = new System.Drawing.Size(100, 20);
            this.txtVendIDLoad.TabIndex = 62;
            // 
            // dtmFromDateLoad
            // 
            // 
            // 
            // 
            this.dtmFromDateLoad.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtmFromDateLoad.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtmFromDateLoad.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtmFromDateLoad.ButtonDropDown.Visible = true;
            this.dtmFromDateLoad.IsPopupCalendarOpen = false;
            this.dtmFromDateLoad.Location = new System.Drawing.Point(14, 27);
            // 
            // 
            // 
            this.dtmFromDateLoad.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtmFromDateLoad.MonthCalendar.BackgroundStyle.Class = "";
            this.dtmFromDateLoad.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtmFromDateLoad.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtmFromDateLoad.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtmFromDateLoad.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtmFromDateLoad.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtmFromDateLoad.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtmFromDateLoad.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtmFromDateLoad.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtmFromDateLoad.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.dtmFromDateLoad.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtmFromDateLoad.MonthCalendar.DisplayMonth = new System.DateTime(2012, 2, 1, 0, 0, 0, 0);
            this.dtmFromDateLoad.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dtmFromDateLoad.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtmFromDateLoad.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtmFromDateLoad.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtmFromDateLoad.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtmFromDateLoad.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.dtmFromDateLoad.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtmFromDateLoad.MonthCalendar.TodayButtonVisible = true;
            this.dtmFromDateLoad.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dtmFromDateLoad.Name = "dtmFromDateLoad";
            this.dtmFromDateLoad.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dtmFromDateLoad.Size = new System.Drawing.Size(100, 20);
            this.dtmFromDateLoad.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtmFromDateLoad.TabIndex = 58;
            // 
            // labelX6
            // 
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.Class = "";
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Location = new System.Drawing.Point(14, 8);
            this.labelX6.Name = "labelX6";
            this.labelX6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelX6.Size = new System.Drawing.Size(100, 20);
            this.labelX6.TabIndex = 61;
            this.labelX6.Text = "FromDate";
            // 
            // labelVendID
            // 
            // 
            // 
            // 
            this.labelVendID.BackgroundStyle.Class = "";
            this.labelVendID.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelVendID.Location = new System.Drawing.Point(264, 10);
            this.labelVendID.Name = "labelVendID";
            this.labelVendID.Size = new System.Drawing.Size(50, 15);
            this.labelVendID.TabIndex = 63;
            this.labelVendID.Text = "VendID";
            // 
            // labelX10
            // 
            // 
            // 
            // 
            this.labelX10.BackgroundStyle.Class = "";
            this.labelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX10.Location = new System.Drawing.Point(585, 10);
            this.labelX10.Name = "labelX10";
            this.labelX10.Size = new System.Drawing.Size(50, 15);
            this.labelX10.TabIndex = 69;
            this.labelX10.Text = "InvcNbr";
            // 
            // PONbr
            // 
            // 
            // 
            // 
            this.PONbr.BackgroundStyle.Class = "";
            this.PONbr.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.PONbr.Location = new System.Drawing.Point(499, 10);
            this.PONbr.Name = "PONbr";
            this.PONbr.Size = new System.Drawing.Size(50, 15);
            this.PONbr.TabIndex = 65;
            this.PONbr.Text = "PONbr";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.Class = "";
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(139, 8);
            this.labelX3.Name = "labelX3";
            this.labelX3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelX3.Size = new System.Drawing.Size(100, 20);
            this.labelX3.TabIndex = 60;
            this.labelX3.Text = "ToDate";
            // 
            // btnCheck
            // 
            this.btnCheck.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCheck.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCheck.Location = new System.Drawing.Point(658, 24);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(75, 23);
            this.btnCheck.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCheck.TabIndex = 68;
            this.btnCheck.Text = "Check";
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // txtInvcNbr
            // 
            // 
            // 
            // 
            this.txtInvcNbr.Border.Class = "TextBoxBorder";
            this.txtInvcNbr.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtInvcNbr.Location = new System.Drawing.Point(585, 28);
            this.txtInvcNbr.Name = "txtInvcNbr";
            this.txtInvcNbr.Size = new System.Drawing.Size(66, 20);
            this.txtInvcNbr.TabIndex = 67;
            this.txtInvcNbr.TextChanged += new System.EventHandler(this.txtInvcNbr_TextChanged);
            // 
            // txtPoNbr
            // 
            // 
            // 
            // 
            this.txtPoNbr.Border.Class = "TextBoxBorder";
            this.txtPoNbr.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtPoNbr.Location = new System.Drawing.Point(499, 28);
            this.txtPoNbr.Name = "txtPoNbr";
            this.txtPoNbr.Size = new System.Drawing.Size(72, 20);
            this.txtPoNbr.TabIndex = 66;
            this.txtPoNbr.TextChanged += new System.EventHandler(this.txtPoNbr_TextChanged);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(757, 58);
            this.shapeContainer1.TabIndex = 70;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 475;
            this.lineShape1.X2 = 475;
            this.lineShape1.Y1 = -1;
            this.lineShape1.Y2 = 59;
            // 
            // dgvDocList
            // 
            this.dgvDocList.AllowUserToAddRows = false;
            this.dgvDocList.AllowUserToOrderColumns = true;
            this.dgvDocList.AllowUserToResizeColumns = false;
            this.dgvDocList.AutoColumnHeadder = true;
            this.dgvDocList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDocList.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDocList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDocList.EndCell = 0;
            this.dgvDocList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvDocList.Language = "Language1";
            this.dgvDocList.Location = new System.Drawing.Point(0, 159);
            this.dgvDocList.Name = "dgvDocList";
            this.dgvDocList.Size = new System.Drawing.Size(757, 238);
            this.dgvDocList.TabIndex = 76;
            this.dgvDocList.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDocList_CellContentDoubleClick);
            this.dgvDocList.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgvDocList_CellValidating);
            this.dgvDocList.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDocList_CellEndEdit);
            this.dgvDocList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDocList_CellContentClick);
            // 
            // txtAdjNbrFind
            // 
            // 
            // 
            // 
            this.txtAdjNbrFind.Border.Class = "TextBoxBorder";
            this.txtAdjNbrFind.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtAdjNbrFind.Location = new System.Drawing.Point(382, 23);
            this.txtAdjNbrFind.Name = "txtAdjNbrFind";
            this.txtAdjNbrFind.Size = new System.Drawing.Size(100, 20);
            this.txtAdjNbrFind.TabIndex = 37;
            // 
            // normalLabel1
            // 
            // 
            // 
            // 
            this.normalLabel1.BackgroundStyle.Class = "";
            this.normalLabel1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.normalLabel1.Location = new System.Drawing.Point(14, 4);
            this.normalLabel1.Name = "normalLabel1";
            this.normalLabel1.Size = new System.Drawing.Size(75, 20);
            this.normalLabel1.TabIndex = 38;
            this.normalLabel1.Text = "User";
            // 
            // normalLabel2
            // 
            // 
            // 
            // 
            this.normalLabel2.BackgroundStyle.Class = "";
            this.normalLabel2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.normalLabel2.Location = new System.Drawing.Point(136, 3);
            this.normalLabel2.Name = "normalLabel2";
            this.normalLabel2.Size = new System.Drawing.Size(75, 20);
            this.normalLabel2.TabIndex = 39;
            this.normalLabel2.Text = "FromDate";
            // 
            // dtmFromDate
            // 
            // 
            // 
            // 
            this.dtmFromDate.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtmFromDate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtmFromDate.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtmFromDate.ButtonDropDown.Visible = true;
            this.dtmFromDate.IsPopupCalendarOpen = false;
            this.dtmFromDate.Location = new System.Drawing.Point(135, 23);
            // 
            // 
            // 
            this.dtmFromDate.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtmFromDate.MonthCalendar.BackgroundStyle.Class = "";
            this.dtmFromDate.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtmFromDate.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtmFromDate.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtmFromDate.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtmFromDate.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtmFromDate.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtmFromDate.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtmFromDate.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtmFromDate.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.dtmFromDate.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtmFromDate.MonthCalendar.DisplayMonth = new System.DateTime(2012, 4, 1, 0, 0, 0, 0);
            this.dtmFromDate.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dtmFromDate.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtmFromDate.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtmFromDate.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtmFromDate.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtmFromDate.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.dtmFromDate.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtmFromDate.MonthCalendar.TodayButtonVisible = true;
            this.dtmFromDate.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dtmFromDate.Name = "dtmFromDate";
            this.dtmFromDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dtmFromDate.Size = new System.Drawing.Size(100, 20);
            this.dtmFromDate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtmFromDate.TabIndex = 40;
            // 
            // AP202
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.DoubleBuffered = true;
            this.Name = "AP202";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.AP202_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).EndInit();
            this.pnldgv.ResumeLayout(false);
            this.pnl.ResumeLayout(false);
            this.pnlhead.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barStatus)).EndInit();
            this.panelEx1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtmToDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtmAdjDate)).EndInit();
            this.panelEx2.ResumeLayout(false);
            this.panelEx3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtmToDateLoad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtmFromDateLoad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtmFromDate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PT.Component.MultiColumnComboBox cmbUser;
        private PT.Component.NormalLabel labelX14;
        private PT.Component.NormalDateTimeInput dtmToDate;
        private PT.Component.NormalLabel labelX17;
        private PT.Component.NormalLabel labelX1;
        private PT.Component.MultiColumnComboBox cmbAdjAcct;
        private PT.Component.NormalLabel labelX5;
        private PT.Component.MultiColumnComboBox cmbStatus;
        private PT.Component.MultiColumnComboBox cmbBranchID;
        private PT.Component.NormalDateTimeInput dtmAdjDate;
        private PT.Component.NormalLabel labelX8;
        private PT.Component.NormalLabel labelX4;
        private PT.Component.NormalLabel labelX9;
        private PT.Component.NormalLabel labelBranchID;
        private PT.Component.NormalLabel labelX2;
        private PT.Component.NumericTextBox txtAdjAmt;
        private DevComponents.DotNetBar.PanelEx panelEx2;
        private DevComponents.DotNetBar.PanelEx panelEx3;
        private PT.Component.DataGridView dgvDocList;
        private PT.Component.NormalTextBox txtAdjNbr;
        private PT.Component.NormalTextBox txtAdjDescr;
        private PT.Component.NormalTextBox txtAdjNbrFind;
        private PT.Component.NormalLabel normalLabel1;
        private PT.Component.NormalLabel normalLabel2;
        private PT.Component.NormalDateTimeInput dtmFromDate;
        private PT.Component.NormalDateTimeInput dtmToDateLoad;
        private DevComponents.DotNetBar.ButtonX btnLoad;
        private PT.Component.MultiDropDownTextBox txtVendIDLoad;
        private PT.Component.NormalDateTimeInput dtmFromDateLoad;
        private PT.Component.NormalLabel labelX6;
        private PT.Component.NormalLabel labelVendID;
        private PT.Component.NormalLabel labelX10;
        private PT.Component.NormalLabel PONbr;
        private PT.Component.NormalLabel labelX3;
        private DevComponents.DotNetBar.ButtonX btnCheck;
        private PT.Component.NormalTextBox txtInvcNbr;
        private PT.Component.NormalTextBox txtPoNbr;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
    }
}

