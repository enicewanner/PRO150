using Microsoft.AspNetCore.Mvc;
using PRO150.Models;
using PRO150.Interfaces;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows;



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


        public IActionResult GuesserScreen(string? hintMsg, string? hintedWords)
        {
            if (!String.IsNullOrEmpty(hintMsg) && !String.IsNullOrEmpty(hintedWords))
            {
                Card.hintMsg = hintMsg;
                Card.hintedWords = int.Parse(hintedWords);              
            }

            if(Card.isClicked)
            {
                  Console.Write("FUCK YES IT WORKED");       
            }

                

            
            
            return View();
        }


        public static object ColorChange(object sender)
        {
           Console.WriteLine(sender.GetType().Name);
            return sender;
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