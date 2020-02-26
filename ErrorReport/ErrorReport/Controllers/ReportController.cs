using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ErrorReport.Services;
using Microsoft.AspNetCore.Mvc;

namespace ErrorReport.Controllers
{
    [Route("/")]
    public class ReportController : Controller
    {
        private readonly ReportService rService;

        public ReportController(ReportService rService)
        {
            this.rService = rService;
        }

        [Route("/")]
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Names = rService.Names;
            return View();
        }

        [Route("/")]
        [HttpPost]
        public IActionResult Index(string reporter, string manufacturer, string serialNumber, string description)
        {
            rService.AddNewReport(reporter, manufacturer, serialNumber, description);
            return RedirectToAction("Index");
        }

        [Route("/list")]
        [HttpGet]
        public IActionResult List()
        {
            var reportList = rService.GetAllReports();
            return View(reportList);
        }
    }
}