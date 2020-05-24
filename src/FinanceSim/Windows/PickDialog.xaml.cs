using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace FinanceSim
{
  /// <summary>
  /// Interaction logic for PickDialog.xaml
  /// </summary>
  public partial class PickDialog : Window
  {
    public PickDialog()
    {
      InitializeComponent();
    }

    public string Prompt
    {
      get => lblPrompt.Text;
      set => lblPrompt.Text = value;
    }

    public bool GetSelected<T>(out T item)
    {
      item = default;

      var rb = sp.Children.OfType<RadioButton>().Single(r => r.IsChecked == true);
      if (rb.Content is T value)
      {
        item = value;
        return true;
      }

      return false;
    }

    public void Populate<T>(IEnumerable<T> items)
    {
      var isFirst = true;
      foreach (var item in items)
      {
        var rb = new RadioButton() { Content = item, GroupName = "ChoicesGroup", IsChecked = isFirst };
        sp.Children.Add(rb);
        isFirst = false;
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
