using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finances
{
  public class SimEngineResult
  {
    public List<Transaction> Transactions;
    public Dictionary<Loan, LoanInfo> LoanTransactions;
  }
}
