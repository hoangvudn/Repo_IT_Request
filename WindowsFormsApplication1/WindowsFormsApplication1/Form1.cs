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
    public partial class FStaffRequest : Form
    {
        public FStaffRequest()
        {
            InitializeComponent();
           // DisplayListviewNV();
            FillComboBoxCD();
            FillComboBoxPB();
            DisplayDgvNhanVien();
            //DisplayTenCD();
            //DisplayTenPB();
        }
        //SqlConnection con1 = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=IT_REQUEST;Integrated Security=True");
        //SqlConnection con1 = new SqlConnection(@"Data Source=10.65.2.217\SQLEXPRESS;Initial Catalog=IT_REQUEST;Persist Security Info=True;User ID=sa;Password=abc@123");
        String imgLocation = "";
        SqlDataReader dr;
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iT_REQUESTDataSet4.NHANVIEN' table. You can move, or remove it, as needed.
           // this.nHANVIENTableAdapter3.Fill(this.iT_REQUESTDataSet4.NHANVIEN);
            // TODO: This line of code loads data into the 'iT_REQUESTDataSet3.NHANVIEN' table. You can move, or remove it, as needed.
            //this.nHANVIENTableAdapter2.Fill(this.iT_REQUESTDataSet3.NHANVIEN);
            // TODO: This line of code loads data into the 'iT_REQUESTDataSet2.REQUESTMAKE' table. You can move, or remove it, as needed.
            //this.rEQUESTMAKETableAdapter.Fill(this.iT_REQUESTDataSet2.REQUESTMAKE);
            // TODO: This line of code loads data into the 'iT_REQUESTDataSet1.NHANVIEN' table. You can move, or remove it, as needed.
           // this.nHANVIENTableAdapter1.Fill(this.iT_REQUESTDataSet1.NHANVIEN);
           // // TODO: This line of code loads data into the 'iT_REQUESTDataSet.PHONGBAN' table. You can move, or remove it, as needed.
           // this.pHONGBANTableAdapter.Fill(this.iT_REQUESTDataSet.PHONGBAN);
            // TODO: This line of code loads data into the 'iT_REQUESTDataSet.CHUCDANH' table. You can move, or remove it, as needed.
            //this.cHUCDANHTableAdapter.Fill(this.iT_REQUESTDataSet.CHUCDANH);
            // TODO: This line of code loads data into the 'iT_REQUESTDataSet.NHANVIEN' table. You can move, or remove it, as needed.
           // this.nHANVIENTableAdapter.Fill(this.iT_REQUESTDataSet.NHANVIEN);
            DisplayDgvNhanVien();
            btnLuu.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = true;
            
            //lVNhanVien.View = View.Details;
        }
        //--------Display Staff Information on Datagrid View---------
        void DisplayDgvNhanVien()
        {
            if (FrmMain.con1.State == ConnectionState.Closed)
             FrmMain.con1.Open();
             string query = @"Select * From NHANVIEN";
             SqlCommand cmd = new SqlCommand(query, FrmMain.con1);
             cmd.ExecuteNonQuery();
             DataTable dt = new DataTable();
             SqlDataAdapter da = new SqlDataAdapter(cmd);
             da.Fill(dt);
             dgvNhanVien.DataSource = dt;
             FrmMain.con1.Close();
            //-------------------Setup Header Datagridview---------------------------
            dgvNhanVien.Columns[0].HeaderText = "Mã Nhân Viên";
            dgvNhanVien.Columns[1].HeaderText = "Tên Nhân Viên";
            dgvNhanVien.Columns[2].HeaderText = "Mã Chức Danh";
            dgvNhanVien.Columns[3].HeaderText = "Mã Phòng Ban";
            dgvNhanVien.Columns[4].HeaderText = "Chữ Ký";
            ((DataGridViewImageColumn)dgvNhanVien.Columns[4]).ImageLayout = DataGridViewImageCellLayout.Stretch;//Setup properties Image Layout for Datagridvie
            //----------------------------------------------
        }
        //-----------------------------------------------------------
        
        //-------------------Convert Byte To Image-------------------
        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }
        //-----------------------------------------------------------
        //--------Display Staff Information on ListView---------
        void DisplayListviewNV()
        {
            /*con1.Open();
            //SqlDataReader dr;
            string query = @"Select * From NHANVIEN";
            SqlCommand cmd = new SqlCommand(query, con1);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem lv = new ListViewItem(dr[0].ToString());
                lv.SubItems.Add(dr[1].ToString());
                lv.SubItems.Add(dr[2].ToString());
                lv.SubItems.Add(dr[3].ToString());
                lv.SubItems.Add(dr[4].ToString());
                lVNhanVien.Items.Add(lv);
            }
            con1.Close();*/
        }
        //-----------------------------------------------------------
        //-----------Fill data to Combobox CHUC DANH ----------------
        void FillComboBoxCD()
        {
            string query="Select * From CHUCDANH";
            SqlCommand cmd = new SqlCommand(query, FrmMain.con1);
            FrmMain.con1.Open();
            dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                string Sname = dr.GetString(0);
                cboMaCD.Items.Add(Sname);
            }
            FrmMain.con1.Close();
        }
        //------------------------------------------------------------
        //-----------Fill data to Combobox PHONG BAN ----------------
        void FillComboBoxPB()
        {
            string query = "Select * From PHONGBAN";
            SqlCommand cmd = new SqlCommand(query, FrmMain.con1);
            FrmMain.con1.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string Sname = dr.GetString(0);
                cboMaPB.Items.Add(Sname);
            }
            FrmMain.con1.Close();
        }
        //------------------Display Ten Chuc Danh --------------------
        void DisplayTenCD()
        {
            string query = "Select * From CHUCDANH Where MaCD='" + cboMaCD.Text + "'";
            FrmMain.con1.Open();
            SqlCommand cmd = new SqlCommand(query, FrmMain.con1);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string Sname = dr.GetString(1);
                lblTenCD.Text = Sname;
                lblTenCD.Visible = true;
            }
            FrmMain.con1.Close(); 
        }
        //--------------------------------------------------------------
        //-------------------Display Chu Ky-----------------------------
       
        //--------------------------------------------------------------
        //-------------------Display Ten Phong Ban----------------------
        void DisplayTenPB()
        {
            string query = "Select * From PHONGBAN Where MaPB='" + cboMaPB.Text + "'";
            FrmMain.con1.Open();
            SqlCommand cmd = new SqlCommand(query, FrmMain.con1);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string Sname = dr.GetString(1);
                lblTenPB.Text = Sname;
                lblTenPB.Visible = true;
            }
            FrmMain.con1.Close();
        }
        //--------------------------------------------------------------
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        //--------------------Choose Image From Dialog----------------------
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog= new OpenFileDialog();
            dialog.Filter = "JPG File(*.jpg)|*.jpg| PNG File(*.png)| All File(*.*)*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imgLocation = dialog.FileName.ToString();
                picNhanVien.ImageLocation = imgLocation;
            }

        }
        //--------------------------------------------------------------------------
        //---------------------Convert Image To Binary------------------------------
        public byte[] imageToByte1(byte[] img)
        {
            //byte[] images;
            FileStream Stream = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
            BinaryReader brs = new BinaryReader(Stream);
            img = brs.ReadBytes((int)Stream.Length);
            return img;
        }
        //--------------------------------------------------------------------------
        //------------------------Clear Text----------------------------------------
        void ClearText()
        {
            txtMaNV.Text = "";
            txtTenNV.Text = "";
            cboMaCD.Text = "";
            cboMaPB.Text = "";
            lblTenCD.Text = "";
            lblTenPB.Text = "";
            picNhanVien.Image = null;
            txtMaNV.Focus();
         }
        //----------------------------------------------------------------------------
        private void btnThem_Click(object sender, EventArgs e)
        {
            //DisplayChuKy();
            ClearText();
            btnThem.Enabled = false;
            btnLuu.Enabled = true;
            btnXoa.Enabled = false;
        }
        //-----------------------------------------------------------------------------
        private void cboMaCD_SelectedValueChanged(object sender, EventArgs e)
        {
            DisplayTenCD();
        }

        private void cboMaCD_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboMaPB_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void cboMaPB_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayTenPB();
        }

        private void cboMaPB_SelectedValueChanged(object sender, EventArgs e)
        {
            DisplayTenPB();
        }
        //----------------------Convert Image To Binary---------------------------
        public byte[] imageToByte2(byte[] img)
        {
            //byte[] images;
            FileStream Stream = new FileStream(imgLocation, FileMode.Open, FileAccess.ReadWrite);
            BinaryReader brs = new BinaryReader(Stream);
            img = brs.ReadBytes((int)Stream.Length);
            return img;
        }
        //------------------------------------------
        
        //------------------------Convert Image To Binary Standard----------
        public byte[] imgToByteArray(Image img)
        {
            using (MemoryStream mStream = new MemoryStream())
            {
                img.Save(mStream, img.RawFormat);
                return mStream.ToArray();
            }
        }
        //------------------------------------------------------------
        //-------------------------Function Save ---------------------

        private void btnLuu_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = true;
            btnLuu.Enabled = false;
            if (txtMaNV.Text == "" || txtTenNV.Text == "" || cboMaCD.Text == "" || cboMaPB.Text == "")
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
                    if (picNhanVien.Image == null)
                    {
                        int a = 0;
                        byte[] images = new byte[Convert.ToInt32(a)];
                        string che = @"( SELECT COUNT(*) FROM NHANVIEN WHERE MaNV='" + txtMaNV.Text + "')";
                        FrmMain.con1.Open();

                        SqlCommand Sqlcmd = new SqlCommand("InsertOrEdit", FrmMain.con1);
                        Sqlcmd.CommandType = CommandType.StoredProcedure;
                        Sqlcmd.Parameters.AddWithValue("@Mode", "New");
                        Sqlcmd.Parameters.AddWithValue("@MaNV", txtMaNV.Text.Trim());
                        Sqlcmd.Parameters.AddWithValue("@TenNV", txtTenNV.Text.Trim());
                        Sqlcmd.Parameters.AddWithValue("@MaCD", cboMaCD.Text.Trim());
                        Sqlcmd.Parameters.AddWithValue("@MaPB", cboMaPB.Text.Trim());
                        Sqlcmd.Parameters.AddWithValue("@ChuKy", images);
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
                            DisplayDgvNhanVien();
                        }
                        FrmMain.con1.Close();
                    }
                    else
                    {
                        byte[] a = null;
                        byte[] images = imageToByte2(a);
                        string che = @"( SELECT COUNT(*) FROM NHANVIEN WHERE MaNV='" + txtMaNV.Text + "')";
                        FrmMain.con1.Open();
                        SqlCommand Sqlcmd = new SqlCommand("InsertOrEdit", FrmMain.con1);
                        Sqlcmd.CommandType = CommandType.StoredProcedure;
                        Sqlcmd.Parameters.AddWithValue("@Mode", "New");
                        Sqlcmd.Parameters.AddWithValue("@MaNV", txtMaNV.Text.Trim());
                        Sqlcmd.Parameters.AddWithValue("@TenNV", txtTenNV.Text.Trim());
                        Sqlcmd.Parameters.AddWithValue("@MaCD", cboMaCD.Text.Trim());
                        Sqlcmd.Parameters.AddWithValue("@MaPB", cboMaPB.Text.Trim());
                        Sqlcmd.Parameters.AddWithValue("@ChuKy", images);
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
                            DisplayDgvNhanVien();
                        }
                        FrmMain.con1.Close();
                    }
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
        //--------------------------------------------------------------------------------------------------
        private void lVNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //----------------------------------------------------------------------------
        private void lVNhanVien_Click(object sender, EventArgs e)
        {
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;
        }
        //----------------------------------------------------------------------------
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
           
            
        }
       

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dataGridView1_Scroll(object sender, ScrollEventArgs e)
        {
            
            
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        //---------------------------Event When Click on Datagridview----------------------
        private void dgvNhanVien_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = true;
            btnLuu.Enabled = false;
            btnXoa.Enabled = true;
            if (dgvNhanVien.CurrentRow.Index != -1)
            {
                txtMaNV.Text = dgvNhanVien.CurrentRow.Cells[0].Value.ToString();
                txtTenNV.Text = dgvNhanVien.CurrentRow.Cells[1].Value.ToString();
                cboMaCD.Text = dgvNhanVien.CurrentRow.Cells[2].Value.ToString();
                cboMaPB.Text = dgvNhanVien.CurrentRow.Cells[3].Value.ToString();
                byte[] img = (byte[])dgvNhanVien.CurrentRow.Cells[4].Value;
                if (img.Length == 0)
                {
                    picNhanVien.Image = null;
                }
                else
                {
                    MemoryStream msStr = new MemoryStream(img);
                    picNhanVien.Image = Image.FromStream(msStr);
                }
              }
           }
        //------------------------------------------------------------------------------------
        //------------------When row or column are nulls then nothing---------------------------

        private void dgvNhanVien_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if( dgvNhanVien.Rows[e.RowIndex].Cells[e.ColumnIndex].Value==DBNull.Value)
            {
                e.Cancel = true;
            }
        }
        //---------------------------------------------------------------------------
        private void dgvNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;
            if (dgvNhanVien.CurrentRow.Index != -1)
            {
                txtMaNV.Text = dgvNhanVien.CurrentRow.Cells[0].Value.ToString();
                txtTenNV.Text = dgvNhanVien.CurrentRow.Cells[1].Value.ToString();
                cboMaCD.Text = dgvNhanVien.CurrentRow.Cells[2].Value.ToString();
                cboMaPB.Text = dgvNhanVien.CurrentRow.Cells[3].Value.ToString();
                byte[] img = (byte[])dgvNhanVien.CurrentRow.Cells[4].Value;
                if (img.Length == 0)
                {
                    picNhanVien.Image = null;
                }
                else
                {
                    MemoryStream msStr = new MemoryStream(img);
                    picNhanVien.Image = Image.FromStream(msStr);
                }
            }
        }
        //-----------------------------------------------------------------------------
        private void btnCancel_Click(object sender, EventArgs e)
        {
            picNhanVien.Image = null;
        }
        //------------------------Function Delete--------------------------------------
        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult Dlr = MessageBox.Show("Delete", "Some Title", MessageBoxButtons.YesNo);
            if(Dlr==DialogResult.Yes)
            {
                FrmMain.con1.Open();
                SqlCommand Sqlcmd = new SqlCommand("Delete", FrmMain.con1);
                Sqlcmd.CommandType = CommandType.StoredProcedure;
                Sqlcmd.Parameters.AddWithValue("@MaNV", txtMaNV.Text.Trim());
                Sqlcmd.ExecuteNonQuery();
                MessageBox.Show("Deleted Successfully!!!!!");
                DisplayDgvNhanVien();
                FrmMain.con1.Close();
            }
        }
        //--------------------------------------------------------------------------------------------
        //---------------------------------Function Edit Database-------------------------------------
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text == "" || txtTenNV.Text == "" || cboMaCD.Text == "" || cboMaPB.Text == "")
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
                        if (picNhanVien.Image == null)
                        {
                            int a = 0;
                            byte[] images = new byte[Convert.ToInt32(a)];
                            FrmMain.con1.Open();
                            SqlCommand Sqlcmd = new SqlCommand("InsertOrEdit", FrmMain.con1);
                             Sqlcmd.CommandType = CommandType.StoredProcedure;
                             Sqlcmd.Parameters.AddWithValue("@Mode", "Edit");
                             Sqlcmd.Parameters.AddWithValue("@MaNV", txtMaNV.Text.Trim());
                             Sqlcmd.Parameters.AddWithValue("@TenNV", txtTenNV.Text.Trim());
                             Sqlcmd.Parameters.AddWithValue("@MaCD", cboMaCD.Text.Trim());
                             Sqlcmd.Parameters.AddWithValue("@MaPB", cboMaPB.Text.Trim());
                             Sqlcmd.Parameters.AddWithValue("@ChuKy", images);
                             Sqlcmd.ExecuteNonQuery();
                              MessageBox.Show("UPDATED SUCCESSFULLY !!!!!");
                              DisplayDgvNhanVien();
                              FrmMain.con1.Close();
                        }
                        else
                        {
                            MessageBox.Show("Edit Success");
                            byte[] images = null;
                            images =imgToByteArray(picNhanVien.Image);
                            FrmMain.con1.Open();
                            SqlCommand Sqlcmd = new SqlCommand("InsertOrEdit", FrmMain.con1);
                             Sqlcmd.CommandType = CommandType.StoredProcedure;
                             Sqlcmd.Parameters.AddWithValue("@Mode", "Edit");
                             Sqlcmd.Parameters.AddWithValue("@MaNV", txtMaNV.Text.Trim());
                             Sqlcmd.Parameters.AddWithValue("@TenNV", txtTenNV.Text.Trim());
                             Sqlcmd.Parameters.AddWithValue("@MaCD", cboMaCD.Text.Trim());
                             Sqlcmd.Parameters.AddWithValue("@MaPB", cboMaPB.Text.Trim());
                             Sqlcmd.Parameters.AddWithValue("@ChuKy", images);
                             Sqlcmd.ExecuteNonQuery();
                                MessageBox.Show("UPDATED SUCCESSFULLY !!!!!");
                                DisplayDgvNhanVien();
                             FrmMain.con1.Close();
                        }
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
        //-----------------------------------------------------------------------------------------------
    }
}
