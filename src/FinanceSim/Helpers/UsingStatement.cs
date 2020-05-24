using System;

namespace FinanceSim
{
  public partial class MainWindow
  {
    public class UsingStatement : IDisposable
    {
      private Action _onDispose;

      public UsingStatement(Action onDispose)
      {
        _onDispose = onDispose;
      }

      public void Dispose()
      {
        _onDispose?.Invoke();
        _onDispose = null;
      }
    }
  }
}
