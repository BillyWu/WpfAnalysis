using System;
using System.Collections.Generic;

namespace EFToolConvertYKTToCode.Models
{
    public partial class PA_tboLocal
    {
        public int SeqNO { get; set; }
        public Nullable<int> Region { get; set; }
        public string Name { get; set; }
        public Nullable<int> SchemeNO { get; set; }
        public Nullable<int> GateNO { get; set; }
        public Nullable<int> InOutFlag { get; set; }
        public Nullable<int> MonthCarOpenType { get; set; }
        public Nullable<int> FreeCarOpenType { get; set; }
        public Nullable<int> TempCarOpenType { get; set; }
        public Nullable<int> MoneyCarOpenType { get; set; }
        public Nullable<int> VerifyCarNO { get; set; }
        public string RecogniseIP { get; set; }
        public Nullable<int> ExportNO { get; set; }
        public Nullable<bool> UsedAV { get; set; }
        public string Memo { get; set; }
        public Nullable<int> ScreenType { get; set; }
        public string ScreenCOM { get; set; }
        public string ScreenIP { get; set; }
        public Nullable<int> ScreenID { get; set; }
        public Nullable<int> Quality { get; set; }
        public Nullable<int> OpenGateType { get; set; }
        public string OpenGateCOM { get; set; }
        public Nullable<int> OpenGatePort { get; set; }
        public Nullable<int> ScreenPort { get; set; }
        public Nullable<int> AVNO { get; set; }
        public Nullable<int> SpeechType { get; set; }
        public string VideoSource { get; set; }
        public string CameraIP { get; set; }
        public Nullable<int> CameraPort { get; set; }
        public string CameraUsername { get; set; }
        public string CameraPassword { get; set; }
        public Nullable<System.DateTime> BeginTime { get; set; }
        public Nullable<int> CarID { get; set; }
        public Nullable<System.DateTime> DownLstTime { get; set; }
        public string VoiceModuleCom { get; set; }
        public Nullable<int> VoiceModuleID { get; set; }
        public Nullable<int> park_no { get; set; }
        public Nullable<int> inside_park { get; set; }
        public Nullable<int> passBH { get; set; }
        public Nullable<bool> NonBlock { get; set; }
    }
}
