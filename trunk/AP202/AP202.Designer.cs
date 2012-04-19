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
            this.labelX16 = new DevComponents.DotNetBar.LabelX();
            this.labelX14 = new DevComponents.DotNetBar.LabelX();
            this.FromDate = new DevComponents.DotNetBar.LabelX();
            this.dtmToDate = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.dtmFromDate = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.labelX17 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.DocAcct = new PT.Component.MultiColumnComboBox();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.cmbStatus = new PT.Component.MultiColumnComboBox();
            this.cmbBranchID = new PT.Component.MultiColumnComboBox();
            this.dtmAdjDate = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.lblBranchID = new DevComponents.DotNetBar.LabelX();
            this.txtAdjAmt = new PT.Component.NumericTextBox();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.panelEx2 = new DevComponents.DotNetBar.PanelEx();
            this.txtAdjNbr = new PT.Component.NormalTextBox();
            this.txtDocDescr = new PT.Component.NormalTextBox();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.dateTimeInput1 = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.dateTimeInput2 = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.VendID = new DevComponents.DotNetBar.LabelX();
            this.txtVendID = new PT.Component.MultiDropDownTextBox(this.components);
            this.panelEx3 = new DevComponents.DotNetBar.PanelEx();
            this.dgvDocList = new PT.Component.DataGridView(this.components);
            this.txtAdjdNbrFind = new PT.Component.NormalTextBox();
            this.btnLoad = new DevComponents.DotNetBar.ButtonX();
            this.panelEx4 = new DevComponents.DotNetBar.PanelEx();
            this.normalTextBox1 = new PT.Component.NormalTextBox();
            this.normalTextBox2 = new PT.Component.NormalTextBox();
            this.btnCheck = new DevComponents.DotNetBar.ButtonX();
            this.PONbr = new DevComponents.DotNetBar.LabelX();
            this.labelX10 = new DevComponents.DotNetBar.LabelX();
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barStatus)).BeginInit();
            this.panelEx1.SuspendLayout();
            this.pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.pnlhead.SuspendLayout();
            this.pnldgv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtmToDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtmFromDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtmAdjDate)).BeginInit();
            this.panelEx2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeInput1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeInput2)).BeginInit();
            this.panelEx3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocList)).BeginInit();
            this.panelEx4.SuspendLayout();
            this.SuspendLayout();
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
            // dgv
            // 
            this.dgv.Location = new System.Drawing.Point(0, 54);
            this.dgv.Size = new System.Drawing.Size(555, 4);
            // 
            // pnlhead
            // 
            this.pnlhead.Controls.Add(this.txtAdjdNbrFind);
            this.pnlhead.Controls.Add(this.cmbUser);
            this.pnlhead.Controls.Add(this.labelX17);
            this.pnlhead.Controls.Add(this.dtmFromDate);
            this.pnlhead.Controls.Add(this.labelX16);
            this.pnlhead.Controls.Add(this.dtmToDate);
            this.pnlhead.Controls.Add(this.FromDate);
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
            // labelX16
            // 
            // 
            // 
            // 
            this.labelX16.BackgroundStyle.Class = "";
            this.labelX16.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX16.Location = new System.Drawing.Point(12, 5);
            this.labelX16.Name = "labelX16";
            this.labelX16.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelX16.Size = new System.Drawing.Size(100, 20);
            this.labelX16.TabIndex = 35;
            this.labelX16.Text = "User";
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
            // FromDate
            // 
            // 
            // 
            // 
            this.FromDate.BackgroundStyle.Class = "";
            this.FromDate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.FromDate.Location = new System.Drawing.Point(135, 5);
            this.FromDate.Name = "FromDate";
            this.FromDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.FromDate.Size = new System.Drawing.Size(100, 20);
            this.FromDate.TabIndex = 33;
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
            this.dtmToDate.Size = new System.Drawing.Size(100, 20);
            this.dtmToDate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtmToDate.TabIndex = 30;
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
            this.dtmFromDate.Location = new System.Drawing.Point(135, 24);
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
            this.dtmFromDate.TabIndex = 29;
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
            // DocAcct
            // 
            this.DocAcct.AutoComplete = false;
            this.DocAcct.AutoDropdown = false;
            this.DocAcct.BackColorEven = System.Drawing.Color.White;
            this.DocAcct.BackColorOdd = System.Drawing.Color.White;
            this.DocAcct.ColumnNames = "";
            this.DocAcct.ColumnWidthDefault = 75;
            this.DocAcct.ColumnWidths = "";
            this.DocAcct.DisplayMember = "Text";
            this.DocAcct.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.DocAcct.FormattingEnabled = true;
            this.DocAcct.ItemHeight = 14;
            this.DocAcct.LinkedColumnIndex = 0;
            this.DocAcct.LinkedTextBox = null;
            this.DocAcct.Location = new System.Drawing.Point(467, 13);
            this.DocAcct.Name = "DocAcct";
            this.DocAcct.Size = new System.Drawing.Size(100, 20);
            this.DocAcct.TabIndex = 70;
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
            // lblBranchID
            // 
            // 
            // 
            // 
            this.lblBranchID.BackgroundStyle.Class = "";
            this.lblBranchID.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblBranchID.Location = new System.Drawing.Point(10, 15);
            this.lblBranchID.Name = "lblBranchID";
            this.lblBranchID.Size = new System.Drawing.Size(50, 15);
            this.lblBranchID.TabIndex = 59;
            this.lblBranchID.Text = "BranchID";
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
            this.panelEx2.Controls.Add(this.txtDocDescr);
            this.panelEx2.Controls.Add(this.labelX2);
            this.panelEx2.Controls.Add(this.txtAdjAmt);
            this.panelEx2.Controls.Add(this.labelX1);
            this.panelEx2.Controls.Add(this.DocAcct);
            this.panelEx2.Controls.Add(this.labelX5);
            this.panelEx2.Controls.Add(this.cmbBranchID);
            this.panelEx2.Controls.Add(this.cmbStatus);
            this.panelEx2.Controls.Add(this.lblBranchID);
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
            // txtDocDescr
            // 
            // 
            // 
            // 
            this.txtDocDescr.Border.Class = "TextBoxBorder";
            this.txtDocDescr.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDocDescr.Location = new System.Drawing.Point(69, 67);
            this.txtDocDescr.Name = "txtDocDescr";
            this.txtDocDescr.Size = new System.Drawing.Size(299, 20);
            this.txtDocDescr.TabIndex = 74;
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.Class = "";
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(132, 2);
            this.labelX3.Name = "labelX3";
            this.labelX3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelX3.Size = new System.Drawing.Size(100, 20);
            this.labelX3.TabIndex = 39;
            this.labelX3.Text = "ToDate";
            // 
            // dateTimeInput1
            // 
            // 
            // 
            // 
            this.dateTimeInput1.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dateTimeInput1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimeInput1.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dateTimeInput1.ButtonDropDown.Visible = true;
            this.dateTimeInput1.IsPopupCalendarOpen = false;
            this.dateTimeInput1.Location = new System.Drawing.Point(7, 21);
            // 
            // 
            // 
            this.dateTimeInput1.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dateTimeInput1.MonthCalendar.BackgroundStyle.Class = "";
            this.dateTimeInput1.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimeInput1.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dateTimeInput1.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dateTimeInput1.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dateTimeInput1.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dateTimeInput1.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dateTimeInput1.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dateTimeInput1.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dateTimeInput1.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.dateTimeInput1.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimeInput1.MonthCalendar.DisplayMonth = new System.DateTime(2012, 2, 1, 0, 0, 0, 0);
            this.dateTimeInput1.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dateTimeInput1.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dateTimeInput1.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dateTimeInput1.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dateTimeInput1.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dateTimeInput1.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.dateTimeInput1.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimeInput1.MonthCalendar.TodayButtonVisible = true;
            this.dateTimeInput1.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dateTimeInput1.Name = "dateTimeInput1";
            this.dateTimeInput1.Size = new System.Drawing.Size(100, 20);
            this.dateTimeInput1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dateTimeInput1.TabIndex = 37;
            // 
            // dateTimeInput2
            // 
            // 
            // 
            // 
            this.dateTimeInput2.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dateTimeInput2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimeInput2.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dateTimeInput2.ButtonDropDown.Visible = true;
            this.dateTimeInput2.IsPopupCalendarOpen = false;
            this.dateTimeInput2.Location = new System.Drawing.Point(132, 21);
            // 
            // 
            // 
            this.dateTimeInput2.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dateTimeInput2.MonthCalendar.BackgroundStyle.Class = "";
            this.dateTimeInput2.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimeInput2.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dateTimeInput2.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dateTimeInput2.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dateTimeInput2.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dateTimeInput2.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dateTimeInput2.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dateTimeInput2.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dateTimeInput2.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.dateTimeInput2.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimeInput2.MonthCalendar.DisplayMonth = new System.DateTime(2012, 2, 1, 0, 0, 0, 0);
            this.dateTimeInput2.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dateTimeInput2.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dateTimeInput2.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dateTimeInput2.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dateTimeInput2.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dateTimeInput2.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.dateTimeInput2.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimeInput2.MonthCalendar.TodayButtonVisible = true;
            this.dateTimeInput2.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dateTimeInput2.Name = "dateTimeInput2";
            this.dateTimeInput2.Size = new System.Drawing.Size(100, 20);
            this.dateTimeInput2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dateTimeInput2.TabIndex = 38;
            // 
            // labelX6
            // 
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.Class = "";
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Location = new System.Drawing.Point(7, 2);
            this.labelX6.Name = "labelX6";
            this.labelX6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelX6.Size = new System.Drawing.Size(100, 20);
            this.labelX6.TabIndex = 40;
            this.labelX6.Text = "labelX6";
            // 
            // VendID
            // 
            // 
            // 
            // 
            this.VendID.BackgroundStyle.Class = "";
            this.VendID.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.VendID.Location = new System.Drawing.Point(257, 4);
            this.VendID.Name = "VendID";
            this.VendID.Size = new System.Drawing.Size(50, 15);
            this.VendID.TabIndex = 51;
            this.VendID.Text = "VendID";
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
            this.txtVendID.Location = new System.Drawing.Point(257, 21);
            this.txtVendID.Name = "txtVendID";
            this.txtVendID.RowsDisplay = 10;
            this.txtVendID.Size = new System.Drawing.Size(100, 20);
            this.txtVendID.TabIndex = 50;
            // 
            // panelEx3
            // 
            this.panelEx3.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx3.Controls.Add(this.labelX10);
            this.panelEx3.Controls.Add(this.PONbr);
            this.panelEx3.Controls.Add(this.btnCheck);
            this.panelEx3.Controls.Add(this.normalTextBox2);
            this.panelEx3.Controls.Add(this.normalTextBox1);
            this.panelEx3.Controls.Add(this.panelEx4);
            this.panelEx3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEx3.Location = new System.Drawing.Point(0, 101);
            this.panelEx3.Name = "panelEx3";
            this.panelEx3.Size = new System.Drawing.Size(757, 56);
            this.panelEx3.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx3.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx3.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx3.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx3.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx3.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx3.Style.GradientAngle = 90;
            this.panelEx3.TabIndex = 75;
            // 
            // dgvDocList
            // 
            this.dgvDocList.AutoColumnHeadder = true;
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
            this.dgvDocList.Location = new System.Drawing.Point(0, 157);
            this.dgvDocList.Name = "dgvDocList";
            this.dgvDocList.Size = new System.Drawing.Size(757, 240);
            this.dgvDocList.TabIndex = 76;
            // 
            // txtAdjdNbrFind
            // 
            // 
            // 
            // 
            this.txtAdjdNbrFind.Border.Class = "TextBoxBorder";
            this.txtAdjdNbrFind.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtAdjdNbrFind.Location = new System.Drawing.Point(382, 23);
            this.txtAdjdNbrFind.Name = "txtAdjdNbrFind";
            this.txtAdjdNbrFind.Size = new System.Drawing.Size(100, 20);
            this.txtAdjdNbrFind.TabIndex = 37;
            // 
            // btnLoad
            // 
            this.btnLoad.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnLoad.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnLoad.Location = new System.Drawing.Point(373, 20);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnLoad.TabIndex = 52;
            this.btnLoad.Text = "Load";
            // 
            // panelEx4
            // 
            this.panelEx4.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx4.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx4.Controls.Add(this.dateTimeInput2);
            this.panelEx4.Controls.Add(this.btnLoad);
            this.panelEx4.Controls.Add(this.txtVendID);
            this.panelEx4.Controls.Add(this.dateTimeInput1);
            this.panelEx4.Controls.Add(this.labelX6);
            this.panelEx4.Controls.Add(this.VendID);
            this.panelEx4.Controls.Add(this.labelX3);
            this.panelEx4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelEx4.Location = new System.Drawing.Point(0, 0);
            this.panelEx4.Name = "panelEx4";
            this.panelEx4.Size = new System.Drawing.Size(467, 56);
            this.panelEx4.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx4.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx4.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx4.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx4.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx4.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx4.Style.GradientAngle = 90;
            this.panelEx4.TabIndex = 53;
            // 
            // normalTextBox1
            // 
            // 
            // 
            // 
            this.normalTextBox1.Border.Class = "TextBoxBorder";
            this.normalTextBox1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.normalTextBox1.Location = new System.Drawing.Point(501, 21);
            this.normalTextBox1.Name = "normalTextBox1";
            this.normalTextBox1.Size = new System.Drawing.Size(72, 20);
            this.normalTextBox1.TabIndex = 54;
            // 
            // normalTextBox2
            // 
            // 
            // 
            // 
            this.normalTextBox2.Border.Class = "TextBoxBorder";
            this.normalTextBox2.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.normalTextBox2.Location = new System.Drawing.Point(587, 21);
            this.normalTextBox2.Name = "normalTextBox2";
            this.normalTextBox2.Size = new System.Drawing.Size(66, 20);
            this.normalTextBox2.TabIndex = 55;
            // 
            // btnCheck
            // 
            this.btnCheck.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCheck.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCheck.Location = new System.Drawing.Point(660, 17);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(75, 23);
            this.btnCheck.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCheck.TabIndex = 56;
            this.btnCheck.Text = "Check";
            // 
            // PONbr
            // 
            // 
            // 
            // 
            this.PONbr.BackgroundStyle.Class = "";
            this.PONbr.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.PONbr.Location = new System.Drawing.Point(501, 3);
            this.PONbr.Name = "PONbr";
            this.PONbr.Size = new System.Drawing.Size(50, 15);
            this.PONbr.TabIndex = 53;
            this.PONbr.Text = "PONbr";
            // 
            // labelX10
            // 
            // 
            // 
            // 
            this.labelX10.BackgroundStyle.Class = "";
            this.labelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX10.Location = new System.Drawing.Point(587, 3);
            this.labelX10.Name = "labelX10";
            this.labelX10.Size = new System.Drawing.Size(50, 15);
            this.labelX10.TabIndex = 57;
            this.labelX10.Text = "InvcNbr";
            // 
            // AP202
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Name = "AP202";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barStatus)).EndInit();
            this.panelEx1.ResumeLayout(false);
            this.pnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.pnlhead.ResumeLayout(false);
            this.pnldgv.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtmToDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtmFromDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtmAdjDate)).EndInit();
            this.panelEx2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeInput1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeInput2)).EndInit();
            this.panelEx3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocList)).EndInit();
            this.panelEx4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private PT.Component.MultiColumnComboBox cmbUser;
        private DevComponents.DotNetBar.LabelX labelX16;
        private DevComponents.DotNetBar.LabelX labelX14;
        private DevComponents.DotNetBar.LabelX FromDate;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtmToDate;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtmFromDate;
        private DevComponents.DotNetBar.LabelX labelX17;
        private DevComponents.DotNetBar.LabelX labelX1;
        private PT.Component.MultiColumnComboBox DocAcct;
        private DevComponents.DotNetBar.LabelX labelX5;
        private PT.Component.MultiColumnComboBox cmbStatus;
        private PT.Component.MultiColumnComboBox cmbBranchID;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtmAdjDate;
        private DevComponents.DotNetBar.LabelX labelX8;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX9;
        private DevComponents.DotNetBar.LabelX lblBranchID;
        private DevComponents.DotNetBar.LabelX labelX2;
        private PT.Component.NumericTextBox txtAdjAmt;
        private DevComponents.DotNetBar.PanelEx panelEx2;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dateTimeInput2;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dateTimeInput1;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.LabelX VendID;
        private PT.Component.MultiDropDownTextBox txtVendID;
        private DevComponents.DotNetBar.PanelEx panelEx3;
        private PT.Component.DataGridView dgvDocList;
        private PT.Component.NormalTextBox txtAdjNbr;
        private PT.Component.NormalTextBox txtDocDescr;
        private PT.Component.NormalTextBox txtAdjdNbrFind;
        private DevComponents.DotNetBar.PanelEx panelEx4;
        private DevComponents.DotNetBar.ButtonX btnLoad;
        private DevComponents.DotNetBar.ButtonX btnCheck;
        private PT.Component.NormalTextBox normalTextBox2;
        private PT.Component.NormalTextBox normalTextBox1;
        private DevComponents.DotNetBar.LabelX labelX10;
        private DevComponents.DotNetBar.LabelX PONbr;
    }
}

