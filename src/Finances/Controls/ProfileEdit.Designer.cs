namespace Finances
{
  partial class ProfileEdit
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
      this.numYears = new DevExpress.XtraEditors.SpinEdit();
      this.numStartingBalance = new DevExpress.XtraEditors.SpinEdit();
      this.dtStartDate = new DevExpress.XtraEditors.DateEdit();
      this.ctrlRecurringPayments = new Finances.CollectionButtonEdit();
      this.ctrlPaychecks = new Finances.CollectionButtonEdit();
      this.txtName = new DevExpress.XtraEditors.TextEdit();
      this.ctrlLoans = new Finances.CollectionButtonEdit();
      this.ctrlCreditCards = new Finances.CollectionButtonEdit();
      this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
      this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
      this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
      this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
      this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
      this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
      this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
      this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
      this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
      this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
      this.layoutControl1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numYears.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numStartingBalance.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dtStartDate.Properties.CalendarTimeProperties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dtStartDate.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
      this.SuspendLayout();
      // 
      // layoutControl1
      // 
      this.layoutControl1.Controls.Add(this.numYears);
      this.layoutControl1.Controls.Add(this.numStartingBalance);
      this.layoutControl1.Controls.Add(this.dtStartDate);
      this.layoutControl1.Controls.Add(this.ctrlRecurringPayments);
      this.layoutControl1.Controls.Add(this.ctrlPaychecks);
      this.layoutControl1.Controls.Add(this.txtName);
      this.layoutControl1.Controls.Add(this.ctrlLoans);
      this.layoutControl1.Controls.Add(this.ctrlCreditCards);
      this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.layoutControl1.Location = new System.Drawing.Point(0, 0);
      this.layoutControl1.Name = "layoutControl1";
      this.layoutControl1.Root = this.layoutControlGroup1;
      this.layoutControl1.Size = new System.Drawing.Size(436, 249);
      this.layoutControl1.TabIndex = 0;
      this.layoutControl1.Text = "layoutControl1";
      // 
      // numYears
      // 
      this.numYears.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.numYears.Location = new System.Drawing.Point(130, 180);
      this.numYears.Name = "numYears";
      this.numYears.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.numYears.Properties.IsFloatValue = false;
      this.numYears.Properties.Mask.EditMask = "N00";
      this.numYears.Size = new System.Drawing.Size(294, 20);
      this.numYears.StyleController = this.layoutControl1;
      this.numYears.TabIndex = 11;
      // 
      // numStartingBalance
      // 
      this.numStartingBalance.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.numStartingBalance.Location = new System.Drawing.Point(130, 156);
      this.numStartingBalance.Name = "numStartingBalance";
      this.numStartingBalance.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.numStartingBalance.Properties.DisplayFormat.FormatString = "c2";
      this.numStartingBalance.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
      this.numStartingBalance.Size = new System.Drawing.Size(294, 20);
      this.numStartingBalance.StyleController = this.layoutControl1;
      this.numStartingBalance.TabIndex = 10;
      // 
      // dtStartDate
      // 
      this.dtStartDate.EditValue = null;
      this.dtStartDate.Location = new System.Drawing.Point(130, 132);
      this.dtStartDate.Name = "dtStartDate";
      this.dtStartDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.dtStartDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.dtStartDate.Size = new System.Drawing.Size(294, 20);
      this.dtStartDate.StyleController = this.layoutControl1;
      this.dtStartDate.TabIndex = 9;
      // 
      // ctrlRecurringPayments
      // 
      this.ctrlRecurringPayments.Location = new System.Drawing.Point(130, 108);
      this.ctrlRecurringPayments.Name = "ctrlRecurringPayments";
      this.ctrlRecurringPayments.Size = new System.Drawing.Size(294, 20);
      this.ctrlRecurringPayments.TabIndex = 8;
      // 
      // ctrlPaychecks
      // 
      this.ctrlPaychecks.Location = new System.Drawing.Point(130, 84);
      this.ctrlPaychecks.Name = "ctrlPaychecks";
      this.ctrlPaychecks.Size = new System.Drawing.Size(294, 20);
      this.ctrlPaychecks.TabIndex = 7;
      // 
      // txtName
      // 
      this.txtName.Location = new System.Drawing.Point(130, 60);
      this.txtName.Name = "txtName";
      this.txtName.Size = new System.Drawing.Size(294, 20);
      this.txtName.StyleController = this.layoutControl1;
      this.txtName.TabIndex = 6;
      // 
      // ctrlLoans
      // 
      this.ctrlLoans.Location = new System.Drawing.Point(130, 36);
      this.ctrlLoans.Name = "ctrlLoans";
      this.ctrlLoans.Size = new System.Drawing.Size(294, 20);
      this.ctrlLoans.TabIndex = 5;
      // 
      // ctrlCreditCards
      // 
      this.ctrlCreditCards.Location = new System.Drawing.Point(130, 12);
      this.ctrlCreditCards.Name = "ctrlCreditCards";
      this.ctrlCreditCards.Size = new System.Drawing.Size(294, 20);
      this.ctrlCreditCards.TabIndex = 4;
      // 
      // layoutControlGroup1
      // 
      this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
      this.layoutControlGroup1.GroupBordersVisible = false;
      this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.emptySpaceItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.layoutControlItem7,
            this.layoutControlItem8});
      this.layoutControlGroup1.Name = "layoutControlGroup1";
      this.layoutControlGroup1.Size = new System.Drawing.Size(436, 249);
      this.layoutControlGroup1.TextVisible = false;
      // 
      // layoutControlItem1
      // 
      this.layoutControlItem1.AppearanceItemCaption.FontStyleDelta = System.Drawing.FontStyle.Bold;
      this.layoutControlItem1.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem1.Control = this.ctrlCreditCards;
      this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
      this.layoutControlItem1.Name = "layoutControlItem1";
      this.layoutControlItem1.Size = new System.Drawing.Size(416, 24);
      this.layoutControlItem1.Text = "Credit Cards";
      this.layoutControlItem1.TextSize = new System.Drawing.Size(115, 13);
      // 
      // emptySpaceItem1
      // 
      this.emptySpaceItem1.AllowHotTrack = false;
      this.emptySpaceItem1.Location = new System.Drawing.Point(0, 192);
      this.emptySpaceItem1.Name = "emptySpaceItem1";
      this.emptySpaceItem1.Size = new System.Drawing.Size(416, 37);
      this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
      // 
      // layoutControlItem2
      // 
      this.layoutControlItem2.AppearanceItemCaption.FontStyleDelta = System.Drawing.FontStyle.Bold;
      this.layoutControlItem2.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem2.Control = this.ctrlLoans;
      this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
      this.layoutControlItem2.Name = "layoutControlItem2";
      this.layoutControlItem2.Size = new System.Drawing.Size(416, 24);
      this.layoutControlItem2.Text = "Loans";
      this.layoutControlItem2.TextSize = new System.Drawing.Size(115, 13);
      // 
      // layoutControlItem3
      // 
      this.layoutControlItem3.AppearanceItemCaption.FontStyleDelta = System.Drawing.FontStyle.Bold;
      this.layoutControlItem3.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem3.Control = this.txtName;
      this.layoutControlItem3.Location = new System.Drawing.Point(0, 48);
      this.layoutControlItem3.Name = "layoutControlItem3";
      this.layoutControlItem3.Size = new System.Drawing.Size(416, 24);
      this.layoutControlItem3.Text = "Name";
      this.layoutControlItem3.TextSize = new System.Drawing.Size(115, 13);
      // 
      // layoutControlItem4
      // 
      this.layoutControlItem4.AppearanceItemCaption.FontStyleDelta = System.Drawing.FontStyle.Bold;
      this.layoutControlItem4.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem4.Control = this.ctrlPaychecks;
      this.layoutControlItem4.Location = new System.Drawing.Point(0, 72);
      this.layoutControlItem4.Name = "layoutControlItem4";
      this.layoutControlItem4.Size = new System.Drawing.Size(416, 24);
      this.layoutControlItem4.Text = "Paychecks";
      this.layoutControlItem4.TextSize = new System.Drawing.Size(115, 13);
      // 
      // layoutControlItem5
      // 
      this.layoutControlItem5.AppearanceItemCaption.FontStyleDelta = System.Drawing.FontStyle.Bold;
      this.layoutControlItem5.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem5.Control = this.ctrlRecurringPayments;
      this.layoutControlItem5.Location = new System.Drawing.Point(0, 96);
      this.layoutControlItem5.Name = "layoutControlItem5";
      this.layoutControlItem5.Size = new System.Drawing.Size(416, 24);
      this.layoutControlItem5.Text = "Recurring Payments";
      this.layoutControlItem5.TextSize = new System.Drawing.Size(115, 13);
      // 
      // layoutControlItem6
      // 
      this.layoutControlItem6.AppearanceItemCaption.FontStyleDelta = System.Drawing.FontStyle.Bold;
      this.layoutControlItem6.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem6.Control = this.dtStartDate;
      this.layoutControlItem6.Location = new System.Drawing.Point(0, 120);
      this.layoutControlItem6.Name = "layoutControlItem6";
      this.layoutControlItem6.Size = new System.Drawing.Size(416, 24);
      this.layoutControlItem6.Text = "Start Date";
      this.layoutControlItem6.TextSize = new System.Drawing.Size(115, 13);
      // 
      // layoutControlItem7
      // 
      this.layoutControlItem7.AppearanceItemCaption.FontStyleDelta = System.Drawing.FontStyle.Bold;
      this.layoutControlItem7.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem7.Control = this.numStartingBalance;
      this.layoutControlItem7.Location = new System.Drawing.Point(0, 144);
      this.layoutControlItem7.Name = "layoutControlItem7";
      this.layoutControlItem7.Size = new System.Drawing.Size(416, 24);
      this.layoutControlItem7.Text = "Starting Balance";
      this.layoutControlItem7.TextSize = new System.Drawing.Size(115, 13);
      // 
      // layoutControlItem8
      // 
      this.layoutControlItem8.AppearanceItemCaption.FontStyleDelta = System.Drawing.FontStyle.Bold;
      this.layoutControlItem8.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem8.Control = this.numYears;
      this.layoutControlItem8.Location = new System.Drawing.Point(0, 168);
      this.layoutControlItem8.Name = "layoutControlItem8";
      this.layoutControlItem8.Size = new System.Drawing.Size(416, 24);
      this.layoutControlItem8.Text = "Years";
      this.layoutControlItem8.TextSize = new System.Drawing.Size(115, 13);
      // 
      // ProfileEdit
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.layoutControl1);
      this.Name = "ProfileEdit";
      this.Size = new System.Drawing.Size(436, 249);
      ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
      this.layoutControl1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.numYears.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numStartingBalance.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dtStartDate.Properties.CalendarTimeProperties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dtStartDate.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private DevExpress.XtraLayout.LayoutControl layoutControl1;
    private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
    private DevExpress.XtraEditors.SpinEdit numYears;
    private DevExpress.XtraEditors.SpinEdit numStartingBalance;
    private DevExpress.XtraEditors.DateEdit dtStartDate;
    private CollectionButtonEdit ctrlRecurringPayments;
    private CollectionButtonEdit ctrlPaychecks;
    private DevExpress.XtraEditors.TextEdit txtName;
    private CollectionButtonEdit ctrlLoans;
    private CollectionButtonEdit ctrlCreditCards;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
    private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
  }
}
