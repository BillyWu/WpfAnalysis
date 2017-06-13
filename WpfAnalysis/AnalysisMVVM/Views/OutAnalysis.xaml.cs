using SUT.PrintEngine.Utils;
using System;
using System.Data;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
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
        private InOutAnalysisViewModel viewModel;
        private List<Tuple<string, string, double, Type>> headers;
        public OutAnalysis()
        {
            InitializeComponent();

            viewModel = new InOutAnalysisViewModel(typeof(OutAnalysis));
            this.DataContext = viewModel;

            headers = new List<Tuple<string, string, double, Type>>();
            foreach (var column in gridView1.Columns)
            {
                var s1 = column.DisplayMemberBinding as Binding;
                headers.Add(new Tuple<string, string, double, Type>(column.Header.ToString(), s1.Path.Path, column.ActualWidth, typeof(string)));
            }
        }

        private void ListViewItem_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var outViewModel = ((ListViewItem)sender).Content as OutViewModel;
            var outDetail = new OutDetail(outViewModel);
            outDetail.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            outDetail.ShowDialog();
        }

        private void btnExcel_Click(object sender, RoutedEventArgs e)
        {
            var s = new ExportToExcel<InOutViewModel, ObservableCollection<InOutViewModel>>();
            s.headers = headers;
            s.dataToPrint = viewModel.RecordCollection;
            s.GenerateReport();
        }

        private void btnPrint_Click(object sender, RoutedEventArgs e)
        {
            var dataTable = GenerateUtil.GenerateDataTable(headers, viewModel.RecordCollection);
            var columnWidths = headers.Select(x => x.Item3 * 0.51).ToList();
            var ht = new HeaderTemplate();
            var headerTemplate = XamlWriter.Save(ht);
            var printControl = PrintControlFactory.Create(dataTable, columnWidths, headerTemplate);
            printControl.ShowPrintPreview();
        }

    }
}
