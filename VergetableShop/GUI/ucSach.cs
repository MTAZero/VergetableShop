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
    public partial class ucSach : UserControl
    {
        private SACH tg = new SACH();

        #region Load
        public ucSach(SACH z)
        {
            InitializeComponent();
            tg = z;
        }
        #endregion

        private void ucSach_Load(object sender, EventArgs e)
        {
            txtTenSach.Text = tg.TEN;
            txtGiaBan.Text = ((int)tg.GIABAN).ToString("N0");
            imgAnh.Image = Helper.byteArrayToImage(tg.ANH);
        }
    }
}
