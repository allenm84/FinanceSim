using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace FinanceSim
{
  public class DueTypeDisplayTextConverter : IValueConverter
  {
    private readonly Dictionary<DueType, string> _typeToText = new Dictionary<DueType, string>
    {
      { DueType.Daily, "Days" },
      { DueType.Monthly, "Months" },
      { DueType.Once, "Once" },
      { DueType.Weekly, "Weeks" },
      { DueType.Yearly, "Years" },
    };

    object IValueConverter.Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
      if (value is DueType dueType && _typeToText.TryGetValue(dueType, out var display))
      {
        return display;
      }

      return value?.ToString();
    }

    object IValueConverter.ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
      return string.Empty;
    }
  }
}
