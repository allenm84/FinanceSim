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
    public SetupSnowballDialog(Profile profile)
    {
      InitializeComponent();
      Initiailize(profile);
    }

    public decimal InitialAmount => numInitialSnowball.Value;

    public SnowBallSetup Setup => new SnowBallSetup
    {
      DebtOrder = DebtsInOrder().Select(d => d.Id).ToArray(),
      InitialAmount = InitialAmount,
    };

    private void Initiailize(Profile profile)
    {
      var setup = profile.Snowball;
      var debts = profile.Debts;

      string[] desiredOrder;
      if (setup != null)
      {
        numInitialSnowball.Value = setup.InitialAmount;
        desiredOrder = setup.DebtOrder;
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

    private IEnumerable<Debt> DebtsInOrder() => treeList1.Nodes
      .OfType<TreeListNode>()
      .Select(n => treeList1.GetDataRecordByNode(n))
      .OfType<Debt>();

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
