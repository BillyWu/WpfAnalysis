using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAnalysis
{
    public class OutViewModel : NotifyPropertyChanged
    {

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
    }
}
