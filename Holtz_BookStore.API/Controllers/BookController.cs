using Holtz_BookStore.API.Repositories;
using Holtz_BookStore.API.Repositories.Contracts;
using Holtz_BookStore.API.ViewModels;
using Holtz_BookStore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Holtz_BookStore.API.Controllers
{
    [RoutePrefix("Books")]
    public class BookController : Controller
    {
        private readonly IBookRepository _repo;
        public BookController()
        {
            _repo = new BookRepository();
        }

        [Route("List")]
        [HttpGet]
        public ActionResult Index()
        {
            return View(_repo.FindAll());
        }


        [Route("Create")]
        [HttpGet]
        public ViewResult Create()
        {
            var categories = _repo.FindAllCategories();
            var model = new CreateBookViewModel
            {
                Name = "",
                ISBN = "",
                CategoryId = 0,
                CategoryOptions = new SelectList(categories, "Id", "Name")
            };
            return View(model);
        }

        [Route("Create")]
        [HttpPost]
        public ViewResult Create(CreateBookViewModel book )
        {
            return View();
        }
    }
}