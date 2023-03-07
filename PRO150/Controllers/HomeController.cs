using Microsoft.AspNetCore.Mvc;
using PRO150.Models;
using PRO150.Interfaces;
using System.Diagnostics;

namespace PRO150.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        IDataAccessLayer dal;


        public HomeController(ILogger<HomeController> logger, IDataAccessLayer indal)
        {
            _logger = logger;
            dal = indal;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GuesserScreen(string hintMsg, string hintedWords)
        {
            ViewBag.hintMsg = hintMsg;
            ViewBag.hintedWords = int.Parse(hintedWords);
            
            return View();
        }


        public IActionResult SpyMasterScreen()
        {
            return View();
        }


        public IActionResult RulePage()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(User user)
        {
            if(dal.UserExists(user))
            {
                return RedirectToAction("Profile", user);
            }
            else if(!dal.UserExists(user) && ModelState.IsValid)
            {
                dal.AddUser(user);
                TempData["success"] = "User Created";
                return RedirectToAction("Profile", user);
            }
            else
            {
                return View();
            }
        }

        public IActionResult Logout()
        {
            return RedirectToAction("Login");
        }

        public IActionResult Profile(User user)
        {
            if(user.Username == null)
            {
                TempData["Error"] = "Please make an account to see stats";
                return View(user);
            }
            return View(user);
        }

        public IActionResult GuesserTran()
        {
            return View();
        }

        public IActionResult SpymasterTran()
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