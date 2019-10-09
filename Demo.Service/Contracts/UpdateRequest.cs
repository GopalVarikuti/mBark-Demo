using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.Service.Contracts
{
    public class UpdateRequest
    {
        [JsonProperty("booking")]
        public Booking booking { get; set; }
    }
    public class Booking
    {
        public CrediCard creditcardinfo { get; set; }

        [JsonProperty]
        public string voyno { get; set; }
        [JsonProperty]
        public string bookingno { get; set; }
        [JsonProperty]
        public string shipcode { get; set; }
        [JsonProperty]
        public string shipname { get; set; }
        [JsonProperty]
        public string embarkationdate { get; set; }
        [JsonProperty]
        public string debarkationdate { get; set; }
    }

    public class CrediCard
    {
        [JsonProperty]
        public string registeredcardid { get; set; }
        [JsonProperty]
        public string ccholdername { get; set; }
        [JsonProperty]
        public string ccmaskedno { get; set; }
        [JsonProperty]
        public string ccexpiry { get; set; }
        [JsonProperty]
        public string cctype { get; set; }
        [JsonProperty]
        public string currencycode { get; set; }
        [JsonProperty]
        public string cctoken { get; set; }
        [JsonProperty]
        public string ccissuedate { get; set; }
        [JsonProperty]
        public string iscctokenpresent { get; set; }
        [JsonProperty]
        public string preauthorisedToken { get; set; }

        public List<Guest> guestsmapped { get; set; }
    }

    public class Guest
    {
        public Personalinfo personalinfo { get; set; }
    }
    public class Personalinfo
    {
        [JsonProperty]
        public string seqno { get; set; }
        [JsonProperty]
        public string guestid { get; set; }
        [JsonProperty]
        public string folio { get; set; }
        [JsonProperty]
        public string plastname { get; set; }
        [JsonProperty]
        public string middlename { get; set; }
        [JsonProperty]
        public string firstname { get; set; }
        [JsonProperty]
        public string title { get; set; }
        [JsonProperty]
        public string gender { get; set; }
        [JsonProperty]
        public string loyalty { get; set; }
        [JsonProperty]
        public string isresponsible { get; set; }
        [JsonProperty]
        public string guesttype { get; set; }
        [JsonProperty]
        public string barcode { get; set; }
        [JsonProperty]
        public string cabin { get; set; }
        [JsonProperty]
        public string musterstation { get; set; }
    }
}
