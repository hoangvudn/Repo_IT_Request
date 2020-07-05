namespace WindowsFormsApplication1
{
    partial class FrmSendRequest
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaRQ = new System.Windows.Forms.TextBox();
            this.txtTenRQ = new System.Windows.Forms.TextBox();
            this.dgvSendRQ = new System.Windows.Forms.DataGridView();
            this.lblMaNV = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.lblTenNV = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dtNgayGui = new System.Windows.Forms.DateTimePicker();
            this.lblNgayGui = new System.Windows.Forms.Label();
            this.lblThoiGianGui = new System.Windows.Forms.Label();
            this.lblMaPB = new System.Windows.Forms.Label();
            this.txtMaPB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboMaLoaiYC = new System.Windows.Forms.ComboBox();
            this.lblTenLoaiYC = new System.Windows.Forms.Label();
            this.lblNoiDungCT = new System.Windows.Forms.Label();
            this.txtNoiDungCT = new System.Windows.Forms.TextBox();
            this.picChuKy = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.rdBSearch = new System.Windows.Forms.RadioButton();
            this.dtSearch = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSendRQ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picChuKy)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Request";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(250, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Request";
            // 
            // txtMaRQ
            // 
            this.txtMaRQ.Location = new System.Drawing.Point(100, 74);
            this.txtMaRQ.Name = "txtMaRQ";
            this.txtMaRQ.Size = new System.Drawing.Size(100, 20);
            this.txtMaRQ.TabIndex = 2;
            // 
            // txtTenRQ
            // 
            this.txtTenRQ.Location = new System.Drawing.Point(328, 74);
            this.txtTenRQ.Name = "txtTenRQ";
            this.txtTenRQ.Size = new System.Drawing.Size(141, 20);
            this.txtTenRQ.TabIndex = 3;
            // 
            // dgvSendRQ
            // 
            this.dgvSendRQ.AllowUserToAddRows = false;
            this.dgvSendRQ.AllowUserToDeleteRows = false;
            this.dgvSendRQ.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSendRQ.Location = new System.Drawing.Point(259, 151);
            this.dgvSendRQ.Name = "dgvSendRQ";
            this.dgvSendRQ.ReadOnly = true;
            this.dgvSendRQ.Size = new System.Drawing.Size(428, 176);
            this.dgvSendRQ.TabIndex = 4;
            this.dgvSendRQ.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSendRQ_CellContentClick);
            this.dgvSendRQ.Click += new System.EventHandler(this.dgvSendRQ_Click);
            // 
            // lblMaNV
            // 
            this.lblMaNV.AutoSize = true;
            this.lblMaNV.Location = new System.Drawing.Point(12, 116);
            this.lblMaNV.Name = "lblMaNV";
            this.lblMaNV.Size = new System.Drawing.Size(75, 13);
            this.lblMaNV.TabIndex = 5;
            this.lblMaNV.Text = "Mã Nhân Viên";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Enabled = false;
            this.txtMaNV.Location = new System.Drawing.Point(100, 113);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(100, 20);
            this.txtMaNV.TabIndex = 6;
            // 
            // lblTenNV
            // 
            this.lblTenNV.AutoSize = true;
            this.lblTenNV.Enabled = false;
            this.lblTenNV.Location = new System.Drawing.Point(97, 139);
            this.lblTenNV.Name = "lblTenNV";
            this.lblTenNV.Size = new System.Drawing.Size(79, 13);
            this.lblTenNV.TabIndex = 7;
            this.lblTenNV.Text = "Tên Nhân Viên";
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(377, 333);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(82, 46);
            this.btnLuu.TabIndex = 29;
            this.btnLuu.Text = "Gửi Request";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(703, 333);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 46);
            this.btnThoat.TabIndex = 28;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(597, 333);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(80, 46);
            this.btnXoa.TabIndex = 27;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(487, 333);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(85, 46);
            this.btnSua.TabIndex = 26;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(258, 333);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(86, 46);
            this.btnThem.TabIndex = 25;
            this.btnThem.Text = "Tạo Request";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dtNgayGui
            // 
            this.dtNgayGui.Enabled = false;
            this.dtNgayGui.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayGui.Location = new System.Drawing.Point(588, 113);
            this.dtNgayGui.Name = "dtNgayGui";
            this.dtNgayGui.Size = new System.Drawing.Size(85, 20);
            this.dtNgayGui.TabIndex = 30;
            // 
            // lblNgayGui
            // 
            this.lblNgayGui.AutoSize = true;
            this.lblNgayGui.Location = new System.Drawing.Point(495, 119);
            this.lblNgayGui.Name = "lblNgayGui";
            this.lblNgayGui.Size = new System.Drawing.Size(51, 13);
            this.lblNgayGui.TabIndex = 31;
            this.lblNgayGui.Text = "Ngày Gửi";
            // 
            // lblThoiGianGui
            // 
            this.lblThoiGianGui.AutoSize = true;
            this.lblThoiGianGui.Enabled = false;
            this.lblThoiGianGui.Location = new System.Drawing.Point(675, 117);
            this.lblThoiGianGui.Name = "lblThoiGianGui";
            this.lblThoiGianGui.Size = new System.Drawing.Size(72, 13);
            this.lblThoiGianGui.TabIndex = 32;
            this.lblThoiGianGui.Text = "Thời Gian Gửi";
            // 
            // lblMaPB
            // 
            this.lblMaPB.AutoSize = true;
            this.lblMaPB.Location = new System.Drawing.Point(250, 120);
            this.lblMaPB.Name = "lblMaPB";
            this.lblMaPB.Size = new System.Drawing.Size(78, 13);
            this.lblMaPB.TabIndex = 33;
            this.lblMaPB.Text = "Mã Phòng Ban";
            // 
            // txtMaPB
            // 
            this.txtMaPB.Enabled = false;
            this.txtMaPB.Location = new System.Drawing.Point(329, 112);
            this.txtMaPB.Name = "txtMaPB";
            this.txtMaPB.Size = new System.Drawing.Size(63, 20);
            this.txtMaPB.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(493, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "Mã Loại Yêu Cầu";
            // 
            // cboMaLoaiYC
            // 
            this.cboMaLoaiYC.FormattingEnabled = true;
            this.cboMaLoaiYC.Location = new System.Drawing.Point(588, 72);
            this.cboMaLoaiYC.Name = "cboMaLoaiYC";
            this.cboMaLoaiYC.Size = new System.Drawing.Size(85, 21);
            this.cboMaLoaiYC.TabIndex = 36;
            this.cboMaLoaiYC.SelectedIndexChanged += new System.EventHandler(this.cboMaLoaiYC_SelectedIndexChanged);
            this.cboMaLoaiYC.SelectionChangeCommitted += new System.EventHandler(this.cboMaLoaiYC_SelectionChangeCommitted);
            this.cboMaLoaiYC.SelectedValueChanged += new System.EventHandler(this.cboMaLoaiYC_SelectedValueChanged);
            // 
            // lblTenLoaiYC
            // 
            this.lblTenLoaiYC.AutoSize = true;
            this.lblTenLoaiYC.Enabled = false;
            this.lblTenLoaiYC.Location = new System.Drawing.Point(679, 80);
            this.lblTenLoaiYC.Name = "lblTenLoaiYC";
            this.lblTenLoaiYC.Size = new System.Drawing.Size(93, 13);
            this.lblTenLoaiYC.TabIndex = 37;
            this.lblTenLoaiYC.Text = "Tên Loại Yêu Cầu";
            // 
            // lblNoiDungCT
            // 
            this.lblNoiDungCT.AutoSize = true;
            this.lblNoiDungCT.Location = new System.Drawing.Point(14, 170);
            this.lblNoiDungCT.Name = "lblNoiDungCT";
            this.lblNoiDungCT.Size = new System.Drawing.Size(138, 13);
            this.lblNoiDungCT.TabIndex = 38;
            this.lblNoiDungCT.Text = "Nội Dung Chi Tiết Yêu Cầu:";
            // 
            // txtNoiDungCT
            // 
            this.txtNoiDungCT.Location = new System.Drawing.Point(13, 190);
            this.txtNoiDungCT.Multiline = true;
            this.txtNoiDungCT.Name = "txtNoiDungCT";
            this.txtNoiDungCT.Size = new System.Drawing.Size(240, 87);
            this.txtNoiDungCT.TabIndex = 39;
            // 
            // picChuKy
            // 
            this.picChuKy.Location = new System.Drawing.Point(687, 151);
            this.picChuKy.Name = "picChuKy";
            this.picChuKy.Size = new System.Drawing.Size(103, 88);
            this.picChuKy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picChuKy.TabIndex = 40;
            this.picChuKy.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(334, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 31);
            this.label5.TabIndex = 41;
            this.label5.Text = "REQUEST";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(12, 333);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(133, 41);
            this.btnSearch.TabIndex = 42;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtFind
            // 
            this.txtFind.Location = new System.Drawing.Point(12, 296);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(133, 20);
            this.txtFind.TabIndex = 43;
            this.txtFind.Click += new System.EventHandler(this.txtFind_Click);
            // 
            // rdBSearch
            // 
            this.rdBSearch.AutoSize = true;
            this.rdBSearch.Location = new System.Drawing.Point(161, 296);
            this.rdBSearch.Name = "rdBSearch";
            this.rdBSearch.Size = new System.Drawing.Size(92, 17);
            this.rdBSearch.TabIndex = 44;
            this.rdBSearch.TabStop = true;
            this.rdBSearch.Text = "Tìm theo ngày";
            this.rdBSearch.UseVisualStyleBackColor = true;
            this.rdBSearch.Click += new System.EventHandler(this.rdBSearch_Click);
            // 
            // dtSearch
            // 
            this.dtSearch.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtSearch.Location = new System.Drawing.Point(161, 321);
            this.dtSearch.Name = "dtSearch";
            this.dtSearch.Size = new System.Drawing.Size(85, 20);
            this.dtSearch.TabIndex = 45;
            // 
            // FrmSendRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 389);
            this.Controls.Add(this.dtSearch);
            this.Controls.Add(this.rdBSearch);
            this.Controls.Add(this.txtFind);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.picChuKy);
            this.Controls.Add(this.txtNoiDungCT);
            this.Controls.Add(this.lblNoiDungCT);
            this.Controls.Add(this.lblTenLoaiYC);
            this.Controls.Add(this.cboMaLoaiYC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMaPB);
            this.Controls.Add(this.lblMaPB);
            this.Controls.Add(this.lblThoiGianGui);
            this.Controls.Add(this.lblNgayGui);
            this.Controls.Add(this.dtNgayGui);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.lblTenNV);
            this.Controls.Add(this.txtMaNV);
            this.Controls.Add(this.lblMaNV);
            this.Controls.Add(this.dgvSendRQ);
            this.Controls.Add(this.txtTenRQ);
            this.Controls.Add(this.txtMaRQ);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmSendRequest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSendRequest";
            this.Load += new System.EventHandler(this.FrmSendRequest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSendRQ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picChuKy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaRQ;
        private System.Windows.Forms.TextBox txtTenRQ;
        private System.Windows.Forms.DataGridView dgvSendRQ;
        private System.Windows.Forms.Label lblMaNV;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label lblTenNV;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DateTimePicker dtNgayGui;
        private System.Windows.Forms.Label lblNgayGui;
        private System.Windows.Forms.Label lblThoiGianGui;
        private System.Windows.Forms.Label lblMaPB;
        private System.Windows.Forms.TextBox txtMaPB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboMaLoaiYC;
        private System.Windows.Forms.Label lblTenLoaiYC;
        private System.Windows.Forms.Label lblNoiDungCT;
        private System.Windows.Forms.TextBox txtNoiDungCT;
        private System.Windows.Forms.PictureBox picChuKy;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.RadioButton rdBSearch;
        private System.Windows.Forms.DateTimePicker dtSearch;
    }
}