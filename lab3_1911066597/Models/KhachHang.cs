namespace lab3_1911066597.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Linq;

    [Table("KhachHang")]
    public partial class KhachHang
    {
        [Key]
        public int makh { get; set; }
        [Required]
        [StringLength(50)]
        public string hoten { get; set; }

        public string tendangnhap { get; set; }
        [StringLength(20)]
        public string matkhau { get; set; }
        [StringLength(10)]
        public string email { get; set; }
        [StringLength(50)]
        public string diachi { get; set; }
        [StringLength(50)]
        public string dienthoai { get; set; }
    }
}
