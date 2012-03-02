namespace IN201
{
    partial class IN201
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
            this.FromDate = new DevComponents.DotNetBar.LabelX();
            this.dtmToDate = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.labelX17 = new DevComponents.DotNetBar.LabelX();
            this.dtmFromDate = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.txtDocNbrFind = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.pnlHeader = new DevComponents.DotNetBar.PanelEx();
            this.cmbStatus = new PT.Component.MultiColumnComboBox();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.cmbType = new PT.Component.MultiColumnComboBox();
            this.cmbBranchID = new PT.Component.MultiColumnComboBox();
            this.cmbWhID = new PT.Component.MultiColumnComboBox();
            this.cmbReason = new PT.Component.MultiColumnComboBox();
            this.txtTotalAmt = new PT.Component.NumericTextBox();
            this.txtTotalQty = new PT.Component.NumericTextBox();
            this.labelX19 = new DevComponents.DotNetBar.LabelX();
            this.dtmDocDate = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.lblBranchID = new DevComponents.DotNetBar.LabelX();
            this.txtDocDescr = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtDocNbr = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.pnlInput = new DevComponents.DotNetBar.PanelEx();
            this.btnDelRow = new DevComponents.DotNetBar.ButtonX();
            this.btnUpdate = new DevComponents.DotNetBar.ButtonX();
            this.chk6 = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.cmbINUnit = new PT.Component.MultiColumnComboBox();
            this.chk5 = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.chk4 = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.chk3 = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.chk2 = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.txtProductID = new PT.Component.MultiDropDownTextBox(this.components);
            this.chk1 = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.txtTotalCost = new PT.Component.NumericTextBox();
            this.txtUnitCost = new PT.Component.NumericTextBox();
            this.txtQty = new PT.Component.NumericTextBox();
            this.btnAddRow = new DevComponents.DotNetBar.ButtonX();
            this.txtLotID = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.dgvDocDet = new PT.Component.DataGridView(this.components);
            this.labelX16 = new DevComponents.DotNetBar.LabelX();
            this.cmbUser = new PT.Component.MultiColumnComboBox();
            this.cmbDocType1 = new PT.Component.MultiColumnComboBox();
            this.DocType = new DevComponents.DotNetBar.LabelX();
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).BeginInit();
            this.pnldgv.SuspendLayout();
            this.pnl.SuspendLayout();
            this.pnlhead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barStatus)).BeginInit();
            this.panelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtmToDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtmFromDate)).BeginInit();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtmDocDate)).BeginInit();
            this.pnlInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocDet)).BeginInit();
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
            // pnldgv
            // 
            this.pnldgv.Size = new System.Drawing.Size(47, 33);
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
            this.pnl.Controls.Add(this.dgvDocDet);
            this.pnl.Controls.Add(this.pnlInput);
            this.pnl.Controls.Add(this.pnlHeader);
            this.pnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl.Location = new System.Drawing.Point(0, 0);
            this.pnl.Size = new System.Drawing.Size(784, 537);
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
            this.pnlhead.Controls.Add(this.DocType);
            this.pnlhead.Controls.Add(this.cmbDocType1);
            this.pnlhead.Controls.Add(this.cmbUser);
            this.pnlhead.Controls.Add(this.labelX16);
            this.pnlhead.Controls.Add(this.txtDocNbrFind);
            this.pnlhead.Controls.Add(this.labelX1);
            this.pnlhead.Controls.Add(this.FromDate);
            this.pnlhead.Controls.Add(this.dtmToDate);
            this.pnlhead.Controls.Add(this.dtmFromDate);
            this.pnlhead.Controls.Add(this.labelX17);
            this.pnlhead.Size = new System.Drawing.Size(47, 57);
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
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToOrderColumns = true;
            this.dgv.Location = new System.Drawing.Point(0, 57);
            this.dgv.Size = new System.Drawing.Size(47, 0);
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
            // FromDate
            // 
            // 
            // 
            // 
            this.FromDate.BackgroundStyle.Class = "";
            this.FromDate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.FromDate.Location = new System.Drawing.Point(140, 3);
            this.FromDate.Name = "FromDate";
            this.FromDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.FromDate.Size = new System.Drawing.Size(100, 20);
            this.FromDate.TabIndex = 13;
            this.FromDate.Text = "FromDate";
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
            this.dtmToDate.Location = new System.Drawing.Point(265, 22);
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
            this.dtmToDate.Size = new System.Drawing.Size(100, 20);
            this.dtmToDate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtmToDate.TabIndex = 3;
            // 
            // labelX17
            // 
            // 
            // 
            // 
            this.labelX17.BackgroundStyle.Class = "";
            this.labelX17.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX17.Location = new System.Drawing.Point(265, 3);
            this.labelX17.Name = "labelX17";
            this.labelX17.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelX17.Size = new System.Drawing.Size(100, 20);
            this.labelX17.TabIndex = 10;
            this.labelX17.Text = "ToDate";
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
            this.dtmFromDate.Location = new System.Drawing.Point(140, 22);
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
            this.dtmFromDate.MonthCalendar.DisplayMonth = new System.DateTime(2012, 2, 1, 0, 0, 0, 0);
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
            this.dtmFromDate.Size = new System.Drawing.Size(100, 20);
            this.dtmFromDate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtmFromDate.TabIndex = 2;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(512, 3);
            this.labelX1.Name = "labelX1";
            this.labelX1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelX1.Size = new System.Drawing.Size(100, 20);
            this.labelX1.TabIndex = 14;
            this.labelX1.Text = "DocNbr";
            // 
            // txtDocNbrFind
            // 
            // 
            // 
            // 
            this.txtDocNbrFind.Border.Class = "TextBoxBorder";
            this.txtDocNbrFind.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDocNbrFind.Location = new System.Drawing.Point(512, 22);
            this.txtDocNbrFind.Name = "txtDocNbrFind";
            this.txtDocNbrFind.Size = new System.Drawing.Size(100, 20);
            this.txtDocNbrFind.TabIndex = 4;
            // 
            // pnlHeader
            // 
            this.pnlHeader.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnlHeader.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.pnlHeader.Controls.Add(this.cmbStatus);
            this.pnlHeader.Controls.Add(this.labelX6);
            this.pnlHeader.Controls.Add(this.cmbType);
            this.pnlHeader.Controls.Add(this.cmbBranchID);
            this.pnlHeader.Controls.Add(this.cmbWhID);
            this.pnlHeader.Controls.Add(this.cmbReason);
            this.pnlHeader.Controls.Add(this.txtTotalAmt);
            this.pnlHeader.Controls.Add(this.txtTotalQty);
            this.pnlHeader.Controls.Add(this.labelX19);
            this.pnlHeader.Controls.Add(this.dtmDocDate);
            this.pnlHeader.Controls.Add(this.labelX7);
            this.pnlHeader.Controls.Add(this.labelX8);
            this.pnlHeader.Controls.Add(this.labelX5);
            this.pnlHeader.Controls.Add(this.labelX4);
            this.pnlHeader.Controls.Add(this.labelX3);
            this.pnlHeader.Controls.Add(this.labelX2);
            this.pnlHeader.Controls.Add(this.labelX9);
            this.pnlHeader.Controls.Add(this.lblBranchID);
            this.pnlHeader.Controls.Add(this.txtDocDescr);
            this.pnlHeader.Controls.Add(this.txtDocNbr);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(784, 101);
            this.pnlHeader.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.pnlHeader.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.pnlHeader.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.pnlHeader.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.pnlHeader.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnlHeader.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnlHeader.Style.GradientAngle = 90;
            this.pnlHeader.TabIndex = 1;
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
            this.cmbStatus.Location = new System.Drawing.Point(72, 37);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(100, 20);
            this.cmbStatus.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmbStatus.TabIndex = 31;
            this.cmbStatus.SelectedIndexChanged += new System.EventHandler(this.cmbStatus_SelectedIndexChanged);
            // 
            // labelX6
            // 
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.Class = "";
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Location = new System.Drawing.Point(408, 42);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(50, 15);
            this.labelX6.TabIndex = 30;
            this.labelX6.Text = "DocType";
            // 
            // cmbType
            // 
            this.cmbType.AutoComplete = false;
            this.cmbType.AutoDropdown = false;
            this.cmbType.BackColorEven = System.Drawing.Color.White;
            this.cmbType.BackColorOdd = System.Drawing.Color.White;
            this.cmbType.ColumnNames = "";
            this.cmbType.ColumnWidthDefault = 75;
            this.cmbType.ColumnWidths = "";
            this.cmbType.DisplayMember = "Text";
            this.cmbType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbType.FormattingEnabled = true;
            this.cmbType.ItemHeight = 14;
            this.cmbType.LinkedColumnIndex = 0;
            this.cmbType.LinkedTextBox = null;
            this.cmbType.Location = new System.Drawing.Point(464, 39);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(100, 20);
            this.cmbType.TabIndex = 29;
            this.cmbType.SelectedIndexChanged += new System.EventHandler(this.cmbType_SelectedIndexChanged);
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
            this.cmbBranchID.Location = new System.Drawing.Point(72, 10);
            this.cmbBranchID.Name = "cmbBranchID";
            this.cmbBranchID.Size = new System.Drawing.Size(100, 20);
            this.cmbBranchID.TabIndex = 5;
            // 
            // cmbWhID
            // 
            this.cmbWhID.AutoComplete = false;
            this.cmbWhID.AutoDropdown = false;
            this.cmbWhID.BackColorEven = System.Drawing.Color.White;
            this.cmbWhID.BackColorOdd = System.Drawing.Color.White;
            this.cmbWhID.ColumnNames = "";
            this.cmbWhID.ColumnWidthDefault = 75;
            this.cmbWhID.ColumnWidths = "";
            this.cmbWhID.DisplayMember = "Text";
            this.cmbWhID.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbWhID.FormattingEnabled = true;
            this.cmbWhID.ItemHeight = 14;
            this.cmbWhID.LinkedColumnIndex = 0;
            this.cmbWhID.LinkedTextBox = null;
            this.cmbWhID.Location = new System.Drawing.Point(464, 11);
            this.cmbWhID.Name = "cmbWhID";
            this.cmbWhID.Size = new System.Drawing.Size(100, 20);
            this.cmbWhID.TabIndex = 9;
            // 
            // cmbReason
            // 
            this.cmbReason.AutoComplete = false;
            this.cmbReason.AutoDropdown = false;
            this.cmbReason.BackColorEven = System.Drawing.Color.White;
            this.cmbReason.BackColorOdd = System.Drawing.Color.White;
            this.cmbReason.ColumnNames = "";
            this.cmbReason.ColumnWidthDefault = 75;
            this.cmbReason.ColumnWidths = "";
            this.cmbReason.DisplayMember = "Text";
            this.cmbReason.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbReason.FormattingEnabled = true;
            this.cmbReason.ItemHeight = 14;
            this.cmbReason.LinkedColumnIndex = 0;
            this.cmbReason.LinkedTextBox = null;
            this.cmbReason.Location = new System.Drawing.Point(660, 10);
            this.cmbReason.Name = "cmbReason";
            this.cmbReason.Size = new System.Drawing.Size(100, 20);
            this.cmbReason.TabIndex = 10;
            // 
            // txtTotalAmt
            // 
            this.txtTotalAmt.AllowSpace = false;
            // 
            // 
            // 
            this.txtTotalAmt.Border.Class = "TextBoxBorder";
            this.txtTotalAmt.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTotalAmt.Enabled = false;
            this.txtTotalAmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTotalAmt.Location = new System.Drawing.Point(660, 65);
            this.txtTotalAmt.Name = "txtTotalAmt";
            this.txtTotalAmt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTotalAmt.Size = new System.Drawing.Size(100, 20);
            this.txtTotalAmt.TabIndex = 20;
            this.txtTotalAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTotalQty
            // 
            this.txtTotalQty.AllowSpace = false;
            // 
            // 
            // 
            this.txtTotalQty.Border.Class = "TextBoxBorder";
            this.txtTotalQty.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTotalQty.Enabled = false;
            this.txtTotalQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTotalQty.Location = new System.Drawing.Point(660, 39);
            this.txtTotalQty.Name = "txtTotalQty";
            this.txtTotalQty.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTotalQty.Size = new System.Drawing.Size(100, 20);
            this.txtTotalQty.TabIndex = 19;
            this.txtTotalQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelX19
            // 
            // 
            // 
            // 
            this.labelX19.BackgroundStyle.Class = "";
            this.labelX19.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX19.Location = new System.Drawing.Point(604, 42);
            this.labelX19.Name = "labelX19";
            this.labelX19.Size = new System.Drawing.Size(50, 15);
            this.labelX19.TabIndex = 28;
            this.labelX19.Text = "TotalQty";
            // 
            // dtmDocDate
            // 
            // 
            // 
            // 
            this.dtmDocDate.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtmDocDate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtmDocDate.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtmDocDate.ButtonDropDown.Visible = true;
            this.dtmDocDate.IsPopupCalendarOpen = false;
            this.dtmDocDate.Location = new System.Drawing.Point(271, 39);
            // 
            // 
            // 
            this.dtmDocDate.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtmDocDate.MonthCalendar.BackgroundStyle.Class = "";
            this.dtmDocDate.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtmDocDate.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtmDocDate.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtmDocDate.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtmDocDate.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtmDocDate.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtmDocDate.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtmDocDate.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtmDocDate.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.dtmDocDate.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtmDocDate.MonthCalendar.DisplayMonth = new System.DateTime(2012, 2, 1, 0, 0, 0, 0);
            this.dtmDocDate.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dtmDocDate.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtmDocDate.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtmDocDate.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtmDocDate.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtmDocDate.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.dtmDocDate.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtmDocDate.MonthCalendar.TodayButtonVisible = true;
            this.dtmDocDate.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dtmDocDate.Name = "dtmDocDate";
            this.dtmDocDate.Size = new System.Drawing.Size(100, 20);
            this.dtmDocDate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtmDocDate.TabIndex = 8;
            // 
            // labelX7
            // 
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.Class = "";
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Location = new System.Drawing.Point(408, 14);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(50, 15);
            this.labelX7.TabIndex = 15;
            this.labelX7.Text = "WhID";
            // 
            // labelX8
            // 
            // 
            // 
            // 
            this.labelX8.BackgroundStyle.Class = "";
            this.labelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX8.Location = new System.Drawing.Point(17, 39);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(50, 15);
            this.labelX8.TabIndex = 17;
            this.labelX8.Text = "Status";
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.Class = "";
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(212, 68);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(50, 15);
            this.labelX5.TabIndex = 11;
            this.labelX5.Text = "DocDescr";
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.Class = "";
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(212, 16);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(50, 15);
            this.labelX4.TabIndex = 10;
            this.labelX4.Text = "DocNbr";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.Class = "";
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(604, 13);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(50, 15);
            this.labelX3.TabIndex = 9;
            this.labelX3.Text = "Reason";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.Class = "";
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(604, 70);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(50, 15);
            this.labelX2.TabIndex = 8;
            this.labelX2.Text = "TotalAmt";
            // 
            // labelX9
            // 
            // 
            // 
            // 
            this.labelX9.BackgroundStyle.Class = "";
            this.labelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX9.Location = new System.Drawing.Point(212, 42);
            this.labelX9.Name = "labelX9";
            this.labelX9.Size = new System.Drawing.Size(50, 15);
            this.labelX9.TabIndex = 7;
            this.labelX9.Text = "DocDate";
            // 
            // lblBranchID
            // 
            // 
            // 
            // 
            this.lblBranchID.BackgroundStyle.Class = "";
            this.lblBranchID.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblBranchID.Location = new System.Drawing.Point(16, 14);
            this.lblBranchID.Name = "lblBranchID";
            this.lblBranchID.Size = new System.Drawing.Size(50, 15);
            this.lblBranchID.TabIndex = 6;
            this.lblBranchID.Text = "BranchID";
            // 
            // txtDocDescr
            // 
            // 
            // 
            // 
            this.txtDocDescr.Border.Class = "TextBoxBorder";
            this.txtDocDescr.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDocDescr.Location = new System.Drawing.Point(271, 64);
            this.txtDocDescr.Name = "txtDocDescr";
            this.txtDocDescr.Size = new System.Drawing.Size(293, 20);
            this.txtDocDescr.TabIndex = 30;
            // 
            // txtDocNbr
            // 
            // 
            // 
            // 
            this.txtDocNbr.Border.Class = "TextBoxBorder";
            this.txtDocNbr.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDocNbr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtDocNbr.Location = new System.Drawing.Point(271, 12);
            this.txtDocNbr.Name = "txtDocNbr";
            this.txtDocNbr.Size = new System.Drawing.Size(100, 20);
            this.txtDocNbr.TabIndex = 7;
            this.txtDocNbr.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDocNbr_KeyDown);
            // 
            // pnlInput
            // 
            this.pnlInput.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnlInput.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.pnlInput.Controls.Add(this.btnDelRow);
            this.pnlInput.Controls.Add(this.btnUpdate);
            this.pnlInput.Controls.Add(this.chk6);
            this.pnlInput.Controls.Add(this.cmbINUnit);
            this.pnlInput.Controls.Add(this.chk5);
            this.pnlInput.Controls.Add(this.chk4);
            this.pnlInput.Controls.Add(this.chk3);
            this.pnlInput.Controls.Add(this.chk2);
            this.pnlInput.Controls.Add(this.txtProductID);
            this.pnlInput.Controls.Add(this.chk1);
            this.pnlInput.Controls.Add(this.txtTotalCost);
            this.pnlInput.Controls.Add(this.txtUnitCost);
            this.pnlInput.Controls.Add(this.txtQty);
            this.pnlInput.Controls.Add(this.btnAddRow);
            this.pnlInput.Controls.Add(this.txtLotID);
            this.pnlInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlInput.Location = new System.Drawing.Point(0, 101);
            this.pnlInput.Name = "pnlInput";
            this.pnlInput.Size = new System.Drawing.Size(784, 53);
            this.pnlInput.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.pnlInput.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.pnlInput.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.pnlInput.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.pnlInput.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnlInput.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnlInput.Style.GradientAngle = 90;
            this.pnlInput.TabIndex = 2;
            // 
            // btnDelRow
            // 
            this.btnDelRow.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDelRow.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDelRow.Location = new System.Drawing.Point(728, 27);
            this.btnDelRow.Name = "btnDelRow";
            this.btnDelRow.Size = new System.Drawing.Size(40, 20);
            this.btnDelRow.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnDelRow.TabIndex = 45;
            this.btnDelRow.Text = "Del";
            this.btnDelRow.Click += new System.EventHandler(this.btnDelRow_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnUpdate.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnUpdate.Location = new System.Drawing.Point(681, 27);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(40, 20);
            this.btnUpdate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnUpdate.TabIndex = 44;
            this.btnUpdate.Text = "Upd";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // chk6
            // 
            // 
            // 
            // 
            this.chk6.BackgroundStyle.Class = "";
            this.chk6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chk6.Location = new System.Drawing.Point(527, 9);
            this.chk6.Name = "chk6";
            this.chk6.Size = new System.Drawing.Size(100, 15);
            this.chk6.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.chk6.TabIndex = 43;
            this.chk6.Text = "TotalCost";
            this.chk6.CheckedChanged += new System.EventHandler(this.chk6_CheckedChanged);
            // 
            // cmbINUnit
            // 
            this.cmbINUnit.AutoComplete = true;
            this.cmbINUnit.AutoDropdown = false;
            this.cmbINUnit.BackColorEven = System.Drawing.Color.White;
            this.cmbINUnit.BackColorOdd = System.Drawing.Color.White;
            this.cmbINUnit.ColumnNames = "";
            this.cmbINUnit.ColumnWidthDefault = 75;
            this.cmbINUnit.ColumnWidths = "";
            this.cmbINUnit.DisplayMember = "Text";
            this.cmbINUnit.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbINUnit.FormattingEnabled = true;
            this.cmbINUnit.ItemHeight = 14;
            this.cmbINUnit.LinkedColumnIndex = 0;
            this.cmbINUnit.LinkedTextBox = null;
            this.cmbINUnit.Location = new System.Drawing.Point(221, 27);
            this.cmbINUnit.Name = "cmbINUnit";
            this.cmbINUnit.Size = new System.Drawing.Size(100, 20);
            this.cmbINUnit.TabIndex = 14;
            this.cmbINUnit.SelectedIndexChanged += new System.EventHandler(this.cmbINUnit_SelectedIndexChanged);
            // 
            // chk5
            // 
            // 
            // 
            // 
            this.chk5.BackgroundStyle.Class = "";
            this.chk5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chk5.Location = new System.Drawing.Point(425, 9);
            this.chk5.Name = "chk5";
            this.chk5.Size = new System.Drawing.Size(100, 15);
            this.chk5.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.chk5.TabIndex = 42;
            this.chk5.Text = "UnitCost";
            this.chk5.CheckedChanged += new System.EventHandler(this.chk5_CheckedChanged);
            // 
            // chk4
            // 
            // 
            // 
            // 
            this.chk4.BackgroundStyle.Class = "";
            this.chk4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chk4.Location = new System.Drawing.Point(323, 9);
            this.chk4.Name = "chk4";
            this.chk4.Size = new System.Drawing.Size(100, 15);
            this.chk4.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.chk4.TabIndex = 41;
            this.chk4.Text = "LineQty";
            this.chk4.CheckedChanged += new System.EventHandler(this.chk4_CheckedChanged);
            // 
            // chk3
            // 
            // 
            // 
            // 
            this.chk3.BackgroundStyle.Class = "";
            this.chk3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chk3.Location = new System.Drawing.Point(220, 9);
            this.chk3.Name = "chk3";
            this.chk3.Size = new System.Drawing.Size(100, 15);
            this.chk3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.chk3.TabIndex = 40;
            this.chk3.Text = "INUnit";
            this.chk3.CheckedChanged += new System.EventHandler(this.chk3_CheckedChanged);
            // 
            // chk2
            // 
            // 
            // 
            // 
            this.chk2.BackgroundStyle.Class = "";
            this.chk2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chk2.Location = new System.Drawing.Point(119, 9);
            this.chk2.Name = "chk2";
            this.chk2.Size = new System.Drawing.Size(100, 15);
            this.chk2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.chk2.TabIndex = 39;
            this.chk2.Text = "LotID";
            this.chk2.CheckedChanged += new System.EventHandler(this.chk2_CheckedChanged);
            // 
            // txtProductID
            // 
            this.txtProductID.AutoComplete = false;
            this.txtProductID.AutoReSizeColumn = true;
            // 
            // 
            // 
            this.txtProductID.Border.Class = "TextBoxBorder";
            this.txtProductID.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtProductID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtProductID.ColumnHeaders = "";
            this.txtProductID.ColumnNames = "";
            this.txtProductID.ColumnWidthDefault = 75;
            this.txtProductID.ColumnWidths = "";
            this.txtProductID.DataSource = null;
            this.txtProductID.Language = "Language1";
            this.txtProductID.Location = new System.Drawing.Point(17, 27);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.RowsDisplay = 10;
            this.txtProductID.Size = new System.Drawing.Size(100, 20);
            this.txtProductID.TabIndex = 12;
            this.txtProductID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProductID_KeyDown);
            this.txtProductID.Enter += new System.EventHandler(this.txtProductID_Enter);
            this.txtProductID.TextChanged += new System.EventHandler(this.txtProductID_TextChanged);
            // 
            // chk1
            // 
            // 
            // 
            // 
            this.chk1.BackgroundStyle.Class = "";
            this.chk1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chk1.Location = new System.Drawing.Point(17, 9);
            this.chk1.Name = "chk1";
            this.chk1.Size = new System.Drawing.Size(100, 15);
            this.chk1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.chk1.TabIndex = 37;
            this.chk1.Text = "ProductID";
            this.chk1.CheckedChanged += new System.EventHandler(this.chk1_CheckedChanged);
            // 
            // txtTotalCost
            // 
            this.txtTotalCost.AllowSpace = false;
            // 
            // 
            // 
            this.txtTotalCost.Border.Class = "TextBoxBorder";
            this.txtTotalCost.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTotalCost.Location = new System.Drawing.Point(527, 27);
            this.txtTotalCost.Name = "txtTotalCost";
            this.txtTotalCost.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTotalCost.Size = new System.Drawing.Size(100, 20);
            this.txtTotalCost.TabIndex = 17;
            this.txtTotalCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTotalCost.Leave += new System.EventHandler(this.txtTotalCost_Leave);
            // 
            // txtUnitCost
            // 
            this.txtUnitCost.AllowSpace = false;
            // 
            // 
            // 
            this.txtUnitCost.Border.Class = "TextBoxBorder";
            this.txtUnitCost.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtUnitCost.Location = new System.Drawing.Point(425, 27);
            this.txtUnitCost.Name = "txtUnitCost";
            this.txtUnitCost.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtUnitCost.Size = new System.Drawing.Size(100, 20);
            this.txtUnitCost.TabIndex = 16;
            this.txtUnitCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtUnitCost.Leave += new System.EventHandler(this.txtUnitCost_Leave);
            // 
            // txtQty
            // 
            this.txtQty.AllowSpace = false;
            // 
            // 
            // 
            this.txtQty.Border.Class = "TextBoxBorder";
            this.txtQty.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtQty.Location = new System.Drawing.Point(323, 27);
            this.txtQty.Name = "txtQty";
            this.txtQty.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtQty.Size = new System.Drawing.Size(100, 20);
            this.txtQty.TabIndex = 15;
            this.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtQty.Leave += new System.EventHandler(this.txtQty_Leave);
            // 
            // btnAddRow
            // 
            this.btnAddRow.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAddRow.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAddRow.Location = new System.Drawing.Point(634, 27);
            this.btnAddRow.Name = "btnAddRow";
            this.btnAddRow.Size = new System.Drawing.Size(40, 20);
            this.btnAddRow.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAddRow.TabIndex = 18;
            this.btnAddRow.Text = "Add";
            this.btnAddRow.Click += new System.EventHandler(this.btnAddRow_Click);
            this.btnAddRow.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnAddRow_KeyDown);
            // 
            // txtLotID
            // 
            this.txtLotID.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.txtLotID.Border.Class = "TextBoxBorder";
            this.txtLotID.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtLotID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtLotID.Enabled = false;
            this.txtLotID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtLotID.Location = new System.Drawing.Point(120, 27);
            this.txtLotID.Name = "txtLotID";
            this.txtLotID.Size = new System.Drawing.Size(100, 20);
            this.txtLotID.TabIndex = 13;
            this.txtLotID.Text = "MD";
            // 
            // dgvDocDet
            // 
            this.dgvDocDet.AllowUserToAddRows = false;
            this.dgvDocDet.AutoColumnHeadder = true;
            this.dgvDocDet.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDocDet.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDocDet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDocDet.EndCell = 0;
            this.dgvDocDet.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvDocDet.Language = "Language1";
            this.dgvDocDet.Location = new System.Drawing.Point(0, 154);
            this.dgvDocDet.Name = "dgvDocDet";
            this.dgvDocDet.Size = new System.Drawing.Size(784, 383);
            this.dgvDocDet.TabIndex = 3;
            this.dgvDocDet.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDocDet_CellValueChanged);
            this.dgvDocDet.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDocDet_CellClick);
            this.dgvDocDet.SelectionChanged += new System.EventHandler(this.dgvDocDet_SelectionChanged);
            // 
            // labelX16
            // 
            // 
            // 
            // 
            this.labelX16.BackgroundStyle.Class = "";
            this.labelX16.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX16.Location = new System.Drawing.Point(17, 3);
            this.labelX16.Name = "labelX16";
            this.labelX16.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelX16.Size = new System.Drawing.Size(100, 20);
            this.labelX16.TabIndex = 15;
            this.labelX16.Text = "User";
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
            this.cmbUser.Location = new System.Drawing.Point(17, 22);
            this.cmbUser.Name = "cmbUser";
            this.cmbUser.Size = new System.Drawing.Size(100, 20);
            this.cmbUser.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmbUser.TabIndex = 16;
            // 
            // cmbDocType1
            // 
            this.cmbDocType1.AutoComplete = false;
            this.cmbDocType1.AutoDropdown = false;
            this.cmbDocType1.BackColorEven = System.Drawing.Color.White;
            this.cmbDocType1.BackColorOdd = System.Drawing.Color.White;
            this.cmbDocType1.ColumnNames = "";
            this.cmbDocType1.ColumnWidthDefault = 75;
            this.cmbDocType1.ColumnWidths = "";
            this.cmbDocType1.DisplayMember = "Text";
            this.cmbDocType1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbDocType1.FormattingEnabled = true;
            this.cmbDocType1.ItemHeight = 14;
            this.cmbDocType1.LinkedColumnIndex = 0;
            this.cmbDocType1.LinkedTextBox = null;
            this.cmbDocType1.Location = new System.Drawing.Point(387, 22);
            this.cmbDocType1.Name = "cmbDocType1";
            this.cmbDocType1.Size = new System.Drawing.Size(100, 20);
            this.cmbDocType1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmbDocType1.TabIndex = 17;
            // 
            // DocType
            // 
            // 
            // 
            // 
            this.DocType.BackgroundStyle.Class = "";
            this.DocType.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.DocType.Location = new System.Drawing.Point(387, 3);
            this.DocType.Name = "DocType";
            this.DocType.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DocType.Size = new System.Drawing.Size(100, 20);
            this.DocType.TabIndex = 18;
            this.DocType.Text = "DocType";
            // 
            // IN201
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Name = "IN201";
            this.Text = "Điều Chỉnh Kho";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).EndInit();
            this.pnldgv.ResumeLayout(false);
            this.pnl.ResumeLayout(false);
            this.pnlhead.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barStatus)).EndInit();
            this.panelEx1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtmToDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtmFromDate)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtmDocDate)).EndInit();
            this.pnlInput.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocDet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX FromDate;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtmToDate;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtmFromDate;
        private DevComponents.DotNetBar.LabelX labelX17;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDocNbrFind;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.PanelEx pnlHeader;
        private PT.Component.MultiColumnComboBox cmbBranchID;
        private PT.Component.MultiColumnComboBox cmbWhID;
        private PT.Component.MultiColumnComboBox cmbReason;
        private PT.Component.NumericTextBox txtTotalAmt;
        private PT.Component.NumericTextBox txtTotalQty;
        private DevComponents.DotNetBar.LabelX labelX19;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtmDocDate;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.LabelX labelX8;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX9;
        private DevComponents.DotNetBar.LabelX lblBranchID;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDocDescr;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDocNbr;
        private DevComponents.DotNetBar.PanelEx pnlInput;
        private DevComponents.DotNetBar.Controls.CheckBoxX chk1;
        private PT.Component.NumericTextBox txtTotalCost;
        private PT.Component.NumericTextBox txtUnitCost;
        private PT.Component.NumericTextBox txtQty;
        private DevComponents.DotNetBar.ButtonX btnAddRow;
        private DevComponents.DotNetBar.Controls.TextBoxX txtLotID;
        private PT.Component.DataGridView dgvDocDet;
        private PT.Component.MultiDropDownTextBox txtProductID;
        private DevComponents.DotNetBar.Controls.CheckBoxX chk6;
        private DevComponents.DotNetBar.Controls.CheckBoxX chk5;
        private DevComponents.DotNetBar.Controls.CheckBoxX chk4;
        private DevComponents.DotNetBar.Controls.CheckBoxX chk3;
        private DevComponents.DotNetBar.Controls.CheckBoxX chk2;
        private DevComponents.DotNetBar.LabelX labelX16;
        private PT.Component.MultiColumnComboBox cmbINUnit;
        private DevComponents.DotNetBar.ButtonX btnUpdate;
        private DevComponents.DotNetBar.ButtonX btnDelRow;
        private PT.Component.MultiColumnComboBox cmbType;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.LabelX DocType;
        private PT.Component.MultiColumnComboBox cmbDocType1;
        private PT.Component.MultiColumnComboBox cmbUser;
        private PT.Component.MultiColumnComboBox cmbStatus;
    }
}

