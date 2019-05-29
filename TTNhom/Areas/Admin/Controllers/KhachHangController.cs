using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TTNhom.Models.EF;
namespace TTNhom.Areas.Admin.Controllers
{
    public class KhachHangController : Controller
    {
        // GET: Admin/KhachHang
        NuocHoaDbContext db = new NuocHoaDbContext();
        public ActionResult Index()
        {
            return View(db.KhachHangs.ToList());
        }
    }
}