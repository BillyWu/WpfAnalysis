using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAnalysis
{
    public class OutAnalysisViewModel : NotifyPropertyChangedByName
    {
        public OutAnalysisViewModel()
        {
            SelectedCardType = EnumCardType.月租车;

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
