using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EFToolConvertYKTToCode.Models.Mapping
{
    public class Table_AliasOfPlateMap : EntityTypeConfiguration<Table_AliasOfPlate>
    {
        public Table_AliasOfPlateMap()
        {
            // Primary Key
            this.HasKey(t => t.Alias);

            // Properties
            this.Property(t => t.Alias)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Table_AliasOfPlate");
            this.Property(t => t.Alias).HasColumnName("Alias");
        }
    }
}
