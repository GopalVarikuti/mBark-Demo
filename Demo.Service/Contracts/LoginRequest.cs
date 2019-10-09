using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.Service.Contracts
{
    public class LoginRequest
    {
        public class RootObject
        {
            [JsonProperty("username")]
            public string Username { get; set; }

            [JsonProperty("password")]
            public string Password { get; set; }

            [JsonProperty("grant_type")]
            public string Grant_type { get; set; }

            [JsonProperty("client_id")]
            public string Client_id { get; set; }

            [JsonProperty("client_secret")]
            public string Client_secret { get; set; }
        }
    }
}
