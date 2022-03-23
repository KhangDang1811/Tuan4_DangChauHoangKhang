namespace lab3_1911066597.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Linq;
    using System.Web.Mvc;

    [Table("Rubik")]
    public partial class Rubik
    {
        public int id { get; set; }

        public int? maloai { get; set; }

        [Required]
        [StringLength(100)]
        public string ten { get; set; }

        public string mota { get; set; }

        [StringLength(50)]
        public string hang { get; set; }

        public decimal? gia { get; set; }

        [StringLength(50)]
        public string hinh { get; set; }

        public int? soluongton { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? ngaycapnhat { get; set; }
        public Loai Loai { get; set; }



        public static List<Rubik> GetAll()
        {
            RubikModel context = new RubikModel();
            return context.Rubiks.ToList();
        }

        public void Insert()
        {
            RubikModel context = new RubikModel();
            try
            {
                context.Rubiks.Add(this);
                context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

       public static Rubik FindRubikByID(int id)
        {
            RubikModel context = new RubikModel();
            return context.Rubiks.FirstOrDefault(p => p.id == id);
        }

        public void Update()
        {
            RubikModel context = new RubikModel();
            try
            {
                Rubik find = context.Rubiks.FirstOrDefault(p => p.id == id);
                if (find != null)
                {
                    find.ten = this.ten;
                    find.mota = this.mota;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void DeleteRubik()
        {
            RubikModel context = new RubikModel();
            Rubik rubik = context.Rubiks.FirstOrDefault(p => p.id == id);
            context.Rubiks.Remove(rubik);
            context.SaveChanges();
        }
    }
}
