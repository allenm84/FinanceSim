using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceSim
{
  public struct DueInfo
  {
    public DateTime Start { get; set; }
    public DateTime? End { get; set; }
    public DueType Type { get; set; }
    public int Period { get; set; }
    public DateTime Seed { get; set; }

    public override string ToString()
    {
      return DueInfoHelper.GetDisplay(this);
    }
  }
}
