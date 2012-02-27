namespace IN104
{
    partial class IN104
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
            this.VendID = new DevComponents.DotNetBar.LabelX();
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).BeginInit();
            this.SuspendLayout();
            // 
            // bar1
            // 
            this.bar1.Size = new System.Drawing.Size(718, 25);
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
            // btnDelete
            // 
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
            // 
            // barStatus
            // 
            this.barStatus.Location = new System.Drawing.Point(0, 448);
            this.barStatus.Size = new System.Drawing.Size(718, 2);
            // 
            // bar2
            // 
            this.bar2.Location = new System.Drawing.Point(0, 431);
            this.bar2.Size = new System.Drawing.Size(718, 19);
            // 
            // dgv1
            // 
            this.dgv1.AllowUserToAddRows = false;
            this.dgv1.AllowUserToDeleteRows = false;
            this.dgv1.AllowUserToResizeRows = false;
            this.dgv1.Size = new System.Drawing.Size(718, 292);
            this.dgv1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv1_CellClick);
            this.dgv1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgv1_KeyDown);
            this.dgv1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv1_RowHeaderMouseClick);
            // 
            // dgv2
            // 
            this.dgv2.AllowUserToAddRows = false;
            this.dgv2.AllowUserToDeleteRows = false;
            this.dgv2.AllowUserToResizeRows = false;
            this.dgv2.Size = new System.Drawing.Size(718, 111);
            // 
            // lbl2
            // 
            // 
            // 
            // 
            this.lbl2.BackgroundStyle.Class = "";
            this.lbl2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // lbl1
            // 
            // 
            // 
            // 
            this.lbl1.BackgroundStyle.Class = "";
            this.lbl1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // text1
            // 
            // 
            // 
            // 
            this.txt1.Border.Class = "TextBoxBorder";
            this.txt1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // text2
            // 
            // 
            // 
            // 
            this.txt2.Border.Class = "TextBoxBorder";
            this.txt2.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // VendID
            // 
            // 
            // 
            // 
            this.VendID.BackgroundStyle.Class = "";
            this.VendID.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.VendID.Location = new System.Drawing.Point(30, 11);
            this.VendID.Name = "VendID";
            this.VendID.Size = new System.Drawing.Size(75, 23);
            this.VendID.TabIndex = 4;
            this.VendID.Text = "VendID";
            // 
            // IN104
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 450);
            this.Name = "IN104";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX VendID;

    }
}

