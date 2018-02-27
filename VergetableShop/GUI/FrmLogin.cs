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
    public partial class FrmLogin : MetroForm
    {
        private VergetableContext db = Helper.db;

        #region Hàm khởi tạo
        public FrmLogin()
        {
            InitializeComponent();
            Helper.Reload();
        }
        #endregion

        #region Sự kiện
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string taikhoan = txtTaiKhoan.Text;
            string matkhau = txtMatKhau.Text;

            int cnt = db.NHANVIENs.Where(p => p.TAIKHOAN == taikhoan && p.MATKHAU == matkhau).ToList().Count;

            if (cnt == 0)
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu chưa chính xác",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            NHANVIEN nv = db.NHANVIENs.Where(p => p.TAIKHOAN == taikhoan).FirstOrDefault();
            FrmMain form = new FrmMain(nv);
            this.Hide();
            form.ShowDialog();
            this.Show();

            txtTaiKhoan.Text = "";
            txtMatKhau.Text = "";

            this.Focus();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
