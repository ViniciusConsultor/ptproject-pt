namespace IN106
{
    partial class IN106
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
            this.txtWeight = new PT.Component.NumericTextBox();
            this.txtVolume = new PT.Component.NumericTextBox();
            this.chkStatus = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.txtPOUnit = new PT.Component.MultiColumnComboBox();
            this.txtVendID = new PT.Component.MultiColumnComboBox();
            this.txtINUnit = new PT.Component.MultiColumnComboBox();
            this.txtSOUnit = new PT.Component.MultiColumnComboBox();
            this.txtDfltWhID = new PT.Component.MultiColumnComboBox();
            this.txtTaxID = new PT.Component.MultiColumnComboBox();
            this.txtToUnit = new PT.Component.MultiColumnComboBox();
            this.txtFromUnit = new PT.Component.MultiColumnComboBox();
            this.txtCnvfact = new PT.Component.MultiDropDownTextBox(this.components);
            this.txtPOToUnitPrice = new PT.Component.NumericTextBox();
            this.txtPOFromUnitPrice = new PT.Component.NumericTextBox();
            this.txtSOToUnitPrice = new PT.Component.NumericTextBox();
            this.txtSOFromUnitPrice = new PT.Component.NumericTextBox();
            this.txtCopy = new PT.Component.MultiDropDownTextBox(this.components);
            this.btnCopy = new DevComponents.DotNetBar.ButtonX();
            this.dtiCrtd_DateTime = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.txtCrtd_User = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtCrtd_Prog = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtClassID1 = new PT.Component.MultiDropDownTextBox(this.components);
            this.txtClassID2 = new PT.Component.MultiDropDownTextBox(this.components);
            this.dtiSOPriEffDate = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.dtiPOPriEffDate = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.txtProductID = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtDesc = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblTaxID = new System.Windows.Forms.Label();
            this.lblStyle = new System.Windows.Forms.Label();
            this.txtStyle = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblWeight = new System.Windows.Forms.Label();
            this.lblVolume = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.txtSize = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblPicture = new System.Windows.Forms.Label();
            this.txtPicture = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblDfltWhID = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.txtColor = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblINUnit = new System.Windows.Forms.Label();
            this.lblSOUnit = new System.Windows.Forms.Label();
            this.lblPOUnit = new System.Windows.Forms.Label();
            this.lblSOPriEffDate = new System.Windows.Forms.Label();
            this.SOToUnitPrice = new System.Windows.Forms.Label();
            this.lblSOFromUnitPrice = new System.Windows.Forms.Label();
            this.lblPOPriEffDate = new System.Windows.Forms.Label();
            this.POToUnitPrice = new System.Windows.Forms.Label();
            this.lblPOFromUnitPrice = new System.Windows.Forms.Label();
            this.lblCnvfact = new System.Windows.Forms.Label();
            this.ToUnit = new System.Windows.Forms.Label();
            this.lblFromUnit = new System.Windows.Forms.Label();
            this.lblVendID = new System.Windows.Forms.Label();
            this.lblClassID1 = new System.Windows.Forms.Label();
            this.lblClassID2 = new System.Windows.Forms.Label();
            this.lblDescr = new System.Windows.Forms.Label();
            this.lblProductID = new System.Windows.Forms.Label();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.txtClassID1Search = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtClassID2Search = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtProductNameSearch = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.cbxVendIdSearch = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).BeginInit();
            this.pnldgv.SuspendLayout();
            this.pnl.SuspendLayout();
            this.pnlhead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.panelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtiCrtd_DateTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtiSOPriEffDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtiPOPriEffDate)).BeginInit();
            this.SuspendLayout();
            // 
            // bar1
            // 
            this.bar1.Size = new System.Drawing.Size(881, 25);
            // 
            // btnAdd
            // 
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnBack
            // 
            this.btnBack.Enabled = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // pnldgv
            // 
            this.pnldgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnldgv.Location = new System.Drawing.Point(0, 0);
            this.pnldgv.Size = new System.Drawing.Size(881, 525);
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
            this.pnl.Controls.Add(this.txtWeight);
            this.pnl.Controls.Add(this.txtVolume);
            this.pnl.Controls.Add(this.chkStatus);
            this.pnl.Controls.Add(this.txtPOUnit);
            this.pnl.Controls.Add(this.txtVendID);
            this.pnl.Controls.Add(this.txtINUnit);
            this.pnl.Controls.Add(this.txtSOUnit);
            this.pnl.Controls.Add(this.txtDfltWhID);
            this.pnl.Controls.Add(this.txtTaxID);
            this.pnl.Controls.Add(this.txtToUnit);
            this.pnl.Controls.Add(this.txtFromUnit);
            this.pnl.Controls.Add(this.txtCnvfact);
            this.pnl.Controls.Add(this.txtPOToUnitPrice);
            this.pnl.Controls.Add(this.txtPOFromUnitPrice);
            this.pnl.Controls.Add(this.txtSOToUnitPrice);
            this.pnl.Controls.Add(this.txtSOFromUnitPrice);
            this.pnl.Controls.Add(this.txtCopy);
            this.pnl.Controls.Add(this.btnCopy);
            this.pnl.Controls.Add(this.dtiCrtd_DateTime);
            this.pnl.Controls.Add(this.txtCrtd_User);
            this.pnl.Controls.Add(this.txtCrtd_Prog);
            this.pnl.Controls.Add(this.txtClassID1);
            this.pnl.Controls.Add(this.txtClassID2);
            this.pnl.Controls.Add(this.dtiSOPriEffDate);
            this.pnl.Controls.Add(this.dtiPOPriEffDate);
            this.pnl.Controls.Add(this.txtProductID);
            this.pnl.Controls.Add(this.txtDesc);
            this.pnl.Controls.Add(this.lblTaxID);
            this.pnl.Controls.Add(this.lblStyle);
            this.pnl.Controls.Add(this.txtStyle);
            this.pnl.Controls.Add(this.lblWeight);
            this.pnl.Controls.Add(this.lblVolume);
            this.pnl.Controls.Add(this.lblSize);
            this.pnl.Controls.Add(this.txtSize);
            this.pnl.Controls.Add(this.lblPicture);
            this.pnl.Controls.Add(this.txtPicture);
            this.pnl.Controls.Add(this.lblDfltWhID);
            this.pnl.Controls.Add(this.lblColor);
            this.pnl.Controls.Add(this.txtColor);
            this.pnl.Controls.Add(this.lblINUnit);
            this.pnl.Controls.Add(this.lblSOUnit);
            this.pnl.Controls.Add(this.lblPOUnit);
            this.pnl.Controls.Add(this.lblSOPriEffDate);
            this.pnl.Controls.Add(this.SOToUnitPrice);
            this.pnl.Controls.Add(this.lblSOFromUnitPrice);
            this.pnl.Controls.Add(this.lblPOPriEffDate);
            this.pnl.Controls.Add(this.POToUnitPrice);
            this.pnl.Controls.Add(this.lblPOFromUnitPrice);
            this.pnl.Controls.Add(this.lblCnvfact);
            this.pnl.Controls.Add(this.ToUnit);
            this.pnl.Controls.Add(this.lblFromUnit);
            this.pnl.Controls.Add(this.lblVendID);
            this.pnl.Controls.Add(this.lblClassID1);
            this.pnl.Controls.Add(this.lblClassID2);
            this.pnl.Controls.Add(this.lblDescr);
            this.pnl.Controls.Add(this.lblProductID);
            this.pnl.Location = new System.Drawing.Point(132, 22);
            this.pnl.Size = new System.Drawing.Size(737, 491);
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
            this.pnlhead.Controls.Add(this.cbxVendIdSearch);
            this.pnlhead.Controls.Add(this.txtProductNameSearch);
            this.pnlhead.Controls.Add(this.txtClassID2Search);
            this.pnlhead.Controls.Add(this.txtClassID1Search);
            this.pnlhead.Controls.Add(this.labelX4);
            this.pnlhead.Controls.Add(this.labelX3);
            this.pnlhead.Controls.Add(this.labelX2);
            this.pnlhead.Controls.Add(this.labelX1);
            this.pnlhead.Size = new System.Drawing.Size(881, 30);
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
            this.dgv.Location = new System.Drawing.Point(0, 30);
            this.dgv.ReadOnly = true;
            this.dgv.Size = new System.Drawing.Size(881, 495);
            this.dgv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellDoubleClick);
            // 
            // panelEx1
            // 
            this.panelEx1.Size = new System.Drawing.Size(881, 525);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            // 
            // buttonItem1
            // 
            this.buttonItem1.Visible = false;
            // 
            // buttonItem2
            // 
            this.buttonItem2.Visible = false;
            // 
            // labelItem6
            // 
            this.labelItem6.Visible = false;
            // 
            // labelItem1
            // 
            this.labelItem1.Visible = false;
            // 
            // txtWeight
            // 
            this.txtWeight.AllowSpace = false;
            // 
            // 
            // 
            this.txtWeight.Border.Class = "TextBoxBorder";
            this.txtWeight.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtWeight.Location = new System.Drawing.Point(343, 336);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(100, 20);
            this.txtWeight.TabIndex = 131;
            this.txtWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtVolume
            // 
            this.txtVolume.AllowSpace = false;
            // 
            // 
            // 
            this.txtVolume.Border.Class = "TextBoxBorder";
            this.txtVolume.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtVolume.Location = new System.Drawing.Point(343, 310);
            this.txtVolume.Name = "txtVolume";
            this.txtVolume.Size = new System.Drawing.Size(100, 20);
            this.txtVolume.TabIndex = 130;
            this.txtVolume.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // chkStatus
            // 
            // 
            // 
            // 
            this.chkStatus.BackgroundStyle.Class = "";
            this.chkStatus.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chkStatus.Location = new System.Drawing.Point(245, 6);
            this.chkStatus.Name = "chkStatus";
            this.chkStatus.Size = new System.Drawing.Size(76, 23);
            this.chkStatus.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.chkStatus.TabIndex = 78;
            this.chkStatus.Text = "Status";
            // 
            // txtPOUnit
            // 
            this.txtPOUnit.AutoComplete = false;
            this.txtPOUnit.AutoDropdown = false;
            this.txtPOUnit.BackColorEven = System.Drawing.Color.White;
            this.txtPOUnit.BackColorOdd = System.Drawing.Color.White;
            this.txtPOUnit.ColumnNames = "";
            this.txtPOUnit.ColumnWidthDefault = 75;
            this.txtPOUnit.ColumnWidths = "";
            this.txtPOUnit.DisplayMember = "Text";
            this.txtPOUnit.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.txtPOUnit.FormattingEnabled = true;
            this.txtPOUnit.ItemHeight = 14;
            this.txtPOUnit.LinkedColumnIndex = 0;
            this.txtPOUnit.LinkedTextBox = null;
            this.txtPOUnit.Location = new System.Drawing.Point(142, 282);
            this.txtPOUnit.Name = "txtPOUnit";
            this.txtPOUnit.Size = new System.Drawing.Size(100, 20);
            this.txtPOUnit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.txtPOUnit.TabIndex = 100;
            // 
            // txtVendID
            // 
            this.txtVendID.AutoComplete = false;
            this.txtVendID.AutoDropdown = false;
            this.txtVendID.BackColorEven = System.Drawing.Color.White;
            this.txtVendID.BackColorOdd = System.Drawing.Color.White;
            this.txtVendID.ColumnNames = "";
            this.txtVendID.ColumnWidthDefault = 75;
            this.txtVendID.ColumnWidths = "";
            this.txtVendID.DisplayMember = "Text";
            this.txtVendID.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.txtVendID.FormattingEnabled = true;
            this.txtVendID.ItemHeight = 14;
            this.txtVendID.LinkedColumnIndex = 0;
            this.txtVendID.LinkedTextBox = null;
            this.txtVendID.Location = new System.Drawing.Point(141, 360);
            this.txtVendID.Name = "txtVendID";
            this.txtVendID.Size = new System.Drawing.Size(100, 20);
            this.txtVendID.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.txtVendID.TabIndex = 104;
            // 
            // txtINUnit
            // 
            this.txtINUnit.AutoComplete = false;
            this.txtINUnit.AutoDropdown = false;
            this.txtINUnit.BackColorEven = System.Drawing.Color.White;
            this.txtINUnit.BackColorOdd = System.Drawing.Color.White;
            this.txtINUnit.ColumnNames = "";
            this.txtINUnit.ColumnWidthDefault = 75;
            this.txtINUnit.ColumnWidths = "";
            this.txtINUnit.DisplayMember = "Text";
            this.txtINUnit.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.txtINUnit.FormattingEnabled = true;
            this.txtINUnit.ItemHeight = 14;
            this.txtINUnit.LinkedColumnIndex = 0;
            this.txtINUnit.LinkedTextBox = null;
            this.txtINUnit.Location = new System.Drawing.Point(142, 334);
            this.txtINUnit.Name = "txtINUnit";
            this.txtINUnit.Size = new System.Drawing.Size(100, 20);
            this.txtINUnit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.txtINUnit.TabIndex = 103;
            // 
            // txtSOUnit
            // 
            this.txtSOUnit.AutoComplete = false;
            this.txtSOUnit.AutoDropdown = false;
            this.txtSOUnit.BackColorEven = System.Drawing.Color.White;
            this.txtSOUnit.BackColorOdd = System.Drawing.Color.White;
            this.txtSOUnit.ColumnNames = "";
            this.txtSOUnit.ColumnWidthDefault = 75;
            this.txtSOUnit.ColumnWidths = "";
            this.txtSOUnit.DisplayMember = "Text";
            this.txtSOUnit.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.txtSOUnit.FormattingEnabled = true;
            this.txtSOUnit.ItemHeight = 14;
            this.txtSOUnit.LinkedColumnIndex = 0;
            this.txtSOUnit.LinkedTextBox = null;
            this.txtSOUnit.Location = new System.Drawing.Point(142, 308);
            this.txtSOUnit.Name = "txtSOUnit";
            this.txtSOUnit.Size = new System.Drawing.Size(100, 20);
            this.txtSOUnit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.txtSOUnit.TabIndex = 101;
            // 
            // txtDfltWhID
            // 
            this.txtDfltWhID.AutoComplete = false;
            this.txtDfltWhID.AutoDropdown = false;
            this.txtDfltWhID.BackColorEven = System.Drawing.Color.White;
            this.txtDfltWhID.BackColorOdd = System.Drawing.Color.White;
            this.txtDfltWhID.ColumnNames = "";
            this.txtDfltWhID.ColumnWidthDefault = 75;
            this.txtDfltWhID.ColumnWidths = "";
            this.txtDfltWhID.DisplayMember = "Text";
            this.txtDfltWhID.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.txtDfltWhID.FormattingEnabled = true;
            this.txtDfltWhID.ItemHeight = 14;
            this.txtDfltWhID.LinkedColumnIndex = 0;
            this.txtDfltWhID.LinkedTextBox = null;
            this.txtDfltWhID.Location = new System.Drawing.Point(141, 230);
            this.txtDfltWhID.Name = "txtDfltWhID";
            this.txtDfltWhID.Size = new System.Drawing.Size(100, 20);
            this.txtDfltWhID.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.txtDfltWhID.TabIndex = 96;
            // 
            // txtTaxID
            // 
            this.txtTaxID.AutoComplete = false;
            this.txtTaxID.AutoDropdown = false;
            this.txtTaxID.BackColorEven = System.Drawing.Color.White;
            this.txtTaxID.BackColorOdd = System.Drawing.Color.White;
            this.txtTaxID.ColumnNames = "";
            this.txtTaxID.ColumnWidthDefault = 75;
            this.txtTaxID.ColumnWidths = "";
            this.txtTaxID.DisplayMember = "Text";
            this.txtTaxID.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.txtTaxID.FormattingEnabled = true;
            this.txtTaxID.ItemHeight = 14;
            this.txtTaxID.LinkedColumnIndex = 0;
            this.txtTaxID.LinkedTextBox = null;
            this.txtTaxID.Location = new System.Drawing.Point(141, 256);
            this.txtTaxID.Name = "txtTaxID";
            this.txtTaxID.Size = new System.Drawing.Size(100, 20);
            this.txtTaxID.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.txtTaxID.TabIndex = 98;
            // 
            // txtToUnit
            // 
            this.txtToUnit.AutoComplete = false;
            this.txtToUnit.AutoDropdown = false;
            this.txtToUnit.BackColorEven = System.Drawing.Color.White;
            this.txtToUnit.BackColorOdd = System.Drawing.Color.White;
            this.txtToUnit.ColumnNames = "";
            this.txtToUnit.ColumnWidthDefault = 75;
            this.txtToUnit.ColumnWidths = "";
            this.txtToUnit.DisplayMember = "Text";
            this.txtToUnit.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.txtToUnit.FormattingEnabled = true;
            this.txtToUnit.ItemHeight = 14;
            this.txtToUnit.LinkedColumnIndex = 0;
            this.txtToUnit.LinkedTextBox = null;
            this.txtToUnit.Location = new System.Drawing.Point(257, 132);
            this.txtToUnit.Name = "txtToUnit";
            this.txtToUnit.Size = new System.Drawing.Size(100, 20);
            this.txtToUnit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.txtToUnit.TabIndex = 86;
            this.txtToUnit.SelectedIndexChanged += new System.EventHandler(this.txtToUnit_SelectedIndexChanged);
            // 
            // txtFromUnit
            // 
            this.txtFromUnit.AutoComplete = false;
            this.txtFromUnit.AutoDropdown = false;
            this.txtFromUnit.BackColorEven = System.Drawing.Color.White;
            this.txtFromUnit.BackColorOdd = System.Drawing.Color.White;
            this.txtFromUnit.ColumnNames = "";
            this.txtFromUnit.ColumnWidthDefault = 75;
            this.txtFromUnit.ColumnWidths = "";
            this.txtFromUnit.DisplayMember = "Text";
            this.txtFromUnit.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.txtFromUnit.FormattingEnabled = true;
            this.txtFromUnit.ItemHeight = 14;
            this.txtFromUnit.LinkedColumnIndex = 0;
            this.txtFromUnit.LinkedTextBox = null;
            this.txtFromUnit.Location = new System.Drawing.Point(141, 132);
            this.txtFromUnit.Name = "txtFromUnit";
            this.txtFromUnit.Size = new System.Drawing.Size(100, 20);
            this.txtFromUnit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.txtFromUnit.TabIndex = 84;
            this.txtFromUnit.SelectedIndexChanged += new System.EventHandler(this.txtFromUnit_SelectedIndexChanged);
            // 
            // txtCnvfact
            // 
            this.txtCnvfact.AutoComplete = false;
            this.txtCnvfact.AutoReSizeColumn = true;
            // 
            // 
            // 
            this.txtCnvfact.Border.Class = "TextBoxBorder";
            this.txtCnvfact.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtCnvfact.ColumnHeaders = "";
            this.txtCnvfact.ColumnNames = "";
            this.txtCnvfact.ColumnWidthDefault = 75;
            this.txtCnvfact.ColumnWidths = "";
            this.txtCnvfact.DataSource = null;
            this.txtCnvfact.Language = "Language1";
            this.txtCnvfact.Location = new System.Drawing.Point(476, 132);
            this.txtCnvfact.Name = "txtCnvfact";
            this.txtCnvfact.RowsDisplay = 10;
            this.txtCnvfact.Size = new System.Drawing.Size(100, 20);
            this.txtCnvfact.TabIndex = 87;
            this.txtCnvfact.Leave += new System.EventHandler(this.txtCnvfact_Leave);
            // 
            // txtPOToUnitPrice
            // 
            this.txtPOToUnitPrice.AllowSpace = false;
            // 
            // 
            // 
            this.txtPOToUnitPrice.Border.Class = "TextBoxBorder";
            this.txtPOToUnitPrice.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtPOToUnitPrice.Location = new System.Drawing.Point(258, 160);
            this.txtPOToUnitPrice.Name = "txtPOToUnitPrice";
            this.txtPOToUnitPrice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPOToUnitPrice.Size = new System.Drawing.Size(100, 20);
            this.txtPOToUnitPrice.TabIndex = 90;
            this.txtPOToUnitPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPOFromUnitPrice
            // 
            this.txtPOFromUnitPrice.AllowSpace = false;
            // 
            // 
            // 
            this.txtPOFromUnitPrice.Border.Class = "TextBoxBorder";
            this.txtPOFromUnitPrice.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtPOFromUnitPrice.Location = new System.Drawing.Point(141, 158);
            this.txtPOFromUnitPrice.Name = "txtPOFromUnitPrice";
            this.txtPOFromUnitPrice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPOFromUnitPrice.Size = new System.Drawing.Size(100, 20);
            this.txtPOFromUnitPrice.TabIndex = 89;
            this.txtPOFromUnitPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPOFromUnitPrice.Leave += new System.EventHandler(this.txtPOFromUnitPrice_Leave);
            // 
            // txtSOToUnitPrice
            // 
            this.txtSOToUnitPrice.AllowSpace = false;
            // 
            // 
            // 
            this.txtSOToUnitPrice.Border.Class = "TextBoxBorder";
            this.txtSOToUnitPrice.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSOToUnitPrice.Location = new System.Drawing.Point(258, 186);
            this.txtSOToUnitPrice.Name = "txtSOToUnitPrice";
            this.txtSOToUnitPrice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtSOToUnitPrice.Size = new System.Drawing.Size(100, 20);
            this.txtSOToUnitPrice.TabIndex = 94;
            this.txtSOToUnitPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtSOFromUnitPrice
            // 
            this.txtSOFromUnitPrice.AllowSpace = false;
            // 
            // 
            // 
            this.txtSOFromUnitPrice.Border.Class = "TextBoxBorder";
            this.txtSOFromUnitPrice.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSOFromUnitPrice.Location = new System.Drawing.Point(141, 184);
            this.txtSOFromUnitPrice.Name = "txtSOFromUnitPrice";
            this.txtSOFromUnitPrice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtSOFromUnitPrice.Size = new System.Drawing.Size(100, 20);
            this.txtSOFromUnitPrice.TabIndex = 92;
            this.txtSOFromUnitPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSOFromUnitPrice.Leave += new System.EventHandler(this.txtSOFromUnitPrice_Leave);
            // 
            // txtCopy
            // 
            this.txtCopy.AutoComplete = false;
            this.txtCopy.AutoReSizeColumn = true;
            // 
            // 
            // 
            this.txtCopy.Border.Class = "TextBoxBorder";
            this.txtCopy.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtCopy.ColumnHeaders = "";
            this.txtCopy.ColumnNames = "";
            this.txtCopy.ColumnWidthDefault = 75;
            this.txtCopy.ColumnWidths = "";
            this.txtCopy.DataSource = null;
            this.txtCopy.Language = "Language1";
            this.txtCopy.Location = new System.Drawing.Point(419, 9);
            this.txtCopy.Name = "txtCopy";
            this.txtCopy.RowsDisplay = 10;
            this.txtCopy.Size = new System.Drawing.Size(100, 20);
            this.txtCopy.TabIndex = 129;
            this.txtCopy.WatermarkText = "ProductID";
            // 
            // btnCopy
            // 
            this.btnCopy.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCopy.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCopy.Location = new System.Drawing.Point(343, 9);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(70, 20);
            this.btnCopy.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCopy.TabIndex = 128;
            this.btnCopy.Text = "Copy From ...";
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // dtiCrtd_DateTime
            // 
            // 
            // 
            // 
            this.dtiCrtd_DateTime.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtiCrtd_DateTime.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtiCrtd_DateTime.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtiCrtd_DateTime.ButtonDropDown.Visible = true;
            this.dtiCrtd_DateTime.IsPopupCalendarOpen = false;
            this.dtiCrtd_DateTime.Location = new System.Drawing.Point(27, 466);
            // 
            // 
            // 
            this.dtiCrtd_DateTime.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtiCrtd_DateTime.MonthCalendar.BackgroundStyle.Class = "";
            this.dtiCrtd_DateTime.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtiCrtd_DateTime.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtiCrtd_DateTime.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtiCrtd_DateTime.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtiCrtd_DateTime.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtiCrtd_DateTime.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtiCrtd_DateTime.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtiCrtd_DateTime.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtiCrtd_DateTime.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.dtiCrtd_DateTime.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtiCrtd_DateTime.MonthCalendar.DisplayMonth = new System.DateTime(2012, 2, 1, 0, 0, 0, 0);
            this.dtiCrtd_DateTime.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dtiCrtd_DateTime.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtiCrtd_DateTime.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtiCrtd_DateTime.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtiCrtd_DateTime.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtiCrtd_DateTime.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.dtiCrtd_DateTime.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtiCrtd_DateTime.MonthCalendar.TodayButtonVisible = true;
            this.dtiCrtd_DateTime.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dtiCrtd_DateTime.Name = "dtiCrtd_DateTime";
            this.dtiCrtd_DateTime.Size = new System.Drawing.Size(20, 20);
            this.dtiCrtd_DateTime.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtiCrtd_DateTime.TabIndex = 127;
            this.dtiCrtd_DateTime.Visible = false;
            // 
            // txtCrtd_User
            // 
            // 
            // 
            // 
            this.txtCrtd_User.Border.Class = "TextBoxBorder";
            this.txtCrtd_User.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtCrtd_User.Location = new System.Drawing.Point(79, 466);
            this.txtCrtd_User.Name = "txtCrtd_User";
            this.txtCrtd_User.Size = new System.Drawing.Size(20, 20);
            this.txtCrtd_User.TabIndex = 126;
            this.txtCrtd_User.Visible = false;
            // 
            // txtCrtd_Prog
            // 
            // 
            // 
            // 
            this.txtCrtd_Prog.Border.Class = "TextBoxBorder";
            this.txtCrtd_Prog.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtCrtd_Prog.Location = new System.Drawing.Point(53, 466);
            this.txtCrtd_Prog.Name = "txtCrtd_Prog";
            this.txtCrtd_Prog.Size = new System.Drawing.Size(20, 20);
            this.txtCrtd_Prog.TabIndex = 125;
            this.txtCrtd_Prog.Visible = false;
            // 
            // txtClassID1
            // 
            this.txtClassID1.AutoComplete = false;
            this.txtClassID1.AutoReSizeColumn = true;
            // 
            // 
            // 
            this.txtClassID1.Border.Class = "TextBoxBorder";
            this.txtClassID1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtClassID1.ColumnHeaders = "";
            this.txtClassID1.ColumnNames = "";
            this.txtClassID1.ColumnWidthDefault = 75;
            this.txtClassID1.ColumnWidths = "";
            this.txtClassID1.DataSource = null;
            this.txtClassID1.Language = "Language1";
            this.txtClassID1.Location = new System.Drawing.Point(140, 106);
            this.txtClassID1.Name = "txtClassID1";
            this.txtClassID1.RowsDisplay = 10;
            this.txtClassID1.Size = new System.Drawing.Size(100, 20);
            this.txtClassID1.TabIndex = 82;
            this.txtClassID1.TextChanged += new System.EventHandler(this.txtClassID1_TextChanged);
            // 
            // txtClassID2
            // 
            this.txtClassID2.AutoComplete = false;
            this.txtClassID2.AutoReSizeColumn = true;
            // 
            // 
            // 
            this.txtClassID2.Border.Class = "TextBoxBorder";
            this.txtClassID2.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtClassID2.ColumnHeaders = "";
            this.txtClassID2.ColumnNames = "";
            this.txtClassID2.ColumnWidthDefault = 75;
            this.txtClassID2.ColumnWidths = "";
            this.txtClassID2.DataSource = null;
            this.txtClassID2.Language = "Language1";
            this.txtClassID2.Location = new System.Drawing.Point(139, 81);
            this.txtClassID2.Name = "txtClassID2";
            this.txtClassID2.RowsDisplay = 10;
            this.txtClassID2.Size = new System.Drawing.Size(100, 20);
            this.txtClassID2.TabIndex = 81;
            this.txtClassID2.TextChanged += new System.EventHandler(this.txtClassID2_TextChanged);
            // 
            // dtiSOPriEffDate
            // 
            // 
            // 
            // 
            this.dtiSOPriEffDate.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtiSOPriEffDate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtiSOPriEffDate.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtiSOPriEffDate.ButtonDropDown.Visible = true;
            this.dtiSOPriEffDate.IsPopupCalendarOpen = false;
            this.dtiSOPriEffDate.Location = new System.Drawing.Point(476, 188);
            // 
            // 
            // 
            this.dtiSOPriEffDate.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtiSOPriEffDate.MonthCalendar.BackgroundStyle.Class = "";
            this.dtiSOPriEffDate.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtiSOPriEffDate.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtiSOPriEffDate.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtiSOPriEffDate.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtiSOPriEffDate.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtiSOPriEffDate.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtiSOPriEffDate.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtiSOPriEffDate.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtiSOPriEffDate.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.dtiSOPriEffDate.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtiSOPriEffDate.MonthCalendar.DisplayMonth = new System.DateTime(2012, 2, 1, 0, 0, 0, 0);
            this.dtiSOPriEffDate.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dtiSOPriEffDate.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtiSOPriEffDate.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtiSOPriEffDate.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtiSOPriEffDate.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtiSOPriEffDate.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.dtiSOPriEffDate.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtiSOPriEffDate.MonthCalendar.TodayButtonVisible = true;
            this.dtiSOPriEffDate.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dtiSOPriEffDate.Name = "dtiSOPriEffDate";
            this.dtiSOPriEffDate.Size = new System.Drawing.Size(100, 20);
            this.dtiSOPriEffDate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtiSOPriEffDate.TabIndex = 95;
            // 
            // dtiPOPriEffDate
            // 
            // 
            // 
            // 
            this.dtiPOPriEffDate.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtiPOPriEffDate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtiPOPriEffDate.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtiPOPriEffDate.ButtonDropDown.Visible = true;
            this.dtiPOPriEffDate.IsPopupCalendarOpen = false;
            this.dtiPOPriEffDate.Location = new System.Drawing.Point(476, 159);
            // 
            // 
            // 
            this.dtiPOPriEffDate.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtiPOPriEffDate.MonthCalendar.BackgroundStyle.Class = "";
            this.dtiPOPriEffDate.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtiPOPriEffDate.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtiPOPriEffDate.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtiPOPriEffDate.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtiPOPriEffDate.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtiPOPriEffDate.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtiPOPriEffDate.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtiPOPriEffDate.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtiPOPriEffDate.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.dtiPOPriEffDate.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtiPOPriEffDate.MonthCalendar.DisplayMonth = new System.DateTime(2012, 2, 1, 0, 0, 0, 0);
            this.dtiPOPriEffDate.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dtiPOPriEffDate.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtiPOPriEffDate.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtiPOPriEffDate.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtiPOPriEffDate.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtiPOPriEffDate.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.dtiPOPriEffDate.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtiPOPriEffDate.MonthCalendar.TodayButtonVisible = true;
            this.dtiPOPriEffDate.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dtiPOPriEffDate.Name = "dtiPOPriEffDate";
            this.dtiPOPriEffDate.Size = new System.Drawing.Size(100, 20);
            this.dtiPOPriEffDate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtiPOPriEffDate.TabIndex = 91;
            // 
            // txtProductID
            // 
            // 
            // 
            // 
            this.txtProductID.Border.Class = "TextBoxBorder";
            this.txtProductID.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtProductID.Location = new System.Drawing.Point(139, 9);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(100, 20);
            this.txtProductID.TabIndex = 76;
            this.txtProductID.TextChanged += new System.EventHandler(this.txtProductID_TextChanged);
            // 
            // txtDesc
            // 
            // 
            // 
            // 
            this.txtDesc.Border.Class = "TextBoxBorder";
            this.txtDesc.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDesc.Location = new System.Drawing.Point(139, 35);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(380, 20);
            this.txtDesc.TabIndex = 80;
            // 
            // lblTaxID
            // 
            this.lblTaxID.Location = new System.Drawing.Point(16, 257);
            this.lblTaxID.Name = "lblTaxID";
            this.lblTaxID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTaxID.Size = new System.Drawing.Size(120, 15);
            this.lblTaxID.TabIndex = 124;
            this.lblTaxID.Text = "TaxID";
            // 
            // lblStyle
            // 
            this.lblStyle.Location = new System.Drawing.Point(262, 364);
            this.lblStyle.Name = "lblStyle";
            this.lblStyle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblStyle.Size = new System.Drawing.Size(80, 15);
            this.lblStyle.TabIndex = 123;
            this.lblStyle.Text = "Style";
            // 
            // txtStyle
            // 
            // 
            // 
            // 
            this.txtStyle.Border.Class = "TextBoxBorder";
            this.txtStyle.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtStyle.Location = new System.Drawing.Point(343, 362);
            this.txtStyle.Name = "txtStyle";
            this.txtStyle.Size = new System.Drawing.Size(100, 20);
            this.txtStyle.TabIndex = 111;
            this.txtStyle.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblWeight
            // 
            this.lblWeight.Location = new System.Drawing.Point(262, 336);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblWeight.Size = new System.Drawing.Size(80, 15);
            this.lblWeight.TabIndex = 122;
            this.lblWeight.Text = "Weight";
            // 
            // lblVolume
            // 
            this.lblVolume.Location = new System.Drawing.Point(262, 310);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblVolume.Size = new System.Drawing.Size(80, 15);
            this.lblVolume.TabIndex = 121;
            this.lblVolume.Tag = "";
            this.lblVolume.Text = "Volume";
            // 
            // lblSize
            // 
            this.lblSize.Location = new System.Drawing.Point(262, 284);
            this.lblSize.Name = "lblSize";
            this.lblSize.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblSize.Size = new System.Drawing.Size(80, 15);
            this.lblSize.TabIndex = 120;
            this.lblSize.Text = "Size";
            // 
            // txtSize
            // 
            // 
            // 
            // 
            this.txtSize.Border.Class = "TextBoxBorder";
            this.txtSize.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSize.Location = new System.Drawing.Point(343, 282);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(100, 20);
            this.txtSize.TabIndex = 109;
            this.txtSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblPicture
            // 
            this.lblPicture.Location = new System.Drawing.Point(262, 256);
            this.lblPicture.Name = "lblPicture";
            this.lblPicture.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblPicture.Size = new System.Drawing.Size(80, 15);
            this.lblPicture.TabIndex = 119;
            this.lblPicture.Text = "Picture";
            // 
            // txtPicture
            // 
            // 
            // 
            // 
            this.txtPicture.Border.Class = "TextBoxBorder";
            this.txtPicture.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtPicture.Location = new System.Drawing.Point(343, 256);
            this.txtPicture.Name = "txtPicture";
            this.txtPicture.Size = new System.Drawing.Size(100, 20);
            this.txtPicture.TabIndex = 107;
            // 
            // lblDfltWhID
            // 
            this.lblDfltWhID.Location = new System.Drawing.Point(16, 234);
            this.lblDfltWhID.Name = "lblDfltWhID";
            this.lblDfltWhID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblDfltWhID.Size = new System.Drawing.Size(120, 15);
            this.lblDfltWhID.TabIndex = 118;
            this.lblDfltWhID.Text = "DfltWhID";
            // 
            // lblColor
            // 
            this.lblColor.Location = new System.Drawing.Point(262, 232);
            this.lblColor.Name = "lblColor";
            this.lblColor.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblColor.Size = new System.Drawing.Size(80, 15);
            this.lblColor.TabIndex = 117;
            this.lblColor.Text = "Color";
            // 
            // txtColor
            // 
            // 
            // 
            // 
            this.txtColor.Border.Class = "TextBoxBorder";
            this.txtColor.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtColor.Location = new System.Drawing.Point(343, 230);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(100, 20);
            this.txtColor.TabIndex = 106;
            // 
            // lblINUnit
            // 
            this.lblINUnit.Location = new System.Drawing.Point(16, 336);
            this.lblINUnit.Name = "lblINUnit";
            this.lblINUnit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblINUnit.Size = new System.Drawing.Size(120, 15);
            this.lblINUnit.TabIndex = 116;
            this.lblINUnit.Text = "INUnit";
            // 
            // lblSOUnit
            // 
            this.lblSOUnit.Location = new System.Drawing.Point(16, 310);
            this.lblSOUnit.Name = "lblSOUnit";
            this.lblSOUnit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblSOUnit.Size = new System.Drawing.Size(120, 15);
            this.lblSOUnit.TabIndex = 115;
            this.lblSOUnit.Text = "SOUnit";
            // 
            // lblPOUnit
            // 
            this.lblPOUnit.Location = new System.Drawing.Point(16, 283);
            this.lblPOUnit.Name = "lblPOUnit";
            this.lblPOUnit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblPOUnit.Size = new System.Drawing.Size(120, 15);
            this.lblPOUnit.TabIndex = 114;
            this.lblPOUnit.Text = "POUnit";
            // 
            // lblSOPriEffDate
            // 
            this.lblSOPriEffDate.Location = new System.Drawing.Point(354, 188);
            this.lblSOPriEffDate.Name = "lblSOPriEffDate";
            this.lblSOPriEffDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblSOPriEffDate.Size = new System.Drawing.Size(120, 15);
            this.lblSOPriEffDate.TabIndex = 113;
            this.lblSOPriEffDate.Text = "SOPriEffDate";
            // 
            // SOToUnitPrice
            // 
            this.SOToUnitPrice.Location = new System.Drawing.Point(136, 188);
            this.SOToUnitPrice.Name = "SOToUnitPrice";
            this.SOToUnitPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.SOToUnitPrice.Size = new System.Drawing.Size(120, 15);
            this.SOToUnitPrice.TabIndex = 112;
            this.SOToUnitPrice.Text = "/";
            // 
            // lblSOFromUnitPrice
            // 
            this.lblSOFromUnitPrice.Location = new System.Drawing.Point(19, 186);
            this.lblSOFromUnitPrice.Name = "lblSOFromUnitPrice";
            this.lblSOFromUnitPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblSOFromUnitPrice.Size = new System.Drawing.Size(120, 15);
            this.lblSOFromUnitPrice.TabIndex = 110;
            this.lblSOFromUnitPrice.Text = "SOFromUnitPrice";
            // 
            // lblPOPriEffDate
            // 
            this.lblPOPriEffDate.Location = new System.Drawing.Point(354, 161);
            this.lblPOPriEffDate.Name = "lblPOPriEffDate";
            this.lblPOPriEffDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblPOPriEffDate.Size = new System.Drawing.Size(120, 15);
            this.lblPOPriEffDate.TabIndex = 108;
            this.lblPOPriEffDate.Text = "POPriEffDate";
            // 
            // POToUnitPrice
            // 
            this.POToUnitPrice.Location = new System.Drawing.Point(136, 162);
            this.POToUnitPrice.Name = "POToUnitPrice";
            this.POToUnitPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.POToUnitPrice.Size = new System.Drawing.Size(120, 15);
            this.POToUnitPrice.TabIndex = 105;
            this.POToUnitPrice.Text = "/";
            // 
            // lblPOFromUnitPrice
            // 
            this.lblPOFromUnitPrice.Location = new System.Drawing.Point(18, 160);
            this.lblPOFromUnitPrice.Name = "lblPOFromUnitPrice";
            this.lblPOFromUnitPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblPOFromUnitPrice.Size = new System.Drawing.Size(120, 15);
            this.lblPOFromUnitPrice.TabIndex = 102;
            this.lblPOFromUnitPrice.Text = "POFromUnitPrice";
            // 
            // lblCnvfact
            // 
            this.lblCnvfact.Location = new System.Drawing.Point(400, 134);
            this.lblCnvfact.Name = "lblCnvfact";
            this.lblCnvfact.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblCnvfact.Size = new System.Drawing.Size(70, 15);
            this.lblCnvfact.TabIndex = 99;
            this.lblCnvfact.Text = "Cnvfact";
            // 
            // ToUnit
            // 
            this.ToUnit.Location = new System.Drawing.Point(186, 134);
            this.ToUnit.Name = "ToUnit";
            this.ToUnit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ToUnit.Size = new System.Drawing.Size(70, 15);
            this.ToUnit.TabIndex = 97;
            this.ToUnit.Text = "/";
            // 
            // lblFromUnit
            // 
            this.lblFromUnit.Location = new System.Drawing.Point(20, 134);
            this.lblFromUnit.Name = "lblFromUnit";
            this.lblFromUnit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblFromUnit.Size = new System.Drawing.Size(120, 15);
            this.lblFromUnit.TabIndex = 93;
            this.lblFromUnit.Text = "FromUnit";
            // 
            // lblVendID
            // 
            this.lblVendID.Location = new System.Drawing.Point(55, 364);
            this.lblVendID.Name = "lblVendID";
            this.lblVendID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblVendID.Size = new System.Drawing.Size(80, 15);
            this.lblVendID.TabIndex = 88;
            this.lblVendID.Text = "VendID";
            // 
            // lblClassID1
            // 
            this.lblClassID1.Location = new System.Drawing.Point(18, 108);
            this.lblClassID1.Name = "lblClassID1";
            this.lblClassID1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblClassID1.Size = new System.Drawing.Size(120, 15);
            this.lblClassID1.TabIndex = 85;
            this.lblClassID1.Text = "ClassID1";
            // 
            // lblClassID2
            // 
            this.lblClassID2.Location = new System.Drawing.Point(17, 83);
            this.lblClassID2.Name = "lblClassID2";
            this.lblClassID2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblClassID2.Size = new System.Drawing.Size(120, 15);
            this.lblClassID2.TabIndex = 83;
            this.lblClassID2.Text = "ClassID2";
            // 
            // lblDescr
            // 
            this.lblDescr.Location = new System.Drawing.Point(14, 37);
            this.lblDescr.Name = "lblDescr";
            this.lblDescr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblDescr.Size = new System.Drawing.Size(120, 15);
            this.lblDescr.TabIndex = 79;
            this.lblDescr.Text = "Descr";
            // 
            // lblProductID
            // 
            this.lblProductID.Location = new System.Drawing.Point(17, 11);
            this.lblProductID.Name = "lblProductID";
            this.lblProductID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblProductID.Size = new System.Drawing.Size(120, 15);
            this.lblProductID.TabIndex = 77;
            this.lblProductID.Text = "ProductID";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(12, 6);
            this.labelX1.Name = "labelX1";
            this.labelX1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX1.Size = new System.Drawing.Size(75, 23);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "VendID";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.Class = "";
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(244, 6);
            this.labelX2.Name = "labelX2";
            this.labelX2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX2.Size = new System.Drawing.Size(75, 23);
            this.labelX2.TabIndex = 1;
            this.labelX2.Text = "ClassID1";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.Class = "";
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(451, 5);
            this.labelX3.Name = "labelX3";
            this.labelX3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX3.Size = new System.Drawing.Size(75, 23);
            this.labelX3.TabIndex = 2;
            this.labelX3.Text = "ClassID2";
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.Class = "";
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(663, 5);
            this.labelX4.Name = "labelX4";
            this.labelX4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX4.Size = new System.Drawing.Size(75, 23);
            this.labelX4.TabIndex = 3;
            this.labelX4.Text = "ProductName";
            // 
            // txtClassID1Search
            // 
            // 
            // 
            // 
            this.txtClassID1Search.Border.Class = "TextBoxBorder";
            this.txtClassID1Search.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtClassID1Search.Location = new System.Drawing.Point(326, 5);
            this.txtClassID1Search.Name = "txtClassID1Search";
            this.txtClassID1Search.Size = new System.Drawing.Size(100, 20);
            this.txtClassID1Search.TabIndex = 5;
            this.txtClassID1Search.TextChanged += new System.EventHandler(this.txtClassID1Search_TextChanged);
            // 
            // txtClassID2Search
            // 
            // 
            // 
            // 
            this.txtClassID2Search.Border.Class = "TextBoxBorder";
            this.txtClassID2Search.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtClassID2Search.Location = new System.Drawing.Point(532, 5);
            this.txtClassID2Search.Name = "txtClassID2Search";
            this.txtClassID2Search.Size = new System.Drawing.Size(100, 20);
            this.txtClassID2Search.TabIndex = 6;
            this.txtClassID2Search.TextChanged += new System.EventHandler(this.txtClassID2Search_TextChanged);
            // 
            // txtProductNameSearch
            // 
            // 
            // 
            // 
            this.txtProductNameSearch.Border.Class = "TextBoxBorder";
            this.txtProductNameSearch.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtProductNameSearch.Location = new System.Drawing.Point(744, 6);
            this.txtProductNameSearch.Name = "txtProductNameSearch";
            this.txtProductNameSearch.Size = new System.Drawing.Size(100, 20);
            this.txtProductNameSearch.TabIndex = 7;
            this.txtProductNameSearch.TextChanged += new System.EventHandler(this.txtProductNameSearch_TextChanged);
            // 
            // cbxVendIdSearch
            // 
            this.cbxVendIdSearch.DisplayMember = "Text";
            this.cbxVendIdSearch.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxVendIdSearch.FormattingEnabled = true;
            this.cbxVendIdSearch.ItemHeight = 14;
            this.cbxVendIdSearch.Location = new System.Drawing.Point(94, 4);
            this.cbxVendIdSearch.Name = "cbxVendIdSearch";
            this.cbxVendIdSearch.Size = new System.Drawing.Size(121, 20);
            this.cbxVendIdSearch.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbxVendIdSearch.TabIndex = 8;
            this.cbxVendIdSearch.SelectedValueChanged += new System.EventHandler(this.cbxVendIdSearch_SelectedValueChanged);
            // 
            // IN1061
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 550);
            this.DoubleBuffered = true;
            this.Name = "IN1061";
            this.Text = "IN1061";
            this.Load += new System.EventHandler(this.IN1061_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).EndInit();
            this.pnldgv.ResumeLayout(false);
            this.pnl.ResumeLayout(false);
            this.pnlhead.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.panelEx1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtiCrtd_DateTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtiSOPriEffDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtiPOPriEffDate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PT.Component.NumericTextBox txtWeight;
        private PT.Component.NumericTextBox txtVolume;
        private DevComponents.DotNetBar.Controls.CheckBoxX chkStatus;
        private PT.Component.MultiColumnComboBox txtPOUnit;
        private PT.Component.MultiColumnComboBox txtVendID;
        private PT.Component.MultiColumnComboBox txtINUnit;
        private PT.Component.MultiColumnComboBox txtSOUnit;
        private PT.Component.MultiColumnComboBox txtDfltWhID;
        private PT.Component.MultiColumnComboBox txtTaxID;
        private PT.Component.MultiColumnComboBox txtToUnit;
        private PT.Component.MultiColumnComboBox txtFromUnit;
        private PT.Component.MultiDropDownTextBox txtCnvfact;
        private PT.Component.NumericTextBox txtPOToUnitPrice;
        private PT.Component.NumericTextBox txtPOFromUnitPrice;
        private PT.Component.NumericTextBox txtSOToUnitPrice;
        private PT.Component.NumericTextBox txtSOFromUnitPrice;
        private PT.Component.MultiDropDownTextBox txtCopy;
        private DevComponents.DotNetBar.ButtonX btnCopy;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtiCrtd_DateTime;
        public DevComponents.DotNetBar.Controls.TextBoxX txtCrtd_User;
        public DevComponents.DotNetBar.Controls.TextBoxX txtCrtd_Prog;
        private PT.Component.MultiDropDownTextBox txtClassID1;
        private PT.Component.MultiDropDownTextBox txtClassID2;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtiSOPriEffDate;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtiPOPriEffDate;
        public DevComponents.DotNetBar.Controls.TextBoxX txtProductID;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDesc;
        private System.Windows.Forms.Label lblTaxID;
        private System.Windows.Forms.Label lblStyle;
        private DevComponents.DotNetBar.Controls.TextBoxX txtStyle;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label lblVolume;
        private System.Windows.Forms.Label lblSize;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSize;
        private System.Windows.Forms.Label lblPicture;
        private DevComponents.DotNetBar.Controls.TextBoxX txtPicture;
        private System.Windows.Forms.Label lblDfltWhID;
        private System.Windows.Forms.Label lblColor;
        private DevComponents.DotNetBar.Controls.TextBoxX txtColor;
        private System.Windows.Forms.Label lblINUnit;
        private System.Windows.Forms.Label lblSOUnit;
        private System.Windows.Forms.Label lblPOUnit;
        private System.Windows.Forms.Label lblSOPriEffDate;
        private System.Windows.Forms.Label SOToUnitPrice;
        private System.Windows.Forms.Label lblSOFromUnitPrice;
        private System.Windows.Forms.Label lblPOPriEffDate;
        private System.Windows.Forms.Label POToUnitPrice;
        private System.Windows.Forms.Label lblPOFromUnitPrice;
        private System.Windows.Forms.Label lblCnvfact;
        private System.Windows.Forms.Label ToUnit;
        private System.Windows.Forms.Label lblFromUnit;
        private System.Windows.Forms.Label lblVendID;
        private System.Windows.Forms.Label lblClassID1;
        private System.Windows.Forms.Label lblClassID2;
        private System.Windows.Forms.Label lblDescr;
        private System.Windows.Forms.Label lblProductID;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtProductNameSearch;
        private DevComponents.DotNetBar.Controls.TextBoxX txtClassID2Search;
        private DevComponents.DotNetBar.Controls.TextBoxX txtClassID1Search;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbxVendIdSearch;
    }
}