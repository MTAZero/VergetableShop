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
    public partial class FrmThemChiTietHoaDon : MetroForm
    {
        private VergetableContext db = Helper.db;
        private HOADON pn = new HOADON();

        #region Hàm khởi tạo
        public FrmThemChiTietHoaDon(HOADON z)
        {
            InitializeComponent();
            Helper.Reload();
            pn = z;
            Helper.IDSanPham = db.MATHANGs.FirstOrDefault().ID;

        }
        #endregion

        #region Hàm chức năng
        private void Loadz()
        {
            try
            {
                MATHANG mh = Helper.db.MATHANGs.Where(p => p.ID == Helper.IDSanPham).First();
                if (mh != null)
                {
                    txtTenMatHang.Text = Helper.TenSanPham(mh);
                    txtDonGia.Text = Helper.GiaSanPham(mh).ToString("N0");
                    txtKho.Text = "( Trong kho : " + mh.SOLUONG + " ) ";
                }
            }
            catch { }
        }

        private void TinhThanhTien()
        {
            MATHANG mh = Helper.db.MATHANGs.Where(p => p.ID == Helper.IDSanPham).First();
            Int64 gt = (Int64)txtSoLuong.Value * Helper.GiaSanPham(mh);
            txtThanhTien.Text = gt.ToString("N0");
        }

        private bool Check()
        {
            if (txtSoLuong.Value == 0)
            {
                MessageBox.Show("Số lượng sản phẩm phải là số nguyên dương",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return false;
            }


            /// check trong kho
            int sl = (int) txtSoLuong.Value;

            MATHANG mh = Helper.db.MATHANGs.Where(p => p.ID == Helper.IDSanPham).First();
            if (sl > mh.SOLUONG)
            {
                MessageBox.Show("Số lượng hàng trong kho không đủ",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        #endregion

        #region Sự kiện
        private void btnChon_Click(object sender, EventArgs e)
        {
            FrmLuaChonSanPham form = new FrmLuaChonSanPham();
            this.Hide();
            form.Focus();
            form.ShowDialog();
            this.Show();
            this.Focus();

            Loadz();
        }

        private void btnHoanThanh_Click(object sender, EventArgs e)
        {
            if (Check())
            {
                CHITIETHOADON z = new CHITIETHOADON();
                z.MATHANGID = Helper.IDSanPham;
                z.SOLUONG = (int)txtSoLuong.Value;

                MATHANG mhz = Helper.db.MATHANGs.Where(p => p.ID == Helper.IDSanPham).First();
                z.DONGIA = Helper.GiaSanPham(mhz);
                z.THANHTIEN = z.SOLUONG * z.DONGIA;
                z.HOADONID = pn.ID;

                CHITIETHOADON cthd = db.CHITIETHOADONs.Where(p => p.MATHANGID == z.MATHANGID && p.HOADONID == pn.ID).FirstOrDefault();

                if (cthd == null)
                {
                    db.CHITIETHOADONs.Add(z);
                }
                else
                {
                    cthd.SOLUONG += z.SOLUONG;
                    cthd.THANHTIEN += z.THANHTIEN;
                }

                try
                {

                    db.SaveChanges();
                    MATHANG mh = db.MATHANGs.Where(p => p.ID == z.MATHANGID).FirstOrDefault();
                    mh.SOLUONG -= z.SOLUONG;
                    pn.TONGTIEN += z.THANHTIEN;
                    db.SaveChanges();

                    MessageBox.Show("Thêm chi tiết hóa đơn thành công",
                                    "Thông báo",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);



                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Thêm chi tiết hóa đơn thất bại\n" + ex.Message,
                                    "Thông báo",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                    this.Close();
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Sự kiện ngầm
        private void txtSoLuong_ValueChanged(object sender, EventArgs e)
        {
            TinhThanhTien();
        }
        #endregion

        #region LoadForm
        private void FrmThemChiTietNhap_Load(object sender, EventArgs e)
        {
            if (Helper.IDSanPham == 0)
            {
                MessageBox.Show("Chưa có loại sản phẩm nào\nVui lòng thêm danh mục các sản phẩm",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                this.Close();
            }
            Loadz();
        }
        #endregion
    }
}
