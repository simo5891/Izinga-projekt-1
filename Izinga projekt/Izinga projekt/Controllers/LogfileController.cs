using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Izinga_projekt.Controllers
{
    public class LogfileController : Controller
    {
        // GET: Logfile
        public ActionResult Index()
        {
            return View();
        }

        // GET: Logfile/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Logfile/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Logfile/Create
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

        // GET: Logfile/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Logfile/Edit/5
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

        // GET: Logfile/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Logfile/Delete/5
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
