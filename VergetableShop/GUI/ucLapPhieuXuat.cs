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
    public partial class ucLapPhieuXuat : UserControl
    {
        private HOADON pn = new HOADON();
        private VergetableContext db = Helper.db;

        #region Hàm khởi tạo
        public ucLapPhieuXuat()
        {
            InitializeComponent();
            Helper.Reload();
            pn = db.HOADONs.Where(p => p.ID == Helper.IDHoaDon).FirstOrDefault();
            if (pn == null) pn = new HOADON();
        }
        #endregion

        #region Hàm chức năng

        private HOADON getPhieuNhapByForm()
        {
            HOADON ans = new HOADON();
            ans.MAHOADON = txtMaHoaDon.Text;
            ans.NGAY = dateNgayBan.DateTime;
            ans.NHANVIENID = (int) cbxNhanVien.EditValue;
            ans.TONGTIEN = Int32.Parse(txtChiPhi.Text);
            ans.TENKHACHHANG = txtTenKhachHang.Text;

            return ans;
        }

        private CHITIETHOADON getChiTietNhapByForm()
        {
            int id = (int) dgvChiTietHoaDon.GetFocusedRowCellValue("ID");
            CHITIETHOADON z = db.CHITIETHOADONs.Where(p => p.ID == id).FirstOrDefault();
            return z;
        }

        private bool Check()
        {
            if (txtMaHoaDon.Text == "")
            {
                MessageBox.Show("Mã hóa đơn không được để trống",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return false;
            }

            string z = txtMaHoaDon.Text;
            int cnt = db.HOADONs.Where(p => p.MAHOADON == z).ToList().Count;
            if (cnt > 0)
            {
                MessageBox.Show("Mã hóa đơn đã được sử dụng",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return false;
            }

            if (txtTenKhachHang.Text == "")
            {
                MessageBox.Show("Tên khách hàng không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        #endregion

        #region LoadForm

        private void LoadDgvChiTietNhap()
        {
            txtChiPhi.Text = ((int)pn.TONGTIEN).ToString("N0");

            int i = 0;
            dgvChiTietHoaDonMain.DataSource = db.CHITIETHOADONs.Where(p => p.HOADONID == pn.ID).ToList()
                                            .Select(p => new
                                            {
                                                ID = p.ID,
                                                STT = ++i,
                                                MatHang = Helper.TenSanPham(db.MATHANGs.Where(z=>z.ID == p.MATHANGID).FirstOrDefault()),
                                                DonGia = ((int) p.DONGIA).ToString("N0"),
                                                SoLuong = p.SOLUONG,
                                                ThanhTien = ((int) p.THANHTIEN).ToString("N0")
                                            })
                                            .ToList();
        }

        private void LoadInitControl()
        {
            cbxNhanVien.Properties.DataSource = db.NHANVIENs.Select(p => new { ID = p.ID, Ten = p.TEN }).ToList();
            cbxNhanVien.Properties.DisplayMember = "Ten";
            cbxNhanVien.Properties.ValueMember = "ID";

            cbxNhanVien.Enabled = false;
            dateNgayBan.Enabled = false;

            dateNgayBan.DateTime = DateTime.Now;

            cbxNhanVien.EditValue = (int) Helper.IDNhanVien;
        }

        private void LoadNewHoaDon()
        {
            btnLapHoaDon.Enabled = true;

            btnThem.Enabled = false;
            btnTra.Enabled = false;
            btnInHoaDon.Enabled = false;
            btnHoanThanhPhieuNhap.Enabled = false;

            dgvChiTietHoaDonMain.Enabled = false;

            txtMaHoaDon.Enabled = true;
            txtTenKhachHang.Enabled = true;
        }

        private void LoadOldHoaDon()
        {
            txtMaHoaDon.Enabled = false;

            txtMaHoaDon.Text = pn.MAHOADON; txtMaHoaDon.Enabled = false;
            dateNgayBan.DateTime = (DateTime)pn.NGAY; dateNgayBan.Enabled = false;
            cbxNhanVien.EditValue = pn.NHANVIENID; cbxNhanVien.Enabled = false;
            txtChiPhi.Text = ((int)pn.TONGTIEN).ToString("N0");
            txtTenKhachHang.Enabled = false;

            btnLapHoaDon.Enabled = true;

            btnThem.Enabled = true;
            btnTra.Enabled = true;
            btnInHoaDon.Enabled = true;
            btnHoanThanhPhieuNhap.Enabled = true;

            dgvChiTietHoaDonMain.Enabled = true;

            LoadDgvChiTietNhap();

        }
        private void ucLapPhieuNhap_Load(object sender, EventArgs e)
        {
            LoadInitControl();
            if (pn.ID == 0)
            {
                LoadNewHoaDon();
            }
            else
            {
                LoadOldHoaDon();
            }
        }
        #endregion

        #region Sự kiện
        private void btnThem_Click(object sender, EventArgs e)
        {
            FrmThemChiTietHoaDon form = new FrmThemChiTietHoaDon(pn);
            form.ShowDialog();
            LoadDgvChiTietNhap();
        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            FrmRpHoaDon form = new FrmRpHoaDon(pn);
            form.ShowDialog();
        }

        private void btnHoanThanhPhieuNhap_Click(object sender, EventArgs e)
        {
            Helper.IDPhieuNhap = 0;
            dateNgayBan.DateTime = DateTime.Now;
            Helper.IDPhieuNhap = 0;

            MessageBox.Show("Hoàn thành thêm phiếu nhập thành công",
                            "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

            LoadNewHoaDon();
            dgvChiTietHoaDonMain.DataSource = null;
            btnLapHoaDon.Enabled = true;
            txtMaHoaDon.Text = "";
            dateNgayBan.DateTime = DateTime.Now;
            txtChiPhi.Text = "0";
            txtTenKhachHang.Text = "";
        }

        private void btnTra_Click(object sender, EventArgs e)
        {
            CHITIETHOADON a = getChiTietNhapByForm();
            if (a.ID == 0)
            {
                MessageBox.Show("Chưa có chi tiết hóa đơn nào được chọn",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            DialogResult rs = MessageBox.Show("Bạn có chắc chắn xóa chi tiết hóa đơn này?",
                                              "Thông báo",
                                              MessageBoxButtons.OKCancel,
                                              MessageBoxIcon.Warning);
            if (rs == DialogResult.Cancel) return;

            MATHANG mh = db.MATHANGs.Where(p => a.MATHANGID == p.ID).FirstOrDefault();
            mh.SOLUONG += a.SOLUONG;
            if (mh.SOLUONG < 0) mh.SOLUONG = 0;

            pn.TONGTIEN -= a.SOLUONG * a.DONGIA;
            db.CHITIETHOADONs.Remove(a);

            try
            {
                db.SaveChanges();
                MessageBox.Show("Xóa chi tiết hóa đơn thành công",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa chi tiết hóa đơn thất bại\n" + ex.Message,
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            finally
            {
                LoadDgvChiTietNhap();
            }

        }


        private void btnLapPhieuNhap_Click(object sender, EventArgs e)
        {
            if (Check())
            {
                HOADON z = getPhieuNhapByForm();
                db.HOADONs.Add(z);
                try
                {
                    db.SaveChanges();
                    MessageBox.Show("Lập hóa đơn thành công",
                                    "Thông báo",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);

                    Helper.IDHoaDon = z.ID;
                    pn = z;

                    btnLapHoaDon.Enabled = false;
                    LoadOldHoaDon();

                }
                catch
                {

                }
                return;
            }
        }
        #endregion


    }
}
