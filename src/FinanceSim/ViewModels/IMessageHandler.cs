using System.Collections.Generic;

namespace FinanceSim
{
  public interface IMessageHandler
  {
    bool Confirm(string message, string caption);
    bool Pick<T>(string title, string prompt, IEnumerable<T> choices, out T choice);
    bool PromptSaveFileAs(string title, string filter, out string saveFilePath);
    bool Popup(string title, object content, bool modal);
  }
}
