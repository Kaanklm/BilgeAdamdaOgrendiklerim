using DataAccess.Entity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Administrator", Policy = null)]
    public class MovieController : Controller
    {
        private readonly IRepository<Movie> movieRepository;
        private readonly IMovieRepository movieRepo;

        public MovieController(IRepository<Movie> _movieRepository, IMovieRepository _movieRepo)
        {
            movieRepository = _movieRepository;
            movieRepo = _movieRepo;
        }
        public IActionResult Index()
        {
            
            return View(movieRepository.GetAll()) ;
        }
    }
}
