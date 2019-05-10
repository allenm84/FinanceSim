using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

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

    protected virtual void FirePropertyChanged([CallerMemberName]string name = "")
    {
      PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
  }
}
