namespace TTNhom.Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TaiKhoan")]
    public partial class TaiKhoan
    {
        [Key]
        public int userId { get; set; }

        [StringLength(50)]
        public string userName { get; set; }

        [StringLength(32)]
        public string password { get; set; }
    }
}
