using System;
using System.Collections.Generic;

namespace Demo.Service.Models
{
    public partial class Document
    {
        public string Docid { get; set; }
        public string Doctype { get; set; }
        public string Docname { get; set; }
        public string Docnote { get; set; }
        public string Isdocnumreq { get; set; }
        public string Isdocissuedate { get; set; }
        public string Isdocexpdtreq { get; set; }
        public string Isdocissuecntryreq { get; set; }
        public string Isdocallowedinforeign { get; set; }
        public string Isdocvalidityreq { get; set; }
        public string Docexpirytolerancedays { get; set; }
        public string Docexpirymessage { get; set; }
        public string Docexpiryyears { get; set; }
        public string Voyno { get; set; }

        public virtual Metadata VoynoNavigation { get; set; }
    }
}
