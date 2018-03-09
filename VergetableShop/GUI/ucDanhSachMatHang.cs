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

namespace BookShop.GUI
{
    public partial class ucDanhSachMatHang : UserControl
    {
        private VergetableContext db = Helper.db;
        private int index = 0, index1 = 0;

        #region Construtor
        public ucDanhSachMatHang()
        {
            InitializeComponent();
            Helper.Reload();
        }

        #endregion

        #region Hàm chức năng

        private MATHANG getMATHANGByID()
        {
            try
            {
                int id = (int)dgvMATHANG.GetFocusedRowCellValue("ID");
                MATHANG ans = db.MATHANGs.Where(p => p.ID == id).FirstOrDefault();
                if (ans == null) return new MATHANG();
                return ans;
            }
            catch
            {
                return new MATHANG();
            }
        }

        private MATHANG getMATHANGByForm()
        {
            MATHANG ans = new MATHANG();

            try
            {
                ans.TEN = txtTenMATHANG.Text;
                ans.GIABAN = Int32.Parse(txtGiaBan.Text);
                ans.NAMXUATBAN = Int32.Parse(txtNamXuatBan.Text);
                ans.NHASANXUATID = (int)cbxNhaSanXuat.EditValue;
                ans.GIASI = Int32.Parse(txtGiaSi.Text);
                ans.GIASHIP = Int32.Parse(txtGiaShip.Text);

                ans.ANH = Helper.imageToByteArray(imgAnh.Image);
            }
            catch { }

            return ans;
        }

        private void ClearControl()
        {
            //cbxNXB.ItemIndex = 0;
            cbxNhaSanXuat.ItemIndex = 0;

            txtTenMATHANG.Text = "";
            txtGiaBan.Text = "";
            txtGiaSi.Text = "";
            txtGiaShip.Text = "";
            txtNamXuatBan.Text = "";
            txtTitleTacGia.Text = "";
            txtTitleTenMATHANG.Text = "";

            imgAnh.Image = null;
        }

        private void UpdateDetail()
        {
            try
            {
                MATHANG ans = getMATHANGByID();

                if (ans.ID == 0) return;

                cbxNhaSanXuat.EditValue = ans.NHASANXUATID;

                txtTenMATHANG.Text = ans.TEN;
                txtGiaBan.Text = ans.GIABAN.ToString();
                txtGiaSi.Text = ans.GIASI.ToString();
                txtGiaShip.Text = ans.GIASHIP.ToString();
                txtNamXuatBan.Text = ans.NAMXUATBAN.ToString();
                txtTitleTacGia.Text = cbxNhaSanXuat.Text;
                txtTitleTenMATHANG.Text = ans.TEN;


                imgAnh.Image = null;
                imgAnh.Image = Helper.byteArrayToImage(ans.ANH);
            }
            catch
            {

            }
        }

