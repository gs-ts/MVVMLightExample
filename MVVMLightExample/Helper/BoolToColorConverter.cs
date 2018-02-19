using System;
using System.Windows.Data;
using System.Globalization;
using System.Windows.Media;

namespace MVVMLightExample.Helper
{
    class BoolToColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
            {
                return new SolidColorBrush(Colors.Gray);
            }

            return System.Convert.ToBoolean(value) ?
                new SolidColorBrush(Colors.Green)
              : new SolidColorBrush(Colors.Red);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
