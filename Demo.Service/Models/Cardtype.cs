using System;
using System.Collections.Generic;

namespace Demo.Service.Models
{
    public partial class Cardtype
    {
        public string Cardid { get; set; }
        public string Type { get; set; }
        public string Displayname { get; set; }
        public string Voyno { get; set; }

        public virtual Metadata VoynoNavigation { get; set; }
    }
}
