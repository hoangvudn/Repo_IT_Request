namespace WindowsFormsApplication1
{
    partial class FrmReportTest
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
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.btnShowRP = new System.Windows.Forms.Button();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.dtNgayGui = new System.Windows.Forms.DateTimePicker();
            this.rbNgayThang = new System.Windows.Forms.RadioButton();
            this.rbNoiDung = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(12, 65);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(890, 460);
            this.crystalReportViewer1.TabIndex = 0;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.crystalReportViewer1.Load += new System.EventHandler(this.crystalReportViewer1_Load);
            // 
            // btnShowRP
            // 
            this.btnShowRP.Location = new System.Drawing.Point(363, 12);
            this.btnShowRP.Name = "btnShowRP";
            this.btnShowRP.Size = new System.Drawing.Size(138, 47);
            this.btnShowRP.TabIndex = 1;
            this.btnShowRP.Text = "Show Report";
            this.btnShowRP.UseVisualStyleBackColor = true;
            this.btnShowRP.Click += new System.EventHandler(this.btnShowRP_Click);
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(184, 39);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(131, 20);
            this.txtMaNV.TabIndex = 2;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(556, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(124, 47);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // dtNgayGui
            // 
            this.dtNgayGui.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayGui.Location = new System.Drawing.Point(41, 39);
            this.dtNgayGui.Name = "dtNgayGui";
            this.dtNgayGui.Size = new System.Drawing.Size(127, 20);
            this.dtNgayGui.TabIndex = 4;
            // 
            // rbNgayThang
            // 
            this.rbNgayThang.AutoSize = true;
            this.rbNgayThang.Location = new System.Drawing.Point(43, 9);
            this.rbNgayThang.Name = "rbNgayThang";
            this.rbNgayThang.Size = new System.Drawing.Size(71, 17);
            this.rbNgayThang.TabIndex = 5;
            this.rbNgayThang.TabStop = true;
            this.rbNgayThang.Text = "Thời Gian";
            this.rbNgayThang.UseVisualStyleBackColor = true;
            // 
            // rbNoiDung
            // 
            this.rbNoiDung.AutoSize = true;
            this.rbNoiDung.Location = new System.Drawing.Point(184, 8);
            this.rbNoiDung.Name = "rbNoiDung";
            this.rbNoiDung.Size = new System.Drawing.Size(70, 17);
            this.rbNoiDung.TabIndex = 6;
            this.rbNoiDung.TabStop = true;
            this.rbNoiDung.Text = "Nội Dung";
            this.rbNoiDung.UseVisualStyleBackColor = true;
            // 
            // FrmReportTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 530);
            this.Controls.Add(this.rbNoiDung);
            this.Controls.Add(this.rbNgayThang);
            this.Controls.Add(this.dtNgayGui);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtMaNV);
            this.Controls.Add(this.btnShowRP);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "FrmReportTest";
            this.Text = "FrmReportTest";
            this.Load += new System.EventHandler(this.FrmReportTest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Button btnShowRP;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DateTimePicker dtNgayGui;
        private System.Windows.Forms.RadioButton rbNgayThang;
        private System.Windows.Forms.RadioButton rbNoiDung;

    }
}