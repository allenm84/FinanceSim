using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceSim
{
  public class SimulationState
  {
    public SimulationNoticeBoard NoticeAccount { get; } = new SimulationNoticeBoard();
    public Dictionary<IAccount, List<Transaction>> Transactions { get; set; }

    public bool IsDone { get; set; }

    public DateTime Start { get; set; }
    public List<IHasDueInfo> RemainingItems { get; set; }
    public Dictionary<string, DateTime> NextDueDate { get; set; }
    public Dictionary<string, decimal> AccountBalances { get; set; }
    public Dictionary<string, decimal> DebtBalances { get; set; }
    public Dictionary<string, IAccount> Accounts { get; set; }
    public List<SimulationEvent> Events { get; set; }

    public bool UseSnowball { get; set; }
    public decimal SnowballAmount { get; set; }
    public Queue<Debt> SnowballTargets { get; set; }
    public Debt CurrentSnowballTarget { get; set; }
  }
}
