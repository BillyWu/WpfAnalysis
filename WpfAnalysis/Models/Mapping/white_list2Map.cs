using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EFToolConvertYKTToCode.Models.Mapping
{
    public class white_list2Map : EntityTypeConfiguration<white_list2>
    {
        public white_list2Map()
        {
            // Primary Key
            this.HasKey(t => new { t.devID, t.card_no });

            // Properties
            this.Property(t => t.devID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.card_no)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Pwd)
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("white_list2");
            this.Property(t => t.devID).HasColumnName("devID");
            this.Property(t => t.card_no).HasColumnName("card_no");
            this.Property(t => t.status).HasColumnName("status");
            this.Property(t => t.bDate).HasColumnName("bDate");
            this.Property(t => t.eDate).HasColumnName("eDate");
            this.Property(t => t.TimeNo).HasColumnName("TimeNo");
            this.Property(t => t.Pwd).HasColumnName("Pwd");
            this.Property(t => t.FxDate).HasColumnName("FxDate");
        }
    }
}
