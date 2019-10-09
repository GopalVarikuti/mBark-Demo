using System;
using System.Collections.Generic;

namespace Demo.Service.Models
{
    public partial class Title
    {
        public string Tid { get; set; }
        public string Id { get; set; }
        public string Description { get; set; }
        public string Voyno { get; set; }

        public virtual Metadata VoynoNavigation { get; set; }
    }
}
