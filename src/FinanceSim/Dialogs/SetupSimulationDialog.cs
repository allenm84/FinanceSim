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
    static bool sUseSnowball = true;

    public SetupSimulationDialog()
    {
      InitializeComponent();
      dtStart.DateTime = DateTime.Today;
      dtEnd.DateTime = DateTime.Today.AddYears(10);
      chkSnowball.Checked = sUseSnowball;
    }

    public SimulationSetup Setup => new SimulationSetup
    {
      Start = dtStart.DateTime.Date,
      End = dtEnd.DateTime.Date,
      UseSnowball = chkSnowball.Checked,
    };

    private void chkSnowball_CheckedChanged(object sender, EventArgs e)
    {
      var useSnowball = chkSnowball.Checked;
      sUseSnowball = useSnowball;
      dtEnd.Enabled = !useSnowball;
    }
  }
}