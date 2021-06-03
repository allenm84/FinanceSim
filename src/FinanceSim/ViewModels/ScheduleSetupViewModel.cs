using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceSim
{
  public class ScheduleSetupViewModel : BaseNotifyPropertyChanged
  {
    private int _daysBefore = 3;
    private int _daysAfter = 3;
    private DateTime _date = DateTime.Today;

    public int DaysBefore
    {
      get => _daysBefore;
      set => SetField(ref _daysBefore, value);
    }

    public int DaysAfter
    {
      get => _daysAfter;
      set => SetField(ref _daysAfter, value);
    }

    public DateTime Date
    {
      get => _date;
      set => SetField(ref _date, value);
    }
  }
}
