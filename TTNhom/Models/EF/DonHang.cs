namespace TTNhom.Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DonHang")]
    public partial class DonHang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DonHang()
        {
            CTDHs = new HashSet<CTDH>();
        }

        [Key]
        public int MaDH { get; set; }

        public int? DaThanhToan { get; set; }

        public int? TinhtrangGH { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ngaydat { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ngaygiao { get; set; }

        public int? MaKH { get; set; }

        public int? MaNV { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTDH> CTDHs { get; set; }

        public virtual KhachHang KhachHang { get; set; }

        public virtual NhanVien NhanVien { get; set; }
    }
}
