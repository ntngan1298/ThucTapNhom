namespace TTNhom.Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NhanVien")]
    public partial class NhanVien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NhanVien()
        {
            DonHangs = new HashSet<DonHang>();
        }

        [Key]
        public int MaNV { get; set; }

        [Display(Name = "Tên NV")]
        [StringLength(100)]
        public string HoTen { get; set; }

        [Display(Name = "Giới tính")]
        [StringLength(10)]
        public string GT { get; set; }

        [Display(Name = "Địa chỉ")]
        [StringLength(100)]
        public string DiaChi { get; set; }

        [Display(Name = "Số điện thoại")]
        [StringLength(10)]
        public string SDT { get; set; }

        [Display(Name = "Số điện thoại")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DonHang> DonHangs { get; set; }
    }
}
