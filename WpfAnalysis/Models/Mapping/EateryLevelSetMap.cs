using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EFToolConvertYKTToCode.Models.Mapping
{
    public class EateryLevelSetMap : EntityTypeConfiguration<EateryLevelSet>
    {
        public EateryLevelSetMap()
        {
            // Primary Key
            this.HasKey(t => t.LevelNo);

            // Properties
            this.Property(t => t.LevelNo)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.LevelName)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("EateryLevelSet");
            this.Property(t => t.LevelNo).HasColumnName("LevelNo");
            this.Property(t => t.LevelName).HasColumnName("LevelName");
            this.Property(t => t.MaxCnt).HasColumnName("MaxCnt");
            this.Property(t => t.MaxAmt).HasColumnName("MaxAmt");
            this.Property(t => t.Percent).HasColumnName("Percent");
            this.Property(t => t.ISOverMaxAmt).HasColumnName("ISOverMaxAmt");
            this.Property(t => t.state).HasColumnName("state");
            this.Property(t => t.breakTimes).HasColumnName("breakTimes");
            this.Property(t => t.lunchTimes).HasColumnName("lunchTimes");
            this.Property(t => t.supperTimes).HasColumnName("supperTimes");
            this.Property(t => t.nightTimes).HasColumnName("nightTimes");
            this.Property(t => t.amt1).HasColumnName("amt1");
            this.Property(t => t.amt2).HasColumnName("amt2");
            this.Property(t => t.amt3).HasColumnName("amt3");
            this.Property(t => t.amt4).HasColumnName("amt4");
            this.Property(t => t.fee1).HasColumnName("fee1");
            this.Property(t => t.fee2).HasColumnName("fee2");
            this.Property(t => t.fee3).HasColumnName("fee3");
            this.Property(t => t.fee4).HasColumnName("fee4");
        }
    }
}
