namespace WindowsFormsApp1
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnDangNhap = new DevExpress.XtraBars.BarButtonItem();
            this.galleryDropDown1 = new DevExpress.XtraBars.Ribbon.GalleryDropDown(this.components);
            this.btnThongTinCaNhan = new DevExpress.XtraBars.BarButtonItem();
            this.btnDoiMatKhau = new DevExpress.XtraBars.BarButtonItem();
            this.btnQLChiNhanh = new DevExpress.XtraBars.BarButtonItem();
            this.btnQLChuyenNghanh = new DevExpress.XtraBars.BarButtonItem();
            this.btnQLSach = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhanBoSach = new DevExpress.XtraBars.BarButtonItem();
            this.btnThongKeYeuCauMuaSach = new DevExpress.XtraBars.BarButtonItem();
            this.btnQLDocGia = new DevExpress.XtraBars.BarButtonItem();
            this.btnQLMuonTraSach = new DevExpress.XtraBars.BarButtonItem();
            this.btnQLLoaiNV = new DevExpress.XtraBars.BarButtonItem();
            this.btnQLNhanVien = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rbHeThong = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbQLTaiNguyen = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbQLMuonTraSach = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbPhanQuyenHeThong = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.galleryDropDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.btnDangNhap,
            this.btnThongTinCaNhan,
            this.btnDoiMatKhau,
            this.btnQLChiNhanh,
            this.btnQLChuyenNghanh,
            this.btnQLSach,
            this.btnPhanBoSach,
            this.btnThongKeYeuCauMuaSach,
            this.btnQLDocGia,
            this.btnQLMuonTraSach,
            this.btnQLLoaiNV,
            this.btnQLNhanVien});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 13;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(1322, 183);
            this.ribbonControl1.Click += new System.EventHandler(this.ribbonControl1_Click);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.ActAsDropDown = true;
            this.btnDangNhap.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.btnDangNhap.Caption = "Đăng Nhập";
            this.btnDangNhap.DropDownControl = this.galleryDropDown1;
            this.btnDangNhap.Id = 1;
            this.btnDangNhap.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDangNhap.ImageOptions.SvgImage")));
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDangNhap_ItemClick);
            // 
            // galleryDropDown1
            // 
            this.galleryDropDown1.Name = "galleryDropDown1";
            this.galleryDropDown1.Ribbon = this.ribbonControl1;
            // 
            // btnThongTinCaNhan
            // 
            this.btnThongTinCaNhan.Caption = "Thông tin cá nhân";
            this.btnThongTinCaNhan.Id = 2;
            this.btnThongTinCaNhan.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThongTinCaNhan.ImageOptions.Image")));
            this.btnThongTinCaNhan.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThongTinCaNhan.ImageOptions.LargeImage")));
            this.btnThongTinCaNhan.Name = "btnThongTinCaNhan";
            // 
            // btnDoiMatKhau
            // 
            this.btnDoiMatKhau.Caption = "Đổi mật khẩu";
            this.btnDoiMatKhau.Id = 3;
            this.btnDoiMatKhau.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDoiMatKhau.ImageOptions.Image")));
            this.btnDoiMatKhau.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDoiMatKhau.ImageOptions.LargeImage")));
            this.btnDoiMatKhau.Name = "btnDoiMatKhau";
            // 
            // btnQLChiNhanh
            // 
            this.btnQLChiNhanh.Caption = "Quản Lý Chi Nhánh";
            this.btnQLChiNhanh.Id = 4;
            this.btnQLChiNhanh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnQLChiNhanh.ImageOptions.Image")));
            this.btnQLChiNhanh.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnQLChiNhanh.ImageOptions.LargeImage")));
            this.btnQLChiNhanh.Name = "btnQLChiNhanh";
            // 
            // btnQLChuyenNghanh
            // 
            this.btnQLChuyenNghanh.Caption = "Quản Lý Chuyên Nghành";
            this.btnQLChuyenNghanh.Id = 5;
            this.btnQLChuyenNghanh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnQLChuyenNghanh.ImageOptions.Image")));
            this.btnQLChuyenNghanh.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnQLChuyenNghanh.ImageOptions.LargeImage")));
            this.btnQLChuyenNghanh.Name = "btnQLChuyenNghanh";
            this.btnQLChuyenNghanh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnQLChuyenNghanh_ItemClick);
            // 
            // btnQLSach
            // 
            this.btnQLSach.Caption = "Quản Lý Sách";
            this.btnQLSach.Id = 6;
            this.btnQLSach.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnQLSach.ImageOptions.Image")));
            this.btnQLSach.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnQLSach.ImageOptions.LargeImage")));
            this.btnQLSach.Name = "btnQLSach";
            // 
            // btnPhanBoSach
            // 
            this.btnPhanBoSach.Caption = "Phân Bổ Sách";
            this.btnPhanBoSach.Id = 7;
            this.btnPhanBoSach.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPhanBoSach.ImageOptions.Image")));
            this.btnPhanBoSach.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnPhanBoSach.ImageOptions.LargeImage")));
            this.btnPhanBoSach.Name = "btnPhanBoSach";
            // 
            // btnThongKeYeuCauMuaSach
            // 
            this.btnThongKeYeuCauMuaSach.Caption = "Thống Kê Yêu Cầu Mua Sách";
            this.btnThongKeYeuCauMuaSach.Id = 8;
            this.btnThongKeYeuCauMuaSach.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThongKeYeuCauMuaSach.ImageOptions.Image")));
            this.btnThongKeYeuCauMuaSach.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThongKeYeuCauMuaSach.ImageOptions.LargeImage")));
            this.btnThongKeYeuCauMuaSach.Name = "btnThongKeYeuCauMuaSach";
            // 
            // btnQLDocGia
            // 
            this.btnQLDocGia.Caption = "Quản Lý Đọc Giả";
            this.btnQLDocGia.Id = 9;
            this.btnQLDocGia.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnQLDocGia.ImageOptions.Image")));
            this.btnQLDocGia.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnQLDocGia.ImageOptions.LargeImage")));
            this.btnQLDocGia.Name = "btnQLDocGia";
            this.btnQLDocGia.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // btnQLMuonTraSach
            // 
            this.btnQLMuonTraSach.Caption = "Quản Lý Mượn Trả Sách";
            this.btnQLMuonTraSach.Id = 10;
            this.btnQLMuonTraSach.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnQLMuonTraSach.ImageOptions.SvgImage")));
            this.btnQLMuonTraSach.Name = "btnQLMuonTraSach";
            // 
            // btnQLLoaiNV
            // 
            this.btnQLLoaiNV.Caption = "Quản Lý Loại Nhân Viên";
            this.btnQLLoaiNV.Id = 11;
            this.btnQLLoaiNV.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnQLLoaiNV.ImageOptions.SvgImage")));
            this.btnQLLoaiNV.Name = "btnQLLoaiNV";
            // 
            // btnQLNhanVien
            // 
            this.btnQLNhanVien.Caption = "Quản Lý Nhân Viên";
            this.btnQLNhanVien.Id = 12;
            this.btnQLNhanVien.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnQLNhanVien.ImageOptions.Image")));
            this.btnQLNhanVien.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnQLNhanVien.ImageOptions.LargeImage")));
            this.btnQLNhanVien.Name = "btnQLNhanVien";
            this.btnQLNhanVien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnQLNhanVien_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rbHeThong,
            this.rbQLTaiNguyen,
            this.rbQLMuonTraSach,
            this.rbPhanQuyenHeThong});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ribbonPage1";
            // 
            // rbHeThong
            // 
            this.rbHeThong.ItemLinks.Add(this.btnDangNhap);
            this.rbHeThong.ItemLinks.Add(this.btnThongTinCaNhan);
            this.rbHeThong.ItemLinks.Add(this.btnDoiMatKhau);
            this.rbHeThong.Name = "rbHeThong";
            this.rbHeThong.Text = "Hệ Thống";
            // 
            // rbQLTaiNguyen
            // 
            this.rbQLTaiNguyen.ItemLinks.Add(this.btnQLChiNhanh);
            this.rbQLTaiNguyen.ItemLinks.Add(this.btnQLChuyenNghanh);
            this.rbQLTaiNguyen.ItemLinks.Add(this.btnQLSach);
            this.rbQLTaiNguyen.ItemLinks.Add(this.btnPhanBoSach);
            this.rbQLTaiNguyen.ItemLinks.Add(this.btnThongKeYeuCauMuaSach);
            this.rbQLTaiNguyen.Name = "rbQLTaiNguyen";
            this.rbQLTaiNguyen.Text = "Quản Lý Tài Nguyên";
            // 
            // rbQLMuonTraSach
            // 
            this.rbQLMuonTraSach.ItemLinks.Add(this.btnQLDocGia);
            this.rbQLMuonTraSach.ItemLinks.Add(this.btnQLMuonTraSach);
            this.rbQLMuonTraSach.Name = "rbQLMuonTraSach";
            this.rbQLMuonTraSach.Text = "Quản Lý Mượn Trả Sách";
            // 
            // rbPhanQuyenHeThong
            // 
            this.rbPhanQuyenHeThong.ItemLinks.Add(this.btnQLLoaiNV);
            this.rbPhanQuyenHeThong.ItemLinks.Add(this.btnQLNhanVien);
            this.rbPhanQuyenHeThong.Name = "rbPhanQuyenHeThong";
            this.rbPhanQuyenHeThong.Text = "Phân Quyền Hệ Thống";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1322, 450);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMain_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.galleryDropDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbHeThong;
        private DevExpress.XtraBars.BarButtonItem btnDangNhap;
        private DevExpress.XtraBars.Ribbon.GalleryDropDown galleryDropDown1;
        private DevExpress.XtraBars.BarButtonItem btnThongTinCaNhan;
        private DevExpress.XtraBars.BarButtonItem btnDoiMatKhau;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbQLTaiNguyen;
        private DevExpress.XtraBars.BarButtonItem btnQLChiNhanh;
        private DevExpress.XtraBars.BarButtonItem btnQLChuyenNghanh;
        private DevExpress.XtraBars.BarButtonItem btnQLSach;
        private DevExpress.XtraBars.BarButtonItem btnPhanBoSach;
        private DevExpress.XtraBars.BarButtonItem btnThongKeYeuCauMuaSach;
        private DevExpress.XtraBars.BarButtonItem btnQLDocGia;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbQLMuonTraSach;
        private DevExpress.XtraBars.BarButtonItem btnQLMuonTraSach;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbPhanQuyenHeThong;
        private DevExpress.XtraBars.BarButtonItem btnQLLoaiNV;
        private DevExpress.XtraBars.BarButtonItem btnQLNhanVien;
    }
}

