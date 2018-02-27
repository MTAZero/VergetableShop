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
    public partial class ucLapPhieuNhap : UserControl
    {
        private PHIEUNHAP pn = new PHIEUNHAP();
        private VergetableContext db = Helper.db;

        #region Hàm khởi tạo
        public ucLapPhieuNhap()
        {
            InitializeComponent();
            Helper.Reload();
            pn = db.PHIEUNHAPs.Where(p => p.ID == Helper.IDPhieuNhap).FirstOrDefault();
            if (pn == null) pn = new PHIEUNHAP();
        }
        #endregion

        #region Hàm chức năng

        private PHIEUNHAP getPhieuNhapByForm()
        {
            PHIEUNHAP ans = new PHIEUNHAP();
            ans.MAPHIEUNHAP = txtMaPhieuNhap.Text;
            ans.NGAY = dateNgayBan.DateTime;
            ans.NHANVIENID = (int) cbxNhanVien.EditValue;
            ans.TONGTIEN = Int32.Parse(txtChiPhi.Text);
            

            return ans;
        }

        private CHITIETNHAP getChiTietNhapByForm()
        {
            int id = (int) dgvChiTietNhap.GetFocusedRowCellValue("ID");
            CHITIETNHAP z = db.CHITIETNHAPs.Where(p => p.ID == id).FirstOrDefault();
            return z;
        }

        #endregion

        #region LoadForm

        private void LoadDgvChiTietNhap()
        {
            txtChiPhi.Text = ((int)pn.TONGTIEN).ToString("N0");

            int i = 0;
            dgvChiTietNhapMain.DataSource = db.CHITIETNHAPs.Where(p => p.PHIEUNHAPID == pn.ID).ToList()
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

        private void LoadNewPhieuNhap()
        {
            btnLapPhieuNhap.Enabled = true;

            btnThem.Enabled = false;
            btnTra.Enabled = false;
            btnInHoaDon.Enabled = false;
            btnHoanThanhPhieuNhap.Enabled = false;

            dgvChiTietNhapMain.Enabled = false;

            txtMaPhieuNhap.Enabled = true;
        }

        private void LoadOldPhieuNhap()
        {
            txtMaPhieuNhap.Enabled = false;

            txtMaPhieuNhap.Text = pn.MAPHIEUNHAP; txtMaPhieuNhap.Enabled = false;
            dateNgayBan.DateTime = (DateTime)pn.NGAY; dateNgayBan.Enabled = false;
            cbxNhanVien.EditValue = pn.NHANVIENID; cbxNhanVien.Enabled = false;
            txtChiPhi.Text = ((int)pn.TONGTIEN).ToString("N0");

            btnLapPhieuNhap.Enabled = true;

            btnThem.Enabled = true;
            btnTra.Enabled = true;
            btnInHoaDon.Enabled = true;
            btnHoanThanhPhieuNhap.Enabled = true;

            dgvChiTietNhapMain.Enabled = true;

            LoadDgvChiTietNhap();

        }
        private void ucLapPhieuNhap_Load(object sender, EventArgs e)
        {
            LoadInitControl();
            if (pn.ID == 0)
            {
                LoadNewPhieuNhap();
            }
            else
            {
                LoadOldPhieuNhap();
            }
        }

        private bool Check()
        {
            if (txtMaPhieuNhap.Text == "")
            {
                MessageBox.Show("Mã phiếu nhập không được để trống",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return false;
            }

            string z = txtMaPhieuNhap.Text;
            int cnt = db.PHIEUNHAPs.Where(p => p.MAPHIEUNHAP == z).ToList().Count;
            if (cnt > 0)
            {
                MessageBox.Show("Mã phiếu nhập đã được sử dụng",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        #endregion

        #region Sự kiện
        private void btnThem_Click(object sender, EventArgs e)
        {
            FrmThemChiTietNhap form = new FrmThemChiTietNhap(pn);
            form.ShowDialog();
            LoadDgvChiTietNhap();
        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            FrmRpPhieuNhap form = new FrmRpPhieuNhap(pn);
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

            LoadNewPhieuNhap();
            dgvChiTietNhapMain.DataSource = null;
            btnLapPhieuNhap.Enabled = true;
            txtMaPhieuNhap.Text = "";
            txtChiPhi.Text = "0";
        }

        private void btnTra_Click(object sender, EventArgs e)
        {
            CHITIETNHAP a = getChiTietNhapByForm();
            if (a.ID == 0)
            {
                MessageBox.Show("Chưa có chi tiết nhập nào được chọn",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            DialogResult rs = MessageBox.Show("Bạn có chắc chắn xóa chi tiết nhập này?",
                                              "Thông báo",
                                              MessageBoxButtons.OK,
                                              MessageBoxIcon.Warning);
            if (rs == DialogResult.Cancel) return;

            MATHANG mh = db.MATHANGs.Where(p => a.MATHANGID == p.ID).FirstOrDefault();
            mh.SOLUONG -= a.SOLUONG;
            if (mh.SOLUONG < 0) mh.SOLUONG = 0;

            pn.TONGTIEN -= a.SOLUONG * a.DONGIA;
            db.CHITIETNHAPs.Remove(a);

            try
            {
                db.SaveChanges();
                MessageBox.Show("Xóa chi tiết nhập thành công",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa chi tiết nhập thất bại\n" + ex.Message,
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
                PHIEUNHAP z = getPhieuNhapByForm();
                db.PHIEUNHAPs.Add(z);
                try
                {
                    db.SaveChanges();
                    MessageBox.Show("Thêm chi tiết phiếu nhập thành công",
                                    "Thông báo",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);

                    Helper.IDPhieuNhap = z.ID;
                    pn = z;
                    LoadOldPhieuNhap();
                    btnLapPhieuNhap.Enabled = false;
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
