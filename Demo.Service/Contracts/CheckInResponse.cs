using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Demo.Service.Contracts
{

     public class CheckInResponse
    {
        [JsonProperty("errors")]
        public List<CheckInRequest> Errors { get; set; }

        [JsonProperty("warnings")]
        public List<CheckInRequest> Warnings { get; set; }

        [JsonProperty("Success")]
        public bool Success { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("timeInMillis")]
        public long TimeInMillis { get; set; }

        [JsonProperty("HttpStatusCode")]
        public HttpStatusCode HttpStatusCode { get; set; }       
    }
}
