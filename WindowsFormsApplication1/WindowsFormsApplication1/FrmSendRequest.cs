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
    public partial class FrmSendRequest : Form
    {
        public FrmSendRequest()
        {
            InitializeComponent();
        }
        //---------------------------------------Connection String----------------------------------------------
        //SqlConnection con1 = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=IT_REQUEST;Integrated Security=True");
        //SqlConnection con1 = new SqlConnection(@"Data Source=10.65.2.217\SQLEXPRESS;Initial Catalog=IT_REQUEST;Persist Security Info=True;User ID=sa;Password=abc@123");
       //------------------------------------------------------------------------------------------------------- 
        String imgLocation = "";
        SqlDataReader dr;
        //-----------------------------Set Image (Stretch) in column Datagridview--------------------------------
        private void Stretch(object sender, EventArgs e)
        {
            foreach (DataGridViewImageColumn column in
                dgvSendRQ.Columns)
            {
                column.ImageLayout = DataGridViewImageCellLayout.Stretch;
                column.Description = "Stretched";
            }
        }
        //------------------------Display Information RequestSend on DatagridSenRQ-------------------------------
        void DisplayDgvSendRQ()
        {
            if (FrmMain.con1.State == ConnectionState.Closed)
            FrmMain.con1.Open();
            string query = @"Select rqs.RequestID, rqs.RequestName, rqs.MaNV, rqs.MaPB, rqs.NgayGuiYC, rqs.ThoiGian, rqs.MaLoaiYC, rqs.DetailInformation,
             nv.ChuKy From REQUESTSEND rqs, NHANVIEN nv Where rqs.MaNV = nv.MaNV And rqs.MaNV='" + FrmLogin.ID_USER.ToString() + "'";
            SqlCommand cmd = new SqlCommand(query, FrmMain.con1);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            //da.Dispose();
            dgvSendRQ.DataSource = dt;
            FrmMain.con1.Close();
        //-----------------------Setup Name For Columns-------------------------
             dgvSendRQ.Columns[0].HeaderText = "Request ID";
             dgvSendRQ.Columns[1].HeaderText = "Tên Request";
             dgvSendRQ.Columns[2].HeaderText = "Mã nhân viên";
             dgvSendRQ.Columns[3].HeaderText = "Mã Phòng Ban";
             dgvSendRQ.Columns[4].HeaderText = "Ngày Gửi";
             dgvSendRQ.Columns[5].HeaderText = "Thời Gian";
             dgvSendRQ.Columns[6].HeaderText = "Mã Loại Y/C";
             dgvSendRQ.Columns[7].HeaderText = "Chi tiết";
             dgvSendRQ.Columns[8].HeaderText = "Chữ Ký";
             ((DataGridViewImageColumn)dgvSendRQ.Columns[8]).ImageLayout = DataGridViewImageCellLayout.Stretch;//Setup properties Image Layout for Datagridview
            
        }
        //-----------------------------------------------------------------------------------------------------------------
        //---------------------------------------------------------------------------
     
      

        //---------------------------------------------------------------------------
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
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
        //-------------------------------Display ten Nhan Vien-----------------------------------
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
        //-------------------------------------------------------------------------------------------------
        //-------------------------------Display Ma Phong Ban-----------------------------------------------
        void DisplayMaPB()
        {
            string query = "Select * From NHANVIEN Where MaNV='" + FrmLogin.ID_USER.ToString() + "'";
            FrmMain.con1.Open();
            SqlCommand cmd = new SqlCommand(query, FrmMain.con1);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string Sname = dr.GetString(3);
                txtMaPB.Text = Sname;
            }
            FrmMain.con1.Close();
        }
        //-------------------------------------------------------------------------------------------------
        //-------------------------------Fill Ma Loai Yeu Cau----------------------------------------------
        void FillMaLoaiYC()
        {
            string query = "Select * From LOAIYEUCAU";
            FrmMain.con1.Open();
            SqlCommand cmd = new SqlCommand(query, FrmMain.con1);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string Sname = dr.GetString(0);
                cboMaLoaiYC.Items.Add(Sname);
            }
            FrmMain.con1.Close();
        }
        //-------------------------------------------------------------------------------------------------
        //----------------------------------Display Ten Loai Yeu Cau---------------------------------------
        void DisplayTenLoaiYC()
        {
            string query = "Select * From LOAIYEUCAU Where MaLoaiYC='" + cboMaLoaiYC.Text + "'";
            FrmMain.con1.Open();
            SqlCommand cmd = new SqlCommand(query, FrmMain.con1);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string Sname = dr.GetString(1);
                lblTenLoaiYC.Text = Sname;
            }
            FrmMain.con1.Close();
        }
        //-------------------------------------------------------------------------------------------------------
        //----------------------------------------FORM LOAD------------------------------------------------------
        private void FrmSendRequest_Load(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnLuu.Enabled = false;
            dtNgayGui.Enabled = true;
            DisplayChuKy();
            DisplayTenNV();
            DisplayMaPB();
            FillMaLoaiYC();
            dtNgayGui.Enabled = false;
            DisplayDgvSendRQ();
            //txtMaRQ.Enabled = false;
          ;
            //-------------------------------------------------------------------------------------------------------

            //-------------------------------------------------------------------------------------------------------
            //-----------------------------Count Rows on Datagrid SenRQ and Set Code for txtMaRQ---------------------
            
            //--------------------------------------------------------------------------------------------------------
            lblThoiGianGui.Text = DateTime.Now.ToString("HH:mm:ss");
            txtMaNV.Text = FrmLogin.ID_USER.ToString();
            //--------------Get Permission From Form Frmlogin---------------Perm is a variable get from database ( Table USER1 )
            int a = Int16.Parse(FrmLogin.Perm.ToString());
            if (a == 0)
            {
                btnLuu.Enabled = true;
                btnThoat.Enabled = true;
                btnXoa.Enabled = true;
            }
            else
            {
                btnLuu.Enabled = false;
                btnLuu.Enabled = false;
                btnXoa.Enabled = false;
            }
        }
        //-----------------------------------------------------------------------------
        private void cboMaLoaiYC_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }
        //--------------------------------EVENT When SelectedValueChanges in cboMaLoaiYC-------------------------------
        private void cboMaLoaiYC_SelectedValueChanged(object sender, EventArgs e)
        {
            DisplayTenLoaiYC();
        }
        //----------------------------------------------------------------------------------------------
        //----------------------Convert Image To Binary-( When choosed image)--------------------------
        public byte[] imageToByte2(byte[] img)
        {
            //byte[] images;
            FileStream Stream = new FileStream(imgLocation, FileMode.Open, FileAccess.ReadWrite);
            BinaryReader brs = new BinaryReader(Stream);
            img = brs.ReadBytes((int)Stream.Length);
            return img;
        }
        //----------------------------------------------------------------------------------------------
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
        //--------------------------Clear Text----------------------------------------------------------
        void ClearText()
        {
            txtTenRQ.Text = "";
            cboMaLoaiYC.Text = "";
            txtNoiDungCT.Text = "";
        }
        //----------------------------------------------------------------------------------------------
        //-----------------------------------SAVE FUNCTION----------------------------------------------
        private void btnLuu_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = true;
            btnLuu.Enabled = true;
            /* int count1 = 0;
             count1 = dgvSendRQ.Rows.Count;
             count1 = count1 + 1;
             txtMaRQ.Text = txtMaNV.Text + count1.ToString();*/
            if ( txtTenRQ.Text == "" || cboMaLoaiYC.Text == "" || txtNoiDungCT.Text == "")
            {
                MessageBox.Show("Input Data, Please");
            }
            else
            {
                DialogResult Dlr = MessageBox.Show("SAVE", "Some Title", MessageBoxButtons.YesNo);
                if (Dlr == DialogResult.Yes)
                {
                    try
                    {
                        //if (picChuKy.Image == null)
                        //{
                            int a = 0;
                            byte[] images = new byte[Convert.ToInt32(a)];
                            string che = @"( SELECT COUNT(*) FROM REQUESTSEND WHERE RequestID='" + txtMaRQ.Text.Trim() + "')";
                            FrmMain.con1.Open();
                            SqlCommand Sqlcmd = new SqlCommand("InsertOrEditRQSend", FrmMain.con1);
                            Sqlcmd.CommandType = CommandType.StoredProcedure;
                            Sqlcmd.Parameters.AddWithValue("@Mode", "New");
                            Sqlcmd.Parameters.AddWithValue("@RequestID", txtMaRQ.Text.Trim());
                            Sqlcmd.Parameters.AddWithValue("@RequestName", txtTenRQ.Text.Trim());
                            Sqlcmd.Parameters.AddWithValue("@MaNV", txtMaNV.Text.Trim());
                            Sqlcmd.Parameters.AddWithValue("@MaPB", txtMaPB.Text.Trim());
                            Sqlcmd.Parameters.AddWithValue("@NgayGuiYC", dtNgayGui.Value.Date);
                            Sqlcmd.Parameters.AddWithValue("@ThoiGian", DateTime.Now.ToString("HH:mm:ss"));
                            Sqlcmd.Parameters.AddWithValue("@MaLoaiYC", cboMaLoaiYC.Text.Trim());
                            Sqlcmd.Parameters.AddWithValue("@Detail", txtNoiDungCT.Text.Trim());
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
                                DisplayDgvSendRQ();
                            }
                            FrmMain.con1.Close();
                        /*}
                        else
                        {
                            //MessageBox.Show("Da co Image");
                            byte[] images = imgToByteArray(picChuKy.Image);
                            string che = @"( SELECT COUNT(*) FROM REQUESTSEND WHERE RequestID='" + txtMaRQ.Text + "')";
                            FrmMain.con1.Open();
                            SqlCommand Sqlcmd = new SqlCommand("InsertOrEditRQSend", FrmMain.con1);
                            Sqlcmd.CommandType = CommandType.StoredProcedure;
                            Sqlcmd.Parameters.AddWithValue("@Mode", "New");
                            Sqlcmd.Parameters.AddWithValue("@RequestID", txtMaRQ.Text.Trim());
                            Sqlcmd.Parameters.AddWithValue("@RequestName", txtTenRQ.Text.Trim());
                            Sqlcmd.Parameters.AddWithValue("@MaNV", txtMaNV.Text.Trim());
                            Sqlcmd.Parameters.AddWithValue("@MaPB", txtMaPB.Text.Trim());
                            Sqlcmd.Parameters.AddWithValue("@NgayGuiYC", dtNgayGui.Value.Date);
                            Sqlcmd.Parameters.AddWithValue("@ThoiGian", DateTime.Now.ToString("HH:mm:ss"));
                            Sqlcmd.Parameters.AddWithValue("@MaLoaiYC", cboMaLoaiYC.Text.Trim());
                            Sqlcmd.Parameters.AddWithValue("@Detail", txtNoiDungCT.Text.Trim());
                            //Sqlcmd.Parameters.AddWithValue("@ChuKy", images);// Error 'Empty.......' This error because file image.
                            SqlCommand cmda = new SqlCommand(che, FrmMain.con1);
                            int count = (int)cmda.ExecuteScalar();
                            if (count > 0)
                            {
                                MessageBox.Show("ID alreaday exist");
                            }
                            else
                            {
                                Sqlcmd.ExecuteNonQuery();
                                MessageBox.Show("INSERTED SUCCESSFULLY !!!!!");
                                DisplayDgvSendRQ();
                            }
                            FrmMain.con1.Close();
                        }*/
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
        }
        //-----------------------------------------------------------------------------------------------------
        //------------------------------EDIT FUNCTION----------------------------------------------------------
        private void btnSua_Click(object sender, EventArgs e)
        {
            DialogResult Dlr = MessageBox.Show("Do you want Update?", "UPDATE", MessageBoxButtons.YesNo);
            if (Dlr == DialogResult.Yes)
            {
                try
                {
                    FrmMain.con1.Open();
                    //byte[] images = null;
                    //images = imgToByteArray(picChuKy.Image);
                    SqlCommand Sqlcmd = new SqlCommand("InsertOrEditRQSend", FrmMain.con1);
                    Sqlcmd.CommandType = CommandType.StoredProcedure;
                    Sqlcmd.Parameters.AddWithValue("@Mode", "Edit");
                    Sqlcmd.Parameters.AddWithValue("@RequestID", txtMaRQ.Text.Trim());
                    Sqlcmd.Parameters.AddWithValue("@RequestName", txtTenRQ.Text.Trim());
                    Sqlcmd.Parameters.AddWithValue("@MaNV", txtMaNV.Text.Trim());
                    Sqlcmd.Parameters.AddWithValue("@MaPB", txtMaPB.Text.Trim());
                    Sqlcmd.Parameters.AddWithValue("@NgayGuiYC", dtNgayGui.Value.Date);
                    Sqlcmd.Parameters.AddWithValue("@ThoiGian", DateTime.Now.ToString("HH:mm:ss"));
                    Sqlcmd.Parameters.AddWithValue("@MaLoaiYC", cboMaLoaiYC.Text.Trim());
                    Sqlcmd.Parameters.AddWithValue("@Detail", txtNoiDungCT.Text.Trim());
                    //Sqlcmd.Parameters.AddWithValue("@ChuKy", images);
                    Sqlcmd.ExecuteNonQuery();
                    MessageBox.Show("UPDATED SUCCESSFULLY!!!!!");
                    DisplayDgvSendRQ();
                    FrmMain.con1.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Warning ERROR -- Primary KEY!!!!!");
                }
                finally
                {
                    if (FrmMain.con1.State == ConnectionState.Open)
                        FrmMain.con1.Close();
                }
            }
        }
        //-----------------------------------------------------------------------------------------------------
        //--------------------------------------DELETE FUNCTION------------------------------------------------
        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult Dlr = MessageBox.Show("Do you want Delete", "Delete", MessageBoxButtons.YesNo);
            if (Dlr == DialogResult.Yes)
            {
                try
                {
                    FrmMain.con1.Open();
                    SqlCommand Sqlcmd = new SqlCommand("DeleteSendRQ", FrmMain.con1);
                    Sqlcmd.CommandType = CommandType.StoredProcedure;
                    Sqlcmd.Parameters.AddWithValue("@RequestID", txtMaRQ.Text.Trim());
                    Sqlcmd.ExecuteNonQuery();
                    MessageBox.Show("Deleted Successfully!!!!!");
                    DisplayDgvSendRQ();
                    //ClearText();
                    FrmMain.con1.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Warnig! Ma Request already exits on Another Table!!!!");
                }
                finally
                {
                    if (FrmMain.con1.State == ConnectionState.Open)
                        FrmMain.con1.Close();
                }
            }
        }
        //------------------------------EVENT When click on Datagridview---------------------------
        private void dgvSendRQ_Click(object sender, EventArgs e)
        {
            btnXoa.Enabled = false;
            btnSua.Enabled = true;
           try
           {
               if (dgvSendRQ.CurrentRow.Index != -1)
               {
                   txtMaRQ.Text = dgvSendRQ.CurrentRow.Cells[0].Value.ToString();
                   txtTenRQ.Text = dgvSendRQ.CurrentRow.Cells[1].Value.ToString();
                   txtMaNV.Text = dgvSendRQ.CurrentRow.Cells[2].Value.ToString();
                   txtMaPB.Text = dgvSendRQ.CurrentRow.Cells[3].Value.ToString();
                   dtNgayGui.Text = dgvSendRQ.CurrentRow.Cells[4].Value.ToString();
                   lblThoiGianGui.Text = dgvSendRQ.CurrentRow.Cells[5].Value.ToString();
                   cboMaLoaiYC.Text = dgvSendRQ.CurrentRow.Cells[6].Value.ToString();
                   txtNoiDungCT.Text = dgvSendRQ.CurrentRow.Cells[7].Value.ToString();
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
            catch(Exception )
           {
               MessageBox.Show("No Record!!!!!");
           }

        }
        //-----------------------------------------------------------------------------------------------------
        private void dgvSendRQ_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //-------------------------------------------------------------------
        //-----------------ADD FUNCTION--------------------------------------
        private void btnThem_Click(object sender, EventArgs e)
        {
            ClearText();
            btnThem.Enabled = false;
            btnLuu.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            lblThoiGianGui.Text = DateTime.Now.ToString("HH:mm:ss");
            dtNgayGui.Text = DateTime.Now.ToString();
            int count1 = 0;
            count1 = dgvSendRQ.Rows.Count;
            count1 = count1 + 1;
            txtMaRQ.Text = FrmLogin.ID_USER.ToString().Trim() + count1.ToString().Trim();
         }
        //-----------------------------------------------------------------------------------------------------
        //----------------------------SEARCH FUNCTION----------------------------------------------------------
        void FillDataGridView()
        {
            if (FrmMain.con1.State == ConnectionState.Closed)
                FrmMain.con1.Open();

            SqlDataAdapter sqlDa = new SqlDataAdapter("ViewSendRQ", FrmMain.con1);
            sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
            sqlDa.SelectCommand.Parameters.AddWithValue("@RequestID", txtFind.Text.Trim());
            sqlDa.SelectCommand.Parameters.AddWithValue("@RequestName", txtFind.Text.Trim());
            sqlDa.SelectCommand.Parameters.AddWithValue("@MaLoaiYC", txtFind.Text.Trim());
            sqlDa.SelectCommand.Parameters.AddWithValue("@MaNV", txtMaNV.Text.Trim());
            sqlDa.SelectCommand.Parameters.AddWithValue("@Detail", txtFind.Text.Trim());
            
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);
            dgvSendRQ.DataSource = dtbl;
            FrmMain.con1.Close();
        }
        //-------------------------------------------------------------------------------------
        //--------------------SEARCH by DATE---------------------------------------------------
        void FillDataGridViewDATE()
        {
            if (FrmMain.con1.State == ConnectionState.Closed)
                FrmMain.con1.Open();

            SqlDataAdapter sqlDa = new SqlDataAdapter("ViewSendRQDate", FrmMain.con1);
            sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
            sqlDa.SelectCommand.Parameters.AddWithValue("@NgayGui", dtSearch.Value.Date);
            sqlDa.SelectCommand.Parameters.AddWithValue("@MaNV", txtMaNV.Text.Trim());
    
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);
            dgvSendRQ.DataSource = dtbl;
            FrmMain.con1.Close();
        }
        //-------------------------------------------------------------------------------------
        //----------------------------------SEARCH FUNCTION------------------------------------
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if(rdBSearch.Checked==true)
                {
                    FillDataGridViewDATE();
                }
                else
                {
                    FillDataGridView();
                }
                if (dgvSendRQ.CurrentRow.Index != -1)
                {
                    txtMaRQ.Text = dgvSendRQ.CurrentRow.Cells[0].Value.ToString();
                    txtTenRQ.Text = dgvSendRQ.CurrentRow.Cells[1].Value.ToString();
                    txtMaNV.Text = dgvSendRQ.CurrentRow.Cells[2].Value.ToString();
                    txtMaPB.Text = dgvSendRQ.CurrentRow.Cells[3].Value.ToString();
                    dtNgayGui.Text = dgvSendRQ.CurrentRow.Cells[4].Value.ToString();
                    lblThoiGianGui.Text = dgvSendRQ.CurrentRow.Cells[5].Value.ToString();
                    cboMaLoaiYC.Text = dgvSendRQ.CurrentRow.Cells[6].Value.ToString();
                    txtNoiDungCT.Text = dgvSendRQ.CurrentRow.Cells[7].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                 MessageBox.Show( ex.Message);
            }
            FrmMain.con1.Close();
            rdBSearch.Checked = false;
            txtFind.Enabled = true;
        }
        //----------------------------------------------------------------------------------------------
        private void rdBSearch_Click(object sender, EventArgs e)
        {
            txtFind.Enabled = false;

        }
        //---------------------------------------------------------------------------------------
        private void txtFind_Click(object sender, EventArgs e)
        {
            rdBSearch.Checked = false;
            txtFind.Enabled = true;
        }

        private void cboMaLoaiYC_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
       //-----------------------------------------------------------------------------------------------------
    }
}
