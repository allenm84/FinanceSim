using System;
using System.ComponentModel;
using System.Drawing;
using DevExpress.XtraEditors;

namespace Finances
{
  public partial class LoanEdit : XtraUserControl, IEditControl
  {
    private bool _loadingLoan;
    private Loan _loan;
    private Size _textSize = new Size(55, 13);

    public LoanEdit()
    {
      InitializeComponent();

      numPayment.ValueChanged += editControl_ValueChanged;
      numBalance.ValueChanged += editControl_ValueChanged;
      cboKind.ValueChanged += editControl_ValueChanged;
      txtName.TextChanged += editControl_ValueChanged;
      dtNextDueDate.DateTimeChanged += editControl_ValueChanged;
      ctrlInterestRate.ValueChanged += editControl_ValueChanged;
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    public DevExpress.XtraLayout.Utils.Padding GroupPadding
    {
      get => layoutControlGroup1.Padding;
      set => layoutControlGroup1.Padding = value;
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    public Size TextSize
    {
      get => _textSize;
      set
      {
        _textSize = value;
        UpdateTextSize();
      }
    }

    [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public Loan Loan
    {
      get => _loan;
      set
      {
        _loan = value;
        LoadLoan();
      }
    }

    object IEditControl.Source
    {
      get => Loan;
      set
      {
        if (value is Loan loan)
        {
          Loan = loan;
        }
      }
    }

    private void UpdateTextSize()
    {
      layoutControlItem1.TextSize = _textSize;
      layoutControlItem2.TextSize = _textSize;
      layoutControlItem5.TextSize = _textSize;
      layoutControlItem6.TextSize = _textSize;
      layoutControlItem8.TextSize = _textSize;
    }

    private void LoadLoan()
    {
      _loadingLoan = true;

      numPayment.Value = _loan.Amount;
      numBalance.Value = _loan.Balance;
      cboKind.Value = _loan.Kind;
      txtName.Text = _loan.Name;
      dtNextDueDate.DateTime = _loan.NextDueDate;
      ctrlInterestRate.Value = _loan.InterestRate;

      _loadingLoan = false;
    }

    private void editControl_ValueChanged(object sender, EventArgs e)
    {
      if (!_loadingLoan)
      {
        _loan.Amount = numPayment.Value;
        _loan.Balance = numBalance.Value;
        _loan.Kind = cboKind.Value;
        _loan.Name = txtName.Text;
        _loan.NextDueDate = dtNextDueDate.DateTime.Date;
        _loan.InterestRate = ctrlInterestRate.Value;
      }
    }
  }
}
