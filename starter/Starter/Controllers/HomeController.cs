using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Starter.Models;

namespace Starter.Controllers
{
    public class HomeController : Controller
    {
        private readonly PersonRepository _personRepo;

        public HomeController()
        {
            _personRepo = new PersonRepository();
        }

        public ActionResult Index()
        {
            var list = _personRepo.GetAll();
            return View(list);
        }

        public ActionResult Add()
        {
            return View("Edit", new KeyValuePair<string, Person>("", new Person()));
        }

        [HttpPost]
        public ActionResult Save(string key, Person value)
        {
            _personRepo.Save(new KeyValuePair<string, Person>(key, value));
            return RedirectToAction("Index");
        }

        public ActionResult Edit(string id)
        {
            var person = _personRepo.GetPersonByKey(id);
            return View("Edit", person);
        }

        public ActionResult Delete(string id)
        {
            _personRepo.Delete(id);
            return RedirectToAction("Index");
        }
    }
}