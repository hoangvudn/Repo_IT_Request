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
    public partial class FDepartment : Form
    {
        public FDepartment()
        {
            InitializeComponent();
        }
        //SqlConnection con1 = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=IT_REQUEST;Integrated Security=True");
        //SqlConnection con1 = new SqlConnection(@"Data Source=10.65.2.217\SQLEXPRESS;Initial Catalog=IT_REQUEST;Persist Security Info=True;User ID=sa;Password=abc@123");
        //String imgLocation = "";
        //SqlDataReader dr;
       
        private void FDepartment_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iT_REQUESTDataSet.PHONGBAN' table. You can move, or remove it, as needed.
           // this.pHONGBANTableAdapter.Fill(this.iT_REQUESTDataSet.PHONGBAN);
            DisplayDgvPhongBan();
            btnXoa.Enabled = false;
            btnLuu.Enabled = false;
            btnSua.Enabled = false;
            //txtMaBP.Text = DateTime.Today.ToShortTimeString();
            //txtMaBP.Text = DateTime.Now.Hour.ToString();
            //txtMaBP.Text = DateTime.Now.ToShortTimeString();
        }
        //------------------------------------------------------------
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        //--------------------------Clear all Text----------------------------------------------
        void ClearText()
        {
            txtMaBP.Text = "";
            txtTenBP.Text = "";
            txtMaBP.Focus();
        }
        //---------------------------------------------------------------------------------------
        //-----------------Display Information Department on Datagridview------------------------ 
        void DisplayDgvPhongBan()
        {
            if ( FrmMain.con1.State == ConnectionState.Closed)
            FrmMain.con1.Open();
             string query = @"Select * From PHONGBAN";
             SqlCommand cmd = new SqlCommand(query, FrmMain.con1);
             cmd.ExecuteNonQuery();
             DataTable dt = new DataTable();
             SqlDataAdapter da = new SqlDataAdapter(cmd);
             da.Fill(dt);
            dgvPhongBan.DataSource = dt;
            FrmMain.con1.Close();
        }
        //-----------------------------------------------------------------------------------------
        private void btnThem_Click(object sender, EventArgs e)
        {
            ClearText();
            btnThem.Enabled = false;
            btnLuu.Enabled = true;
            btnXoa.Enabled = false;
        }
        //-----------------------------------------------------------------------------------------
        //--------------------------------SAVE FUNCTION--------------------------------------------
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMaBP.Text == "" || txtTenBP.Text == " ")
            {
                MessageBox.Show("INPUT DATA PLEASE!!!!!");
            }
            else
            {
                DialogResult Dlr = MessageBox.Show("Do you want Save", "Title", MessageBoxButtons.YesNo);
                if (Dlr == DialogResult.Yes)
                {
                    String che = @"( SELECT COUNT(*) FROM PHONGBAN WHERE MaPB='" + txtMaBP.Text + "') ";
                    FrmMain.con1.Open();
                    SqlCommand Sqlcmd = new SqlCommand("InsertOrEditPB", FrmMain.con1);
                     Sqlcmd.CommandType = CommandType.StoredProcedure;
                     Sqlcmd.Parameters.AddWithValue("@Mode", "New");
                     Sqlcmd.Parameters.AddWithValue("@MaPB", txtMaBP.Text.Trim());
                     Sqlcmd.Parameters.AddWithValue("@TenPB", txtTenBP.Text.Trim());
                     SqlCommand cmd = new SqlCommand(che, FrmMain.con1);
                     int count = (int)cmd.ExecuteScalar();
                     if(count>0)
                     {
                         MessageBox.Show("Ma Phong Ban already exits");
                         btnLuu.Enabled = true;
                         btnThem.Enabled = false;
                     }
                     else
                     {
                         Sqlcmd.ExecuteNonQuery();
                         MessageBox.Show("UPDATE SUCCESSFULLY!!!!!");
                         DisplayDgvPhongBan();
                         btnThem.Enabled = true;
                         
                     }
                     FrmMain.con1.Close();
                }
            }
        }
        //----------------------------------------------------------
        //---------------------Delete Function----------------------
        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult Dlr = MessageBox.Show("Do you want Delete", "Delete", MessageBoxButtons.YesNo);
            if(Dlr == DialogResult.Yes)
            {
                try
                {
                    FrmMain.con1.Open();
                    SqlCommand Sqlcmd = new SqlCommand("DeletePB", FrmMain.con1);
                    Sqlcmd.CommandType = CommandType.StoredProcedure;
                    Sqlcmd.Parameters.AddWithValue("@MaPB", txtMaBP.Text.Trim());
                    Sqlcmd.ExecuteNonQuery();
                    MessageBox.Show("Deleted Successfully!!!!!");
                    DisplayDgvPhongBan();
                    //ClearText();
                    FrmMain.con1.Close();
                }
                catch (Exception )
                {
                    MessageBox.Show("Ma Phong Ban already exits on Another Table ");
                }
                finally
                {
                    if (FrmMain.con1.State == ConnectionState.Open)
                        FrmMain.con1.Close();
                }

            }
        }
        //-----------------------------------------------------------------------------
        //----------------------Event display information on textbox when click on datagridview PHONGBAN--------------
        private void dgvPhongBan_Click(object sender, EventArgs e)
        {
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            if(dgvPhongBan.CurrentRow.Index!=-1)
            {
                txtMaBP.Text = dgvPhongBan.CurrentRow.Cells[0].Value.ToString();
                txtTenBP.Text = dgvPhongBan.CurrentRow.Cells[1].Value.ToString();
            }
        }
        //-------------------------------------------------------------------------------
        //-------------------------------Edit Function-----------------------------------
        private void btnSua_Click(object sender, EventArgs e)
        {
            DialogResult Dlr = MessageBox.Show("Do you want Update?", "UPDATE", MessageBoxButtons.YesNo);
            if(Dlr==DialogResult.Yes)
            {
                try
                {
                    FrmMain.con1.Open();
                    SqlCommand Sqlcmd = new SqlCommand("InsertOrEditPB", FrmMain.con1);
                    Sqlcmd.CommandType=CommandType.StoredProcedure;
                    Sqlcmd.Parameters.AddWithValue("@Mode","Edit");
                    Sqlcmd.Parameters.AddWithValue("@MaPB",txtMaBP.Text.Trim());
                    Sqlcmd.Parameters.AddWithValue("@TenPB",txtTenBP.Text.Trim());
                    Sqlcmd.ExecuteNonQuery();
                    MessageBox.Show("UPDATED SUCCESSFULLY!!!!!");
                    DisplayDgvPhongBan();
                    FrmMain.con1.Close();
                }
                /*catch(Exception)
                {
                    MessageBox.Show("Da ton tai ma pb ben bang khac Relationship!!!!!");
                }*/
                finally
                {
                    if (FrmMain.con1.State == ConnectionState.Open)
                        FrmMain.con1.Close();
                }
            }
        }

        private void dgvPhongBan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //----------------------------------------------------------------
    }
}
