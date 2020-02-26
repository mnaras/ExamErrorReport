using ErrorReport.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ErrorReport.Interfaces;

namespace ErrorReport.Services
{
    public class ReportService : IReportService
    {
        private readonly ApplicationContext applicationContext;
        public List<string> Names { get; set; }

        public ReportService(ApplicationContext applicationContext)
        {
            this.applicationContext = applicationContext;
            Names = new List<string>() { "Egg", "Martin", "John", "Deny" };
        }

        public void AddNewReport(string reporter, string manufacturer, string serialNumber, string description)
        {
            var report = new Report(reporter, manufacturer, serialNumber, description);
            applicationContext.Reports.Add(report);
            applicationContext.SaveChanges();
        }

        public List<Report> GetAllReports()
        {
            var reportList = applicationContext.Reports.ToList();
            return reportList;
        }

        public bool DoesReportExist(string Name)
        {
            var exist = Names.Contains(Name);
            return exist;
        }

        public bool IsCompleted(string secret)
        {
            var completed = secret.Equals("voala");
            return completed;
        }

        public Report GetReportById(long id)
        {
            var report = applicationContext.Reports.FirstOrDefault(r => r.Id == id);
            return report;
        }

        public void DeleteReportById(long id)
        {
            var report = GetReportById(id);
            applicationContext.Reports.Remove(report);
            applicationContext.SaveChanges();
        }

        public List<Report> GetReportsByManufacturer(string manufacturer)
        {
            var reportList = applicationContext.Reports.Where(r => r.Manufacturer == manufacturer).ToList();
            return reportList;
        }

        public List<Report> GetReportsByReporter(string reporter)
        {
            var reportList = applicationContext.Reports.Where(r => r.Reporter == reporter).ToList();
            return reportList;
        }
    }
}
