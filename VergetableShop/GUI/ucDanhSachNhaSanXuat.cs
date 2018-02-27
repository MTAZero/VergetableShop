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
    public partial class ucDanhSachNhaSanXuat : UserControl
    {
        private VergetableContext db = Helper.db;
        private int index = 0, index1 = 0;

        #region constructor
        public ucDanhSachNhaSanXuat()
        {
            InitializeComponent();
            Helper.Reload();
        }

        #endregion

        #region Hàm chức năng

        private NXB getNHAXUATBANByID()
        {
            try
            {
                int id = (int) dgvNhaXuatBan.GetFocusedRowCellValue("ID");
                NXB ans = db.NXBs.Where(p => p.ID == id).FirstOrDefault();
                if (ans == null) return new NXB();
                return ans;
            }
            catch
            {
                return new NXB();
            }
        }

        private NXB getNHAXUATBANByForm()
        {
            NXB ans = new NXB();

            ans.TEN = txtTenNXB.Text;

            return ans;
        }

        private void ClearControl()
        {
            txtTenNXB.Text = "";
        }

        private void UpdateDetail()
        {
            try
            {
                NXB tg = getNHAXUATBANByID();

                if (tg.ID == 0) return;

                txtTenNXB.Text = tg.TEN;
            }
            catch
            {

            }
        }

        private void LockControl()
        {
            txtTenNXB.Enabled = false;

            dgvNhaXuatBanMain.Enabled = true;
            txtTimKiem.Enabled = true;

            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void UnlockControl()
        {
            txtTenNXB.Enabled = true;

            dgvNhaXuatBanMain.Enabled = false;
            txtTimKiem.Enabled = false;
        }

        private bool Check()
        {
            if (txtTenNXB.Text == "")
            {
                MessageBox.Show("Tên của nhà xuất bản không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private bool CheckLuaChon()
        {
            NXB tg = getNHAXUATBANByID();
            if (tg.ID == 0)
            {
                MessageBox.Show("Chưa có nhà xuất bản nào được chọn",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void CapNhat(ref NXB cu, NXB moi)
        {
            cu.TEN = moi.TEN;
        }

        #endregion

        #region LoadForm

        private void LoadInitControl()
        {
            ClearControl();
        }

        private void LoadDgvNXB()
        {
            int i = 0;
            string keyWord = txtTimKiem.Text.Trim().ToUpper();
            var listNHAXUATBAN = db.NXBs.ToList()
                           .Select(p => new
                           {
                               ID = p.ID,
                               Ten = p.TEN,
                           })
                           .ToList();
            dgvNhaXuatBanMain.DataSource = listNHAXUATBAN.ToList()
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
                dgvNhaXuatBan.FocusedRowHandle = index;
                dgvNhaXuatBanMain.Select();
            }
            catch
            {

            }

        }

        private void ucDanhSachNhaXuatBan_Load(object sender, EventArgs e)
        {
            LoadInitControl();
            LoadDgvNXB();
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

                    NXB moi = getNHAXUATBANByForm();
                    db.NXBs.Add(moi);

                    try
                    {
                        db.SaveChanges();
                        MessageBox.Show("Thêm thông tin nhà xuất bản thành công",
                                        "Thông báo",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Thêm thông tin nhà xuất bản thất bại\n" + ex.Message,
                                        "Thông báo",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    }
                    LoadDgvNXB();
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

                    NXB cu = getNHAXUATBANByID();
                    NXB moi = getNHAXUATBANByForm();
                    CapNhat(ref cu, moi);

                    try
                    {
                        db.SaveChanges();
                        MessageBox.Show("Sưa thông tin nhà xuất bản thành công",
                                        "Thông báo",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Sửa thông tin nhà xuất bản thất bại\n" + ex.Message,
                                        "Thông báo",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    }
                    LoadDgvNXB();
                }

                return;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (btnXoa.Text == "Xóa")
            {
                if (!CheckLuaChon()) return;

                NXB cu = getNHAXUATBANByID();
                DialogResult rs = MessageBox.Show("Bạn có chắc chắn xóa nhà xuất bản " + cu.TEN + "?",
                                                  "Thông báo",
                                                  MessageBoxButtons.OKCancel,
                                                  MessageBoxIcon.Warning);

                if (rs == DialogResult.Cancel) return;

                try
                {
                    db.NXBs.Remove(cu);
                    db.SaveChanges();
                    MessageBox.Show("Xóa thông tin nhà xuất bản thành công",
                                    "Thông báo",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xóa thông tin nhà xuất bản thất bại\n" + ex.Message,
                                    "Thông báo",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
                LoadDgvNXB();

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
            LoadDgvNXB();
            txtTimKiem.Focus();
        }

        private void dgvNhaXuatBan_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            UpdateDetail();

            try
            {
                index1 = index;
                index = dgvNhaXuatBan.FocusedRowHandle;
            }
            catch { }
        }

        #endregion
    }
}
