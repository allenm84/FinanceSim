using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using Newtonsoft.Json;

namespace Finances
{
  public partial class CollectionButtonEdit : XtraUserControl
  {
    private MethodInfo _setup;
    private Func<string> _push;
    private Action<string> _pop;
    private object _list;

    public CollectionButtonEdit()
    {
      InitializeComponent();
    }

    public void Setup<TItem, TItemEditor>(IList<TItem> list)
      where TItem : INamedItem, new()
      where TItemEditor : Control, IEditControl, new()
    {
      var type = typeof(CollectionEdit);
      var method = type.GetMethod(nameof(CollectionEdit.Setup));

      _list = list;
      _setup = method.MakeGenericMethod(typeof(TItem), typeof(TItemEditor));
      _push = () => JsonConvert.SerializeObject(list);
      _pop = (json) =>
      {
        var data = JsonConvert.DeserializeObject(json, list.GetType());
        if (data is IList<TItem> sourceList)
        {
          list.Clear();
          foreach (var item in sourceList)
          {
            list.Add(item);
          }
        }
      };
    }

    private void buttonEdit1_ButtonClick(object sender, ButtonPressedEventArgs e)
    {
      using (var dlg = new CollectionEditDialog())
      {
        var json = _push?.Invoke();
        _setup.Invoke(dlg.Properties, new[] { _list });
        if (dlg.ShowDialog(this) != DialogResult.OK)
        {
          _pop?.Invoke(json);
        }
      }
    }
  }
}
