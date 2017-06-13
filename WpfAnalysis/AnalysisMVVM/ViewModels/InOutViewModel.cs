using EFToolConvertYKTToCode.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAnalysis
{
    public class InOutViewModel : NotifyPropertyChanged
    {
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
