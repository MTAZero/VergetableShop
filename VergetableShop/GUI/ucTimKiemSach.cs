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
    public partial class ucTimKiemSach : UserControl
    {
        private VergetableContext db = Helper.db;

        #region Hàm khởi tạo
        public ucTimKiemSach()
        {
            InitializeComponent();
            Helper.Reload();
        }

        #endregion

        #region LoadForm

        private void LoadTheLoai()
        {
            panelTheLoai.Controls.Clear();

            var listTheLoai = db.THELOAIs.ToList();
            foreach (var item in listTheLoai)
            {
                CheckBox ich = new CheckBox();
                ich.Tag = item.ID;
                ich.Text = item.TEN;
                ich.AutoSize = false;
                ich.Size = new System.Drawing.Size(180, 21);
                ich.CheckedChanged += LoadSach;
                ich.Checked = true;
                panelTheLoai.Controls.Add(ich);
            }
        }

        private void LoadTacGia()
        {
            panelTacGia.Controls.Clear();

            var listTacGia = db.TACGIAs.ToList();
            foreach (var item in listTacGia)
            {
                CheckBox ich = new CheckBox();
                ich.Tag = item.ID;
                ich.Text = item.TEN;
                ich.AutoSize = false;
                ich.Size = new System.Drawing.Size(180, 21);
                ich.Checked = true;
                ich.CheckedChanged += LoadSach;
                panelTacGia.Controls.Add(ich);
            }
        }

        private void LoadNXB()
        {
            panelNhaXuatBan.Controls.Clear();

            var listNXB = db.NXBs.ToList();
            foreach (var item in listNXB)
            {
                CheckBox ich = new CheckBox();
                ich.Tag = item.ID;
                ich.Text = item.TEN;
                ich.AutoSize = false;
                ich.Size = new System.Drawing.Size(180, 21);
                ich.Checked = true;
                ich.CheckedChanged += LoadSach;
                panelNhaXuatBan.Controls.Add(ich);
            }
        }

        private void DisplayListSach()
        {
            var listSach = db.SACHes.ToList();

            /// Getlist tác giả được chọn
            var listTacGia = new List<TACGIA>();
            foreach (var item in panelTacGia.Controls)
            {
                var iz = item as CheckBox;

                if (iz.Checked)
                {
                    TACGIA tg = db.TACGIAs.Where(p => p.ID == (int)iz.Tag).First();
                    listTacGia.Add(tg);
                }
            }
            listSach = (
                        from sach in listSach
                        from tacgia in listTacGia
                        where sach.TACGIAID == tacgia.ID
                        select sach
                       )
                       .ToList();

            /// Getlist thể loại được chọn
            var listTheLoai = new List<THELOAI>();
            foreach (var item in panelTheLoai.Controls)
            {
                var iz = item as CheckBox;

                if (iz.Checked)
                {
                    THELOAI tg = db.THELOAIs.Where(p => p.ID == (int)iz.Tag).First();
                    listTheLoai.Add(tg);
                }
            }
            listSach = (
                        from sach in listSach
                        from theloai in listTheLoai
                        where sach.THELOAIID == theloai.ID
                        select sach
                       )
                       .ToList();

            /// Getlist nhà xuất bản được chọn
            var listNXB = new List<NXB>();
            foreach (var item in panelNhaXuatBan.Controls)
            {
                var iz = item as CheckBox;

                if (iz.Checked)
                {
                    NXB tg = db.NXBs.Where(p => p.ID == (int)iz.Tag).First();
                    listNXB.Add(tg);
                }
            }
            listSach = (
                        from sach in listSach
                        from nxb in listNXB
                        where sach.NXBID == nxb.ID
                        select sach
                       )
                       .ToList();

            /// Hiển thị các quyển sách
            panelSach.Controls.Clear();
            foreach (var item in listSach)
            {
                ucSach z = new ucSach(item);
                panelSach.Controls.Add(z);
            }

        }

        private void LoadSach(object sender, EventArgs e)
        {
            DisplayListSach();
        }

        private void ucTimKiemSach_Load(object sender, EventArgs e)
        {
            LoadTheLoai();
            LoadTacGia();
            LoadNXB();
            DisplayListSach();
        }
        #endregion

        
    }
}
