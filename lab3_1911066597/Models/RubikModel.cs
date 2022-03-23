using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace lab3_1911066597.Models
{
    public partial class RubikModel : DbContext
    {
        public RubikModel()
            : base("name=RubikModel")
        {
        }

        public virtual DbSet<Loai> Loais { get; set; }
        public virtual DbSet<Rubik> Rubiks { get; set; }

        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<DonHang> DonHangs { get; set; }
        public virtual DbSet<ChiTietDonHang> ChiTietDonHangs { get; set; }

        public virtual DbSet<GioHang> GioHangs { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Rubik>()
                .Property(e => e.gia)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Rubik>()
                .Property(e => e.hinh)
                .IsUnicode(false);
        }

       
    }
}
