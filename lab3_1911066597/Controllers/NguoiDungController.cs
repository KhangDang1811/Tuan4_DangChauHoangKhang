using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using lab3_1911066597.Models;

namespace lab3_1911066597.Controllers
{
    public class NguoiDungController : Controller
    {
        // GET: NguoiDung
        RubikModel data = new RubikModel();
   
        [HttpGet]
        public ActionResult DangKy()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Dangky(FormCollection collection, KhachHang kh)
        {
            var hoten = collection["hoten"];
            var tendangnhap = collection["tendangnhap"];
            var matkhau = collection["matkhau"];
            var MatkhauXacNhan = collection["MatKhauXacNhan"];
            var email = collection["email"];
            var diachi = collection["diachi"];
            var dienthoai = collection["dienthoai"];
            /*var ngaysinh = String.Format("{0:MM/dd/yyyy}", collection["ngaysinh"]);*/
            if (String.IsNullOrEmpty(MatkhauXacNhan))
            {
                ViewData["NhapMKXN"] = "Phải nhập mật khẩu xác nhận!";
            }
            else
            {
                if (!matkhau.Equals(MatkhauXacNhan))
                {
                    ViewData["MatkhauGiongNhau"] = "Mật khẩu và mật khẩu xác nhận phải giống nhau";
                }
                else
                {
                    kh.hoten = hoten;
                    kh.tendangnhap = tendangnhap;
                    kh.matkhau = matkhau;
                    kh.email = email;
                    kh.diachi = diachi;
                    kh.dienthoai = dienthoai;
                    /* kh.ngaysinh - DateTime.Parse(ngaysinh); */
                    data.KhachHangs.Add(kh);
                    data.SaveChanges();
                    return RedirectToAction("DangNhap");
                }
            }
            return this.DangKy();
        }

        [HttpGet]
        public ActionResult DangNhap()
        {
            return View();
        }
            [HttpPost]
            public ActionResult DangNhap(FormCollection collection)
            {
                var tendangnhap = collection["tendangnhap"];
                var matkhau = collection["matkhau"];
                KhachHang kh = data.KhachHangs.SingleOrDefault(n => n.tendangnhap ==
         tendangnhap && n.matkhau == matkhau);
                if (kh != null)
                {
                    ViewBag.ThongBao = "Chúc mừng đăng nhập thành công";
                    Session["Taikhoan"] = kh;
                }
                else
                {
                    ViewBag.ThongBao = "Tên đăng nhập hoặc mật khẩu không đúng";
                }
                return RedirectToAction("Index", "Home");
            }
        }
}