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
using System.Security.Cryptography;

namespace WindowsFormsApplication1
{
    public partial class FrmCreatUser : Form
    {
        public FrmCreatUser()
        {
            InitializeComponent();
        }
        //------------------------------Connection String----------------------------------------------------------------------
        //SqlConnection con1 = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=IT_REQUEST;Integrated Security=True");
        //SqlConnection con1 = new SqlConnection(@"Data Source=10.65.2.217\SQLEXPRESS;Initial Catalog=IT_REQUEST;Persist Security Info=True;User ID=sa;Password=abc@123");
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        //-----------------------Clear Text-----------------------------------------------
        void ClearText()
        {
            txtUser.Text = "";
            txtPass.Text = "";
            txtRepass.Text = "";
            cboPermission.Text = "";
            txtUser.Focus();
        }
        //--------------------------------------------------------------------------------
        //----------------------------------Encrypt Password------------------------------
        /*public static string MD5Hash(string input)
        {
            StringBuilder hash = new StringBuilder();
            MD5CryptoServiceProvider md5provider = new MD5CryptoServiceProvider();
            byte[] bytes = md5provider.ComputeHash(new UTF8Encoding().GetBytes(input));
            for (int i = 0; i < bytes.Length; i++)
            {
                hash.Append(bytes[i].ToString("x2")+"b");
            }
            return hash.ToString();
        }*/
        //--------------------------------------------------------------------------------
        //-----------------------Display database CreatUser on Datagridview---------------
        void DisplayDgvCreatUser()
        {
            if (FrmMain.con1.State == ConnectionState.Closed)
                FrmMain.con1.Open();
            string query = @"Select * From USER1";
            SqlCommand cmd = new SqlCommand(query, FrmMain.con1);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvCreatUser.DataSource = dt;
            FrmMain.con1.Close();
        }
        //-----------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------
        void DisplayDgvCreatUser1()
        {
            if (FrmMain.con1.State == ConnectionState.Closed)
                FrmMain.con1.Open();
            string query = @"Select * From USER1 Where MaNV='"+txtUser.Text.Trim()+"'";
            SqlCommand cmd = new SqlCommand(query, FrmMain.con1);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvCreatUser.DataSource = dt;
            FrmMain.con1.Close();
        }
        //-----------------------------------------------------------------------------------
        //------------------------LOAD FORM--------------------------------------------------
        private void FrmCreatUser_Load(object sender, EventArgs e)
        {
            //DisplayDgvCreatUser();
            btnXoa.Enabled = false;
            btnLuu.Enabled = false;
            btnSua.Enabled = false;
            //txtUser.Enabled = false;
            txtUser.Text = FrmLogin.ID_USER.ToString();
            int a = Int16.Parse(FrmLogin.Perm.ToString());
            if(a==1)
            {
                MessageBox.Show("Welcome User: ");
                dgvCreatUser.Visible = false;
                txtUser.Enabled = false;
                btnXoa.Enabled = false;
                btnLuu.Enabled = false;
                btnSua.Enabled = true;
                btnThem.Enabled = false;
                cboPermission.Text = "1";
                cboPermission.Enabled = false;
            }
            else
            {
                MessageBox.Show("Welcome Admin");
                DisplayDgvCreatUser();
                btnXoa.Enabled = true;
                btnLuu.Enabled = false;
                btnSua.Enabled =true;
                btnThem.Enabled = true;
                cboPermission.Enabled = true;
            }
        }
        //------------------------------------------------------------------------------------
        //------------------------------------------------------------------------------------
        private void btnThem_Click(object sender, EventArgs e)
        {
            ClearText();
            btnThem.Enabled = false;
            btnLuu.Enabled = true;
            btnXoa.Enabled = false;
        }
        //----------------------------------------------------------------------------------------
        //----------------------------------------------------------------------------------------
        private void btnSua_Click(object sender, EventArgs e)
        {
            DialogResult Dlr = MessageBox.Show("Do you want Update?", "UPDATE", MessageBoxButtons.YesNo);
            if (Dlr == DialogResult.Yes)
            {
                try
                {
                    if (FrmMain.MD5Hash(txtPass.Text.Trim()) != FrmMain.MD5Hash(txtRepass.Text.Trim()))
                    {
                        MessageBox.Show("Pass and Repass not match");
                    }
                    else
                    {
                        FrmMain.con1.Open();
                        SqlCommand Sqlcmd = new SqlCommand("InsertOrEditUser", FrmMain.con1);
                        Sqlcmd.CommandType = CommandType.StoredProcedure;
                        Sqlcmd.Parameters.AddWithValue("@Mode", "Edit");
                        Sqlcmd.Parameters.AddWithValue("@MaNV", txtUser.Text.Trim());
                        Sqlcmd.Parameters.AddWithValue("@Pass", FrmMain.MD5Hash(txtPass.Text.Trim()));
                        Sqlcmd.Parameters.AddWithValue("@Per", cboPermission.Text.Trim());
                        Sqlcmd.ExecuteNonQuery();
                        MessageBox.Show("UPDATED SUCCESSFULLY !!!!!");
                        DisplayDgvCreatUser();
                        FrmMain.con1.Close();
                    }
                }
                catch (Exception)
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
        //-----------------------------------------------------------------------------------------------------------
        //-------------------------------SAVE FUNCTION---------------------------------------------------------------
        private void btnLuu_Click(object sender, EventArgs e)
        {
             if (txtUser.Text == "" || txtPass.Text == "")
             {
                 MessageBox.Show("INPUT DATA PLEASE!!!!!");
             }
             else
             {
                 DialogResult Dlr = MessageBox.Show("Do you want Save", "Title", MessageBoxButtons.YesNo);
                 if (Dlr == DialogResult.Yes)
                 {
                     if(txtPass.Text!=txtRepass.Text)
                     {
                         MessageBox.Show("Pass and Re-Pass not match");
                     }
                     else
                     {
                      String che = @"( SELECT COUNT(*) FROM USER1 WHERE MaNV='" + txtUser.Text.Trim() + "') ";
                      FrmMain.con1.Open();
                      SqlCommand Sqlcmd = new SqlCommand("InsertOrEditUser", FrmMain.con1);
                      Sqlcmd.CommandType = CommandType.StoredProcedure;
                      Sqlcmd.Parameters.AddWithValue("@Mode", "New");
                      Sqlcmd.Parameters.AddWithValue("@MaNV", txtUser.Text.Trim());
                      Sqlcmd.Parameters.AddWithValue("@Pass", FrmMain.MD5Hash(txtPass.Text.Trim()));
                      Sqlcmd.Parameters.AddWithValue("@Per",cboPermission.Text.Trim());
                      SqlCommand cmd = new SqlCommand(che, FrmMain.con1);
                      int count = (int)cmd.ExecuteScalar();
                      if (count > 0)
                      {
                         MessageBox.Show("User already exits");
                         btnLuu.Enabled = true;
                         btnThem.Enabled = false;
                      }
                      else
                      {
                         Sqlcmd.ExecuteNonQuery();
                         MessageBox.Show("UPDATED SUCCESSFULLY!!!!!");
                         DisplayDgvCreatUser();
                         btnLuu.Enabled = false;
                         btnThem.Enabled = true;
                         ClearText();
                      }
                      FrmMain.con1.Close();
                     }
                   }
               }
         }
        //---------------------------------------------------------------------------------------------
        //-----------------------------Delete Function-------------------------------------------------
        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult Dlr = MessageBox.Show("Do you want Delete", "Delete", MessageBoxButtons.YesNo);
            if (Dlr == DialogResult.Yes)
            {
                try
                {
                    FrmMain.con1.Open();
                    SqlCommand Sqlcmd = new SqlCommand("DeleteUser", FrmMain.con1);
                    Sqlcmd.CommandType = CommandType.StoredProcedure;
                    Sqlcmd.Parameters.AddWithValue("@MaNV", txtUser.Text.Trim());
                    Sqlcmd.ExecuteNonQuery();
                    MessageBox.Show("Deleted Successfully!!!!!");
                    DisplayDgvCreatUser();
                    ClearText();
                    FrmMain.con1.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("User already exits on Another Table ");
                }
                finally
                {
                    if (FrmMain.con1.State == ConnectionState.Open)
                        FrmMain.con1.Close();
                }
            }
        }
        //-------------------------------------------------------------------------------------------------------------------
        //-------------------------------------------------Show Information when click on Datagrid------------------------------------------------------------------
        private void dgvCreatUser_Click(object sender, EventArgs e)
        {
            btnXoa.Enabled = true;
            try
            {
                if (dgvCreatUser.CurrentRow.Index != -1)
                {
                    txtUser.Text = dgvCreatUser.CurrentRow.Cells[0].Value.ToString();
                    txtPass.Text = dgvCreatUser.CurrentRow.Cells[1].Value.ToString();
                    cboPermission.Text = dgvCreatUser.CurrentRow.Cells[2].Value.ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No Record!!!!!");
            }

        }
        //-------------------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------------------
        private void dgvCreatUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //-------------------------------------------------------------------------------------------------------------------
    }

}