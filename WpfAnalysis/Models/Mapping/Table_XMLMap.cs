using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EFToolConvertYKTToCode.Models.Mapping
{
    public class Table_XMLMap : EntityTypeConfiguration<Table_XML>
    {
        public Table_XMLMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("Table_XML");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.XML).HasColumnName("XML");
        }
    }
}
