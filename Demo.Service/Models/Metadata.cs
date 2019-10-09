using System;
using System.Collections.Generic;

namespace Demo.Service.Models
{
    public partial class Metadata
    {
        public string Voyno { get; set; }
        public string Doctype { get; set; }
        public string Docname { get; set; }
        public string Isdocnumreq { get; set; }
        public string Isdocissuedate { get; set; }
        public string Isdocexpdtreq { get; set; }
        public string Isdocissuecntryreq { get; set; }
        public string IsDocallowedinForeign { get; set; }
        public string Docvalidityreq { get; set; }
        public string Homeportcntry { get; set; }
        public string QuestionNo { get; set; }
        public string Question { get; set; }
        public string QuestionType { get; set; }
        public string IsHealthQuestionsReq { get; set; }
        public string IsNonVisaWaiverAllowed { get; set; }
        public string IsPassportReceiptReq { get; set; }
        public string IsPregQuestionsReq { get; set; }
        public string IsPlaceBirth { get; set; }
        public string AgeMinor { get; set; }
        public string IsB1b2visaCheckin { get; set; }
        public string IsAutoDeleteManifest { get; set; }
        public string IsRetryRfidlift { get; set; }
        public string OfflineTimeout { get; set; }
        public string CntryCode { get; set; }
        public string CntryName { get; set; }
        public string IsVisaWaiver { get; set; }
    }
}
