namespace TTNhom.Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SP")]
    public partial class SP
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SP()
        {
            CTDHs = new HashSet<CTDH>();
        }

        [Key]
        public int MaSP { get; set; }

        [Display(Name = "Tên Sản Phẩm")]
        [StringLength(50)]
        public string TenSP { get; set; }

        [Display(Name = "Giá")]
        public decimal? Gia { get; set; }

        [Display(Name = "KL")]
        public int? Khoiluong { get; set; }

        [Display(Name = "Ảnh")]
        [StringLength(50)]
        public string Anh { get; set; }

        [Display(Name = "Mô tả")]
        public string MoTa { get; set; }

        [Display(Name = "SL Tồn")]
        public int? SolgTon { get; set; }
        
        public int? MaLSP { get; set; }

        public int? MaNH { get; set; }

        public int? Moi { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTDH> CTDHs { get; set; }

        public virtual LoaiSP LoaiSP { get; set; }

        public virtual NhanHieu NhanHieu { get; set; }
    }
}
