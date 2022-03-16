using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tuan4_San.Models;

namespace Tuan4_San.Models
{
    public class GioHang
    {
        MyDataDataContext data = new MyDataDataContext(); 
        public int masach { get; set; }
        public string tensach { get; set; }
        public string hinh { get; set; }
        public Double giaban { get; set; }
        public int isoluong { get; set; }
        public Double dThanhtien
        {
            get { return isoluong * giaban; }
        }
        public GioHang(int id)
        {
            masach = id;
            Sach sach = data.Saches.Single(n => n.masach == masach);
            tensach = sach.tensach;
            hinh = sach.hinh;
            giaban = double.Parse(sach.giaban.ToString());
            isoluong = 1;
        }
    }
}