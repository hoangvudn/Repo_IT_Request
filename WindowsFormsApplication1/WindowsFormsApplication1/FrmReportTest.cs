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
using Microsoft.Reporting.WinForms;
namespace WindowsFormsApplication1
{
    public partial class FrmReportTest : Form
    {
        public FrmReportTest()
        {
            InitializeComponent();
        }
        //SqlConnection con1 = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=IT_REQUEST;Integrated Security=True");
        //SqlConnection con1 = new SqlConnection(@"Data Source=10.65.2.217\SQLEXPRESS;Initial Catalog=IT_REQUEST;Persist Security Info=True;User ID=sa;Password=abc@123");
        //-----------------------------------------------------------SHOW REPORT------------------------------------------------------------------------------
        private void btnShowRP_Click(object sender, EventArgs e)
        {
            if (rbNoiDung.Checked == true)
            {
                FrmMain.con1.Open();
                SqlDataAdapter sqlSDa = new SqlDataAdapter("ViewReportNoiDungSR", FrmMain.con1);
                sqlSDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlSDa.SelectCommand.Parameters.AddWithValue("@RequestID", txtMaNV.Text.Trim());
                sqlSDa.SelectCommand.Parameters.AddWithValue("@RequestName", txtMaNV.Text.Trim());
                sqlSDa.SelectCommand.Parameters.AddWithValue("@MaNV", txtMaNV.Text.Trim());
                //sqlSDa.SelectCommand.Parameters.AddWithValue("@NgayGui", dtNgayGui.Value.Date);
                DataTable dtb = new DataTable();
           
                sqlSDa.Fill(dtb);
                FrmMain.con1.Close();
                WindowsFormsApplication1.CReportMain.CReportEx1 crpTest = new CReportMain.CReportEx1();

                crpTest.Database.Tables["ViewReportNoiDungSR"].SetDataSource(dtb);
                //crpTest.Database.Tables["NHANVIEN"].SetDataSource(dtb.Tables[1]);
                crystalReportViewer1.ReportSource = null;
                crystalReportViewer1.ReportSource = crpTest;
            }
            //-----------------------------------------------------------------------------------------------------
            //-----------------------------------------------------------------------------------------------------
            if (rbNgayThang.Checked == true)
            {
                FrmMain.con1.Open();
                SqlDataAdapter sqlSDa = new SqlDataAdapter("ViewReportNgayThangSR", FrmMain.con1);
                sqlSDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                //sqlSDa.SelectCommand.Parameters.AddWithValue("@MaNV", txtMaNV.Text.Trim());
                sqlSDa.SelectCommand.Parameters.AddWithValue("@NgayGui", dtNgayGui.Value.Date);
                DataTable dtb = new DataTable();
                sqlSDa.Fill(dtb);
                FrmMain.con1.Close();
                WindowsFormsApplication1.CReportMain.CReportEx1 crpTest = new CReportMain.CReportEx1();
                crpTest.Database.Tables["REQUESTSEND"].SetDataSource(dtb);
                crystalReportViewer1.ReportSource = null;
                crystalReportViewer1.ReportSource = crpTest;
            }
        }
        //--------------------------------------------------------------------------
        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
        //--------------------------------------------------------------------------
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        //--------------------------------------------------------------------------
        private void FrmReportTest_Load(object sender, EventArgs e)
        {

        }
        //-----------------------------------------------------------------------
    }
}
