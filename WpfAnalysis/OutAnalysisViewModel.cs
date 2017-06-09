using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfAnalysis
{
    public class OutAnalysisViewModel : NotifyPropertyChangedByName
    {
        public OutAnalysisViewModel()
        {
            OutCollection = new ObservableCollection<OutViewModel>();

            SelectedCardType = EnumCardType.月租车;
            AnalysisStartDate = DateTime.Parse("2000-01-01 00:00:00");
            AnalysisStartTime = DateTime.Now;
            AnalysisEndDate = DateTime.Parse("2020-01-01 00:00:00");
            AnalysisEndTime = DateTime.Now;

            AnalysisCommand = new OutCommandAnalysis(this);
        }

        public ICommand AnalysisCommand
        {
            get;
        }

        private EnumCardType _SelectedCardType;
        public EnumCardType SelectedCardType
        {
            get
            {
                return _SelectedCardType;
            }
            set
            {
                _SelectedCardType = value;
                OnPropertyChanged("SelectedCardType");
            }
        }

        private DateTime? _AnalysisStartTime;
        public DateTime? AnalysisStartTime
        {
            get
            {
                return _AnalysisStartTime;
            }
            set
            {
                _AnalysisStartTime = value;
                OnPropertyChanged("AnalysisStartTime");
            }
        }

        private DateTime? _AnalysisStartDate;
        public DateTime? AnalysisStartDate
        {
            get
            {
                return _AnalysisStartDate;
            }
            set
            {
                _AnalysisStartDate = value;
                OnPropertyChanged("AnalysisStartDate");
            }
        }

        private DateTime? _AnalysisEndTime;
        public DateTime? AnalysisEndTime
        {
            get
            {
                return _AnalysisEndTime;
            }
            set
            {
                _AnalysisEndTime = value;
                OnPropertyChanged("AnalysisEndTime");
            }
        }

        private DateTime? _AnalysisEndDate;
        public DateTime? AnalysisEndDate
        {
            get
            {
                return _AnalysisEndDate;
            }
            set
            {
                _AnalysisEndDate = value;
                OnPropertyChanged("AnalysisEndDate");
            }
        }

        private ObservableCollection<OutViewModel> _OutCollection;
        public ObservableCollection<OutViewModel> OutCollection
        {
            get
            {
                return _OutCollection;
            }
            set
            {
                _OutCollection = value;
                OnPropertyChanged("OutCollection");
            }
        }

    }
}
