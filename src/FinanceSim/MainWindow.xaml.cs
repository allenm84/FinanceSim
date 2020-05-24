using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Input;
using Microsoft.Win32;

namespace FinanceSim
{
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window, IMessengeHandler
  {
    public MainWindow()
    {
      InitializeComponent();
      Messenger.Register(this);
      LoadData();
    }

    private async void LoadData()
    {
      using (DisplayWait())
      {
        await FinanceSimSystem.LoadData();
      }
    }

    private async void SaveData()
    {
      using (DisplayWait())
      {
        await FinanceSimSystem.SaveData();
      }
    }

    private IDisposable DisplayWait()
    {
      busyIndicator.IsBusy = true;
      return new UsingStatement(() =>
      {
        busyIndicator.IsBusy = false;
      });
    }

    private void tbbSave_ItemClick(object sender, RoutedEventArgs e)
    {
      SaveData();
    }

    bool IMessengeHandler.Confirm(string message, string caption)
    {
      var result = MessageBox.Show(message, caption, MessageBoxButton.YesNo, MessageBoxImage.Question);
      return (result == MessageBoxResult.Yes);
    }

    bool IMessengeHandler.Pick<T>(string title, string prompt, IEnumerable<T> choices, out T choice)
    {
      choice = default;

      var dlg = new PickDialog
      {
        Prompt = prompt,
        Title = title
      };

      dlg.Populate(choices);
      return 
        dlg.ShowDialog() == true && 
        dlg.GetSelected(out choice);
    }

    bool IMessengeHandler.PromptSaveFileAs(string title, string filter, out string saveFilePath)
    {
      saveFilePath = "";

      var dlg = new SaveFileDialog();
      {
        dlg.OverwritePrompt = true;
        dlg.Filter = filter;

        if (dlg.ShowDialog(this) == true)
        {
          saveFilePath = dlg.FileName;
        }
      }

      return !string.IsNullOrWhiteSpace(saveFilePath);
    }

    bool IMessengeHandler.Popup(string title, object content, bool modal)
    {
      var dlg = new PopupWindow()
      {
        Title = title,
        DataContext = content,
      };

      return dlg.ShowPopup(modal);
    }
  }
}
