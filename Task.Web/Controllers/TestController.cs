using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Task.Web.Models;

namespace Task.Web.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index(string name)
        {
            var model = new TestViewModel();
            model.Name = name ?? "no name";
            model.Message = ConfigurationManager.AppSettings["message"];
            return View(model);
        }
    }
}