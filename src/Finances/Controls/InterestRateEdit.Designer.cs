namespace Finances
{
  partial class InterestRateEdit
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
      DevExpress.XtraLayout.ColumnDefinition columnDefinition1 = new DevExpress.XtraLayout.ColumnDefinition();
      DevExpress.XtraLayout.ColumnDefinition columnDefinition2 = new DevExpress.XtraLayout.ColumnDefinition();
      DevExpress.XtraLayout.ColumnDefinition columnDefinition3 = new DevExpress.XtraLayout.ColumnDefinition();
      DevExpress.XtraLayout.RowDefinition rowDefinition1 = new DevExpress.XtraLayout.RowDefinition();
      DevExpress.XtraLayout.RowDefinition rowDefinition2 = new DevExpress.XtraLayout.RowDefinition();
      DevExpress.XtraLayout.RowDefinition rowDefinition3 = new DevExpress.XtraLayout.RowDefinition();
      DevExpress.XtraLayout.RowDefinition rowDefinition4 = new DevExpress.XtraLayout.RowDefinition();
      this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
      this.cboKind = new Finances.RecurringPaymentKindEdit();
      this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
      this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
      this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
      this.dtNext = new DevExpress.XtraEditors.DateEdit();
      this.numPercentage = new DevExpress.XtraEditors.SpinEdit();
      this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
      this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
      this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
      this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
      this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
      this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
      this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
      this.layoutControl1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dtNext.Properties.CalendarTimeProperties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dtNext.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numPercentage.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
      this.SuspendLayout();
      // 
      // layoutControl1
      // 
      this.layoutControl1.Controls.Add(this.cboKind);
      this.layoutControl1.Controls.Add(this.labelControl3);
      this.layoutControl1.Controls.Add(this.labelControl2);
      this.layoutControl1.Controls.Add(this.labelControl1);
      this.layoutControl1.Controls.Add(this.dtNext);
      this.layoutControl1.Controls.Add(this.numPercentage);
      this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.layoutControl1.Location = new System.Drawing.Point(0, 0);
      this.layoutControl1.Name = "layoutControl1";
      this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(586, 183, 650, 400);
      this.layoutControl1.Root = this.layoutControlGroup1;
      this.layoutControl1.Size = new System.Drawing.Size(205, 78);
      this.layoutControl1.TabIndex = 0;
      this.layoutControl1.Text = "layoutControl1";
      // 
      // cboKind
      // 
      this.cboKind.Location = new System.Drawing.Point(32, 26);
      this.cboKind.Name = "cboKind";
      this.cboKind.Size = new System.Drawing.Size(144, 20);
      this.cboKind.TabIndex = 10;
      // 
      // labelControl3
      // 
      this.labelControl3.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold;
      this.labelControl3.Appearance.Options.UseFont = true;
      this.labelControl3.Location = new System.Drawing.Point(2, 29);
      this.labelControl3.Name = "labelControl3";
      this.labelControl3.Size = new System.Drawing.Size(24, 13);
      this.labelControl3.StyleController = this.layoutControl1;
      this.labelControl3.TabIndex = 9;
      this.labelControl3.Text = "Kind";
      // 
      // labelControl2
      // 
      this.labelControl2.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold;
      this.labelControl2.Appearance.Options.UseFont = true;
      this.labelControl2.Location = new System.Drawing.Point(2, 53);
      this.labelControl2.Name = "labelControl2";
      this.labelControl2.Size = new System.Drawing.Size(26, 13);
      this.labelControl2.StyleController = this.layoutControl1;
      this.labelControl2.TabIndex = 8;
      this.labelControl2.Text = "Next";
      // 
      // labelControl1
      // 
      this.labelControl1.Location = new System.Drawing.Point(180, 5);
      this.labelControl1.Name = "labelControl1";
      this.labelControl1.Size = new System.Drawing.Size(11, 13);
      this.labelControl1.StyleController = this.layoutControl1;
      this.labelControl1.TabIndex = 7;
      this.labelControl1.Text = "%";
      // 
      // dtNext
      // 
      this.dtNext.EditValue = null;
      this.dtNext.Location = new System.Drawing.Point(32, 50);
      this.dtNext.Name = "dtNext";
      this.dtNext.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.dtNext.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.dtNext.Size = new System.Drawing.Size(171, 20);
      this.dtNext.StyleController = this.layoutControl1;
      this.dtNext.TabIndex = 6;
      // 
      // numPercentage
      // 
      this.numPercentage.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.numPercentage.Location = new System.Drawing.Point(2, 2);
      this.numPercentage.Name = "numPercentage";
      this.numPercentage.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.numPercentage.Size = new System.Drawing.Size(174, 20);
      this.numPercentage.StyleController = this.layoutControl1;
      this.numPercentage.TabIndex = 5;
      // 
      // layoutControlGroup1
      // 
      this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
      this.layoutControlGroup1.GroupBordersVisible = false;
      this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.layoutControlItem1});
      this.layoutControlGroup1.LayoutMode = DevExpress.XtraLayout.Utils.LayoutMode.Table;
      this.layoutControlGroup1.Name = "Root";
      columnDefinition1.SizeType = System.Windows.Forms.SizeType.AutoSize;
      columnDefinition1.Width = 30D;
      columnDefinition2.SizeType = System.Windows.Forms.SizeType.Percent;
      columnDefinition2.Width = 100D;
      columnDefinition3.SizeType = System.Windows.Forms.SizeType.AutoSize;
      columnDefinition3.Width = 27D;
      this.layoutControlGroup1.OptionsTableLayoutGroup.ColumnDefinitions.AddRange(new DevExpress.XtraLayout.ColumnDefinition[] {
            columnDefinition1,
            columnDefinition2,
            columnDefinition3});
      rowDefinition1.Height = 24D;
      rowDefinition1.SizeType = System.Windows.Forms.SizeType.AutoSize;
      rowDefinition2.Height = 24D;
      rowDefinition2.SizeType = System.Windows.Forms.SizeType.AutoSize;
      rowDefinition3.Height = 24D;
      rowDefinition3.SizeType = System.Windows.Forms.SizeType.AutoSize;
      rowDefinition4.Height = 100D;
      rowDefinition4.SizeType = System.Windows.Forms.SizeType.Percent;
      this.layoutControlGroup1.OptionsTableLayoutGroup.RowDefinitions.AddRange(new DevExpress.XtraLayout.RowDefinition[] {
            rowDefinition1,
            rowDefinition2,
            rowDefinition3,
            rowDefinition4});
      this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
      this.layoutControlGroup1.Size = new System.Drawing.Size(205, 78);
      this.layoutControlGroup1.TextVisible = false;
      // 
      // layoutControlItem2
      // 
      this.layoutControlItem2.Control = this.numPercentage;
      this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
      this.layoutControlItem2.Name = "layoutControlItem2";
      this.layoutControlItem2.OptionsTableLayoutItem.ColumnSpan = 2;
      this.layoutControlItem2.Size = new System.Drawing.Size(178, 24);
      this.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Right;
      this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
      this.layoutControlItem2.TextVisible = false;
      // 
      // layoutControlItem3
      // 
      this.layoutControlItem3.Control = this.dtNext;
      this.layoutControlItem3.Location = new System.Drawing.Point(30, 48);
      this.layoutControlItem3.Name = "layoutControlItem3";
      this.layoutControlItem3.OptionsTableLayoutItem.ColumnIndex = 1;
      this.layoutControlItem3.OptionsTableLayoutItem.ColumnSpan = 2;
      this.layoutControlItem3.OptionsTableLayoutItem.RowIndex = 2;
      this.layoutControlItem3.Size = new System.Drawing.Size(175, 24);
      this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
      this.layoutControlItem3.TextVisible = false;
      // 
      // layoutControlItem4
      // 
      this.layoutControlItem4.Control = this.labelControl1;
      this.layoutControlItem4.ControlAlignment = System.Drawing.ContentAlignment.MiddleLeft;
      this.layoutControlItem4.Location = new System.Drawing.Point(178, 0);
      this.layoutControlItem4.Name = "layoutControlItem4";
      this.layoutControlItem4.OptionsTableLayoutItem.ColumnIndex = 2;
      this.layoutControlItem4.Size = new System.Drawing.Size(27, 24);
      this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
      this.layoutControlItem4.TextVisible = false;
      this.layoutControlItem4.TrimClientAreaToControl = false;
      // 
      // layoutControlItem5
      // 
      this.layoutControlItem5.Control = this.labelControl2;
      this.layoutControlItem5.ControlAlignment = System.Drawing.ContentAlignment.MiddleLeft;
      this.layoutControlItem5.Location = new System.Drawing.Point(0, 48);
      this.layoutControlItem5.Name = "layoutControlItem5";
      this.layoutControlItem5.OptionsTableLayoutItem.RowIndex = 2;
      this.layoutControlItem5.Size = new System.Drawing.Size(30, 24);
      this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
      this.layoutControlItem5.TextVisible = false;
      this.layoutControlItem5.TrimClientAreaToControl = false;
      // 
      // layoutControlItem6
      // 
      this.layoutControlItem6.Control = this.labelControl3;
      this.layoutControlItem6.ControlAlignment = System.Drawing.ContentAlignment.MiddleLeft;
      this.layoutControlItem6.Location = new System.Drawing.Point(0, 24);
      this.layoutControlItem6.Name = "layoutControlItem6";
      this.layoutControlItem6.OptionsTableLayoutItem.RowIndex = 1;
      this.layoutControlItem6.Size = new System.Drawing.Size(30, 24);
      this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
      this.layoutControlItem6.TextVisible = false;
      this.layoutControlItem6.TrimClientAreaToControl = false;
      // 
      // layoutControlItem1
      // 
      this.layoutControlItem1.Control = this.cboKind;
      this.layoutControlItem1.Location = new System.Drawing.Point(30, 24);
      this.layoutControlItem1.Name = "layoutControlItem1";
      this.layoutControlItem1.OptionsTableLayoutItem.ColumnIndex = 1;
      this.layoutControlItem1.OptionsTableLayoutItem.RowIndex = 1;
      this.layoutControlItem1.Size = new System.Drawing.Size(148, 24);
      this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
      this.layoutControlItem1.TextVisible = false;
      // 
      // InterestRateEdit
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.layoutControl1);
      this.Name = "InterestRateEdit";
      this.Size = new System.Drawing.Size(205, 78);
      ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
      this.layoutControl1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dtNext.Properties.CalendarTimeProperties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dtNext.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numPercentage.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private DevExpress.XtraLayout.LayoutControl layoutControl1;
    private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
    private DevExpress.XtraEditors.SpinEdit numPercentage;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
    private DevExpress.XtraEditors.DateEdit dtNext;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
    private DevExpress.XtraEditors.LabelControl labelControl1;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
    private DevExpress.XtraEditors.LabelControl labelControl3;
    private DevExpress.XtraEditors.LabelControl labelControl2;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
    private RecurringPaymentKindEdit cboKind;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
  }
}
