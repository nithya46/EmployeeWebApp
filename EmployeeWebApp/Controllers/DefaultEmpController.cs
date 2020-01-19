using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmployeeWebApp.Controllers
{
    public class DefaultEmpController : Controller
    {
        // GET: DefaultEmp
        //public ActionResult Index()
        //{
        //    return View();
        //}
        public ActionResult Employee()
        {
            return View();
        }

        // GET: DefaultEmp/Details/5
        public ActionResult DetailsShowEmp(int id)
        {
            return View();
        }

        // GET: DefaultEmp/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        // POST: DefaultEmp/Create
        [HttpPost]
        public ActionResult CreateAddEmp(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Employee");
            }
            catch
            {
                return View();
            }
        }

        // GET: DefaultEmp/Edit/5
        public ActionResult EditUpdateEmp(int id)
        {
            return View();
        }

        // POST: DefaultEmp/Edit/5
        [HttpPost]
        public ActionResult EditUpdateEmp(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Employee");
            }
            catch
            {
                return View();
            }
        }

        // GET: DefaultEmp/Delete/5
        public ActionResult DeleteEmp(int id)
        {
            return View();
        }

        // POST: DefaultEmp/Delete/5
        [HttpPost]
        public ActionResult DeleteEmp(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Employee");
            }
            catch
            {
                return View();
            }
        }
    }
}
