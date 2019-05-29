using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceSim
{
  public class SnowballDebtOrder
  {
    private readonly Debt[] _order;
    private int _currentIndex = -1;

    public SnowballDebtOrder(IEnumerable<Debt> debts)
    {
      _order = debts.ToArray();
      _currentIndex = 0;
    }

    public Debt Current => IsCurrentIndexValid() ? _order[_currentIndex] : null;

    private bool IsCurrentIndexValid() => (-1 < _currentIndex && _currentIndex < _order.Length);

    public bool IsCurrent(Debt debt)
    {
      if (debt == null)
      {
        return false;
      }

      return string.Equals(Current?.Id, debt.Id);
    }

    public bool MoveNext()
    {
      ++_currentIndex;
      return IsCurrentIndexValid();
    }
  }
}
