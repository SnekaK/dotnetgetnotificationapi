
using System;
using System.Collections.Generic;
using System.Text;

namespace CazhOn.Domain.Models
{
    public class RawTblGlobalPostBack
    {
        public Int64 Rawlobalpostbackid { get; set; }
        public string Transactionid { get; set; }
        public string Advertisername { get; set; }
        public string Transactiondate { get; set; }
        public string Transactiontime { get; set; }
        public string Saleamount { get; set; }
        public string Commission { get; set; }
        public string Ipaddress { get; set; }
        public string status { get; set; }
        public string Subid { get; set; }
        public string Source { get; set; }
        public string Vendor { get; set; }
        public DateTime? Createddate { get; set; }
        public DateTime? Updateddate { get; set; }
        public int? CashBackStatusId { get; set; }
        public DateTime? JobRunDatetime { get; set; }
        public string ExternalId { get; set; }
        public string ExternalClickId { get; set; }
        public string ExternalReferalUrl { get; set; }
        public DateTime? ExternalUpdatedate { get; set; }

    }
}
