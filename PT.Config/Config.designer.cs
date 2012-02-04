namespace PT.Config
{
    partial class Config
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
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.lblUsername = new DevComponents.DotNetBar.LabelX();
            this.lblPassword = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.tbxUsername = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbxPassword = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.textBoxX4 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.cbxDatabase = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.btnSaveSystemConfig = new DevComponents.DotNetBar.ButtonX();
            this.buttonX3 = new DevComponents.DotNetBar.ButtonX();
            this.tbxServername = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnCancel = new DevComponents.DotNetBar.ButtonX();
            this.btnConnect = new DevComponents.DotNetBar.ButtonX();
            this.SuspendLayout();
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(13, 13);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 23);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Server Name";
            // 
            // lblUsername
            // 
            // 
            // 
            // 
            this.lblUsername.BackgroundStyle.Class = "";
            this.lblUsername.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblUsername.Location = new System.Drawing.Point(12, 43);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(75, 23);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "User Name";
            // 
            // lblPassword
            // 
            // 
            // 
            // 
            this.lblPassword.BackgroundStyle.Class = "";
            this.lblPassword.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblPassword.Location = new System.Drawing.Point(12, 72);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(75, 23);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Password";
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.Class = "";
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(281, 12);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(98, 23);
            this.labelX4.TabIndex = 3;
            this.labelX4.Text = "System Database";
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.Class = "";
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(281, 41);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(115, 23);
            this.labelX5.TabIndex = 4;
            this.labelX5.Text = "Application Database";
            // 
            // tbxUsername
            // 
            // 
            // 
            // 
            this.tbxUsername.Border.Class = "TextBoxBorder";
            this.tbxUsername.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbxUsername.Location = new System.Drawing.Point(94, 46);
            this.tbxUsername.Name = "tbxUsername";
            this.tbxUsername.Size = new System.Drawing.Size(156, 20);
            this.tbxUsername.TabIndex = 6;
            // 
            // tbxPassword
            // 
            // 
            // 
            // 
            this.tbxPassword.Border.Class = "TextBoxBorder";
            this.tbxPassword.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbxPassword.Location = new System.Drawing.Point(94, 75);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.PasswordChar = '*';
            this.tbxPassword.Size = new System.Drawing.Size(156, 20);
            this.tbxPassword.TabIndex = 7;
            // 
            // textBoxX4
            // 
            this.textBoxX4.BackColor = System.Drawing.Color.Tan;
            // 
            // 
            // 
            this.textBoxX4.Border.Class = "TextBoxBorder";
            this.textBoxX4.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxX4.Location = new System.Drawing.Point(402, 44);
            this.textBoxX4.Name = "textBoxX4";
            this.textBoxX4.Size = new System.Drawing.Size(212, 20);
            this.textBoxX4.TabIndex = 8;
            // 
            // cbxDatabase
            // 
            this.cbxDatabase.DisplayMember = "Text";
            this.cbxDatabase.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxDatabase.FormattingEnabled = true;
            this.cbxDatabase.ItemHeight = 14;
            this.cbxDatabase.Location = new System.Drawing.Point(402, 15);
            this.cbxDatabase.Name = "cbxDatabase";
            this.cbxDatabase.Size = new System.Drawing.Size(212, 20);
            this.cbxDatabase.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbxDatabase.TabIndex = 9;
            // 
            // btnSaveSystemConfig
            // 
            this.btnSaveSystemConfig.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSaveSystemConfig.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSaveSystemConfig.Location = new System.Drawing.Point(402, 75);
            this.btnSaveSystemConfig.Name = "btnSaveSystemConfig";
            this.btnSaveSystemConfig.Size = new System.Drawing.Size(152, 23);
            this.btnSaveSystemConfig.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSaveSystemConfig.TabIndex = 11;
            this.btnSaveSystemConfig.Text = "Save System Config";
            this.btnSaveSystemConfig.Click += new System.EventHandler(this.btnSaveSystemConfig_Click);
            // 
            // buttonX3
            // 
            this.buttonX3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX3.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX3.Location = new System.Drawing.Point(402, 109);
            this.buttonX3.Name = "buttonX3";
            this.buttonX3.Size = new System.Drawing.Size(100, 23);
            this.buttonX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX3.TabIndex = 12;
            this.buttonX3.Text = "Close";
            this.buttonX3.Click += new System.EventHandler(this.buttonX3_Click);
            // 
            // tbxServername
            // 
            // 
            // 
            // 
            this.tbxServername.Border.Class = "TextBoxBorder";
            this.tbxServername.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbxServername.Location = new System.Drawing.Point(94, 16);
            this.tbxServername.Name = "tbxServername";
            this.tbxServername.Size = new System.Drawing.Size(156, 20);
            this.tbxServername.TabIndex = 13;
            this.tbxServername.TextChanged += new System.EventHandler(this.tbxServername_TextChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancel.Location = new System.Drawing.Point(119, 109);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 23);
            this.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Cancel";
            // 
            // btnConnect
            // 
            this.btnConnect.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnConnect.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnConnect.Location = new System.Drawing.Point(13, 109);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(100, 23);
            this.btnConnect.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnConnect.TabIndex = 17;
            this.btnConnect.Text = "Connect";
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // Config
            // 
            this.ClientSize = new System.Drawing.Size(626, 208);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.tbxServername);
            this.Controls.Add(this.buttonX3);
            this.Controls.Add(this.btnSaveSystemConfig);
            this.Controls.Add(this.cbxDatabase);
            this.Controls.Add(this.textBoxX4);
            this.Controls.Add(this.tbxPassword);
            this.Controls.Add(this.tbxUsername);
            this.Controls.Add(this.labelX5);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.labelX1);
            this.DoubleBuffered = true;
            this.Name = "Config";
            this.Text = "Cấu hình hệ thống";
            this.Load += new System.EventHandler(this.PTConfig_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX lblUsername;
        private DevComponents.DotNetBar.LabelX lblPassword;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.Controls.TextBoxX tbxUsername;
        private DevComponents.DotNetBar.Controls.TextBoxX tbxPassword;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX4;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbxDatabase;
        private DevComponents.DotNetBar.ButtonX btnSaveSystemConfig;
        private DevComponents.DotNetBar.ButtonX buttonX3;
        private DevComponents.DotNetBar.Controls.TextBoxX tbxServername;
        private DevComponents.DotNetBar.ButtonX btnCancel;
        private DevComponents.DotNetBar.ButtonX btnConnect;
    }
}