namespace FinanceSim
{
  public interface IHasDueInfo : IHasName
  {
    DueInfo Due { get; set; }
  }
}
