using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EFToolConvertYKTToCode.Models.Mapping
{
    public class EateryCustLevelMap : EntityTypeConfiguration<EateryCustLevel>
    {
        public EateryCustLevelMap()
        {
            // Primary Key
            this.HasKey(t => t.CustNo);

            // Properties
            this.Property(t => t.CustNo)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.dinner)
                .IsRequired()
                .HasMaxLength(400);

            this.Property(t => t.MatchDevStr)
                .HasMaxLength(400);

            // Table & Column Mappings
            this.ToTable("EateryCustLevel");
            this.Property(t => t.CustNo).HasColumnName("CustNo");
            this.Property(t => t.LevelNo).HasColumnName("LevelNo");
            this.Property(t => t.AccessMode).HasColumnName("AccessMode");
            this.Property(t => t.dinner).HasColumnName("dinner");
            this.Property(t => t.MatchDevStr).HasColumnName("MatchDevStr");
        }
    }
}
