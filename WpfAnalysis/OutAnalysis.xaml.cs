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
            this.DataContext = viewModel;
        }

        private void ListViewItem_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var outViewModel = ((ListViewItem)sender).Content as OutViewModel;
            var outDetail = new OutDetail(outViewModel);
            outDetail.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            outDetail.ShowDialog();
        }
    }
}
