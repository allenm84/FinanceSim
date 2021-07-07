using System;

namespace FinanceSim
{
  public abstract class BaseIdViewModel : BaseNotifyPropertyChanged, IHasName, IHasIdViewModel
  {
    private string _name;

    protected BaseIdViewModel(ProfileViewModel profile, IHasName model)
    {
      Profile = profile;
      Id = model.Id;
      Name = model.Name;
    }

    protected BaseIdViewModel(ProfileViewModel profile)
    {
      Profile = profile;
      Id = Guid.NewGuid().ToString();
      Name = "<New>";
    }

    public ProfileViewModel Profile { get; }

    public string Id { get; }

    public string Name
    {
      get => _name;
      set => SetField(ref _name, value);
    }

    public override string ToString() => Name;
  }
}
