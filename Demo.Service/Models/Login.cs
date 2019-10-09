using System;
using System.Collections.Generic;

namespace Demo.Service.Models
{
    public partial class Login
    {
        public string AgentId { get; set; }
        public string Password { get; set; }
        public string DeviceId { get; set; }
        public string LocationCode { get; set; }
        public string UtcDatetime { get; set; }
    }
}
