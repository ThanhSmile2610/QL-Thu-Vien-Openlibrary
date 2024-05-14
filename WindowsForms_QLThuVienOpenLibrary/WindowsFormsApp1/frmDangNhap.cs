using OpenLibrary.Bussiness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmDangNhap : Form
    {
        CtrDangNhap ctrDangNhap = new CtrDangNhap();
        public frmDangNhap()
        {
            InitializeComponent();
        }
        private bool validateData()
        {
            errorProvider1.SetError(txtUserName, (txtUserName.Text == "") ? "Hãy nhập UserName " : "");
            errorProvider1.SetError(txtPassword, (txtPassword.Text == "") ? "Hãy nhập PassWord " : "");
            return (txtUserName.Text != "" && txtPassword.Text != "");
        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (!validateData())
                return;
            bool isAutheticated = ctrDangNhap.login(txtUserName.Text, txtPassword.Text);
                if (isAutheticated)
                {
                    var f = (frmMain)this.ParentForm;
                    f.xuLyLogin();
                    this.Close();
                }
                else
                    MessageBox.Show("Sai UserName và Password", "Lỗi Đăng Nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}
