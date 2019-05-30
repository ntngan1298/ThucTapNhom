using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TTNhom.DAO;
using TTNhom.Models.EF;

namespace TTNhom.Areas.Admin.Controllers
{
    public class NhanVienController : Controller
    {
        // GET: Admin/NhanVien
        NuocHoaDbContext db = new NuocHoaDbContext();
        public ActionResult Index()
        {

            return View(db.NhanViens.ToList());
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(NhanVien nv)
        {
            if (ModelState.IsValid)
            {
                var dao = new NhanVienDao();
                long id = dao.Insert(nv);
                if (id>0)
                {
                    return RedirectToAction("Index", "NhanVien");
                }
                else
                {
                    ModelState.AddModelError("", "Thêm nhân viên không thành công");
                }
            }
            return View("Create");
        }

        public ActionResult Update()

      
    }
}