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

namespace WpfAnalysis
{
    /// <summary>
    /// Interaction logic for OutDetail.xaml
    /// </summary>
    public partial class OutDetail : Window
    {
        private OutDetailViewModel _outDetailViewModel;

        public OutDetail()
        {
            InitializeComponent();
        }

        public OutDetail(OutViewModel outViewModel)
        {
            InitializeComponent();

            _outDetailViewModel = new OutDetailViewModel(outViewModel);

            this.DataContext = _outDetailViewModel;
        }

    }
}
