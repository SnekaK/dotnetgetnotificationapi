using System;
using System.Collections.Generic;

#nullable disable

namespace CazhOn.Domain.Models
{
    public partial class Affiliatellink
    {
        public long Affiliatellinkid { get; set; }
        public string Amount { get; set; }
        public string Commission { get; set; }
        public string Subid { get; set; }
        public string Tid { get; set; }
        public string Vendor { get; set; }
        public DateTime? Createddate { get; set; }
        public DateTime? Updateddate { get; set; }
    }
}
