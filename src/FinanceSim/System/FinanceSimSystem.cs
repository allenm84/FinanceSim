using System.Threading.Tasks;

namespace FinanceSim
{
  public class FinanceSimSystem
  {
    public static MainViewModel View { get; } = new();

    public static async Task LoadData() => await View.LoadData();
    public static async Task SaveData() => await View.SaveData();
  }
}
