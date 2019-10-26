using Microsoft.CodeAnalysis.CSharp.Scripting;
using Microsoft.CodeAnalysis.Scripting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FinanceSim
{
  public class SimulationEvent
  {
    public SimulationEvent(DateTime date, string script, params object[] args)
    {
      Date = date;
      Script = script;
      Arguments = args;
    }

    public DateTime Date { get; }

    private string Script { get; }
    private object[] Arguments { get; }

    public async Task Apply()
    {
      // create an array for the names
      var names = Arguments.Select((a, i) => $"var{i}").Cast<object>().ToArray();

      // replace the expression text with these names
      var expr = string.Format(Script, names);

      // create a lamba from the expression
      var lambaInput = string.Join(", ", names);
      var lambda = $"({lambaInput}) => {expr}";

      // get the type
      var actionType = Expression.GetActionType(Arguments.Select(a => a.GetType()).ToArray());

      // get the method that will be used to create the delegate
      var method = typeof(CSharpScript)
        .GetMethods(BindingFlags.Public | BindingFlags.Static)
        .Where(m => string.Equals(m.Name, nameof(CSharpScript.EvaluateAsync)))
        .Single(m => m.IsGenericMethodDefinition)
        .MakeGenericMethod(actionType);

      // call the method
      var options = ScriptOptions.Default.AddReferences(typeof(State).Assembly);
      if (method.Invoke(null, new object[] { lambda, options, null, null, default(CancellationToken) }) is Task task)
      {
        await task.ConfigureAwait(false);
        Delegate result = ((dynamic)task).Result;
        result.DynamicInvoke(Arguments);
      }
    }
  }
}
