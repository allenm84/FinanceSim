using System.Collections.Generic;

namespace FinanceSim
{
  public static class EnumerableHelper
  {
    public static T SafeDequeue<T>(this Queue<T> queue) => queue.Count > 0 ? queue.Dequeue() : default;
  }
}
