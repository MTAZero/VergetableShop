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
    public partial class ucDanhSachDauSach : UserControl
    {
        private VergetableContext db = Helper.db;
        private int index = 0, index1 = 0;

        #region Construtor
        public ucDanhSachDauSach()
        {
            InitializeComponent();
            Helper.Reload();
        }

        #endregion

        #region Hàm chức năng

        private SACH getSACHByID()
        {
            try
            {
                int id = (int)dgvSACH.GetFocusedRowCellValue("ID");
                SACH ans = db.SACHes.Where(p => p.ID == id).FirstOrDefault();
                if (ans == null) return new SACH();
                return ans;
            }
            catch
            {
                return new SACH();
            }
        }

        private SACH getSACHByForm()
        {
            SACH ans = new SACH();

            try
            {
                ans.TEN = txtTenSach.Text;
                ans.GIABAN = Int32.Parse(txtGiaBan.Text);
                ans.NAMXUATBAN = Int32.Parse(txtNamXuatBan.Text);
                ans.THONGTINSACH = txtThongTinSach.Text;
                ans.TACGIAID = (int)cbxTacGia.EditValue;
                ans.NXBID = (int)cbxNXB.EditValue;
                ans.THELOAIID = (int)cbxTheLoai.EditValue;

                ans.ANH = Helper.imageToByteArray(imgAnh.Image);
            }
            catch { }

            return ans;
        }

        private void ClearControl()
        {
            cbxNXB.ItemIndex = 0;
            cbxTacGia.ItemIndex = 0;
            cbxTheLoai.ItemIndex = 0;

            txtTenSach.Text = "";
            txtGiaBan.Text = "";
            txtNamXuatBan.Text = "";
            txtThongTinSach.Text = "";
            txtTitleTacGia.Text = "";
            txtTitleTenSach.Text = "";

            imgAnh.Image = null;
        }

        private void UpdateDetail()
        {
            try
            {
                SACH ans = getSACHByID();

                if (ans.ID == 0) return;

                cbxNXB.EditValue = ans.NXBID;
                cbxTacGia.EditValue = ans.TACGIAID;
                cbxTheLoai.EditValue = ans.THELOAIID;

                txtTenSach.Text = ans.TEN;
                txtGiaBan.Text = ans.GIABAN.ToString();
                txtNamXuatBan.Text = ans.NAMXUATBAN.ToString();
                txtThongTinSach.Text = ans.THONGTINSACH;
                txtTitleTacGia.Text = cbxTacGia.Text;
                txtTitleTenSach.Text = ans.TEN;

                imgAnh.Image = null;
                imgAnh.Image = Helper.byteArrayToImage(ans.ANH);
            }
            catch
            {

            }
        }

        private void LockControl()
        {
            txtTenSach.Enabled = false;
            cbxTacGia.Enabled = false;
            cbxNXB.Enabled = false;
            cbxTheLoai.Enabled = false;
            txtGiaBan.Enabled = false;
            txtNamXuatBan.Enabled = false;
            txtThongTinSach.Enabled = false;
            imgAnh.Enabled = false;

            dgvSACHMain.Enabled = true;
            txtTimKiem.Enabled = true;

            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void UnlockControl()
        {
            txtTenSach.Enabled = true;
            cbxTacGia.Enabled = true;
            cbxNXB.Enabled = true;
            cbxTheLoai.Enabled = true;
            txtGiaBan.Enabled = true;
            txtNamXuatBan.Enabled = true;
            txtThongTinSach.Enabled = true;
            imgAnh.Enabled = true;

            dgvSACHMain.Enabled = false;
            txtTimKiem.Enabled = false;
        }

        private bool Check()
        {
            if (imgAnh.Image == null)
            {
                MessageBox.Show("Ảnh của đầu sách không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtTenSach.Text == "")
            {
                MessageBox.Show("Tên của đầu sách không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            try
            {
                int giaban = Int32.Parse(txtGiaBan.Text);
                giaban = giaban / giaban;
            }
            catch
            {
                MessageBox.Show("Giá bán của đầu sách phải là số nguyên dương",
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

            return true;
        }

        private bool CheckLuaChon()
        {
            SACH tg = getSACHByID();
            if (tg.ID == 0)
            {
                MessageBox.Show("Chưa có đầu sách nào được chọn",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void CapNhat(ref SACH cu, SACH moi)
        {
            cu.TEN = moi.TEN;
            cu.TACGIAID = moi.TACGIAID;
            cu.NXBID = moi.NXBID;
            cu.THELOAIID = moi.THELOAIID;
            cu.GIABAN = moi.GIABAN;
            cu.NAMXUATBAN = moi.NAMXUATBAN;
            cu.THONGTINSACH = moi.THONGTINSACH;
            cu.ANH = moi.ANH;
        }

        #endregion

        #region LoadForm

        private void LoadInitControl()
        {
            cbxNXB.Properties.DataSource = db.NXBs.Select(p => new { ID = p.ID, TEN = p.TEN }).ToList();
            cbxNXB.Properties.DisplayMember = "TEN";
            cbxNXB.Properties.ValueMember = "ID";

            cbxTacGia.Properties.DataSource = db.TACGIAs.Select(p => new { ID = p.ID, TEN = p.TEN }).ToList();
            cbxTacGia.Properties.DisplayMember = "TEN";
            cbxTacGia.Properties.ValueMember = "ID";

            cbxTheLoai.Properties.DataSource = db.THELOAIs.Select(p => new { ID = p.ID, TEN = p.TEN }).ToList();
            cbxTheLoai.Properties.DisplayMember = "TEN";
            cbxTheLoai.Properties.ValueMember = "ID";

            ClearControl();
        }

        private void LoadDgvSACH()
        {
            int i = 0;
            string keyWord = txtTimKiem.Text.Trim().ToUpper();
            var listSach = db.SACHes.ToList()
                           .Select(p => new
                           {
                               ID = p.ID,
                               Ten = p.TEN,
                               GiaBan = ((int) p.GIABAN).ToString("N0")
                           })
                           .ToList();

            dgvSACHMain.DataSource = listSach.ToList()
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
                dgvSACH.FocusedRowHandle = index;
                dgvSACHMain.Select();
            }
            catch
            {

            }

        }

        private void ucDanhSachDauSach_Load(object sender, EventArgs e)
        {
            LoadInitControl();
            LoadDgvSACH();
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

                    SACH moi = getSACHByForm();
                    db.SACHes.Add(moi);
                    

                    try
                    {
                        db.SaveChanges();

                        MATHANG mh = new MATHANG();
                        mh.LOAISP = 0;
                        mh.SACHID = moi.ID;
                        mh.SOLUONG = 0;
                        db.MATHANGs.Add(mh);
                        db.SaveChanges();

                        MessageBox.Show("Thêm thông tin đầu sách thành công",
                                        "Thông báo",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Thêm thông tin đầu sách thất bại\n" + ex.Message,
                                        "Thông báo",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    }
                    LoadDgvSACH();
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

                    SACH cu = getSACHByID();
                    SACH moi = getSACHByForm();
                    CapNhat(ref cu, moi);

                    try
                    {
                        db.SaveChanges();
                        MessageBox.Show("Sưa thông tin đầu sách thành công",
                                        "Thông báo",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Sửa thông tin đầu sách thất bại\n" + ex.Message,
                                        "Thông báo",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    }
                    LoadDgvSACH();
                }

                return;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (btnXoa.Text == "Xóa")
            {
                if (!CheckLuaChon()) return;

                SACH cu = getSACHByID();
                DialogResult rs = MessageBox.Show("Bạn có chắc chắn xóa đầu sách " + cu.TEN + "?",
                                                  "Thông báo",
                                                  MessageBoxButtons.OKCancel,
                                                  MessageBoxIcon.Warning);

                if (rs == DialogResult.Cancel) return;

                try
                {
                    MATHANG mh = db.MATHANGs.Where(p => p.LOAISP == 0 && p.SACHID == cu.ID).FirstOrDefault();
                    if (mh != null) db.MATHANGs.Remove(mh);

                    db.SACHes.Remove(cu);
                    db.SaveChanges();
                    MessageBox.Show("Xóa thông tin đầu sách thành công",
                                    "Thông báo",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xóa thông tin đầu sách thất bại\n" + ex.Message,
                                    "Thông báo",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
                LoadDgvSACH();

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
            LoadDgvSACH();
            txtTimKiem.Focus();   
        }

        private void dgvDauSach_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            UpdateDetail();

            try
            {
                index1 = index;
                index = dgvSACH.FocusedRowHandle;
            }
            catch { }
        }
        #endregion

    }
}
