using EFToolConvertYKTToCode.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAnalysis
{
    public class OutDetailViewModel : InOutDetailViewModel
    {

        public OutDetailViewModel(OutViewModel viewModel)
        {
            this.CarNo = viewModel.CarNo;
            this.OutPic = viewModel.OutPic;

            using (var context = new FZWD20150818Context())
            {
                var oInPark = context.in_park.Find(new object[] { viewModel.OutParkRecord.card_no, viewModel.OutParkRecord.in_seq });
                this.InPic = oInPark.in_pic;
            }
        }

        private string _outPic;
        public string OutPic
        {
            get { return _outPic; }
            set
            {
                _outPic = value;
                OnPropertyChanged(new PropertyChangedEventArgs("OutPic"));
            }
        }

        private string _inPic;
        public string InPic
        {
            get { return _inPic; }
            set
            {
                _inPic = value;
                OnPropertyChanged(new PropertyChangedEventArgs("InPic"));
            }
        }

    }
}
