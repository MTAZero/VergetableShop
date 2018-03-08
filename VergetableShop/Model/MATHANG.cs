namespace BookShop.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MATHANG")]
    public partial class MATHANG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MATHANG()
        {
            CHITIETHOADONs = new HashSet<CHITIETHOADON>();
            CHITIETNHAPs = new HashSet<CHITIETNHAP>();
        }

        public int ID { get; set; }

        public string TEN { get; set; }

        public int? NHASANXUATID { get; set; }

        public int? GIABAN { get; set; }

        public int? NAMXUATBAN { get; set; }

        [Column(TypeName = "image")]
        public byte[] ANH { get; set; }

        public int? SOLUONG { get; set; }

        public int? GIASI { get; set; }

        public int? GIASHIP { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETHOADON> CHITIETHOADONs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETNHAP> CHITIETNHAPs { get; set; }

        public virtual NHASANXUAT NHASANXUAT { get; set; }
    }
}
