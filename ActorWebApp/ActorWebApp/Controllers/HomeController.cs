using ActorWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ActorWebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IActorRepository _actorRepository;

        public HomeController(ILogger<HomeController> logger, IActorRepository repo)
        {
            _logger = logger;
            _actorRepository = repo;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult List()
        {
            return View(_actorRepository.AllActors);
        }
    }
}
