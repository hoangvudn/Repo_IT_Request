namespace WindowsFormsApplication1
{
    partial class FrmChucDanh
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
            this.dgvChucDanh = new System.Windows.Forms.DataGridView();
            this.btnLuu = new System.Windows.Forms.Button();
            this.lblThongTinCD = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMaBP = new System.Windows.Forms.Label();
            this.txtTenCD = new System.Windows.Forms.TextBox();
            this.txtMaCD = new System.Windows.Forms.TextBox();
            this.lblTenCD = new System.Windows.Forms.Label();
            this.lblMaCD = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChucDanh)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvChucDanh
            // 
            this.dgvChucDanh.AllowUserToAddRows = false;
            this.dgvChucDanh.AllowUserToDeleteRows = false;
            this.dgvChucDanh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChucDanh.Location = new System.Drawing.Point(367, 52);
            this.dgvChucDanh.Name = "dgvChucDanh";
            this.dgvChucDanh.ReadOnly = true;
            this.dgvChucDanh.Size = new System.Drawing.Size(253, 94);
            this.dgvChucDanh.TabIndex = 25;
            this.dgvChucDanh.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChucDanh_CellContentClick);
            this.dgvChucDanh.Click += new System.EventHandler(this.dgvChucDanh_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(286, 152);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 46);
            this.btnLuu.TabIndex = 24;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // lblThongTinCD
            // 
            this.lblThongTinCD.AutoSize = true;
            this.lblThongTinCD.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongTinCD.Location = new System.Drawing.Point(257, 18);
            this.lblThongTinCD.Name = "lblThongTinCD";
            this.lblThongTinCD.Size = new System.Drawing.Size(183, 22);
            this.lblThongTinCD.TabIndex = 23;
            this.lblThongTinCD.Text = "Thông Tin Chức Danh";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(545, 152);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 46);
            this.btnThoat.TabIndex = 22;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(459, 152);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 46);
            this.btnXoa.TabIndex = 21;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(374, 152);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 46);
            this.btnSua.TabIndex = 20;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(198, 152);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 46);
            this.btnThem.TabIndex = 19;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-147, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Tên Phòng Ban";
            // 
            // lblMaBP
            // 
            this.lblMaBP.AutoSize = true;
            this.lblMaBP.Location = new System.Drawing.Point(-147, 106);
            this.lblMaBP.Name = "lblMaBP";
            this.lblMaBP.Size = new System.Drawing.Size(78, 13);
            this.lblMaBP.TabIndex = 17;
            this.lblMaBP.Text = "Mã Phòng Ban";
            // 
            // txtTenCD
            // 
            this.txtTenCD.Location = new System.Drawing.Point(126, 126);
            this.txtTenCD.Name = "txtTenCD";
            this.txtTenCD.Size = new System.Drawing.Size(235, 20);
            this.txtTenCD.TabIndex = 16;
            // 
            // txtMaCD
            // 
            this.txtMaCD.Location = new System.Drawing.Point(126, 77);
            this.txtMaCD.Name = "txtMaCD";
            this.txtMaCD.Size = new System.Drawing.Size(125, 20);
            this.txtMaCD.TabIndex = 15;
            // 
            // lblTenCD
            // 
            this.lblTenCD.AutoSize = true;
            this.lblTenCD.Location = new System.Drawing.Point(12, 133);
            this.lblTenCD.Name = "lblTenCD";
            this.lblTenCD.Size = new System.Drawing.Size(83, 13);
            this.lblTenCD.TabIndex = 27;
            this.lblTenCD.Text = "Tên Chức Danh";
            // 
            // lblMaCD
            // 
            this.lblMaCD.AutoSize = true;
            this.lblMaCD.Location = new System.Drawing.Point(12, 84);
            this.lblMaCD.Name = "lblMaCD";
            this.lblMaCD.Size = new System.Drawing.Size(79, 13);
            this.lblMaCD.TabIndex = 26;
            this.lblMaCD.Text = "Mã Chức Danh";
            // 
            // FrmChucDanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 201);
            this.Controls.Add(this.lblTenCD);
            this.Controls.Add(this.lblMaCD);
            this.Controls.Add(this.dgvChucDanh);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.lblThongTinCD);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblMaBP);
            this.Controls.Add(this.txtTenCD);
            this.Controls.Add(this.txtMaCD);
            this.Name = "FrmChucDanh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmChucDanh";
            this.Load += new System.EventHandler(this.FrmChucDanh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChucDanh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvChucDanh;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Label lblThongTinCD;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMaBP;
        private System.Windows.Forms.TextBox txtTenCD;
        private System.Windows.Forms.TextBox txtMaCD;
        private System.Windows.Forms.Label lblTenCD;
        private System.Windows.Forms.Label lblMaCD;
    }
}