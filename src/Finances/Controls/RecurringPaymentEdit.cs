using System;
using System.ComponentModel;
using System.Drawing;
using DevExpress.XtraEditors;

namespace Finances
{
  public partial class RecurringPaymentEdit : XtraUserControl, IEditControl
  {
    private bool _loadingPayment;
    private RecurringPayment _payment;
    private Size _textSize = new Size(45, 13);

    public RecurringPaymentEdit()
    {
      InitializeComponent();

      numAmount.ValueChanged += editControl_ValueChanged;
      cboKind.ValueChanged += editControl_ValueChanged;
      txtName.TextChanged += editControl_ValueChanged;
      dtNextDueDate.DateTimeChanged += editControl_ValueChanged;

      UpdateTextSize();
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
    public RecurringPayment Payment
    {
      get => _payment;
      set
      {
        _payment = value;
        LoadPayment();
      }
    }

    object IEditControl.Source
    {
      get => Payment;
      set
      {
        if (value is RecurringPayment payment)
        {
          Payment = payment;
        }
      }
    }

    private void UpdateTextSize()
    {
      layoutControlItem1.TextSize = _textSize;
      layoutControlItem3.TextSize = _textSize;
      layoutControlItem4.TextSize = _textSize;
      layoutControlItem5.TextSize = _textSize;
    }

    private void LoadPayment()
    {
      _loadingPayment = true;

      numAmount.Value = _payment.Amount;
      cboKind.Value = _payment.Kind;
      txtName.Text = _payment.Name;
      dtNextDueDate.DateTime = _payment.NextDueDate;

      _loadingPayment = false;
    }

    private void editControl_ValueChanged(object sender, EventArgs e)
    {
      if (!_loadingPayment)
      {
        _payment.Amount = numAmount.Value;
        _payment.Kind = cboKind.Value;
        _payment.Name = txtName.Text;
        _payment.NextDueDate = dtNextDueDate.DateTime.Date;
      }
    }
  }
}
