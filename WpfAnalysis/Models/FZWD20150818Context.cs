using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using EFToolConvertYKTToCode.Models.Mapping;

namespace EFToolConvertYKTToCode.Models
{
    public partial class FZWD20150818Context : DbContext
    {
        static FZWD20150818Context()
        {
            Database.SetInitializer<FZWD20150818Context>(null);
        }

        public FZWD20150818Context()
            : base("Name=FZWD20150818Context")
        {
        }

        public DbSet<car_no> car_no { get; set; }
        public DbSet<car_type> car_type { get; set; }
        public DbSet<card_charge> card_charge { get; set; }
        public DbSet<card_delay> card_delay { get; set; }
        public DbSet<card_lost> card_lost { get; set; }
        public DbSet<card_make> card_make { get; set; }
        public DbSet<card_quit> card_quit { get; set; }
        public DbSet<Card_quit_Pay> Card_quit_Pay { get; set; }
        public DbSet<card_status> card_status { get; set; }
        public DbSet<card_type> card_type { get; set; }
        public DbSet<CardRecharge> CardRecharges { get; set; }
        public DbSet<color_type> color_type { get; set; }
        public DbSet<customer> customers { get; set; }
        public DbSet<device> devices { get; set; }
        public DbSet<devtype> devtypes { get; set; }
        public DbSet<door_card_make> door_card_make { get; set; }
        public DbSet<door_dev_parm> door_dev_parm { get; set; }
        public DbSet<dtproperty> dtproperties { get; set; }
        public DbSet<EateryCardPay> EateryCardPays { get; set; }
        public DbSet<EateryComputer> EateryComputers { get; set; }
        public DbSet<EateryCstDinRec> EateryCstDinRecs { get; set; }
        public DbSet<EateryCustLevel> EateryCustLevels { get; set; }
        public DbSet<EateryDevice> EateryDevices { get; set; }
        public DbSet<EateryDevicePrice> EateryDevicePrices { get; set; }
        public DbSet<EateryDeviceSet> EateryDeviceSets { get; set; }
        public DbSet<EateryDeviceTime> EateryDeviceTimes { get; set; }
        public DbSet<EateryDinner> EateryDinners { get; set; }
        public DbSet<EateryDinnerAdd> EateryDinnerAdds { get; set; }
        public DbSet<EateryLevelSet> EateryLevelSets { get; set; }
        public DbSet<EateryWhitelist> EateryWhitelists { get; set; }
        public DbSet<fee_std> fee_std { get; set; }
        public DbSet<handoperator> handoperators { get; set; }
        public DbSet<hmd> hmds { get; set; }
        public DbSet<hmd_list> hmd_list { get; set; }
        public DbSet<in_park> in_park { get; set; }
        public DbSet<in_park_history> in_park_history { get; set; }
        public DbSet<InvalidOpenGate> InvalidOpenGates { get; set; }
        public DbSet<kq_chuCai> kq_chuCai { get; set; }
        public DbSet<kq_daKa> kq_daKa { get; set; }
        public DbSet<kq_daKaH> kq_daKaH { get; set; }
        public DbSet<kq_dept> kq_dept { get; set; }
        public DbSet<kq_deptWork> kq_deptWork { get; set; }
        public DbSet<kq_history> kq_history { get; set; }
        public DbSet<kq_holiday> kq_holiday { get; set; }
        public DbSet<kq_huiZongH> kq_huiZongH { get; set; }
        public DbSet<kq_jiaBan> kq_jiaBan { get; set; }
        public DbSet<kq_mingXiH> kq_mingXiH { get; set; }
        public DbSet<kq_qianKa> kq_qianKa { get; set; }
        public DbSet<kq_qingJia> kq_qingJia { get; set; }
        public DbSet<kq_rule> kq_rule { get; set; }
        public DbSet<kq_work> kq_work { get; set; }
        public DbSet<kq_workQueueH> kq_workQueueH { get; set; }
        public DbSet<kq_wrkHoliday> kq_wrkHoliday { get; set; }
        public DbSet<lift_card_make> lift_card_make { get; set; }
        public DbSet<lift_info> lift_info { get; set; }
        public DbSet<lift_price> lift_price { get; set; }
        public DbSet<lift_record> lift_record { get; set; }
        public DbSet<log> logs { get; set; }
        public DbSet<M_ContrlNo> M_ContrlNo { get; set; }
        public DbSet<M_ControlDefine> M_ControlDefine { get; set; }
        public DbSet<M_controlStall> M_controlStall { get; set; }
        public DbSet<M_log> M_log { get; set; }
        public DbSet<M_Record> M_Record { get; set; }
        public DbSet<M_Record_history> M_Record_history { get; set; }
        public DbSet<M_Time> M_Time { get; set; }
        public DbSet<M_TimeTask> M_TimeTask { get; set; }
        public DbSet<operator1> operators { get; set; }
        public DbSet<operator_right> operator_right { get; set; }
        public DbSet<out_park> out_park { get; set; }
        public DbSet<out_park_history> out_park_history { get; set; }
        public DbSet<PA_tboDevice> PA_tboDevice { get; set; }
        public DbSet<PA_tboLocal> PA_tboLocal { get; set; }
        public DbSet<PA_tboScheme> PA_tboScheme { get; set; }
        public DbSet<park> parks { get; set; }
        public DbSet<Park_Auto_Pay_Record> Park_Auto_Pay_Record { get; set; }
        public DbSet<park_card_make> park_card_make { get; set; }
        public DbSet<park_central_pay> park_central_pay { get; set; }
        public DbSet<park_dev_parm> park_dev_parm { get; set; }
        public DbSet<Park_Device_State> Park_Device_State { get; set; }
        public DbSet<park_pay_bill> park_pay_bill { get; set; }
        public DbSet<Park_Pay_Device> Park_Pay_Device { get; set; }
        public DbSet<park_stall> park_stall { get; set; }
        public DbSet<park_timesec> park_timesec { get; set; }
        public DbSet<parking> parkings { get; set; }
        public DbSet<parkingInside> parkingInsides { get; set; }
        public DbSet<parkingless520> parkingless520 { get; set; }
        public DbSet<ParkSearch_area_dictionary> ParkSearch_area_dictionary { get; set; }
        public DbSet<Parksearch_Area_line> Parksearch_Area_line { get; set; }
        public DbSet<ParkSearch_car_log> ParkSearch_car_log { get; set; }
        public DbSet<ParkSearch_car_record> ParkSearch_car_record { get; set; }
        public DbSet<ParkSearch_map> ParkSearch_map { get; set; }
        public DbSet<Parksearch_pos> Parksearch_pos { get; set; }
        public DbSet<Parksearch_recognizer> Parksearch_recognizer { get; set; }
        public DbSet<PayMethod> PayMethods { get; set; }
        public DbSet<remote_control> remote_control { get; set; }
        public DbSet<stall_occuppy> stall_occuppy { get; set; }
        public DbSet<subsystem> subsystems { get; set; }
        public DbSet<sysindex> sysindexes { get; set; }
        public DbSet<SystemSet> SystemSets { get; set; }
        public DbSet<Table_AliasOfPlate> Table_AliasOfPlate { get; set; }
        public DbSet<Table_MoneyDiscount> Table_MoneyDiscount { get; set; }
        public DbSet<Table_PointDiscount> Table_PointDiscount { get; set; }
        public DbSet<Table_Visitor> Table_Visitor { get; set; }
        public DbSet<Table_XML> Table_XML { get; set; }
        public DbSet<Ticket_Info> Ticket_Info { get; set; }
        public DbSet<white_list> white_list { get; set; }
        public DbSet<white_list2> white_list2 { get; set; }
        public DbSet<wkczyq> wkczyqs { get; set; }
        public DbSet<xg_line> xg_line { get; set; }
        public DbSet<xg_node> xg_node { get; set; }
        public DbSet<xg_plan> xg_plan { get; set; }
        public DbSet<xg_plan_detail> xg_plan_detail { get; set; }
        public DbSet<custoper> custopers { get; set; }
        public DbSet<V_controldefine> V_controldefine { get; set; }
        public DbSet<V_controldefine1> V_controldefine1 { get; set; }
        public DbSet<V_DoorHmdList> V_DoorHmdList { get; set; }
        public DbSet<V_DoorWhiteList> V_DoorWhiteList { get; set; }
        public DbSet<V_Lift_Card_Info> V_Lift_Card_Info { get; set; }
        public DbSet<V_Lift_Record> V_Lift_Record { get; set; }
        public DbSet<v_log> v_log { get; set; }
        public DbSet<V_OUT_PARK> V_OUT_PARK { get; set; }
        public DbSet<V_out_park_history> V_out_park_history { get; set; }
        public DbSet<VcardKind> VcardKinds { get; set; }
        public DbSet<vCardLostRpt> vCardLostRpts { get; set; }
        public DbSet<vCardMake> vCardMakes { get; set; }
        public DbSet<vCardPayRpt> vCardPayRpts { get; set; }
        public DbSet<vCardQuitRpt> vCardQuitRpts { get; set; }
        public DbSet<vComputer> vComputers { get; set; }
        public DbSet<vCustCard> vCustCards { get; set; }
        public DbSet<vCustCard2> vCustCard2 { get; set; }
        public DbSet<vCustCard3> vCustCard3 { get; set; }
        public DbSet<vcustomer> vcustomers { get; set; }
        public DbSet<vDevice> vDevices { get; set; }
        public DbSet<vDeviceTime> vDeviceTimes { get; set; }
        public DbSet<vDinnerAdd> vDinnerAdds { get; set; }
        public DbSet<vEatery_quit_pay> vEatery_quit_pay { get; set; }
        public DbSet<vEateryCstDinRec> vEateryCstDinRecs { get; set; }
        public DbSet<vEateryDinner> vEateryDinners { get; set; }
        public DbSet<vEaterylevelset> vEaterylevelsets { get; set; }
        public DbSet<vEateryPay> vEateryPays { get; set; }
        public DbSet<vEateryPayQuit> vEateryPayQuits { get; set; }
        public DbSet<vi_dev_parm> vi_dev_parm { get; set; }
        public DbSet<VKQ_daka> VKQ_daka { get; set; }
        public DbSet<VKQ_dakaH> VKQ_dakaH { get; set; }
        public DbSet<VKQ_deptWork> VKQ_deptWork { get; set; }
        public DbSet<VKQ_History> VKQ_History { get; set; }
        public DbSet<VKQ_mingxi> VKQ_mingxi { get; set; }
        public DbSet<VKQ_mingxiH> VKQ_mingxiH { get; set; }
        public DbSet<VKQ_wrkQueue> VKQ_wrkQueue { get; set; }
        public DbSet<VKQ_wrkQueueH> VKQ_wrkQueueH { get; set; }
        public DbSet<vLiftRecord> vLiftRecords { get; set; }
        public DbSet<vParkWhiteList> vParkWhiteLists { get; set; }
        public DbSet<vRealControl> vRealControls { get; set; }
        public DbSet<vTableInfo> vTableInfoes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new car_noMap());
            modelBuilder.Configurations.Add(new car_typeMap());
            modelBuilder.Configurations.Add(new card_chargeMap());
            modelBuilder.Configurations.Add(new card_delayMap());
            modelBuilder.Configurations.Add(new card_lostMap());
            modelBuilder.Configurations.Add(new card_makeMap());
            modelBuilder.Configurations.Add(new card_quitMap());
            modelBuilder.Configurations.Add(new Card_quit_PayMap());
            modelBuilder.Configurations.Add(new card_statusMap());
            modelBuilder.Configurations.Add(new card_typeMap());
            modelBuilder.Configurations.Add(new CardRechargeMap());
            modelBuilder.Configurations.Add(new color_typeMap());
            modelBuilder.Configurations.Add(new customerMap());
            modelBuilder.Configurations.Add(new deviceMap());
            modelBuilder.Configurations.Add(new devtypeMap());
            modelBuilder.Configurations.Add(new door_card_makeMap());
            modelBuilder.Configurations.Add(new door_dev_parmMap());
            modelBuilder.Configurations.Add(new dtpropertyMap());
            modelBuilder.Configurations.Add(new EateryCardPayMap());
            modelBuilder.Configurations.Add(new EateryComputerMap());
            modelBuilder.Configurations.Add(new EateryCstDinRecMap());
            modelBuilder.Configurations.Add(new EateryCustLevelMap());
            modelBuilder.Configurations.Add(new EateryDeviceMap());
            modelBuilder.Configurations.Add(new EateryDevicePriceMap());
            modelBuilder.Configurations.Add(new EateryDeviceSetMap());
            modelBuilder.Configurations.Add(new EateryDeviceTimeMap());
            modelBuilder.Configurations.Add(new EateryDinnerMap());
            modelBuilder.Configurations.Add(new EateryDinnerAddMap());
            modelBuilder.Configurations.Add(new EateryLevelSetMap());
            modelBuilder.Configurations.Add(new EateryWhitelistMap());
            modelBuilder.Configurations.Add(new fee_stdMap());
            modelBuilder.Configurations.Add(new handoperatorMap());
            modelBuilder.Configurations.Add(new hmdMap());
            modelBuilder.Configurations.Add(new hmd_listMap());
            modelBuilder.Configurations.Add(new in_parkMap());
            modelBuilder.Configurations.Add(new in_park_historyMap());
            modelBuilder.Configurations.Add(new InvalidOpenGateMap());
            modelBuilder.Configurations.Add(new kq_chuCaiMap());
            modelBuilder.Configurations.Add(new kq_daKaMap());
            modelBuilder.Configurations.Add(new kq_daKaHMap());
            modelBuilder.Configurations.Add(new kq_deptMap());
            modelBuilder.Configurations.Add(new kq_deptWorkMap());
            modelBuilder.Configurations.Add(new kq_historyMap());
            modelBuilder.Configurations.Add(new kq_holidayMap());
            modelBuilder.Configurations.Add(new kq_huiZongHMap());
            modelBuilder.Configurations.Add(new kq_jiaBanMap());
            modelBuilder.Configurations.Add(new kq_mingXiHMap());
            modelBuilder.Configurations.Add(new kq_qianKaMap());
            modelBuilder.Configurations.Add(new kq_qingJiaMap());
            modelBuilder.Configurations.Add(new kq_ruleMap());
            modelBuilder.Configurations.Add(new kq_workMap());
            modelBuilder.Configurations.Add(new kq_workQueueHMap());
            modelBuilder.Configurations.Add(new kq_wrkHolidayMap());
            modelBuilder.Configurations.Add(new lift_card_makeMap());
            modelBuilder.Configurations.Add(new lift_infoMap());
            modelBuilder.Configurations.Add(new lift_priceMap());
            modelBuilder.Configurations.Add(new lift_recordMap());
            modelBuilder.Configurations.Add(new logMap());
            modelBuilder.Configurations.Add(new M_ContrlNoMap());
            modelBuilder.Configurations.Add(new M_ControlDefineMap());
            modelBuilder.Configurations.Add(new M_controlStallMap());
            modelBuilder.Configurations.Add(new M_logMap());
            modelBuilder.Configurations.Add(new M_RecordMap());
            modelBuilder.Configurations.Add(new M_Record_historyMap());
            modelBuilder.Configurations.Add(new M_TimeMap());
            modelBuilder.Configurations.Add(new M_TimeTaskMap());
            modelBuilder.Configurations.Add(new operatorMap());
            modelBuilder.Configurations.Add(new operator_rightMap());
            modelBuilder.Configurations.Add(new out_parkMap());
            modelBuilder.Configurations.Add(new out_park_historyMap());
            modelBuilder.Configurations.Add(new PA_tboDeviceMap());
            modelBuilder.Configurations.Add(new PA_tboLocalMap());
            modelBuilder.Configurations.Add(new PA_tboSchemeMap());
            modelBuilder.Configurations.Add(new parkMap());
            modelBuilder.Configurations.Add(new Park_Auto_Pay_RecordMap());
            modelBuilder.Configurations.Add(new park_card_makeMap());
            modelBuilder.Configurations.Add(new park_central_payMap());
            modelBuilder.Configurations.Add(new park_dev_parmMap());
            modelBuilder.Configurations.Add(new Park_Device_StateMap());
            modelBuilder.Configurations.Add(new park_pay_billMap());
            modelBuilder.Configurations.Add(new Park_Pay_DeviceMap());
            modelBuilder.Configurations.Add(new park_stallMap());
            modelBuilder.Configurations.Add(new park_timesecMap());
            modelBuilder.Configurations.Add(new parkingMap());
            modelBuilder.Configurations.Add(new parkingInsideMap());
            modelBuilder.Configurations.Add(new parkingless520Map());
            modelBuilder.Configurations.Add(new ParkSearch_area_dictionaryMap());
            modelBuilder.Configurations.Add(new Parksearch_Area_lineMap());
            modelBuilder.Configurations.Add(new ParkSearch_car_logMap());
            modelBuilder.Configurations.Add(new ParkSearch_car_recordMap());
            modelBuilder.Configurations.Add(new ParkSearch_mapMap());
            modelBuilder.Configurations.Add(new Parksearch_posMap());
            modelBuilder.Configurations.Add(new Parksearch_recognizerMap());
            modelBuilder.Configurations.Add(new PayMethodMap());
            modelBuilder.Configurations.Add(new remote_controlMap());
            modelBuilder.Configurations.Add(new stall_occuppyMap());
            modelBuilder.Configurations.Add(new subsystemMap());
            modelBuilder.Configurations.Add(new sysindexMap());
            modelBuilder.Configurations.Add(new SystemSetMap());
            modelBuilder.Configurations.Add(new Table_AliasOfPlateMap());
            modelBuilder.Configurations.Add(new Table_MoneyDiscountMap());
            modelBuilder.Configurations.Add(new Table_PointDiscountMap());
            modelBuilder.Configurations.Add(new Table_VisitorMap());
            modelBuilder.Configurations.Add(new Table_XMLMap());
            modelBuilder.Configurations.Add(new Ticket_InfoMap());
            modelBuilder.Configurations.Add(new white_listMap());
            modelBuilder.Configurations.Add(new white_list2Map());
            modelBuilder.Configurations.Add(new wkczyqMap());
            modelBuilder.Configurations.Add(new xg_lineMap());
            modelBuilder.Configurations.Add(new xg_nodeMap());
            modelBuilder.Configurations.Add(new xg_planMap());
            modelBuilder.Configurations.Add(new xg_plan_detailMap());
            modelBuilder.Configurations.Add(new custoperMap());
            modelBuilder.Configurations.Add(new V_controldefineMap());
            modelBuilder.Configurations.Add(new V_controldefine1Map());
            modelBuilder.Configurations.Add(new V_DoorHmdListMap());
            modelBuilder.Configurations.Add(new V_DoorWhiteListMap());
            modelBuilder.Configurations.Add(new V_Lift_Card_InfoMap());
            modelBuilder.Configurations.Add(new V_Lift_RecordMap());
            modelBuilder.Configurations.Add(new v_logMap());
            modelBuilder.Configurations.Add(new V_OUT_PARKMap());
            modelBuilder.Configurations.Add(new V_out_park_historyMap());
            modelBuilder.Configurations.Add(new VcardKindMap());
            modelBuilder.Configurations.Add(new vCardLostRptMap());
            modelBuilder.Configurations.Add(new vCardMakeMap());
            modelBuilder.Configurations.Add(new vCardPayRptMap());
            modelBuilder.Configurations.Add(new vCardQuitRptMap());
            modelBuilder.Configurations.Add(new vComputerMap());
            modelBuilder.Configurations.Add(new vCustCardMap());
            modelBuilder.Configurations.Add(new vCustCard2Map());
            modelBuilder.Configurations.Add(new vCustCard3Map());
            modelBuilder.Configurations.Add(new vcustomerMap());
            modelBuilder.Configurations.Add(new vDeviceMap());
            modelBuilder.Configurations.Add(new vDeviceTimeMap());
            modelBuilder.Configurations.Add(new vDinnerAddMap());
            modelBuilder.Configurations.Add(new vEatery_quit_payMap());
            modelBuilder.Configurations.Add(new vEateryCstDinRecMap());
            modelBuilder.Configurations.Add(new vEateryDinnerMap());
            modelBuilder.Configurations.Add(new vEaterylevelsetMap());
            modelBuilder.Configurations.Add(new vEateryPayMap());
            modelBuilder.Configurations.Add(new vEateryPayQuitMap());
            modelBuilder.Configurations.Add(new vi_dev_parmMap());
            modelBuilder.Configurations.Add(new VKQ_dakaMap());
            modelBuilder.Configurations.Add(new VKQ_dakaHMap());
            modelBuilder.Configurations.Add(new VKQ_deptWorkMap());
            modelBuilder.Configurations.Add(new VKQ_HistoryMap());
            modelBuilder.Configurations.Add(new VKQ_mingxiMap());
            modelBuilder.Configurations.Add(new VKQ_mingxiHMap());
            modelBuilder.Configurations.Add(new VKQ_wrkQueueMap());
            modelBuilder.Configurations.Add(new VKQ_wrkQueueHMap());
            modelBuilder.Configurations.Add(new vLiftRecordMap());
            modelBuilder.Configurations.Add(new vParkWhiteListMap());
            modelBuilder.Configurations.Add(new vRealControlMap());
            modelBuilder.Configurations.Add(new vTableInfoMap());
        }
    }
}
