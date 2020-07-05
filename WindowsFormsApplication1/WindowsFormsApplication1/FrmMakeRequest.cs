using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class FrmMakeRequest : Form
    {
        public FrmMakeRequest()
        {
            InitializeComponent();
        }
        //SqlConnection con1 = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=IT_REQUEST;Integrated Security=True");
        //SqlConnection con1 = new SqlConnection(@"Data Source=10.65.2.217\SQLEXPRESS;Initial Catalog=IT_REQUEST;Persist Security Info=True;User ID=sa;Password=abc@123");
        SqlDataReader dr;
        //-------------------------------------FILL ID Send Request-------------------------
        void FillIDSendRequest()
        {
            string query = "Select * From REQUESTSEND Where MaPB='"+cboPhongBan.Text.Trim()+"'";
            FrmMain.con1.Open();
            SqlCommand cmd = new SqlCommand(query, FrmMain.con1);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string Sname = dr.GetString(0);
                cboIDSRQ.Items.Add(Sname);
            }
            FrmMain.con1.Close();
        }
        //-------------------------------------------------------------------------------------------------
        //----------------------------------Fill Ma Phong Ban----------------------------------------------
        void FillMaPB()
        {
            string query = "Select * From PHONGBAN";
            FrmMain.con1.Open();
            SqlCommand cmd = new SqlCommand(query, FrmMain.con1);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string Sname = dr.GetString(0);
                cboPhongBan.Items.Add(Sname);
            }
            FrmMain.con1.Close();
        }
        //-------------------------------------------------------------------------------------------------
        //---------------------------------Display Ten Nhan Vien-------------------------------------------
        void DisplayTenNV()
        {
            string query = "Select * From NHANVIEN Where MaNV='" + FrmLogin.ID_USER.ToString() + "'";
            FrmMain.con1.Open();
            SqlCommand cmd = new SqlCommand(query, FrmMain.con1);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string Sname = dr.GetString(1);
                lblTenNV.Text = Sname;
            }
            FrmMain.con1.Close();
        }
        //------------------------------------------------------------------------------------
        //--------------------------Display Chu Ky ----------------------------------------
        void DisplayChuKy()
        {
            string query = "Select * From NHANVIEN Where MaNV='" + FrmLogin.ID_USER.ToString() + "'";
            FrmMain.con1.Open();
            SqlCommand cmd = new SqlCommand(query, FrmMain.con1);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                byte[] img = new byte[0];
                img = (Byte[])(dr["ChuKy"]);
                MemoryStream stream = new MemoryStream(img);
                picChuKy.Image = Image.FromStream(stream);
            }
            FrmMain.con1.Close();
        }
        //---------------------------------------------------------------------------------------
        //---------------------------------Convert Image To Binary Standard (When image in picturebox get from database and not choose from dialog )-----------------------------
        public byte[] imgToByteArray(Image img)
        {
            using (MemoryStream mStream = new MemoryStream())
            {
                img.Save(mStream, img.RawFormat);
                return mStream.ToArray();
            }
        }
        //----------------------------------------------------------------------------------------------
        //------------------------Display Information RequestSend on DatagridSenRQ-------------------------------
        void DisplayDgvSendRQ()
        {
            if (FrmMain.con1.State == ConnectionState.Closed)
                FrmMain.con1.Open();
            string query = @"Select rqs.RequestID, rqs.RequestName, rqs.MaNV, rqs.MaPB, rqs.NgayGuiYC, rqs.ThoiGian, rqs.MaLoaiYC, rqs.DetailInformation,
             nv.ChuKy From REQUESTSEND rqs, NHANVIEN nv Where rqs.MaNV = nv.MaNV And RequestID='" + txtidSendRq.Text.Trim() + "'";
            SqlCommand cmd = new SqlCommand(query, FrmMain.con1);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvSendRQ.DataSource = dt;
            FrmMain.con1.Close();
            //-----------------------Setup Name For Columns-------------------------
            dgvSendRQ.Columns[0].HeaderText = "ID Request";
            dgvSendRQ.Columns[1].HeaderText = "Tên Request";
            dgvSendRQ.Columns[2].HeaderText = "Mã nhân viên";
            dgvSendRQ.Columns[3].HeaderText = "Mã Phòng Ban";
            dgvSendRQ.Columns[4].HeaderText = "Ngày Gửi";
            dgvSendRQ.Columns[5].HeaderText = "Thời Gian";
            dgvSendRQ.Columns[6].HeaderText = "Mã Loại Y/C";
            dgvSendRQ.Columns[7].HeaderText = "Chi tiết";
            dgvSendRQ.Columns[8].HeaderText = "Chữ Ký";
            ((DataGridViewImageColumn)dgvSendRQ.Columns[8]).ImageLayout = DataGridViewImageCellLayout.Stretch;//Setup properties Image Layout for Datagridview
            //for (int i = 0; i < dgvSendRQ.Columns.Count; i++)
            //if (dgvSendRQ.Columns[i] is DataGridViewImageColumn)
            // {
            //   ((DataGridViewImageColumn)dgvSendRQ.Columns[i]).ImageLayout = DataGridViewImageCellLayout.Stretch;
            //   break;
            //}
        }
        //-----------------------------------------------------------------------------------------------------------------

        //------------------------Display Information Make Request-------------------------------
        void DisplayDgvMakeRQ()
        {
            if (FrmMain.con1.State == ConnectionState.Closed)
                FrmMain.con1.Open();
            string query = @"Select rqm.RequestIDMake, rqm.RequestID, rqm.MaNV, rqm.NgayThucHien, rqm.ThoiGian, rqm.TrangThai, rqm.KetQua,
                           nv.ChuKy From REQUESTMAKE rqm, NHANVIEN nv Where rqm.MaNV = nv.MaNV And rqm.MaNV='" + FrmLogin.ID_USER.ToString() + "'";
            SqlCommand cmd = new SqlCommand(query, FrmMain.con1);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgMakeRQ.DataSource = dt;
            FrmMain.con1.Close();
            //-----------------------Setup Name For Columns-------------------------
            dgMakeRQ.Columns[0].HeaderText = "ID Make Request";
            dgMakeRQ.Columns[1].HeaderText = "Id Send Request";
            dgMakeRQ.Columns[2].HeaderText = "Mã nhân viên";
            dgMakeRQ.Columns[3].HeaderText = "Ngày Thực Hiện ";
            dgMakeRQ.Columns[4].HeaderText = "Thời Gian";
            dgMakeRQ.Columns[5].HeaderText = "Tình Trạng";
            dgMakeRQ.Columns[6].HeaderText = "Kết Quả";
            dgMakeRQ.Columns[7].HeaderText = "Chữ Ký";
            ((DataGridViewImageColumn)dgMakeRQ.Columns[7]).ImageLayout = DataGridViewImageCellLayout.Stretch;//Setup properties Image Layout for Datagridview
            //for (int i = 0; i < dgvSendRQ.Columns.Count; i++)
            //if (dgvSendRQ.Columns[i] is DataGridViewImageColumn)
            // {
            //   ((DataGridViewImageColumn)dgvSendRQ.Columns[i]).ImageLayout = DataGridViewImageCellLayout.Stretch;
            //   break;
            //}
        }
        //-----------------------------------Display Information Send Request--------------------------------------------------------
        void DisplayDgvMakeRQbyIdSendRequest()
        {
            if (FrmMain.con1.State == ConnectionState.Closed)
                FrmMain.con1.Open();
            string query = @"Select rqm.RequestIDMake, rqm.RequestID, rqm.MaNV, rqm.NgayThucHien, rqm.ThoiGian, rqm.TrangThai, rqm.KetQua,
                           nv.ChuKy From REQUESTMAKE rqm, NHANVIEN nv Where rqm.MaNV = nv.MaNV and RequestID='" + txtFindMRQ.Text.Trim() + "'";
            SqlCommand cmd = new SqlCommand(query, FrmMain.con1);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgMakeRQ.DataSource = dt;
            FrmMain.con1.Close();
            //-----------------------Setup Name For Columns-------------------------
            dgMakeRQ.Columns[0].HeaderText = "ID Make Request";
            dgMakeRQ.Columns[1].HeaderText = "Id Send Request";
            dgMakeRQ.Columns[2].HeaderText = "Mã nhân viên";
            dgMakeRQ.Columns[3].HeaderText = "Ngày Thực Hiện ";
            dgMakeRQ.Columns[4].HeaderText = "Thời Gian";
            dgMakeRQ.Columns[5].HeaderText = "Tình Trạng";
            dgMakeRQ.Columns[6].HeaderText = "Kết Quả";
            dgMakeRQ.Columns[7].HeaderText = "Chữ Ký";
            ((DataGridViewImageColumn)dgMakeRQ.Columns[7]).ImageLayout = DataGridViewImageCellLayout.Stretch;//Setup properties Image Layout for Datagridview
            //for (int i = 0; i < dgvSendRQ.Columns.Count; i++)
            //if (dgvSendRQ.Columns[i] is DataGridViewImageColumn)
            // {
            //   ((DataGridViewImageColumn)dgvSendRQ.Columns[i]).ImageLayout = DataGridViewImageCellLayout.Stretch;
            //   break;
            //}
        }
        //-----------------------------------------------------------------------------------------------------------------

        //----------------------------------------------------------------------------------------------
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
        //-------------------------------------------------------------------------------------
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        //-------------------------------------------------------
        private void FrmMakeRequest_Load(object sender, EventArgs e)
        {
            Int16 a;
            a = FrmLogin.Perm;
            if (a==1)
            {
                btnXoa.Enabled = false;
            }
            
            FillIDSendRequest();
            DisplayDgvMakeRQ();
            DisplayChuKy();
            FillMaPB();
            DisplayTenNV();
            lblTenNV.Enabled = false;
            lblThoiGianTH.Text = DateTime.Now.ToString("HH:mm:ss");
            txtMaNV.Text = FrmLogin.ID_USER.ToString();
            txtMaNV.Enabled = false;
        }
        //---------------------------------------------------------------------------------
        //-------------------------------SAVE FUNCTION-------------------------------------
        private void btnLuu_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = true;
            btnLuu.Enabled = true;
            //--------------------------------------------------------------------------------------------------------------------
            //if (cboIDSRQ.Text == "" || txtKQTH.Text == "")
            //{
               // MessageBox.Show("Input Data, Please");
            //}
           // else
           // {
                DialogResult Dlr = MessageBox.Show("SAVE", "Some Title", MessageBoxButtons.YesNo);
                if (Dlr == DialogResult.Yes)
                {
                    try
                    {
                        if (picChuKy.Image == null)
                        {
                            int a = 0;
                            byte[] images = new byte[Convert.ToInt32(a)];
                            string che = @"( SELECT COUNT(*) FROM REQUESTMAKE WHERE  RequestID='" + txtidSendRq.Text.Trim() + "')";
                            FrmMain.con1.Open();
                            SqlCommand Sqlcmd = new SqlCommand("InsertOrEditRQMake", FrmMain.con1);
                            Sqlcmd.CommandType = CommandType.StoredProcedure;
                            Sqlcmd.Parameters.AddWithValue("@Mode", "New");
                            Sqlcmd.Parameters.AddWithValue("@RequestIDMake", txtIDMRQ.Text.Trim());
                            Sqlcmd.Parameters.AddWithValue("@RequestID", txtidSendRq.Text.Trim());
                            Sqlcmd.Parameters.AddWithValue("@MaNV", txtMaNV.Text.Trim());
                            Sqlcmd.Parameters.AddWithValue("@NgayThucHien", dtNgayThucHien.Value.Date);
                            Sqlcmd.Parameters.AddWithValue("@ThoiGian", DateTime.Now.ToString("HH:mm:ss"));
                            if (ckbStatus.Checked == true)
                            {
                                Sqlcmd.Parameters.AddWithValue("@Status", 1);
                            }
                            else
                            {
                                Sqlcmd.Parameters.AddWithValue("@Status", 0);
                            }
                            Sqlcmd.Parameters.AddWithValue("@Ketqua", txtKQTH.Text.Trim());
                            //Sqlcmd.Parameters.AddWithValue("@ChuKy", images);
                            SqlCommand cmda = new SqlCommand(che, FrmMain.con1);
                            int count = (int)cmda.ExecuteScalar();
                            if (count > 0)
                            {
                                MessageBox.Show("ID already exist");
                                btnLuu.Enabled = true;
                                btnThem.Enabled = false;
                            }
                            else
                            {
                                Sqlcmd.ExecuteNonQuery();
                                MessageBox.Show("INSERTED SUCCESSFULLY !!!!!");
                                DisplayDgvMakeRQ();
                            }
                            FrmMain.con1.Close();
                        }
                        else
                        {
                            //MessageBox.Show("Da co Image");
                            byte[] images = imgToByteArray(picChuKy.Image);
                            string che = @"( SELECT COUNT(*) FROM REQUESTMAKE WHERE  RequestID='" + txtidSendRq.Text.Trim() + "' )";
                            FrmMain.con1.Open();
                            SqlCommand Sqlcmd = new SqlCommand("InsertOrEditRQMake", FrmMain.con1);
                            Sqlcmd.CommandType = CommandType.StoredProcedure;
                            Sqlcmd.Parameters.AddWithValue("@Mode", "New");
                            Sqlcmd.Parameters.AddWithValue("@RequestIDMake", txtIDMRQ.Text.Trim());
                            Sqlcmd.Parameters.AddWithValue("@RequestID", txtidSendRq.Text.Trim());
                            Sqlcmd.Parameters.AddWithValue("@MaNV", txtMaNV.Text.Trim());
                            Sqlcmd.Parameters.AddWithValue("@NgayThucHien", dtNgayThucHien.Value.Date);
                            Sqlcmd.Parameters.AddWithValue("@ThoiGian", DateTime.Now.ToString("HH:mm:ss"));
                            if (ckbStatus.Checked == true)
                            {
                                Sqlcmd.Parameters.AddWithValue("@Status", 1);
                            }
                            else
                            {
                                Sqlcmd.Parameters.AddWithValue("@Status", 0);
                            }
                            Sqlcmd.Parameters.AddWithValue("@Ketqua", txtKQTH.Text.Trim());
                            //Sqlcmd.Parameters.AddWithValue("@ChuKy", images);
                            SqlCommand cmda = new SqlCommand(che, FrmMain.con1);
                            int count = (int)cmda.ExecuteScalar();
                            if (count > 0)
                            {
                                MessageBox.Show("ID alreaday exist");
                                btnLuu.Enabled = true;
                                btnThem.Enabled = false;
                            }
                            else
                            {
                                Sqlcmd.ExecuteNonQuery();
                                MessageBox.Show("INSERTED SUCCESSFULLY !!!!!");
                                DisplayDgvMakeRQ();
                            }
                            FrmMain.con1.Close();
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("ID Request Not Exist");
                    }
                    finally
                    {
                        if (FrmMain.con1.State == ConnectionState.Open)
                            FrmMain.con1.Close();
                    }
                }
            //}
        }
        //-----------------------------------------------------------------------------------------------------
        //---------------------------------Clear Text----------------------------------------------------------
        void ClearText()
        {
            txtIDMRQ.Text = "";
            txtKQTH.Text = "";
            cboIDSRQ.Text = "";
            txtidSendRq.Text = "";
            cboPhongBan.Text = "";
        }
        //-----------------------------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------------
        private void btnThem_Click(object sender, EventArgs e)
        {
            ClearText();
            btnThem.Enabled = false;
            btnLuu.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            lblThoiGianTH.Text = DateTime.Now.ToString("HH:mm:ss");
            dtNgayThucHien.Text = DateTime.Now.ToString();
            int count1 = 0;
            count1 = dgMakeRQ.Rows.Count;
            count1 = count1 + 1;
            txtIDMRQ.Text = "M"+FrmLogin.ID_USER.ToString().Trim() + count1.ToString().Trim();
        }
        //---------------------------------------------------------------
        private void cboPhongBan_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
        //---------------------------------------------------------------
        private void cboPhongBan_SelectedValueChanged(object sender, EventArgs e)
        {
            cboIDSRQ.Items.Clear();
            cboIDSRQ.Text = "";
            FillIDSendRequest();
        }
        //--------------------------When CboIDSRQ changed then Display Datagrid view Send Request-----------------------------
        private void cboIDSRQ_SelectedValueChanged(object sender, EventArgs e)
        {
            DisplayDgvSendRQ();
        }
        //-----------------------------------------------------------------------------------------------------------
        private void dgMakeRQ_Click(object sender, EventArgs e)
        {
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            try
            {
                if (dgMakeRQ.CurrentRow.Index != -1)
                {
                    txtIDMRQ.Text = dgMakeRQ.CurrentRow.Cells[0].Value.ToString();
                    txtidSendRq.Text = dgMakeRQ.CurrentRow.Cells[1].Value.ToString();
                    txtMaNV.Text = dgMakeRQ.CurrentRow.Cells[2].Value.ToString();
                    dtNgayThucHien.Text = dgMakeRQ.CurrentRow.Cells[3].Value.ToString();
                    lblThoiGianTH.Text = dgMakeRQ.CurrentRow.Cells[4].Value.ToString();
                    txtKQTH.Text = dgMakeRQ.CurrentRow.Cells[6].Value.ToString();
                    /*byte[] img = (byte[])dgvNhanVien.CurrentRow.Cells[4].Value;
                    if (img.Length == 0)
                    {
                        picNhanVien.Image = null;
                    }
                    else
                    {
                        MemoryStream msStr = new MemoryStream(img);
                        picNhanVien.Image = Image.FromStream(msStr);
                    }*/
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No Record!!!!!");
            }
        }
        //------------------------------------------------------------------------------------------------
        //----------------------------EDIT FUNCTION-------------------------------------------------------
        private void btnSua_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = false;
            DialogResult Dlr = MessageBox.Show("Do you want Update?", "UPDATE", MessageBoxButtons.YesNo);
            if (Dlr == DialogResult.Yes)
            {
                try
                {
                    byte[] images = null;
                    images = imgToByteArray(picChuKy.Image);
                    FrmMain.con1.Open();
                    SqlCommand Sqlcmd = new SqlCommand("InsertOrEditRQMake", FrmMain.con1);
                    Sqlcmd.CommandType = CommandType.StoredProcedure;
                    Sqlcmd.Parameters.AddWithValue("@Mode", "Edit");
                    Sqlcmd.Parameters.AddWithValue("@RequestIDMake", txtIDMRQ.Text.Trim());
                    Sqlcmd.Parameters.AddWithValue("@RequestID", txtidSendRq.Text.Trim());
                    Sqlcmd.Parameters.AddWithValue("@MaNV", txtMaNV.Text.Trim());
                    Sqlcmd.Parameters.AddWithValue("@NgayThucHien", dgMakeRQ.CurrentRow.Cells[3].Value.ToString());
                    Sqlcmd.Parameters.AddWithValue("@ThoiGian",dgMakeRQ.CurrentRow.Cells[4].Value.ToString());
                    if (ckbStatus.Checked == true)
                    {
                        Sqlcmd.Parameters.AddWithValue("@Status", 1);
                    }
                    else
                    {
                        Sqlcmd.Parameters.AddWithValue("@Status", 0);
                    }
                    Sqlcmd.Parameters.AddWithValue("@KetQua", txtKQTH.Text.Trim());
                    Sqlcmd.Parameters.AddWithValue("@ChuKy", images);
                    Sqlcmd.ExecuteNonQuery();
                    MessageBox.Show("UPDATED SUCCESSFULLY!!!!!");
                    DisplayDgvMakeRQ();
                    btnThem.Enabled = true;
                    btnSua.Enabled = false;
                    FrmMain.con1.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    if (FrmMain.con1.State == ConnectionState.Open)
                        FrmMain.con1.Close();
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void cboIDSRQ_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void cboIDSRQ_TextUpdate(object sender, EventArgs e)
        {
            
        }

        private void txtidSendRq_TextChanged(object sender, EventArgs e)
        {
            DisplayDgvSendRQ();
        }

        private void dgMakeRQ_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtFindMRQ_TextChanged(object sender, EventArgs e)
        {
            //DisplayDgvMakeRQbyIdSendRequest();
            if (txtFindMRQ.Text == "")
            {
                DisplayDgvMakeRQ();
            }
            else
            {
                DisplayDgvMakeRQbyIdSendRequest();
            }
        }
        //---------------------------------------------------------------------------------------------------------------
    }
}
