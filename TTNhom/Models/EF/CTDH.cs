namespace TTNhom.Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CTDH")]
    public partial class CTDH
    {
        [Key]
        public int MaCTDH { get; set; }

        public int? MaDH { get; set; }

        public int? MaSP { get; set; }

        public int? soluong { get; set; }

        public decimal? thanhtien { get; set; }

        public virtual DonHang DonHang { get; set; }

        public virtual SP SP { get; set; }
    }
}
