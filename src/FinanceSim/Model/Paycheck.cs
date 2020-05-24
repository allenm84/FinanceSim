using System.Collections.Generic;

namespace FinanceSim
{
  public class Paycheck : IHasDueInfo
  {
    public string Id { get; set; }
    public string AccountId { get; set; }
    public string Name { get; set; }
    public decimal Total { get; set; }
    public DueInfo Due { get; set; }
    public List<PaycheckDeposit> Deposits { get; set; }
  }
}
