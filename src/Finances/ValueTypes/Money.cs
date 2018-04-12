using System;

namespace Finances
{
  [Serializable]
  public struct Money : IComparable<Money>, IComparable
  {
    public decimal Value;

    public Money(decimal value)
    {
      Value = value;
    }

    public static implicit operator Money(decimal d)
    {
      return new Money(d);
    }

    public static Money operator -(Money x)
    {
      return new Money(-x.Value);
    }

    public static Money operator +(Money x)
    {
      return new Money(x.Value);
    }

    public static Money operator ++(Money x)
    {
      return new Money(x.Value++);
    }

    public static Money operator --(Money x)
    {
      return new Money(x.Value--);
    }

    public static Money operator %(Money x, Money y)
    {
      return new Money(x.Value % y.Value);
    }

    public static Money operator %(decimal x, Money y)
    {
      return new Money(x % y.Value);
    }

    public static Money operator %(Money x, decimal y)
    {
      return new Money(x.Value % y);
    }

    public static Money operator -(Money x, Money y)
    {
      return new Money(x.Value - y.Value);
    }

    public static Money operator +(Money x, Money y)
    {
      return new Money(x.Value + y.Value);
    }

    public static Money operator /(Money x, Money y)
    {
      return new Money(x.Value / y.Value);
    }

    public static Money operator *(Money x, Money y)
    {
      return new Money(x.Value * y.Value);
    }

    public static Money operator -(decimal x, Money y)
    {
      return new Money(x - y.Value);
    }

    public static Money operator +(decimal x, Money y)
    {
      return new Money(x + y.Value);
    }

    public static Money operator /(decimal x, Money y)
    {
      return new Money(x / y.Value);
    }

    public static Money operator *(decimal x, Money y)
    {
      return new Money(x * y.Value);
    }

    public static Money operator -(Money x, decimal y)
    {
      return new Money(x.Value - y);
    }

    public static Money operator +(Money x, decimal y)
    {
      return new Money(x.Value + y);
    }

    public static Money operator /(Money x, decimal y)
    {
      return new Money(x.Value / y);
    }

    public static Money operator *(Money x, decimal y)
    {
      return new Money(x.Value * y);
    }

    public override string ToString()
    {
      return $"{Value:c2}";
    }

    private static int DoCompare(Money x, Money y)
    {
      return decimal.Compare(x.Value, y.Value);
    }

    int IComparable<Money>.CompareTo(Money other)
    {
      return DoCompare(this, other);
    }

    int IComparable.CompareTo(object obj)
    {
      var other = (Money)obj;
      return DoCompare(this, other);
    }
  }
}