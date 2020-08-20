using System;
using System.Globalization;
using Xamarin.Forms;

namespace Healthy_Body.Portable
{
    public class IntToBoolConverter: IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string s = String.Format("{0:0}", value);
            return int.Parse(s) != 0;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (bool)value ? 1 : 0;
        }
    }
}