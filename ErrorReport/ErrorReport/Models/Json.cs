using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ErrorReport.Models
{
    public class Json
    {
        [JsonProperty("reporter")]
        public string Reporter { get; set; }

        [JsonProperty("manufacturer")]
        public string Manufacturer { get; set; }

        [JsonProperty("serialNumber")]
        public string SerialNumber { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("secret")]
        public string Secret { get; set; }
    }
}
