using BookShop.Model;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookShop.GUI
{
    public partial class FrmMain : MetroForm
    {
        private VergetableContext db = Helper.db;
        private NHANVIEN nv = new NHANVIEN();

        #region Hàm khởi tạo
        public FrmMain(NHANVIEN z)
        {
            InitializeComponent();
            Helper.Reload();
            nv = z;
            Helper.IDNhanVien = nv.ID;
        }
        #endregion

        #region Sự kiện mở các form chức năng
        private void barNhanVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panelMain.Controls.Clear();
            ucDanhSachNhanVien uc = new ucDanhSachNhanVien();
            uc.Dock = DockStyle.Fill;
            panelMain.Controls.Add(uc);
        }

        private void barSach_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panelMain.Controls.Clear();
            ucDanhSachMatHang uc = new ucDanhSachMatHang();
            uc.Dock = DockStyle.Fill;
            panelMain.Controls.Add(uc);
        }

        

        private void barTheLoai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //panelMain.Controls.Clear();
            //ucDanhSachNhaCungCap uc = new ucDanhSachNhaCungCap();
            //uc.Dock = DockStyle.Fill;
            //panelMain.Controls.Add(uc);
        }
        

        private void barNhaXuatBan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panelMain.Controls.Clear();
            ucDanhSachNhaSanXuat uc = new ucDanhSachNhaSanXuat();
            uc.Dock = DockStyle.Fill;
            panelMain.Controls.Add(uc);
        }

        private void barNhapHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panelMain.Controls.Clear();
            ucNhapHang uc = new ucNhapHang();
            uc.Dock = DockStyle.Fill;
            panelMain.Controls.Add(uc);
        }

        private void barBanHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panelMain.Controls.Clear();
            ucBanHang uc = new ucBanHang();
            uc.Dock = DockStyle.Fill;
            panelMain.Controls.Add(uc);
        }

        private void barTimKiemSach_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panelMain.Controls.Clear();
            ucTimKiemMatHang uc = new ucTimKiemMatHang();
            uc.Dock = DockStyle.Fill;
            panelMain.Controls.Add(uc);
        }

        private void barVanPhongPham_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //panelMain.Controls.Clear();
            //ucDanhSachVanPhongPham uc = new ucDanhSachVanPhongPham();
            //uc.Dock = DockStyle.Fill;
            //panelMain.Controls.Add(uc);
        }

        private void barThongKeBanHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panelMain.Controls.Clear();
            ucThongKeBanHang uc = new ucThongKeBanHang();
            uc.Dock = DockStyle.Fill;
            panelMain.Controls.Add(uc);
        }
        private void barTacGia_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        private void barLapPhieuNhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panelMain.Controls.Clear();
            ucLapPhieuNhap uc = new ucLapPhieuNhap();
            uc.Dock = DockStyle.Fill;
            panelMain.Controls.Add(uc);
        }

        private void barLapPhieuXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panelMain.Controls.Clear();
            ucLapPhieuXuat uc = new ucLapPhieuXuat();
            uc.Dock = DockStyle.Fill;
            panelMain.Controls.Add(uc);
        }


        private void barThongTinCaNhan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmThongTinCaNhan form = new FrmThongTinCaNhan(nv);
            form.ShowDialog();
        }

        private void barDoiMatKhau_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmDoiMatKhau form = new FrmDoiMatKhau(nv);
            form.ShowDialog();
        }

        private void barKho_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panelMain.Controls.Clear();
            ucKho uc = new ucKho();
            uc.Dock = DockStyle.Fill;
            panelMain.Controls.Add(uc);
        }

        #endregion

        private void FrmMain_Load(object sender, EventArgs e)
        {
            if (nv.CHUCVU == 0)
            {
                pageQuanTri.Visible = false;
                return;
            }
        }

        private void barDangXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có chắc chắn đăng xuất?",
                                              "Thông báo",
                                              MessageBoxButtons.OKCancel,
                                              MessageBoxIcon.Error);
            if (rs == DialogResult.Cancel) return;
            this.Close();
        }
    }
}
