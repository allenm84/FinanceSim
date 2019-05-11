using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinanceSim
{
  public partial class SetupSnowballDialog : BaseForm
  {
    public SetupSnowballDialog(IEnumerable<Debt> debts)
    {
      InitializeComponent();

      dtStart.DateTime = DateTime.Today;

      foreach (var debt in debts)
      {
        debtBindingSource.Add(debt);
      }
    }

    public DateTime Start => dtStart.DateTime.Date;

    public decimal InitialAmount => numInitialSnowball.Value;

    public Debt SelectedDebt => cboDebts.EditValue as Debt;
  }
}
