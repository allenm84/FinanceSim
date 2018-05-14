using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finances
{
  public class LoanInfo
  {
    public int PaymentCount = 1;
    public List<Transaction> Transactions = new List<Transaction>();
  }
}
