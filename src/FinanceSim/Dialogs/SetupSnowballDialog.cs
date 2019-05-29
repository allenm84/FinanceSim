using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Utils.DragDrop;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraTreeList.Nodes;

namespace FinanceSim
{
  public partial class SetupSnowballDialog : BaseForm
  {
    static (DateTime, decimal, string[])? sPreviousChoice = null;

    public SetupSnowballDialog(IEnumerable<Debt> debts)
    {
      InitializeComponent();
      dtStart.DateTime = DateTime.Today;
      Pop(debts);
    }

    public DateTime Start => dtStart.DateTime.Date;

    public decimal InitialAmount => numInitialSnowball.Value;

    public SnowballDebtOrder Order => CreateOrder();

    private void Pop(IEnumerable<Debt> debts)
    {
      string[] desiredOrder;
      if (sPreviousChoice.HasValue)
      {
        (DateTime time, decimal amount, string[] ids) = sPreviousChoice.Value;
        dtStart.DateTime = time;
        numInitialSnowball.Value = amount;
        desiredOrder = ids;
      }
      else
      {
        desiredOrder = debts
          .OrderBy(d => d.Balance)
          .Select(d => d.Id)
          .ToArray();
      }

      var table = desiredOrder
        .Select((id, index) => (id, index))
        .ToDictionary(k => k.id, v => v.index, StringComparer.OrdinalIgnoreCase);

      foreach (var debt in debts.OrderBy(d => GetOrder(d)))
      {
        debtBindingSource.Add(debt);
      }

      int GetOrder(Debt debt)
      {
        if (table.TryGetValue(debt.Id, out var index))
        {
          return index;
        }
        return int.MaxValue;
      }
    }

    private void Push()
    {
      sPreviousChoice = (Start, InitialAmount, DebtsInOrder().Select(d => d.Id).ToArray());
    }

    private IEnumerable<Debt> DebtsInOrder() => treeList1.Nodes
      .OfType<TreeListNode>()
      .Select(n => treeList1.GetDataRecordByNode(n))
      .OfType<Debt>();

    private SnowballDebtOrder CreateOrder() => new SnowballDebtOrder(DebtsInOrder());

    protected override void OnFormClosing(FormClosingEventArgs e)
    {
      base.OnFormClosing(e);
      if (!e.Cancel)
      {
        Push();
      }
    }

    private void dragDropEvents1_DragOver(object sender, DragOverEventArgs e)
    {
      e.Default();

      if (e.InsertType == InsertType.AsChild)
      {
        e.Action = DragDropActions.None;
        e.InsertType = InsertType.None;
      }
      e.Handled = true;
    }
  }
}
