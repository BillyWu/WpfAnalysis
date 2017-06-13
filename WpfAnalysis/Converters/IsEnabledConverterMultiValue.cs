using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Data;

namespace WpfAnalysis
{
    public class IsEnabledConverterMultiValue : IMultiValueConverter
    {
        public object Convert(object[] value, Type targetType, object parameter,
            System.Globalization.CultureInfo culture)
        {
            return ((value[0] != null) 
                && ((value[1] != null) && ((int)(value[1]) > 0)));
        }

        public object[] ConvertBack(object value, Type[] targetType, object parameter,
            System.Globalization.CultureInfo culture)
        {
            return null;
        }
    }

}
