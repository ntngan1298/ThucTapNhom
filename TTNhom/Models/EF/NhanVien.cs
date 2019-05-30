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
        [Required(ErrorMessage ="Bạn phải nhập Tên")]
        [StringLength(100)]
        public string HoTen { get; set; }

        [Required(ErrorMessage = "Bạn phải nhập giới tính")]
        [StringLength(10)]
        public string GT { get; set; }

        [Required(ErrorMessage = "Bạn phải nhập địa chỉ ")]
        [StringLength(100)]
        public string DiaChi { get; set; }

        [Required(ErrorMessage = "Bạn phải nhập số điện thoại")]
        [StringLength(10)]
        public string SDT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DonHang> DonHangs { get; set; }
    }
}
