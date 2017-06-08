using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EFToolConvertYKTToCode.Models.Mapping
{
    public class vCardMakeMap : EntityTypeConfiguration<vCardMake>
    {
        public vCardMakeMap()
        {
            // Primary Key
            this.HasKey(t => new { t.card_no, t.cust_no, t.LevelNo });

            // Properties
            this.Property(t => t.card_no)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.cust_no)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.@operator)
                .HasMaxLength(10);

            this.Property(t => t.LevelNo)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.LevelName)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("vCardMake");
            this.Property(t => t.card_no).HasColumnName("card_no");
            this.Property(t => t.cust_no).HasColumnName("cust_no");
            this.Property(t => t.foregift).HasColumnName("foregift");
            this.Property(t => t.balance).HasColumnName("balance");
            this.Property(t => t.validdt).HasColumnName("validdt");
            this.Property(t => t.status).HasColumnName("status");
            this.Property(t => t.@operator).HasColumnName("operator");
            this.Property(t => t.createdt).HasColumnName("createdt");
            this.Property(t => t.LevelNo).HasColumnName("LevelNo");
            this.Property(t => t.LevelName).HasColumnName("LevelName");
            this.Property(t => t.MaxCnt).HasColumnName("MaxCnt");
            this.Property(t => t.MaxAmt).HasColumnName("MaxAmt");
            this.Property(t => t.Percent).HasColumnName("Percent");
            this.Property(t => t.ISOverMaxAmt).HasColumnName("ISOverMaxAmt");
            this.Property(t => t.state).HasColumnName("state");
            this.Property(t => t.breakTimes).HasColumnName("breakTimes");
            this.Property(t => t.lunchTimes).HasColumnName("lunchTimes");
            this.Property(t => t.supperTimes).HasColumnName("supperTimes");
            this.Property(t => t.amt1).HasColumnName("amt1");
            this.Property(t => t.amt2).HasColumnName("amt2");
            this.Property(t => t.amt3).HasColumnName("amt3");
            this.Property(t => t.amt4).HasColumnName("amt4");
        }
    }
}
