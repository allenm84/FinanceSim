using System;
using System.Collections.Generic;
using System.Linq;

namespace FinanceSim
{
  public class SimulationDueInfo
  {
    private static readonly DateTime End = new(9876, 12, 31);

    private readonly DueInfo _dueInfo;
    private readonly IEnumerator<DateTime> _dueDates;

    public SimulationDueInfo(DateTime start, DueInfo info)
    {
      _dueInfo = info;
      _dueDates = CreateDueDateGenerator(start).GetEnumerator();
      _dueDates.MoveNext();
      Start = Current;
    }

    public DateTime Current => _dueDates.Current;
    public DateTime Start { get; }

    public bool IsStopped { get; private set; }

    public void Next()
    {
      IsStopped = !_dueDates.MoveNext();
    }

    private DateTime Next(DateTime date) => DueInfoHelper.Advance(date, _dueInfo);

    private IEnumerable<DateTime> DueDates()
    {
      var end = _dueInfo.End.GetValueOrDefault(End);

      if (_dueInfo.Type == DueType.Once)
      {
        end = _dueInfo.Seed;
      }

      for (DateTime i = _dueInfo.Seed; i <= end; i = Next(i))
      {
        yield return i;
      }
    }

    private IEnumerable<DateTime> CreateDueDateGenerator(DateTime start)
    {
      var d1 = start.Date;
      var d2 = _dueInfo.Start.Date;
      var latest = (d1 > d2) ? d1 : d2;
      return DueDates().SkipWhile(d => d < latest);
    }
  }
}
