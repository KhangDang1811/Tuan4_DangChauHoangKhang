namespace lab3_1911066597.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Linq;

    [Table("ChiTietDonHang")]
    public partial class ChiTietDonHang
    {
        [Key]
        public int madon { get; set; }
       
        public int massach { get; set; }
        public int soluong { get; set; }
        public decimal? gia { get; set; }

    }
}