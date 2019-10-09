using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.Service.Contracts
{
    public class LoginResponse
    {
        [JsonProperty("access_token")]
        public string Access_token { get; set; }

        [JsonProperty("token_type")]
        public string Token_type { get; set; }

        [JsonProperty("expires_in")]
        public int Expires_in { get; set; }

        [JsonProperty("userName")]
        public string UserName { get; set; }

        [JsonProperty("roles")]
        public string Roles { get; set; }

        [JsonProperty("initialPasswordChanged")]
        public string InitialPasswordChanged { get; set; }

        [JsonProperty("__invalid_name__.issued")]
        public string invalidnameissued { get; set; }

        [JsonProperty("__invalid_name__.expires ")]
        public string invalidnameexpires { get; set; }
    }
}
