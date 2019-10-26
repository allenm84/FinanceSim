using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceSim
{
  public sealed class IHasIdComparer<T> : IEqualityComparer<T> where T  : IHasId
  {
    static readonly Lazy<IHasIdComparer<T>> sInstance;
    static IHasIdComparer()
    {
      sInstance = new Lazy<IHasIdComparer<T>>(() => new IHasIdComparer<T>(), true);
    }

    public static IHasIdComparer<T> Instance => sInstance.Value;

    private IHasIdComparer() { }

    bool IEqualityComparer<T>.Equals(T x, T y)
    {
      return string.Equals(x.Id, y.Id);
    }

    int IEqualityComparer<T>.GetHashCode(T obj)
    {
      return obj.Id.GetHashCode();
    }
  }
}
