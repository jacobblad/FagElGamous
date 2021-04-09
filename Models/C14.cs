using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FagElGamous.Models
{
    public partial class C14
    {
        public int C14Id { get; set; }
        public int? BurialFk { get; set; }
        public string BurialLocation { get; set; }
        public int? Rack { get; set; }
        public int? NS { get; set; }
        public string Column6 { get; set; }
        public int? EW { get; set; }
        public string Column8 { get; set; }
        public string Square { get; set; }
        public int? Area { get; set; }
        public int? Burial { get; set; }
        public int? Rack1 { get; set; }
        public int? Tube { get; set; }
        public string Description { get; set; }
        public int? SizeMl { get; set; }
        public int? Foci { get; set; }
        public int? C14Sample2017 { get; set; }
        public string Location { get; set; }
        public string QuestionS { get; set; }
        public int? Column20 { get; set; }
        public int? Conventional14cAgeBp { get; set; }
        public string Column14cCalendarDate { get; set; }
        public string Calibrated95CalendarDateMax { get; set; }
        public string Calibrated95CalendarDateMin { get; set; }
        public string Calibrated95CalendarDateSpan { get; set; }
        public string Calibrated95CalendarDateAvg { get; set; }
        public string Category { get; set; }
        public string Notes { get; set; }

        public virtual Burial BurialFkNavigation { get; set; }
    }
}
