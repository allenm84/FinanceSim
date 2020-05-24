using System;
using System.Collections.Generic;

namespace FinanceSim
{
  public static class Messenger
  {
    static IMessengeHandler sHandler;

    public static void Register(IMessengeHandler handler)
    {
      sHandler = handler;
    }

    public static bool Confirm(string message, string caption)
    {
      return sHandler?.Confirm(message, caption) ?? false;
    }

    public static bool Pick<T>(string title, string prompt, IEnumerable<T> choices, out T choice)
    {
      choice = default;
      return sHandler?.Pick(title, prompt, choices, out choice) ?? false;
    }

    public static bool PromptSaveFileAs(string title, string filter, out string saveFilePath)
    {
      saveFilePath = null;
      return sHandler?.PromptSaveFileAs(title, filter, out saveFilePath) ?? false;
    }

    public static bool Popup(string title, object content, bool modal)
    {
      return sHandler?.Popup(title, content, modal) ?? false;
    }
  }
}
