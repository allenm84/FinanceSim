using System;
using DevExpress.XtraEditors;

namespace Finances
{
  public partial class PaycheckEdit : XtraUserControl, IEditControl
  {
    private bool _loadingPaycheck;
    private Paycheck _paycheck;

    public PaycheckEdit()
    {
      InitializeComponent();
      txtDescription.TextChanged += editControl_ValueChanged;
    }

    object IEditControl.Source
    {
      get => _paycheck;
      set
      {
        if (value is Paycheck paycheck)
        {
          recurringPaymentEdit1.Payment = paycheck;
          _paycheck = paycheck;
          LoadPaycheck();
        }
      }
    }

    private void LoadPaycheck()
    {
      _loadingPaycheck = true;
      txtDescription.Text = _paycheck.Description;
      _loadingPaycheck = false;
    }

    private void editControl_ValueChanged(object sender, EventArgs e)
    {
      if (!_loadingPaycheck)
      {
        _paycheck.Description = txtDescription.Text;
      }
    }
  }
}
