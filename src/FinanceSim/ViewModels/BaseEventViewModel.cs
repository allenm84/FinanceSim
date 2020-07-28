using System;
using System.Runtime.InteropServices;

namespace FinanceSim
{
  public abstract class BaseEventViewModel : BaseNotifyPropertyChanged, IHasIdViewModel
  {
    private DateTime _date;
    private string _name;

    public BaseEventViewModel(ProfileViewModel profile, BaseEvent model)
    {
      Profile = profile;
      Date = model.Date;
      Name = model.Name ?? $"{model.GetType().Name}";
    }

    public BaseEventViewModel(ProfileViewModel profile)
    {
      Profile = profile;
    }

    public ProfileViewModel Profile { get; }

    public DateTime Date
    {
      get => _date;
      set => SetField(ref _date, value);
    }

    public string Name
    {
      get => _name;
      set => SetField(ref _name, value);
    }

    string IHasIdViewModel.Id => "{no-id}";

    public abstract BaseEvent GetModel();
  }
}