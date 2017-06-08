using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EFToolConvertYKTToCode.Models.Mapping
{
    public class park_card_makeMap : EntityTypeConfiguration<park_card_make>
    {
        public park_card_makeMap()
        {
            // Primary Key
            this.HasKey(t => new { t.card_no, t.cust_no });

            // Properties
            this.Property(t => t.card_no)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.cust_no)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.carno)
                .HasMaxLength(15);

            this.Property(t => t.remark)
                .HasMaxLength(60);

            this.Property(t => t.matchDevStr)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("park_card_make");
            this.Property(t => t.card_no).HasColumnName("card_no");
            this.Property(t => t.cust_no).HasColumnName("cust_no");
            this.Property(t => t.card_type).HasColumnName("card_type");
            this.Property(t => t.car_type).HasColumnName("car_type");
            this.Property(t => t.car_color).HasColumnName("car_color");
            this.Property(t => t.carno).HasColumnName("carno");
            this.Property(t => t.park).HasColumnName("park");
            this.Property(t => t.park_stall).HasColumnName("park_stall");
            this.Property(t => t.park_stall1).HasColumnName("park_stall1");
            this.Property(t => t.park_stall2).HasColumnName("park_stall2");
            this.Property(t => t.timesec).HasColumnName("timesec");
            this.Property(t => t.remark).HasColumnName("remark");
            this.Property(t => t.matchDevStr).HasColumnName("matchDevStr");
        }
    }
}
