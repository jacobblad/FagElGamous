using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FagElGamous.Models
{
    public partial class Burial
    {
        public Burial()
        {
            C14 = new HashSet<C14>();
            Cranial = new HashSet<Cranial>();
            Sample = new HashSet<Sample>();
        }

        public int BurialId { get; set; }
        public string BurialLocation { get; set; }
        public string BurialLocationNs { get; set; }
        public string BurialLocationEw { get; set; }
        public string LowPairNs { get; set; }
        public string HighPairNs { get; set; }
        public int? LowPairEw { get; set; }
        public int? HighPairEw { get; set; }
        public string BurialSubplot { get; set; }
        public string BurialDepth { get; set; }
        public string SouthToHead { get; set; }
        public string SouthToFeet { get; set; }
        public string WestToHead { get; set; }
        public string WestToFeet { get; set; }
        public string BurialSituation { get; set; }
        public decimal? LengthOfRemains { get; set; }
        public string BurialNumber { get; set; }
        public int? SampleNumber { get; set; }
        public string GenderGe { get; set; }
        public decimal? GeFunctionTotal { get; set; }
        public string GenderBodyCol { get; set; }
        public string BurialGenderMethod { get; set; }
        public string BasilarSuture { get; set; }
        public string VentralArc { get; set; }
        public string SubpubicAngle { get; set; }
        public string SciaticNotch { get; set; }
        public string PubicBone { get; set; }
        public string PreaurSulcus { get; set; }
        public string MedialIpRamus { get; set; }
        public int? DorsalPitting { get; set; }
        public int? ForemanMagnum { get; set; }
        public decimal? FemurHead { get; set; }
        public decimal? HumerusHead { get; set; }
        public string Osteophytosis { get; set; }
        public string PubicSymphysis { get; set; }
        public decimal? FemurLength { get; set; }
        public decimal? HumerusLength { get; set; }
        public decimal? TibiaLength { get; set; }
        public string Robust { get; set; }
        public string SupraorbitalRidges { get; set; }
        public string OrbitEdge { get; set; }
        public int? ParietalBossing { get; set; }
        public int? Gonian { get; set; }
        public int? NuchalCrest { get; set; }
        public int? ZygomaticCrest { get; set; }
        public string CranialSuture { get; set; }
        public decimal? MaximumCranialLength { get; set; }
        public decimal? MaximumCranialBreadth { get; set; }
        public decimal? BasionBregmaHeight { get; set; }
        public decimal? BasionNasion { get; set; }
        public decimal? BasionProsthionLength { get; set; }
        public decimal? BizygomaticDiameter { get; set; }
        public decimal? NasionProsthion { get; set; }
        public decimal? MaximumNasalBreadth { get; set; }
        public decimal? InterorbitalBreadth { get; set; }
        public string ArtifactsDescription { get; set; }
        public string HairColorCode { get; set; }
        public string HairColorDescription { get; set; }
        public string PreservationIndex { get; set; }
        public string HairTaken { get; set; }
        public string SoftTissueTaken { get; set; }
        public string BoneTaken { get; set; }
        public string ToothTaken { get; set; }
        public string TextileTaken { get; set; }
        public string DescriptionOfTaken { get; set; }
        public string ArtifactFound { get; set; }
        public string EstimateAge { get; set; }
        public string AgeCode { get; set; }
        public decimal? EstimateLivingStature { get; set; }
        public string ToothAttrition { get; set; }
        public string ToothEruption { get; set; }
        public string PathologyAnomalies { get; set; }
        public string EpiphysealUnion { get; set; }
        public int? YearFound { get; set; }
        public string MonthFound { get; set; }
        public int? DayFound { get; set; }
        public string HeadDirection { get; set; }
        public string YearOnSkull { get; set; }
        public string MonthOnSkull { get; set; }
        public int? DateOnSkull { get; set; }
        public string FieldBook { get; set; }
        public string FieldBookPageNumber { get; set; }
        public string InitialsOfDataEntryExpert { get; set; }
        public string InitialsOfDataEntryCheker { get; set; }
        public string ByuSample { get; set; }
        public int? BodyAnalysis { get; set; }
        public string SkullAtMagazine { get; set; }
        public string PostcraniaAtMagazine { get; set; }
        public string RackAndShelf { get; set; }
        public string ToBeConfirmed { get; set; }
        public string SkullTrama { get; set; }
        public string CribraOrbitala { get; set; }
        public string PoroticHyperostosis { get; set; }
        public string PoroticHyperostosisLocation { get; set; }
        public string MetopicStructure { get; set; }
        public string ButtonOsteoma { get; set; }
        public string PostcraniaTrauma { get; set; }
        public string OsteologyUnknownComment { get; set; }
        public string TemporalMandibularJoinOsteoarthritis { get; set; }
        public string LinearHypoplasiaEnamel { get; set; }
        public int? Tomb { get; set; }
        public int? AreaHillBurials { get; set; }
        public string BurialPreservation { get; set; }
        public string BurialWrapingCode { get; set; }
        public string BurialAdultChild { get; set; }
        public string Burialagemethod { get; set; }
        public string BurialSampleTaken { get; set; }
        public string Goods { get; set; }
        public string Cluster { get; set; }
        public string FaceBundle { get; set; }
        public string OsteologyNotes { get; set; }

        public virtual ICollection<C14> C14 { get; set; }
        public virtual ICollection<Cranial> Cranial { get; set; }
        public virtual ICollection<Sample> Sample { get; set; }
    }
}
