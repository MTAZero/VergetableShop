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
    public partial class ucKho : UserControl
    {
        private VergetableContext db = Helper.db;

        #region Constructor
        public ucKho()
        {
            InitializeComponent();
            Helper.Reload();
        }
        #endregion

        #region LoadForm

        private void LoadDgv()
        {
            string KeyWord = txtTimKiem.Text.ToUpper();

            int i = 0;
            dgvKhoMain.DataSource = db.MATHANGs.ToList()
                                    .Where(p => Helper.TenSanPham(p).ToUpper().Contains(KeyWord))
                                    .OrderByDescending(p=>p.SOLUONG)
                                    .Select(p => new
                                    {
                                        STT = ++i,
                                        MatHang = Helper.TenSanPham(p),
                                        SoLuong = p.SOLUONG,
                                        GiaBan = Helper.GiaSanPham(p).ToString("N0"),
                                        TongGiaTri = ((int)Helper.GiaSanPham(p) * (int) p.SOLUONG).ToString("N0")
                                    })
                                    .ToList();
        }

        private void ucKho_Load(object sender, EventArgs e)
        {
            LoadDgv();
        }
        #endregion

        #region Sự kiện ngầm
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            LoadDgv();
        }
        #endregion
    }
}
