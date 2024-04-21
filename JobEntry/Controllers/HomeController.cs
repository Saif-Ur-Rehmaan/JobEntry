using System.Diagnostics;
using JobEntry.Models;
using Microsoft.AspNetCore.Mvc;

namespace JobEntry.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
 

        [Route("/")]
        [Route("/Index")]
        public IActionResult Index()
        {
            return View();
        }
        [Route("/login")]
        public IActionResult Login()
        {
            return View();
        }
        [Route("/Register")]
        public IActionResult Register()
        {
            return View();
        }

        [Route("/404")]
        public IActionResult NotFound404()
        {
            return View("404");
        }
        
        [Route("/about")]
        public IActionResult About()
        {
            return View();
        }

        [Route("/category")]
        public IActionResult Category()
        {
            return View();
        }

        [Route("/contact")]
        public IActionResult Contact()
        {
            return View();
        }
        [Route("/job-detail")]
        public IActionResult Jobdetail()
        {
            return View();
        }
        [Route("/job-list")]
        public IActionResult Joblist()
        {
            return View();
        }
        [Route("/testimonial")]
        public IActionResult Testimonial()
        {
            return View();
        }
    }
}
