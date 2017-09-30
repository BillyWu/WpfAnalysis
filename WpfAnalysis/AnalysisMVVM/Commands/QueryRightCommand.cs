using EFToolConvertYKTToCode.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfAnalysis
{
    public class QueryRightCommand : CommandBase
    {
        private QueryRightViewModel _viewModel;
        public QueryRightCommand(QueryRightViewModel viewModel)
        {
            _viewModel = viewModel;
        }

        public override void PerformCommand(object parameter)
        {
            try
            {
                using (var context = new FZWD20150818Context())
                {
                    DateTime dtStartDT = (DateTime) _viewModel.PublishStartDate;
                    DateTime dtEndDT = (DateTime) _viewModel.PublishEndDate;

                }
            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
