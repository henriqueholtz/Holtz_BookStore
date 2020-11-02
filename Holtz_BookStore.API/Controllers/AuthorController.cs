using Holtz_BookStore.API.Repositories;
using Holtz_BookStore.API.Repositories.Contracts;
using Holtz_BookStore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Holtz_BookStore.API.Controllers
{
    public class AuthorController : Controller
    {
        private IAuthorRepository repository;
        public AuthorController()
        {
            repository = new AuthorRepository();
        }

        [Route("list")]
        //[LogActionFilter()]
        public ActionResult Index()
        {
            return View(repository.Get());
        }

        [HttpGet]
        public ViewResult Create()
        {
            return View();
        }

        [HttpPost]
        public ViewResult Create(Author author)
        {
            if (repository.Create(author))
                RedirectToAction(nameof(Index));

            return View();
        }


        [HttpGet]
        [Route("remove/{id:int}")]
        public ViewResult Edit(int id)
        {
            return View(repository.Get(id));
        }

        [HttpPost]
        public ViewResult Edit(Author author)
        {
            repository.Update(author);
            RedirectToAction(nameof(Index));
            return View();
        }


        [HttpGet]
        [Route("remove/{id:int}")]
        public ViewResult Delete(int id)
        {
            return View(repository.Get(id));
        }

        [HttpPost]
        [Route("remove/{id:int}")]
        [ActionName("Delete")]
        public ViewResult DeleteConfirm(int id)
        {
            if (repository.Delete(id))
                RedirectToAction(nameof(Index));

            RedirectToAction(nameof(Index));
            return View();
        }
    }
}