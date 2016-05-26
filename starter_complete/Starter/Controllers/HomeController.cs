using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Starter.Models;

namespace Starter.Controllers
{
    public class HomeController : Controller
    {
        private readonly ProfileRepository _profileRepo;

        public HomeController()
        {
            _profileRepo = new ProfileRepository();
        }

        public ActionResult Index()
        {
            var list = _profileRepo.GetAll();
            return View(list);
        }

        public ActionResult Add()
        {
            return View("Edit", new KeyValuePair<string, Profile>("", new Profile()));
        }

        [HttpPost]
        public ActionResult Save(string key, Profile value)
        {
            _profileRepo.Save(new KeyValuePair<string, Profile>(key, value));
            return RedirectToAction("Index");
        }

        public ActionResult Edit(string id)
        {
            var profile = _profileRepo.GetProfileByKey(id);
            return View("Edit", profile);
        }

        public ActionResult Delete(string id)
        {
            _profileRepo.Delete(id);
            return RedirectToAction("Index");
        }
    }
}