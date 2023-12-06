using System.Diagnostics;
using Jisa.Models;
using Microsoft.AspNetCore.Mvc;

namespace Jisa.Controllers
{

    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public UserDAL da=new UserDAL();    

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
       public IActionResult Login(User us)
        {
            int result = da.Validation(us);
            if (result > 0)
            {
                ViewBag.Message = " Login Successfully";
            }
            else
            {
                ViewBag.Message = " Login Fail";
            }
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