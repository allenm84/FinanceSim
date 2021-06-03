using System;
using System.Globalization;
using System.Windows.Data;

namespace FinanceSim
{
  public class CollectionViewSourceConverter : IValueConverter
  {
    object IValueConverter.Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
      var cvs = new CollectionViewSource();
      cvs.Source = value;
      cvs.GroupDescriptions.Add(new PropertyGroupDescription("Date"));
      return cvs;
    }

    object IValueConverter.ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
      throw new NotImplementedException();
    }
  }
}
