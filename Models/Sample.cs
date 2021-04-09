using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FagElGamous.Models
{
    public partial class Sample
    {
        public int SampleId { get; set; }
        public int? BurialFk { get; set; }
        public string BurialLocation { get; set; }
        public int? Rack { get; set; }
        public string Bag { get; set; }
        public int? Low { get; set; }
        public int? High { get; set; }
        public string NS { get; set; }
        public int? Low1 { get; set; }
        public int? High1 { get; set; }
        public string EW { get; set; }
        public string Area { get; set; }
        public string Burial { get; set; }
        public string Date { get; set; }
        public string PreviouslySampled { get; set; }
        public string Notes { get; set; }
        public string Initials { get; set; }

        public virtual Burial BurialFkNavigation { get; set; }
    }
}
