using NPOI.HSSF.Model;
using NPOI.HSSF.UserModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace WpfAnalysis.ExportUtility
{
    public class ExportToExcelWithNPIO
    {
        public static void ExportToExcel(string excelName, List<Tuple<string, string, double, Type>> headers, ObservableCollection<InOutViewModel> RecordCollection)
        {
            string excelPath = ConfigurationManager.AppSettings["ExcelPath"];
            if (excelPath.Last() != System.IO.Path.DirectorySeparatorChar)
                excelPath += System.IO.Path.DirectorySeparatorChar;
            string excelFile = string.Format("{0}{1}", excelPath, excelName);
            string sheetName = "Sheet1";

            if (File.Exists(excelFile))
            {
                File.Delete(excelFile);
            }

            HSSFWorkbook wb = HSSFWorkbook.Create(InternalWorkbook.CreateWorkbook());
            HSSFSheet sh = (HSSFSheet)wb.CreateSheet(sheetName);

            for (int i = 1; i <= RecordCollection.Count; i++)
            {
                var item = RecordCollection[i - 1];

                if (sh.GetRow(i) == null)
                    sh.CreateRow(i);

                for (int j = 0; j < headers.Count; j++)
                {
                    if (sh.GetRow(i).GetCell(j) == null)
                        sh.GetRow(i).CreateCell(j);

                    string sValue = "";
                    if (item is OutViewModel)
                    {
                        var y = typeof(OutViewModel).InvokeMember(headers[j].Item2.ToString(), BindingFlags.GetProperty, null, item, null);
                        sValue = (y == null) ? "" : y.ToString();
                    }
                    else if (item is InViewModel)
                    {
                        var y = typeof(InViewModel).InvokeMember(headers[j].Item2.ToString(), BindingFlags.GetProperty, null, item, null);
                        sValue = (y == null) ? "" : y.ToString();
                    }

                    sh.GetRow(i).GetCell(j).SetCellValue(sValue);
                }
            }

            var r = sh.CreateRow(0);
            for (int j = 0; j < headers.Count; j++)
            {
                if (sh.GetRow(0).GetCell(j) == null)
                    sh.GetRow(0).CreateCell(j);
                sh.GetRow(0).GetCell(j).SetCellValue(headers[j].Item1);
                sh.AutoSizeColumn(j);
            }

            using (var fs = new FileStream(excelFile, FileMode.Create, FileAccess.Write))
            {
                wb.Write(fs);
            }

            ExploreFile(excelFile);
        }

        public static void ExportToExcel1<T>(string excelName, List<Tuple<string, string, double, Type>> headers, ObservableCollection<T> RecordCollection)
        {
            string excelPath = ConfigurationManager.AppSettings["ExcelPath"];
            if (excelPath.Last() != System.IO.Path.DirectorySeparatorChar)
                excelPath += System.IO.Path.DirectorySeparatorChar;
            string excelFile = string.Format("{0}{1}", excelPath, excelName);
            string sheetName = "Sheet1";

            if (File.Exists(excelFile))
            {
                File.Delete(excelFile);
            }

            HSSFWorkbook wb = HSSFWorkbook.Create(InternalWorkbook.CreateWorkbook());
            HSSFSheet sh = (HSSFSheet)wb.CreateSheet(sheetName);

            for (int i = 1; i <= RecordCollection.Count; i++)
            {
                var item = RecordCollection[i - 1];

                if (sh.GetRow(i) == null)
                    sh.CreateRow(i);

                for (int j = 0; j < headers.Count; j++)
                {
                    if (sh.GetRow(i).GetCell(j) == null)
                        sh.GetRow(i).CreateCell(j);

                    string sValue = "";
                    var y = typeof(T).InvokeMember(headers[j].Item2.ToString(), BindingFlags.GetProperty, null, item, null);
                    sValue = (y == null) ? "" : y.ToString();

                    sh.GetRow(i).GetCell(j).SetCellValue(sValue);
                }
            }

            var r = sh.CreateRow(0);
            for (int j = 0; j < headers.Count; j++)
            {
                if (sh.GetRow(0).GetCell(j) == null)
                    sh.GetRow(0).CreateCell(j);
                sh.GetRow(0).GetCell(j).SetCellValue(headers[j].Item1);
                sh.AutoSizeColumn(j);
            }

            using (var fs = new FileStream(excelFile, FileMode.Create, FileAccess.Write))
            {
                wb.Write(fs);
            }

            ExploreFile(excelFile);
        }

        public static bool ExploreFile(string filePath)
        {
            if (!System.IO.File.Exists(filePath))
            {
                return false;
            }
            //Clean up file path so it can be navigated OK
            filePath = System.IO.Path.GetFullPath(filePath);
            Process.Start("explorer.exe", string.Format(" / select,\"{0}\"", filePath));
            return true;
        }

    }
}
