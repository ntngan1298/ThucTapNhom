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
        [Display(Name ="Thanh toán")]
        public int? DaThanhToan { get; set; }

        [Display(Name = "Giao hàng")]
        public int? TinhtrangGH { get; set; }

        [Display(Name = "Ngày đặt hàng")]
        [Column(TypeName = "date")]
        public DateTime? ngaydat { get; set; }

        [Display(Name = "Ngày giao hàng")]
        [Column(TypeName = "date")]
        public DateTime? ngaygiao { get; set; }

        [Display(Name = "Khách hàng")]
        public int? MaKH { get; set; }

        [Display(Name = "NV lập")]
        public int? MaNV { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTDH> CTDHs { get; set; }

        public virtual KhachHang KhachHang { get; set; }

        public virtual NhanVien NhanVien { get; set; }
    }
}
