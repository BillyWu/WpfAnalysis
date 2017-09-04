using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfAnalysis
{
    public class InOutAnalysisViewModel : NotifyPropertyChangedByName
    {
        public InOutAnalysisViewModel(Type oType)
        {
            RecordCollection = new ObservableCollection<InOutViewModel>();

            SelectedCardType = EnumCardType.全部;

            AnalysisStartDateTime = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd") + " 00:00:00");
            AnalysisEndDateTime = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd") + " 23:59:59");

            AnalysisCommand = new InOutCommandAnalysis(this, oType);
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

        private DateTime? _AnalysisStartDateTime;
        public DateTime? AnalysisStartDateTime
        {
            get
            {
                return _AnalysisStartDateTime;
            }
            set
            {
                _AnalysisStartDateTime = value;
                OnPropertyChanged("AnalysisStartDateTime");
            }
        }

        private DateTime? _AnalysisEndDateTime;
        public DateTime? AnalysisEndDateTime
        {
            get
            {
                return _AnalysisEndDateTime;
            }
            set
            {
                _AnalysisEndDateTime = value;
                OnPropertyChanged("AnalysisEndDateTime");
            }
        }

        private ObservableCollection<InOutViewModel> _RecordCollection;
        public ObservableCollection<InOutViewModel> RecordCollection
        {
            get
            {
                return _RecordCollection;
            }
            set
            {
                _RecordCollection = value;
                OnPropertyChanged("RecordCollection");
            }
        }

        private int _CollectionCount;
        public int CollectionCount
        {
            get
            {
                return _CollectionCount;
            }
            set
            {
                _CollectionCount = value;
                OnPropertyChanged("CollectionCount");
            }
        }
    }
}
