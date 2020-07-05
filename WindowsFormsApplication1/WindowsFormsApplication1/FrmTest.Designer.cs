namespace WindowsFormsApplication1
{
    partial class FrmTest
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
            this.dgvTestRport = new System.Windows.Forms.DataGridView();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lVTest = new System.Windows.Forms.ListView();
            this.RequestID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RequestName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TenCD = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.dgvTest = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTestRport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTest)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTestRport
            // 
            this.dgvTestRport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTestRport.Location = new System.Drawing.Point(12, 21);
            this.dgvTestRport.Name = "dgvTestRport";
            this.dgvTestRport.Size = new System.Drawing.Size(253, 150);
            this.dgvTestRport.TabIndex = 0;
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(1, 229);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(145, 56);
            this.btnReport.TabIndex = 1;
            this.btnReport.Text = "REPORT";
            this.btnReport.UseVisualStyleBackColor = true;
            //this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(423, 229);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(145, 56);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lVTest
            // 
            this.lVTest.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.RequestID,
            this.RequestName,
            this.TenCD});
            this.lVTest.FullRowSelect = true;
            this.lVTest.GridLines = true;
            this.lVTest.Location = new System.Drawing.Point(294, 21);
            this.lVTest.Name = "lVTest";
            this.lVTest.Size = new System.Drawing.Size(248, 150);
            this.lVTest.TabIndex = 3;
            this.lVTest.UseCompatibleStateImageBehavior = false;
            this.lVTest.View = System.Windows.Forms.View.Details;
            // 
            // RequestID
            // 
            this.RequestID.Text = "Request ID";
            this.RequestID.Width = 84;
            // 
            // RequestName
            // 
            this.RequestName.Text = "Ten Request";
            this.RequestName.Width = 82;
            // 
            // TenCD
            // 
            this.TenCD.Text = "Chức Danh";
            this.TenCD.Width = 123;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(214, 229);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 56);
            this.button1.TabIndex = 4;
            this.button1.Text = "REPORT LISTVIEW";
            this.button1.UseVisualStyleBackColor = true;
           // this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvTest
            // 
            this.dgvTest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTest.Location = new System.Drawing.Point(585, 107);
            this.dgvTest.Name = "dgvTest";
            this.dgvTest.Size = new System.Drawing.Size(187, 95);
            this.dgvTest.TabIndex = 5;
            // 
            // FrmTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 425);
            this.Controls.Add(this.dgvTest);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lVTest);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.dgvTestRport);
            this.Name = "FrmTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmTest";
            this.Load += new System.EventHandler(this.FrmTest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTestRport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTest)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTestRport;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ListView lVTest;
        private System.Windows.Forms.ColumnHeader RequestID;
        private System.Windows.Forms.ColumnHeader RequestName;
        private System.Windows.Forms.ColumnHeader TenCD;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvTest;
    }
}