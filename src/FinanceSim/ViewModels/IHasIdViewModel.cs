using System.ComponentModel;

namespace FinanceSim
{
  public interface IHasIdViewModel : INotifyPropertyChanged
  {
    string Id { get; }
    string Name { get; }
  }
}