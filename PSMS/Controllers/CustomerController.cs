using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PSMS.Controllers
{
    public class CustomerController : BaseController
    {
        // GET: Customer
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            ViewBag.Title = "Create Customer";
            ViewBag.SubmitButtonText = "Create";
            return View();
        }

        public ActionResult Edit(long id)
        {
            ViewBag.Title = "Update Customer";
            ViewBag.SubmitButtonText = "Update";
            return View("Create");
        }
    }
}