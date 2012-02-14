namespace IN202
{
    partial class IN202
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
            this.pnlHeader = new DevComponents.DotNetBar.PanelEx();
            this.cmbBranchID = new PT.Component.MultiColumnComboBox();
            this.cmbWhID = new PT.Component.MultiColumnComboBox();
            this.cmbReason = new PT.Component.MultiColumnComboBox();
            this.cmbToWhID = new PT.Component.MultiColumnComboBox();
            this.txtTotalAmt = new PT.Component.NumericTextBox();
            this.txtTotalQty = new PT.Component.NumericTextBox();
            this.labelX19 = new DevComponents.DotNetBar.LabelX();
            this.dtmDocDate = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.txtStatus = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.lblBranchID = new DevComponents.DotNetBar.LabelX();
            this.txtDocDescr = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtDocNbr = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.panelEx3 = new DevComponents.DotNetBar.PanelEx();
            this.dgvDocDet = new PT.Component.DataGridView(this.components);
            this.pnlInput = new DevComponents.DotNetBar.PanelEx();
            this.checkBoxX1 = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.txtTotalCost = new PT.Component.NumericTextBox();
            this.txtUnitCost = new PT.Component.NumericTextBox();
            this.txtQty = new PT.Component.NumericTextBox();
            this.cmbIUnit = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.btnAddRow = new DevComponents.DotNetBar.ButtonX();
            this.labelX14 = new DevComponents.DotNetBar.LabelX();
            this.labelX13 = new DevComponents.DotNetBar.LabelX();
            this.labelX12 = new DevComponents.DotNetBar.LabelX();
            this.labelX11 = new DevComponents.DotNetBar.LabelX();
            this.labelX10 = new DevComponents.DotNetBar.LabelX();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.txtLotID = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.dateTimeInput2 = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.dateTimeInput3 = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.labelX15 = new DevComponents.DotNetBar.LabelX();
            this.dtmFromDate = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.labelX16 = new DevComponents.DotNetBar.LabelX();
            this.labelX17 = new DevComponents.DotNetBar.LabelX();
            this.labelX18 = new DevComponents.DotNetBar.LabelX();
            this.cmbUser = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.dmtToDate = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.FromDate = new DevComponents.DotNetBar.LabelX();
            this.txtDocNbrFind = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX20 = new DevComponents.DotNetBar.LabelX();
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).BeginInit();
            this.pnldgv.SuspendLayout();
            this.pnl.SuspendLayout();
            this.pnlhead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtmDocDate)).BeginInit();
            this.panelEx3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocDet)).BeginInit();
            this.pnlInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeInput2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeInput3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtmFromDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dmtToDate)).BeginInit();
            this.SuspendLayout();
            // 
            // bar1
            // 
            this.bar1.Size = new System.Drawing.Size(784, 25);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            // 
            // btnBack
            // 
            this.btnBack.Enabled = false;
            // 
            // pnldgv
            // 
            this.pnldgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnldgv.Location = new System.Drawing.Point(0, 0);
            this.pnldgv.Size = new System.Drawing.Size(784, 537);
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
            this.pnl.Controls.Add(this.panelEx3);
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
            this.pnlhead.Controls.Add(this.txtDocNbrFind);
            this.pnlhead.Controls.Add(this.labelX20);
            this.pnlhead.Controls.Add(this.FromDate);
            this.pnlhead.Controls.Add(this.dmtToDate);
            this.pnlhead.Controls.Add(this.cmbUser);
            this.pnlhead.Controls.Add(this.labelX17);
            this.pnlhead.Controls.Add(this.labelX16);
            this.pnlhead.Controls.Add(this.dtmFromDate);
            this.pnlhead.Size = new System.Drawing.Size(784, 45);
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
            this.dgv.Size = new System.Drawing.Size(784, 492);
            // 
            // pnlHeader
            // 
            this.pnlHeader.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnlHeader.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.pnlHeader.Controls.Add(this.cmbBranchID);
            this.pnlHeader.Controls.Add(this.cmbWhID);
            this.pnlHeader.Controls.Add(this.cmbReason);
            this.pnlHeader.Controls.Add(this.cmbToWhID);
            this.pnlHeader.Controls.Add(this.txtTotalAmt);
            this.pnlHeader.Controls.Add(this.txtTotalQty);
            this.pnlHeader.Controls.Add(this.labelX19);
            this.pnlHeader.Controls.Add(this.dtmDocDate);
            this.pnlHeader.Controls.Add(this.labelX7);
            this.pnlHeader.Controls.Add(this.labelX8);
            this.pnlHeader.Controls.Add(this.txtStatus);
            this.pnlHeader.Controls.Add(this.labelX6);
            this.pnlHeader.Controls.Add(this.labelX5);
            this.pnlHeader.Controls.Add(this.labelX4);
            this.pnlHeader.Controls.Add(this.labelX3);
            this.pnlHeader.Controls.Add(this.labelX2);
            this.pnlHeader.Controls.Add(this.labelX1);
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
            this.pnlHeader.TabIndex = 0;
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
            this.cmbBranchID.TabIndex = 31;
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
            this.cmbWhID.TabIndex = 31;
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
            this.cmbReason.Location = new System.Drawing.Point(660, 11);
            this.cmbReason.Name = "cmbReason";
            this.cmbReason.Size = new System.Drawing.Size(100, 20);
            this.cmbReason.TabIndex = 32;
            // 
            // cmbToWhID
            // 
            this.cmbToWhID.AutoComplete = false;
            this.cmbToWhID.AutoDropdown = false;
            this.cmbToWhID.BackColorEven = System.Drawing.Color.White;
            this.cmbToWhID.BackColorOdd = System.Drawing.Color.White;
            this.cmbToWhID.ColumnNames = "";
            this.cmbToWhID.ColumnWidthDefault = 75;
            this.cmbToWhID.ColumnWidths = "";
            this.cmbToWhID.DisplayMember = "Text";
            this.cmbToWhID.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbToWhID.FormattingEnabled = true;
            this.cmbToWhID.ItemHeight = 14;
            this.cmbToWhID.LinkedColumnIndex = 0;
            this.cmbToWhID.LinkedTextBox = null;
            this.cmbToWhID.Location = new System.Drawing.Point(464, 38);
            this.cmbToWhID.Name = "cmbToWhID";
            this.cmbToWhID.Size = new System.Drawing.Size(100, 20);
            this.cmbToWhID.TabIndex = 32;
            // 
            // txtTotalAmt
            // 
            this.txtTotalAmt.AllowSpace = false;
            // 
            // 
            // 
            this.txtTotalAmt.Border.Class = "TextBoxBorder";
            this.txtTotalAmt.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTotalAmt.Location = new System.Drawing.Point(660, 62);
            this.txtTotalAmt.Name = "txtTotalAmt";
            this.txtTotalAmt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTotalAmt.Size = new System.Drawing.Size(100, 20);
            this.txtTotalAmt.TabIndex = 30;
            // 
            // txtTotalQty
            // 
            this.txtTotalQty.AllowSpace = false;
            // 
            // 
            // 
            this.txtTotalQty.Border.Class = "TextBoxBorder";
            this.txtTotalQty.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTotalQty.Location = new System.Drawing.Point(660, 34);
            this.txtTotalQty.Name = "txtTotalQty";
            this.txtTotalQty.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTotalQty.Size = new System.Drawing.Size(100, 20);
            this.txtTotalQty.TabIndex = 29;
            // 
            // labelX19
            // 
            // 
            // 
            // 
            this.labelX19.BackgroundStyle.Class = "";
            this.labelX19.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX19.Location = new System.Drawing.Point(604, 40);
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
            this.dtmDocDate.TabIndex = 18;
            // 
            // labelX7
            // 
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.Class = "";
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Location = new System.Drawing.Point(405, 15);
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
            // txtStatus
            // 
            // 
            // 
            // 
            this.txtStatus.Border.Class = "TextBoxBorder";
            this.txtStatus.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtStatus.Location = new System.Drawing.Point(72, 37);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(100, 20);
            this.txtStatus.TabIndex = 16;
            // 
            // labelX6
            // 
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.Class = "";
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Location = new System.Drawing.Point(405, 42);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(50, 15);
            this.labelX6.TabIndex = 14;
            this.labelX6.Text = "ToWhID";
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
            this.labelX3.Location = new System.Drawing.Point(604, 12);
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
            this.labelX2.Location = new System.Drawing.Point(604, 67);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(50, 15);
            this.labelX2.TabIndex = 8;
            this.labelX2.Text = "TotalAmt";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(212, 42);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(50, 15);
            this.labelX1.TabIndex = 7;
            this.labelX1.Text = "DocDate";
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
            this.txtDocDescr.TabIndex = 5;
            // 
            // txtDocNbr
            // 
            // 
            // 
            // 
            this.txtDocNbr.Border.Class = "TextBoxBorder";
            this.txtDocNbr.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDocNbr.Location = new System.Drawing.Point(271, 12);
            this.txtDocNbr.Name = "txtDocNbr";
            this.txtDocNbr.Size = new System.Drawing.Size(100, 20);
            this.txtDocNbr.TabIndex = 1;
            // 
            // panelEx3
            // 
            this.panelEx3.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx3.Controls.Add(this.dgvDocDet);
            this.panelEx3.Controls.Add(this.pnlInput);
            this.panelEx3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx3.Location = new System.Drawing.Point(0, 101);
            this.panelEx3.Name = "panelEx3";
            this.panelEx3.Size = new System.Drawing.Size(784, 436);
            this.panelEx3.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx3.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx3.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx3.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx3.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx3.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx3.Style.GradientAngle = 90;
            this.panelEx3.TabIndex = 1;
            // 
            // dgvDocDet
            // 
            this.dgvDocDet.AutoColumnHeadder = true;
            this.dgvDocDet.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDocDet.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDocDet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDocDet.EndCell = 0;
            this.dgvDocDet.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvDocDet.Language = "Language1";
            this.dgvDocDet.Location = new System.Drawing.Point(0, 53);
            this.dgvDocDet.Name = "dgvDocDet";
            this.dgvDocDet.Size = new System.Drawing.Size(784, 383);
            this.dgvDocDet.TabIndex = 1;
            // 
            // pnlInput
            // 
            this.pnlInput.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnlInput.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.pnlInput.Controls.Add(this.checkBoxX1);
            this.pnlInput.Controls.Add(this.txtTotalCost);
            this.pnlInput.Controls.Add(this.txtUnitCost);
            this.pnlInput.Controls.Add(this.txtQty);
            this.pnlInput.Controls.Add(this.cmbIUnit);
            this.pnlInput.Controls.Add(this.btnAddRow);
            this.pnlInput.Controls.Add(this.labelX14);
            this.pnlInput.Controls.Add(this.labelX13);
            this.pnlInput.Controls.Add(this.labelX12);
            this.pnlInput.Controls.Add(this.labelX11);
            this.pnlInput.Controls.Add(this.labelX10);
            this.pnlInput.Controls.Add(this.labelX9);
            this.pnlInput.Controls.Add(this.txtLotID);
            this.pnlInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlInput.Location = new System.Drawing.Point(0, 0);
            this.pnlInput.Name = "pnlInput";
            this.pnlInput.Size = new System.Drawing.Size(784, 53);
            this.pnlInput.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.pnlInput.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.pnlInput.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.pnlInput.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.pnlInput.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnlInput.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnlInput.Style.GradientAngle = 90;
            this.pnlInput.TabIndex = 0;
            // 
            // checkBoxX1
            // 
            // 
            // 
            // 
            this.checkBoxX1.BackgroundStyle.Class = "";
            this.checkBoxX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.checkBoxX1.Location = new System.Drawing.Point(87, 11);
            this.checkBoxX1.Name = "checkBoxX1";
            this.checkBoxX1.Size = new System.Drawing.Size(20, 10);
            this.checkBoxX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.checkBoxX1.TabIndex = 37;
            // 
            // txtTotalCost
            // 
            this.txtTotalCost.AllowSpace = false;
            // 
            // 
            // 
            this.txtTotalCost.Border.Class = "TextBoxBorder";
            this.txtTotalCost.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTotalCost.Location = new System.Drawing.Point(559, 27);
            this.txtTotalCost.Name = "txtTotalCost";
            this.txtTotalCost.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTotalCost.Size = new System.Drawing.Size(100, 20);
            this.txtTotalCost.TabIndex = 5;
            // 
            // txtUnitCost
            // 
            this.txtUnitCost.AllowSpace = false;
            // 
            // 
            // 
            this.txtUnitCost.Border.Class = "TextBoxBorder";
            this.txtUnitCost.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtUnitCost.Location = new System.Drawing.Point(453, 27);
            this.txtUnitCost.Name = "txtUnitCost";
            this.txtUnitCost.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtUnitCost.Size = new System.Drawing.Size(100, 20);
            this.txtUnitCost.TabIndex = 4;
            // 
            // txtQty
            // 
            this.txtQty.AllowSpace = false;
            // 
            // 
            // 
            this.txtQty.Border.Class = "TextBoxBorder";
            this.txtQty.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtQty.Location = new System.Drawing.Point(347, 27);
            this.txtQty.Name = "txtQty";
            this.txtQty.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtQty.Size = new System.Drawing.Size(100, 20);
            this.txtQty.TabIndex = 3;
            // 
            // cmbIUnit
            // 
            this.cmbIUnit.DisplayMember = "Text";
            this.cmbIUnit.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbIUnit.FormattingEnabled = true;
            this.cmbIUnit.ItemHeight = 14;
            this.cmbIUnit.Location = new System.Drawing.Point(238, 27);
            this.cmbIUnit.Name = "cmbIUnit";
            this.cmbIUnit.Size = new System.Drawing.Size(100, 20);
            this.cmbIUnit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmbIUnit.TabIndex = 2;
            this.cmbIUnit.SelectedIndexChanged += new System.EventHandler(this.cmbIUnit_SelectedIndexChanged);
            // 
            // btnAddRow
            // 
            this.btnAddRow.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAddRow.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAddRow.Location = new System.Drawing.Point(675, 27);
            this.btnAddRow.Name = "btnAddRow";
            this.btnAddRow.Size = new System.Drawing.Size(40, 20);
            this.btnAddRow.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAddRow.TabIndex = 31;
            this.btnAddRow.Text = "Add";
            this.btnAddRow.Click += new System.EventHandler(this.btnAddRow_Click);
            // 
            // labelX14
            // 
            // 
            // 
            // 
            this.labelX14.BackgroundStyle.Class = "";
            this.labelX14.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX14.Location = new System.Drawing.Point(559, 9);
            this.labelX14.Name = "labelX14";
            this.labelX14.Size = new System.Drawing.Size(100, 15);
            this.labelX14.TabIndex = 30;
            this.labelX14.Text = "TotalCost";
            // 
            // labelX13
            // 
            // 
            // 
            // 
            this.labelX13.BackgroundStyle.Class = "";
            this.labelX13.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX13.Location = new System.Drawing.Point(453, 9);
            this.labelX13.Name = "labelX13";
            this.labelX13.Size = new System.Drawing.Size(100, 15);
            this.labelX13.TabIndex = 28;
            this.labelX13.Text = "UnitCost";
            // 
            // labelX12
            // 
            // 
            // 
            // 
            this.labelX12.BackgroundStyle.Class = "";
            this.labelX12.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX12.Location = new System.Drawing.Point(347, 9);
            this.labelX12.Name = "labelX12";
            this.labelX12.Size = new System.Drawing.Size(100, 15);
            this.labelX12.TabIndex = 26;
            this.labelX12.Text = "Qty";
            // 
            // labelX11
            // 
            // 
            // 
            // 
            this.labelX11.BackgroundStyle.Class = "";
            this.labelX11.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX11.Location = new System.Drawing.Point(238, 9);
            this.labelX11.Name = "labelX11";
            this.labelX11.Size = new System.Drawing.Size(100, 15);
            this.labelX11.TabIndex = 25;
            this.labelX11.Text = "Unit";
            // 
            // labelX10
            // 
            // 
            // 
            // 
            this.labelX10.BackgroundStyle.Class = "";
            this.labelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX10.Location = new System.Drawing.Point(129, 9);
            this.labelX10.Name = "labelX10";
            this.labelX10.Size = new System.Drawing.Size(100, 15);
            this.labelX10.TabIndex = 24;
            this.labelX10.Text = "LotID";
            // 
            // labelX9
            // 
            // 
            // 
            // 
            this.labelX9.BackgroundStyle.Class = "";
            this.labelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX9.Location = new System.Drawing.Point(21, 9);
            this.labelX9.Name = "labelX9";
            this.labelX9.Size = new System.Drawing.Size(100, 15);
            this.labelX9.TabIndex = 23;
            this.labelX9.Text = "ProductID";
            // 
            // txtLotID
            // 
            this.txtLotID.BackColor = System.Drawing.Color.AntiqueWhite;
            // 
            // 
            // 
            this.txtLotID.Border.Class = "TextBoxBorder";
            this.txtLotID.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtLotID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtLotID.Location = new System.Drawing.Point(129, 27);
            this.txtLotID.Name = "txtLotID";
            this.txtLotID.Size = new System.Drawing.Size(100, 20);
            this.txtLotID.TabIndex = 1;
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
            this.dateTimeInput2.Location = new System.Drawing.Point(316, 9);
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
            this.dateTimeInput2.TabIndex = 1;
            // 
            // dateTimeInput3
            // 
            // 
            // 
            // 
            this.dateTimeInput3.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dateTimeInput3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimeInput3.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dateTimeInput3.ButtonDropDown.Visible = true;
            this.dateTimeInput3.IsPopupCalendarOpen = false;
            this.dateTimeInput3.Location = new System.Drawing.Point(489, 9);
            // 
            // 
            // 
            this.dateTimeInput3.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dateTimeInput3.MonthCalendar.BackgroundStyle.Class = "";
            this.dateTimeInput3.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimeInput3.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dateTimeInput3.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dateTimeInput3.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dateTimeInput3.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dateTimeInput3.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dateTimeInput3.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dateTimeInput3.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dateTimeInput3.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.dateTimeInput3.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimeInput3.MonthCalendar.DisplayMonth = new System.DateTime(2012, 2, 1, 0, 0, 0, 0);
            this.dateTimeInput3.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dateTimeInput3.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dateTimeInput3.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dateTimeInput3.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dateTimeInput3.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dateTimeInput3.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.dateTimeInput3.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimeInput3.MonthCalendar.TodayButtonVisible = true;
            this.dateTimeInput3.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dateTimeInput3.Name = "dateTimeInput3";
            this.dateTimeInput3.Size = new System.Drawing.Size(100, 20);
            this.dateTimeInput3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dateTimeInput3.TabIndex = 2;
            // 
            // labelX15
            // 
            // 
            // 
            // 
            this.labelX15.BackgroundStyle.Class = "";
            this.labelX15.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX15.Location = new System.Drawing.Point(12, 6);
            this.labelX15.Name = "labelX15";
            this.labelX15.Size = new System.Drawing.Size(50, 23);
            this.labelX15.TabIndex = 3;
            this.labelX15.Text = "User";
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
            this.dtmFromDate.Location = new System.Drawing.Point(228, 11);
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
            this.dtmFromDate.TabIndex = 1;
            // 
            // labelX16
            // 
            // 
            // 
            // 
            this.labelX16.BackgroundStyle.Class = "";
            this.labelX16.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX16.Location = new System.Drawing.Point(5, 11);
            this.labelX16.Name = "labelX16";
            this.labelX16.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX16.Size = new System.Drawing.Size(31, 23);
            this.labelX16.TabIndex = 3;
            this.labelX16.Text = "User";
            // 
            // labelX17
            // 
            // 
            // 
            // 
            this.labelX17.BackgroundStyle.Class = "";
            this.labelX17.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX17.Location = new System.Drawing.Point(340, 11);
            this.labelX17.Name = "labelX17";
            this.labelX17.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX17.Size = new System.Drawing.Size(50, 23);
            this.labelX17.TabIndex = 4;
            this.labelX17.Text = "ToDate";
            // 
            // labelX18
            // 
            // 
            // 
            // 
            this.labelX18.BackgroundStyle.Class = "";
            this.labelX18.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX18.Location = new System.Drawing.Point(224, 10);
            this.labelX18.Name = "labelX18";
            this.labelX18.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX18.Size = new System.Drawing.Size(62, 23);
            this.labelX18.TabIndex = 5;
            this.labelX18.Text = "FromDate";
            // 
            // cmbUser
            // 
            this.cmbUser.DisplayMember = "Text";
            this.cmbUser.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbUser.FormattingEnabled = true;
            this.cmbUser.ItemHeight = 14;
            this.cmbUser.Location = new System.Drawing.Point(45, 11);
            this.cmbUser.Name = "cmbUser";
            this.cmbUser.Size = new System.Drawing.Size(102, 20);
            this.cmbUser.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmbUser.TabIndex = 5;
            // 
            // dmtToDate
            // 
            // 
            // 
            // 
            this.dmtToDate.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dmtToDate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dmtToDate.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dmtToDate.ButtonDropDown.Visible = true;
            this.dmtToDate.IsPopupCalendarOpen = false;
            this.dmtToDate.Location = new System.Drawing.Point(399, 11);
            // 
            // 
            // 
            this.dmtToDate.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dmtToDate.MonthCalendar.BackgroundStyle.Class = "";
            this.dmtToDate.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dmtToDate.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dmtToDate.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dmtToDate.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dmtToDate.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dmtToDate.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dmtToDate.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dmtToDate.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dmtToDate.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.dmtToDate.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dmtToDate.MonthCalendar.DisplayMonth = new System.DateTime(2012, 2, 1, 0, 0, 0, 0);
            this.dmtToDate.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dmtToDate.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dmtToDate.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dmtToDate.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dmtToDate.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dmtToDate.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.dmtToDate.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dmtToDate.MonthCalendar.TodayButtonVisible = true;
            this.dmtToDate.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dmtToDate.Name = "dmtToDate";
            this.dmtToDate.Size = new System.Drawing.Size(100, 20);
            this.dmtToDate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dmtToDate.TabIndex = 6;
            // 
            // FromDate
            // 
            // 
            // 
            // 
            this.FromDate.BackgroundStyle.Class = "";
            this.FromDate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.FromDate.Location = new System.Drawing.Point(171, 11);
            this.FromDate.Name = "FromDate";
            this.FromDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.FromDate.Size = new System.Drawing.Size(50, 23);
            this.FromDate.TabIndex = 7;
            this.FromDate.Text = "FromDate";
            // 
            // txtDocNbrFind
            // 
            // 
            // 
            // 
            this.txtDocNbrFind.Border.Class = "TextBoxBorder";
            this.txtDocNbrFind.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDocNbrFind.Location = new System.Drawing.Point(570, 11);
            this.txtDocNbrFind.Name = "txtDocNbrFind";
            this.txtDocNbrFind.Size = new System.Drawing.Size(100, 20);
            this.txtDocNbrFind.TabIndex = 17;
            // 
            // labelX20
            // 
            // 
            // 
            // 
            this.labelX20.BackgroundStyle.Class = "";
            this.labelX20.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX20.Location = new System.Drawing.Point(526, 11);
            this.labelX20.Name = "labelX20";
            this.labelX20.Size = new System.Drawing.Size(50, 23);
            this.labelX20.TabIndex = 16;
            this.labelX20.Text = "DocNbr";
            // 
            // IN202
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Name = "IN202";
            this.Text = "Chuyển Kho";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).EndInit();
            this.pnldgv.ResumeLayout(false);
            this.pnl.ResumeLayout(false);
            this.pnlhead.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtmDocDate)).EndInit();
            this.panelEx3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocDet)).EndInit();
            this.pnlInput.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeInput2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeInput3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtmFromDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dmtToDate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx3;
        private DevComponents.DotNetBar.PanelEx pnlHeader;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDocDescr;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDocNbr;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX lblBranchID;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX8;
        private DevComponents.DotNetBar.Controls.TextBoxX txtStatus;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtmDocDate;
        private DevComponents.DotNetBar.PanelEx pnlInput;
        private DevComponents.DotNetBar.Controls.TextBoxX txtLotID;
        private DevComponents.DotNetBar.LabelX labelX13;
        private DevComponents.DotNetBar.LabelX labelX12;
        private DevComponents.DotNetBar.LabelX labelX11;
        private DevComponents.DotNetBar.LabelX labelX10;
        private DevComponents.DotNetBar.LabelX labelX9;
        private DevComponents.DotNetBar.ButtonX btnAddRow;
        private DevComponents.DotNetBar.LabelX labelX14;
        private PT.Component.DataGridView dgvDocDet;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dateTimeInput2;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dateTimeInput3;
        private DevComponents.DotNetBar.LabelX labelX15;
        private DevComponents.DotNetBar.LabelX labelX18;
        private DevComponents.DotNetBar.LabelX labelX17;
        private DevComponents.DotNetBar.LabelX labelX16;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtmFromDate;
        private DevComponents.DotNetBar.LabelX labelX19;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbUser;
        private DevComponents.DotNetBar.LabelX FromDate;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dmtToDate;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbIUnit;
        private PT.Component.NumericTextBox txtTotalCost;
        private PT.Component.NumericTextBox txtUnitCost;
        private PT.Component.NumericTextBox txtQty;
        private PT.Component.NumericTextBox txtTotalAmt;
        private PT.Component.NumericTextBox txtTotalQty;
        private DevComponents.DotNetBar.Controls.CheckBoxX checkBoxX1;
        private PT.Component.MultiColumnComboBox cmbWhID;
        private PT.Component.MultiColumnComboBox cmbToWhID;
        private PT.Component.MultiColumnComboBox cmbReason;
        private PT.Component.MultiColumnComboBox cmbBranchID;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDocNbrFind;
        private DevComponents.DotNetBar.LabelX labelX20;
    }
}

