using System;
using System.Web.Mvc;
using Starter.Models;

namespace Starter.Controllers
{
    public class HomeController : Controller
    {
        private readonly PersonRepository _personRepo;

        public HomeController(PersonRepository personRepo)
        {
            _personRepo = personRepo;
        }

        public ActionResult Index()
        {
            var list = _personRepo.GetAll();
            return View(list);
        }

        public ActionResult Add()
        {
            return View("Edit", new Person());
        }

        [HttpPost]
        public ActionResult Save(Person model)
        {
            _personRepo.Save(model);
            return RedirectToAction("Index");
        }

        public ActionResult Edit(Guid id)
        {
            var person = _personRepo.GetPersonByKey(id);
            return View("Edit", person);
        }

        public ActionResult Delete(Guid id)
        {
            _personRepo.Delete(id);
            return RedirectToAction("Index");
        }
    }
}