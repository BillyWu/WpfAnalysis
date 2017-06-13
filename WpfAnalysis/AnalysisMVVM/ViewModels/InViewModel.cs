using EFToolConvertYKTToCode.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAnalysis
{
    public class InViewModel : InOutViewModel
    {
        public in_park InParkRecord
        {
            get;
            set;
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

        private int? _inFrom;
        public int? InFrom
        {
            get { return _inFrom; }
            set
            {
                _inFrom = value;
                OnPropertyChanged(new PropertyChangedEventArgs("InFrom"));
            }
        }
    }
}
