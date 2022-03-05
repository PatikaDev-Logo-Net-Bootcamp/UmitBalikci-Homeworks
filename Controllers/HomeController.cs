using HomeworkOne.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace HomeworkOne.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult Sample()
        {
            var model = new UserViewModel();
            return View(model);
        }

        [HttpPost]
        public IActionResult Sample(UserViewModel model)
        {
            var result = new ResponseViewModel();

            if (!ModelState.IsValid)
            {

                result.Data = null;
                result.Succes = false;
                result.Error = "Hatalı giriş işlemi.";


                
                return View();
            }

            result.Data = "Başarılı Giriş";
            result.Succes = true;
            result.Error = null;


            return Ok(result);
            //return View();

        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
