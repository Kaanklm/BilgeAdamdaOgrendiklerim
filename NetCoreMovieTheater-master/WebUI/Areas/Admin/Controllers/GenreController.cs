using DataAccess.Context;
using DataAccess.Entity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Service.Interface;
using Service.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles ="Administrator",Policy =null)]
    public class GenreController : Controller
    {
        private readonly IRepository<Genre> genreRepository;

        public GenreController(IRepository<Genre> _genreRepository)
        {
            genreRepository = _genreRepository;
        }

        public IActionResult Index()
        {
            return View(genreRepository.GetAll());
        }

        public IActionResult PostGenre()
        {


            return View();

        }
        [HttpPost]
        public IActionResult PostGenre(Genre genre)
        {
            genreRepository.Create(genre);
            

            return RedirectToAction("Index");
         

        }

    }
}
