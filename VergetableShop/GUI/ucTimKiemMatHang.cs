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
    public partial class ucTimKiemMatHang : UserControl
    {
        private VergetableContext db = Helper.db;

        #region Hàm khởi tạo
        public ucTimKiemMatHang()
        {
            InitializeComponent();
            Helper.Reload();
        }

        #endregion

        #region LoadForm

        private void LoadNHASANXUAT()
        {
            panelNHASANXUAT.Controls.Clear();

            var listNHASANXUAT = db.NHASANXUATs.ToList();
            foreach (var item in listNHASANXUAT)
            {
                CheckBox ich = new CheckBox();
                ich.Tag = item.ID;
                ich.Text = item.TEN;
                ich.AutoSize = false;
                ich.Size = new System.Drawing.Size(350, 21);
                ich.Checked = true;
                ich.CheckedChanged += LoadSach;
                panelNHASANXUAT.Controls.Add(ich);
            }
        }

        private void DisplayListSach()
        {
            var listSach = db.MATHANGs.ToList();

            /// Getlist tác giả được chọn
            var listNHASANXUAT = new List<NHASANXUAT>();
            foreach (var item in panelNHASANXUAT.Controls)
            {
                var iz = item as CheckBox;

                if (iz.Checked)
                {
                    NHASANXUAT tg = db.NHASANXUATs.Where(p => p.ID == (int)iz.Tag).First();
                    listNHASANXUAT.Add(tg);
                }
            }
            listSach = (
                        from sach in listSach
                        from NHASANXUAT in listNHASANXUAT
                        where sach.NHASANXUATID == NHASANXUAT.ID
                        select sach
                       )
                       .ToList();

            /// Hiển thị các quyển sách
            panelSach.Controls.Clear();
            foreach (var item in listSach)
            {
                ucS z = new ucS(item);
                panelSach.Controls.Add(z);
            }

        }

        private void LoadSach(object sender, EventArgs e)
        {
            DisplayListSach();
        }

        private void ucTimKiemSach_Load(object sender, EventArgs e)
        {
            LoadNHASANXUAT();
            //LoadNXB();
            DisplayListSach();
        }
        #endregion

        
    }
}
