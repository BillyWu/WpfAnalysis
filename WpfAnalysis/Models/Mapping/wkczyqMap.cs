using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EFToolConvertYKTToCode.Models.Mapping
{
    public class wkczyqMap : EntityTypeConfiguration<wkczyq>
    {
        public wkczyqMap()
        {
            // Primary Key
            this.HasKey(t => t.cardno);

            // Properties
            this.Property(t => t.cardno)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("wkczyq");
            this.Property(t => t.cardno).HasColumnName("cardno");
            this.Property(t => t.address).HasColumnName("address");
            this.Property(t => t.card_type).HasColumnName("card_type");
            this.Property(t => t.balance).HasColumnName("balance");
            this.Property(t => t.startdate).HasColumnName("startdate");
            this.Property(t => t.enddate).HasColumnName("enddate");
            this.Property(t => t.downloadflag).HasColumnName("downloadflag");
        }
    }
}
