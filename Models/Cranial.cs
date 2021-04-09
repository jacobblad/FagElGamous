using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FagElGamous.Models
{
    public partial class Cranial
    {
        public int CranialId { get; set; }
        public int? BurialFk { get; set; }
        public string BurialLocation { get; set; }
        public int? SampleNumber { get; set; }
        public decimal? MaximumCranialLength { get; set; }
        public decimal? MaximumCranialBreadth { get; set; }
        public decimal? BasionBregmaHeight { get; set; }
        public decimal? BasionNasion { get; set; }
        public decimal? BasionProsthionLength { get; set; }
        public decimal? BizygomaticDiameter { get; set; }
        public decimal? NasionProsthion { get; set; }
        public decimal? MaximumNasalBreadth { get; set; }
        public decimal? InterorbitalBreadth { get; set; }
        public string BurialPositioningNorthSouthNumber { get; set; }
        public string BurialPositioningNorthSouthDirection { get; set; }
        public string BurialPositioningEastWestNumber { get; set; }
        public string BurialPositioningEastWestDirection { get; set; }
        public int? BurialNumber { get; set; }
        public decimal? BurialDepth { get; set; }
        public string BurialSubPlotDirection { get; set; }
        public string BurialArtifactDescription { get; set; }
        public string BuriedWithArtifacts { get; set; }
        public int? GilesGender { get; set; }
        public string BodyGender { get; set; }

        public virtual Burial BurialFkNavigation { get; set; }
    }
}
