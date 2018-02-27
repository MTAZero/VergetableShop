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
    public partial class FrmThemChiTietNhap : MetroForm
    {
        private VergetableContext db = Helper.db;
        private PHIEUNHAP pn = new PHIEUNHAP();

        #region Hàm khởi tạo
        public FrmThemChiTietNhap(PHIEUNHAP z)
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
                }
            }
            catch { }
        }

        private void TinhThanhTien()
        {
            Int64 gt = (Int64)txtSoLuong.Value * (Int64)txtDonGia.Value;
            txtThanhTien.Text = gt.ToString("N0");
        }

        private bool Check()
        {
            if (txtSoLuong.Value == 0)
            {
                MessageBox.Show("Số lượng phải là số nguyên dương",
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
                CHITIETNHAP z = new CHITIETNHAP();
                z.MATHANGID = Helper.IDSanPham;
                z.SOLUONG = (int)txtSoLuong.Value;
                z.DONGIA = (int)txtDonGia.Value;
                z.THANHTIEN = z.SOLUONG * z.DONGIA;
                z.PHIEUNHAPID = pn.ID;
                db.CHITIETNHAPs.Add(z);

                try
                {

                    db.SaveChanges();
                    MATHANG mh = db.MATHANGs.Where(p => p.ID == z.MATHANGID).FirstOrDefault();
                    mh.SOLUONG += z.SOLUONG;
                    pn.TONGTIEN += z.THANHTIEN;
                    db.SaveChanges();

                    MessageBox.Show("Thêm chi tiết nhập thành công",
                                    "Thông báo",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);



                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Thêm chi tiết nhập thất bại\n" + ex.Message,
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

        private void txtDonGia_ValueChanged(object sender, EventArgs e)
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
