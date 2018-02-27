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
    public partial class FrmLuaChonSanPham : MetroForm
    {
        private VergetableContext db = Helper.db;

        #region Khởi tạo
        public FrmLuaChonSanPham()
        {
            InitializeComponent();
            Helper.Reload();
        }
        #endregion

        #region LoadForm
        private void LoadSanPham()
        {
            var listMatHang = db.MATHANGs.ToList();

            panelMatHang.Controls.Clear();
            foreach (var item in listMatHang)
            {
                ucMatHang uc = new ucMatHang(item, LuaChon);

                if (Helper.TenSanPham(item).ToUpper().Contains(txtTimKiem.Text.ToUpper()))
                {

                    uc.Tag = item.ID;
                    uc.Enabled = true;
                    panelMatHang.Controls.Add(uc);
                }
            }
        }
        private void FrmLuaChonSanPham_Load(object sender, EventArgs e)
        {
            LoadSanPham();
        }

        private void LuaChon(object sender, EventArgs e)
        {
            ucMatHang sp = sender as ucMatHang;
            this.Close();
        }
        #endregion

        #region Sự kiện
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            LoadSanPham();
        }
        #endregion
    }
}
