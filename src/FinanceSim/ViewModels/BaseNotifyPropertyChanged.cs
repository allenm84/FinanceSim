using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace FinanceSim
{
  public abstract class BaseNotifyPropertyChanged : INotifyPropertyChanged
  {
    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void SetField<T>(ref T target, T value, [CallerMemberName] string name = "")
    {
      target = value;
      FirePropertyChanged(name);
    }

    protected virtual void AfterPropertyChanged(string name)
    {
    }

    protected virtual void BeforePropertyChanged(string name)
    {
    }

    protected virtual void FirePropertyChanged([CallerMemberName]string name = "")
    {
      BeforePropertyChanged(name);
      PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
      AfterPropertyChanged(name);
    }
  }
}
