namespace BookShop.GUI
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelMain = new System.Windows.Forms.Panel();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barNhanVien = new DevExpress.XtraBars.BarButtonItem();
            this.barTheLoai = new DevExpress.XtraBars.BarButtonItem();
            this.barNhaXuatBan = new DevExpress.XtraBars.BarButtonItem();
            this.barTacGia = new DevExpress.XtraBars.BarButtonItem();
            this.barSach = new DevExpress.XtraBars.BarButtonItem();
            this.barVanPhongPham = new DevExpress.XtraBars.BarButtonItem();
            this.barNhapHang = new DevExpress.XtraBars.BarButtonItem();
            this.barBanHang = new DevExpress.XtraBars.BarButtonItem();
            this.barTimKiemSach = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem11 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem12 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem13 = new DevExpress.XtraBars.BarButtonItem();
            this.barThongKeBanHang = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barThongTinCaNhan = new DevExpress.XtraBars.BarButtonItem();
            this.barDoiMatKhau = new DevExpress.XtraBars.BarButtonItem();
            this.barLapPhieuNhap = new DevExpress.XtraBars.BarButtonItem();
            this.barLapPhieuXuat = new DevExpress.XtraBars.BarButtonItem();
            this.barKho = new DevExpress.XtraBars.BarButtonItem();
            this.barDangXuat = new DevExpress.XtraBars.BarButtonItem();
            this.pageNhanVien = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.pageQuanTri = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panelMain);
            this.panel1.Controls.Add(this.ribbonControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(20, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1310, 690);
            this.panel1.TabIndex = 0;
            // 
            // panelMain
            // 
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 140);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1308, 548);
            this.panelMain.TabIndex = 1;
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.barNhanVien,
            this.barTheLoai,
            this.barNhaXuatBan,
            this.barTacGia,
            this.barSach,
            this.barVanPhongPham,
            this.barNhapHang,
            this.barBanHang,
            this.barTimKiemSach,
            this.barButtonItem11,
            this.barButtonItem12,
            this.barButtonItem13,
            this.barThongKeBanHang,
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem3,
            this.barThongTinCaNhan,
            this.barDoiMatKhau,
            this.barLapPhieuNhap,
            this.barLapPhieuXuat,
            this.barKho,
            this.barDangXuat});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 24;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.pageNhanVien,
            this.pageQuanTri});
            this.ribbonControl1.Size = new System.Drawing.Size(1308, 140);
            // 
            // barNhanVien
            // 
            this.barNhanVien.Caption = "Nhân viên";
            this.barNhanVien.Glyph = ((System.Drawing.Image)(resources.GetObject("barNhanVien.Glyph")));
            this.barNhanVien.Id = 1;
            this.barNhanVien.Name = "barNhanVien";
            this.barNhanVien.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barNhanVien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barNhanVien_ItemClick);
            // 
            // barTheLoai
            // 
            this.barTheLoai.Caption = "Thể loại";
            this.barTheLoai.Glyph = ((System.Drawing.Image)(resources.GetObject("barTheLoai.Glyph")));
            this.barTheLoai.Id = 2;
            this.barTheLoai.Name = "barTheLoai";
            this.barTheLoai.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barTheLoai.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barTheLoai_ItemClick);
            // 
            // barNhaXuatBan
            // 
            this.barNhaXuatBan.Caption = "Nhà xuất bản";
            this.barNhaXuatBan.Glyph = ((System.Drawing.Image)(resources.GetObject("barNhaXuatBan.Glyph")));
            this.barNhaXuatBan.Id = 3;
            this.barNhaXuatBan.Name = "barNhaXuatBan";
            this.barNhaXuatBan.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barNhaXuatBan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barNhaXuatBan_ItemClick);
            // 
            // barTacGia
            // 
            this.barTacGia.Caption = "Tác giả";
            this.barTacGia.Glyph = ((System.Drawing.Image)(resources.GetObject("barTacGia.Glyph")));
            this.barTacGia.Id = 4;
            this.barTacGia.Name = "barTacGia";
            this.barTacGia.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barTacGia.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barTacGia_ItemClick);
            // 
            // barSach
            // 
            this.barSach.Caption = "Sách";
            this.barSach.Glyph = ((System.Drawing.Image)(resources.GetObject("barSach.Glyph")));
            this.barSach.Id = 5;
            this.barSach.Name = "barSach";
            this.barSach.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barSach.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barSach_ItemClick);
            // 
            // barVanPhongPham
            // 
            this.barVanPhongPham.Caption = "Văn phòng phẩm";
            this.barVanPhongPham.Glyph = ((System.Drawing.Image)(resources.GetObject("barVanPhongPham.Glyph")));
            this.barVanPhongPham.Id = 6;
            this.barVanPhongPham.Name = "barVanPhongPham";
            this.barVanPhongPham.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barVanPhongPham.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barVanPhongPham_ItemClick);
            // 
            // barNhapHang
            // 
            this.barNhapHang.Caption = "Thống kê phiếu nhập";
            this.barNhapHang.Glyph = ((System.Drawing.Image)(resources.GetObject("barNhapHang.Glyph")));
            this.barNhapHang.Id = 7;
            this.barNhapHang.Name = "barNhapHang";
            this.barNhapHang.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barNhapHang.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barNhapHang_ItemClick);
            // 
            // barBanHang
            // 
            this.barBanHang.Caption = "Thống kê hóa đơn";
            this.barBanHang.Glyph = ((System.Drawing.Image)(resources.GetObject("barBanHang.Glyph")));
            this.barBanHang.Id = 8;
            this.barBanHang.Name = "barBanHang";
            this.barBanHang.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barBanHang.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBanHang_ItemClick);
            // 
            // barTimKiemSach
            // 
            this.barTimKiemSach.Caption = "Tìm kiếm sách";
            this.barTimKiemSach.Glyph = ((System.Drawing.Image)(resources.GetObject("barTimKiemSach.Glyph")));
            this.barTimKiemSach.Id = 10;
            this.barTimKiemSach.Name = "barTimKiemSach";
            this.barTimKiemSach.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barTimKiemSach.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barTimKiemSach_ItemClick);
            // 
            // barButtonItem11
            // 
            this.barButtonItem11.Caption = "Tìm kiếm nhà xuất bản";
            this.barButtonItem11.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem11.Glyph")));
            this.barButtonItem11.Id = 11;
            this.barButtonItem11.Name = "barButtonItem11";
            this.barButtonItem11.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            // 
            // barButtonItem12
            // 
            this.barButtonItem12.Caption = "Tìm kiếm tác giả";
            this.barButtonItem12.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem12.Glyph")));
            this.barButtonItem12.Id = 12;
            this.barButtonItem12.Name = "barButtonItem12";
            this.barButtonItem12.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            // 
            // barButtonItem13
            // 
            this.barButtonItem13.Caption = "Tìm kiếm thể";
            this.barButtonItem13.Id = 13;
            this.barButtonItem13.Name = "barButtonItem13";
            // 
            // barThongKeBanHang
            // 
            this.barThongKeBanHang.Caption = "Thống kê bán hàng";
            this.barThongKeBanHang.Glyph = ((System.Drawing.Image)(resources.GetObject("barThongKeBanHang.Glyph")));
            this.barThongKeBanHang.Id = 14;
            this.barThongKeBanHang.Name = "barThongKeBanHang";
            this.barThongKeBanHang.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barThongKeBanHang.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barThongKeBanHang_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Thông tin";
            this.barButtonItem1.Id = 15;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Thông tin cá nhân";
            this.barButtonItem2.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.Glyph")));
            this.barButtonItem2.Id = 16;
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Đổi mật khẩu";
            this.barButtonItem3.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.Glyph")));
            this.barButtonItem3.Id = 17;
            this.barButtonItem3.Name = "barButtonItem3";
            this.barButtonItem3.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // barThongTinCaNhan
            // 
            this.barThongTinCaNhan.Caption = "Thông tin cá nhân";
            this.barThongTinCaNhan.Glyph = ((System.Drawing.Image)(resources.GetObject("barThongTinCaNhan.Glyph")));
            this.barThongTinCaNhan.Id = 18;
            this.barThongTinCaNhan.Name = "barThongTinCaNhan";
            this.barThongTinCaNhan.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barThongTinCaNhan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barThongTinCaNhan_ItemClick);
            // 
            // barDoiMatKhau
            // 
            this.barDoiMatKhau.Caption = "Đổi mật khẩu";
            this.barDoiMatKhau.Glyph = ((System.Drawing.Image)(resources.GetObject("barDoiMatKhau.Glyph")));
            this.barDoiMatKhau.Id = 19;
            this.barDoiMatKhau.Name = "barDoiMatKhau";
            this.barDoiMatKhau.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barDoiMatKhau.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barDoiMatKhau_ItemClick);
            // 
            // barLapPhieuNhap
            // 
            this.barLapPhieuNhap.Caption = "Lập phiếu nhập";
            this.barLapPhieuNhap.Glyph = ((System.Drawing.Image)(resources.GetObject("barLapPhieuNhap.Glyph")));
            this.barLapPhieuNhap.Id = 20;
            this.barLapPhieuNhap.Name = "barLapPhieuNhap";
            this.barLapPhieuNhap.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.barLapPhieuNhap.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barLapPhieuNhap_ItemClick);
            // 
            // barLapPhieuXuat
            // 
            this.barLapPhieuXuat.Caption = "Lập phiếu xuất";
            this.barLapPhieuXuat.Glyph = ((System.Drawing.Image)(resources.GetObject("barLapPhieuXuat.Glyph")));
            this.barLapPhieuXuat.Id = 21;
            this.barLapPhieuXuat.Name = "barLapPhieuXuat";
            this.barLapPhieuXuat.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barLapPhieuXuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barLapPhieuXuat_ItemClick);
            // 
            // barKho
            // 
            this.barKho.Caption = "Kho";
            this.barKho.Glyph = ((System.Drawing.Image)(resources.GetObject("barKho.Glyph")));
            this.barKho.Id = 22;
            this.barKho.Name = "barKho";
            this.barKho.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barKho.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barKho_ItemClick);
            // 
            // barDangXuat
            // 
            this.barDangXuat.Caption = "Đăng xuất";
            this.barDangXuat.Glyph = ((System.Drawing.Image)(resources.GetObject("barDangXuat.Glyph")));
            this.barDangXuat.Id = 23;
            this.barDangXuat.Name = "barDangXuat";
            this.barDangXuat.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barDangXuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barDangXuat_ItemClick);
            // 
            // pageNhanVien
            // 
            this.pageNhanVien.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup4,
            this.ribbonPageGroup6});
            this.pageNhanVien.Name = "pageNhanVien";
            this.pageNhanVien.Text = "Nhân viên";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.barTimKiemSach);
            this.ribbonPageGroup4.ItemLinks.Add(this.barLapPhieuNhap);
            this.ribbonPageGroup4.ItemLinks.Add(this.barLapPhieuXuat);
            this.ribbonPageGroup4.ItemLinks.Add(this.barKho);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "Hỗ trợ";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.ItemLinks.Add(this.barThongTinCaNhan);
            this.ribbonPageGroup6.ItemLinks.Add(this.barDoiMatKhau);
            this.ribbonPageGroup6.ItemLinks.Add(this.barDangXuat);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            this.ribbonPageGroup6.Text = "Tài khoản";
            // 
            // pageQuanTri
            // 
            this.pageQuanTri.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2,
            this.ribbonPageGroup3,
            this.ribbonPageGroup1});
            this.pageQuanTri.Name = "pageQuanTri";
            this.pageQuanTri.Text = "Quản trị";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.barNhanVien);
            this.ribbonPageGroup2.ItemLinks.Add(this.barTheLoai);
            this.ribbonPageGroup2.ItemLinks.Add(this.barNhaXuatBan);
            this.ribbonPageGroup2.ItemLinks.Add(this.barTacGia);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Danh mục";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.barSach);
            this.ribbonPageGroup3.ItemLinks.Add(this.barVanPhongPham);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Sản phẩm";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barNhapHang);
            this.ribbonPageGroup1.ItemLinks.Add(this.barBanHang);
            this.ribbonPageGroup1.ItemLinks.Add(this.barThongKeBanHang);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Thống kê";
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Visual Studio 2013 Light";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.barButtonItem2);
            this.ribbonPageGroup5.ItemLinks.Add(this.barButtonItem3);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "QUẢN LÝ NHÀ SÁCH";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 740);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.DisplayHeader = false;
            this.Name = "FrmMain";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Text = "FrmMain";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage pageNhanVien;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPage pageQuanTri;
        private DevExpress.XtraBars.BarButtonItem barNhanVien;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem barTheLoai;
        private DevExpress.XtraBars.BarButtonItem barNhaXuatBan;
        private DevExpress.XtraBars.BarButtonItem barTacGia;
        private DevExpress.XtraBars.BarButtonItem barSach;
        private DevExpress.XtraBars.BarButtonItem barVanPhongPham;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem barNhapHang;
        private DevExpress.XtraBars.BarButtonItem barBanHang;
        private DevExpress.XtraBars.BarButtonItem barTimKiemSach;
        private DevExpress.XtraBars.BarButtonItem barButtonItem11;
        private DevExpress.XtraBars.BarButtonItem barButtonItem12;
        private DevExpress.XtraBars.BarButtonItem barButtonItem13;
        private DevExpress.XtraBars.BarButtonItem barThongKeBanHang;
        private System.Windows.Forms.Panel panelMain;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barThongTinCaNhan;
        private DevExpress.XtraBars.BarButtonItem barDoiMatKhau;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraBars.BarButtonItem barLapPhieuNhap;
        private DevExpress.XtraBars.BarButtonItem barLapPhieuXuat;
        private DevExpress.XtraBars.BarButtonItem barKho;
        private DevExpress.XtraBars.BarButtonItem barDangXuat;
    }
}