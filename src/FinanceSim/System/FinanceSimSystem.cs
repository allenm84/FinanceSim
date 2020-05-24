using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace FinanceSim
{
  public class FinanceSimSystem
  {
    public static MainViewModel View { get; } = new MainViewModel();

    public static async Task LoadData() => await View.LoadData();
    public static async Task SaveData() => await View.SaveData();
  }
}
