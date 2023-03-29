using System;
using System.Collections.Generic;

#nullable disable

namespace CazhOn.Domain.Models
{
    public partial class StgTblstorecampaign
    {
        public long StgTblstorecampaignId { get; set; }
        public string StoreName { get; set; }
        public string StoreMdid { get; set; }
        public string StoreMdname { get; set; }
        public string StoreType { get; set; }
        public string Category { get; set; }
        public string BaseUrl { get; set; }
        public string AffiliateUrl { get; set; }
        public string LogoLargeUrl { get; set; }
        public string LogoMediumUrl { get; set; }
        public string LogoSmallUrl { get; set; }
        public decimal? CommPayout { get; set; }
        public string CommCalcType { get; set; }
        public string CommCalcTypeLkupmdid { get; set; }
        public string CommType { get; set; }
        public string CommTypeLkupmdid { get; set; }
        public string VendorNameLkupmdid { get; set; }
        public string CampaignTerms { get; set; }
        public DateTime Createddatetime { get; set; }
        public DateTime Createddatetimeutc { get; set; }
    }
}
