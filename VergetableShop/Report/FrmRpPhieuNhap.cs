using BookShop.Model;
using MetroFramework.Forms;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookShop.Report
{
    public partial class FrmRpPhieuNhap : MetroForm
    {
        private VergetableContext db = Helper.db;
        private PHIEUNHAP hd = new PHIEUNHAP();
        public FrmRpPhieuNhap(PHIEUNHAP z)
        {
            InitializeComponent();
            Helper.Reload();
            hd = z;
        }

        private void FrmRpHoaDon_Load(object sender, EventArgs e)
        {
            // CHi tiết hóa đơn
            int i = 0;
            HOADONBindingSource.DataSource = db.CHITIETNHAPs.Where(p => p.PHIEUNHAPID == hd.ID).ToList()
                                             .Select(p => new
                                             {
                                                 STT = ++i,
                                                 MatHang = Helper.TenSanPham(db.MATHANGs.Where(k=>k.ID == p.MATHANGID).FirstOrDefault()),
                                                 SoLuong = p.SOLUONG,
                                                 DonGia = ((int)p.DONGIA).ToString("N0"),
                                                 ThanhTien = ((int)p.THANHTIEN).ToString("N0")
                                             })
                                             .ToList();

            ReportParameter[] listPara = new ReportParameter[]{
                    new ReportParameter("MaPhieuNhap", hd.MAPHIEUNHAP),
                    new ReportParameter("NgayNhap", ((DateTime) hd.NGAY).ToString("dd/MM/yyyy")),
                    new ReportParameter("NhanVienNhap", db.NHANVIENs.Where(p=>p.ID== hd.NHANVIENID).FirstOrDefault().TEN),
                    new ReportParameter("TongTien", ((int)hd.TONGTIEN).ToString("N0"))
                };
            this.rpViewerHoaDon.LocalReport.SetParameters(listPara);


            this.rpViewerHoaDon.LocalReport.Refresh();
            this.rpViewerHoaDon.RefreshReport();
        }
    }
}
