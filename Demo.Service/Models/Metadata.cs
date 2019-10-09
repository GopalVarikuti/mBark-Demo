using System;
using System.Collections.Generic;

namespace Demo.Service.Models
{
    public partial class Metadata
    {
        public Metadata()
        {
            Cardtype = new HashSet<Cardtype>();
            Country = new HashSet<Country>();
            Document = new HashSet<Document>();
            Gender = new HashSet<Gender>();
            Title = new HashSet<Title>();
        }

        public string Voyno { get; set; }
        public string Shipcode { get; set; }
        public string Shipname { get; set; }
        public string Embarkationdate { get; set; }
        public string Debarkationdate { get; set; }
        public string Cruisecontract { get; set; }
        public string Url { get; set; }
        public string Text { get; set; }
        public string Vurl { get; set; }
        public string Currencycode { get; set; }
        public string Cardexpirytolerancedays { get; set; }
        public string Cardexpirymessage { get; set; }
        public string Cardexpiryyears { get; set; }
        public string Dobyears { get; set; }

        public virtual ICollection<Cardtype> Cardtype { get; set; }
        public virtual ICollection<Country> Country { get; set; }
        public virtual ICollection<Document> Document { get; set; }
        public virtual ICollection<Gender> Gender { get; set; }
        public virtual ICollection<Title> Title { get; set; }
    }
}
