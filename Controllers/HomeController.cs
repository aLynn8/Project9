using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Project3.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

//Aubrey Farnbach (Wright) Section 2 Group 1

namespace Project3.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private IMovieListRepository _repository;

        public HomeController(ILogger<HomeController> logger, IMovieListRepository repository)
        {
            _logger = logger;
            _repository = repository;
        }

        //Returns Index
        public IActionResult Index()
        {
            return View(_repository.ApplicationResponses);
        }

        //Returns movie list from temp storage within MyMovies view
        public IActionResult MyMovies()
        {
            return View(TempStorage.Applications);
        }

        //Returns MyPodcasts view
        public IActionResult MyPodcasts()
        {
            return View();
        }

        //Returns AdMovies view on a Get requuest
        [HttpGet]
        public IActionResult AddMovies()
        {
            return View();
        }

        //Returns MovieConfirmation with the appResponse data from the form
        [HttpPost]
        public IActionResult AddMovies(ApplicationResponse appResponse)
        {
            TempStorage.AddApplication(appResponse);
            return View("MovieConfirmation", appResponse);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
