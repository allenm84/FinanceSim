namespace FinanceSim
{
  public abstract class BaseNamedWithoutId : IHasName
  {
    public string Id => "{no-id}";
    public string Name { get; set; }
  }
}