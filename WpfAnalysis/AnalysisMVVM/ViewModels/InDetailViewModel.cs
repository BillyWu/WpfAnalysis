using EFToolConvertYKTToCode.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAnalysis
{
    public class InDetailViewModel : InOutDetailViewModel
    {

        public InDetailViewModel(InViewModel viewModel)
        {
            this.CarNo = viewModel.CarNo;
            this.InPic = viewModel.InPic;
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
