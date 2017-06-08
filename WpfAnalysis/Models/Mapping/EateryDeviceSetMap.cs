using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EFToolConvertYKTToCode.Models.Mapping
{
    public class EateryDeviceSetMap : EntityTypeConfiguration<EateryDeviceSet>
    {
        public EateryDeviceSetMap()
        {
            // Primary Key
            this.HasKey(t => t.DevNo);

            // Properties
            this.Property(t => t.DevNo)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("EateryDeviceSet");
            this.Property(t => t.DevNo).HasColumnName("DevNo");
            this.Property(t => t.MaxAmt).HasColumnName("MaxAmt");
            this.Property(t => t.MinAmt).HasColumnName("MinAmt");
            this.Property(t => t.DelayTime).HasColumnName("DelayTime");
            this.Property(t => t.ISDevTime).HasColumnName("ISDevTime");
            this.Property(t => t.ISOpenDev).HasColumnName("ISOpenDev");
            this.Property(t => t.ISOverMaxAmt).HasColumnName("ISOverMaxAmt");
            this.Property(t => t.ISOverBlance).HasColumnName("ISOverBlance");
        }
    }
}
