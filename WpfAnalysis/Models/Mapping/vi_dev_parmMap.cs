using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EFToolConvertYKTToCode.Models.Mapping
{
    public class vi_dev_parmMap : EntityTypeConfiguration<vi_dev_parm>
    {
        public vi_dev_parmMap()
        {
            // Primary Key
            this.HasKey(t => t.dev_id);

            // Properties
            this.Property(t => t.dev_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.sysflag)
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.commpass)
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.syspass)
                .IsFixedLength()
                .HasMaxLength(6);

            this.Property(t => t.userpass)
                .IsFixedLength()
                .HasMaxLength(6);

            this.Property(t => t.light)
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("vi_dev_parm");
            this.Property(t => t.dev_id).HasColumnName("dev_id");
            this.Property(t => t.sysflag).HasColumnName("sysflag");
            this.Property(t => t.commpass).HasColumnName("commpass");
            this.Property(t => t.syspass).HasColumnName("syspass");
            this.Property(t => t.userpass).HasColumnName("userpass");
            this.Property(t => t.card_left).HasColumnName("card_left");
            this.Property(t => t.stall_num).HasColumnName("stall_num");
            this.Property(t => t.user_info).HasColumnName("user_info");
            this.Property(t => t.disp_delay).HasColumnName("disp_delay");
            this.Property(t => t.temp_card).HasColumnName("temp_card");
            this.Property(t => t.currency).HasColumnName("currency");
            this.Property(t => t.in_overflow).HasColumnName("in_overflow");
            this.Property(t => t.ext_dev).HasColumnName("ext_dev");
            this.Property(t => t.allow_go).HasColumnName("allow_go");
            this.Property(t => t.dev_attr).HasColumnName("dev_attr");
            this.Property(t => t.stall_in_use).HasColumnName("stall_in_use");
            this.Property(t => t.allow_card).HasColumnName("allow_card");
            this.Property(t => t.gate_select).HasColumnName("gate_select");
            this.Property(t => t.valid_days).HasColumnName("valid_days");
            this.Property(t => t.balance_left).HasColumnName("balance_left");
            this.Property(t => t.united_charge).HasColumnName("united_charge");
            this.Property(t => t.inout).HasColumnName("inout");
            this.Property(t => t.offline).HasColumnName("offline");
            this.Property(t => t.light).HasColumnName("light");
            this.Property(t => t.reserve_num).HasColumnName("reserve_num");
        }
    }
}
