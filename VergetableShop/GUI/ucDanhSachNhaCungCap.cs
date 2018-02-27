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
    public partial class ucDanhSachNhaCungCap : UserControl
    {
        private VergetableContext db = Helper.db;
        private int index = 0, index1 = 0;

        #region constructor
        public ucDanhSachNhaCungCap()
        {
            InitializeComponent();
            Helper.Reload();
        }

        #endregion

        #region Hàm chức năng

        private NHACUNGCAP getNHACUNGCAPByID()
        {
            try
            {
                int id = (int) dgvNHACUNGCAP.GetFocusedRowCellValue("ID");
                NHACUNGCAP ans = db.NHACUNGCAPs.Where(p => p.ID == id).FirstOrDefault();
                if (ans == null) return new NHACUNGCAP();
                return ans;
            }
            catch
            {
                return new NHACUNGCAP();
            }
        }

        private NHACUNGCAP getNHACUNGCAPByForm()
        {
            NHACUNGCAP ans = new NHACUNGCAP();

            ans.TEN = txtTenNHACUNGCAP.Text;

            return ans;
        }

        private void ClearControl()
        {
            txtTenNHACUNGCAP.Text = "";
        }

        private void UpdateDetail()
        {
            try
            {
                NHACUNGCAP tg = getNHACUNGCAPByID();

                if (tg.ID == 0) return;

                txtTenNHACUNGCAP.Text = tg.TEN;
            }
            catch
            {

            }
        }

        private void LockControl()
        {
            txtTenNHACUNGCAP.Enabled = false;

            dgvNHACUNGCAPMain.Enabled = true;
            txtTimKiem.Enabled = true;

            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void UnlockControl()
        {
            txtTenNHACUNGCAP.Enabled = true;

            dgvNHACUNGCAPMain.Enabled = false;
            txtTimKiem.Enabled = false;
        }

        private bool Check()
        {
            if (txtTenNHACUNGCAP.Text == "")
            {
                MessageBox.Show("Tên của nhà cung cấp không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private bool CheckLuaChon()
        {
            NHACUNGCAP tg = getNHACUNGCAPByID();
            if (tg.ID == 0)
            {
                MessageBox.Show("Chưa có nhà cung cấp nào được chọn",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void CapNhat(ref NHACUNGCAP cu, NHACUNGCAP moi)
        {
            cu.TEN = moi.TEN;
        }

        #endregion

        #region LoadForm

        private void LoadInitControl()
        {
            ClearControl();
        }

        private void LoadDgvNhanVien()
        {
            int i = 0;
            string keyWord = txtTimKiem.Text.Trim().ToUpper();
            var listNHACUNGCAP = db.NHACUNGCAPs.ToList()
                           .Select(p => new
                           {
                               ID = p.ID,
                               Ten = p.TEN,
                           })
                           .ToList();
            dgvNHACUNGCAPMain.DataSource = listNHACUNGCAP.ToList()
                                         .Where(p => p.Ten.ToUpper().Contains(keyWord))
                                         .Select(p => new
                                         {
                                             ID = p.ID,
                                             STT = ++i,
                                             Ten = p.Ten,
                                         }).ToList();

            UpdateDetail();

            /// Load lại dòng đang chọn
            try
            {
                index = index1;
                dgvNHACUNGCAP.FocusedRowHandle = index;
                dgvNHACUNGCAPMain.Select();
            }
            catch
            {

            }

        }

        private void ucDanhSachNHACUNGCAP_Load(object sender, EventArgs e)
        {
            LoadInitControl();
            LoadDgvNhanVien();
            LockControl();
        }
        #endregion

        #region sự kiện
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

                    NHACUNGCAP moi = getNHACUNGCAPByForm();
                    db.NHACUNGCAPs.Add(moi);

                    try
                    {
                        db.SaveChanges();
                        MessageBox.Show("Thêm thông tin nhà cung cấp thành công",
                                        "Thông báo",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Thêm thông tin nhà cung cấp thất bại\n" + ex.Message,
                                        "Thông báo",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    }
                    LoadDgvNhanVien();
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

                    NHACUNGCAP cu = getNHACUNGCAPByID();
                    NHACUNGCAP moi = getNHACUNGCAPByForm();
                    CapNhat(ref cu, moi);

                    try
                    {
                        db.SaveChanges();
                        MessageBox.Show("Sưa thông tin nhà cung cấp thành công",
                                        "Thông báo",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Sửa thông tin nhà cung cấp thất bại\n" + ex.Message,
                                        "Thông báo",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    }
                    LoadDgvNhanVien();
                }

                return;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (btnXoa.Text == "Xóa")
            {
                if (!CheckLuaChon()) return;

                NHACUNGCAP cu = getNHACUNGCAPByID();
                DialogResult rs = MessageBox.Show("Bạn có chắc chắn xóa nhà cung cấp " + cu.TEN + "?",
                                                  "Thông báo",
                                                  MessageBoxButtons.OKCancel,
                                                  MessageBoxIcon.Warning);

                if (rs == DialogResult.Cancel) return;

                try
                {
                    db.NHACUNGCAPs.Remove(cu);
                    db.SaveChanges();
                    MessageBox.Show("Xóa thông tin nhà cung cấp thành công",
                                    "Thông báo",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xóa thông tin nhà cung cấp thất bại\n" + ex.Message,
                                    "Thông báo",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
                LoadDgvNhanVien();

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
        
        #endregion

        #region sự kiện ngầm

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            LoadDgvNhanVien();
            txtTimKiem.Focus();
        }

        private void dgvNhaXuatBan_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            UpdateDetail();

            try
            {
                index1 = index;
                index = dgvNHACUNGCAP.FocusedRowHandle;
            }
            catch { }
        }

        #endregion
    }
}
