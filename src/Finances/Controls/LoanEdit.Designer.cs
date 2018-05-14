namespace Finances
{
  partial class LoanEdit
  {
    /// <summary> 
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary> 
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
      this.dtNextDueDate = new DevExpress.XtraEditors.DateEdit();
      this.txtName = new DevExpress.XtraEditors.TextEdit();
      this.numBalance = new DevExpress.XtraEditors.SpinEdit();
      this.numPayment = new DevExpress.XtraEditors.SpinEdit();
      this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
      this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
      this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
      this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
      this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
      this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
      this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
      this.ctrlInterestRate = new Finances.InterestRateEdit();
      this.cboKind = new Finances.RecurringPaymentKindEdit();
      this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
      this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
      this.layoutControl1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dtNextDueDate.Properties.CalendarTimeProperties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dtNextDueDate.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numBalance.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numPayment.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
      this.SuspendLayout();
      // 
      // layoutControl1
      // 
      this.layoutControl1.Controls.Add(this.ctrlInterestRate);
      this.layoutControl1.Controls.Add(this.cboKind);
      this.layoutControl1.Controls.Add(this.dtNextDueDate);
      this.layoutControl1.Controls.Add(this.txtName);
      this.layoutControl1.Controls.Add(this.numBalance);
      this.layoutControl1.Controls.Add(this.numPayment);
      this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.layoutControl1.Location = new System.Drawing.Point(0, 0);
      this.layoutControl1.Name = "layoutControl1";
      this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(773, 167, 650, 400);
      this.layoutControl1.Root = this.layoutControlGroup1;
      this.layoutControl1.Size = new System.Drawing.Size(314, 263);
      this.layoutControl1.TabIndex = 0;
      this.layoutControl1.Text = "layoutControl1";
      // 
      // dtNextDueDate
      // 
      this.dtNextDueDate.EditValue = null;
      this.dtNextDueDate.Location = new System.Drawing.Point(70, 108);
      this.dtNextDueDate.Name = "dtNextDueDate";
      this.dtNextDueDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.dtNextDueDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.dtNextDueDate.Size = new System.Drawing.Size(232, 20);
      this.dtNextDueDate.StyleController = this.layoutControl1;
      this.dtNextDueDate.TabIndex = 9;
      // 
      // txtName
      // 
      this.txtName.Location = new System.Drawing.Point(70, 84);
      this.txtName.Name = "txtName";
      this.txtName.Size = new System.Drawing.Size(232, 20);
      this.txtName.StyleController = this.layoutControl1;
      this.txtName.TabIndex = 8;
      // 
      // numBalance
      // 
      this.numBalance.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.numBalance.Location = new System.Drawing.Point(70, 36);
      this.numBalance.Name = "numBalance";
      this.numBalance.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.numBalance.Properties.DisplayFormat.FormatString = "c2";
      this.numBalance.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
      this.numBalance.Size = new System.Drawing.Size(232, 20);
      this.numBalance.StyleController = this.layoutControl1;
      this.numBalance.TabIndex = 5;
      // 
      // numPayment
      // 
      this.numPayment.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.numPayment.Location = new System.Drawing.Point(70, 12);
      this.numPayment.Name = "numPayment";
      this.numPayment.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.numPayment.Properties.DisplayFormat.FormatString = "c2";
      this.numPayment.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
      this.numPayment.Size = new System.Drawing.Size(232, 20);
      this.numPayment.StyleController = this.layoutControl1;
      this.numPayment.TabIndex = 4;
      // 
      // layoutControlGroup1
      // 
      this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
      this.layoutControlGroup1.GroupBordersVisible = false;
      this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.emptySpaceItem1,
            this.layoutControlItem2,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.layoutControlItem8,
            this.layoutControlGroup2});
      this.layoutControlGroup1.Name = "Root";
      this.layoutControlGroup1.OptionsItemText.TextAlignMode = DevExpress.XtraLayout.TextAlignModeGroup.CustomSize;
      this.layoutControlGroup1.Size = new System.Drawing.Size(314, 263);
      this.layoutControlGroup1.TextVisible = false;
      // 
      // layoutControlItem1
      // 
      this.layoutControlItem1.AppearanceItemCaption.FontStyleDelta = System.Drawing.FontStyle.Bold;
      this.layoutControlItem1.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem1.Control = this.numPayment;
      this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
      this.layoutControlItem1.Name = "layoutControlItem1";
      this.layoutControlItem1.Size = new System.Drawing.Size(294, 24);
      this.layoutControlItem1.Text = "Payment";
      this.layoutControlItem1.TextSize = new System.Drawing.Size(55, 13);
      // 
      // emptySpaceItem1
      // 
      this.emptySpaceItem1.AllowHotTrack = false;
      this.emptySpaceItem1.Location = new System.Drawing.Point(0, 239);
      this.emptySpaceItem1.MinSize = new System.Drawing.Size(10, 1);
      this.emptySpaceItem1.Name = "emptySpaceItem1";
      this.emptySpaceItem1.Size = new System.Drawing.Size(294, 4);
      this.emptySpaceItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
      this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
      // 
      // layoutControlItem2
      // 
      this.layoutControlItem2.AppearanceItemCaption.FontStyleDelta = System.Drawing.FontStyle.Bold;
      this.layoutControlItem2.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem2.Control = this.numBalance;
      this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
      this.layoutControlItem2.Name = "layoutControlItem2";
      this.layoutControlItem2.Size = new System.Drawing.Size(294, 24);
      this.layoutControlItem2.Text = "Balance";
      this.layoutControlItem2.TextSize = new System.Drawing.Size(55, 13);
      // 
      // layoutControlItem5
      // 
      this.layoutControlItem5.AppearanceItemCaption.FontStyleDelta = System.Drawing.FontStyle.Bold;
      this.layoutControlItem5.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem5.Control = this.txtName;
      this.layoutControlItem5.Location = new System.Drawing.Point(0, 72);
      this.layoutControlItem5.Name = "layoutControlItem5";
      this.layoutControlItem5.Size = new System.Drawing.Size(294, 24);
      this.layoutControlItem5.Text = "Name";
      this.layoutControlItem5.TextSize = new System.Drawing.Size(55, 13);
      // 
      // layoutControlItem6
      // 
      this.layoutControlItem6.AppearanceItemCaption.FontStyleDelta = System.Drawing.FontStyle.Bold;
      this.layoutControlItem6.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem6.Control = this.dtNextDueDate;
      this.layoutControlItem6.Location = new System.Drawing.Point(0, 96);
      this.layoutControlItem6.Name = "layoutControlItem6";
      this.layoutControlItem6.Size = new System.Drawing.Size(294, 24);
      this.layoutControlItem6.Text = "Next";
      this.layoutControlItem6.TextSize = new System.Drawing.Size(55, 13);
      // 
      // layoutControlGroup2
      // 
      this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem3});
      this.layoutControlGroup2.Location = new System.Drawing.Point(0, 120);
      this.layoutControlGroup2.Name = "layoutControlGroup2";
      this.layoutControlGroup2.Size = new System.Drawing.Size(294, 119);
      this.layoutControlGroup2.Text = "Interest Rate";
      // 
      // ctrlInterestRate
      // 
      this.ctrlInterestRate.Location = new System.Drawing.Point(24, 162);
      this.ctrlInterestRate.Name = "ctrlInterestRate";
      this.ctrlInterestRate.Size = new System.Drawing.Size(266, 73);
      this.ctrlInterestRate.TabIndex = 12;
      // 
      // cboKind
      // 
      this.cboKind.Location = new System.Drawing.Point(70, 60);
      this.cboKind.Name = "cboKind";
      this.cboKind.Size = new System.Drawing.Size(232, 20);
      this.cboKind.TabIndex = 11;
      // 
      // layoutControlItem8
      // 
      this.layoutControlItem8.AppearanceItemCaption.FontStyleDelta = System.Drawing.FontStyle.Bold;
      this.layoutControlItem8.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem8.Control = this.cboKind;
      this.layoutControlItem8.Location = new System.Drawing.Point(0, 48);
      this.layoutControlItem8.Name = "layoutControlItem8";
      this.layoutControlItem8.Size = new System.Drawing.Size(294, 24);
      this.layoutControlItem8.Text = "Kind";
      this.layoutControlItem8.TextSize = new System.Drawing.Size(55, 13);
      // 
      // layoutControlItem3
      // 
      this.layoutControlItem3.Control = this.ctrlInterestRate;
      this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
      this.layoutControlItem3.MaxSize = new System.Drawing.Size(0, 77);
      this.layoutControlItem3.MinSize = new System.Drawing.Size(112, 77);
      this.layoutControlItem3.Name = "layoutControlItem3";
      this.layoutControlItem3.Size = new System.Drawing.Size(270, 77);
      this.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
      this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
      this.layoutControlItem3.TextVisible = false;
      // 
      // LoanEdit
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.layoutControl1);
      this.Name = "LoanEdit";
      this.Size = new System.Drawing.Size(314, 263);
      ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
      this.layoutControl1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dtNextDueDate.Properties.CalendarTimeProperties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dtNextDueDate.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numBalance.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numPayment.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private DevExpress.XtraLayout.LayoutControl layoutControl1;
    private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
    private DevExpress.XtraEditors.SpinEdit numBalance;
    private DevExpress.XtraEditors.SpinEdit numPayment;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
    private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
    private DevExpress.XtraEditors.DateEdit dtNextDueDate;
    private DevExpress.XtraEditors.TextEdit txtName;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
    private RecurringPaymentKindEdit cboKind;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
    private InterestRateEdit ctrlInterestRate;
    private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
  }
}
