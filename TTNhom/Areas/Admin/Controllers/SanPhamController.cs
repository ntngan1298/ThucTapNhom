using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TTNhom.DAO;
using TTNhom.Models.EF;
namespace TTNhom.Areas.Admin.Controllers
{
    public class SanPhamController : Controller
    {
        // GET: Admin/SanPham
        NuocHoaDbContext db = new NuocHoaDbContext();
        public ActionResult Index()
        {
            return View(db.SPs.ToList());
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create( SP sp)
        {
            if (ModelState.IsValid)
            {
                var dao = new SPDao();
                long id = dao.Insert(sp);
                if (id > 0)
                {
                    return RedirectToAction("Index","SanPham");
                }
                else
                {
                    ModelState.AddModelError("", "Thêm dữ diệu không thành công");
                }
            }
            return View("Create");
        }
    }
}