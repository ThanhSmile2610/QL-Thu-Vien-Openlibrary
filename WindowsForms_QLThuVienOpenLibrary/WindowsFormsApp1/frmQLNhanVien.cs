using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using OpenLibrary.DataAccess;
using OpenLibrary.Bussiness;

namespace WindowsFormsApp1
{
    public partial class frmQLNhanVien : Form
    {
        CtrQLNV ctr = new CtrQLNV();
        public frmQLNhanVien()
        {
            InitializeComponent();
            connect();
        }
        private SqlConnection conn;
        public void connect()
        {
            //Lấy chuỗi kết nối CSDL
            string strcon = "Data Source=LAPTOP-TT2BDHBO;Initial Catalog=OPENLIBRARY;Integrated Security=True";
            try
            {
                conn = new SqlConnection(strcon);
                // Mở kết nối
                conn.Open();
                //Ko làm gì thì đóng kết nối lại
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Không kết nối được CSDL", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmQLNhanVien_Load(object sender, EventArgs e)
        {
            dgvQLNV.DataSource = getDSNhanVien();
            DataTable table = getDSChiNhanh();
            DataTable table1 = getDSLoaiNhanVien();
            txtMaCN.DataSource = table;
            //Nội dung hiển thị lên combobox
            txtMaCN.DisplayMember = "TenCN";
            //giá trị truy xuất combobox
            txtMaCN.ValueMember = "MaCN";
            txtMaLoaiNV.DataSource = table1;
            //Nội dung hiển thị lên combobox
            txtMaLoaiNV.DisplayMember = "TenLoaiNV";
            //giá trị truy xuất combobox
            txtMaLoaiNV.ValueMember = "MaLoaiNV";
        }

        private void pHinhAnh_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg  = new OpenFileDialog())
            {
                dlg.Title = "Open Image";
                dlg.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp, *.png) | *.jpg; *.jpeg; *.gif;";
                if(dlg.ShowDialog() == DialogResult.OK)
                {
                    pHinhAnh.Image = new Bitmap(dlg.FileName);
                    pHinhAnh.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
        }
        string TenNV, CMND, Sdt, DiaChi, Email, UserName, Password, MaCN, MaLoaiNV;

        private void dgvQLNV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string tenNV = txtHoTenNV.Text;
            string cMND = txtCMND.Text;
            string sDT = txtSDT.Text;
            string diaChi = txtDiaChi.Text;
            string email = txtEmail.Text;
            int maCN = int.Parse(txtMaCN.SelectedValue.ToString());
            int maLoaiNV = int.Parse(txtMaLoaiNV.SelectedValue.ToString());
            string userName = txtUserName.Text;
            string password = txtPassword.Text;

            try
            {
                conn.Open();

                string strSQL = "UPDATE NHANVIEN " + "SET HoTenNV = @TenNV, CMND = @CMND, SDT = @SDT, DiaChi = @DiaChi, Email = @Email, MaCN = @MaCN, MaLoaiNV = @MaLoaiNV, UserName = @UserName, Password = @Password " +"WHERE UserName = @CurrentUserName";

                SqlCommand cmd = new SqlCommand(strSQL, conn);
                cmd.Parameters.AddWithValue("@TenNV", tenNV);
                cmd.Parameters.AddWithValue("@CMND", cMND);
                cmd.Parameters.AddWithValue("@SDT", sDT);
                cmd.Parameters.AddWithValue("@DiaChi", diaChi);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@MaCN", maCN);
                cmd.Parameters.AddWithValue("@MaLoaiNV", maLoaiNV);
                cmd.Parameters.AddWithValue("@UserName", userName);
                cmd.Parameters.AddWithValue("@Password", password);
                cmd.Parameters.AddWithValue("@CurrentUserName", txtUserName.Text);

                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Cập nhật dữ liệu thành công");
                dgvQLNV.DataSource = getDSNhanVien(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cập nhật bị lỗi: " + ex.Message);
            }
        }

        private void dgvQLNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvQLNV.Rows[e.RowIndex];

                txtHoTenNV.Text = row.Cells["HoTenNV"].Value.ToString();
                txtCMND.Text = row.Cells["CMND"].Value.ToString();
                txtSDT.Text = row.Cells["SDT"].Value.ToString();
                txtDiaChi.Text = row.Cells["DiaChi"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();
                txtMaCN.SelectedValue = row.Cells["MaCN"].Value;
                txtMaLoaiNV.SelectedValue = row.Cells["MaLoaiNV"].Value;
                txtUserName.Text = row.Cells["UserName"].Value.ToString();
                txtPassword.Text = row.Cells["Password"].Value.ToString();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;

            if (string.IsNullOrEmpty(userName))
            {
                MessageBox.Show("Vui lòng nhập UserName muốn xóa!");
                return;
            }

            try
            {
                conn.Open();
                string strSQL = "DELETE FROM NHANVIEN WHERE UserName = @UserName";
                SqlCommand cmd = new SqlCommand(strSQL, conn);
                cmd.Parameters.AddWithValue("@UserName", userName);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Xóa dữ liệu thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa bị lỗi" + ex.ToString());
            }
            dgvQLNV.DataSource = getDSNhanVien();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            TenNV = txtHoTenNV.Text;
            CMND = txtCMND.Text;
            Sdt = txtSDT.Text;
            DiaChi = txtDiaChi.Text;
            Email = txtEmail.Text;
            MaCN = txtMaCN.SelectedValue.ToString();
            MaLoaiNV = txtMaLoaiNV.SelectedValue.ToString();
            UserName = txtUserName.Text;
            Password = txtPassword.Text;
            try
            {
                conn.Open();

                string str = "INSERT INTO NHANVIEN (HoTenNV, CMND, SDT, DiaChi, Email, MaCN, MaLoaiNV, UserName, Password) " + "VALUES (@TenNV, @CMND, @Sdt, @DiaChi, @Email, @MaCN, @MaLoaiNV, @UserName, @Password)";

                SqlCommand cmd = new SqlCommand(str, conn);
                cmd.Parameters.AddWithValue("@TenNV", TenNV);
                cmd.Parameters.AddWithValue("@CMND", CMND);
                cmd.Parameters.AddWithValue("@Sdt", Sdt);
                cmd.Parameters.AddWithValue("@DiaChi", DiaChi);
                cmd.Parameters.AddWithValue("@Email", Email);
                cmd.Parameters.AddWithValue("@MaCN", MaCN);
                cmd.Parameters.AddWithValue("@MaLoaiNV", MaLoaiNV);
                cmd.Parameters.AddWithValue("@UserName", UserName);
                cmd.Parameters.AddWithValue("@Password", Password);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Thêm dữ liệu thành công");
                txtHoTenNV.Text = "";
                txtCMND.Text = "";
                txtSDT.Text = "";
                txtDiaChi.Text = "";
                txtEmail.Text = "";
                MaCN = txtMaCN.SelectedValue.ToString();
                MaLoaiNV = txtMaLoaiNV.SelectedValue.ToString();
                txtUserName.Text = "";
                txtPassword.Text = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm dữ liệu bị lỗi: " + ex.Message);
            }
            finally
            {
                conn.Close(); 
            }
            dgvQLNV.DataSource = getDSNhanVien();
        }
        public DataTable getDSChiNhanh()
        {
            string strSQL = "Select * from CHINHANH";
            SqlDataAdapter adapter;
            adapter = new SqlDataAdapter(strSQL, conn);
            DataSet dataset = new DataSet();
            try
            {
                adapter.Fill(dataset);
                return dataset.Tables[0];
            }
            catch
            {
                return null;
            }
        }
        public DataTable getDSLoaiNhanVien()
        {
            string strSQL = "Select * from LOAINHANVIEN";
            SqlDataAdapter adapter;
            adapter = new SqlDataAdapter(strSQL, conn);
            DataSet dataset = new DataSet();
            try
            {
                adapter.Fill(dataset);
                return dataset.Tables[0];
            }
            catch
            {
                return null;
            }
        }
        private DataTable getDSNhanVien()
        {
            string str = "Select nv.MaNV, nv.HoTenNV, nv.CMND, nv.SDT, nv.DiaChi, nv.Email, nv.HinhAnh, nv.MaCN, nv.MaLoaiNV, nv.UserName, nv.Password From NHANVIEN nv";
            SqlDataAdapter adapter = new SqlDataAdapter(str, conn);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            return dataSet.Tables[0];
        }
    }
}
