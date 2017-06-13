using EFToolConvertYKTToCode.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAnalysis
{
    public class OutViewModel : InOutViewModel
    {
        public out_park OutParkRecord
        {
            get;
            set;
        }

        private string _carType;
        public string CarType
        {
            get { return _carType; }
            set
            {
                _carType = value;
                OnPropertyChanged(new PropertyChangedEventArgs("CarType"));
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

        private DateTime? _outTime;
        public DateTime? OutTime
        {
            get { return _outTime; }
            set
            {
                _outTime = value;
                OnPropertyChanged(new PropertyChangedEventArgs("OutTime"));
            }
        }

        private int? _outFrom;
        public int? OutFrom
        {
            get { return _outFrom; }
            set
            {
                _outFrom = value;
                OnPropertyChanged(new PropertyChangedEventArgs("OutFrom"));
            }
        }

        private decimal? _actualIncome;
        public decimal? ActualIncome
        {
            get { return _actualIncome; }
            set
            {
                _actualIncome = value;
                OnPropertyChanged(new PropertyChangedEventArgs("ActualIncome"));
            }
        }
    }
}
