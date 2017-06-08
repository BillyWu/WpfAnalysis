using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EFToolConvertYKTToCode.Models.Mapping
{
    public class PA_tboLocalMap : EntityTypeConfiguration<PA_tboLocal>
    {
        public PA_tboLocalMap()
        {
            // Primary Key
            this.HasKey(t => t.SeqNO);

            // Properties
            this.Property(t => t.Name)
                .HasMaxLength(50);

            this.Property(t => t.RecogniseIP)
                .HasMaxLength(50);

            this.Property(t => t.Memo)
                .HasMaxLength(1000);

            this.Property(t => t.ScreenCOM)
                .HasMaxLength(50);

            this.Property(t => t.ScreenIP)
                .HasMaxLength(50);

            this.Property(t => t.OpenGateCOM)
                .HasMaxLength(50);

            this.Property(t => t.VideoSource)
                .HasMaxLength(50);

            this.Property(t => t.CameraIP)
                .HasMaxLength(50);

            this.Property(t => t.CameraUsername)
                .HasMaxLength(50);

            this.Property(t => t.CameraPassword)
                .HasMaxLength(50);

            this.Property(t => t.VoiceModuleCom)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("PA_tboLocal");
            this.Property(t => t.SeqNO).HasColumnName("SeqNO");
            this.Property(t => t.Region).HasColumnName("Region");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.SchemeNO).HasColumnName("SchemeNO");
            this.Property(t => t.GateNO).HasColumnName("GateNO");
            this.Property(t => t.InOutFlag).HasColumnName("InOutFlag");
            this.Property(t => t.MonthCarOpenType).HasColumnName("MonthCarOpenType");
            this.Property(t => t.FreeCarOpenType).HasColumnName("FreeCarOpenType");
            this.Property(t => t.TempCarOpenType).HasColumnName("TempCarOpenType");
            this.Property(t => t.MoneyCarOpenType).HasColumnName("MoneyCarOpenType");
            this.Property(t => t.VerifyCarNO).HasColumnName("VerifyCarNO");
            this.Property(t => t.RecogniseIP).HasColumnName("RecogniseIP");
            this.Property(t => t.ExportNO).HasColumnName("ExportNO");
            this.Property(t => t.UsedAV).HasColumnName("UsedAV");
            this.Property(t => t.Memo).HasColumnName("Memo");
            this.Property(t => t.ScreenType).HasColumnName("ScreenType");
            this.Property(t => t.ScreenCOM).HasColumnName("ScreenCOM");
            this.Property(t => t.ScreenIP).HasColumnName("ScreenIP");
            this.Property(t => t.ScreenID).HasColumnName("ScreenID");
            this.Property(t => t.Quality).HasColumnName("Quality");
            this.Property(t => t.OpenGateType).HasColumnName("OpenGateType");
            this.Property(t => t.OpenGateCOM).HasColumnName("OpenGateCOM");
            this.Property(t => t.OpenGatePort).HasColumnName("OpenGatePort");
            this.Property(t => t.ScreenPort).HasColumnName("ScreenPort");
            this.Property(t => t.AVNO).HasColumnName("AVNO");
            this.Property(t => t.SpeechType).HasColumnName("SpeechType");
            this.Property(t => t.VideoSource).HasColumnName("VideoSource");
            this.Property(t => t.CameraIP).HasColumnName("CameraIP");
            this.Property(t => t.CameraPort).HasColumnName("CameraPort");
            this.Property(t => t.CameraUsername).HasColumnName("CameraUsername");
            this.Property(t => t.CameraPassword).HasColumnName("CameraPassword");
            this.Property(t => t.BeginTime).HasColumnName("BeginTime");
            this.Property(t => t.CarID).HasColumnName("CarID");
            this.Property(t => t.DownLstTime).HasColumnName("DownLstTime");
            this.Property(t => t.VoiceModuleCom).HasColumnName("VoiceModuleCom");
            this.Property(t => t.VoiceModuleID).HasColumnName("VoiceModuleID");
            this.Property(t => t.park_no).HasColumnName("park_no");
            this.Property(t => t.inside_park).HasColumnName("inside_park");
            this.Property(t => t.passBH).HasColumnName("passBH");
            this.Property(t => t.NonBlock).HasColumnName("NonBlock");
        }
    }
}
