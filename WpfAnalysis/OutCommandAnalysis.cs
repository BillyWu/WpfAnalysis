using EFToolConvertYKTToCode.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfAnalysis
{
    public class OutCommandAnalysis : CommandBase
    {
        private OutAnalysisViewModel _viewModel;
        public OutCommandAnalysis(OutAnalysisViewModel viewModel)
        {
            _viewModel = viewModel;
        }

        public override void PerformCommand(object parameter)
        {
            try
            {
                using (var context = new FZWD20150818Context())
                {
                    //DateTime dtStartDT = DateTime.Parse(((DateTime)_viewModel.AnalysisStartDate).ToString("yyyy-MM-dd ")
                    //        + ((DateTime)_viewModel.AnalysisStartTime).ToString("HH:mm:00"));
                    //DateTime dtEndDT = DateTime.Parse(((DateTime)_viewModel.AnalysisEndDate).ToString("yyyy-MM-dd ")
                    //        + ((DateTime)_viewModel.AnalysisEndTime).ToString("HH:mm:00"));
                    DateTime dtStartDT = (DateTime)_viewModel.AnalysisStartDateTime;
                    DateTime dtEndDT = (DateTime)_viewModel.AnalysisEndDateTime;

                    var listRecord = context.out_park.Where(x => x.out_time >= dtStartDT && x.out_time <= dtEndDT).ToList();
                    _viewModel.CollectionCount = listRecord.Count;
                    _viewModel.OutCollection.Clear();
                    foreach(var record in listRecord)
                    {
                        string personCode = "";
                        string personName = "";
                        string cardNo = "";
                        var oParkCardMake = context.park_card_make.Where(x => x.card_no == record.card_no).FirstOrDefault();
                        if (oParkCardMake != null)
                        {
                            cardNo = oParkCardMake.card_no.ToString();
                            var oCustomer = context.customers.Find(oParkCardMake.cust_no);
                            if (oCustomer != null)
                            {
                                personCode = oCustomer.cust_nick;
                                personName = oCustomer.cust_name;
                            }
                        }

                        _viewModel.OutCollection.Add(new OutViewModel() {
                            PersonCode = personCode,
                            PersonName = personName,
                            CardNo = cardNo,
                            CardType = ((EnumCardType)record.card_tid).ToString(),
                            CarType = ((EnumCarType)record.car_tid).ToString(),
                            CarNo = record.carno,
                            OutPic = record.out_pic,
                            InTime = record.in_time,
                            OutTime = record.out_time,
                            OutFrom = record.out_from,
                            ActualIncome = record.money2,
                            OperatorName = record.@operator,
                            OutParkRecord = record
                        });
                    }
                }
            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
