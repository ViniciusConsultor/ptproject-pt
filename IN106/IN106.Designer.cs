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
            this.lblProductID = new System.Windows.Forms.Label();
            this.lblDescr = new System.Windows.Forms.Label();
            this.lblClassID2 = new System.Windows.Forms.Label();
            this.lblClassID1 = new System.Windows.Forms.Label();
            this.lblVendID = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblFromUnit = new System.Windows.Forms.Label();
            this.lblToUnit = new System.Windows.Forms.Label();
            this.lblCnvfact = new System.Windows.Forms.Label();
            this.lblPOFromUnitPrice = new System.Windows.Forms.Label();
            this.lblPOToUnitPrice = new System.Windows.Forms.Label();
            this.lblPOPriEffDate = new System.Windows.Forms.Label();
            this.lblSOFromUnitPrice = new System.Windows.Forms.Label();
            this.lblSOToUnitPrice = new System.Windows.Forms.Label();
            this.lblSOPriEffDate = new System.Windows.Forms.Label();
            this.lblPOUnit = new System.Windows.Forms.Label();
            this.lblSOUnit = new System.Windows.Forms.Label();
            this.lblINUnit = new System.Windows.Forms.Label();
            this.txtColor = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblDfltWhID = new System.Windows.Forms.Label();
            this.txtPicture = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblPicture = new System.Windows.Forms.Label();
            this.txtSize = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblSize = new System.Windows.Forms.Label();
            this.txtVolume = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblVolume = new System.Windows.Forms.Label();
            this.txtWeight = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblWeight = new System.Windows.Forms.Label();
            this.txtStyle = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblStyle = new System.Windows.Forms.Label();
            this.lblTaxID = new System.Windows.Forms.Label();
            this.txtDesc = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtProductID = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.cbxStatus = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem1 = new DevComponents.Editors.ComboItem();
            this.comboItem3 = new DevComponents.Editors.ComboItem();
            this.dtiPOPriEffDate = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.dtiSOPriEffDate = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.txtClassID2 = new PT.Component.MultiDropDownTextBox(this.components);
            this.txtClassID1 = new PT.Component.MultiDropDownTextBox(this.components);
            this.txtCrtd_Prog = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtCrtd_User = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.dtiCrtd_DateTime = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.btnCopy = new DevComponents.DotNetBar.ButtonX();
            this.txtCopy = new PT.Component.MultiDropDownTextBox(this.components);
            this.txtSOFromUnitPrice = new PT.Component.NumericTextBox();
            this.txtSOToUnitPrice = new PT.Component.NumericTextBox();
            this.txtPOFromUnitPrice = new PT.Component.NumericTextBox();
            this.txtPOToUnitPrice = new PT.Component.NumericTextBox();
            this.txtCnvfact = new PT.Component.MultiDropDownTextBox(this.components);
            this.txtFromUnit = new PT.Component.MultiColumnComboBox();
            this.txtToUnit = new PT.Component.MultiColumnComboBox();
            this.txtTaxID = new PT.Component.MultiColumnComboBox();
            this.txtDfltWhID = new PT.Component.MultiColumnComboBox();
            this.txtSOUnit = new PT.Component.MultiColumnComboBox();
            this.txtINUnit = new PT.Component.MultiColumnComboBox();
            this.txtVendID = new PT.Component.MultiColumnComboBox();
            this.txtPOUnit = new PT.Component.MultiColumnComboBox();
            this.chkStatus = new DevComponents.DotNetBar.Controls.CheckBoxX();
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).BeginInit();
            this.pnl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtiPOPriEffDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtiSOPriEffDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtiCrtd_DateTime)).BeginInit();
            this.SuspendLayout();
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
            // pnl1
            // 
            this.pnl1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.pnl1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.pnl1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.pnl1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.pnl1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnl1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnl1.Style.GradientAngle = 90;
            // 
            // dgv
            // 
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dgv.Location = new System.Drawing.Point(0, 0);
            this.dgv.ReadOnly = false;
            this.dgv.Size = new System.Drawing.Size(784, 521);
            this.dgv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellDoubleClick);
            // 
            // pnl
            // 
            this.pnl.AutoSize = true;
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
            this.pnl.Controls.Add(this.cbxStatus);
            this.pnl.Controls.Add(this.txtProductID);
            this.pnl.Controls.Add(this.txtDesc);
            this.pnl.Controls.Add(this.lblTaxID);
            this.pnl.Controls.Add(this.lblStyle);
            this.pnl.Controls.Add(this.txtStyle);
            this.pnl.Controls.Add(this.lblWeight);
            this.pnl.Controls.Add(this.txtWeight);
            this.pnl.Controls.Add(this.lblVolume);
            this.pnl.Controls.Add(this.txtVolume);
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
            this.pnl.Controls.Add(this.lblSOToUnitPrice);
            this.pnl.Controls.Add(this.lblSOFromUnitPrice);
            this.pnl.Controls.Add(this.lblPOPriEffDate);
            this.pnl.Controls.Add(this.lblPOToUnitPrice);
            this.pnl.Controls.Add(this.lblPOFromUnitPrice);
            this.pnl.Controls.Add(this.lblCnvfact);
            this.pnl.Controls.Add(this.lblToUnit);
            this.pnl.Controls.Add(this.lblFromUnit);
            this.pnl.Controls.Add(this.lblStatus);
            this.pnl.Controls.Add(this.lblVendID);
            this.pnl.Controls.Add(this.lblClassID1);
            this.pnl.Controls.Add(this.lblClassID2);
            this.pnl.Controls.Add(this.lblDescr);
            this.pnl.Controls.Add(this.lblProductID);
            this.pnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl.Location = new System.Drawing.Point(0, 0);
            this.pnl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pnl.Size = new System.Drawing.Size(784, 521);
            this.pnl.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.pnl.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.pnl.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.pnl.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.pnl.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnl.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnl.Style.GradientAngle = 90;
            // 
            // lblProductID
            // 
            this.lblProductID.Location = new System.Drawing.Point(2, 37);
            this.lblProductID.Name = "lblProductID";
            this.lblProductID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblProductID.Size = new System.Drawing.Size(120, 15);
            this.lblProductID.TabIndex = 1;
            this.lblProductID.Text = "ProductID";
            // 
            // lblDescr
            // 
            this.lblDescr.Location = new System.Drawing.Point(-1, 63);
            this.lblDescr.Name = "lblDescr";
            this.lblDescr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblDescr.Size = new System.Drawing.Size(120, 15);
            this.lblDescr.TabIndex = 3;
            this.lblDescr.Text = "Descr";
            // 
            // lblClassID2
            // 
            this.lblClassID2.Location = new System.Drawing.Point(2, 109);
            this.lblClassID2.Name = "lblClassID2";
            this.lblClassID2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblClassID2.Size = new System.Drawing.Size(120, 15);
            this.lblClassID2.TabIndex = 5;
            this.lblClassID2.Text = "ClassID2";
            // 
            // lblClassID1
            // 
            this.lblClassID1.Location = new System.Drawing.Point(3, 134);
            this.lblClassID1.Name = "lblClassID1";
            this.lblClassID1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblClassID1.Size = new System.Drawing.Size(120, 15);
            this.lblClassID1.TabIndex = 7;
            this.lblClassID1.Text = "ClassID1";
            // 
            // lblVendID
            // 
            this.lblVendID.Location = new System.Drawing.Point(1, 390);
            this.lblVendID.Name = "lblVendID";
            this.lblVendID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblVendID.Size = new System.Drawing.Size(120, 15);
            this.lblVendID.TabIndex = 9;
            this.lblVendID.Text = "VendID";
            // 
            // lblStatus
            // 
            this.lblStatus.Location = new System.Drawing.Point(229, 8);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblStatus.Size = new System.Drawing.Size(70, 15);
            this.lblStatus.TabIndex = 11;
            this.lblStatus.Text = "Status";
            // 
            // lblFromUnit
            // 
            this.lblFromUnit.Location = new System.Drawing.Point(5, 160);
            this.lblFromUnit.Name = "lblFromUnit";
            this.lblFromUnit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblFromUnit.Size = new System.Drawing.Size(120, 15);
            this.lblFromUnit.TabIndex = 13;
            this.lblFromUnit.Text = "FromUnit";
            // 
            // lblToUnit
            // 
            this.lblToUnit.Location = new System.Drawing.Point(257, 160);
            this.lblToUnit.Name = "lblToUnit";
            this.lblToUnit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblToUnit.Size = new System.Drawing.Size(70, 15);
            this.lblToUnit.TabIndex = 15;
            this.lblToUnit.Text = "ToUnit";
            // 
            // lblCnvfact
            // 
            this.lblCnvfact.Location = new System.Drawing.Point(447, 160);
            this.lblCnvfact.Name = "lblCnvfact";
            this.lblCnvfact.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblCnvfact.Size = new System.Drawing.Size(70, 15);
            this.lblCnvfact.TabIndex = 17;
            this.lblCnvfact.Text = "Cnvfact";
            // 
            // lblPOFromUnitPrice
            // 
            this.lblPOFromUnitPrice.Location = new System.Drawing.Point(3, 186);
            this.lblPOFromUnitPrice.Name = "lblPOFromUnitPrice";
            this.lblPOFromUnitPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblPOFromUnitPrice.Size = new System.Drawing.Size(120, 15);
            this.lblPOFromUnitPrice.TabIndex = 19;
            this.lblPOFromUnitPrice.Text = "POFromUnitPrice";
            // 
            // lblPOToUnitPrice
            // 
            this.lblPOToUnitPrice.Location = new System.Drawing.Point(207, 188);
            this.lblPOToUnitPrice.Name = "lblPOToUnitPrice";
            this.lblPOToUnitPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblPOToUnitPrice.Size = new System.Drawing.Size(120, 15);
            this.lblPOToUnitPrice.TabIndex = 21;
            this.lblPOToUnitPrice.Text = "POToUnitPrice";
            // 
            // lblPOPriEffDate
            // 
            this.lblPOPriEffDate.Location = new System.Drawing.Point(401, 187);
            this.lblPOPriEffDate.Name = "lblPOPriEffDate";
            this.lblPOPriEffDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblPOPriEffDate.Size = new System.Drawing.Size(120, 15);
            this.lblPOPriEffDate.TabIndex = 23;
            this.lblPOPriEffDate.Text = "POPriEffDate";
            // 
            // lblSOFromUnitPrice
            // 
            this.lblSOFromUnitPrice.Location = new System.Drawing.Point(4, 212);
            this.lblSOFromUnitPrice.Name = "lblSOFromUnitPrice";
            this.lblSOFromUnitPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblSOFromUnitPrice.Size = new System.Drawing.Size(120, 15);
            this.lblSOFromUnitPrice.TabIndex = 25;
            this.lblSOFromUnitPrice.Text = "SOFromUnitPrice";
            // 
            // lblSOToUnitPrice
            // 
            this.lblSOToUnitPrice.Location = new System.Drawing.Point(207, 214);
            this.lblSOToUnitPrice.Name = "lblSOToUnitPrice";
            this.lblSOToUnitPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblSOToUnitPrice.Size = new System.Drawing.Size(120, 15);
            this.lblSOToUnitPrice.TabIndex = 27;
            this.lblSOToUnitPrice.Text = "SOToUnitPrice";
            // 
            // lblSOPriEffDate
            // 
            this.lblSOPriEffDate.Location = new System.Drawing.Point(401, 214);
            this.lblSOPriEffDate.Name = "lblSOPriEffDate";
            this.lblSOPriEffDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblSOPriEffDate.Size = new System.Drawing.Size(120, 15);
            this.lblSOPriEffDate.TabIndex = 29;
            this.lblSOPriEffDate.Text = "SOPriEffDate";
            // 
            // lblPOUnit
            // 
            this.lblPOUnit.Location = new System.Drawing.Point(1, 309);
            this.lblPOUnit.Name = "lblPOUnit";
            this.lblPOUnit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblPOUnit.Size = new System.Drawing.Size(120, 15);
            this.lblPOUnit.TabIndex = 31;
            this.lblPOUnit.Text = "POUnit";
            // 
            // lblSOUnit
            // 
            this.lblSOUnit.Location = new System.Drawing.Point(1, 336);
            this.lblSOUnit.Name = "lblSOUnit";
            this.lblSOUnit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblSOUnit.Size = new System.Drawing.Size(120, 15);
            this.lblSOUnit.TabIndex = 33;
            this.lblSOUnit.Text = "SOUnit";
            // 
            // lblINUnit
            // 
            this.lblINUnit.Location = new System.Drawing.Point(1, 362);
            this.lblINUnit.Name = "lblINUnit";
            this.lblINUnit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblINUnit.Size = new System.Drawing.Size(120, 15);
            this.lblINUnit.TabIndex = 35;
            this.lblINUnit.Text = "INUnit";
            // 
            // txtColor
            // 
            // 
            // 
            // 
            this.txtColor.Border.Class = "TextBoxBorder";
            this.txtColor.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtColor.Location = new System.Drawing.Point(328, 256);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(100, 20);
            this.txtColor.TabIndex = 36;
            // 
            // lblColor
            // 
            this.lblColor.Location = new System.Drawing.Point(247, 258);
            this.lblColor.Name = "lblColor";
            this.lblColor.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblColor.Size = new System.Drawing.Size(80, 15);
            this.lblColor.TabIndex = 37;
            this.lblColor.Text = "Color";
            // 
            // lblDfltWhID
            // 
            this.lblDfltWhID.Location = new System.Drawing.Point(1, 260);
            this.lblDfltWhID.Name = "lblDfltWhID";
            this.lblDfltWhID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblDfltWhID.Size = new System.Drawing.Size(120, 15);
            this.lblDfltWhID.TabIndex = 39;
            this.lblDfltWhID.Text = "DfltWhID";
            // 
            // txtPicture
            // 
            // 
            // 
            // 
            this.txtPicture.Border.Class = "TextBoxBorder";
            this.txtPicture.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtPicture.Location = new System.Drawing.Point(328, 282);
            this.txtPicture.Name = "txtPicture";
            this.txtPicture.Size = new System.Drawing.Size(100, 20);
            this.txtPicture.TabIndex = 40;
            // 
            // lblPicture
            // 
            this.lblPicture.Location = new System.Drawing.Point(247, 282);
            this.lblPicture.Name = "lblPicture";
            this.lblPicture.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblPicture.Size = new System.Drawing.Size(80, 15);
            this.lblPicture.TabIndex = 41;
            this.lblPicture.Text = "Picture";
            // 
            // txtSize
            // 
            // 
            // 
            // 
            this.txtSize.Border.Class = "TextBoxBorder";
            this.txtSize.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSize.Location = new System.Drawing.Point(328, 308);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(100, 20);
            this.txtSize.TabIndex = 42;
            // 
            // lblSize
            // 
            this.lblSize.Location = new System.Drawing.Point(247, 310);
            this.lblSize.Name = "lblSize";
            this.lblSize.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblSize.Size = new System.Drawing.Size(80, 15);
            this.lblSize.TabIndex = 43;
            this.lblSize.Text = "Size";
            // 
            // txtVolume
            // 
            // 
            // 
            // 
            this.txtVolume.Border.Class = "TextBoxBorder";
            this.txtVolume.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtVolume.Location = new System.Drawing.Point(328, 334);
            this.txtVolume.Name = "txtVolume";
            this.txtVolume.Size = new System.Drawing.Size(100, 20);
            this.txtVolume.TabIndex = 44;
            // 
            // lblVolume
            // 
            this.lblVolume.Location = new System.Drawing.Point(247, 336);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblVolume.Size = new System.Drawing.Size(80, 15);
            this.lblVolume.TabIndex = 45;
            this.lblVolume.Tag = "";
            this.lblVolume.Text = "Volume";
            // 
            // txtWeight
            // 
            // 
            // 
            // 
            this.txtWeight.Border.Class = "TextBoxBorder";
            this.txtWeight.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtWeight.Location = new System.Drawing.Point(328, 360);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(100, 20);
            this.txtWeight.TabIndex = 46;
            // 
            // lblWeight
            // 
            this.lblWeight.Location = new System.Drawing.Point(247, 362);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblWeight.Size = new System.Drawing.Size(80, 15);
            this.lblWeight.TabIndex = 47;
            this.lblWeight.Text = "Weight";
            // 
            // txtStyle
            // 
            // 
            // 
            // 
            this.txtStyle.Border.Class = "TextBoxBorder";
            this.txtStyle.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtStyle.Location = new System.Drawing.Point(328, 386);
            this.txtStyle.Name = "txtStyle";
            this.txtStyle.Size = new System.Drawing.Size(100, 20);
            this.txtStyle.TabIndex = 48;
            // 
            // lblStyle
            // 
            this.lblStyle.Location = new System.Drawing.Point(247, 388);
            this.lblStyle.Name = "lblStyle";
            this.lblStyle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblStyle.Size = new System.Drawing.Size(80, 15);
            this.lblStyle.TabIndex = 49;
            this.lblStyle.Text = "Style";
            // 
            // lblTaxID
            // 
            this.lblTaxID.Location = new System.Drawing.Point(1, 283);
            this.lblTaxID.Name = "lblTaxID";
            this.lblTaxID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTaxID.Size = new System.Drawing.Size(120, 15);
            this.lblTaxID.TabIndex = 51;
            this.lblTaxID.Text = "TaxID";
            // 
            // txtDesc
            // 
            // 
            // 
            // 
            this.txtDesc.Border.Class = "TextBoxBorder";
            this.txtDesc.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDesc.Location = new System.Drawing.Point(124, 61);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(380, 20);
            this.txtDesc.TabIndex = 2;
            // 
            // txtProductID
            // 
            // 
            // 
            // 
            this.txtProductID.Border.Class = "TextBoxBorder";
            this.txtProductID.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtProductID.Location = new System.Drawing.Point(124, 35);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(100, 20);
            this.txtProductID.TabIndex = 1;
            // 
            // cbxStatus
            // 
            this.cbxStatus.DisplayMember = "Text";
            this.cbxStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxStatus.FormattingEnabled = true;
            this.cbxStatus.ItemHeight = 14;
            this.cbxStatus.Items.AddRange(new object[] {
            this.comboItem1,
            this.comboItem3});
            this.cbxStatus.Location = new System.Drawing.Point(305, 3);
            this.cbxStatus.Name = "cbxStatus";
            this.cbxStatus.Size = new System.Drawing.Size(100, 20);
            this.cbxStatus.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbxStatus.TabIndex = 52;
            // 
            // comboItem1
            // 
            this.comboItem1.Text = "1";
            // 
            // comboItem3
            // 
            this.comboItem3.Text = "0";
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
            this.dtiPOPriEffDate.Location = new System.Drawing.Point(523, 185);
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
            this.dtiPOPriEffDate.TabIndex = 53;
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
            this.dtiSOPriEffDate.Location = new System.Drawing.Point(523, 214);
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
            this.dtiSOPriEffDate.TabIndex = 54;
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
            this.txtClassID2.Location = new System.Drawing.Point(124, 107);
            this.txtClassID2.Name = "txtClassID2";
            this.txtClassID2.RowsDisplay = 10;
            this.txtClassID2.Size = new System.Drawing.Size(100, 20);
            this.txtClassID2.TabIndex = 3;
            this.txtClassID2.TextChanged += new System.EventHandler(this.txtClassID2_TextChanged);
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
            this.txtClassID1.Location = new System.Drawing.Point(125, 132);
            this.txtClassID1.Name = "txtClassID1";
            this.txtClassID1.RowsDisplay = 10;
            this.txtClassID1.Size = new System.Drawing.Size(100, 20);
            this.txtClassID1.TabIndex = 4;
            this.txtClassID1.TextChanged += new System.EventHandler(this.txtClassID1_TextChanged);
            // 
            // txtCrtd_Prog
            // 
            // 
            // 
            // 
            this.txtCrtd_Prog.Border.Class = "TextBoxBorder";
            this.txtCrtd_Prog.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtCrtd_Prog.Location = new System.Drawing.Point(38, 492);
            this.txtCrtd_Prog.Name = "txtCrtd_Prog";
            this.txtCrtd_Prog.Size = new System.Drawing.Size(20, 20);
            this.txtCrtd_Prog.TabIndex = 65;
            this.txtCrtd_Prog.Visible = false;
            // 
            // txtCrtd_User
            // 
            // 
            // 
            // 
            this.txtCrtd_User.Border.Class = "TextBoxBorder";
            this.txtCrtd_User.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtCrtd_User.Location = new System.Drawing.Point(64, 492);
            this.txtCrtd_User.Name = "txtCrtd_User";
            this.txtCrtd_User.Size = new System.Drawing.Size(20, 20);
            this.txtCrtd_User.TabIndex = 66;
            this.txtCrtd_User.Visible = false;
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
            this.dtiCrtd_DateTime.Location = new System.Drawing.Point(12, 492);
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
            this.dtiCrtd_DateTime.TabIndex = 70;
            this.dtiCrtd_DateTime.Visible = false;
            // 
            // btnCopy
            // 
            this.btnCopy.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCopy.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCopy.Location = new System.Drawing.Point(328, 35);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(70, 20);
            this.btnCopy.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCopy.TabIndex = 72;
            this.btnCopy.Text = "Copy From ...";
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
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
            this.txtCopy.Location = new System.Drawing.Point(404, 35);
            this.txtCopy.Name = "txtCopy";
            this.txtCopy.RowsDisplay = 10;
            this.txtCopy.Size = new System.Drawing.Size(100, 20);
            this.txtCopy.TabIndex = 73;
            this.txtCopy.WatermarkText = "ProductID";
            // 
            // txtSOFromUnitPrice
            // 
            this.txtSOFromUnitPrice.AllowSpace = false;
            // 
            // 
            // 
            this.txtSOFromUnitPrice.Border.Class = "TextBoxBorder";
            this.txtSOFromUnitPrice.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSOFromUnitPrice.Location = new System.Drawing.Point(126, 210);
            this.txtSOFromUnitPrice.Name = "txtSOFromUnitPrice";
            this.txtSOFromUnitPrice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtSOFromUnitPrice.Size = new System.Drawing.Size(100, 20);
            this.txtSOFromUnitPrice.TabIndex = 74;
            this.txtSOFromUnitPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtSOToUnitPrice
            // 
            this.txtSOToUnitPrice.AllowSpace = false;
            // 
            // 
            // 
            this.txtSOToUnitPrice.Border.Class = "TextBoxBorder";
            this.txtSOToUnitPrice.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSOToUnitPrice.Location = new System.Drawing.Point(329, 212);
            this.txtSOToUnitPrice.Name = "txtSOToUnitPrice";
            this.txtSOToUnitPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSOToUnitPrice.Size = new System.Drawing.Size(100, 20);
            this.txtSOToUnitPrice.TabIndex = 75;
            this.txtSOToUnitPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPOFromUnitPrice
            // 
            this.txtPOFromUnitPrice.AllowSpace = false;
            // 
            // 
            // 
            this.txtPOFromUnitPrice.Border.Class = "TextBoxBorder";
            this.txtPOFromUnitPrice.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtPOFromUnitPrice.Location = new System.Drawing.Point(126, 184);
            this.txtPOFromUnitPrice.Name = "txtPOFromUnitPrice";
            this.txtPOFromUnitPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPOFromUnitPrice.Size = new System.Drawing.Size(100, 20);
            this.txtPOFromUnitPrice.TabIndex = 76;
            this.txtPOFromUnitPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPOToUnitPrice
            // 
            this.txtPOToUnitPrice.AllowSpace = false;
            // 
            // 
            // 
            this.txtPOToUnitPrice.Border.Class = "TextBoxBorder";
            this.txtPOToUnitPrice.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtPOToUnitPrice.Location = new System.Drawing.Point(329, 186);
            this.txtPOToUnitPrice.Name = "txtPOToUnitPrice";
            this.txtPOToUnitPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPOToUnitPrice.Size = new System.Drawing.Size(100, 20);
            this.txtPOToUnitPrice.TabIndex = 77;
            this.txtPOToUnitPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            this.txtCnvfact.Location = new System.Drawing.Point(523, 158);
            this.txtCnvfact.Name = "txtCnvfact";
            this.txtCnvfact.RowsDisplay = 10;
            this.txtCnvfact.Size = new System.Drawing.Size(100, 20);
            this.txtCnvfact.TabIndex = 79;
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
            this.txtFromUnit.Location = new System.Drawing.Point(126, 158);
            this.txtFromUnit.Name = "txtFromUnit";
            this.txtFromUnit.Size = new System.Drawing.Size(100, 20);
            this.txtFromUnit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.txtFromUnit.TabIndex = 80;
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
            this.txtToUnit.Location = new System.Drawing.Point(328, 158);
            this.txtToUnit.Name = "txtToUnit";
            this.txtToUnit.Size = new System.Drawing.Size(100, 20);
            this.txtToUnit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.txtToUnit.TabIndex = 81;
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
            this.txtTaxID.Location = new System.Drawing.Point(126, 282);
            this.txtTaxID.Name = "txtTaxID";
            this.txtTaxID.Size = new System.Drawing.Size(100, 20);
            this.txtTaxID.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.txtTaxID.TabIndex = 82;
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
            this.txtDfltWhID.Location = new System.Drawing.Point(126, 256);
            this.txtDfltWhID.Name = "txtDfltWhID";
            this.txtDfltWhID.Size = new System.Drawing.Size(100, 20);
            this.txtDfltWhID.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.txtDfltWhID.TabIndex = 83;
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
            this.txtSOUnit.Location = new System.Drawing.Point(127, 334);
            this.txtSOUnit.Name = "txtSOUnit";
            this.txtSOUnit.Size = new System.Drawing.Size(100, 20);
            this.txtSOUnit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.txtSOUnit.TabIndex = 84;
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
            this.txtINUnit.Location = new System.Drawing.Point(127, 360);
            this.txtINUnit.Name = "txtINUnit";
            this.txtINUnit.Size = new System.Drawing.Size(100, 20);
            this.txtINUnit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.txtINUnit.TabIndex = 85;
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
            this.txtVendID.Location = new System.Drawing.Point(126, 386);
            this.txtVendID.Name = "txtVendID";
            this.txtVendID.Size = new System.Drawing.Size(100, 20);
            this.txtVendID.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.txtVendID.TabIndex = 86;
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
            this.txtPOUnit.Location = new System.Drawing.Point(127, 308);
            this.txtPOUnit.Name = "txtPOUnit";
            this.txtPOUnit.Size = new System.Drawing.Size(100, 20);
            this.txtPOUnit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.txtPOUnit.TabIndex = 87;
            // 
            // chkStatus
            // 
            // 
            // 
            // 
            this.chkStatus.BackgroundStyle.Class = "";
            this.chkStatus.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chkStatus.Location = new System.Drawing.Point(242, 32);
            this.chkStatus.Name = "chkStatus";
            this.chkStatus.Size = new System.Drawing.Size(76, 23);
            this.chkStatus.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.chkStatus.TabIndex = 88;
            this.chkStatus.Text = "Status";
            // 
            // IN106
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Name = "IN106";
            this.Text = "IN106";
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            this.Load += new System.EventHandler(this.IN106_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).EndInit();
            this.pnl1.ResumeLayout(false);
            this.pnl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.pnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtiPOPriEffDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtiSOPriEffDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtiCrtd_DateTime)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.ComboBoxEx cbxStatus;
        public DevComponents.DotNetBar.Controls.TextBoxX txtProductID;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDesc;
        private System.Windows.Forms.Label lblTaxID;
        private System.Windows.Forms.Label lblStyle;
        private DevComponents.DotNetBar.Controls.TextBoxX txtStyle;
        private System.Windows.Forms.Label lblWeight;
        private DevComponents.DotNetBar.Controls.TextBoxX txtWeight;
        private System.Windows.Forms.Label lblVolume;
        private DevComponents.DotNetBar.Controls.TextBoxX txtVolume;
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
        private System.Windows.Forms.Label lblSOToUnitPrice;
        private System.Windows.Forms.Label lblSOFromUnitPrice;
        private System.Windows.Forms.Label lblPOPriEffDate;
        private System.Windows.Forms.Label lblPOToUnitPrice;
        private System.Windows.Forms.Label lblPOFromUnitPrice;
        private System.Windows.Forms.Label lblCnvfact;
        private System.Windows.Forms.Label lblToUnit;
        private System.Windows.Forms.Label lblFromUnit;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblVendID;
        private System.Windows.Forms.Label lblClassID1;
        private System.Windows.Forms.Label lblClassID2;
        private System.Windows.Forms.Label lblDescr;
        private System.Windows.Forms.Label lblProductID;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtiPOPriEffDate;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtiSOPriEffDate;
        private PT.Component.MultiDropDownTextBox txtClassID1;
        private PT.Component.MultiDropDownTextBox txtClassID2;
        public DevComponents.DotNetBar.Controls.TextBoxX txtCrtd_User;
        public DevComponents.DotNetBar.Controls.TextBoxX txtCrtd_Prog;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtiCrtd_DateTime;
        private DevComponents.DotNetBar.ButtonX btnCopy;
        private PT.Component.MultiDropDownTextBox txtCopy;
        private PT.Component.NumericTextBox txtPOToUnitPrice;
        private PT.Component.NumericTextBox txtPOFromUnitPrice;
        private PT.Component.NumericTextBox txtSOToUnitPrice;
        private PT.Component.NumericTextBox txtSOFromUnitPrice;
        public DevComponents.Editors.ComboItem comboItem3;
        public DevComponents.Editors.ComboItem comboItem1;
        private PT.Component.MultiDropDownTextBox txtCnvfact;
        private PT.Component.MultiColumnComboBox txtFromUnit;
        private PT.Component.MultiColumnComboBox txtToUnit;
        private PT.Component.MultiColumnComboBox txtTaxID;
        private PT.Component.MultiColumnComboBox txtPOUnit;
        private PT.Component.MultiColumnComboBox txtVendID;
        private PT.Component.MultiColumnComboBox txtINUnit;
        private PT.Component.MultiColumnComboBox txtSOUnit;
        private PT.Component.MultiColumnComboBox txtDfltWhID;
        private DevComponents.DotNetBar.Controls.CheckBoxX chkStatus;

    }
}