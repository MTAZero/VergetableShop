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
    public partial class ucMatHang : UserControl
    {
        private MATHANG tg = new MATHANG();
        private VergetableContext db = Helper.db;

        #region Load
        public ucMatHang(MATHANG z,EventHandler sukien)
        {
            InitializeComponent();
            tg = z;
            Helper.Reload();

            panel2.Click += sukien;
            imgAnh.Click += sukien;
            txtTen.Click += sukien;

            panel2.Click += Gan;
            imgAnh.Click += Gan;
            txtTen.Click += Gan;
        }
        #endregion

        private void Gan(object sender, EventArgs e)
        {
            Helper.IDSanPham = tg.ID;
        }

        private void ucSach_Load(object sender, EventArgs e)
        {
            panel2.Tag = this.Tag;
            imgAnh.Tag = this.Tag;
            txtTen.Tag = this.Tag;

            MATHANG k = db.MATHANGs.Where(p => p.ID == tg.ID).First();
            k = tg;
            /// Nếu là sách
            txtTen.Text = k.TEN;
            imgAnh.Image = Helper.byteArrayToImage(k.ANH);

        }
    }
}
