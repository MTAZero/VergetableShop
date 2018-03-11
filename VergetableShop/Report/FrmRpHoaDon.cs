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
    public partial class FrmRpHoaDon : MetroForm
    {
        private VergetableContext db = Helper.db;
        private HOADON hd = new HOADON();
        public FrmRpHoaDon(HOADON z)
        {
            InitializeComponent();
            Helper.Reload();
            hd = z;
        }

        private void FrmRpHoaDon_Load(object sender, EventArgs e)
        {
            // CHi tiết hóa đơn
            int i = 0;
            HOADONBindingSource.DataSource = db.CHITIETHOADONs.Where(p => p.HOADONID == hd.ID).ToList()
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
                    new ReportParameter("MaHoaDon", hd.MAHOADON),
                    new ReportParameter("NgayBan", ((DateTime) hd.NGAY).ToString("dd/MM/yyyy")),
                    new ReportParameter("NhanVienBanHang", db.NHANVIENs.Where(p=>p.ID== hd.NHANVIENID).FirstOrDefault().TEN),
                    new ReportParameter("TongTien", ((int)hd.TONGTIEN).ToString("N0")),
                    new ReportParameter("TenKhachHang",hd.TENKHACHHANG)
                };
            this.rpViewerHoaDon.LocalReport.SetParameters(listPara);


            this.rpViewerHoaDon.LocalReport.Refresh();
            this.rpViewerHoaDon.RefreshReport();
        }
    }
}
