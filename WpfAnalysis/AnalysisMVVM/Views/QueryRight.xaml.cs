using System;
using System.Collections.Generic;
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
using SUT.PrintEngine.Utils;
using System.Windows.Markup;
using WpfAnalysis.ExportUtility;

namespace WpfAnalysis
{
    /// <summary>
    /// Interaction logic for QueryRight.xaml
    /// </summary>
    public partial class QueryRight : Window
    {
        private QueryRightViewModel viewModel;
        private List<Tuple<string, string, double, Type>> headers;

        public QueryRight()
        {
            InitializeComponent();

            viewModel = new QueryRightViewModel();
            this.DataContext = viewModel;

            headers = new List<Tuple<string, string, double, Type>>();
            foreach (var column in gridView1.Columns)
            {
                if (column.Header is GridViewColumnHeader header)
                    headers.Add(new Tuple<string, string, double, Type>(header.Content.ToString(), header.Tag.ToString(), column.ActualWidth, typeof(string)));
            }
        }

        private void btnExcel_Click(object sender, RoutedEventArgs e)
        {
            ExportToExcelWithNPIO.ExportToExcel1<QueryRightRowViewModel>("门禁权限.xls", headers, viewModel.RecordCollection);
        }

        private void btnPrint_Click(object sender, RoutedEventArgs e)
        {
            var dataTable = GenerateUtil.GenerateDataTable1<QueryRightRowViewModel>(headers, viewModel.RecordCollection);
            var columnWidths = headers.Select(x => x.Item3 * 0.51).ToList();
            var ht = new HeaderTemplate();
            var headerTemplate = XamlWriter.Save(ht);
            var printControl = PrintControlFactory.Create(dataTable, columnWidths, headerTemplate);
            printControl.ShowPrintPreview();
        }
    }
}
