using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookShop.Model;
using BookShop.Report;

namespace BookShop.GUI
{
    public partial class ucBanHang : UserControl
    {
        private VergetableContext db = Helper.db;

        #region Hàm khởi tạo
        public ucBanHang()
        {
            InitializeComponent();
            Helper.Reload();

            dgvChiTietHoaDonMain.DataSource = null;
            dgvHoaDonMain.DataSource = null;
        }

        #endregion

        #region LoadForm
        private void LoadInitControl()
        {
            dateBatDau.DateTime = DateTime.Now.AddDays(-30);
            dateKetThuc.DateTime = DateTime.Now;
        }

        private void LoadDgvDanhSachHoaDon()
        {
            txtTongGiaTri.Text = "Tổng giá trị : 0";
            try
            {
                dgvHoaDonMain.DataSource = db.HOADONs.ToList()
                                           .Where(p => p.NGAY >= dateBatDau.DateTime && p.NGAY <= dateKetThuc.DateTime)
                                           .OrderBy(p => p.NGAY)
                                           .Select(p => new
                                           {
                                               ID = p.ID,
                                               TongChiPhi = ((int)p.TONGTIEN).ToString("N0"),
                                               MaHoaDon = p.MAHOADON,
                                               Ngay = ((DateTime)p.NGAY).ToString("dd/MM/yyyy"),
                                               NhanVien = db.NHANVIENs.Where(z => z.ID == p.NHANVIENID).FirstOrDefault().TEN
                                           })
                                           .Where(p => p.MaHoaDon.ToUpper().Contains(txtTimKiem.Text.ToUpper()))
                                           .ToList();

                txtTongGiaTri.Text = "Tổng giá trị : " +
                                     ((int)db.HOADONs.ToList()
                                           .Where(p => p.NGAY >= dateBatDau.DateTime && p.NGAY <= dateKetThuc.DateTime)
                                           .OrderBy(p => p.NGAY)
                                           .Select(p => new
                                           {
                                               ChiPhi = p.TONGTIEN,
                                               ID = p.ID,
                                               TongChiPhi = ((int)p.TONGTIEN).ToString("N0"),
                                               MaHoaDon = p.MAHOADON,
                                               Ngay = ((DateTime)p.NGAY).ToString("dd/MM/yyyy"),
                                               NhanVien = db.NHANVIENs.Where(z => z.ID == p.NHANVIENID).FirstOrDefault().TEN
                                           })
                                           .ToList()
                                           .Sum(p => p.ChiPhi))
                                           .ToString("N0");
                LoadChiTietHoaDon();
            }
            catch { }
        }

        private void LoadChiTietHoaDon()
        {
            try
            {
                int ID = (int)dgvHoaDon.GetFocusedRowCellValue("ID");
                HOADON hd = db.HOADONs.Where(p => p.ID == ID).FirstOrDefault();

                int i = 0;
                dgvChiTietHoaDonMain.DataSource = db.CHITIETHOADONs.Where(p => p.HOADONID == hd.ID).ToList()
                                                .Select(p => new
                                                {
                                                    ID = p.ID,
                                                    STT = ++i,
                                                    MatHang = Helper.TenSanPham(db.MATHANGs.Where(z => z.ID == p.MATHANGID).FirstOrDefault()),
                                                    DonGia = ((int)p.DONGIA).ToString("N0"),
                                                    SoLuong = p.SOLUONG,
                                                    ThanhTien = ((int)p.THANHTIEN).ToString("N0")
                                                })
                                                .ToList();
            }
            catch { }
        }

        private void ucBanHang_Load(object sender, EventArgs e)
        {
            LoadInitControl();
            LoadDgvDanhSachHoaDon();
        }
        #endregion

        #region Sự kiện ngầm
        private void dgvHoaDon_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            UpdateDetail();
        }

        private void dateKetThuc_EditValueChanged(object sender, EventArgs e)
        {
            LoadDgvDanhSachHoaDon();
        }
        #endregion

        #region Hàm chức năng

        private void UpdateDetail()
        {
            try
            {
                int ID = (int)dgvHoaDon.GetFocusedRowCellValue("ID");
                HOADON hd = db.HOADONs.Where(p => p.ID == ID).FirstOrDefault();

                txtMaHoaDon.Text = hd.MAHOADON;
                dateNgayBan.Text = ((DateTime)hd.NGAY).ToString("dd/MM/yyyy");
                txtNhanVien.Text = db.NHANVIENs.Where(p => p.ID == hd.NHANVIENID).FirstOrDefault().TEN;
                txtTongChiPhi.Text = ((int)hd.TONGTIEN).ToString("N0");

                LoadChiTietHoaDon();
            }
            catch { }
        }

        #endregion

        #region Sự kiện
        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            try
            {
                int ID = (int)dgvHoaDon.GetFocusedRowCellValue("ID");
                HOADON hd = db.HOADONs.Where(p => p.ID == ID).FirstOrDefault();
                FrmRpHoaDon form = new FrmRpHoaDon(hd);
                form.ShowDialog();
            }
            catch
            {
                MessageBox.Show("Chưa có hóa đơn nào được chọn",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }
        }

        #endregion

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            LoadDgvDanhSachHoaDon();
        }
    }
}
