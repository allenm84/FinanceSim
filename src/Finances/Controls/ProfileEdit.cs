using System;
using DevExpress.XtraEditors;

namespace Finances
{
  public partial class ProfileEdit : XtraUserControl, IEditControl
  {
    private bool _loadingProfile = false;
    private Profile _profile;

    public ProfileEdit()
    {
      InitializeComponent();

      txtName.TextChanged += editControl_ValueChanged;
      dtStartDate.DateTimeChanged += editControl_ValueChanged;
      numStartingBalance.ValueChanged += editControl_ValueChanged;
      numYears.ValueChanged += editControl_ValueChanged;
    }

    object IEditControl.Source
    {
      get => _profile;
      set
      {
        if (value is Profile profile)
        {
          _profile = profile;
          LoadProfile();
        }
      }
    }

    private void LoadProfile()
    {
      _loadingProfile = true;
      
      txtName.Text = _profile.Name;
      dtStartDate.DateTime = _profile.StartDate;
      numStartingBalance.Value = _profile.StartingBalance;
      numYears.Value = _profile.Years;

      ctrlCreditCards.Setup<CreditCard, CreditCardEdit>(_profile.CreditCards);
      ctrlLoans.Setup<Loan, LoanEdit>(_profile.Loans);
      ctrlPaychecks.Setup<Paycheck, PaycheckEdit>(_profile.Paychecks);
      ctrlRecurringPayments.Setup<RecurringPayment, RecurringPaymentEdit>(_profile.RecurringPayments);

      _loadingProfile = false;
    }

    private void editControl_ValueChanged(object sender, EventArgs e)
    {
      if (!_loadingProfile)
      {
        _profile.Name = txtName.Text;
        _profile.StartDate = dtStartDate.DateTime;
        _profile.StartingBalance = numStartingBalance.Value;
        _profile.Years = (int)numYears.Value;
      }
    }
  }
}
