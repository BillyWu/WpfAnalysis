using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EFToolConvertYKTToCode.Models.Mapping
{
    public class fee_stdMap : EntityTypeConfiguration<fee_std>
    {
        public fee_stdMap()
        {
            // Primary Key
            this.HasKey(t => new { t.dev_id, t.car_tid, t.fsdm, t.bh, t.lx, t.csz });

            // Properties
            this.Property(t => t.dev_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.car_tid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.fsdm)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.bh)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.lx)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.csz)
                .IsRequired()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("fee_std");
            this.Property(t => t.dev_id).HasColumnName("dev_id");
            this.Property(t => t.car_tid).HasColumnName("car_tid");
            this.Property(t => t.fsdm).HasColumnName("fsdm");
            this.Property(t => t.bh).HasColumnName("bh");
            this.Property(t => t.lx).HasColumnName("lx");
            this.Property(t => t.csz).HasColumnName("csz");
        }
    }
}
