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
using System.Configuration;

namespace WindowsFormsApplication1
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        //SqlConnection con1 = new SqlConnection(System.Configuration.ConfigurationSettings.AppSettings["WindowsFormsApplication1.Properties.Settings.IT_REQUESTConnectionString"]);
        //-------------------------Connection String----------------------------------------------------------
        //SqlConnection con1 = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=IT_REQUEST;Integrated Security=True");
        //SqlConnection con1 = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=IT_REQUEST;Persist Security Info=True;User ID=sa;Password=Abc@123");
        
       //-----------------------------------------------------------------------------------------------------------
        public static string ID_USER = "";
        public static Int16 Perm = 0;
        //String con1 = ConnectionFactory.GetConnection(ConfigurationManager.ConnectionStrings["Test"].ConnectionString, DataBaseProvider);
       
        private void FrmLogin_Load(object sender, EventArgs e)
        {
           
        }
        //-------------------------Get User ID-------------------------------
        private string getID(string manv, string pass)
        {
            string id = "";
            try
            {
                FrmMain.con1.Open();
     
                SqlCommand cmd = new SqlCommand("SELECT * FROM USER1 WHERE MaNV='" + manv + "' and Pass='" + pass + "'", FrmMain.con1);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt!=null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        id = dr["MaNV"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                FrmMain.con1.Close();
            }
            return id;
        }
        //---------------------------------------------------------------------------------------
        //===========================Get permission from database================================
        private Int16 getPer(string manv, string pass)
        {
            Int16 i = 0;
            try
            {
                //FrmMain.con1.Open();
     
                SqlCommand cmd = new SqlCommand("SELECT * FROM USER1 WHERE MaNV='" + manv + "' and Pass='" + pass + "'", FrmMain.con1);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt != null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {

                        i = Int16.Parse(dr["Permissions1"].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                FrmMain.con1.Close();
            }
            return i;
        }
        //------------------------------------------------------------------------------------------------------
        //----------------------------Encrypt Password----------------------------------------------------------
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
        //------------------------------------------------------------------------------------------------------
        //----------------------------------LOGIN---------------------------------------------------------------------------
        private void button1_Click(object sender, EventArgs e)
        {
            ID_USER = getID(txtUser.Text, FrmMain.MD5Hash(txtPass.Text));
            Perm = getPer(txtUser.Text, FrmMain.MD5Hash(txtPass.Text));
            if ((txtUser.Text == "Admin") && (txtPass.Text == "123456"))
            {
                FrmMain Fmain = new FrmMain();
                this.Hide();
                Fmain.ShowDialog();
            }
            else
            FrmMain.con1.Open();
            String query = @"(SELECT * FROM USER1 WHERE MaNV='" + txtUser.Text + "' AND Pass='" + FrmMain.MD5Hash(txtPass.Text) + "')";
            SqlDataAdapter sda = new SqlDataAdapter(query, FrmMain.con1);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                FrmMain FMain = new FrmMain();
                this.Hide();
                FMain.Show();
            }
            else
            {
                MessageBox.Show("Check User and Pass. Please!!!!!");
            }
            FrmMain.con1.Close();
        }
        //---------------------------------------------------------------------------------------------------------------
        //---------------------------------------------------------------------------------------------------------------
       /* private void btnLogin1_Click(object sender, EventArgs e)
        {
            ID_USER = getID(txtUser.Text, MD5Hash(txtPass.Text));
        }*/
        //----------------------------------------------------------------------------------------------------------------
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //-----------------------------------------------------------------------------------------------------------------
    }
}
