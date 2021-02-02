using ApplicationCore.Interfaces;
using ApplicationCore.Logger;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Serilog;
using SerilogDemo.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SerilogDemo.Controllers
{
    public class HomeController : Controller
    {
        private ILoggerAdapter _loggerAdapter;
        public readonly IConfiguration _configuration;
        public HomeController(IConfiguration configuratio, ILoggerAdapter loggerAdapter)
        {
            _configuration = configuratio;
            _loggerAdapter = loggerAdapter;
        }

        public IActionResult Index()
        {
            _loggerAdapter.Debug("Logs Debug");
            _loggerAdapter.Information("Logs Information");
            _loggerAdapter.Warning("Logs Warning");
            _loggerAdapter.Error("Logs Error");
            _loggerAdapter.Fatal("Logs Fatal");
            _loggerAdapter.WriteMethodInfo("WriteMethodInfo");

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
