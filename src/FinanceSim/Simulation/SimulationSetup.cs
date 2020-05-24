using System;

namespace FinanceSim
{
  public class SimulationSetup : BaseNotifyPropertyChanged
  {
    static bool sUseSnowball = true;

    private DateTime _start;
    private DateTime _end;
    private bool _useSnowball;

    public SimulationSetup()
    {
      Start = DateTime.Today;
      End = DateTime.Today.AddYears(10);
      UseSnowball = sUseSnowball;
    }

    public DateTime Start
    {
      get => _start;
      set => SetField(ref _start, value);
    }

    public DateTime End
    {
      get => _end;
      set => SetField(ref _end, value);
    }

    public bool UseSnowball
    {
      get => _useSnowball;
      set
      {
        SetField(ref _useSnowball, value);
        sUseSnowball = _useSnowball;
      }
    }
  }
}
