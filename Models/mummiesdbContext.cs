using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FagElGamous.Models
{
    public partial class mummiesdbContext : DbContext
    {
        public mummiesdbContext()
        {
        }

        public mummiesdbContext(DbContextOptions<mummiesdbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Burial> Burial { get; set; }
        public virtual DbSet<C14> C14 { get; set; }
        public virtual DbSet<Cranial> Cranial { get; set; }
        public virtual DbSet<Sample> Sample { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySQL("Data Source=rds-mysql-mummies.cnhhfictxlmw.us-east-1.rds.amazonaws.com;Initial Catalog=mummiesdb;User ID=admin;Password=hereisagreatpasswordnobodywillguess;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Burial>(entity =>
            {
                entity.ToTable("burial");

                entity.Property(e => e.BurialId).HasColumnName("burial_Id");

                entity.Property(e => e.AgeCode)
                    .HasColumnName("age_code")
                    .HasMaxLength(2);

                entity.Property(e => e.AreaHillBurials).HasColumnName("area_hill_burials");

                entity.Property(e => e.ArtifactFound)
                    .HasColumnName("artifact_found")
                    .HasMaxLength(5);

                entity.Property(e => e.ArtifactsDescription)
                    .HasColumnName("artifacts_description")
                    .HasMaxLength(119);

                entity.Property(e => e.BasilarSuture)
                    .HasColumnName("basilar_suture")
                    .HasMaxLength(6);

                entity.Property(e => e.BasionBregmaHeight)
                    .HasColumnName("basion_bregma_height")
                    .HasColumnType("decimal(5,2)");

                entity.Property(e => e.BasionNasion)
                    .HasColumnName("basion_nasion")
                    .HasColumnType("decimal(5,2)");

                entity.Property(e => e.BasionProsthionLength)
                    .HasColumnName("basion_prosthion_length")
                    .HasColumnType("decimal(4,2)");

                entity.Property(e => e.BizygomaticDiameter)
                    .HasColumnName("bizygomatic_diameter")
                    .HasColumnType("decimal(5,2)");

                entity.Property(e => e.BodyAnalysis).HasColumnName("body_analysis");

                entity.Property(e => e.BoneTaken)
                    .HasColumnName("bone_taken")
                    .HasMaxLength(5);

                entity.Property(e => e.BurialAdultChild)
                    .HasColumnName("burial_adult_child")
                    .HasMaxLength(4);

                entity.Property(e => e.BurialDepth)
                    .HasColumnName("burial_depth")
                    .HasMaxLength(19);

                entity.Property(e => e.BurialGenderMethod)
                    .HasColumnName("burial_gender_method")
                    .HasMaxLength(4);

                entity.Property(e => e.BurialLocation)
                    .HasColumnName("burial_location")
                    .HasMaxLength(26);

                entity.Property(e => e.BurialLocationEw)
                    .HasColumnName("burial_location_EW")
                    .HasMaxLength(2);

                entity.Property(e => e.BurialLocationNs)
                    .HasColumnName("burial_location_NS")
                    .HasMaxLength(2);

                entity.Property(e => e.BurialNumber)
                    .HasColumnName("burial_number")
                    .HasMaxLength(2);

                entity.Property(e => e.BurialPreservation)
                    .HasColumnName("burial_preservation")
                    .HasMaxLength(26);

                entity.Property(e => e.BurialSampleTaken)
                    .HasColumnName("burial_sample_taken")
                    .HasMaxLength(7);

                entity.Property(e => e.BurialSituation)
                    .HasColumnName("burial_situation")
                    .HasMaxLength(1092);

                entity.Property(e => e.BurialSubplot)
                    .HasColumnName("burial_subplot")
                    .HasMaxLength(3);

                entity.Property(e => e.BurialWrapingCode)
                    .HasColumnName("burial_wraping_code")
                    .HasMaxLength(1);

                entity.Property(e => e.Burialagemethod)
                    .HasColumnName("burialagemethod")
                    .HasMaxLength(4);

                entity.Property(e => e.ButtonOsteoma)
                    .HasColumnName("button_osteoma")
                    .HasMaxLength(4);

                entity.Property(e => e.ByuSample)
                    .HasColumnName("byu_sample")
                    .HasMaxLength(1);

                entity.Property(e => e.Cluster)
                    .HasColumnName("cluster")
                    .HasMaxLength(39);

                entity.Property(e => e.CranialSuture)
                    .HasColumnName("cranial_suture")
                    .HasMaxLength(13);

                entity.Property(e => e.CribraOrbitala)
                    .HasColumnName("cribra_orbitala")
                    .HasMaxLength(5);

                entity.Property(e => e.DateOnSkull).HasColumnName("date_on_skull");

                entity.Property(e => e.DayFound).HasColumnName("day_found");

                entity.Property(e => e.DescriptionOfTaken)
                    .HasColumnName("description_of_taken")
                    .HasMaxLength(94);

                entity.Property(e => e.DorsalPitting).HasColumnName("dorsal_pitting");

                entity.Property(e => e.EpiphysealUnion)
                    .HasColumnName("epiphyseal_union")
                    .HasMaxLength(12);

                entity.Property(e => e.EstimateAge)
                    .HasColumnName("estimate_age")
                    .HasMaxLength(19);

                entity.Property(e => e.EstimateLivingStature)
                    .HasColumnName("estimate_living_stature")
                    .HasColumnType("decimal(6,3)");

                entity.Property(e => e.FaceBundle)
                    .HasColumnName("face_bundle")
                    .HasMaxLength(6);

                entity.Property(e => e.FemurHead)
                    .HasColumnName("femur_head")
                    .HasColumnType("decimal(4,2)");

                entity.Property(e => e.FemurLength)
                    .HasColumnName("femur_length")
                    .HasColumnType("decimal(3,1)");

                entity.Property(e => e.FieldBook)
                    .HasColumnName("field_book")
                    .HasMaxLength(17);

                entity.Property(e => e.FieldBookPageNumber)
                    .HasColumnName("field_book_page_number")
                    .HasMaxLength(23);

                entity.Property(e => e.ForemanMagnum).HasColumnName("foreman_magnum");

                entity.Property(e => e.GeFunctionTotal)
                    .HasColumnName("GE_function_total")
                    .HasColumnType("decimal(7,4)");

                entity.Property(e => e.GenderBodyCol)
                    .HasColumnName("gender_body_col")
                    .HasMaxLength(12);

                entity.Property(e => e.GenderGe)
                    .HasColumnName("gender_GE")
                    .HasMaxLength(12);

                entity.Property(e => e.Gonian).HasColumnName("gonian");

                entity.Property(e => e.Goods)
                    .HasColumnName("goods")
                    .HasMaxLength(16);

                entity.Property(e => e.HairColorCode)
                    .HasColumnName("hair_color_code")
                    .HasMaxLength(1);

                entity.Property(e => e.HairColorDescription)
                    .HasColumnName("hair_color_description")
                    .HasMaxLength(13);

                entity.Property(e => e.HairTaken)
                    .HasColumnName("hair_taken")
                    .HasMaxLength(5);

                entity.Property(e => e.HeadDirection)
                    .HasColumnName("head_direction")
                    .HasMaxLength(7);

                entity.Property(e => e.HighPairEw).HasColumnName("high_pair_EW");

                entity.Property(e => e.HighPairNs)
                    .HasColumnName("high_pair_NS")
                    .HasMaxLength(7);

                entity.Property(e => e.HumerusHead)
                    .HasColumnName("humerus_head")
                    .HasColumnType("decimal(4,2)");

                entity.Property(e => e.HumerusLength)
                    .HasColumnName("humerus_length")
                    .HasColumnType("decimal(3,1)");

                entity.Property(e => e.InitialsOfDataEntryCheker)
                    .HasColumnName("initials_of_data_entry_cheker")
                    .HasMaxLength(2);

                entity.Property(e => e.InitialsOfDataEntryExpert)
                    .HasColumnName("initials_of_data_entry_expert")
                    .HasMaxLength(2);

                entity.Property(e => e.InterorbitalBreadth)
                    .HasColumnName("interorbital_breadth")
                    .HasColumnType("decimal(4,2)");

                entity.Property(e => e.LengthOfRemains)
                    .HasColumnName("length_of_remains")
                    .HasColumnType("decimal(18,14)");

                entity.Property(e => e.LinearHypoplasiaEnamel)
                    .HasColumnName("linear_hypoplasia_enamel")
                    .HasMaxLength(1);

                entity.Property(e => e.LowPairEw).HasColumnName("low_pair_EW");

                entity.Property(e => e.LowPairNs)
                    .HasColumnName("low_pair_NS")
                    .HasMaxLength(6);

                entity.Property(e => e.MaximumCranialBreadth)
                    .HasColumnName("maximum_cranial_breadth")
                    .HasColumnType("decimal(5,2)");

                entity.Property(e => e.MaximumCranialLength)
                    .HasColumnName("maximum_cranial_length")
                    .HasColumnType("decimal(5,2)");

                entity.Property(e => e.MaximumNasalBreadth)
                    .HasColumnName("maximum_nasal_breadth")
                    .HasColumnType("decimal(4,2)");

                entity.Property(e => e.MedialIpRamus)
                    .HasColumnName("medial_IP_ramus")
                    .HasMaxLength(11);

                entity.Property(e => e.MetopicStructure)
                    .HasColumnName("metopic_structure")
                    .HasMaxLength(4);

                entity.Property(e => e.MonthFound)
                    .HasColumnName("month_found")
                    .HasMaxLength(9);

                entity.Property(e => e.MonthOnSkull)
                    .HasColumnName("month_on_skull")
                    .HasMaxLength(8);

                entity.Property(e => e.NasionProsthion)
                    .HasColumnName("nasion_prosthion")
                    .HasColumnType("decimal(4,2)");

                entity.Property(e => e.NuchalCrest).HasColumnName("nuchal_crest");

                entity.Property(e => e.OrbitEdge)
                    .HasColumnName("orbit_edge")
                    .HasMaxLength(7);

                entity.Property(e => e.OsteologyNotes)
                    .HasColumnName("osteology_notes")
                    .HasMaxLength(692);

                entity.Property(e => e.OsteologyUnknownComment)
                    .HasColumnName("osteology_unknown_comment")
                    .HasMaxLength(2);

                entity.Property(e => e.Osteophytosis)
                    .HasColumnName("osteophytosis")
                    .HasMaxLength(8);

                entity.Property(e => e.ParietalBossing).HasColumnName("parietal_bossing");

                entity.Property(e => e.PathologyAnomalies)
                    .HasColumnName("pathology_anomalies")
                    .HasMaxLength(169);

                entity.Property(e => e.PoroticHyperostosis)
                    .HasColumnName("porotic_hyperostosis")
                    .HasMaxLength(5);

                entity.Property(e => e.PoroticHyperostosisLocation)
                    .HasColumnName("porotic_hyperostosis_location")
                    .HasMaxLength(4);

                entity.Property(e => e.PostcraniaAtMagazine)
                    .HasColumnName("postcrania_at_magazine")
                    .HasMaxLength(1);

                entity.Property(e => e.PostcraniaTrauma)
                    .HasColumnName("postcrania_trauma")
                    .HasMaxLength(4);

                entity.Property(e => e.PreaurSulcus)
                    .HasColumnName("preaur_sulcus")
                    .HasMaxLength(11);

                entity.Property(e => e.PreservationIndex)
                    .HasColumnName("preservation_index")
                    .HasMaxLength(3);

                entity.Property(e => e.PubicBone)
                    .HasColumnName("pubic_bone")
                    .HasMaxLength(11);

                entity.Property(e => e.PubicSymphysis)
                    .HasColumnName("pubic_symphysis")
                    .HasMaxLength(2);

                entity.Property(e => e.RackAndShelf)
                    .HasColumnName("rack_and_shelf")
                    .HasMaxLength(15);

                entity.Property(e => e.Robust)
                    .HasColumnName("robust")
                    .HasMaxLength(7);

                entity.Property(e => e.SampleNumber).HasColumnName("sample_number");

                entity.Property(e => e.SciaticNotch)
                    .HasColumnName("sciatic_notch")
                    .HasMaxLength(11);

                entity.Property(e => e.SkullAtMagazine)
                    .HasColumnName("skull_at_magazine")
                    .HasMaxLength(1);

                entity.Property(e => e.SkullTrama)
                    .HasColumnName("skull_trama")
                    .HasMaxLength(4);

                entity.Property(e => e.SoftTissueTaken)
                    .HasColumnName("soft_tissue_taken")
                    .HasMaxLength(5);

                entity.Property(e => e.SouthToFeet)
                    .HasColumnName("south_to_feet")
                    .HasMaxLength(18);

                entity.Property(e => e.SouthToHead)
                    .HasColumnName("south_to_head")
                    .HasMaxLength(18);

                entity.Property(e => e.SubpubicAngle)
                    .HasColumnName("subpubic_angle")
                    .HasMaxLength(11);

                entity.Property(e => e.SupraorbitalRidges)
                    .HasColumnName("supraorbital_ridges")
                    .HasMaxLength(7);

                entity.Property(e => e.TemporalMandibularJoinOsteoarthritis)
                    .HasColumnName("temporal_mandibular_join_osteoarthritis")
                    .HasMaxLength(4);

                entity.Property(e => e.TextileTaken)
                    .HasColumnName("textile_taken")
                    .HasMaxLength(5);

                entity.Property(e => e.TibiaLength)
                    .HasColumnName("tibia_length")
                    .HasColumnType("decimal(3,1)");

                entity.Property(e => e.ToBeConfirmed)
                    .HasColumnName("to_be_confirmed")
                    .HasMaxLength(4);

                entity.Property(e => e.Tomb).HasColumnName("tomb");

                entity.Property(e => e.ToothAttrition)
                    .HasColumnName("tooth_attrition")
                    .HasMaxLength(3);

                entity.Property(e => e.ToothEruption)
                    .HasColumnName("tooth_eruption")
                    .HasMaxLength(42);

                entity.Property(e => e.ToothTaken)
                    .HasColumnName("tooth_taken")
                    .HasMaxLength(5);

                entity.Property(e => e.VentralArc)
                    .HasColumnName("ventral_arc")
                    .HasMaxLength(11);

                entity.Property(e => e.WestToFeet)
                    .HasColumnName("west_to_feet")
                    .HasMaxLength(20);

                entity.Property(e => e.WestToHead)
                    .HasColumnName("west_to_head")
                    .HasMaxLength(20);

                entity.Property(e => e.YearFound).HasColumnName("year_found");

                entity.Property(e => e.YearOnSkull)
                    .HasColumnName("year_on_skull")
                    .HasMaxLength(6);

                entity.Property(e => e.ZygomaticCrest).HasColumnName("zygomatic_crest");
            });

            modelBuilder.Entity<C14>(entity =>
            {
                entity.HasIndex(e => e.BurialFk)
                    .HasName("burial_FK");

                entity.Property(e => e.C14Id).HasColumnName("C14_Id");

                entity.Property(e => e.Area).HasColumnName("AREA");

                entity.Property(e => e.BurialFk).HasColumnName("burial_FK");

                entity.Property(e => e.BurialLocation)
                    .HasColumnName("burial_location")
                    .HasMaxLength(24);

                entity.Property(e => e.C14Sample2017).HasColumnName("C14_Sample_2017");

                entity.Property(e => e.Calibrated95CalendarDateAvg)
                    .HasColumnName("Calibrated_95_Calendar_Date_AVG")
                    .HasMaxLength(8);

                entity.Property(e => e.Calibrated95CalendarDateMax)
                    .HasColumnName("Calibrated_95_Calendar_Date_MAX")
                    .HasMaxLength(7);

                entity.Property(e => e.Calibrated95CalendarDateMin)
                    .HasColumnName("Calibrated_95_Calendar_Date_MIN")
                    .HasMaxLength(6);

                entity.Property(e => e.Calibrated95CalendarDateSpan)
                    .HasColumnName("Calibrated_95_Calendar_Date_SPAN")
                    .HasMaxLength(6);

                entity.Property(e => e.Category).HasMaxLength(14);

                entity.Property(e => e.Column14cCalendarDate)
                    .HasColumnName("Column_14C_Calendar_Date")
                    .HasMaxLength(6);

                entity.Property(e => e.Column20).HasColumnName("Column_20");

                entity.Property(e => e.Column6)
                    .HasColumnName("Column_6")
                    .HasMaxLength(1);

                entity.Property(e => e.Column8)
                    .HasColumnName("Column_8")
                    .HasMaxLength(1);

                entity.Property(e => e.Conventional14cAgeBp).HasColumnName("Conventional_14C_age_BP");

                entity.Property(e => e.Description).HasMaxLength(48);

                entity.Property(e => e.EW).HasColumnName("E_W");

                entity.Property(e => e.Location).HasMaxLength(60);

                entity.Property(e => e.NS).HasColumnName("N_S");

                entity.Property(e => e.Notes).HasMaxLength(32);

                entity.Property(e => e.QuestionS)
                    .HasColumnName("Question_s")
                    .HasMaxLength(131);

                entity.Property(e => e.Rack1).HasColumnName("Rack_1");

                entity.Property(e => e.SizeMl).HasColumnName("Size_ml");

                entity.Property(e => e.Square).HasMaxLength(4);

                entity.Property(e => e.Tube).HasColumnName("TUBE");

                entity.HasOne(d => d.BurialFkNavigation)
                    .WithMany(p => p.C14)
                    .HasForeignKey(d => d.BurialFk)
                    .HasConstraintName("C14_ibfk_1");
            });

            modelBuilder.Entity<Cranial>(entity =>
            {
                entity.ToTable("cranial");

                entity.HasIndex(e => e.BurialFk)
                    .HasName("burial_FK");

                entity.Property(e => e.CranialId).HasColumnName("cranial_Id");

                entity.Property(e => e.BasionBregmaHeight)
                    .HasColumnName("Basion_Bregma_Height")
                    .HasColumnType("decimal(5,2)");

                entity.Property(e => e.BasionNasion)
                    .HasColumnName("Basion_Nasion")
                    .HasColumnType("decimal(5,2)");

                entity.Property(e => e.BasionProsthionLength)
                    .HasColumnName("Basion_Prosthion_Length")
                    .HasColumnType("decimal(5,2)");

                entity.Property(e => e.BizygomaticDiameter)
                    .HasColumnName("Bizygomatic_Diameter")
                    .HasColumnType("decimal(5,2)");

                entity.Property(e => e.BodyGender).HasMaxLength(6);

                entity.Property(e => e.BurialArtifactDescription)
                    .HasColumnName("Burial_Artifact_Description")
                    .HasMaxLength(34);

                entity.Property(e => e.BurialDepth)
                    .HasColumnName("Burial_Depth")
                    .HasColumnType("decimal(4,2)");

                entity.Property(e => e.BurialFk).HasColumnName("burial_FK");

                entity.Property(e => e.BurialLocation)
                    .HasColumnName("burial_location")
                    .HasMaxLength(24);

                entity.Property(e => e.BurialNumber).HasColumnName("Burial_Number");

                entity.Property(e => e.BurialPositioningEastWestDirection)
                    .HasColumnName("Burial_Positioning_East_West_Direction")
                    .HasMaxLength(1);

                entity.Property(e => e.BurialPositioningEastWestNumber)
                    .HasColumnName("Burial_Positioning_East_West_Number")
                    .HasMaxLength(5);

                entity.Property(e => e.BurialPositioningNorthSouthDirection)
                    .HasColumnName("Burial_Positioning_North_South_Direction")
                    .HasMaxLength(1);

                entity.Property(e => e.BurialPositioningNorthSouthNumber)
                    .HasColumnName("Burial_Positioning_North_South_Number")
                    .HasMaxLength(7);

                entity.Property(e => e.BurialSubPlotDirection)
                    .HasColumnName("Burial_sub_plot_direction")
                    .HasMaxLength(2);

                entity.Property(e => e.BuriedWithArtifacts)
                    .HasColumnName("Buried_with_Artifacts")
                    .HasMaxLength(5);

                entity.Property(e => e.InterorbitalBreadth)
                    .HasColumnName("Interorbital_Breadth")
                    .HasColumnType("decimal(4,2)");

                entity.Property(e => e.MaximumCranialBreadth)
                    .HasColumnName("Maximum_Cranial_Breadth")
                    .HasColumnType("decimal(5,2)");

                entity.Property(e => e.MaximumCranialLength)
                    .HasColumnName("Maximum_Cranial_Length")
                    .HasColumnType("decimal(5,2)");

                entity.Property(e => e.MaximumNasalBreadth)
                    .HasColumnName("Maximum_Nasal_Breadth")
                    .HasColumnType("decimal(4,2)");

                entity.Property(e => e.NasionProsthion)
                    .HasColumnName("Nasion_Prosthion")
                    .HasColumnType("decimal(5,2)");

                entity.Property(e => e.SampleNumber).HasColumnName("Sample_Number");

                entity.HasOne(d => d.BurialFkNavigation)
                    .WithMany(p => p.Cranial)
                    .HasForeignKey(d => d.BurialFk)
                    .HasConstraintName("cranial_ibfk_1");
            });

            modelBuilder.Entity<Sample>(entity =>
            {
                entity.ToTable("sample");

                entity.HasIndex(e => e.BurialFk)
                    .HasName("burial_FK");

                entity.Property(e => e.SampleId).HasColumnName("sample_Id");

                entity.Property(e => e.Area).HasMaxLength(6);

                entity.Property(e => e.Bag).HasMaxLength(1);

                entity.Property(e => e.Burial).HasMaxLength(8);

                entity.Property(e => e.BurialFk).HasColumnName("burial_FK");

                entity.Property(e => e.BurialLocation)
                    .HasColumnName("burial_location")
                    .HasMaxLength(30);

                entity.Property(e => e.Date).HasMaxLength(19);

                entity.Property(e => e.EW)
                    .HasColumnName("E_W")
                    .HasMaxLength(2);

                entity.Property(e => e.High1).HasColumnName("High_1");

                entity.Property(e => e.Initials).HasMaxLength(3);

                entity.Property(e => e.Low1).HasColumnName("Low_1");

                entity.Property(e => e.NS)
                    .HasColumnName("N_S")
                    .HasMaxLength(2);

                entity.Property(e => e.Notes).HasMaxLength(65);

                entity.Property(e => e.PreviouslySampled)
                    .HasColumnName("Previously_Sampled")
                    .HasMaxLength(3);

                entity.HasOne(d => d.BurialFkNavigation)
                    .WithMany(p => p.Sample)
                    .HasForeignKey(d => d.BurialFk)
                    .HasConstraintName("sample_ibfk_1");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
