using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.Service.Contracts
{
    public class CheckInRequest
    {
        public Passenger passenger { get; set; }
        public string shipId { get; set; }
        public string agentName { get; set; }
        public string deviceID { get; set; }
        public string requestId { get; set; }
    }
    public class Passenger
    {
        //public int Id { get; set; }
        public string authNo { get; set; }
        public string barcode { get; set; }
        public string cabinCategory { get; set; }
        public string ccExpiry { get; set; }
        public string ccHolderName { get; set; }
        public string ccType { get; set; }
        public string checkInStatus { get; set; }
        public string checkInWindow { get; set; }
        public string chkInDateTime { get; set; }
        public string nationality { get; set; }
        public string bookingNo { get; set; }
        public string dateOfBirth { get; set; }
        public string departTime { get; set; }
        public string docType { get; set; }
        public string embarkationDate { get; set; }
        public string flagStatus { get; set; }
        public string folio { get; set; }
        public string gender { get; set; }
        public string guestStatus { get; set; }
        public string isOLC { get; set; }
        public string loyalty { get; set; }
        public string musterStation { get; set; }
        public string docExpiryDate { get; set; }
        public string firstName { get; set; }
        public string docIssueCountry { get; set; }
        public string lastName { get; set; }
        public string docNumber { get; set; }
        public string guestId { get; set; }
        public string guestType { get; set; }
        public int processingStatus { get; set; }
        public string purposeOfVisit { get; set; }
        public string requestedBy { get; set; }
        public string requestorName { get; set; }
        public string stateRoom { get; set; }
        public int rowId { get; set; }
        public string sailDate { get; set; }
        public string seqNo { get; set; }
        public string shipCode { get; set; }
        public string voyNo { get; set; }
        public string shipName { get; set; }
        public string title { get; set; }
        public string zone { get; set; }
    }

   
}
