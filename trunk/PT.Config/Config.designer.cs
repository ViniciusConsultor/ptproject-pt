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
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.tbxUsername = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbxPassword = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.cbxDatabase = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.btnSaveSystemConfig = new DevComponents.DotNetBar.ButtonX();
            this.tbxServername = new DevComponents.DotNetBar.Controls.TextBoxX();
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
            this.labelX1.Location = new System.Drawing.Point(32, 11);
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
            this.lblUsername.Location = new System.Drawing.Point(31, 41);
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
            this.lblPassword.Location = new System.Drawing.Point(31, 70);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(75, 23);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Password";
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.Class = "";
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(31, 136);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(115, 23);
            this.labelX5.TabIndex = 4;
            this.labelX5.Text = "Database Name";
            // 
            // tbxUsername
            // 
            // 
            // 
            // 
            this.tbxUsername.Border.Class = "TextBoxBorder";
            this.tbxUsername.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbxUsername.Location = new System.Drawing.Point(128, 42);
            this.tbxUsername.Name = "tbxUsername";
            this.tbxUsername.Size = new System.Drawing.Size(156, 20);
            this.tbxUsername.TabIndex = 2;
            // 
            // tbxPassword
            // 
            // 
            // 
            // 
            this.tbxPassword.Border.Class = "TextBoxBorder";
            this.tbxPassword.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbxPassword.Location = new System.Drawing.Point(128, 72);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.PasswordChar = '*';
            this.tbxPassword.Size = new System.Drawing.Size(156, 20);
            this.tbxPassword.TabIndex = 3;
            // 
            // cbxDatabase
            // 
            this.cbxDatabase.DisplayMember = "Text";
            this.cbxDatabase.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxDatabase.FormattingEnabled = true;
            this.cbxDatabase.ItemHeight = 14;
            this.cbxDatabase.Location = new System.Drawing.Point(128, 137);
            this.cbxDatabase.Name = "cbxDatabase";
            this.cbxDatabase.Size = new System.Drawing.Size(156, 20);
            this.cbxDatabase.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbxDatabase.TabIndex = 4;
            // 
            // btnSaveSystemConfig
            // 
            this.btnSaveSystemConfig.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSaveSystemConfig.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSaveSystemConfig.Location = new System.Drawing.Point(128, 173);
            this.btnSaveSystemConfig.Name = "btnSaveSystemConfig";
            this.btnSaveSystemConfig.Size = new System.Drawing.Size(121, 23);
            this.btnSaveSystemConfig.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSaveSystemConfig.TabIndex = 6;
            this.btnSaveSystemConfig.Text = "Save System Config";
            this.btnSaveSystemConfig.Click += new System.EventHandler(this.btnSaveSystemConfig_Click);
            // 
            // tbxServername
            // 
            // 
            // 
            // 
            this.tbxServername.Border.Class = "TextBoxBorder";
            this.tbxServername.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbxServername.Location = new System.Drawing.Point(128, 12);
            this.tbxServername.Name = "tbxServername";
            this.tbxServername.Size = new System.Drawing.Size(156, 20);
            this.tbxServername.TabIndex = 1;
            this.tbxServername.TextChanged += new System.EventHandler(this.tbxServername_TextChanged);
            // 
            // btnConnect
            // 
            this.btnConnect.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnConnect.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnConnect.Location = new System.Drawing.Point(128, 99);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(100, 23);
            this.btnConnect.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnConnect.TabIndex = 5;
            this.btnConnect.Text = "Connect";
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // Config
            // 
            this.ClientSize = new System.Drawing.Size(317, 208);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.tbxServername);
            this.Controls.Add(this.btnSaveSystemConfig);
            this.Controls.Add(this.cbxDatabase);
            this.Controls.Add(this.tbxPassword);
            this.Controls.Add(this.tbxUsername);
            this.Controls.Add(this.labelX5);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.labelX1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Config";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cấu hình hệ thống";
            this.Load += new System.EventHandler(this.PTConfig_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX lblUsername;
        private DevComponents.DotNetBar.LabelX lblPassword;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.Controls.TextBoxX tbxUsername;
        private DevComponents.DotNetBar.Controls.TextBoxX tbxPassword;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbxDatabase;
        private DevComponents.DotNetBar.ButtonX btnSaveSystemConfig;
        private DevComponents.DotNetBar.Controls.TextBoxX tbxServername;
        private DevComponents.DotNetBar.ButtonX btnConnect;
    }
}