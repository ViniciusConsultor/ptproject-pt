namespace PT.Manager.DataForm
{
    partial class frmReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReport));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.btnBack = new DevComponents.DotNetBar.ButtonX();
            this.pnlFilter = new DevComponents.DotNetBar.PanelEx();
            this.panelEx3 = new DevComponents.DotNetBar.PanelEx();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.btnView = new DevComponents.DotNetBar.ButtonX();
            this.txtString3 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.cmbReportList = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.chkBool3 = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.dtmDate2 = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.chkBool2 = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.dtmDate1 = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.lblString1 = new DevComponents.DotNetBar.LabelX();
            this.lblString3 = new DevComponents.DotNetBar.LabelX();
            this.chkBool1 = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.lblDate2 = new DevComponents.DotNetBar.LabelX();
            this.lblString2 = new DevComponents.DotNetBar.LabelX();
            this.lblDate1 = new DevComponents.DotNetBar.LabelX();
            this.lblDate3 = new DevComponents.DotNetBar.LabelX();
            this.dtmDate3 = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.panelEx4 = new DevComponents.DotNetBar.PanelEx();
            this.panelEx2 = new DevComponents.DotNetBar.PanelEx();
            this.grdList = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.bar1 = new DevComponents.DotNetBar.Bar();
            this.buttonItem1 = new DevComponents.DotNetBar.ButtonItem();
            this.lblList = new DevComponents.DotNetBar.LabelItem();
            this.txtString2 = new PT.Manager.PTComponent.MultiDropDownTextBox(this.components);
            this.txtString1 = new PT.Manager.PTComponent.MultiDropDownTextBox(this.components);
            this.panelEx1.SuspendLayout();
            this.pnlFilter.SuspendLayout();
            this.panelEx3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtmDate2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtmDate1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtmDate3)).BeginInit();
            this.panelEx4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.crystalReportViewer1);
            this.panelEx1.Controls.Add(this.btnBack);
            this.panelEx1.Controls.Add(this.pnlFilter);
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(1039, 495);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 0;
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 231);
            this.crystalReportViewer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.SelectionFormula = "";
            this.crystalReportViewer1.Size = new System.Drawing.Size(1039, 264);
            this.crystalReportViewer1.TabIndex = 13;
            this.crystalReportViewer1.ViewTimeSelectionFormula = "";
            this.crystalReportViewer1.ReportRefresh += new CrystalDecisions.Windows.Forms.RefreshEventHandler(this.crystalReportViewer1_ReportRefresh);
            // 
            // btnBack
            // 
            this.btnBack.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnBack.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnBack.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnBack.Location = new System.Drawing.Point(0, 207);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(1039, 24);
            this.btnBack.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnBack.TabIndex = 12;
            this.btnBack.Text = "Hiện Toàn Màn Hình";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click_1);
            // 
            // pnlFilter
            // 
            this.pnlFilter.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnlFilter.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.pnlFilter.Controls.Add(this.panelEx3);
            this.pnlFilter.Controls.Add(this.panelEx4);
            this.pnlFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFilter.Location = new System.Drawing.Point(0, 0);
            this.pnlFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlFilter.Name = "pnlFilter";
            this.pnlFilter.Size = new System.Drawing.Size(1039, 207);
            this.pnlFilter.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.pnlFilter.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.pnlFilter.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.pnlFilter.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.pnlFilter.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnlFilter.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnlFilter.Style.GradientAngle = 90;
            this.pnlFilter.TabIndex = 11;
            // 
            // panelEx3
            // 
            this.panelEx3.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx3.Controls.Add(this.txtString2);
            this.panelEx3.Controls.Add(this.txtString1);
            this.panelEx3.Controls.Add(this.labelX1);
            this.panelEx3.Controls.Add(this.btnView);
            this.panelEx3.Controls.Add(this.txtString3);
            this.panelEx3.Controls.Add(this.cmbReportList);
            this.panelEx3.Controls.Add(this.chkBool3);
            this.panelEx3.Controls.Add(this.dtmDate2);
            this.panelEx3.Controls.Add(this.chkBool2);
            this.panelEx3.Controls.Add(this.dtmDate1);
            this.panelEx3.Controls.Add(this.lblString1);
            this.panelEx3.Controls.Add(this.lblString3);
            this.panelEx3.Controls.Add(this.chkBool1);
            this.panelEx3.Controls.Add(this.lblDate2);
            this.panelEx3.Controls.Add(this.lblString2);
            this.panelEx3.Controls.Add(this.lblDate1);
            this.panelEx3.Controls.Add(this.lblDate3);
            this.panelEx3.Controls.Add(this.dtmDate3);
            this.panelEx3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelEx3.Location = new System.Drawing.Point(0, 0);
            this.panelEx3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelEx3.Name = "panelEx3";
            this.panelEx3.Size = new System.Drawing.Size(346, 207);
            this.panelEx3.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx3.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx3.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx3.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx3.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx3.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx3.Style.GradientAngle = 90;
            this.panelEx3.TabIndex = 17;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelX1.Location = new System.Drawing.Point(6, 12);
            this.labelX1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(46, 24);
            this.labelX1.TabIndex = 1;
            this.labelX1.Text = "Báo Cáo";
            // 
            // btnView
            // 
            this.btnView.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnView.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnView.Image = ((System.Drawing.Image)(resources.GetObject("btnView.Image")));
            this.btnView.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.btnView.Location = new System.Drawing.Point(5, 170);
            this.btnView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(328, 33);
            this.btnView.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnView.TabIndex = 9;
            this.btnView.Text = "Xem Báo Cáo";
            this.btnView.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // txtString3
            // 
            // 
            // 
            // 
            this.txtString3.Border.Class = "TextBoxBorder";
            this.txtString3.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtString3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtString3.Location = new System.Drawing.Point(224, 109);
            this.txtString3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtString3.Name = "txtString3";
            this.txtString3.Size = new System.Drawing.Size(100, 20);
            this.txtString3.TabIndex = 16;
            // 
            // cmbReportList
            // 
            this.cmbReportList.DisplayMember = "Text";
            this.cmbReportList.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbReportList.Font = new System.Drawing.Font("Arial", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cmbReportList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.cmbReportList.FormattingEnabled = true;
            this.cmbReportList.ItemHeight = 15;
            this.cmbReportList.Location = new System.Drawing.Point(58, 13);
            this.cmbReportList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbReportList.Name = "cmbReportList";
            this.cmbReportList.Size = new System.Drawing.Size(276, 21);
            this.cmbReportList.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmbReportList.TabIndex = 1;
            this.cmbReportList.SelectedValueChanged += new System.EventHandler(this.cmbReportList_SelectedValueChanged);
            // 
            // chkBool3
            // 
            // 
            // 
            // 
            this.chkBool3.BackgroundStyle.Class = "";
            this.chkBool3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chkBool3.Enabled = false;
            this.chkBool3.Location = new System.Drawing.Point(223, 135);
            this.chkBool3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkBool3.Name = "chkBool3";
            this.chkBool3.Size = new System.Drawing.Size(82, 19);
            this.chkBool3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.chkBool3.TabIndex = 14;
            this.chkBool3.Text = "Bool 3";
            // 
            // dtmDate2
            // 
            // 
            // 
            // 
            this.dtmDate2.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtmDate2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtmDate2.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtmDate2.ButtonDropDown.Visible = true;
            this.dtmDate2.Enabled = false;
            this.dtmDate2.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Center;
            this.dtmDate2.IsPopupCalendarOpen = false;
            this.dtmDate2.Location = new System.Drawing.Point(116, 62);
            this.dtmDate2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            // 
            // 
            // 
            this.dtmDate2.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtmDate2.MonthCalendar.BackgroundStyle.Class = "";
            this.dtmDate2.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtmDate2.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtmDate2.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtmDate2.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtmDate2.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtmDate2.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtmDate2.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtmDate2.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtmDate2.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.dtmDate2.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtmDate2.MonthCalendar.DisplayMonth = new System.DateTime(2011, 12, 1, 0, 0, 0, 0);
            this.dtmDate2.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dtmDate2.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtmDate2.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtmDate2.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtmDate2.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtmDate2.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.dtmDate2.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtmDate2.MonthCalendar.TodayButtonVisible = true;
            this.dtmDate2.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dtmDate2.Name = "dtmDate2";
            this.dtmDate2.Size = new System.Drawing.Size(100, 20);
            this.dtmDate2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtmDate2.TabIndex = 1;
            // 
            // chkBool2
            // 
            // 
            // 
            // 
            this.chkBool2.BackgroundStyle.Class = "";
            this.chkBool2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chkBool2.Enabled = false;
            this.chkBool2.Location = new System.Drawing.Point(116, 135);
            this.chkBool2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkBool2.Name = "chkBool2";
            this.chkBool2.Size = new System.Drawing.Size(82, 19);
            this.chkBool2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.chkBool2.TabIndex = 1;
            this.chkBool2.Text = "Bool 2";
            // 
            // dtmDate1
            // 
            // 
            // 
            // 
            this.dtmDate1.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtmDate1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtmDate1.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtmDate1.ButtonDropDown.Visible = true;
            this.dtmDate1.Enabled = false;
            this.dtmDate1.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Center;
            this.dtmDate1.IsPopupCalendarOpen = false;
            this.dtmDate1.Location = new System.Drawing.Point(9, 62);
            this.dtmDate1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            // 
            // 
            // 
            this.dtmDate1.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtmDate1.MonthCalendar.BackgroundStyle.Class = "";
            this.dtmDate1.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtmDate1.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtmDate1.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtmDate1.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtmDate1.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtmDate1.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtmDate1.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtmDate1.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtmDate1.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.dtmDate1.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtmDate1.MonthCalendar.DisplayMonth = new System.DateTime(2011, 12, 1, 0, 0, 0, 0);
            this.dtmDate1.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dtmDate1.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtmDate1.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtmDate1.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtmDate1.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtmDate1.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.dtmDate1.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtmDate1.MonthCalendar.TodayButtonVisible = true;
            this.dtmDate1.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dtmDate1.Name = "dtmDate1";
            this.dtmDate1.Size = new System.Drawing.Size(100, 20);
            this.dtmDate1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtmDate1.TabIndex = 11;
            // 
            // lblString1
            // 
            // 
            // 
            // 
            this.lblString1.BackgroundStyle.Class = "";
            this.lblString1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblString1.Location = new System.Drawing.Point(10, 89);
            this.lblString1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblString1.Name = "lblString1";
            this.lblString1.Size = new System.Drawing.Size(95, 18);
            this.lblString1.TabIndex = 6;
            this.lblString1.Text = "String 1";
            // 
            // lblString3
            // 
            // 
            // 
            // 
            this.lblString3.BackgroundStyle.Class = "";
            this.lblString3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblString3.Location = new System.Drawing.Point(224, 89);
            this.lblString3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblString3.Name = "lblString3";
            this.lblString3.Size = new System.Drawing.Size(95, 18);
            this.lblString3.TabIndex = 9;
            this.lblString3.Text = "String 3";
            // 
            // chkBool1
            // 
            // 
            // 
            // 
            this.chkBool1.BackgroundStyle.Class = "";
            this.chkBool1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chkBool1.Enabled = false;
            this.chkBool1.Location = new System.Drawing.Point(9, 135);
            this.chkBool1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkBool1.Name = "chkBool1";
            this.chkBool1.Size = new System.Drawing.Size(82, 19);
            this.chkBool1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.chkBool1.TabIndex = 0;
            this.chkBool1.Text = "Bool 1";
            // 
            // lblDate2
            // 
            // 
            // 
            // 
            this.lblDate2.BackgroundStyle.Class = "";
            this.lblDate2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblDate2.Location = new System.Drawing.Point(116, 42);
            this.lblDate2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblDate2.Name = "lblDate2";
            this.lblDate2.Size = new System.Drawing.Size(95, 18);
            this.lblDate2.TabIndex = 5;
            this.lblDate2.Text = "Date 2";
            // 
            // lblString2
            // 
            // 
            // 
            // 
            this.lblString2.BackgroundStyle.Class = "";
            this.lblString2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblString2.Location = new System.Drawing.Point(117, 89);
            this.lblString2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblString2.Name = "lblString2";
            this.lblString2.Size = new System.Drawing.Size(95, 18);
            this.lblString2.TabIndex = 7;
            this.lblString2.Text = "String 2";
            // 
            // lblDate1
            // 
            // 
            // 
            // 
            this.lblDate1.BackgroundStyle.Class = "";
            this.lblDate1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblDate1.Location = new System.Drawing.Point(9, 40);
            this.lblDate1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblDate1.Name = "lblDate1";
            this.lblDate1.Size = new System.Drawing.Size(95, 18);
            this.lblDate1.TabIndex = 4;
            this.lblDate1.Text = "Date 1";
            // 
            // lblDate3
            // 
            // 
            // 
            // 
            this.lblDate3.BackgroundStyle.Class = "";
            this.lblDate3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblDate3.Location = new System.Drawing.Point(223, 43);
            this.lblDate3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblDate3.Name = "lblDate3";
            this.lblDate3.Size = new System.Drawing.Size(95, 18);
            this.lblDate3.TabIndex = 13;
            this.lblDate3.Text = "Date 3";
            // 
            // dtmDate3
            // 
            // 
            // 
            // 
            this.dtmDate3.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtmDate3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtmDate3.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtmDate3.ButtonDropDown.Visible = true;
            this.dtmDate3.Enabled = false;
            this.dtmDate3.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Center;
            this.dtmDate3.IsPopupCalendarOpen = false;
            this.dtmDate3.Location = new System.Drawing.Point(223, 62);
            this.dtmDate3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            // 
            // 
            // 
            this.dtmDate3.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtmDate3.MonthCalendar.BackgroundStyle.Class = "";
            this.dtmDate3.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtmDate3.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtmDate3.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtmDate3.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtmDate3.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtmDate3.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtmDate3.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtmDate3.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtmDate3.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.dtmDate3.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtmDate3.MonthCalendar.DisplayMonth = new System.DateTime(2011, 12, 1, 0, 0, 0, 0);
            this.dtmDate3.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dtmDate3.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtmDate3.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtmDate3.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtmDate3.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtmDate3.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.dtmDate3.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtmDate3.MonthCalendar.TodayButtonVisible = true;
            this.dtmDate3.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dtmDate3.Name = "dtmDate3";
            this.dtmDate3.Size = new System.Drawing.Size(100, 20);
            this.dtmDate3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtmDate3.TabIndex = 12;
            // 
            // panelEx4
            // 
            this.panelEx4.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx4.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx4.Controls.Add(this.panelEx2);
            this.panelEx4.Controls.Add(this.grdList);
            this.panelEx4.Controls.Add(this.bar1);
            this.panelEx4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx4.Location = new System.Drawing.Point(0, 0);
            this.panelEx4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelEx4.Name = "panelEx4";
            this.panelEx4.Size = new System.Drawing.Size(1039, 207);
            this.panelEx4.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx4.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx4.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx4.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx4.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx4.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx4.Style.GradientAngle = 90;
            this.panelEx4.TabIndex = 18;
            // 
            // panelEx2
            // 
            this.panelEx2.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx2.Location = new System.Drawing.Point(433, 42);
            this.panelEx2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelEx2.Name = "panelEx2";
            this.panelEx2.Size = new System.Drawing.Size(328, 163);
            this.panelEx2.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx2.Style.GradientAngle = 90;
            this.panelEx2.TabIndex = 14;
            // 
            // grdList
            // 
            this.grdList.BackgroundColor = System.Drawing.Color.White;
            this.grdList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdList.DefaultCellStyle = dataGridViewCellStyle1;
            this.grdList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdList.Enabled = false;
            this.grdList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.grdList.Location = new System.Drawing.Point(0, 29);
            this.grdList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grdList.Name = "grdList";
            this.grdList.Size = new System.Drawing.Size(1039, 178);
            this.grdList.TabIndex = 1;
            this.grdList.Visible = false;
            // 
            // bar1
            // 
            this.bar1.AntiAlias = true;
            this.bar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bar1.DockSide = DevComponents.DotNetBar.eDockSide.Document;
            this.bar1.DockTabStripHeight = 15;
            this.bar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem1,
            this.lblList});
            this.bar1.Location = new System.Drawing.Point(0, 0);
            this.bar1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bar1.Name = "bar1";
            this.bar1.Size = new System.Drawing.Size(1039, 29);
            this.bar1.Stretch = true;
            this.bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bar1.TabIndex = 16;
            this.bar1.TabStop = false;
            this.bar1.Text = "bar1";
            // 
            // buttonItem1
            // 
            this.buttonItem1.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem1.Image")));
            this.buttonItem1.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.buttonItem1.Name = "buttonItem1";
            this.buttonItem1.Text = "buttonItem1";
            this.buttonItem1.Tooltip = "Lấy Dữ Liệu";
            // 
            // lblList
            // 
            this.lblList.Name = "lblList";
            // 
            // txtString2
            // 
            this.txtString2.AutoComplete = false;
            this.txtString2.AutoDropdown = false;
            this.txtString2.AutoReSizeColumn = false;
            this.txtString2.BackColorEven = System.Drawing.Color.White;
            this.txtString2.BackColorOdd = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtString2.Border.Class = "TextBoxBorder";
            this.txtString2.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtString2.ColumnHeaders = "";
            this.txtString2.ColumnNames = "";
            this.txtString2.ColumnWidthDefault = 75;
            this.txtString2.ColumnWidths = "";
            this.txtString2.DataSource = null;
            this.txtString2.Language = "Language1";
            this.txtString2.LinkedColumnIndex = 0;
            this.txtString2.LinkedTextBox = null;
            this.txtString2.Location = new System.Drawing.Point(118, 109);
            this.txtString2.Name = "txtString2";
            this.txtString2.RowsDisplay = 10;
            this.txtString2.Size = new System.Drawing.Size(100, 20);
            this.txtString2.TabIndex = 18;
            // 
            // txtString1
            // 
            this.txtString1.AutoComplete = false;
            this.txtString1.AutoDropdown = false;
            this.txtString1.AutoReSizeColumn = false;
            this.txtString1.BackColorEven = System.Drawing.Color.White;
            this.txtString1.BackColorOdd = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtString1.Border.Class = "TextBoxBorder";
            this.txtString1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtString1.ColumnHeaders = "";
            this.txtString1.ColumnNames = "";
            this.txtString1.ColumnWidthDefault = 75;
            this.txtString1.ColumnWidths = "";
            this.txtString1.DataSource = null;
            this.txtString1.Language = "Language1";
            this.txtString1.LinkedColumnIndex = 0;
            this.txtString1.LinkedTextBox = null;
            this.txtString1.Location = new System.Drawing.Point(9, 109);
            this.txtString1.Name = "txtString1";
            this.txtString1.RowsDisplay = 10;
            this.txtString1.Size = new System.Drawing.Size(100, 20);
            this.txtString1.TabIndex = 18;
            // 
            // frmReport
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(1039, 495);
            this.Controls.Add(this.panelEx1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmReport";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmReport_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmReport_FormClosing);
            this.panelEx1.ResumeLayout(false);
            this.pnlFilter.ResumeLayout(false);
            this.panelEx3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtmDate2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtmDate1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtmDate3)).EndInit();
            this.panelEx4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbReportList;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtmDate2;
        private DevComponents.DotNetBar.LabelX lblDate2;
        private DevComponents.DotNetBar.LabelX lblDate1;
        private DevComponents.DotNetBar.LabelX lblString2;
        private DevComponents.DotNetBar.LabelX lblString1;
        private DevComponents.DotNetBar.Controls.CheckBoxX chkBool2;
        private DevComponents.DotNetBar.Controls.CheckBoxX chkBool1;
        private DevComponents.DotNetBar.ButtonX btnView;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtmDate1;
        private DevComponents.DotNetBar.LabelX lblString3;
        private DevComponents.DotNetBar.LabelX lblDate3;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtmDate3;
        private DevComponents.DotNetBar.PanelEx pnlFilter;
        private DevComponents.DotNetBar.ButtonX btnBack;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private DevComponents.DotNetBar.PanelEx panelEx2;
        private DevComponents.DotNetBar.Controls.CheckBoxX chkBool3;
        private DevComponents.DotNetBar.Controls.TextBoxX txtString3;
        private DevComponents.DotNetBar.Controls.DataGridViewX grdList;
        private DevComponents.DotNetBar.PanelEx panelEx4;
        private DevComponents.DotNetBar.PanelEx panelEx3;
        private DevComponents.DotNetBar.Bar bar1;
        private DevComponents.DotNetBar.ButtonItem buttonItem1;
        private DevComponents.DotNetBar.LabelItem lblList;
        private PT.Manager.PTComponent.MultiDropDownTextBox txtString1;
        private PT.Manager.PTComponent.MultiDropDownTextBox txtString2;
    }
}