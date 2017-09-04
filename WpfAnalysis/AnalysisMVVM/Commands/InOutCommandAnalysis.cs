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
    public class InOutCommandAnalysis : CommandBase
    {
        private InOutAnalysisViewModel _viewModel;
        private Type _type;
        public InOutCommandAnalysis(InOutAnalysisViewModel viewModel, Type oType)
        {
            _viewModel = viewModel;
            _type = oType;
        }

        public override void PerformCommand(object parameter)
        {
            try
            {
                using (var context = new FZWD20150818Context())
                {
                    DateTime dtStartDT = (DateTime)_viewModel.AnalysisStartDateTime;
                    DateTime dtEndDT = (DateTime)_viewModel.AnalysisEndDateTime;

                    if (_type == typeof(OutAnalysis))
                    {
                        List<out_park> listRecord = null;
                        if (_viewModel.SelectedCardType == EnumCardType.全部)
                        {
                            listRecord = context.out_park.Where(x => x.out_time >= dtStartDT
                                                                    && x.out_time <= dtEndDT)
                                                            .OrderByDescending(x => x.out_time)
                                                            .ToList();
                        }
                        else
                        {
                            listRecord = context.out_park.Where(x => x.out_time >= dtStartDT
                                                                    && x.out_time <= dtEndDT)
                                                            .Where(x => x.card_tid == (int)_viewModel.SelectedCardType)
                                                            .OrderByDescending(x => x.out_time)
                                                            .ToList();
                        }

                        _viewModel.CollectionCount = listRecord.Count;
                        _viewModel.RecordCollection.Clear();
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

                            _viewModel.RecordCollection.Add(new OutViewModel() {
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
                    else if (_type == typeof(InAnalysis))
                    {
                        List<in_park> listRecord = null;
                        if (_viewModel.SelectedCardType == EnumCardType.全部)
                        {
                            listRecord = context.in_park.Where(x => x.in_time >= dtStartDT
                                                                && x.in_time <= dtEndDT)
                                                                .OrderByDescending(x => x.in_time)
                                                                .ToList();
                        }
                        else
                        {
                            listRecord = context.in_park.Where(x => x.in_time >= dtStartDT
                                                                && x.in_time <= dtEndDT
                                                                && x.card_tid == (int)_viewModel.SelectedCardType)
                                                                .OrderByDescending(x => x.in_time)
                                                                .ToList();
                        }
                            
                        _viewModel.CollectionCount = listRecord.Count;
                        _viewModel.RecordCollection.Clear();
                        foreach (var record in listRecord)
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

                            _viewModel.RecordCollection.Add(new InViewModel()
                            {
                                PersonCode = personCode,
                                PersonName = personName,
                                CardNo = cardNo,
                                CardType = ((EnumCardType)record.card_tid).ToString(),
                                CarNo = record.carno,
                                InPic = record.in_pic,
                                InTime = record.in_time,
                                InFrom = record.in_from,
                                OperatorName = record.@operator,
                                InParkRecord = record
                            });
                        }
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
