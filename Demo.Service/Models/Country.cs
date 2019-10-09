using System;
using System.Collections.Generic;

namespace Demo.Service.Models
{
    public partial class Country
    {
        public string Cntryid { get; set; }
        public string Cntrycode { get; set; }
        public string Cntryname { get; set; }
        public string Voyno { get; set; }

        public virtual Metadata VoynoNavigation { get; set; }
    }
}
