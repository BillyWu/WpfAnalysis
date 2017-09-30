using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Reflection;
using WpfAnalysis;

namespace SUT.PrintEngine.Utils
{
    class GenerateUtil
    {
        public static DataTable GenerateDataTable(List<Tuple<string, string, double, Type>> headers, ObservableCollection<InOutViewModel> RecordCollection)
        {
            var dataTable = new DataTable();

            foreach (var column in headers)
            {
                dataTable.Columns.Add(new DataColumn(column.Item1, column.Item4));
            }

            foreach (var item in RecordCollection)
            {
                var dataRow = dataTable.NewRow();

                if (item is InViewModel)
                {
                    for (int i = 0; i < headers.Count; i++)
                    {
                        var y = typeof(InViewModel).InvokeMember(headers[i].Item2, BindingFlags.GetProperty, null, item, null);
                        dataRow[i] = (y == null) ? "" : y.ToString();
                    }
                }
                else if (item is OutViewModel)
                {
                    for (int i = 0; i < headers.Count; i++)
                    {
                        var y = typeof(OutViewModel).InvokeMember(headers[i].Item2, BindingFlags.GetProperty, null, item, null);
                        dataRow[i] = (y == null) ? "" : y.ToString();
                    }
                }

                dataTable.Rows.Add(dataRow);
            }

            return dataTable;
        }

        public static DataTable GenerateDataTable1<T>(List<Tuple<string, string, double, Type>> headers, ObservableCollection<T> RecordCollection)
        {
            var dataTable = new DataTable();

            foreach (var column in headers)
            {
                dataTable.Columns.Add(new DataColumn(column.Item1, column.Item4));
            }

            foreach (var item in RecordCollection)
            {
                var dataRow = dataTable.NewRow();

                for (int i = 0; i < headers.Count; i++)
                {
                    var y = typeof(T).InvokeMember(headers[i].Item2, BindingFlags.GetProperty, null, item, null);
                    dataRow[i] = (y == null) ? "" : y.ToString();
                }

                dataTable.Rows.Add(dataRow);
            }

            return dataTable;
        }
    }
}
