using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ErrorReport.Models
{
    public class Report
    {
        [Key]
        public long Id { get; set; }
        public string Reporter { get; set; }
        public string Manufacturer { get; set; }
        public string SerialNumber { get; set; }
        public string Description { get; set; }
        public DateTime DateAndTime { get; set; }

        public Report(string reporter, string manufacturer,string serialNumber, string description)
        {
            this.Reporter = reporter;
            this.Manufacturer = manufacturer;
            this.SerialNumber = serialNumber;
            this.Description = description;
            this.DateAndTime = DateTime.Now;
        }
    }
}
