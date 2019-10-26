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
  public partial class SetupEventsDialog : BaseForm
  {
    public SetupEventsDialog(Profile profile)
    {
      InitializeComponent();
      Initialize(profile);
    }

    public EventSetup Setup => new EventSetup
    {
      AdjustSnowballAmountEvents = adjustSnowballAmountEventBindingSource.OfType<AdjustSnowballAmountEvent>().ToList(),
      ChangeBillPaymentEvents = changeBillPaymentEventBindingSource.OfType<ChangeBillPaymentEvent>().ToList(),
      AdjustPaycheckTotalEvents = adjustPaycheckTotalEventBindingSource.OfType<AdjustPaycheckTotalEvent>().ToList(),
    };

    private void Initialize(Profile profile)
    {
      foreach (var bill in profile.OfType<Bill>())
      {
        billBindingSource.Add(bill);
      }

      foreach (var paycheck in profile.OfType<Paycheck>())
      {
        paycheckBindingSource.Add(paycheck);
      }

      var events = profile.Events?.Clone();
      if (events != null)
      {
        events.AdjustSnowballAmountEvents = events.AdjustSnowballAmountEvents.Ensure();
        events.ChangeBillPaymentEvents = events.ChangeBillPaymentEvents.Ensure();
        events.AdjustPaycheckTotalEvents = events.AdjustPaycheckTotalEvents.Ensure();

        foreach (var item in events.AdjustSnowballAmountEvents)
        {
          adjustSnowballAmountEventBindingSource.Add(item);
        }
        foreach (var item in events.ChangeBillPaymentEvents)
        {
          changeBillPaymentEventBindingSource.Add(item);
        }
        foreach (var item in events.AdjustPaycheckTotalEvents)
        {
          adjustPaycheckTotalEventBindingSource.Add(item);
        }
      }
    }
  }
}
