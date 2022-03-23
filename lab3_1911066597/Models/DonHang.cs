namespace lab3_1911066597.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Linq;

    [Table("DonHang")]
    public partial class DonHang
    {
        [Key]
        public int madon { get; set; }
        [StringLength(50)]
        public String thanhtoan { get; set; }
        [StringLength(50)]
        public String giaohang { get; set; }
       
        public DateTime? ngaydat { get; set; }
        public DateTime? ngaygiao { get; set; }
        [StringLength(50)]
        public int makh { get; set; }
       
    }
}