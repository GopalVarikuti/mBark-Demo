using System;
using System.Collections.Generic;

namespace Demo.Service.Models
{
    public partial class Metadata
    {
        public string ShipCode { get; set; }
        public string Voyno { get; set; }
        public string DocType { get; set; }
        public string DocName { get; set; }
        public string IsDocNumReq { get; set; }
        public string IsDocIssueDate { get; set; }
        public string IsDocExpdtReq { get; set; }
        public string IsDocIssueCntryReq { get; set; }
        public string IsDocAllowedInForeign { get; set; }
        public string DocValidityReq { get; set; }
        public string HomeportCntry { get; set; }
        public string QuestionNo { get; set; }
        public string Question { get; set; }
        public string QuestionType { get; set; }
        public string IsHealthQuestionsReq { get; set; }
        public string IsNonVisaWaiverAllowed { get; set; }
        public string IsPassportReceiptReq { get; set; }
        public string IsPregQuestionsReq { get; set; }
        public string IsPlaceBirth { get; set; }
        public string Ageminor { get; set; }
        public string CntryCode { get; set; }
        public string CntryName { get; set; }
        public string IsVisaWaiver { get; set; }
        public string IsB1b2visaCheckIn { get; set; }
        public string IsAutoDeleteManifest { get; set; }
        public string IsRetryRfidlift { get; set; }
        public string OfflineTimeout { get; set; }
        public string BookingNo { get; set; }
    }
}
