using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using Practical.Helper;
using Practical.Models;
using Practical.Services;
using static Practical.Helper.EnumsCollection;

namespace Practical.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ICalculationServices calculationServices;
        private readonly IHtmlHelper ihtmlhelper;

        public HomeController(ILogger<HomeController> logger,
            ICalculationServices calculationServices, IHtmlHelper ihtmlhelper)
        {
            _logger = logger;
            this.calculationServices = calculationServices;
            this.ihtmlhelper = ihtmlhelper;
        }

        public IActionResult Index()
        {
            var CalculationType = ihtmlhelper.GetEnumSelectList<MethodType>();
            ViewBag.CalculationType = CalculationType;
            return View();
        }
        [HttpPost]
        public IActionResult Index(Calculation calculation)
        {
            if (ModelState.IsValid)
            {
                var result = calculationServices.calculation(calculation);
                _logger.LogInformation(CommonHelper.logmessage(result));
                ViewBag.result = result.result;
            }

            var CalculationType = ihtmlhelper.GetEnumSelectList<MethodType>();
            ViewBag.CalculationType = CalculationType;
            return View();
        }

    }
}
