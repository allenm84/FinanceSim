using System;
using System.Globalization;
using System.Windows.Data;

namespace FinanceSim
{
  public class NullCheckValueConverter : IValueConverter
  {
    object IValueConverter.Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
      return (value != null);
    }

    object IValueConverter.ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
      throw new NotImplementedException();
    }
  }
}
