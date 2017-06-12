using EFToolConvertYKTToCode.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAnalysis
{
    public class InViewModel : NotifyPropertyChanged
    {
        public out_park OutParkRecord
        {
            get;
            set;
        }

        private string _personCode;
        public string PersonCode
        {
            get { return _personCode; }
            set
            {
                _personCode = value;
                OnPropertyChanged(new PropertyChangedEventArgs("PersonCode"));
            }
        }

        private string _personName;
        public string PersonName
        {
            get { return _personName; }
            set
            {
                _personName = value;
                OnPropertyChanged(new PropertyChangedEventArgs("PersonName"));
            }
        }

        private string _cardno;
        public string CardNo
        {
            get { return _cardno; }
            set
            {
                _cardno = value;
                OnPropertyChanged(new PropertyChangedEventArgs("CardNo"));
            }
        }

        private string _cardType;
        public string CardType
        {
            get { return _cardType; }
            set
            {
                _cardType = value;
                OnPropertyChanged(new PropertyChangedEventArgs("CardType"));
            }
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

        private DateTime? _inTime;
        public DateTime? InTime
        {
            get { return _inTime; }
            set
            {
                _inTime = value;
                OnPropertyChanged(new PropertyChangedEventArgs("InTime"));
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

        private string _operatorName;
        public string OperatorName
        {
            get { return _operatorName; }
            set
            {
                _operatorName = value;
                OnPropertyChanged(new PropertyChangedEventArgs("OperatorName"));
            }
        }

    }
}
