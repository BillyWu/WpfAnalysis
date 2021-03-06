﻿using SUT.PrintEngine.Utils;
using System;
using System.Data;
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
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Reflection;
using WpfAnalysis.ExportUtility;

namespace WpfAnalysis
{
    /// <summary>
    /// Interaction logic for InAnalysis.xaml
    /// </summary>
    public partial class InAnalysis : Window
    {
        private InOutAnalysisViewModel viewModel;
        private List<Tuple<string, string, double, Type>> headers;
        public InAnalysis()
        {
            InitializeComponent();

            viewModel = new InOutAnalysisViewModel(typeof(InAnalysis));
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
            var inViewModel = ((ListViewItem)sender).Content as InViewModel;
            var inDetail = new InDetail(inViewModel);
            inDetail.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            inDetail.ShowDialog();
        }

        private void btnExcel_Click(object sender, RoutedEventArgs e)
        {
            ExportToExcelWithNPIO.ExportToExcel("入场记录.xls", headers, viewModel.RecordCollection);
        }

        private void btnPrint_Click(object sender, RoutedEventArgs e)
        {
            var dataTable = GenerateUtil.GenerateDataTable(headers, viewModel.RecordCollection);
            var columnWidths = headers.Select(x => x.Item3 * 0.6).ToList();
            var ht = new HeaderTemplate();
            var headerTemplate = XamlWriter.Save(ht);
            var printControl = PrintControlFactory.Create(dataTable, columnWidths, headerTemplate);
            printControl.ShowPrintPreview();
        }

        
    }
}
