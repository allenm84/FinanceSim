using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceSim
{
  public interface IHasDueInfo : IHasId
  {
    DueInfo Due { get; }
  }
}
