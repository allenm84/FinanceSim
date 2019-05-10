using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceSim
{
  public sealed class AccountItem : INotifyPropertyChanged
  {
    public AccountItem(IAccount account)
    {
      Value = account;
      Value.PropertyChanged += OnAccountPropertyChanged;
    }

    public IAccount Value { get; }

    public string Id => Value.Id;
    public string Name => Value.Name;

    public event PropertyChangedEventHandler PropertyChanged;

    public void Release()
    {
      Value.PropertyChanged -= OnAccountPropertyChanged;
    }

    private void OnAccountPropertyChanged(object sender, PropertyChangedEventArgs e)
    {
      PropertyChanged?.Invoke(this, e);
    }
  }
}
