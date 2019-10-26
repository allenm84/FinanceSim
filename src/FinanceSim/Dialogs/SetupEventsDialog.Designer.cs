namespace FinanceSim
{
  partial class SetupEventsDialog
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

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
      this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
      this.btnOK = new DevExpress.XtraEditors.SimpleButton();
      this.gridChangePaycheckTotal = new DevExpress.XtraGrid.GridControl();
      this.adjustPaycheckTotalEventBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.gridViewChangePaycheckTotal = new DevExpress.XtraGrid.Views.Grid.GridView();
      this.colChangePaycheckTotalDate = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colChangePaycheckTotalPaycheckId = new DevExpress.XtraGrid.Columns.GridColumn();
      this.cboPaychecks = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
      this.paycheckBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.colAdjustPaycheckTotalAmount = new DevExpress.XtraGrid.Columns.GridColumn();
      this.gridChangeBillPayment = new DevExpress.XtraGrid.GridControl();
      this.changeBillPaymentEventBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.gridViewChangeBillPayment = new DevExpress.XtraGrid.Views.Grid.GridView();
      this.colChangeBillPaymentDate = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colChangeBillPaymentBillId = new DevExpress.XtraGrid.Columns.GridColumn();
      this.cboBills = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
      this.billBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.colChangeBillPaymentNewPayment = new DevExpress.XtraGrid.Columns.GridColumn();
      this.gridAdjustSnowball = new DevExpress.XtraGrid.GridControl();
      this.adjustSnowballAmountEventBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.gridViewAdjustSnowball = new DevExpress.XtraGrid.Views.Grid.GridView();
      this.colPaycheckAdjustAmount = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colPaycheckAdjustDate = new DevExpress.XtraGrid.Columns.GridColumn();
      this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
      this.tabbedControlGroup1 = new DevExpress.XtraLayout.TabbedControlGroup();
      this.layoutControlGroup4 = new DevExpress.XtraLayout.LayoutControlGroup();
      this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
      this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
      this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
      this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
      this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
      this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
      this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
      this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
      this.layoutControl1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.gridChangePaycheckTotal)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.adjustPaycheckTotalEventBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridViewChangePaycheckTotal)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.cboPaychecks)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.paycheckBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridChangeBillPayment)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.changeBillPaymentEventBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridViewChangeBillPayment)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.cboBills)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.billBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridAdjustSnowball)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.adjustSnowballAmountEventBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridViewAdjustSnowball)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.tabbedControlGroup1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
      this.SuspendLayout();
      // 
      // layoutControl1
      // 
      this.layoutControl1.Controls.Add(this.btnCancel);
      this.layoutControl1.Controls.Add(this.btnOK);
      this.layoutControl1.Controls.Add(this.gridChangePaycheckTotal);
      this.layoutControl1.Controls.Add(this.gridChangeBillPayment);
      this.layoutControl1.Controls.Add(this.gridAdjustSnowball);
      this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.layoutControl1.Location = new System.Drawing.Point(0, 0);
      this.layoutControl1.Name = "layoutControl1";
      this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(677, 134, 650, 400);
      this.layoutControl1.Root = this.layoutControlGroup1;
      this.layoutControl1.Size = new System.Drawing.Size(575, 360);
      this.layoutControl1.TabIndex = 0;
      this.layoutControl1.Text = "layoutControl1";
      // 
      // btnCancel
      // 
      this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnCancel.Location = new System.Drawing.Point(487, 326);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new System.Drawing.Size(76, 22);
      this.btnCancel.StyleController = this.layoutControl1;
      this.btnCancel.TabIndex = 8;
      this.btnCancel.Text = "Cancel";
      // 
      // btnOK
      // 
      this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.btnOK.Location = new System.Drawing.Point(407, 326);
      this.btnOK.Name = "btnOK";
      this.btnOK.Size = new System.Drawing.Size(76, 22);
      this.btnOK.StyleController = this.layoutControl1;
      this.btnOK.TabIndex = 7;
      this.btnOK.Text = "OK";
      // 
      // gridChangePaycheckTotal
      // 
      this.gridChangePaycheckTotal.DataSource = this.adjustPaycheckTotalEventBindingSource;
      this.gridChangePaycheckTotal.Location = new System.Drawing.Point(24, 46);
      this.gridChangePaycheckTotal.MainView = this.gridViewChangePaycheckTotal;
      this.gridChangePaycheckTotal.Name = "gridChangePaycheckTotal";
      this.gridChangePaycheckTotal.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cboPaychecks});
      this.gridChangePaycheckTotal.Size = new System.Drawing.Size(527, 264);
      this.gridChangePaycheckTotal.TabIndex = 6;
      this.gridChangePaycheckTotal.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewChangePaycheckTotal});
      // 
      // adjustPaycheckTotalEventBindingSource
      // 
      this.adjustPaycheckTotalEventBindingSource.DataSource = typeof(FinanceSim.AdjustPaycheckTotalEvent);
      // 
      // gridViewChangePaycheckTotal
      // 
      this.gridViewChangePaycheckTotal.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colChangePaycheckTotalDate,
            this.colChangePaycheckTotalPaycheckId,
            this.colAdjustPaycheckTotalAmount});
      this.gridViewChangePaycheckTotal.GridControl = this.gridChangePaycheckTotal;
      this.gridViewChangePaycheckTotal.Name = "gridViewChangePaycheckTotal";
      this.gridViewChangePaycheckTotal.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
      this.gridViewChangePaycheckTotal.OptionsView.ShowGroupPanel = false;
      // 
      // colChangePaycheckTotalDate
      // 
      this.colChangePaycheckTotalDate.FieldName = "Date";
      this.colChangePaycheckTotalDate.Name = "colChangePaycheckTotalDate";
      this.colChangePaycheckTotalDate.Visible = true;
      this.colChangePaycheckTotalDate.VisibleIndex = 0;
      // 
      // colChangePaycheckTotalPaycheckId
      // 
      this.colChangePaycheckTotalPaycheckId.Caption = "Paycheck";
      this.colChangePaycheckTotalPaycheckId.ColumnEdit = this.cboPaychecks;
      this.colChangePaycheckTotalPaycheckId.FieldName = "PaycheckId";
      this.colChangePaycheckTotalPaycheckId.Name = "colChangePaycheckTotalPaycheckId";
      this.colChangePaycheckTotalPaycheckId.Visible = true;
      this.colChangePaycheckTotalPaycheckId.VisibleIndex = 1;
      // 
      // cboPaychecks
      // 
      this.cboPaychecks.AutoHeight = false;
      this.cboPaychecks.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.cboPaychecks.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name", 37, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.Ascending, DevExpress.Utils.DefaultBoolean.Default)});
      this.cboPaychecks.DataSource = this.paycheckBindingSource;
      this.cboPaychecks.DisplayMember = "Name";
      this.cboPaychecks.Name = "cboPaychecks";
      this.cboPaychecks.ValueMember = "Id";
      // 
      // paycheckBindingSource
      // 
      this.paycheckBindingSource.DataSource = typeof(FinanceSim.Paycheck);
      // 
      // colAdjustPaycheckTotalAmount
      // 
      this.colAdjustPaycheckTotalAmount.DisplayFormat.FormatString = "c2";
      this.colAdjustPaycheckTotalAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
      this.colAdjustPaycheckTotalAmount.FieldName = "Amount";
      this.colAdjustPaycheckTotalAmount.Name = "colAdjustPaycheckTotalAmount";
      this.colAdjustPaycheckTotalAmount.Visible = true;
      this.colAdjustPaycheckTotalAmount.VisibleIndex = 2;
      // 
      // gridChangeBillPayment
      // 
      this.gridChangeBillPayment.DataSource = this.changeBillPaymentEventBindingSource;
      this.gridChangeBillPayment.Location = new System.Drawing.Point(24, 46);
      this.gridChangeBillPayment.MainView = this.gridViewChangeBillPayment;
      this.gridChangeBillPayment.Name = "gridChangeBillPayment";
      this.gridChangeBillPayment.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cboBills});
      this.gridChangeBillPayment.Size = new System.Drawing.Size(527, 264);
      this.gridChangeBillPayment.TabIndex = 5;
      this.gridChangeBillPayment.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewChangeBillPayment});
      // 
      // changeBillPaymentEventBindingSource
      // 
      this.changeBillPaymentEventBindingSource.DataSource = typeof(FinanceSim.ChangeBillPaymentEvent);
      // 
      // gridViewChangeBillPayment
      // 
      this.gridViewChangeBillPayment.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colChangeBillPaymentDate,
            this.colChangeBillPaymentBillId,
            this.colChangeBillPaymentNewPayment});
      this.gridViewChangeBillPayment.GridControl = this.gridChangeBillPayment;
      this.gridViewChangeBillPayment.Name = "gridViewChangeBillPayment";
      this.gridViewChangeBillPayment.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
      this.gridViewChangeBillPayment.OptionsView.ShowGroupPanel = false;
      // 
      // colChangeBillPaymentDate
      // 
      this.colChangeBillPaymentDate.FieldName = "Date";
      this.colChangeBillPaymentDate.Name = "colChangeBillPaymentDate";
      this.colChangeBillPaymentDate.Visible = true;
      this.colChangeBillPaymentDate.VisibleIndex = 0;
      // 
      // colChangeBillPaymentBillId
      // 
      this.colChangeBillPaymentBillId.Caption = "Bill";
      this.colChangeBillPaymentBillId.ColumnEdit = this.cboBills;
      this.colChangeBillPaymentBillId.FieldName = "BillId";
      this.colChangeBillPaymentBillId.Name = "colChangeBillPaymentBillId";
      this.colChangeBillPaymentBillId.Visible = true;
      this.colChangeBillPaymentBillId.VisibleIndex = 1;
      // 
      // cboBills
      // 
      this.cboBills.AutoHeight = false;
      this.cboBills.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.cboBills.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name", 37, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.Ascending, DevExpress.Utils.DefaultBoolean.Default)});
      this.cboBills.DataSource = this.billBindingSource;
      this.cboBills.DisplayMember = "Name";
      this.cboBills.Name = "cboBills";
      this.cboBills.ValueMember = "Id";
      // 
      // billBindingSource
      // 
      this.billBindingSource.DataSource = typeof(FinanceSim.Bill);
      // 
      // colChangeBillPaymentNewPayment
      // 
      this.colChangeBillPaymentNewPayment.DisplayFormat.FormatString = "c2";
      this.colChangeBillPaymentNewPayment.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
      this.colChangeBillPaymentNewPayment.FieldName = "NewPayment";
      this.colChangeBillPaymentNewPayment.Name = "colChangeBillPaymentNewPayment";
      this.colChangeBillPaymentNewPayment.Visible = true;
      this.colChangeBillPaymentNewPayment.VisibleIndex = 2;
      // 
      // gridAdjustSnowball
      // 
      this.gridAdjustSnowball.DataSource = this.adjustSnowballAmountEventBindingSource;
      this.gridAdjustSnowball.Location = new System.Drawing.Point(24, 46);
      this.gridAdjustSnowball.MainView = this.gridViewAdjustSnowball;
      this.gridAdjustSnowball.Name = "gridAdjustSnowball";
      this.gridAdjustSnowball.Size = new System.Drawing.Size(527, 264);
      this.gridAdjustSnowball.TabIndex = 4;
      this.gridAdjustSnowball.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewAdjustSnowball});
      // 
      // adjustSnowballAmountEventBindingSource
      // 
      this.adjustSnowballAmountEventBindingSource.DataSource = typeof(FinanceSim.AdjustSnowballAmountEvent);
      // 
      // gridViewAdjustSnowball
      // 
      this.gridViewAdjustSnowball.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPaycheckAdjustAmount,
            this.colPaycheckAdjustDate});
      this.gridViewAdjustSnowball.GridControl = this.gridAdjustSnowball;
      this.gridViewAdjustSnowball.Name = "gridViewAdjustSnowball";
      this.gridViewAdjustSnowball.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
      this.gridViewAdjustSnowball.OptionsView.ShowGroupPanel = false;
      // 
      // colPaycheckAdjustAmount
      // 
      this.colPaycheckAdjustAmount.DisplayFormat.FormatString = "c2";
      this.colPaycheckAdjustAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
      this.colPaycheckAdjustAmount.FieldName = "Amount";
      this.colPaycheckAdjustAmount.Name = "colPaycheckAdjustAmount";
      this.colPaycheckAdjustAmount.Visible = true;
      this.colPaycheckAdjustAmount.VisibleIndex = 1;
      // 
      // colPaycheckAdjustDate
      // 
      this.colPaycheckAdjustDate.FieldName = "Date";
      this.colPaycheckAdjustDate.Name = "colPaycheckAdjustDate";
      this.colPaycheckAdjustDate.Visible = true;
      this.colPaycheckAdjustDate.VisibleIndex = 0;
      // 
      // layoutControlGroup1
      // 
      this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
      this.layoutControlGroup1.GroupBordersVisible = false;
      this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.tabbedControlGroup1,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.emptySpaceItem1});
      this.layoutControlGroup1.Name = "Root";
      this.layoutControlGroup1.Size = new System.Drawing.Size(575, 360);
      this.layoutControlGroup1.TextVisible = false;
      // 
      // tabbedControlGroup1
      // 
      this.tabbedControlGroup1.CustomizationFormText = "tabbedControlGroup1";
      this.tabbedControlGroup1.Location = new System.Drawing.Point(0, 0);
      this.tabbedControlGroup1.Name = "tabbedControlGroup1";
      this.tabbedControlGroup1.SelectedTabPage = this.layoutControlGroup4;
      this.tabbedControlGroup1.SelectedTabPageIndex = 0;
      this.tabbedControlGroup1.Size = new System.Drawing.Size(555, 314);
      this.tabbedControlGroup1.TabPages.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup4,
            this.layoutControlGroup2,
            this.layoutControlGroup3});
      // 
      // layoutControlGroup4
      // 
      this.layoutControlGroup4.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem3});
      this.layoutControlGroup4.Location = new System.Drawing.Point(0, 0);
      this.layoutControlGroup4.Name = "layoutControlGroup4";
      this.layoutControlGroup4.Size = new System.Drawing.Size(531, 268);
      this.layoutControlGroup4.Text = "Adjust Paycheck Total";
      // 
      // layoutControlItem3
      // 
      this.layoutControlItem3.Control = this.gridChangePaycheckTotal;
      this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
      this.layoutControlItem3.Name = "layoutControlItem3";
      this.layoutControlItem3.Size = new System.Drawing.Size(531, 268);
      this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
      this.layoutControlItem3.TextVisible = false;
      // 
      // layoutControlGroup2
      // 
      this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
      this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
      this.layoutControlGroup2.Name = "layoutControlGroup2";
      this.layoutControlGroup2.Size = new System.Drawing.Size(531, 268);
      this.layoutControlGroup2.Text = "Adjust Snowball";
      // 
      // layoutControlItem1
      // 
      this.layoutControlItem1.Control = this.gridAdjustSnowball;
      this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
      this.layoutControlItem1.Name = "layoutControlItem1";
      this.layoutControlItem1.Size = new System.Drawing.Size(531, 268);
      this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
      this.layoutControlItem1.TextVisible = false;
      // 
      // layoutControlGroup3
      // 
      this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2});
      this.layoutControlGroup3.Location = new System.Drawing.Point(0, 0);
      this.layoutControlGroup3.Name = "layoutControlGroup3";
      this.layoutControlGroup3.Size = new System.Drawing.Size(531, 268);
      this.layoutControlGroup3.Text = "Change Bill Payment";
      // 
      // layoutControlItem2
      // 
      this.layoutControlItem2.Control = this.gridChangeBillPayment;
      this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
      this.layoutControlItem2.Name = "layoutControlItem2";
      this.layoutControlItem2.Size = new System.Drawing.Size(531, 268);
      this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
      this.layoutControlItem2.TextVisible = false;
      // 
      // layoutControlItem4
      // 
      this.layoutControlItem4.Control = this.btnOK;
      this.layoutControlItem4.Location = new System.Drawing.Point(395, 314);
      this.layoutControlItem4.MaxSize = new System.Drawing.Size(80, 0);
      this.layoutControlItem4.MinSize = new System.Drawing.Size(80, 26);
      this.layoutControlItem4.Name = "layoutControlItem4";
      this.layoutControlItem4.Size = new System.Drawing.Size(80, 26);
      this.layoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
      this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
      this.layoutControlItem4.TextVisible = false;
      // 
      // layoutControlItem5
      // 
      this.layoutControlItem5.Control = this.btnCancel;
      this.layoutControlItem5.Location = new System.Drawing.Point(475, 314);
      this.layoutControlItem5.MaxSize = new System.Drawing.Size(80, 0);
      this.layoutControlItem5.MinSize = new System.Drawing.Size(80, 26);
      this.layoutControlItem5.Name = "layoutControlItem5";
      this.layoutControlItem5.Size = new System.Drawing.Size(80, 26);
      this.layoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
      this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
      this.layoutControlItem5.TextVisible = false;
      // 
      // emptySpaceItem1
      // 
      this.emptySpaceItem1.AllowHotTrack = false;
      this.emptySpaceItem1.Location = new System.Drawing.Point(0, 314);
      this.emptySpaceItem1.Name = "emptySpaceItem1";
      this.emptySpaceItem1.Size = new System.Drawing.Size(395, 26);
      this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
      // 
      // SetupEventsDialog
      // 
      this.AcceptButton = this.btnOK;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.btnCancel;
      this.ClientSize = new System.Drawing.Size(575, 360);
      this.Controls.Add(this.layoutControl1);
      this.Name = "SetupEventsDialog";
      this.Text = "SetupEventsDialog";
      ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
      this.layoutControl1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.gridChangePaycheckTotal)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.adjustPaycheckTotalEventBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridViewChangePaycheckTotal)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.cboPaychecks)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.paycheckBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridChangeBillPayment)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.changeBillPaymentEventBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridViewChangeBillPayment)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.cboBills)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.billBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridAdjustSnowball)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.adjustSnowballAmountEventBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridViewAdjustSnowball)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.tabbedControlGroup1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private DevExpress.XtraLayout.LayoutControl layoutControl1;
    private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
    private DevExpress.XtraGrid.GridControl gridAdjustSnowball;
    private DevExpress.XtraGrid.Views.Grid.GridView gridViewAdjustSnowball;
    private DevExpress.XtraLayout.TabbedControlGroup tabbedControlGroup1;
    private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
    private DevExpress.XtraGrid.GridControl gridChangePaycheckTotal;
    private DevExpress.XtraGrid.Views.Grid.GridView gridViewChangePaycheckTotal;
    private DevExpress.XtraGrid.GridControl gridChangeBillPayment;
    private DevExpress.XtraGrid.Views.Grid.GridView gridViewChangeBillPayment;
    private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
    private DevExpress.XtraEditors.SimpleButton btnCancel;
    private DevExpress.XtraEditors.SimpleButton btnOK;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
    private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
    private System.Windows.Forms.BindingSource adjustSnowballAmountEventBindingSource;
    private DevExpress.XtraGrid.Columns.GridColumn colPaycheckAdjustAmount;
    private DevExpress.XtraGrid.Columns.GridColumn colPaycheckAdjustDate;
    private System.Windows.Forms.BindingSource changeBillPaymentEventBindingSource;
    private DevExpress.XtraGrid.Columns.GridColumn colChangeBillPaymentDate;
    private DevExpress.XtraGrid.Columns.GridColumn colChangeBillPaymentBillId;
    private DevExpress.XtraGrid.Columns.GridColumn colChangeBillPaymentNewPayment;
    private System.Windows.Forms.BindingSource billBindingSource;
    private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit cboBills;
    private System.Windows.Forms.BindingSource adjustPaycheckTotalEventBindingSource;
    private DevExpress.XtraGrid.Columns.GridColumn colChangePaycheckTotalDate;
    private DevExpress.XtraGrid.Columns.GridColumn colChangePaycheckTotalPaycheckId;
    private System.Windows.Forms.BindingSource paycheckBindingSource;
    private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit cboPaychecks;
    private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup4;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
    private DevExpress.XtraGrid.Columns.GridColumn colAdjustPaycheckTotalAmount;
  }
}