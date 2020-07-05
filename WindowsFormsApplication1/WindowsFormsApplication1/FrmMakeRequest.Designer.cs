namespace WindowsFormsApplication1
{
    partial class FrmMakeRequest
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
            this.lblIDMRQ = new System.Windows.Forms.Label();
            this.txtIDMRQ = new System.Windows.Forms.TextBox();
            this.lblIDSRQ = new System.Windows.Forms.Label();
            this.cboIDSRQ = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.lblNgayThucHien = new System.Windows.Forms.Label();
            this.dtNgayThucHien = new System.Windows.Forms.DateTimePicker();
            this.lblThoiGianTH = new System.Windows.Forms.Label();
            this.ckbStatus = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKQTH = new System.Windows.Forms.TextBox();
            this.picChuKy = new System.Windows.Forms.PictureBox();
            this.dgMakeRQ = new System.Windows.Forms.DataGridView();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTenNV = new System.Windows.Forms.Label();
            this.cboPhongBan = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvSendRQ = new System.Windows.Forms.DataGridView();
            this.txtidSendRq = new System.Windows.Forms.TextBox();
            this.lblidRequest = new System.Windows.Forms.Label();
            this.txtFindMRQ = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picChuKy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgMakeRQ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSendRQ)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIDMRQ
            // 
            this.lblIDMRQ.AutoSize = true;
            this.lblIDMRQ.Location = new System.Drawing.Point(38, 71);
            this.lblIDMRQ.Name = "lblIDMRQ";
            this.lblIDMRQ.Size = new System.Drawing.Size(91, 13);
            this.lblIDMRQ.TabIndex = 0;
            this.lblIDMRQ.Text = "ID Make Request";
            // 
            // txtIDMRQ
            // 
            this.txtIDMRQ.Location = new System.Drawing.Point(146, 64);
            this.txtIDMRQ.Name = "txtIDMRQ";
            this.txtIDMRQ.Size = new System.Drawing.Size(100, 20);
            this.txtIDMRQ.TabIndex = 1;
            // 
            // lblIDSRQ
            // 
            this.lblIDSRQ.AutoSize = true;
            this.lblIDSRQ.Location = new System.Drawing.Point(23, 39);
            this.lblIDSRQ.Name = "lblIDSRQ";
            this.lblIDSRQ.Size = new System.Drawing.Size(89, 13);
            this.lblIDSRQ.TabIndex = 2;
            this.lblIDSRQ.Text = "ID Send Request";
            this.lblIDSRQ.Visible = false;
            // 
            // cboIDSRQ
            // 
            this.cboIDSRQ.FormattingEnabled = true;
            this.cboIDSRQ.Location = new System.Drawing.Point(118, 31);
            this.cboIDSRQ.Name = "cboIDSRQ";
            this.cboIDSRQ.Size = new System.Drawing.Size(100, 21);
            this.cboIDSRQ.TabIndex = 3;
            this.cboIDSRQ.Visible = false;
            this.cboIDSRQ.SelectedIndexChanged += new System.EventHandler(this.cboIDSRQ_SelectedIndexChanged);
            this.cboIDSRQ.TextUpdate += new System.EventHandler(this.cboIDSRQ_TextUpdate);
            this.cboIDSRQ.SelectedValueChanged += new System.EventHandler(this.cboIDSRQ_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mã Nhân Viên";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(146, 148);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(100, 20);
            this.txtMaNV.TabIndex = 5;
            // 
            // lblNgayThucHien
            // 
            this.lblNgayThucHien.AutoSize = true;
            this.lblNgayThucHien.Location = new System.Drawing.Point(38, 197);
            this.lblNgayThucHien.Name = "lblNgayThucHien";
            this.lblNgayThucHien.Size = new System.Drawing.Size(85, 13);
            this.lblNgayThucHien.TabIndex = 6;
            this.lblNgayThucHien.Text = "Ngày Thực Hiện";
            // 
            // dtNgayThucHien
            // 
            this.dtNgayThucHien.Enabled = false;
            this.dtNgayThucHien.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayThucHien.Location = new System.Drawing.Point(146, 191);
            this.dtNgayThucHien.Name = "dtNgayThucHien";
            this.dtNgayThucHien.Size = new System.Drawing.Size(100, 20);
            this.dtNgayThucHien.TabIndex = 31;
            // 
            // lblThoiGianTH
            // 
            this.lblThoiGianTH.AutoSize = true;
            this.lblThoiGianTH.Enabled = false;
            this.lblThoiGianTH.Location = new System.Drawing.Point(145, 258);
            this.lblThoiGianTH.Name = "lblThoiGianTH";
            this.lblThoiGianTH.Size = new System.Drawing.Size(106, 13);
            this.lblThoiGianTH.TabIndex = 33;
            this.lblThoiGianTH.Text = "Thời Gian Thực Hiện";
            // 
            // ckbStatus
            // 
            this.ckbStatus.AutoSize = true;
            this.ckbStatus.Location = new System.Drawing.Point(151, 291);
            this.ckbStatus.Name = "ckbStatus";
            this.ckbStatus.Size = new System.Drawing.Size(78, 17);
            this.ckbStatus.TabIndex = 35;
            this.ckbStatus.Text = "Tình Trạng";
            this.ckbStatus.UseVisualStyleBackColor = true;
            this.ckbStatus.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 354);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "Kết Quả Thực Hiện:";
            // 
            // txtKQTH
            // 
            this.txtKQTH.Location = new System.Drawing.Point(41, 370);
            this.txtKQTH.Multiline = true;
            this.txtKQTH.Name = "txtKQTH";
            this.txtKQTH.Size = new System.Drawing.Size(205, 58);
            this.txtKQTH.TabIndex = 37;
            // 
            // picChuKy
            // 
            this.picChuKy.Location = new System.Drawing.Point(41, 258);
            this.picChuKy.Name = "picChuKy";
            this.picChuKy.Size = new System.Drawing.Size(96, 48);
            this.picChuKy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picChuKy.TabIndex = 41;
            this.picChuKy.TabStop = false;
            // 
            // dgMakeRQ
            // 
            this.dgMakeRQ.AllowUserToAddRows = false;
            this.dgMakeRQ.AllowUserToDeleteRows = false;
            this.dgMakeRQ.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMakeRQ.Location = new System.Drawing.Point(257, 153);
            this.dgMakeRQ.Name = "dgMakeRQ";
            this.dgMakeRQ.ReadOnly = true;
            this.dgMakeRQ.Size = new System.Drawing.Size(528, 233);
            this.dgMakeRQ.TabIndex = 42;
            this.dgMakeRQ.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgMakeRQ_CellContentClick);
            this.dgMakeRQ.Click += new System.EventHandler(this.dgMakeRQ_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(378, 395);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(82, 46);
            this.btnLuu.TabIndex = 47;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(708, 395);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 46);
            this.btnThoat.TabIndex = 46;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(600, 395);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(80, 46);
            this.btnXoa.TabIndex = 45;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(489, 395);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(85, 46);
            this.btnSua.TabIndex = 44;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(255, 395);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(88, 46);
            this.btnThem.TabIndex = 43;
            this.btnThem.Text = "Duyệt Request";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(372, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(221, 31);
            this.label5.TabIndex = 48;
            this.label5.Text = "MAKE REQUEST";
            // 
            // lblTenNV
            // 
            this.lblTenNV.AutoSize = true;
            this.lblTenNV.Location = new System.Drawing.Point(145, 171);
            this.lblTenNV.Name = "lblTenNV";
            this.lblTenNV.Size = new System.Drawing.Size(79, 13);
            this.lblTenNV.TabIndex = 49;
            this.lblTenNV.Text = "Tên Nhân Viên";
            // 
            // cboPhongBan
            // 
            this.cboPhongBan.FormattingEnabled = true;
            this.cboPhongBan.Location = new System.Drawing.Point(124, 1);
            this.cboPhongBan.Name = "cboPhongBan";
            this.cboPhongBan.Size = new System.Drawing.Size(100, 21);
            this.cboPhongBan.TabIndex = 51;
            this.cboPhongBan.Visible = false;
            this.cboPhongBan.SelectedIndexChanged += new System.EventHandler(this.cboPhongBan_SelectedIndexChanged);
            this.cboPhongBan.SelectedValueChanged += new System.EventHandler(this.cboPhongBan_SelectedValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 50;
            this.label3.Text = "Phòng Ban";
            this.label3.Visible = false;
            // 
            // dgvSendRQ
            // 
            this.dgvSendRQ.AllowUserToAddRows = false;
            this.dgvSendRQ.AllowUserToDeleteRows = false;
            this.dgvSendRQ.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSendRQ.Location = new System.Drawing.Point(257, 64);
            this.dgvSendRQ.Name = "dgvSendRQ";
            this.dgvSendRQ.ReadOnly = true;
            this.dgvSendRQ.Size = new System.Drawing.Size(528, 79);
            this.dgvSendRQ.TabIndex = 52;
            // 
            // txtidSendRq
            // 
            this.txtidSendRq.Location = new System.Drawing.Point(146, 106);
            this.txtidSendRq.Name = "txtidSendRq";
            this.txtidSendRq.Size = new System.Drawing.Size(100, 20);
            this.txtidSendRq.TabIndex = 53;
            this.txtidSendRq.TextChanged += new System.EventHandler(this.txtidSendRq_TextChanged);
            // 
            // lblidRequest
            // 
            this.lblidRequest.AutoSize = true;
            this.lblidRequest.Location = new System.Drawing.Point(38, 113);
            this.lblidRequest.Name = "lblidRequest";
            this.lblidRequest.Size = new System.Drawing.Size(61, 13);
            this.lblidRequest.TabIndex = 54;
            this.lblidRequest.Text = "ID Request";
            // 
            // txtFindMRQ
            // 
            this.txtFindMRQ.Location = new System.Drawing.Point(94, 320);
            this.txtFindMRQ.Name = "txtFindMRQ";
            this.txtFindMRQ.Size = new System.Drawing.Size(96, 20);
            this.txtFindMRQ.TabIndex = 55;
            this.txtFindMRQ.TextChanged += new System.EventHandler(this.txtFindMRQ_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 327);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 56;
            this.label4.Text = "Tìm Kiếm";
            // 
            // FrmMakeRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 444);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtFindMRQ);
            this.Controls.Add(this.lblidRequest);
            this.Controls.Add(this.txtidSendRq);
            this.Controls.Add(this.dgvSendRQ);
            this.Controls.Add(this.cboPhongBan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTenNV);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgMakeRQ);
            this.Controls.Add(this.picChuKy);
            this.Controls.Add(this.txtKQTH);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ckbStatus);
            this.Controls.Add(this.lblThoiGianTH);
            this.Controls.Add(this.dtNgayThucHien);
            this.Controls.Add(this.lblNgayThucHien);
            this.Controls.Add(this.txtMaNV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboIDSRQ);
            this.Controls.Add(this.lblIDSRQ);
            this.Controls.Add(this.txtIDMRQ);
            this.Controls.Add(this.lblIDMRQ);
            this.Name = "FrmMakeRequest";
            this.Text = "FrmMakeRequest";
            this.Load += new System.EventHandler(this.FrmMakeRequest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picChuKy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgMakeRQ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSendRQ)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIDMRQ;
        private System.Windows.Forms.TextBox txtIDMRQ;
        private System.Windows.Forms.Label lblIDSRQ;
        private System.Windows.Forms.ComboBox cboIDSRQ;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label lblNgayThucHien;
        private System.Windows.Forms.DateTimePicker dtNgayThucHien;
        private System.Windows.Forms.Label lblThoiGianTH;
        private System.Windows.Forms.CheckBox ckbStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKQTH;
        private System.Windows.Forms.PictureBox picChuKy;
        private System.Windows.Forms.DataGridView dgMakeRQ;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTenNV;
        private System.Windows.Forms.ComboBox cboPhongBan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvSendRQ;
        private System.Windows.Forms.TextBox txtidSendRq;
        private System.Windows.Forms.Label lblidRequest;
        private System.Windows.Forms.TextBox txtFindMRQ;
        private System.Windows.Forms.Label label4;
    }
}