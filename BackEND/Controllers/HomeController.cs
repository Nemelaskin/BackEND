using BackEND.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using BackEND.Data.Query;
using System.Data;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading;
using BackEND.Socket;

namespace BackEND.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        private static void func()
        {
            //CreateSocketToDrone css = new CreateSocketToDrone();
            VideoSocketManager SM = new VideoSocketManager();


        }
        public string Index()
        {
            
            return "Home page";
        }

        public IActionResult Privacy()
        {
            Thread myThread = new Thread(func);
            myThread.Start();

            return View();
        }
        
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
