using System;
using System.Windows;

namespace FinanceSim
{
  /// <summary>
  /// Interaction logic for PopupWindow.xaml
  /// </summary>
  public partial class PopupWindow : Window
  {
    public PopupWindow()
    {
      InitializeComponent();
    }

    private void UpdateOkCancel(bool modal)
    {
      btnOK.IsEnabled = modal;
      btnCancel.IsEnabled = modal;
      pnlOkCancel.Visibility = modal ? 
        Visibility.Visible : 
        Visibility.Collapsed;
    }

    public bool ShowPopup(bool modal)
    {
      UpdateOkCancel(modal);

      if (modal)
      {
        return ShowDialog() == true;
      }
      else
      {
        SizeToContent = SizeToContent.Manual;
        ResizeMode = ResizeMode.CanResizeWithGrip;
        Show();
        return true;
      }
    }

    private void btnOK_Click(object sender, RoutedEventArgs e)
    {
      DialogResult = true;
      Close();
    }

    private void btnCancel_Click(object sender, RoutedEventArgs e)
    {
      DialogResult = false;
      Close();
    }
  }
}
