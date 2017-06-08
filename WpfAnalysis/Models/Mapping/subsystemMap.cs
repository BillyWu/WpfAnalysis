using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EFToolConvertYKTToCode.Models.Mapping
{
    public class subsystemMap : EntityTypeConfiguration<subsystem>
    {
        public subsystemMap()
        {
            // Primary Key
            this.HasKey(t => t.systemid);

            // Properties
            this.Property(t => t.systemid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.sysflag)
                .HasMaxLength(4);

            this.Property(t => t.commpass)
                .HasMaxLength(4);

            this.Property(t => t.syspass)
                .HasMaxLength(6);

            this.Property(t => t.userpass)
                .HasMaxLength(6);

            // Table & Column Mappings
            this.ToTable("subsystem");
            this.Property(t => t.systemid).HasColumnName("systemid");
            this.Property(t => t.sysflag).HasColumnName("sysflag");
            this.Property(t => t.commpass).HasColumnName("commpass");
            this.Property(t => t.syspass).HasColumnName("syspass");
            this.Property(t => t.userpass).HasColumnName("userpass");
            this.Property(t => t.accesstype).HasColumnName("accesstype");
            this.Property(t => t.cardarea1).HasColumnName("cardarea1");
            this.Property(t => t.cardarea2).HasColumnName("cardarea2");
        }
    }
}
