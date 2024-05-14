using OpenLibrary.Bussiness;
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
using OpenLibrary.DataAccess;

namespace WindowsFormsApp1
{
    public partial class frmQLChuyenNganh : Form
    {
        CtrChuyenNganh ctr = new CtrChuyenNganh();
        public frmQLChuyenNganh()
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
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtChuyenNganh.Text.Trim() == "") 
            {
                errorProvider1.SetError(txtChuyenNganh, "Hãy nhập tên cần sửa chuyên ngành!");
                return;
            }

            string currentChuyenNganh = dgvChuyenNghanh.CurrentRow?.Cells["TenCN"]?.Value?.ToString();

            if (string.IsNullOrEmpty(currentChuyenNganh))
            {
                MessageBox.Show("Vui lòng chọn một chuyên ngành để sửa.");
                return;
            }

            string newChuyenNganh = txtChuyenNganh.Text.Trim(); 

            if (ctr.SuaCN(currentChuyenNganh, newChuyenNganh) == false)
            {
                MessageBox.Show("Sửa thất bại");
            }
            else
            {
               
                MessageBox.Show("Sửa thành công");
            }
            dgvChuyenNghanh.DataSource = getDSChuyenNganh();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtChuyenNganh.Text == "")
                errorProvider1.SetError(txtChuyenNganh, "Hay nhap ten chuyen nghanh");
            else
            {
                if (ctr.ThemChuyenNghanh(txtChuyenNganh.Text) == false)
                    MessageBox.Show("Them that bai");
            }
            dgvChuyenNghanh.DataSource = getDSChuyenNganh();
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            string currentChuyenNganh = dgvChuyenNghanh.CurrentRow?.Cells["TenCN"]?.Value?.ToString();

            if (string.IsNullOrEmpty(currentChuyenNganh))
            {
                MessageBox.Show("Vui lòng chọn một chuyên ngành để xóa.");
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa chuyên ngành " + currentChuyenNganh + " hay không?", "Xác nhận xóa", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                if (ctr.XoaCN(currentChuyenNganh) == false)
                {
                    MessageBox.Show("Xóa chuyên ngành thất bại");
                }
                else
                {
                    
                    MessageBox.Show("Xóa chuyên ngành " + currentChuyenNganh + " thành công");
                }
            }
            dgvChuyenNghanh.DataSource = getDSChuyenNganh();
        }
        private void dgvChuyenNghanh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmQLChuyenNghanh_Load(object sender, EventArgs e)
        {
            dgvChuyenNghanh.DataSource = getDSChuyenNganh();
        }
        private void dgvChuyenNghanh_SelectionChanged(object sender, EventArgs e)
        {
            String s = dgvChuyenNghanh.CurrentRow.Cells["TenCN"].Value.ToString();
            if (s != null && s != "") txtChuyenNganh.Text = s;
        }
        private DataTable getDSChuyenNganh()
        {
            string str = "Select cn.MaCN, cn.TenCN From CHUYENNGANH cn";
            SqlDataAdapter adapter = new SqlDataAdapter(str, conn);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            return dataSet.Tables[0];
        }
    }
}
