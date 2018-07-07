using System;
using Xamarin.Forms;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace GoogleClientPlugin
{
    class InvertBooleanConverter: IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return !(bool)value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return !(bool)value;
        }
    }
}
