namespace WindowsFormsApplication1
{
    partial class FMakeRequest
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
            this.dtSearch = new System.Windows.Forms.DateTimePicker();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.picChuKy = new System.Windows.Forms.PictureBox();
            this.txtNoiDungCT = new System.Windows.Forms.TextBox();
            this.lblNoiDungCT = new System.Windows.Forms.Label();
            this.lblTenLoaiYC = new System.Windows.Forms.Label();
            this.cboMaLoaiYC = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaPB = new System.Windows.Forms.TextBox();
            this.lblMaPB = new System.Windows.Forms.Label();
            this.lblThoiGianGui = new System.Windows.Forms.Label();
            this.lblNgayGui = new System.Windows.Forms.Label();
            this.dtNgayGui = new System.Windows.Forms.DateTimePicker();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.lblTenNV = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.lblMaNV = new System.Windows.Forms.Label();
            this.dgvSendRQ = new System.Windows.Forms.DataGridView();
            this.txtTenRQ = new System.Windows.Forms.TextBox();
            this.txtMaRQ = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picChuKy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSendRQ)).BeginInit();
            this.SuspendLayout();
            // 
            // dtSearch
            // 
            this.dtSearch.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtSearch.Location = new System.Drawing.Point(239, 311);
            this.dtSearch.Name = "dtSearch";
            this.dtSearch.Size = new System.Drawing.Size(85, 20);
            this.dtSearch.TabIndex = 74;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(239, 280);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(92, 17);
            this.radioButton1.TabIndex = 73;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Tìm theo ngày";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // txtFind
            // 
            this.txtFind.Location = new System.Drawing.Point(84, 280);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(139, 20);
            this.txtFind.TabIndex = 72;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(84, 306);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(139, 25);
            this.btnSearch.TabIndex = 71;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(370, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(221, 31);
            this.label5.TabIndex = 70;
            this.label5.Text = "MAKE REQUEST";
            // 
            // picChuKy
            // 
            this.picChuKy.Location = new System.Drawing.Point(758, 152);
            this.picChuKy.Name = "picChuKy";
            this.picChuKy.Size = new System.Drawing.Size(103, 88);
            this.picChuKy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picChuKy.TabIndex = 69;
            this.picChuKy.TabStop = false;
            // 
            // txtNoiDungCT
            // 
            this.txtNoiDungCT.Location = new System.Drawing.Point(84, 191);
            this.txtNoiDungCT.Multiline = true;
            this.txtNoiDungCT.Name = "txtNoiDungCT";
            this.txtNoiDungCT.Size = new System.Drawing.Size(240, 72);
            this.txtNoiDungCT.TabIndex = 68;
            // 
            // lblNoiDungCT
            // 
            this.lblNoiDungCT.AutoSize = true;
            this.lblNoiDungCT.Location = new System.Drawing.Point(85, 171);
            this.lblNoiDungCT.Name = "lblNoiDungCT";
            this.lblNoiDungCT.Size = new System.Drawing.Size(138, 13);
            this.lblNoiDungCT.TabIndex = 67;
            this.lblNoiDungCT.Text = "Nội Dung Chi Tiết Yêu Cầu:";
            // 
            // lblTenLoaiYC
            // 
            this.lblTenLoaiYC.AutoSize = true;
            this.lblTenLoaiYC.Enabled = false;
            this.lblTenLoaiYC.Location = new System.Drawing.Point(748, 93);
            this.lblTenLoaiYC.Name = "lblTenLoaiYC";
            this.lblTenLoaiYC.Size = new System.Drawing.Size(93, 13);
            this.lblTenLoaiYC.TabIndex = 66;
            this.lblTenLoaiYC.Text = "Tên Loại Yêu Cầu";
            // 
            // cboMaLoaiYC
            // 
            this.cboMaLoaiYC.FormattingEnabled = true;
            this.cboMaLoaiYC.Location = new System.Drawing.Point(657, 85);
            this.cboMaLoaiYC.Name = "cboMaLoaiYC";
            this.cboMaLoaiYC.Size = new System.Drawing.Size(85, 21);
            this.cboMaLoaiYC.TabIndex = 65;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(562, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 64;
            this.label3.Text = "Mã Loại Yêu Cầu";
            // 
            // txtMaPB
            // 
            this.txtMaPB.Enabled = false;
            this.txtMaPB.Location = new System.Drawing.Point(398, 125);
            this.txtMaPB.Name = "txtMaPB";
            this.txtMaPB.Size = new System.Drawing.Size(63, 20);
            this.txtMaPB.TabIndex = 63;
            // 
            // lblMaPB
            // 
            this.lblMaPB.AutoSize = true;
            this.lblMaPB.Location = new System.Drawing.Point(319, 133);
            this.lblMaPB.Name = "lblMaPB";
            this.lblMaPB.Size = new System.Drawing.Size(78, 13);
            this.lblMaPB.TabIndex = 62;
            this.lblMaPB.Text = "Mã Phòng Ban";
            // 
            // lblThoiGianGui
            // 
            this.lblThoiGianGui.AutoSize = true;
            this.lblThoiGianGui.Enabled = false;
            this.lblThoiGianGui.Location = new System.Drawing.Point(744, 130);
            this.lblThoiGianGui.Name = "lblThoiGianGui";
            this.lblThoiGianGui.Size = new System.Drawing.Size(72, 13);
            this.lblThoiGianGui.TabIndex = 61;
            this.lblThoiGianGui.Text = "Thời Gian Gửi";
            // 
            // lblNgayGui
            // 
            this.lblNgayGui.AutoSize = true;
            this.lblNgayGui.Location = new System.Drawing.Point(564, 132);
            this.lblNgayGui.Name = "lblNgayGui";
            this.lblNgayGui.Size = new System.Drawing.Size(51, 13);
            this.lblNgayGui.TabIndex = 60;
            this.lblNgayGui.Text = "Ngày Gửi";
            // 
            // dtNgayGui
            // 
            this.dtNgayGui.Enabled = false;
            this.dtNgayGui.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayGui.Location = new System.Drawing.Point(657, 126);
            this.dtNgayGui.Name = "dtNgayGui";
            this.dtNgayGui.Size = new System.Drawing.Size(85, 20);
            this.dtNgayGui.TabIndex = 59;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(468, 285);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(82, 46);
            this.btnLuu.TabIndex = 58;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(794, 285);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 46);
            this.btnThoat.TabIndex = 57;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(684, 285);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(80, 46);
            this.btnXoa.TabIndex = 56;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(575, 285);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(85, 46);
            this.btnSua.TabIndex = 55;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(349, 285);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(86, 46);
            this.btnThem.TabIndex = 54;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // lblTenNV
            // 
            this.lblTenNV.AutoSize = true;
            this.lblTenNV.Enabled = false;
            this.lblTenNV.Location = new System.Drawing.Point(166, 152);
            this.lblTenNV.Name = "lblTenNV";
            this.lblTenNV.Size = new System.Drawing.Size(79, 13);
            this.lblTenNV.TabIndex = 53;
            this.lblTenNV.Text = "Tên Nhân Viên";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Enabled = false;
            this.txtMaNV.Location = new System.Drawing.Point(169, 126);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(100, 20);
            this.txtMaNV.TabIndex = 52;
            // 
            // lblMaNV
            // 
            this.lblMaNV.AutoSize = true;
            this.lblMaNV.Location = new System.Drawing.Point(81, 129);
            this.lblMaNV.Name = "lblMaNV";
            this.lblMaNV.Size = new System.Drawing.Size(75, 13);
            this.lblMaNV.TabIndex = 51;
            this.lblMaNV.Text = "Mã Nhân Viên";
            // 
            // dgvSendRQ
            // 
            this.dgvSendRQ.AllowUserToAddRows = false;
            this.dgvSendRQ.AllowUserToDeleteRows = false;
            this.dgvSendRQ.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSendRQ.Location = new System.Drawing.Point(330, 152);
            this.dgvSendRQ.Name = "dgvSendRQ";
            this.dgvSendRQ.ReadOnly = true;
            this.dgvSendRQ.Size = new System.Drawing.Size(428, 127);
            this.dgvSendRQ.TabIndex = 50;
            // 
            // txtTenRQ
            // 
            this.txtTenRQ.Location = new System.Drawing.Point(397, 87);
            this.txtTenRQ.Name = "txtTenRQ";
            this.txtTenRQ.Size = new System.Drawing.Size(141, 20);
            this.txtTenRQ.TabIndex = 49;
            // 
            // txtMaRQ
            // 
            this.txtMaRQ.Location = new System.Drawing.Point(169, 87);
            this.txtMaRQ.Name = "txtMaRQ";
            this.txtMaRQ.Size = new System.Drawing.Size(100, 20);
            this.txtMaRQ.TabIndex = 48;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(319, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 47;
            this.label2.Text = "Tên Request";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 46;
            this.label1.Text = "Mã Request";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(169, 51);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 76;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 75;
            this.label4.Text = "Request ID Make";
            // 
            // FMakeRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 353);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtSearch);
            this.Controls.Add(this.radioButton1);
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
            this.Name = "FMakeRequest";
            this.Text = "FMakeRequest";
            ((System.ComponentModel.ISupportInitialize)(this.picChuKy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSendRQ)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtSearch;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox picChuKy;
        private System.Windows.Forms.TextBox txtNoiDungCT;
        private System.Windows.Forms.Label lblNoiDungCT;
        private System.Windows.Forms.Label lblTenLoaiYC;
        private System.Windows.Forms.ComboBox cboMaLoaiYC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaPB;
        private System.Windows.Forms.Label lblMaPB;
        private System.Windows.Forms.Label lblThoiGianGui;
        private System.Windows.Forms.Label lblNgayGui;
        private System.Windows.Forms.DateTimePicker dtNgayGui;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label lblTenNV;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label lblMaNV;
        private System.Windows.Forms.DataGridView dgvSendRQ;
        private System.Windows.Forms.TextBox txtTenRQ;
        private System.Windows.Forms.TextBox txtMaRQ;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
    }
}