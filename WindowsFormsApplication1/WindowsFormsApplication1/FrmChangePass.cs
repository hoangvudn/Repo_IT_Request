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
    public partial class FrmChangePass : Form
    {
        public FrmChangePass()
        {
            InitializeComponent();
        }
        //----------------------------------Encrypt Password------------------------------
        /*public static string MD5Hash(string input)
        {
            StringBuilder hash = new StringBuilder();
            MD5CryptoServiceProvider md5provider = new MD5CryptoServiceProvider();
            byte[] bytes = md5provider.ComputeHash(new UTF8Encoding().GetBytes(input));
            for (int i = 0; i < bytes.Length; i++)
            {
                hash.Append(bytes[i].ToString("x2"));
            }
            return hash.ToString();
        }*/
        //------------------------------------------------------------------------------------------
        //-----------------------Display Database Change Password on Datagridview-------------------
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
            dgvChangePass.DataSource = dt;
            FrmMain.con1.Close();
        }
        //----------------------------------------------------------------------------------------------
        //-------------------------------------Clear Text-----------------------------------------------
        void ClearText()
        {
            txtUser.Text = "";
            txtPass.Text = "";
            txtOldPass.Text = "";
            txtRepass.Text = "";
            cboPermission.Text = "";
            txtUser.Focus();
        }
        //--------------------------------------------------------------------------------
        private void FrmChangePass_Load(object sender, EventArgs e)
        {
            DisplayDgvCreatUser();
            Int16 Per = FrmLogin.Perm;
            if (Per==1)
            {
                btnThem.Enabled = false;
                btnLuu.Enabled = false;
                btnXoa.Enabled = false;
                MessageBox.Show("Welcome USER NOT ADMIN !!!!!!");
            }
            else
            {
                MessageBox.Show("Welcome ADMIN !!!!!!");
                btnThem.Enabled = true;
                btnLuu.Enabled = true;
                btnXoa.Enabled = true;
            }

        }
        //------------------------------------------------------------------------------------------------------------------------
        //--------------------------------------------SAVE FUNCTION---------------------------------------------------------------
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
                    if (txtPass.Text != txtRepass.Text)
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
                        Sqlcmd.Parameters.AddWithValue("@Per", cboPermission.Text.Trim());
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

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        //--------------------------------------------===EDIT FUNCTION===-------------------------------------------------
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
                        String che = @"( SELECT COUNT(*) FROM USER1 WHERE MaNV='" + txtUser.Text.Trim() + "' AND Pass='" + FrmMain.MD5Hash(txtOldPass.Text) + "') ";
                        FrmMain.con1.Open();
                        SqlCommand Sqlcmd = new SqlCommand("InsertOrEditUser", FrmMain.con1);
                        Sqlcmd.CommandType = CommandType.StoredProcedure;
                        Sqlcmd.Parameters.AddWithValue("@Mode", "Edit");
                        Sqlcmd.Parameters.AddWithValue("@MaNV", txtUser.Text.Trim());
                        Sqlcmd.Parameters.AddWithValue("@Pass", FrmMain.MD5Hash(txtPass.Text.Trim()));
                        Sqlcmd.Parameters.AddWithValue("@Per", cboPermission.Text.Trim());
                        SqlCommand cmd = new SqlCommand(che, FrmMain.con1);
                        int count = (int)cmd.ExecuteScalar();
                        if ( count>0 )
                        {
                            Sqlcmd.ExecuteNonQuery();
                            MessageBox.Show("UPDATED SUCCESSFULLY !!!!!");
                            DisplayDgvCreatUser();
                        }
                        else
                        {
                            MessageBox.Show(" OldPass Not Exits ");                           
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

        private void btnThem_Click(object sender, EventArgs e)
        {

        }
        //-----------------------------------------------------------------------------------------------
    }
}
