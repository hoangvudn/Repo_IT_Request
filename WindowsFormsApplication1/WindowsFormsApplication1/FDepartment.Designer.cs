namespace WindowsFormsApplication1
{
    partial class FDepartment
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
            this.components = new System.ComponentModel.Container();
            this.txtMaBP = new System.Windows.Forms.TextBox();
            this.txtTenBP = new System.Windows.Forms.TextBox();
            this.lblMaBP = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.lblThongTinNV = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.dgvPhongBan = new System.Windows.Forms.DataGridView();
            this.pHONGBANBindingSource = new System.Windows.Forms.BindingSource(this.components);
            //this.iT_REQUESTDataSet = new WindowsFormsApplication1.IT_REQUESTDataSet();
           // this.pHONGBANTableAdapter = new WindowsFormsApplication1.IT_REQUESTDataSetTableAdapters.PHONGBANTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhongBan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHONGBANBindingSource)).BeginInit();
           // ((System.ComponentModel.ISupportInitialize)(this.iT_REQUESTDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMaBP
            // 
            this.txtMaBP.Location = new System.Drawing.Point(110, 68);
            this.txtMaBP.Name = "txtMaBP";
            this.txtMaBP.Size = new System.Drawing.Size(125, 20);
            this.txtMaBP.TabIndex = 0;
            // 
            // txtTenBP
            // 
            this.txtTenBP.Location = new System.Drawing.Point(110, 117);
            this.txtTenBP.Name = "txtTenBP";
            this.txtTenBP.Size = new System.Drawing.Size(235, 20);
            this.txtTenBP.TabIndex = 1;
            // 
            // lblMaBP
            // 
            this.lblMaBP.AutoSize = true;
            this.lblMaBP.Location = new System.Drawing.Point(25, 75);
            this.lblMaBP.Name = "lblMaBP";
            this.lblMaBP.Size = new System.Drawing.Size(78, 13);
            this.lblMaBP.TabIndex = 2;
            this.lblMaBP.Text = "Mã Phòng Ban";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên Phòng Ban";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(529, 143);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 46);
            this.btnThoat.TabIndex = 11;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(443, 143);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 46);
            this.btnXoa.TabIndex = 10;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(358, 143);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 46);
            this.btnSua.TabIndex = 9;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(182, 143);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 46);
            this.btnThem.TabIndex = 8;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // lblThongTinNV
            // 
            this.lblThongTinNV.AutoSize = true;
            this.lblThongTinNV.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongTinNV.Location = new System.Drawing.Point(241, 9);
            this.lblThongTinNV.Name = "lblThongTinNV";
            this.lblThongTinNV.Size = new System.Drawing.Size(179, 22);
            this.lblThongTinNV.TabIndex = 12;
            this.lblThongTinNV.Text = "Thông Tin Phòng Ban";
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(270, 143);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 46);
            this.btnLuu.TabIndex = 13;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // dgvPhongBan
            // 
            this.dgvPhongBan.AllowUserToAddRows = false;
            this.dgvPhongBan.AllowUserToDeleteRows = false;
            this.dgvPhongBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhongBan.Location = new System.Drawing.Point(351, 43);
            this.dgvPhongBan.Name = "dgvPhongBan";
            this.dgvPhongBan.ReadOnly = true;
            this.dgvPhongBan.Size = new System.Drawing.Size(253, 94);
            this.dgvPhongBan.TabIndex = 14;
            this.dgvPhongBan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhongBan_CellContentClick);
            this.dgvPhongBan.Click += new System.EventHandler(this.dgvPhongBan_Click);
            // 
            // pHONGBANBindingSource
            // 
            this.pHONGBANBindingSource.DataMember = "PHONGBAN";
            //this.pHONGBANBindingSource.DataSource = this.iT_REQUESTDataSet;
            // 
            // iT_REQUESTDataSet
            // 
           // this.iT_REQUESTDataSet.DataSetName = "IT_REQUESTDataSet";
           // this.iT_REQUESTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pHONGBANTableAdapter
            // 
            //this.pHONGBANTableAdapter.ClearBeforeFill = true;
            // 
            // FDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 195);
            this.Controls.Add(this.dgvPhongBan);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.lblThongTinNV);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblMaBP);
            this.Controls.Add(this.txtTenBP);
            this.Controls.Add(this.txtMaBP);
            this.Name = "FDepartment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FDepartment";
            this.Load += new System.EventHandler(this.FDepartment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhongBan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHONGBANBindingSource)).EndInit();
            //((System.ComponentModel.ISupportInitialize)(this.iT_REQUESTDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMaBP;
        private System.Windows.Forms.TextBox txtTenBP;
        private System.Windows.Forms.Label lblMaBP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label lblThongTinNV;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.DataGridView dgvPhongBan;
        //private IT_REQUESTDataSet iT_REQUESTDataSet;
        private System.Windows.Forms.BindingSource pHONGBANBindingSource;
        //private IT_REQUESTDataSetTableAdapters.PHONGBANTableAdapter pHONGBANTableAdapter;
    }
}