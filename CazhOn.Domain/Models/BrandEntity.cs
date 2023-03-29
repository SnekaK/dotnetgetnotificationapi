using System;
using System.Collections.Generic;

#nullable disable

namespace CazhOn.Domain.Models
{
    public partial class BrandEntity
    {
        public string StoreMdid { get; set; }
        public string CashBackDesc { get; set; }
        public string ImageName { get; set; }
        public string ImageUrl { get; set; }
        public string StoreMdname { get; set; }
        public string StoreName { get; set; }
        public string StorecampaignGuid { get; set; }
        public string TotalCoupons { get; set; }
        public string TotalOffers { get; set; }
    }
}
