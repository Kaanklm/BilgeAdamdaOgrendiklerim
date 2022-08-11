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
    [Authorize(Roles = "Administrator", Policy = null)]
    public class SaloonController : Controller
    {
        private readonly IRepository<Saloon> saloonRepository;

        public SaloonController(IRepository<Saloon> _saloonRepository)
        {
            saloonRepository = _saloonRepository;
        }
        public IActionResult Index()
        {
            return View(saloonRepository.GetAll());
        }

        public IActionResult PostSaloon()
        {
            return View();
        }

        [HttpPost]
        public IActionResult PostSaloon(Saloon saloon)
        {
            saloonRepository.Create(saloon);
            return RedirectToAction("Index");

        }

        public IActionResult UpdateSaloon(int id)
        {
            //return View(saloonRepository.Where(x => x.Id == id).FirstOrDefault());
            return View();
        }


        [HttpPost]
        public IActionResult UpdateSaloon(Saloon saloon)
        {
            //saloonRepository.UpdateSaloon(saloon);
            //return RedirectToAction("Index");
            return View();

        }



        [HttpPost]
        public IActionResult DeleteSaloon(int id)
        {

            //saloonRepository.DeleteSaloon(id);

            //return RedirectToAction("Index");
            return View();

        }
    }
}
