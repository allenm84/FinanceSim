using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace FinanceSim
{
  public class DelegateCommand : ICommand
  {
    private readonly Action _execute;
    private readonly Func<bool> _canExecute;

    public DelegateCommand(Action execute)
      : this(execute, AlwaysCanExecute)
    {
    }

    public DelegateCommand(Action execute, Func<bool> canExecute)
    {
      _execute = execute;
      _canExecute = canExecute;
    }

    private static bool AlwaysCanExecute() => true;

    public event EventHandler CanExecuteChanged;

    bool ICommand.CanExecute(object parameter)
    {
      return _canExecute?.Invoke() ?? true;
    }

    void ICommand.Execute(object parameter)
    {
      _execute.Invoke();
    }

    public void Refresh() => 
      CanExecuteChanged?.Invoke(this, EventArgs.Empty);
  }
}
