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

        private void btnExcel_Click(object sender, RoutedEventArgs e)
        {
            var headers = new List<Tuple<string, string>>();
            foreach(var column in gridView1.Columns)
            {
                var s1 = column.DisplayMemberBinding as Binding;
                headers.Add(new Tuple<string, string>(column.Header.ToString(), s1.Path.Path));
            }

            //var s = new ExportToExcel<OutViewModel, ObservableCollection<OutViewModel>>();
            //ICollectionView view = CollectionViewSource.GetDefaultView(this.listView1.ItemsSource);
            //s.headers = headers;
            //s.dataToPrint = (ObservableCollection<OutViewModel>)view.SourceCollection;
            //s.GenerateReport();

            var s = new ExportToExcel<OutViewModel, ObservableCollection<OutViewModel>>();
            s.headers = headers;
            s.dataToPrint = viewModel.OutCollection;
            s.GenerateReport();
        }

        private void btnPrint_Click(object sender, RoutedEventArgs e)
        {
            var dataTable = CreateSampleDataTable();
            var columnWidths = new List<double>() { 30, 40, 300 };
            var ht = new HeaderTemplate();
            var headerTemplate = XamlWriter.Save(ht);
            var printControl = PrintControlFactory.Create(dataTable, columnWidths, headerTemplate);
            printControl.ShowPrintPreview();
        }

        private DataTable CreateSampleDataTable()
        {
            var dataTable = new DataTable();
            AddColumn(dataTable, "ID", typeof(int));
            AddColumn(dataTable, "Name", typeof(string));
            AddColumn(dataTable, "Birth Date", typeof(DateTime));
            //AddColumn(dataTable, "Profession", typeof(string));
            //AddColumn(dataTable, "Address", typeof(string));

            for (int i = 1; i < 3; i++)
            {
                AddRow(dataTable, i);
            }
            return dataTable;
        }

        private void AddRow(DataTable dataTable, int i)
        {
            var name = string.Format("saraf {0}", i);
            var dob = string.Format("{0}", DateTime.Now.AddDays(-(i * 18)));
            var profession = string.Format("Engineer {0}", i);
            var address = string.Format("8{0} Jack Clow Road, London", i);
            var dataRow = dataTable.NewRow();
            dataRow[0] = i;
            dataRow[1] = name;
            dataRow[2] = dob;
            //dataRow[3] = profession;
            //dataRow[4] = address;
            dataTable.Rows.Add(dataRow);
        }

        private void AddColumn(DataTable dataTable, string columnName, Type type)
        {
            var dataColumn = new DataColumn(columnName, type);
            dataTable.Columns.Add(dataColumn);
        }

    }
}
