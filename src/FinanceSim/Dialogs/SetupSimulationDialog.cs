using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace FinanceSim
{
  public partial class SetupSimulationDialog : BaseForm
  {
    public SetupSimulationDialog()
    {
      InitializeComponent();
      Start = DateTime.Today;
      End = DateTime.Today.AddYears(10);
    }

    public DateTime Start
    {
      get => dtStart.DateTime.Date;
      set => dtStart.DateTime = value.Date;
    }

    public DateTime End
    {
      get => dtEnd.DateTime.Date;
      set => dtEnd.DateTime = value.Date;
    }
  }
}