using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAnalysis
{
    public class QueryRightRowViewModel : NotifyPropertyChangedByName
    {

        private int _cardNo;
        public int CardNo
        {
            get => _cardNo;
            set
            {
                _cardNo = value;
                OnPropertyChanged("CardNo");
            }
        }

        private int _personCode;
        public int PersonCode
        {
            get => _personCode;
            set
            {
                _personCode = value;
                OnPropertyChanged("PersonCode");
            }
        }

        private string _personName;
        public string PersonName
        {
            get => _personName;
            set
            {
                _personName = value;
                OnPropertyChanged("PersonName");
            }
        }

        private int? _cardStatus;
        public int? CardStatus
        {
            get => _cardStatus;
            set
            {
                _cardStatus = value;
                OnPropertyChanged("CardStatus");
            }
        }

        private DateTime? _validStartDate;
        public DateTime? ValidStartDate
        {
            get => _validStartDate;
            set
            {
                _validStartDate = value;
                OnPropertyChanged("ValidStartDate");
            }
        }

        private DateTime? _validEndDate;
        public DateTime? ValidEndDate
        {
            get => _validEndDate;
            set
            {
                _validEndDate = value;
                OnPropertyChanged("ValidEndDate");
            }
        }
        
        private string _doorRights;
        public string DoorRights
        {
            get => _doorRights;
            set
            {
                _doorRights = value;
                OnPropertyChanged("DoorRights");
            }
        }

        private string _timeSectionNo;
        public string TimeSectionNo
        {
            get => _timeSectionNo;
            set
            {
                _timeSectionNo = value;
                OnPropertyChanged("TimeSectionNo");
            }
        }

    }
}
