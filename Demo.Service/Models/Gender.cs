using System;
using System.Collections.Generic;

namespace Demo.Service.Models
{
    public partial class Gender
    {
        public string Gid { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string Voyno { get; set; }

        public virtual Metadata VoynoNavigation { get; set; }
    }
}
