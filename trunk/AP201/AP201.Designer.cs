namespace AP201
{
    partial class AP201
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
            this.labelX6 = new PT.Component.NormalLabel();
            this.cmbBranchID = new PT.Component.MultiColumnComboBox();
            this.dtmDocDate = new PT.Component.NormalDateTimeInput();
            this.labelX8 = new PT.Component.NormalLabel();
            this.labelX4 = new PT.Component.NormalLabel();
            this.labelX9 = new PT.Component.NormalLabel();
            this.lblBranchID = new PT.Component.NormalLabel();
            this.labelX5 = new PT.Component.NormalLabel();
            this.txtVendID = new PT.Component.MultiDropDownTextBox(this.components);
            this.VendID = new PT.Component.NormalLabel();
            this.labelX2 = new PT.Component.NormalLabel();
            this.labelX7 = new PT.Component.NormalLabel();
            this.cmbTaxID = new PT.Component.MultiColumnComboBox();
            this.dtmDueDate = new PT.Component.NormalDateTimeInput();
            this.labelX10 = new PT.Component.NormalLabel();
            this.txtPreTaxAmt = new PT.Component.NumericTextBox();
            this.txtTaxAmt = new PT.Component.NumericTextBox();
            this.txtOrigDocAmt = new PT.Component.NumericTextBox();
            this.labelX11 = new PT.Component.NormalLabel();
            this.labelX12 = new PT.Component.NormalLabel();
            this.labelX13 = new PT.Component.NormalLabel();
            this.labelX1 = new PT.Component.NormalLabel();
            this.cmbDocAcct = new PT.Component.MultiColumnComboBox();
            this.cmbUser = new PT.Component.MultiColumnComboBox();
            this.labelX16 = new PT.Component.NormalLabel();
            this.labelX14 = new PT.Component.NormalLabel();
            this.FromDate = new PT.Component.NormalLabel();
            this.labelX17 = new PT.Component.NormalLabel();
            this.labelX15 = new PT.Component.NormalLabel();
            this.dtmFromDate = new PT.Component.NormalDateTimeInput();
            this.dtmToDate = new PT.Component.NormalDateTimeInput();
            this.txtDocNbrFind = new PT.Component.NormalTextBox();
            this.txtInvcNbrFind = new PT.Component.NormalTextBox();
            this.btnSearch = new DevComponents.DotNetBar.ButtonX();
            this.txtDocNbr = new PT.Component.NormalTextBox();
            this.txtInvcNbr = new PT.Component.NormalTextBox();
            this.txtInvcNote = new PT.Component.NormalTextBox();
            this.txtDocDescr = new PT.Component.NormalTextBox();
            this.cmbType = new PT.Component.NormalComboBox();
            this.cmbStatus = new PT.Component.NormalComboBox();
            this.normalLabel1 = new PT.Component.NormalLabel();
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).BeginInit();
            this.pnldgv.SuspendLayout();
            this.pnl.SuspendLayout();
            this.pnlhead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barStatus)).BeginInit();
            this.panelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtmDocDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtmDueDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtmFromDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtmToDate)).BeginInit();
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
            // pnldgv
            // 
            this.pnldgv.Size = new System.Drawing.Size(725, 62);
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
            this.pnl.Controls.Add(this.normalLabel1);
            this.pnl.Controls.Add(this.cmbStatus);
            this.pnl.Controls.Add(this.cmbType);
            this.pnl.Controls.Add(this.txtDocDescr);
            this.pnl.Controls.Add(this.txtInvcNote);
            this.pnl.Controls.Add(this.txtInvcNbr);
            this.pnl.Controls.Add(this.txtDocNbr);
            this.pnl.Controls.Add(this.labelX13);
            this.pnl.Controls.Add(this.labelX12);
            this.pnl.Controls.Add(this.labelX11);
            this.pnl.Controls.Add(this.txtOrigDocAmt);
            this.pnl.Controls.Add(this.txtTaxAmt);
            this.pnl.Controls.Add(this.txtPreTaxAmt);
            this.pnl.Controls.Add(this.dtmDueDate);
            this.pnl.Controls.Add(this.labelX10);
            this.pnl.Controls.Add(this.labelX7);
            this.pnl.Controls.Add(this.cmbTaxID);
            this.pnl.Controls.Add(this.labelX2);
            this.pnl.Controls.Add(this.VendID);
            this.pnl.Controls.Add(this.txtVendID);
            this.pnl.Controls.Add(this.labelX1);
            this.pnl.Controls.Add(this.cmbDocAcct);
            this.pnl.Controls.Add(this.labelX5);
            this.pnl.Controls.Add(this.labelX6);
            this.pnl.Controls.Add(this.cmbBranchID);
            this.pnl.Controls.Add(this.dtmDocDate);
            this.pnl.Controls.Add(this.labelX8);
            this.pnl.Controls.Add(this.labelX4);
            this.pnl.Controls.Add(this.labelX9);
            this.pnl.Controls.Add(this.lblBranchID);
            this.pnl.Location = new System.Drawing.Point(12, 74);
            this.pnl.Size = new System.Drawing.Size(769, 422);
            this.pnl.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.pnl.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.pnl.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.pnl.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.pnl.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnl.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnl.Style.GradientAngle = 90;
            this.pnl.Text = "";
            // 
            // pnlhead
            // 
            this.pnlhead.Controls.Add(this.btnSearch);
            this.pnlhead.Controls.Add(this.txtInvcNbrFind);
            this.pnlhead.Controls.Add(this.txtDocNbrFind);
            this.pnlhead.Controls.Add(this.dtmToDate);
            this.pnlhead.Controls.Add(this.dtmFromDate);
            this.pnlhead.Controls.Add(this.labelX15);
            this.pnlhead.Controls.Add(this.cmbUser);
            this.pnlhead.Controls.Add(this.labelX16);
            this.pnlhead.Controls.Add(this.labelX14);
            this.pnlhead.Controls.Add(this.FromDate);
            this.pnlhead.Controls.Add(this.labelX17);
            this.pnlhead.Size = new System.Drawing.Size(725, 57);
            this.pnlhead.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.pnlhead.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.pnlhead.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.pnlhead.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.pnlhead.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnlhead.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnlhead.Style.GradientAngle = 90;
            this.pnlhead.Click += new System.EventHandler(this.pnlhead_Click);
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.Location = new System.Drawing.Point(0, 57);
            this.dgv.Size = new System.Drawing.Size(725, 5);
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
            // labelX6
            // 
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.Class = "";
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Location = new System.Drawing.Point(29, 66);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(50, 15);
            this.labelX6.TabIndex = 42;
            this.labelX6.Text = "DocType";
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
            this.cmbBranchID.Location = new System.Drawing.Point(88, 9);
            this.cmbBranchID.Name = "cmbBranchID";
            this.cmbBranchID.Size = new System.Drawing.Size(100, 20);
            this.cmbBranchID.TabIndex = 1;
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
            this.dtmDocDate.Location = new System.Drawing.Point(287, 38);
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
            this.dtmDocDate.TabIndex = 3;
            // 
            // labelX8
            // 
            // 
            // 
            // 
            this.labelX8.BackgroundStyle.Class = "";
            this.labelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX8.Location = new System.Drawing.Point(29, 38);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(50, 15);
            this.labelX8.TabIndex = 40;
            this.labelX8.Text = "Status";
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.Class = "";
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(228, 14);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(50, 15);
            this.labelX4.TabIndex = 38;
            this.labelX4.Text = "DocNbr";
            // 
            // labelX9
            // 
            // 
            // 
            // 
            this.labelX9.BackgroundStyle.Class = "";
            this.labelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX9.Location = new System.Drawing.Point(228, 41);
            this.labelX9.Name = "labelX9";
            this.labelX9.Size = new System.Drawing.Size(50, 15);
            this.labelX9.TabIndex = 34;
            this.labelX9.Text = "DocDate";
            // 
            // lblBranchID
            // 
            // 
            // 
            // 
            this.lblBranchID.BackgroundStyle.Class = "";
            this.lblBranchID.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblBranchID.Location = new System.Drawing.Point(29, 11);
            this.lblBranchID.Name = "lblBranchID";
            this.lblBranchID.Size = new System.Drawing.Size(50, 15);
            this.lblBranchID.TabIndex = 33;
            this.lblBranchID.Text = "BranchID";
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.Class = "";
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(29, 97);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(50, 15);
            this.labelX5.TabIndex = 44;
            this.labelX5.Text = "DocDescr";
            // 
            // txtVendID
            // 
            this.txtVendID.AutoComplete = false;
            this.txtVendID.AutoReSizeColumn = true;
            // 
            // 
            // 
            this.txtVendID.Border.Class = "TextBoxBorder";
            this.txtVendID.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtVendID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtVendID.ColumnHeaders = "";
            this.txtVendID.ColumnNames = "";
            this.txtVendID.ColumnWidthDefault = 75;
            this.txtVendID.ColumnWidths = "";
            this.txtVendID.DataSource = null;
            this.txtVendID.Language = "Language1";
            this.txtVendID.Location = new System.Drawing.Point(287, 66);
            this.txtVendID.Name = "txtVendID";
            this.txtVendID.RowsDisplay = 10;
            this.txtVendID.Size = new System.Drawing.Size(100, 20);
            this.txtVendID.TabIndex = 4;
            // 
            // VendID
            // 
            // 
            // 
            // 
            this.VendID.BackgroundStyle.Class = "";
            this.VendID.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.VendID.Location = new System.Drawing.Point(228, 71);
            this.VendID.Name = "VendID";
            this.VendID.Size = new System.Drawing.Size(50, 15);
            this.VendID.TabIndex = 49;
            this.VendID.Text = "VendID";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.Class = "";
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(427, 69);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(50, 15);
            this.labelX2.TabIndex = 51;
            this.labelX2.Text = "InvcNbr";
            // 
            // labelX7
            // 
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.Class = "";
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Location = new System.Drawing.Point(204, 156);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(50, 15);
            this.labelX7.TabIndex = 55;
            this.labelX7.Text = "TaxID";
            // 
            // cmbTaxID
            // 
            this.cmbTaxID.AutoComplete = false;
            this.cmbTaxID.AutoDropdown = false;
            this.cmbTaxID.BackColorEven = System.Drawing.Color.White;
            this.cmbTaxID.BackColorOdd = System.Drawing.Color.White;
            this.cmbTaxID.ColumnNames = "";
            this.cmbTaxID.ColumnWidthDefault = 75;
            this.cmbTaxID.ColumnWidths = "";
            this.cmbTaxID.DisplayMember = "Text";
            this.cmbTaxID.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbTaxID.FormattingEnabled = true;
            this.cmbTaxID.ItemHeight = 14;
            this.cmbTaxID.LinkedColumnIndex = 0;
            this.cmbTaxID.LinkedTextBox = null;
            this.cmbTaxID.Location = new System.Drawing.Point(204, 177);
            this.cmbTaxID.Name = "cmbTaxID";
            this.cmbTaxID.Size = new System.Drawing.Size(100, 20);
            this.cmbTaxID.TabIndex = 10;
            this.cmbTaxID.SelectedIndexChanged += new System.EventHandler(this.cmbTaxID_SelectedIndexChanged);
            // 
            // dtmDueDate
            // 
            // 
            // 
            // 
            this.dtmDueDate.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtmDueDate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtmDueDate.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtmDueDate.ButtonDropDown.Visible = true;
            this.dtmDueDate.IsPopupCalendarOpen = false;
            this.dtmDueDate.Location = new System.Drawing.Point(486, 37);
            // 
            // 
            // 
            this.dtmDueDate.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtmDueDate.MonthCalendar.BackgroundStyle.Class = "";
            this.dtmDueDate.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtmDueDate.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtmDueDate.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtmDueDate.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtmDueDate.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtmDueDate.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtmDueDate.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtmDueDate.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtmDueDate.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.dtmDueDate.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtmDueDate.MonthCalendar.DisplayMonth = new System.DateTime(2012, 2, 1, 0, 0, 0, 0);
            this.dtmDueDate.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dtmDueDate.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtmDueDate.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtmDueDate.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtmDueDate.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtmDueDate.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.dtmDueDate.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtmDueDate.MonthCalendar.TodayButtonVisible = true;
            this.dtmDueDate.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dtmDueDate.Name = "dtmDueDate";
            this.dtmDueDate.Size = new System.Drawing.Size(100, 20);
            this.dtmDueDate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtmDueDate.TabIndex = 6;
            // 
            // labelX10
            // 
            // 
            // 
            // 
            this.labelX10.BackgroundStyle.Class = "";
            this.labelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX10.Location = new System.Drawing.Point(427, 40);
            this.labelX10.Name = "labelX10";
            this.labelX10.Size = new System.Drawing.Size(50, 15);
            this.labelX10.TabIndex = 56;
            this.labelX10.Text = "DueDate";
            // 
            // txtPreTaxAmt
            // 
            this.txtPreTaxAmt.AllowSpace = false;
            // 
            // 
            // 
            this.txtPreTaxAmt.Border.Class = "TextBoxBorder";
            this.txtPreTaxAmt.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtPreTaxAmt.Location = new System.Drawing.Point(88, 177);
            this.txtPreTaxAmt.Name = "txtPreTaxAmt";
            this.txtPreTaxAmt.Size = new System.Drawing.Size(100, 20);
            this.txtPreTaxAmt.TabIndex = 9;
            this.txtPreTaxAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPreTaxAmt.Leave += new System.EventHandler(this.txtPreTaxAmt_Leave);
            // 
            // txtTaxAmt
            // 
            this.txtTaxAmt.AllowSpace = false;
            // 
            // 
            // 
            this.txtTaxAmt.Border.Class = "TextBoxBorder";
            this.txtTaxAmt.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTaxAmt.Location = new System.Drawing.Point(322, 177);
            this.txtTaxAmt.Name = "txtTaxAmt";
            this.txtTaxAmt.ReadOnly = true;
            this.txtTaxAmt.Size = new System.Drawing.Size(100, 20);
            this.txtTaxAmt.TabIndex = 11;
            this.txtTaxAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtOrigDocAmt
            // 
            this.txtOrigDocAmt.AllowSpace = false;
            // 
            // 
            // 
            this.txtOrigDocAmt.Border.Class = "TextBoxBorder";
            this.txtOrigDocAmt.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtOrigDocAmt.Location = new System.Drawing.Point(438, 177);
            this.txtOrigDocAmt.Name = "txtOrigDocAmt";
            this.txtOrigDocAmt.ReadOnly = true;
            this.txtOrigDocAmt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtOrigDocAmt.Size = new System.Drawing.Size(100, 20);
            this.txtOrigDocAmt.TabIndex = 12;
            this.txtOrigDocAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelX11
            // 
            // 
            // 
            // 
            this.labelX11.BackgroundStyle.Class = "";
            this.labelX11.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX11.Location = new System.Drawing.Point(88, 156);
            this.labelX11.Name = "labelX11";
            this.labelX11.Size = new System.Drawing.Size(100, 15);
            this.labelX11.TabIndex = 61;
            this.labelX11.Text = "PreTaxAmt";
            // 
            // labelX12
            // 
            // 
            // 
            // 
            this.labelX12.BackgroundStyle.Class = "";
            this.labelX12.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX12.Location = new System.Drawing.Point(322, 156);
            this.labelX12.Name = "labelX12";
            this.labelX12.Size = new System.Drawing.Size(50, 15);
            this.labelX12.TabIndex = 62;
            this.labelX12.Text = "TaxAmt";
            // 
            // labelX13
            // 
            // 
            // 
            // 
            this.labelX13.BackgroundStyle.Class = "";
            this.labelX13.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX13.Location = new System.Drawing.Point(438, 156);
            this.labelX13.Name = "labelX13";
            this.labelX13.Size = new System.Drawing.Size(100, 15);
            this.labelX13.TabIndex = 63;
            this.labelX13.Text = "OrigDocAmt";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(427, 12);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(50, 15);
            this.labelX1.TabIndex = 47;
            this.labelX1.Text = "DocAcct";
            // 
            // cmbDocAcct
            // 
            this.cmbDocAcct.AutoComplete = false;
            this.cmbDocAcct.AutoDropdown = false;
            this.cmbDocAcct.BackColorEven = System.Drawing.Color.White;
            this.cmbDocAcct.BackColorOdd = System.Drawing.Color.White;
            this.cmbDocAcct.ColumnNames = "";
            this.cmbDocAcct.ColumnWidthDefault = 75;
            this.cmbDocAcct.ColumnWidths = "";
            this.cmbDocAcct.DisplayMember = "Text";
            this.cmbDocAcct.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbDocAcct.FormattingEnabled = true;
            this.cmbDocAcct.ItemHeight = 14;
            this.cmbDocAcct.LinkedColumnIndex = 0;
            this.cmbDocAcct.LinkedTextBox = null;
            this.cmbDocAcct.Location = new System.Drawing.Point(486, 9);
            this.cmbDocAcct.Name = "cmbDocAcct";
            this.cmbDocAcct.Size = new System.Drawing.Size(100, 20);
            this.cmbDocAcct.TabIndex = 5;
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
            this.cmbUser.Location = new System.Drawing.Point(7, 24);
            this.cmbUser.Name = "cmbUser";
            this.cmbUser.Size = new System.Drawing.Size(100, 20);
            this.cmbUser.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmbUser.TabIndex = 14;
            // 
            // labelX16
            // 
            // 
            // 
            // 
            this.labelX16.BackgroundStyle.Class = "";
            this.labelX16.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX16.Location = new System.Drawing.Point(7, 5);
            this.labelX16.Name = "labelX16";
            this.labelX16.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelX16.Size = new System.Drawing.Size(100, 20);
            this.labelX16.TabIndex = 25;
            this.labelX16.Text = "User";
            // 
            // labelX14
            // 
            // 
            // 
            // 
            this.labelX14.BackgroundStyle.Class = "";
            this.labelX14.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX14.Location = new System.Drawing.Point(377, 5);
            this.labelX14.Name = "labelX14";
            this.labelX14.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelX14.Size = new System.Drawing.Size(100, 20);
            this.labelX14.TabIndex = 24;
            this.labelX14.Text = "DocNbr";
            // 
            // FromDate
            // 
            // 
            // 
            // 
            this.FromDate.BackgroundStyle.Class = "";
            this.FromDate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.FromDate.Location = new System.Drawing.Point(130, 5);
            this.FromDate.Name = "FromDate";
            this.FromDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.FromDate.Size = new System.Drawing.Size(100, 20);
            this.FromDate.TabIndex = 23;
            this.FromDate.Text = "FromDate";
            // 
            // labelX17
            // 
            // 
            // 
            // 
            this.labelX17.BackgroundStyle.Class = "";
            this.labelX17.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX17.Location = new System.Drawing.Point(255, 5);
            this.labelX17.Name = "labelX17";
            this.labelX17.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelX17.Size = new System.Drawing.Size(100, 20);
            this.labelX17.TabIndex = 22;
            this.labelX17.Text = "ToDate";
            // 
            // labelX15
            // 
            // 
            // 
            // 
            this.labelX15.BackgroundStyle.Class = "";
            this.labelX15.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX15.Location = new System.Drawing.Point(497, 5);
            this.labelX15.Name = "labelX15";
            this.labelX15.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelX15.Size = new System.Drawing.Size(100, 20);
            this.labelX15.TabIndex = 28;
            this.labelX15.Text = "InvcNbr";
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
            this.dtmFromDate.Location = new System.Drawing.Point(130, 24);
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
            this.dtmFromDate.TabIndex = 15;
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
            this.dtmToDate.Location = new System.Drawing.Point(255, 24);
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
            this.dtmToDate.MonthCalendar.DisplayMonth = new System.DateTime(2012, 4, 1, 0, 0, 0, 0);
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
            this.dtmToDate.TabIndex = 16;
            // 
            // txtDocNbrFind
            // 
            // 
            // 
            // 
            this.txtDocNbrFind.Border.Class = "TextBoxBorder";
            this.txtDocNbrFind.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDocNbrFind.Location = new System.Drawing.Point(377, 24);
            this.txtDocNbrFind.Name = "txtDocNbrFind";
            this.txtDocNbrFind.Size = new System.Drawing.Size(100, 20);
            this.txtDocNbrFind.TabIndex = 17;
            // 
            // txtInvcNbrFind
            // 
            // 
            // 
            // 
            this.txtInvcNbrFind.Border.Class = "TextBoxBorder";
            this.txtInvcNbrFind.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtInvcNbrFind.Location = new System.Drawing.Point(497, 24);
            this.txtInvcNbrFind.Name = "txtInvcNbrFind";
            this.txtInvcNbrFind.Size = new System.Drawing.Size(100, 20);
            this.txtInvcNbrFind.TabIndex = 18;
            // 
            // btnSearch
            // 
            this.btnSearch.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSearch.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSearch.Location = new System.Drawing.Point(615, 24);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSearch.TabIndex = 19;
            this.btnSearch.Text = "Search";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtDocNbr
            // 
            // 
            // 
            // 
            this.txtDocNbr.Border.Class = "TextBoxBorder";
            this.txtDocNbr.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDocNbr.Location = new System.Drawing.Point(287, 12);
            this.txtDocNbr.Name = "txtDocNbr";
            this.txtDocNbr.ReadOnly = true;
            this.txtDocNbr.Size = new System.Drawing.Size(100, 20);
            this.txtDocNbr.TabIndex = 64;
            // 
            // txtInvcNbr
            // 
            // 
            // 
            // 
            this.txtInvcNbr.Border.Class = "TextBoxBorder";
            this.txtInvcNbr.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtInvcNbr.Location = new System.Drawing.Point(486, 64);
            this.txtInvcNbr.Name = "txtInvcNbr";
            this.txtInvcNbr.Size = new System.Drawing.Size(100, 20);
            this.txtInvcNbr.TabIndex = 7;
            // 
            // txtInvcNote
            // 
            // 
            // 
            // 
            this.txtInvcNote.Border.Class = "TextBoxBorder";
            this.txtInvcNote.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtInvcNote.Location = new System.Drawing.Point(486, 92);
            this.txtInvcNote.Name = "txtInvcNote";
            this.txtInvcNote.Size = new System.Drawing.Size(100, 20);
            this.txtInvcNote.TabIndex = 8;
            // 
            // txtDocDescr
            // 
            // 
            // 
            // 
            this.txtDocDescr.Border.Class = "TextBoxBorder";
            this.txtDocDescr.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDocDescr.Location = new System.Drawing.Point(88, 97);
            this.txtDocDescr.Name = "txtDocDescr";
            this.txtDocDescr.Size = new System.Drawing.Size(299, 20);
            this.txtDocDescr.TabIndex = 2;
            // 
            // cmbType
            // 
            this.cmbType.DisplayMember = "Text";
            this.cmbType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbType.FormattingEnabled = true;
            this.cmbType.ItemHeight = 14;
            this.cmbType.Location = new System.Drawing.Point(88, 66);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(100, 20);
            this.cmbType.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmbType.TabIndex = 67;
            // 
            // cmbStatus
            // 
            this.cmbStatus.DisplayMember = "Text";
            this.cmbStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.ItemHeight = 14;
            this.cmbStatus.Location = new System.Drawing.Point(88, 38);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(100, 20);
            this.cmbStatus.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmbStatus.TabIndex = 68;
            // 
            // normalLabel1
            // 
            // 
            // 
            // 
            this.normalLabel1.BackgroundStyle.Class = "";
            this.normalLabel1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.normalLabel1.Location = new System.Drawing.Point(427, 92);
            this.normalLabel1.Name = "normalLabel1";
            this.normalLabel1.Size = new System.Drawing.Size(53, 23);
            this.normalLabel1.TabIndex = 72;
            this.normalLabel1.Text = "InvcNote";
            // 
            // AP201
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.DoubleBuffered = true;
            this.Name = "AP201";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.AP201_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).EndInit();
            this.pnldgv.ResumeLayout(false);
            this.pnl.ResumeLayout(false);
            this.pnlhead.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barStatus)).EndInit();
            this.panelEx1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtmDocDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtmDueDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtmFromDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtmToDate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PT.Component.NormalLabel labelX6;
        private PT.Component.MultiColumnComboBox cmbBranchID;
        private PT.Component.NormalDateTimeInput dtmDocDate;
        private PT.Component.NormalLabel labelX8;
        private PT.Component.NormalLabel labelX4;
        private PT.Component.NormalLabel labelX9;
        private PT.Component.NormalLabel lblBranchID;
        private PT.Component.NormalLabel labelX5;
        private PT.Component.NormalLabel labelX2;
        private PT.Component.NormalLabel VendID;
        private PT.Component.MultiDropDownTextBox txtVendID;
        private PT.Component.NormalDateTimeInput dtmDueDate;
        private PT.Component.NormalLabel labelX10;
        private PT.Component.NormalLabel labelX7;
        private PT.Component.MultiColumnComboBox cmbTaxID;
        private PT.Component.NumericTextBox txtPreTaxAmt;
        private PT.Component.NormalLabel labelX11;
        private PT.Component.NumericTextBox txtOrigDocAmt;
        private PT.Component.NumericTextBox txtTaxAmt;
        private PT.Component.NormalLabel labelX13;
        private PT.Component.NormalLabel labelX12;
        private PT.Component.NormalLabel labelX1;
        private PT.Component.MultiColumnComboBox cmbDocAcct;
        private PT.Component.NormalLabel labelX15;
        private PT.Component.MultiColumnComboBox cmbUser;
        private PT.Component.NormalLabel labelX16;
        private PT.Component.NormalLabel labelX14;
        private PT.Component.NormalLabel FromDate;
        private PT.Component.NormalLabel labelX17;
        private PT.Component.NormalDateTimeInput dtmToDate;
        private PT.Component.NormalDateTimeInput dtmFromDate;
        private PT.Component.NormalTextBox txtDocNbrFind;
        private PT.Component.NormalTextBox txtInvcNbrFind;
        private DevComponents.DotNetBar.ButtonX btnSearch;
        private PT.Component.NormalTextBox txtDocDescr;
        private PT.Component.NormalTextBox txtInvcNote;
        private PT.Component.NormalTextBox txtInvcNbr;
        private PT.Component.NormalTextBox txtDocNbr;
        private PT.Component.NormalComboBox cmbStatus;
        private PT.Component.NormalComboBox cmbType;
        private PT.Component.NormalLabel normalLabel1;
    }
}

