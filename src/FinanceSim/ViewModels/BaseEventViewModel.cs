using System;

namespace FinanceSim
{
  public abstract class BaseEventViewModel : BaseNotifyPropertyChanged, IHasIdViewModel
  {
    private DateTime _date;

    public BaseEventViewModel(ProfileViewModel profile, BaseEvent model)
    {
      Profile = profile;
      Date = model.Date;
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

    string IHasIdViewModel.Name => "{no-name}";
    string IHasIdViewModel.Id => "{no-id}";

    public abstract BaseEvent GetModel();
  }
}