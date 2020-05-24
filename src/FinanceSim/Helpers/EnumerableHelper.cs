using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceSim
{
  public static class EnumerableHelper
  {
    public static IEnumerable<T> Iterate<T>(params IEnumerable<T>[] collections)
    {
      return collections.Where(c => c != null).SelectMany(c => c);
    }

    public static void AddRange<T>(this ICollection<T> collection, IEnumerable<T> items)
    {
      if (items == null || collection == null)
      {
        return;
      }

      foreach (T item in items)
      {
        collection.Add(item);
      }
    }

    public static IEnumerable<T> OrEmpty<T>(this IEnumerable<T> collection) => collection ?? Enumerable.Empty<T>();
  }
}
