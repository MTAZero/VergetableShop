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

        private NHASANXUAT getNHAXUATBANByID()
        {
            try
            {
                int id = (int) dgvNhaXuatBan.GetFocusedRowCellValue("ID");
                NHASANXUAT ans = db.NHASANXUATs.Where(p => p.ID == id).FirstOrDefault();
                if (ans == null) return new NHASANXUAT();
                return ans;
            }
            catch
            {
                return new NHASANXUAT();
            }
        }

        private NHASANXUAT getNHAXUATBANByForm()
        {
            NHASANXUAT ans = new NHASANXUAT();

            ans.TEN = txtTenNHASANXUAT.Text;
            ans.DIACHI = txtDiaChi.Text;
            ans.MASOTHUE = txtMaSoThue.Text;
            ans.SDT = txtSDT.Text;

            return ans;
        }

        private void ClearControl()
        {
            txtTenNHASANXUAT.Text = "";
            txtDiaChi.Text = "";
            txtMaSoThue.Text = "";
            txtSDT.Text = "";
        }

        private void UpdateDetail()
        {
            try
            {
                NHASANXUAT tg = getNHAXUATBANByID();

                if (tg.ID == 0) return;

                txtTenNHASANXUAT.Text = tg.TEN;
                txtDiaChi.Text = tg.DIACHI;
                txtMaSoThue.Text = tg.MASOTHUE;
                txtSDT.Text = tg.SDT;
            }
            catch
            {

            }
        }

        private void LockControl()
        {
            txtTenNHASANXUAT.Enabled = false;
            txtDiaChi.Enabled = false;
            txtMaSoThue.Enabled = false;
            txtSDT.Enabled = false;

            dgvNhaXuatBanMain.Enabled = true;
            txtTimKiem.Enabled = true;

            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void UnlockControl()
        {
            txtTenNHASANXUAT.Enabled = true;
            txtDiaChi.Enabled = true;
            txtMaSoThue.Enabled = true;
            txtSDT.Enabled = true;

            dgvNhaXuatBanMain.Enabled = false;
            txtTimKiem.Enabled = false;
        }

        private bool Check()
        {
            if (txtTenNHASANXUAT.Text == "")
            {
                MessageBox.Show("Tên của nhà sản xuất không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtDiaChi.Text == "")
            {
                MessageBox.Show("Địa chỉ của nhà sản xuất không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtMaSoThue.Text == "")
            {
                MessageBox.Show("Mã số thuế của nhà sản xuất không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtSDT.Text == "")
            {
                MessageBox.Show("Số điện thoại của nhà sản xuất không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                return false;
            }

            return true;
        }

        private bool CheckLuaChon()
        {
            NHASANXUAT tg = getNHAXUATBANByID();
            if (tg.ID == 0)
            {
                MessageBox.Show("Chưa có nhà sản xuất nào được chọn",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void CapNhat(ref NHASANXUAT cu, NHASANXUAT moi)
        {
            cu.TEN = moi.TEN;
            cu.DIACHI = moi.DIACHI;
            cu.MASOTHUE = moi.MASOTHUE;
            cu.SDT = moi.SDT;
        }

        #endregion

        #region LoadForm

        private void LoadInitControl()
        {
            ClearControl();
        }

        private void LoadDgvNHASANXUAT()
        {
            int i = 0;
            string keyWord = txtTimKiem.Text.Trim().ToUpper();
            var listNHAXUATBAN = db.NHASANXUATs.ToList()
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
            LoadDgvNHASANXUAT();
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

                    NHASANXUAT moi = getNHAXUATBANByForm();
                    db.NHASANXUATs.Add(moi);

                    try
                    {
                        db.SaveChanges();
                        MessageBox.Show("Thêm thông tin nhà sản xuất thành công",
                                        "Thông báo",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Thêm thông tin nhà sản xuất thất bại\n" + ex.Message,
                                        "Thông báo",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    }
                    LoadDgvNHASANXUAT();
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

                    NHASANXUAT cu = getNHAXUATBANByID();
                    NHASANXUAT moi = getNHAXUATBANByForm();
                    CapNhat(ref cu, moi);

                    try
                    {
                        db.SaveChanges();
                        MessageBox.Show("Sưa thông tin nhà sản xuất thành công",
                                        "Thông báo",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Sửa thông tin nhà sản xuất thất bại\n" + ex.Message,
                                        "Thông báo",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    }
                    LoadDgvNHASANXUAT();
                }

                return;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (btnXoa.Text == "Xóa")
            {
                if (!CheckLuaChon()) return;

                NHASANXUAT cu = getNHAXUATBANByID();
                DialogResult rs = MessageBox.Show("Bạn có chắc chắn xóa nhà sản xuất " + cu.TEN + "?",
                                                  "Thông báo",
                                                  MessageBoxButtons.OKCancel,
                                                  MessageBoxIcon.Warning);

                if (rs == DialogResult.Cancel) return;

                try
                {
                    db.NHASANXUATs.Remove(cu);
                    db.SaveChanges();
                    MessageBox.Show("Xóa thông tin nhà sản xuất thành công",
                                    "Thông báo",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xóa thông tin nhà sản xuất thất bại\n" + ex.Message,
                                    "Thông báo",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
                LoadDgvNHASANXUAT();

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
            LoadDgvNHASANXUAT();
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
