using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Task.Data.Models;
using Task.Data.Services;

namespace Task.Web.Controllers
{
    public class UsersController : Controller
    {
        private readonly IUserData db;

        public UsersController(IUserData db)
        {
            this.db = db;
        }


        [HttpGet]
        // GET: Restaurants
        public ActionResult Index()
        {
            var model = db.GetAll();
            return View(model);
        }

        [HttpGet]
        public ActionResult Details(int id)
        {
            var model = db.Get(id);
            if (model == null)
            {
                return RedirectToAction("Index");
            }
            return View(model);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(User user)
        { 
            if (ModelState.IsValid)
            {
                db.Add(user);
                return RedirectToAction("Details", new { id = user.Id });
            }
            return View();
        }

        [HttpGet]
        
        public ActionResult Edit(int id)
        {
            var model = db.Get(id);
            if (model == null)
            {
                return HttpNotFound();
            }
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(User user)
        {
            if (ModelState.IsValid)
            {
                db.Update(user);
                return RedirectToAction("Details", new { id = user.Id });
            }
            return View(user);
        }

    }
}