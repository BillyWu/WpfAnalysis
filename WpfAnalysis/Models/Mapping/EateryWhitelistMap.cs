using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EFToolConvertYKTToCode.Models.Mapping
{
    public class EateryWhitelistMap : EntityTypeConfiguration<EateryWhitelist>
    {
        public EateryWhitelistMap()
        {
            // Primary Key
            this.HasKey(t => new { t.devNo, t.card_no, t.status });

            // Properties
            this.Property(t => t.devNo)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.cust_name)
                .HasMaxLength(50);

            this.Property(t => t.card_no)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.status)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("EateryWhitelist");
            this.Property(t => t.devNo).HasColumnName("devNo");
            this.Property(t => t.cust_name).HasColumnName("cust_name");
            this.Property(t => t.LevelNo).HasColumnName("LevelNo");
            this.Property(t => t.card_no).HasColumnName("card_no");
            this.Property(t => t.cust_no).HasColumnName("cust_no");
            this.Property(t => t.balance).HasColumnName("balance");
            this.Property(t => t.validdt).HasColumnName("validdt");
            this.Property(t => t.createdt).HasColumnName("createdt");
            this.Property(t => t.status).HasColumnName("status");
            this.Property(t => t.flag).HasColumnName("flag");
        }
    }
}
