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
    public partial class FrmTest : Form
    {
        public FrmTest()
        {
            InitializeComponent();
        }
        //--------------------------Connection String-------------------------------------------------
         //SqlConnection con1 = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=IT_REQUEST;Integrated Security=True");
         //SqlConnection con1 = new SqlConnection(@"Data Source=10.65.2.217\SQLEXPRESS;Initial Catalog=IT_REQUEST;Persist Security Info=True;User ID=sa;Password=abc@123");
        //------------------------------------------------------------------------------ 
        //SqlDataReader dr;
        private void FrmTest_Load(object sender, EventArgs e)
        {
           /* if (FrmMain.con1.State == ConnectionState.Closed)
                FrmMain.con1.Open();
            string query = @"Select a.MaNV, a.TenNV, b.TestData From NHANVIEN a, CHUKY b Where a.IdSignature=b.IdSignature";
            SqlCommand cmd = new SqlCommand(query, FrmMain.con1);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            //da.Dispose();
            dgvTest.DataSource = dt;
            FrmMain.con1.Close();*/
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
           /* //When write SQL command to long. So We need add '@' before SQL command
            string query = @"Select  RequestSend.RequestID, RequestSend.RequestName, ChucDanh.TenCD  From
            RequestSend,CHUCDANH Where RequestSend.MaCD=ChucDanh.MaCD ";
            SqlCommand cmd= new SqlCommand(query,con1);
            con1.Open();
            cmd.ExecuteNonQuery();
            DataTable dt=new DataTable();
            SqlDataAdapter da=new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvTestRport.DataSource=dt;
            con1.Close();

                 /*From REQUESTSEND AS RS
                 INNER JOIN PHONGBAN ON RS.MaPB=PHONGBAN.MaPB
                 INNER JOIN NHANVIEN ON RS.MaNV=NHANVIEN.MaNV
				 INNER JOIN CHUCDANH ON RS.MaCD=CHUCDANH.MaCD
				 INNER JOIN LOAIYEUCAU ON RS.MaLoaiYC=LOAIYEUCAU.MaLoaiYC ";*/
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        /*private void button1_Click(object sender, EventArgs e)
        {
            con1.Open();
            string query = @"Select  RequestSend.RequestID, RequestSend.RequestName, ChucDanh.TenCD  From
            RequestSend,CHUCDANH Where RequestSend.MaCD=ChucDanh.MaCD ";
            SqlCommand cmd = new SqlCommand(query, con1);
            dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                ListViewItem lv = new ListViewItem(dr[0].ToString());
                lv.SubItems.Add(dr[1].ToString());
                lv.SubItems.Add(dr[2].ToString());
                lVTest.Items.Add(lv);
            }
            con1.Close();
            
        }*/
    }
}
