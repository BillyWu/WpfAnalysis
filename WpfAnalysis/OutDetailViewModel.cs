using EFToolConvertYKTToCode.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAnalysis
{
    public class OutDetailViewModel : NotifyPropertyChanged
    {

        public OutDetailViewModel(OutViewModel outViewModel)
        {
            this.CarNo = outViewModel.CarNo;
            this.OutPic = outViewModel.OutPic;

            using (var context = new FZWD20150818Context())
            {
                var oInPark = context.in_park.Find(new object[] { outViewModel.OutParkRecord.card_no, outViewModel.OutParkRecord.in_seq });
                this.InPic = oInPark.in_pic;
            }
                
        }

        private string _carno;
        public string CarNo
        {
            get { return _carno; }
            set
            {
                _carno = value;
                OnPropertyChanged(new PropertyChangedEventArgs("CarNo"));
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
