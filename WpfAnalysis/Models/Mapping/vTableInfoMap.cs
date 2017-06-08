using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EFToolConvertYKTToCode.Models.Mapping
{
    public class vTableInfoMap : EntityTypeConfiguration<vTableInfo>
    {
        public vTableInfoMap()
        {
            // Primary Key
            this.HasKey(t => new { t.TableName, t.colid, t.eFieldName, t.type_name, t.length, t.scale });

            // Properties
            this.Property(t => t.TableName)
                .IsRequired()
                .HasMaxLength(128);

            this.Property(t => t.colid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.eFieldName)
                .IsRequired()
                .HasMaxLength(128);

            this.Property(t => t.type_name)
                .IsRequired()
                .HasMaxLength(128);

            this.Property(t => t.length)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.scale)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("vTableInfo");
            this.Property(t => t.TableName).HasColumnName("TableName");
            this.Property(t => t.colid).HasColumnName("colid");
            this.Property(t => t.eFieldName).HasColumnName("eFieldName");
            this.Property(t => t.type_name).HasColumnName("type_name");
            this.Property(t => t.length).HasColumnName("length");
            this.Property(t => t.isnullable).HasColumnName("isnullable");
            this.Property(t => t.scale).HasColumnName("scale");
        }
    }
}
