using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.Service.Contracts
{
    public class LoginResponse
    {
        [JsonProperty("position")]
        public string Position { get; set; }

        [JsonProperty("Role")]
        public string Role { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("timeInMillis")]
        public long TimeInMillis { get; set; }

        [JsonProperty("responseCode")]
        public string ResponseCode { get; set; }
    }
}
