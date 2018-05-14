namespace Finances
{
  partial class RecurringPaymentEdit
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
      this.cboKind = new Finances.RecurringPaymentKindEdit();
      this.numAmount = new DevExpress.XtraEditors.SpinEdit();
      this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
      this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
      this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
      this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
      this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
      this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
      this.layoutControl1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dtNextDueDate.Properties.CalendarTimeProperties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dtNextDueDate.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numAmount.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
      this.SuspendLayout();
      // 
      // layoutControl1
      // 
      this.layoutControl1.Controls.Add(this.dtNextDueDate);
      this.layoutControl1.Controls.Add(this.txtName);
      this.layoutControl1.Controls.Add(this.cboKind);
      this.layoutControl1.Controls.Add(this.numAmount);
      this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.layoutControl1.Location = new System.Drawing.Point(0, 0);
      this.layoutControl1.Name = "layoutControl1";
      this.layoutControl1.OptionsItemText.TextAlignMode = DevExpress.XtraLayout.TextAlignMode.CustomSize;
      this.layoutControl1.Root = this.layoutControlGroup1;
      this.layoutControl1.Size = new System.Drawing.Size(243, 118);
      this.layoutControl1.TabIndex = 0;
      this.layoutControl1.Text = "layoutControl1";
      // 
      // dtNextDueDate
      // 
      this.dtNextDueDate.EditValue = null;
      this.dtNextDueDate.Location = new System.Drawing.Point(60, 84);
      this.dtNextDueDate.Name = "dtNextDueDate";
      this.dtNextDueDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.dtNextDueDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.dtNextDueDate.Size = new System.Drawing.Size(171, 20);
      this.dtNextDueDate.StyleController = this.layoutControl1;
      this.dtNextDueDate.TabIndex = 8;
      // 
      // txtName
      // 
      this.txtName.Location = new System.Drawing.Point(60, 60);
      this.txtName.Name = "txtName";
      this.txtName.Size = new System.Drawing.Size(171, 20);
      this.txtName.StyleController = this.layoutControl1;
      this.txtName.TabIndex = 7;
      // 
      // cboKind
      // 
      this.cboKind.Location = new System.Drawing.Point(60, 36);
      this.cboKind.Name = "cboKind";
      this.cboKind.Size = new System.Drawing.Size(171, 20);
      this.cboKind.TabIndex = 6;
      // 
      // numAmount
      // 
      this.numAmount.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.numAmount.Location = new System.Drawing.Point(60, 12);
      this.numAmount.Name = "numAmount";
      this.numAmount.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.numAmount.Properties.DisplayFormat.FormatString = "c2";
      this.numAmount.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
      this.numAmount.Size = new System.Drawing.Size(171, 20);
      this.numAmount.StyleController = this.layoutControl1;
      this.numAmount.TabIndex = 4;
      // 
      // layoutControlGroup1
      // 
      this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
      this.layoutControlGroup1.GroupBordersVisible = false;
      this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.emptySpaceItem1,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5});
      this.layoutControlGroup1.Name = "layoutControlGroup1";
      this.layoutControlGroup1.Size = new System.Drawing.Size(243, 118);
      this.layoutControlGroup1.TextVisible = false;
      // 
      // layoutControlItem1
      // 
      this.layoutControlItem1.AppearanceItemCaption.FontStyleDelta = System.Drawing.FontStyle.Bold;
      this.layoutControlItem1.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem1.Control = this.numAmount;
      this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
      this.layoutControlItem1.Name = "layoutControlItem1";
      this.layoutControlItem1.Size = new System.Drawing.Size(223, 24);
      this.layoutControlItem1.Text = "Amount";
      this.layoutControlItem1.TextSize = new System.Drawing.Size(45, 13);
      // 
      // emptySpaceItem1
      // 
      this.emptySpaceItem1.AllowHotTrack = false;
      this.emptySpaceItem1.Location = new System.Drawing.Point(0, 96);
      this.emptySpaceItem1.MinSize = new System.Drawing.Size(10, 1);
      this.emptySpaceItem1.Name = "emptySpaceItem1";
      this.emptySpaceItem1.Size = new System.Drawing.Size(223, 2);
      this.emptySpaceItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
      this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
      // 
      // layoutControlItem3
      // 
      this.layoutControlItem3.AppearanceItemCaption.FontStyleDelta = System.Drawing.FontStyle.Bold;
      this.layoutControlItem3.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem3.Control = this.cboKind;
      this.layoutControlItem3.Location = new System.Drawing.Point(0, 24);
      this.layoutControlItem3.Name = "layoutControlItem3";
      this.layoutControlItem3.Size = new System.Drawing.Size(223, 24);
      this.layoutControlItem3.Text = "Kind";
      this.layoutControlItem3.TextSize = new System.Drawing.Size(45, 13);
      // 
      // layoutControlItem4
      // 
      this.layoutControlItem4.AppearanceItemCaption.FontStyleDelta = System.Drawing.FontStyle.Bold;
      this.layoutControlItem4.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem4.Control = this.txtName;
      this.layoutControlItem4.Location = new System.Drawing.Point(0, 48);
      this.layoutControlItem4.Name = "layoutControlItem4";
      this.layoutControlItem4.Size = new System.Drawing.Size(223, 24);
      this.layoutControlItem4.Text = "Name";
      this.layoutControlItem4.TextSize = new System.Drawing.Size(45, 13);
      // 
      // layoutControlItem5
      // 
      this.layoutControlItem5.AppearanceItemCaption.FontStyleDelta = System.Drawing.FontStyle.Bold;
      this.layoutControlItem5.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem5.Control = this.dtNextDueDate;
      this.layoutControlItem5.Location = new System.Drawing.Point(0, 72);
      this.layoutControlItem5.Name = "layoutControlItem5";
      this.layoutControlItem5.Size = new System.Drawing.Size(223, 24);
      this.layoutControlItem5.Text = "Next";
      this.layoutControlItem5.TextSize = new System.Drawing.Size(45, 13);
      // 
      // RecurringPaymentEdit
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.layoutControl1);
      this.Name = "RecurringPaymentEdit";
      this.Size = new System.Drawing.Size(243, 118);
      ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
      this.layoutControl1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dtNextDueDate.Properties.CalendarTimeProperties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dtNextDueDate.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numAmount.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private DevExpress.XtraLayout.LayoutControl layoutControl1;
    private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
    private DevExpress.XtraEditors.SpinEdit numAmount;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
    private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
    private DevExpress.XtraEditors.DateEdit dtNextDueDate;
    private DevExpress.XtraEditors.TextEdit txtName;
    private RecurringPaymentKindEdit cboKind;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
  }
}
