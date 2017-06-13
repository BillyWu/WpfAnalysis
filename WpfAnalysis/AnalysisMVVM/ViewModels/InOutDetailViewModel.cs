using EFToolConvertYKTToCode.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAnalysis
{
    public class InOutDetailViewModel : NotifyPropertyChanged
    {

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
