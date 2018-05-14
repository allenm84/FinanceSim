using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.Data;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using Newtonsoft.Json;

namespace Finances
{
  public partial class CollectionEdit : XtraUserControl
  {
    private Action _addNewItem;
    private IEditControl _editor;

    public CollectionEdit()
    {
      InitializeComponent();
      gridViewCollection.SelectionChanged += gridViewCollection_SelectionChanged;
      baseNamedItemBindingSource.ListChanged += namedItemSource_ListChanged;
    }

    public string CollectionCaption
    {
      get => layoutControlGroup2.Text;
      set => layoutControlGroup2.Text = value;
    }

    public void Setup<TItem, TItemEditor>(IList<TItem> list)
      where TItem : INamedItem, new()
      where TItemEditor : Control, IEditControl, new()
    {
      baseNamedItemBindingSource.DataSource = list;
      
      _addNewItem = () =>
      {
        var item = new TItem();
        var index = list.Count;
        baseNamedItemBindingSource.Add(item);

        gridViewCollection.BeginSelection();
        gridViewCollection.ClearSelection();
        gridViewCollection.SelectRow(index);
        gridViewCollection.EndSelection();
        gridViewCollection.MakeRowVisible(index);

        layoutControlGroup3.Text = item.Name;
      };

      pnlEditor.SuspendLayout();

      var editor = new TItemEditor();
      editor.Dock = DockStyle.Fill;
      pnlEditor.Controls.Add(editor);
      _editor = editor;

      pnlEditor.ResumeLayout(false);
    }

    public object GetItem(int rowHandle)
    {
      return gridViewCollection.GetRow(rowHandle);
    }

    public GridHitInfo HitTest(int x, int y)
    {
      return gridViewCollection.CalcHitInfo(x, y);
    }

    protected override void OnLoad(EventArgs e)
    {
      base.OnLoad(e);
      gridViewCollection.SelectRow(0);
    }

    private void namedItemSource_ListChanged(object sender, ListChangedEventArgs e)
    {
      if (e.ListChangedType == ListChangedType.ItemChanged)
      {
        var desired = gridViewCollection.GetFocusedRow();
        var actual = baseNamedItemBindingSource[e.NewIndex];
        if (ReferenceEquals(desired, actual) && desired is INamedItem item)
        {
          layoutControlGroup3.Text = item.Name;
        }
      }
    }

    private void gridViewCollection_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
      if (_editor != null)
      {
        var row = gridViewCollection.GetFocusedRow();
        _editor.Source = row;
        if (row is INamedItem item)
        {
          layoutControlGroup3.Text = item.Name;
        }
      }
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
      _addNewItem?.Invoke();
    }

    private void btnRemove_Click(object sender, EventArgs e)
    {
      if (gridViewCollection.SelectedRowsCount > 0 && this.Confirm("Are you sure you want to remove the selected item(s)?"))
      {
        gridViewCollection.DeleteSelectedRows();
      }
    }

    private void btnCopy_Click(object sender, EventArgs e)
    {
      var row = gridViewCollection.GetFocusedRow();
      var type = row.GetType();
      var json = JsonConvert.SerializeObject(row);
      var copy = JsonConvert.DeserializeObject(json, type);
      if (copy is BaseNamedItem item)
      {
        item.Name = $"Copy of {item.Name}";
        baseNamedItemBindingSource.Add(item);
      }
    }

    private void gridCollection_MouseDoubleClick(object sender, MouseEventArgs e)
    {
      if (e.Button == MouseButtons.Left)
      {
        this.OnMouseDoubleClick(e);
      }
    }
  }
}
