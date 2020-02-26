using ErrorReport.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ErrorReport.Interfaces
{
    public interface IReportService
    {
        List<string> Names { get; set; }
        void AddNewReport(string reporter, string manufacturer, string serialNumber, string description);
        List<Report> GetAllReports();
        bool DoesReportExist(string Name);
        bool IsCompleted(string secret);
        Report GetReportById(long id);
        void DeleteReportById(long id);
        List<Report> GetReportsByManufacturer(string manufacturer);
        List<Report> GetReportsByReporter(string reporter);

    }
}
