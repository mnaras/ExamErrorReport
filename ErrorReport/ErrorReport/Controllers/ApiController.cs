using ErrorReport.Models;
using ErrorReport.Services;
using Microsoft.AspNetCore.Mvc;

namespace ErrorReport.Controllers
{
    [Route("api")]
    [ApiController]
    public class ApiController : ControllerBase
    {
        private readonly ReportService rService;
        public ApiController(ReportService RService)
        {
            this.rService = RService;
        }

        [Route("/report")]
        [HttpPost]
        public IActionResult Report([FromBody] Json data)
        {
            if (rService.DoesReportExist(data.Reporter))
            {
                rService.AddNewReport(data.Reporter, data.Manufacturer, data.SerialNumber, data.Description);
                return RedirectToAction("List");
            }
            else
            {
                return StatusCode(403, new { info = "The given reporter does not exist!" });
            }
        }

        [Route("/complete/{id}")]
        [HttpGet]
        public IActionResult Complete(long id, [FromBody] Json data)
        {
            if (rService.GetReportById(id) == null)
            {
                return StatusCode(403, new { inf = "The given Id does not exist!" });
            }
            else if (rService.IsCompleted(data.Secret))
            {
                rService.DeleteReportById(id);
                return Ok(new { info = "The given report has been deleted / completed!" });
            }
            else
            {
                return StatusCode(403, new { info = "The given report cannot be deleted / completed!"});
            }
        }

        [Route("list/query")]
        [HttpGet]
        public IActionResult Query(string reporter, string manufacturer)
        {
            if (reporter == null && manufacturer == null)
            {
                return NotFound();
            }
            else if (reporter == null)
            {
                var reportList = rService.GetReportsByManufacturer(manufacturer);
                return Ok(new { result = "ok", tickets = reportList });
            }
            else
            {
                var reportList = rService.GetReportsByReporter(reporter);
                return Ok(new { result = "ok", tickets = reportList });
            }
        }
    }
}