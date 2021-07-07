using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;

namespace FinanceSim
{
  public class SnowBallSetupViewModel : BaseNotifyPropertyChanged
  {
    private string[] _desiredOrder;
    private decimal _initialAmount;

    public SnowBallSetupViewModel(ProfileViewModel profile, SnowBallSetup model)
    {
      Profile = profile;

      _initialAmount = model?.InitialAmount ?? 0;
      _desiredOrder = model?.DebtOrder;

      DoRefresh();

      Profile.Debts.CollectionChanged += Debts_CollectionChanged;
    }

    public ProfileViewModel Profile { get; }

    public decimal InitialAmount
    {
      get => _initialAmount;
      set => SetField(ref _initialAmount, value);
    }

    public ObservableCollectionEx<SnowBallSetupItemViewModel> Items { get; } = new();

    public SnowBallSetup GetModel()
    {
      SaveDesiredOrder();
      return new SnowBallSetup
      {
        DebtOrder = _desiredOrder,
        InitialAmount = InitialAmount,
      };
    }

    private void DoRefresh()
    {
      Items.Set(GetDebtsInOrder(_desiredOrder).Select(d => new SnowBallSetupItemViewModel(d)));
    }

    private void SaveDesiredOrder()
    {
      _desiredOrder = Items.Select(i => i.Debt.Id).ToArray();
    }

    private IEnumerable<DebtItemViewModel> GetDebtsInOrder(string[] ids)
    {
      var debtTable = Profile.Debts.ToDictionary(d => d.Id);

      // first, get the desired order based on the models
      if (ids != null)
      {
        foreach (var id in ids)
        {
          if (debtTable.TryGetValue(id, out var debt))
          {
            // remove the debt so we don't return it again down below
            debtTable.Remove(id);
            yield return debt;
          }
        }
      }

      // add the remaining debts to the list sorted by their balance
      foreach (var debt in debtTable.Select(v => v.Value).OrderBy(d => d.Balance))
      {
        yield return debt;
      }
    }

    private void Debts_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
    {
      SaveDesiredOrder();
      DoRefresh();
    }
  }
}
