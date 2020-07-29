using System;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;

namespace FinanceSim
{
  public class HasBalanceAccountsViewModel : BaseCollectionEditorAggregateViewModel<IHasBalanceViewModel>
  {
    private readonly DebtsViewModel _debts;
    private DebtItemViewModel[] _debtItems = Array.Empty<DebtItemViewModel>();

    public HasBalanceAccountsViewModel(BankAccountsViewModel accounts, DebtsViewModel debts) 
      : base(accounts, debts)
    {
      _debts = debts;
      _debts.CollectionChanged += OnDebtsCollectionChanged;
      UpdateItemCache();
    }

    private void UpdateItemCache()
    {
      Array.ForEach(_debtItems, d => d.PropertyChanged -= OnDebtItemPropertyChanged);

      _debtItems = _debts.GetItems().ToArray();

      Array.ForEach(_debtItems, d => d.PropertyChanged += OnDebtItemPropertyChanged);
    }

    protected override bool IsValid(IHasBalanceViewModel item)
    {
      if (item is DebtItemViewModel debt)
      {
        return debt.Type == DebtType.Revolving;
      }

      return true;
    }

    private void OnDebtItemPropertyChanged(object sender, PropertyChangedEventArgs e)
    {
      UpdateCollection();
    }

    private void OnDebtsCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
    {
      UpdateItemCache();
    }
  }
}