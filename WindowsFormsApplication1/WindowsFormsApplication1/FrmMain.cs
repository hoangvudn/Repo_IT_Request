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
    public partial class FrmMain : Form
    {
        //public static string con2 = ConfigurationManager.ConnectionStrings["ConnectITREQUEST"].ConnectionString;
        //public static SqlConnection con3 = new SqlConnection(con2);
        public FrmMain()
        {
            InitializeComponent();
          
        }
        //public  static SqlConnection con1 = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=IT_REQUEST;Integrated Security=True");
        //public static string con3 = System.Configuration.ConfigurationManager.ConnectionStrings["IT_REQUESTConnectionString"].ConnectionString;
        public static string con2 = ConfigurationManager.ConnectionStrings["IT_REQUESTConnectionString"].ConnectionString;
        public static SqlConnection con1 = new SqlConnection(con2);
       
        //-------------------------------Variable Global--------------------------------    -
        /*public class VariableGlobal
        {
            SqlConnection con1 = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=IT_REQUEST;Integrated Security=True");
            SqlConnection con1 = new SqlConnection(@"Data Source=10.65.2.217\SQLEXPRESS;Initial Catalog=IT_REQUEST;Persist Security Info=True;User ID=sa;Password=abc@123");
            <connectionStrings>
           <add name="WindowsFormsApplication1.Properties.Settings.IT_REQUESTConnectionString"
             connectionString="Data Source=10.65.0.6\SQLEXPRESS;Initial Catalog=IT_REQUEST;User ID=sa;Password=Abc@123"
            providerName="System.Data.SqlClient" />
          <add name="WindowsFormsApplication1.Properties.Settings.IT_REQUESTConnectionString1"
            connectionString="Data Source=10.65.0.6\SQLEXPRESS;Initial Catalog=IT_REQUEST;User ID=sa;Password=Abc@123"
            providerName="System.Data.SqlClient" />
          </connectionStrings>
        }*/
        //**********************************************************************************************************
        //***********************************CONNECTION STRING GLOBAL***********************************************
             
             //public static SqlConnection con1 = new SqlConnection(@"Data Source=10.65.0.6\SQLEXPRESS;Initial Catalog=IT_REQUEST;Persist Security Info=True;User ID=sa;Password=Abc@123");
             //public static SqlConnection con1 = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=IT_REQUEST;Integrated Security=True");
        //public static SqlConnection con1 = new SqlConnection(System.Configuration.ConfigurationManager.AppSettings["Connect"]);
        //public static SqlConnection con1 = new SqlConnection(System.Configuration.ConfigurationManager.AppSettings["WindowsFormsApplication1.Properties.Settings.IT_REQUESTConnectionString"]);
        //string con2 = ConfigurationManager.ConnectionStrings["WindowsFormsApplication1.Properties.Settings.IT_REQoUESTConnectionString"].ConnectionString;
       // SqlConnection con1 = new SqlConnection(con2);
  
        //------------------------------------------------------------------------

        public static string MD5Hash(string input)
        {
                 StringBuilder hash = new StringBuilder();
                 MD5CryptoServiceProvider md5provider = new MD5CryptoServiceProvider();
                 byte[] bytes = md5provider.ComputeHash(new UTF8Encoding().GetBytes(input));

                 for (int i = 0; i < bytes.Length; i++)
                 {
                     hash.Append(bytes[i].ToString("x2") + "b");
                 }
                 return hash.ToString();
        }
        //*************************************************************************************************************
        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FDepartment FD = new FDepartment();
            FD.Show();
        }
        //-------------------------------------------------------------------------
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //-------------------------------------------------------------------------
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmTest TestRP = new FrmTest();
            TestRP.Show();
        }
        //------------------------------------------------------------------------
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FStaffRequest FNhanvien = new FStaffRequest();
            FNhanvien.Show();
        }
        //------------------------------------------------------------------------
        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            FrmChucDanh FChucDanh = new FrmChucDanh();
            FChucDanh.Show();
        }
        //-------------------------------------------------------------------------
        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            FrmDanhMucYC FrmYC = new FrmDanhMucYC();
            FrmYC.Show();
        }
        //-------------------------------------------------------------------------
        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            FrmSendRequest FrmSenRQ = new FrmSendRequest();
            FrmSenRQ.Show();
        }
        //------------------------------------------------------------------------
        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            FrmCreatUser FrmCuser = new FrmCreatUser();
            FrmCuser.Show();
        }
        //------------------------------------------------------------------------
        private void FrmMain_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Hello User ID:"+FrmLogin.ID_USER);
            int per = FrmLogin.Perm;

            //string s = FrmLogin.ID_USER.ToString();
            if (per == 1)
            {
                toolStripMenuItem2.Enabled = false;
                toolStripMenuItem3.Enabled = false;
                toolStripMenuItem4.Enabled = false;
                toolStripMenuItem9.Enabled = false;
                loginToolStripMenuItem.Enabled = false;
            }
              
        }
        //-------------------------------------------------------------------
        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            FrmChangePass FChangPass = new FrmChangePass();
            FChangPass.Show();
        }
        //----------------------------------------------------------------------------
        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            FrmReportTest frmRPT = new FrmReportTest();
            frmRPT.Show();
        }
        //-----------------------------------------------------------------------------
        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            FrmMakeRequest FrmMRQ = new FrmMakeRequest();
            FrmMRQ.Show();
        }
        //-------------------------------------------------------------------
    }
}
