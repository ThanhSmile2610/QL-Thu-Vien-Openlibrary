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
    public partial class frmMain : Form
    {
        CtrMain ctr = new CtrMain();
        public frmMain()
        {
            InitializeComponent();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnDangNhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (LoginInfo.MaNV == -1)
            {
                frmDangNhap f = new frmDangNhap();
                f.MdiParent = this;
                f.StartPosition = FormStartPosition.CenterParent;
                f.Show();
            }
            else
            {
                ctr.logout();
                xuLyLogin();
            }
        }

        public void xuLyLogin()
        {

            this.Text = (LoginInfo.HoTenNV != "") ? "OpenLibrary" : "OpenLibrary - Xin Chao " + LoginInfo.HoTenNV;
            btnDangNhap.Caption = (LoginInfo.MaNV == -1) ? "Đăng nhập" : "Đăng xuất";
            btnThongTinCaNhan.Enabled = (LoginInfo.MaNV != -1);
            btnDoiMatKhau.Enabled = (LoginInfo.MaNV != -1);
            rbPhanQuyenHeThong.Visible = (LoginInfo.MaLoaiNV == 1);
            rbQLTaiNguyen.Visible = (LoginInfo.MaLoaiNV == 1);
            rbQLMuonTraSach.Visible = (LoginInfo.MaLoaiNV == 2);
        }
        public void frmMain_Load(object sender, EventArgs e)
        {
            xuLyLogin();
        }

        private void btnQLChuyenNghanh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmQLChuyenNganh f = (frmQLChuyenNganh)this.MdiChildren.FirstOrDefault( k => k is frmQLChuyenNganh );
            if (f == null) 
            {
                f = new frmQLChuyenNganh();
                f.MdiParent = this;
                f.WindowState = FormWindowState.Maximized;
                f.Show();
            }
            else
            {
                f.WindowState= FormWindowState.Maximized;
                this.ActivateMdiChild(f);
            }
        }

        private void frmMain_Load_1(object sender, EventArgs e)
        {

        }

        private void btnQLNhanVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmQLNhanVien f = (frmQLNhanVien)this.MdiChildren.FirstOrDefault(k => k is frmQLNhanVien);
            if (f == null)
            {
                f = new frmQLNhanVien();
                f.MdiParent = this;
                f.WindowState = FormWindowState.Maximized;
                f.Show();
            }
            else
            {
                f.WindowState = FormWindowState.Maximized;
                this.ActivateMdiChild(f);
            }
        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }
    }
}

