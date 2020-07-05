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
    public partial class FrmChucDanh : Form
    {
        public FrmChucDanh()
        {
            InitializeComponent();
        }
        //SqlConnection con1 = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=IT_REQUEST;Integrated Security=True");
        //SqlConnection con1 = new SqlConnection(@"Data Source=10.65.2.217\SQLEXPRESS;Initial Catalog=IT_REQUEST;Persist Security Info=True;User ID=sa;Password=abc@123");
        //--------------------------------------------------------------------------------------------------
        private void FrmChucDanh_Load(object sender, EventArgs e)
        {
            
            DisplayDgvChucDanh();
            btnXoa.Enabled = false;
            btnLuu.Enabled = false;
            btnSua.Enabled = false;
        }
        //-----------------------------------------------------------------------
        //---------------------Exit Application----------------------------------
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        //---------------Clear Text----------------------------------------------
        void ClearText()
        {
            txtMaCD.Text = "";
            txtTenCD.Text = "";
            txtMaCD.Focus();
        }
        //-----------------------------------------------------------------------
        //--------------------Display CHUC DANH on Datagridview------------------
        void DisplayDgvChucDanh()
        {
            if (FrmMain.con1.State == ConnectionState.Closed)
                FrmMain.con1.Open();
            string query = @"Select * From CHUCDANH";
            SqlCommand cmd = new SqlCommand(query, FrmMain.con1);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvChucDanh.DataSource = dt;
            FrmMain.con1.Close();
        }
        //------------------------------------------------------------
        //----------------------Add Function-------------------------- 
        private void btnThem_Click(object sender, EventArgs e)
        {
            ClearText();
            btnThem.Enabled = false;
            btnLuu.Enabled = true;
            btnXoa.Enabled = false;
        }
        //-------------------------------------------------------------
        //------------------------Save Function------------------------
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMaCD.Text == "" || txtTenCD.Text == " ")
            {
                MessageBox.Show("INPUT DATA PLEASE!!!!!");
            }
            else
            {
                DialogResult Dlr = MessageBox.Show("Do you want Save", "Title", MessageBoxButtons.YesNo);
                if (Dlr == DialogResult.Yes)
                {
                    String che = @"( SELECT COUNT(*) FROM CHUCDANH WHERE MaCD='" + txtMaCD.Text + "') ";
                    FrmMain.con1.Open();
                    SqlCommand Sqlcmd = new SqlCommand("InsertOrEditCD", FrmMain.con1);
                    Sqlcmd.CommandType = CommandType.StoredProcedure;
                    Sqlcmd.Parameters.AddWithValue("@Mode", "New");
                    Sqlcmd.Parameters.AddWithValue("@MaCD", txtMaCD.Text.Trim());
                    Sqlcmd.Parameters.AddWithValue("@TenCD", txtTenCD.Text.Trim());
                    SqlCommand cmd = new SqlCommand(che, FrmMain.con1);
                    int count = (int)cmd.ExecuteScalar();
                    if (count > 0)
                    {
                        MessageBox.Show("Ma Chuc Danh already exits");
                        btnLuu.Enabled = true;
                        btnThem.Enabled = false;
                    }
                    else
                    {
                        Sqlcmd.ExecuteNonQuery();
                        MessageBox.Show("UPDATED SUCCESSFULLY!!!!!");
                        DisplayDgvChucDanh();
                        btnLuu.Enabled = false;
                        btnThem.Enabled = true;
                    }
                    FrmMain.con1.Close();
                }
            }
        }
        //----------------------------------------------------------------
        //------------------------EDIT Function---------------------------
        private void btnSua_Click(object sender, EventArgs e)
        {
            DialogResult Dlr = MessageBox.Show("Do you want Update?", "UPDATE", MessageBoxButtons.YesNo);
            if (Dlr == DialogResult.Yes)
            {
                try
                {
                    FrmMain.con1.Open();
                    SqlCommand Sqlcmd = new SqlCommand("InsertOrEditCD", FrmMain.con1);
                    Sqlcmd.CommandType = CommandType.StoredProcedure;
                    Sqlcmd.Parameters.AddWithValue("@Mode", "Edit");
                    Sqlcmd.Parameters.AddWithValue("@MaCD", txtMaCD.Text.Trim());
                    Sqlcmd.Parameters.AddWithValue("@TenCD", txtTenCD.Text.Trim());
                    Sqlcmd.ExecuteNonQuery();
                    MessageBox.Show("UPDATED SUCCESSFULLY!!!!!");
                    DisplayDgvChucDanh();
                    FrmMain.con1.Close();
                }
                catch(Exception)
                {
                    MessageBox.Show("Warning ERROR in Relationship!!!!!");
                }
                finally
                {
                    if (FrmMain.con1.State == ConnectionState.Open)
                        FrmMain.con1.Close();
                }
            }
        }
        //----------------------------------------------------------------
        //----------------------------Delete Function---------------------
        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult Dlr = MessageBox.Show("Do you want Delete", "Delete", MessageBoxButtons.YesNo);
            if (Dlr == DialogResult.Yes)
            {
                try
                {
                    FrmMain.con1.Open();
                    SqlCommand Sqlcmd = new SqlCommand("DeleteCD", FrmMain.con1);
                    Sqlcmd.CommandType = CommandType.StoredProcedure;
                    Sqlcmd.Parameters.AddWithValue("@MaCD", txtMaCD.Text.Trim());
                    Sqlcmd.ExecuteNonQuery();
                    MessageBox.Show("Deleted Successfully!!!!!");
                    DisplayDgvChucDanh();
                    //ClearText();
                    FrmMain.con1.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Ma Chuc Danh already exits on Another Table ");
                }
                finally
                {
                    if (FrmMain.con1.State == ConnectionState.Open)
                        FrmMain.con1.Close();
                }
            }
       }
        //-------------------------------------------------------------------------------
       //-----------------------------Display CHUCDANH on Datagridview-------------------
        private void dgvChucDanh_Click(object sender, EventArgs e)
        {
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            if (dgvChucDanh.CurrentRow.Index != -1)
            {
                txtMaCD.Text = dgvChucDanh.CurrentRow.Cells[0].Value.ToString();
                txtTenCD.Text = dgvChucDanh.CurrentRow.Cells[1].Value.ToString();
            }
        }
        //---------------------------------------------------------------------------------

        private void dgvChucDanh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
       //----------------------------------------------------------------------------------------
   }
}
