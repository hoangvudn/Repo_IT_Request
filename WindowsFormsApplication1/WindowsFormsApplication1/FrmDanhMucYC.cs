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
namespace WindowsFormsApplication1
{
    public partial class FrmDanhMucYC : Form
    {
        public FrmDanhMucYC()
        {
            InitializeComponent();
        }
        //SqlConnection con1 = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=IT_REQUEST;Integrated Security=True");
        //SqlConnection con1 = new SqlConnection(@"Data Source=10.65.2.217\SQLEXPRESS;Initial Catalog=IT_REQUEST;Persist Security Info=True;User ID=sa;Password=abc@123");

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        //--------------------Display YEU CAU on Datagridview-----
        void DisplayDgvLoaiYeuCau()
        {
            if (FrmMain.con1.State == ConnectionState.Closed)
             FrmMain.con1.Open();
             string query = @"Select * From LOAIYEUCAU";
             SqlCommand cmd = new SqlCommand(query, FrmMain.con1);
             cmd.ExecuteNonQuery();
             DataTable dt = new DataTable();
             SqlDataAdapter da = new SqlDataAdapter(cmd);
             da.Fill(dt);
             dgvYeuCau.DataSource = dt;
             FrmMain.con1.Close();
        }
        //------------------------------------------------------------
        //---------------------------------------------------------------
        private void FrmDanhMucYC_Load(object sender, EventArgs e)
        {
            DisplayDgvLoaiYeuCau();
            btnXoa.Enabled = false;
            btnLuu.Enabled = false;
            btnSua.Enabled = false;
        }
        //--------------------------------------------------------------
        //---------------Clear Text----------------------------------------------
        void ClearText()
        {
            txtMaYC.Text = "";
            txtTenYC.Text = "";
            txtMaYC.Focus();
        }
        //---------------------------------------------------------------
        //---------------------------ADD Function---------------------------------
        private void btnThem_Click(object sender, EventArgs e)
        {
            ClearText();
            btnThem.Enabled = false;
            btnLuu.Enabled = true;
            btnXoa.Enabled = false;
        }
        //-------------------------------------------------------------------------------------------------------------
        //-------------------------------SAVE FUNCTION-----------------------------------------------------------------
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMaYC.Text == "" || txtTenYC.Text == " ")
            {
                MessageBox.Show("INPUT DATA PLEASE!!!!!");
            }
            else
            {
                DialogResult Dlr = MessageBox.Show("Do you want Save", "Title", MessageBoxButtons.YesNo);
                if (Dlr == DialogResult.Yes)
                {
                    String che = @"( SELECT COUNT(*) FROM LOAIYEUCAU WHERE MaLoaiYC='" + txtMaYC.Text + "') ";
                    FrmMain.con1.Open();
                    SqlCommand Sqlcmd = new SqlCommand("InsertOrEditYC", FrmMain.con1);
                     Sqlcmd.CommandType = CommandType.StoredProcedure;
                     Sqlcmd.Parameters.AddWithValue("@Mode", "New");
                     Sqlcmd.Parameters.AddWithValue("@MaLoaiYC", txtMaYC.Text.Trim());
                     Sqlcmd.Parameters.AddWithValue("@TenLoaiYC", txtTenYC.Text.Trim());
                     SqlCommand cmd = new SqlCommand(che, FrmMain.con1);
                     int count = (int)cmd.ExecuteScalar();
                     if (count > 0)
                     {
                        MessageBox.Show("Ma Loai Yeu Cau already exits");
                        btnLuu.Enabled = true;
                        btnThem.Enabled = false;
                     }
                     else
                     {
                        Sqlcmd.ExecuteNonQuery();
                        MessageBox.Show("UPDATED SUCCESSFULLY!!!!!");
                        DisplayDgvLoaiYeuCau();
                        btnLuu.Enabled = false;
                        btnThem.Enabled = true;
                     }
                     FrmMain.con1.Close();
                }
             }
        }
        //-----------------------------------------------------------------------------
        //----------------------------------EDIT FUNCTION------------------------------
        private void btnSua_Click(object sender, EventArgs e)
        {
            DialogResult Dlr = MessageBox.Show("Do you want Update?", "UPDATE", MessageBoxButtons.YesNo);
            if (Dlr == DialogResult.Yes)
            {
                try
                {
                    FrmMain.con1.Open();
                    SqlCommand Sqlcmd = new SqlCommand("InsertOrEditYC", FrmMain.con1);
                    Sqlcmd.CommandType = CommandType.StoredProcedure;
                    Sqlcmd.Parameters.AddWithValue("@Mode", "Edit");
                    Sqlcmd.Parameters.AddWithValue("@MaLoaiYC", txtMaYC.Text.Trim());
                    Sqlcmd.Parameters.AddWithValue("@TenLoaiYC", txtTenYC.Text.Trim());
                    Sqlcmd.ExecuteNonQuery();
                    MessageBox.Show("UPDATED SUCCESSFULLY!!!!!");
                    DisplayDgvLoaiYeuCau();
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
        //--------------------------------------------------------------------------------------
        //----------------------------------Delete Function-------------------------------------
        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult Dlr = MessageBox.Show("Do you want Delete", "Delete", MessageBoxButtons.YesNo);
            if (Dlr == DialogResult.Yes)
            {
                try
                {
                    FrmMain.con1.Open();
                    SqlCommand Sqlcmd = new SqlCommand("DeleteLoaiYC", FrmMain.con1);
                     Sqlcmd.CommandType = CommandType.StoredProcedure;
                     Sqlcmd.Parameters.AddWithValue("@MaLoaiYC", txtMaYC.Text.Trim());
                     Sqlcmd.ExecuteNonQuery();
                     MessageBox.Show("Deleted Successfully!!!!!");
                     DisplayDgvLoaiYeuCau();
                     ClearText();
                    FrmMain.con1.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Ma Loai Yeu Cau already exits on Another Table ");
                }
                finally
                {
                    if (FrmMain.con1.State == ConnectionState.Open)
                        FrmMain.con1.Close();
                }
            }
         }
        //------------------------------------------------------------------------------------------------
        //-------------------------------------Datagrid hien thi danh muc Yeu Cau-------------------------
        private void dgvYeuCau_Click(object sender, EventArgs e)
        {
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            btnThem.Enabled = true;
            if (dgvYeuCau.CurrentRow.Index != -1)
            {
                txtMaYC.Text = dgvYeuCau.CurrentRow.Cells[0].Value.ToString();
                txtTenYC.Text = dgvYeuCau.CurrentRow.Cells[1].Value.ToString();
            }
        }
        //-------------------------------------------------------------------------------------------------
        private void dgvYeuCau_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //-------------------------------------------------------------------------------------
    }
}
