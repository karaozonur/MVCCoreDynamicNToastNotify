using Microsoft.AspNetCore.Mvc;
using MVCCoreNToastNotify.Models;
using NToastNotify;
using System.Diagnostics;

namespace MVCCoreNToastNotify.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IToastNotification _notification;  
        public HomeController(ILogger<HomeController> logger,IToastNotification toastNotification)
        {
            _logger = logger;
            _notification = toastNotification;
        }

        public IActionResult Index()
        {
            _notification.AddSuccessToastMessage(message:"Merhaba Dünya la");
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