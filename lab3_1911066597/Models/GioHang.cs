using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace lab3_1911066597.Models
{
    public class GioHang
    {
        RubikModel data = new RubikModel();
        [Key]
        public int maloai { get; set; }
        [Display(Name = "Tên sách")]
        public string ten { get; set; }
        [Display(Name = "Ảnh bìa")]
        public string hinh { get; set; }
        [Display(Name = "Giá bán")]
        public Double gia { get; set; }
        [Display(Name = "Số lượng")]
        public int soluong { get; set; }
        [Display(Name = "Thành tiền")]
        public Double Thanhtien
        {
            get { return soluong * gia; }
        }
        public GioHang(int id)
        {
            maloai = id;
            Rubik rubik = data.Rubiks.Single(n => n.id == maloai);
            hinh = rubik.hinh;
            ten = rubik.ten;
            gia = double.Parse(rubik.gia.ToString());
            soluong = 1;


        }
    }
}