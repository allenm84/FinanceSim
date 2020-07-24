using System;
using System.Collections.Generic;

namespace FinanceSim
{
  public class SimulationLookupState
  {
    public SimulationNoticeBoard NoticeAccount { get; } = new SimulationNoticeBoard();
    public Dictionary<IAccount, List<SimulationResultItem>> Transactions { get; set; }

    public bool IsDone { get; set; }

    public DateTime Start { get; set; }
    public List<IHasDueInfo> RemainingItems { get; set; }
    public Dictionary<string, DateTime> NextDueDate { get; set; }
    public Dictionary<string, decimal> AccountBalances { get; set; }
    public Dictionary<string, IAccount> Accounts { get; set; }
    public List<SimulationEvent> Events { get; set; }

    public bool UseSnowball { get; set; }
    public decimal SnowballAmount { get; set; }
    public Queue<Debt> SnowballTargets { get; set; }
    public Debt CurrentSnowballTarget { get; set; }
  }
}
