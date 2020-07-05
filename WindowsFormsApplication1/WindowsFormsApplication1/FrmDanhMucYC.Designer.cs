namespace WindowsFormsApplication1
{
    partial class FrmDanhMucYC
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
            this.lblTenCD = new System.Windows.Forms.Label();
            this.lblMaCD = new System.Windows.Forms.Label();
            this.dgvYeuCau = new System.Windows.Forms.DataGridView();
            this.btnLuu = new System.Windows.Forms.Button();
            this.lblDanhMucYC = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtTenYC = new System.Windows.Forms.TextBox();
            this.txtMaYC = new System.Windows.Forms.TextBox();
            this.lblTenYC = new System.Windows.Forms.Label();
            this.lblMaYC = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvYeuCau)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTenCD
            // 
            this.lblTenCD.AutoSize = true;
            this.lblTenCD.Location = new System.Drawing.Point(-162, 155);
            this.lblTenCD.Name = "lblTenCD";
            this.lblTenCD.Size = new System.Drawing.Size(83, 13);
            this.lblTenCD.TabIndex = 38;
            this.lblTenCD.Text = "Tên Chức Danh";
            // 
            // lblMaCD
            // 
            this.lblMaCD.AutoSize = true;
            this.lblMaCD.Location = new System.Drawing.Point(-162, 106);
            this.lblMaCD.Name = "lblMaCD";
            this.lblMaCD.Size = new System.Drawing.Size(79, 13);
            this.lblMaCD.TabIndex = 37;
            this.lblMaCD.Text = "Mã Chức Danh";
            // 
            // dgvYeuCau
            // 
            this.dgvYeuCau.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvYeuCau.Location = new System.Drawing.Point(352, 66);
            this.dgvYeuCau.Name = "dgvYeuCau";
            this.dgvYeuCau.Size = new System.Drawing.Size(276, 94);
            this.dgvYeuCau.TabIndex = 36;
            this.dgvYeuCau.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvYeuCau_CellContentClick);
            this.dgvYeuCau.Click += new System.EventHandler(this.dgvYeuCau_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(294, 166);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 46);
            this.btnLuu.TabIndex = 35;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // lblDanhMucYC
            // 
            this.lblDanhMucYC.AutoSize = true;
            this.lblDanhMucYC.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDanhMucYC.Location = new System.Drawing.Point(249, 19);
            this.lblDanhMucYC.Name = "lblDanhMucYC";
            this.lblDanhMucYC.Size = new System.Drawing.Size(163, 22);
            this.lblDanhMucYC.TabIndex = 34;
            this.lblDanhMucYC.Text = "Danh Mục Yêu Cầu";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(553, 166);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 46);
            this.btnThoat.TabIndex = 33;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(467, 166);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 46);
            this.btnXoa.TabIndex = 32;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(382, 166);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 46);
            this.btnSua.TabIndex = 31;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(206, 166);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 46);
            this.btnThem.TabIndex = 30;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtTenYC
            // 
            this.txtTenYC.Location = new System.Drawing.Point(111, 140);
            this.txtTenYC.Name = "txtTenYC";
            this.txtTenYC.Size = new System.Drawing.Size(235, 20);
            this.txtTenYC.TabIndex = 29;
            // 
            // txtMaYC
            // 
            this.txtMaYC.Location = new System.Drawing.Point(111, 91);
            this.txtMaYC.Name = "txtMaYC";
            this.txtMaYC.Size = new System.Drawing.Size(125, 20);
            this.txtMaYC.TabIndex = 28;
            // 
            // lblTenYC
            // 
            this.lblTenYC.AutoSize = true;
            this.lblTenYC.Location = new System.Drawing.Point(12, 147);
            this.lblTenYC.Name = "lblTenYC";
            this.lblTenYC.Size = new System.Drawing.Size(70, 13);
            this.lblTenYC.TabIndex = 40;
            this.lblTenYC.Text = "Tên Yêu Cầu";
            // 
            // lblMaYC
            // 
            this.lblMaYC.AutoSize = true;
            this.lblMaYC.Location = new System.Drawing.Point(12, 98);
            this.lblMaYC.Name = "lblMaYC";
            this.lblMaYC.Size = new System.Drawing.Size(66, 13);
            this.lblMaYC.TabIndex = 39;
            this.lblMaYC.Text = "Mã Yêu Cầu";
            // 
            // FrmDanhMucYC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 215);
            this.Controls.Add(this.lblTenYC);
            this.Controls.Add(this.lblMaYC);
            this.Controls.Add(this.lblTenCD);
            this.Controls.Add(this.lblMaCD);
            this.Controls.Add(this.dgvYeuCau);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.lblDanhMucYC);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtTenYC);
            this.Controls.Add(this.txtMaYC);
            this.Name = "FrmDanhMucYC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmDanhMucYC";
            this.Load += new System.EventHandler(this.FrmDanhMucYC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvYeuCau)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTenCD;
        private System.Windows.Forms.Label lblMaCD;
        private System.Windows.Forms.DataGridView dgvYeuCau;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Label lblDanhMucYC;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtTenYC;
        private System.Windows.Forms.TextBox txtMaYC;
        private System.Windows.Forms.Label lblTenYC;
        private System.Windows.Forms.Label lblMaYC;
    }
}