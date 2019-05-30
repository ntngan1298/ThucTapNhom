using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TTNhom.Models.EF;
using TTNhom.DAO;
namespace TTNhom.Areas.Admin.Controllers
{
    public class TaiKhoanController : Controller
    {
        // GET: Admin/TaiKhoan
        NuocHoaDbContext db = new NuocHoaDbContext();
        public ActionResult Index()
        {
            return View(db.TaiKhoans.ToList());
        }
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create( TaiKhoan tk)
        {
            if (ModelState.IsValid)
            {
                var dao = new UserDao();
                long id = dao.Insert(tk);
                if(db.TaiKhoans.Any(x=>x.userName== tk.userName))
                    {
                    ModelState.AddModelError("", "Tên tài khoản đã tồn tại");
                }
                else
                {
                    if (id > 0)
                    {
                        return RedirectToAction("Index", "TaiKhoan");
                    }
                    else
                    {
                        ModelState.AddModelError("ThongBao", "Thêm tài khoản quản trị không thành công");
                    }
                }
            }
            return View("Create");
        }

        public ActionResult Edit( int id)
        {
            var user = new UserDao().ViewDetail(id);
            return View(user);
        }

        [HttpPost]
        public ActionResult Edit ( TaiKhoan user)
        {
            if (ModelState.IsValid)
            {
                var dao = new UserDao();
                var res = dao.Update(user);
                if (res)
                {
                    return RedirectToAction("Index", "TaiKhoan");
                }
                else
                {
                    ModelState.AddModelError("", "Sửa dữ liệu không thành công");
                }
            }
            return View("Index");
        }

        [HttpDelete]
        public ActionResult Delete( int id)
        {
            var user = new UserDao().Delete(id);
            return RedirectToAction("Index");
        }
    }
}