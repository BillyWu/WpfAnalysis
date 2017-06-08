using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EFToolConvertYKTToCode.Models.Mapping
{
    public class Table_MoneyDiscountMap : EntityTypeConfiguration<Table_MoneyDiscount>
    {
        public Table_MoneyDiscountMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("Table_MoneyDiscount");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.Money).HasColumnName("Money");
            this.Property(t => t.Discount).HasColumnName("Discount");
        }
    }
}
