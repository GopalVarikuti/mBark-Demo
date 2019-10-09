using System;
using System.Collections.Generic;

namespace Demo.Service.Models
{
    public partial class Userslogin
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string GrantType { get; set; }
        public string ClientId { get; set; }
        public string ClientSecret { get; set; }
    }
}
