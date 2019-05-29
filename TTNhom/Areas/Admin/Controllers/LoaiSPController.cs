using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TTNhom.Models.EF;
namespace TTNhom.Areas.Admin.Controllers
{
    public class LoaiSPController : Controller
    {
        // GET: Admin/LoaiSP
        NuocHoaDbContext db = new NuocHoaDbContext();
        public ActionResult Index()
        {
            return View(db.LoaiSPs.ToList());
        }
    }
}