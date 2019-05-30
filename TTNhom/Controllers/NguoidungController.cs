using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TTNhom.Models.EF;
namespace TTNhom.Controllers
{
    public class NguoidungController : Controller
    {
        NuocHoaDbContext db = new NuocHoaDbContext();
        // GET: Nguoidung
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult DangNhap()
        {
            return View();
        }
        [HttpPost]
        public ActionResult DangNhap(FormCollection f)
        {
            string sTaikhoan = f["txtName"].ToString();
            string sMK = f["txtPwd"].ToString();
            TaiKhoan tk = db.TaiKhoans.SingleOrDefault(x => x.userName == sTaikhoan && x.password == sMK);
            if (tk != null)
            {
                ViewBag.ThongBao = "Dang nhap thanh cong";
                Session["Taikhoan"] = tk;
                return View();
            }

            
                ViewBag.ThongBao = "Tai khoan hoac mat khau k dung";
                return View();
            
         }
    }
}