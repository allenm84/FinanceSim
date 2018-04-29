using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Finances
{
  public class BaseNamedItem : INamedItem, INotifyPropertyChanged
  {
    public BaseNamedItem()
    {
      _name = $"<New {GetType().Name}>";
    }

    private string _name;
    public string Name
    {
      get => _name;
      set
      {
        if (!string.Equals(_name, value))
        {
          _name = value;
          FirePropertyChanged();
        }
      }
    }

    public event PropertyChangedEventHandler PropertyChanged;

    private void FirePropertyChanged([CallerMemberName]string name = "")
    {
      var args = new PropertyChangedEventArgs(name);
      PropertyChanged?.Invoke(this, args);
    }
  }
}
