using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace FinanceSim
{
  public static class JsonConsts
  {
    public static readonly JsonSerializerSettings Settings = new()
    {
      TypeNameHandling = TypeNameHandling.Auto,
    };
  }
}