        private void LockControl()
        {
            txtTenMATHANG.Enabled = false;
            cbxNhaSanXuat.Enabled = false;
            txtGiaBan.Enabled = false;
            txtNamXuatBan.Enabled = false;
            imgAnh.Enabled = false;
            txtGiaSi.Enabled = false;
            txtGiaShip.Enabled = false;

            dgvMATHANGMain.Enabled = true;
            txtTimKiem.Enabled = true;

            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void UnlockControl()
        {
            txtTenMATHANG.Enabled = true;
            cbxNhaSanXuat.Enabled = true;
            txtGiaBan.Enabled = true;
            txtNamXuatBan.Enabled = true;
            imgAnh.Enabled = true;
            txtGiaSi.Enabled = true;
            txtGiaShip.Enabled = true;

            dgvMATHANGMain.Enabled = false;
            txtTimKiem.Enabled = false;
        }

        private bool Check()
        {
            if (imgAnh.Image == null)
            {
                MessageBox.Show("Ảnh của mặt hàng không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtTenMATHANG.Text == "")
            {
                MessageBox.Show("Tên của mặt hàng không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            try
            {
                int giaban = Int32.Parse(txtGiaBan.Text);
                giaban = giaban / giaban;
            }
            catch
            {
                MessageBox.Show("Giá bán của mặt hàng phải là số nguyên dương",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return false;
            }

            try
            {
                int nam = Int32.Parse(txtNamXuatBan.Text);

                if (nam > DateTime.Now.Year)
                {
                    MessageBox.Show("Năm xuất bản chưa chính xác\nNăm xuất bản phải nhỏ hơn hoặc bằng thời điểm hiện tại",
                                    "Thông báo",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                    return false;
                }
            }
            catch
            {
                MessageBox.Show("Năm xuất bản của sách phải là số nguyên",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return false;
            }

            try
            {
                int giaban = Int32.Parse(txtGiaSi.Text);
                giaban = giaban / giaban;
            }
            catch
            {
                MessageBox.Show("Giá sỉ của mặt hàng phải là số nguyên dương",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return false;
            }

            try
            {
                int giaban = Int32.Parse(txtGiaShip.Text);
                giaban = giaban / giaban;
            }
            catch
            {
                MessageBox.Show("Giá ship của mặt hàng phải là số nguyên dương",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private bool CheckLuaChon()
        {
            MATHANG tg = getMATHANGByID();
            if (tg.ID == 0)
            {
                MessageBox.Show("Chưa có mặt hàng nào được chọn",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void CapNhat(ref MATHANG cu, MATHANG moi)
        {
            cu.TEN = moi.TEN;
            cu.NHASANXUATID = moi.NHASANXUATID;
            cu.GIABAN = moi.GIABAN;
            cu.NAMXUATBAN = moi.NAMXUATBAN;
            //cu.THONGTINMATHANG = moi.THONGTINMATHANG;
            cu.GIASI = moi.GIASI;
            cu.GIASHIP = moi.GIASHIP;
            cu.ANH = moi.ANH;
        }

        #endregion

        #region LoadForm

        private void LoadInitControl()
        {
            cbxNhaSanXuat.Properties.DataSource = db.NHASANXUATs.Select(p => new { ID = p.ID, TEN = p.TEN }).ToList();
            cbxNhaSanXuat.Properties.DisplayMember = "TEN";
            cbxNhaSanXuat.Properties.ValueMember = "ID";

            ClearControl();
        }

        private void LoadDgvMATHANG()
        {
            int i = 0;
            string keyWord = txtTimKiem.Text.Trim().ToUpper();
            var listMATHANG = db.MATHANGs.ToList()
                           .Select(p => new
                           {
                               ID = p.ID,
                               Ten = p.TEN,
                               GiaBan = ((int) p.GIABAN).ToString("N0")
                           })
                           .ToList();

            dgvMATHANGMain.DataSource = listMATHANG.ToList()
                                     .Where(p => p.Ten.ToUpper().Contains(keyWord))
                                     .Select(p => new
                                     {
                                         ID = p.ID,
                                         STT = ++i,
                                         Ten = p.Ten,
                                         GiaBan = p.GiaBan
                                     }).ToList();

            UpdateDetail();

            /// Load lại dòng đang chọn
            try
            {
                index = index1;
                dgvMATHANG.FocusedRowHandle = index;
                dgvMATHANGMain.Select();
            }
            catch
            {

            }

        }

        private void ucDanhMATHANGDauMATHANG_Load(object sender, EventArgs e)
        {
            LoadInitControl();
            LoadDgvMATHANG();
            LockControl();
        }

        #endregion

        #region Sự kiện
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (btnThem.Text == "Thêm")
            {
                btnSua.Enabled = false;
                btnThem.Text = "Lưu";
                btnXoa.Text = "Hủy";

                ClearControl();
                UnlockControl();

                return;
            }

            if (btnThem.Text == "Lưu")
            {
                if (Check())
                {
                    btnThem.Text = "Thêm";
                    btnXoa.Text = "Xóa";
                    LockControl();

                    MATHANG moi = getMATHANGByForm();
                    moi.SOLUONG = 0;
                    db.MATHANGs.Add(moi);
                    

                    try
                    {
                        db.SaveChanges();

                        MessageBox.Show("Thêm thông tin mặt hàng thành công",
                                        "Thông báo",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Thêm thông tin mặt hàng thất bại\n" + ex.Message,
                                        "Thông báo",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    }
                    LoadDgvMATHANG();
                }
                return;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!CheckLuaChon()) return;

            if (btnSua.Text == "Sửa")
            {
                btnSua.Text = "Lưu";
                btnXoa.Text = "Hủy";
                btnThem.Enabled = false;

                UnlockControl();

                return;
            }

            if (btnSua.Text == "Lưu")
            {
                if (Check())
                {
                    btnSua.Text = "Sửa";
                    btnXoa.Text = "Xóa";

                    LockControl();

                    MATHANG cu = getMATHANGByID();
                    MATHANG moi = getMATHANGByForm();
                    CapNhat(ref cu, moi);

                    try
                    {
                        db.SaveChanges();
                        MessageBox.Show("Sưa thông tin mặt hàng thành công",
                                        "Thông báo",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Sửa thông tin mặt hàng thất bại\n" + ex.Message,
                                        "Thông báo",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    }
                    LoadDgvMATHANG();
                }

                return;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (btnXoa.Text == "Xóa")
            {
                if (!CheckLuaChon()) return;

                MATHANG cu = getMATHANGByID();
                DialogResult rs = MessageBox.Show("Bạn có chắc chắn xóa mặt hàng " + cu.TEN + "?",
                                                  "Thông báo",
                                                  MessageBoxButtons.OKCancel,
                                                  MessageBoxIcon.Warning);

                if (rs == DialogResult.Cancel) return;

                try
                {
                    db.MATHANGs.Remove(cu);
                    db.SaveChanges();
                    MessageBox.Show("Xóa thông tin mặt hàng thành công",
                                    "Thông báo",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xóa thông tin mặt hàng thất bại\n" + ex.Message,
                                    "Thông báo",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
                LoadDgvMATHANG();

                return;
            }
            if (btnXoa.Text == "Hủy")
            {
                btnSua.Text = "Sửa";
                btnThem.Text = "Thêm";
                btnXoa.Text = "Xóa";

                LockControl();
                UpdateDetail();
                return;
            }
        }

        private void imgAnh_Click(object sender, EventArgs e)
        {
            string path = "";
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                open.ShowDialog();
                path = open.FileName;
            }
            catch
            {

            }

            try
            {
                Image image = Image.FromFile(path);

                imgAnh.Image = image;
            }
            catch
            {
                MessageBox.Show("Định dạng ảnh không phù hợp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


        }

        #endregion

        #region Sự kiện ngầm
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            LoadDgvMATHANG();
            txtTimKiem.Focus();   
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dgvDauMATHANG_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            UpdateDetail();

            try
            {
                index1 = index;
                index = dgvMATHANG.FocusedRowHandle;
            }
            catch { }
        }
        #endregion

    }
}
