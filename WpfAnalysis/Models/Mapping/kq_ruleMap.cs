using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EFToolConvertYKTToCode.Models.Mapping
{
    public class kq_ruleMap : EntityTypeConfiguration<kq_rule>
    {
        public kq_ruleMap()
        {
            // Primary Key
            this.HasKey(t => t.wrkNo);

            // Properties
            this.Property(t => t.id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.wrkNo)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.JB_startTime)
                .HasMaxLength(5);

            this.Property(t => t.JB_endTime)
                .HasMaxLength(5);

            // Table & Column Mappings
            this.ToTable("kq_rule");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.wrkNo).HasColumnName("wrkNo");
            this.Property(t => t.wrkType).HasColumnName("wrkType");
            this.Property(t => t.ciDao).HasColumnName("ciDao");
            this.Property(t => t.zaoTui).HasColumnName("zaoTui");
            this.Property(t => t.validSignTime).HasColumnName("validSignTime");
            this.Property(t => t.weekHoliday).HasColumnName("weekHoliday");
            this.Property(t => t.JB_startTime).HasColumnName("JB_startTime");
            this.Property(t => t.JB_endTime).HasColumnName("JB_endTime");
            this.Property(t => t.IsJBDCalc).HasColumnName("IsJBDCalc");
            this.Property(t => t.IsHoliday).HasColumnName("IsHoliday");
            this.Property(t => t.dayTimes).HasColumnName("dayTimes");
        }
    }
}
