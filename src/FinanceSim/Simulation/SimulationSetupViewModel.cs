using System;
using System.Windows.Input;

namespace FinanceSim
{
  public class SimulationSetupViewModel : BaseNotifyPropertyChanged
  {
    private DateTime _start;
    private DateTime _end;
    private bool _useSnowball;

    public SimulationSetupViewModel(SimulationSetup model)
    {
      ResetToDefaultsCommand = new DelegateCommand(DoResetToDefaults);

      if (model != null)
      {
        Start = model.Start;
        End = model.End;
        UseSnowball = model.UseSnowball;
      }
      else
      {
        DoResetToDefaults();
      }
    }

    public ICommand ResetToDefaultsCommand { get; }

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
      set => SetField(ref _useSnowball, value);
    }

    public SimulationSetup GetModel() => new()
    {
      Start = Start,
      End = End,
      UseSnowball = UseSnowball,
    };

    private void DoResetToDefaults()
    {
      Start = DateTime.Today;
      End = DateTime.Today.AddYears(10);
      UseSnowball = true;
    }
  }
}
