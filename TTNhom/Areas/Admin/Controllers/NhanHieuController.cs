using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TTNhom.Areas.Admin.Models;
using TTNhom.Models.EF;
namespace TTNhom.Areas.Admin.Controllers
{
    public class NhanHieuController : Controller
    {
        // GET: Admin/NhanHieu
        public ActionResult Index()
        {
            var iplNH = new NhanHieuModel();
            var model = iplNH.ListAll();
            return View(model);
        }

        // GET: Admin/NhanHieu/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Admin/NhanHieu/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/NhanHieu/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/NhanHieu/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Admin/NhanHieu/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/NhanHieu/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Admin/NhanHieu/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
