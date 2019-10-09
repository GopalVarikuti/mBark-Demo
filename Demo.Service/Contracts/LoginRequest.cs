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
        [Required]
        [JsonProperty("password")]
        public string Password { get; set; }

        [Required]
        [JsonProperty("agentId")]
        public string AgentId { get; set; }

        [Required]
        [JsonProperty("deviceId")]
        public string DeviceId { get; set; }

        [Required]
        [JsonProperty("locationCode")]
        public string LocationCode { get; set; }

        [Required]
        [JsonProperty("utcDatetime")]
        public string UtcDatetime { get; set; }
    }
}
