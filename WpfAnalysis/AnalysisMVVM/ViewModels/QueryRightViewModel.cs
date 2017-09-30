using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Input;
using EFToolConvertYKTToCode.Models;

namespace WpfAnalysis
{
    public class QueryRightViewModel : NotifyPropertyChangedByName
    {
        public QueryRightViewModel()
        {
            using (var context = new FZWD20150818Context())
            {
                List<M_ControlDefine> M_ControlDefine = context.M_ControlDefine.ToList();

                RecordCollection = new ObservableCollection<QueryRightRowViewModel>();
                CvsRecordCollection = new CollectionViewSource()
                {
                    Source = RecordCollection,
                };
                CvsRecordCollection.Filter += RecordCollection_Filter;

                foreach (var doorCard in context.door_card_make)
                {
                    var customer = context.customers.FirstOrDefault(x => x.cust_no == doorCard.cust_no);

                    string rights = doorCard.MachNo;
                    if (rights == "" || rights == "," || rights == ",,")
                        rights = ",";
                    string[] doorRights = rights.Split(',');
                    var listDoorRights = new List<string>();
                    listDoorRights.AddRange(doorRights);
                    listDoorRights.RemoveAt(listDoorRights.Count() - 1);
                    listDoorRights.RemoveAt(0);
                    string updateRights = "";
                    foreach (var right in listDoorRights)
                    {
                        updateRights +=
                            M_ControlDefine.FirstOrDefault(x => x.id.ToString() == right)?.DoorName + ",";
                    }


                    RecordCollection.Add(new QueryRightRowViewModel()
                    {
                        CardNo = doorCard.card_no,
                        PersonCode = doorCard.cust_no,
                        PersonName = customer?.cust_name,
                        CardStatus = doorCard.CardState,
                        ValidStartDate = doorCard.bDate,
                        ValidEndDate = doorCard.eDate,
                        DoorRights = updateRights,
                        TimeSectionNo = doorCard.TimeNo
                    });
                    
                }
                CollectionCount = RecordCollection.Count;

                PublishStartDate = DateTime.Today.AddYears(-1);
                PublishEndDate = DateTime.Today;

                AnalysisCommand = new QueryRightCommand(this);
            }
        }

        public ICommand AnalysisCommand
        {
            get;
        }

        private DateTime? _PublishStartDate;
        public DateTime? PublishStartDate
        {
            get
            {
                return _PublishStartDate;
            }
            set
            {
                _PublishStartDate = value;
                OnPropertyChanged("PublishStartDate");
            }
        }

        private DateTime? _PublishEndDate;
        public DateTime? PublishEndDate
        {
            get
            {
                return _PublishEndDate;
            }
            set
            {
                _PublishEndDate = value;
                OnPropertyChanged("PublishEndDate");
            }
        }

        public ObservableCollection<QueryRightRowViewModel> RecordCollection { get; set; }
        internal CollectionViewSource CvsRecordCollection { get; }
        public ICollectionView CvRecordCollection => CvsRecordCollection.View;

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


        private string _filterName;
        public string FilterName
        {
            get => _filterName;
            set
            {
                _filterName = value;
                this.CvsRecordCollection.View.Refresh();
                OnPropertyChanged("FilterName");
            }
        }

        private string _filterBh;
        public string FilterBh
        {
            get => _filterBh;
            set
            {
                _filterBh = value;
                this.CvsRecordCollection.View.Refresh();
                OnPropertyChanged("FilterBh");
            }
        }


        private string _filterCardNo;
        public string FilterCardNo
        {
            get => _filterCardNo;
            set
            {
                _filterCardNo = value;
                this.CvsRecordCollection.View.Refresh();
                OnPropertyChanged("FilterCardNo");
            }
        }


        private string _filterDoorName;
        public string FilterDoorName
        {
            get => _filterDoorName;
            set
            {
                _filterDoorName = value;
                this.CvsRecordCollection.View.Refresh();
                OnPropertyChanged("FilterDoorName");
            }
        }

        private void RecordCollection_Filter(object sender, FilterEventArgs e)
        {
            if (e.Item is QueryRightRowViewModel vm)
            {
                bool bFilter = true;

                var tuples = new List<Tuple<string, string>>()
                {
                    new Tuple<string, string>("PersonName", FilterName),
                    new Tuple<string, string>("PersonCode", FilterBh),
                    new Tuple<string, string>("CardNo", FilterCardNo),
                    new Tuple<string, string>("DoorRights", FilterDoorName),
                    

                };

                foreach (var tuple in tuples)
                {
                    var propValue = (vm?.GetType().GetProperty(tuple.Item1)?.GetValue(vm, null));
                    bFilter &= string.IsNullOrEmpty(tuple.Item2) || propValue == null || propValue.ToString().Contains(tuple.Item2);
                }

                e.Accepted = bFilter;
            }
            else
                e.Accepted = true;
        }
    }
}
