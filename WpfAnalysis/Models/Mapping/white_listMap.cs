using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EFToolConvertYKTToCode.Models.Mapping
{
    public class white_listMap : EntityTypeConfiguration<white_list>
    {
        public white_listMap()
        {
            // Primary Key
            this.HasKey(t => new { t.dev_id, t.card_no });

            // Properties
            this.Property(t => t.dev_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.card_no)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.carno)
                .HasMaxLength(15);

            // Table & Column Mappings
            this.ToTable("white_list");
            this.Property(t => t.dev_id).HasColumnName("dev_id");
            this.Property(t => t.card_no).HasColumnName("card_no");
            this.Property(t => t.card_type).HasColumnName("card_type");
            this.Property(t => t.car_type).HasColumnName("car_type");
            this.Property(t => t.park_stall).HasColumnName("park_stall");
            this.Property(t => t.timesec).HasColumnName("timesec");
            this.Property(t => t.validdt).HasColumnName("validdt");
            this.Property(t => t.carno).HasColumnName("carno");
            this.Property(t => t.status).HasColumnName("status");
            this.Property(t => t.cust_no).HasColumnName("cust_no");
        }
    }
}
