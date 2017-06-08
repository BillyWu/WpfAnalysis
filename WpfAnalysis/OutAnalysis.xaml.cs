using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfAnalysis
{
    /// <summary>
    /// Interaction logic for OutAnalysis.xaml
    /// </summary>
    public partial class OutAnalysis : Window
    {
        private OutAnalysisViewModel viewModel;
        public OutAnalysis()
        {
            InitializeComponent();

            viewModel = new OutAnalysisViewModel();
            viewModel.OutCollection = new ObservableCollection<OutViewModel>();
            viewModel.OutCollection.Add(new OutViewModel() { CarNo="1" });

            this.DataContext = viewModel;
        }
    }
}
