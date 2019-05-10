namespace FinanceSim
{
  partial class MainForm
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
      this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
      this.gridAccounts = new DevExpress.XtraGrid.GridControl();
      this.bankAccountBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.prShared = new DevExpress.XtraEditors.Repository.PersistentRepository(this.components);
      this.cboAccounts = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
      this.accountItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.btnEditDueInfo = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
      this.gridViewAccounts = new DevExpress.XtraGrid.Views.Grid.GridView();
      this.colAccountName = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colAccountType = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colAccountBalance = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colAccountAPY = new DevExpress.XtraGrid.Columns.GridColumn();
      this.gridPaychecks = new DevExpress.XtraGrid.GridControl();
      this.paycheckBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.gridViewPaychecks = new DevExpress.XtraGrid.Views.Grid.GridView();
      this.collPaycheckName = new DevExpress.XtraGrid.Columns.GridColumn();
      this.collPaycheckTotal = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colPaycheckAccountId = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colPaycheckDeposits = new DevExpress.XtraGrid.Columns.GridColumn();
      this.btnEditPaycheckDeposits = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
      this.collPaycheckDue = new DevExpress.XtraGrid.Columns.GridColumn();
      this.gridBills = new DevExpress.XtraGrid.GridControl();
      this.billBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.gridViewBills = new DevExpress.XtraGrid.Views.Grid.GridView();
      this.colBillName = new DevExpress.XtraGrid.Columns.GridColumn();
      this.coBilllPayment = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colBillAccountId = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colBillDue = new DevExpress.XtraGrid.Columns.GridColumn();
      this.gridDebts = new DevExpress.XtraGrid.GridControl();
      this.debtBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.gridViewDebts = new DevExpress.XtraGrid.Views.Grid.GridView();
      this.colDebtName = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colDebtPayment = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colDebtBalance = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colDebtInterest = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colDebtAccountId = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colDebtDue = new DevExpress.XtraGrid.Columns.GridColumn();
      this.cboProfiles = new DevExpress.XtraEditors.LookUpEdit();
      this.profileBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.txtProfileName = new DevExpress.XtraEditors.TextEdit();
      this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
      this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
      this.lcgProfile = new DevExpress.XtraLayout.LayoutControlGroup();
      this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
      this.tabbedControlGroup1 = new DevExpress.XtraLayout.TabbedControlGroup();
      this.layoutControlGroup5 = new DevExpress.XtraLayout.LayoutControlGroup();
      this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
      this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
      this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
      this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
      this.bar1 = new DevExpress.XtraBars.Bar();
      this.skinBarSubItem1 = new DevExpress.XtraBars.SkinBarSubItem();
      this.tbbSave = new DevExpress.XtraBars.BarButtonItem();
      this.tbbNewProfile = new DevExpress.XtraBars.BarButtonItem();
      this.tbbCloneProfile = new DevExpress.XtraBars.BarButtonItem();
      this.tbbRemoveProfile = new DevExpress.XtraBars.BarButtonItem();
      this.tbbRun = new DevExpress.XtraBars.BarButtonItem();
      this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
      this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
      this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
      this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
      this.layoutControlGroup4 = new DevExpress.XtraLayout.LayoutControlGroup();
      this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
      this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
      this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
      this.layoutControl1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.gridAccounts)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.bankAccountBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.cboAccounts)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.accountItemBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.btnEditDueInfo)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridViewAccounts)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridPaychecks)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.paycheckBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridViewPaychecks)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.btnEditPaycheckDeposits)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridBills)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.billBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridViewBills)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridDebts)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.debtBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridViewDebts)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.cboProfiles.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.profileBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtProfileName.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.lcgProfile)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.tabbedControlGroup1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup5)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
      this.SuspendLayout();
      // 
      // layoutControl1
      // 
      this.layoutControl1.Controls.Add(this.gridAccounts);
      this.layoutControl1.Controls.Add(this.gridPaychecks);
      this.layoutControl1.Controls.Add(this.gridBills);
      this.layoutControl1.Controls.Add(this.gridDebts);
      this.layoutControl1.Controls.Add(this.cboProfiles);
      this.layoutControl1.Controls.Add(this.txtProfileName);
      this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.layoutControl1.Location = new System.Drawing.Point(0, 31);
      this.layoutControl1.Name = "layoutControl1";
      this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(864, 331, 650, 400);
      this.layoutControl1.Root = this.layoutControlGroup1;
      this.layoutControl1.Size = new System.Drawing.Size(593, 485);
      this.layoutControl1.TabIndex = 0;
      this.layoutControl1.Text = "layoutControl1";
      // 
      // gridAccounts
      // 
      this.gridAccounts.DataSource = this.bankAccountBindingSource;
      this.gridAccounts.ExternalRepository = this.prShared;
      this.gridAccounts.Location = new System.Drawing.Point(36, 124);
      this.gridAccounts.MainView = this.gridViewAccounts;
      this.gridAccounts.Name = "gridAccounts";
      this.gridAccounts.Size = new System.Drawing.Size(521, 325);
      this.gridAccounts.TabIndex = 4;
      this.gridAccounts.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewAccounts});
      this.gridAccounts.ProcessGridKey += new System.Windows.Forms.KeyEventHandler(this.gridAccounts_ProcessGridKey);
      // 
      // bankAccountBindingSource
      // 
      this.bankAccountBindingSource.DataSource = typeof(FinanceSim.BankAccount);
      // 
      // prShared
      // 
      this.prShared.Items.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cboAccounts,
            this.btnEditDueInfo});
      // 
      // cboAccounts
      // 
      this.cboAccounts.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.cboAccounts.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name", 37, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.Ascending, DevExpress.Utils.DefaultBoolean.Default)});
      this.cboAccounts.DataSource = this.accountItemBindingSource;
      this.cboAccounts.DisplayMember = "Name";
      this.cboAccounts.Name = "cboAccounts";
      this.cboAccounts.NullText = "[Account]";
      this.cboAccounts.ShowHeader = false;
      this.cboAccounts.ShowLines = false;
      this.cboAccounts.ValueMember = "Id";
      // 
      // accountItemBindingSource
      // 
      this.accountItemBindingSource.DataSource = typeof(FinanceSim.AccountItem);
      // 
      // btnEditDueInfo
      // 
      this.btnEditDueInfo.AutoHeight = false;
      this.btnEditDueInfo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
      this.btnEditDueInfo.Name = "btnEditDueInfo";
      this.btnEditDueInfo.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
      this.btnEditDueInfo.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnEditDueInfo_ButtonClick);
      // 
      // gridViewAccounts
      // 
      this.gridViewAccounts.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAccountName,
            this.colAccountType,
            this.colAccountBalance,
            this.colAccountAPY});
      this.gridViewAccounts.GridControl = this.gridAccounts;
      this.gridViewAccounts.Name = "gridViewAccounts";
      this.gridViewAccounts.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
      this.gridViewAccounts.OptionsView.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
      this.gridViewAccounts.OptionsView.ShowGroupPanel = false;
      // 
      // colAccountName
      // 
      this.colAccountName.FieldName = "Name";
      this.colAccountName.Name = "colAccountName";
      this.colAccountName.Visible = true;
      this.colAccountName.VisibleIndex = 0;
      // 
      // colAccountType
      // 
      this.colAccountType.FieldName = "Type";
      this.colAccountType.Name = "colAccountType";
      this.colAccountType.Visible = true;
      this.colAccountType.VisibleIndex = 1;
      // 
      // colAccountBalance
      // 
      this.colAccountBalance.DisplayFormat.FormatString = "c2";
      this.colAccountBalance.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
      this.colAccountBalance.FieldName = "Balance";
      this.colAccountBalance.Name = "colAccountBalance";
      this.colAccountBalance.Visible = true;
      this.colAccountBalance.VisibleIndex = 2;
      // 
      // colAccountAPY
      // 
      this.colAccountAPY.DisplayFormat.FormatString = "p2";
      this.colAccountAPY.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
      this.colAccountAPY.FieldName = "APY";
      this.colAccountAPY.Name = "colAccountAPY";
      this.colAccountAPY.Visible = true;
      this.colAccountAPY.VisibleIndex = 3;
      // 
      // gridPaychecks
      // 
      this.gridPaychecks.DataSource = this.paycheckBindingSource;
      this.gridPaychecks.ExternalRepository = this.prShared;
      this.gridPaychecks.Location = new System.Drawing.Point(36, 124);
      this.gridPaychecks.MainView = this.gridViewPaychecks;
      this.gridPaychecks.Name = "gridPaychecks";
      this.gridPaychecks.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnEditPaycheckDeposits});
      this.gridPaychecks.Size = new System.Drawing.Size(521, 325);
      this.gridPaychecks.TabIndex = 5;
      this.gridPaychecks.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewPaychecks});
      this.gridPaychecks.ProcessGridKey += new System.Windows.Forms.KeyEventHandler(this.gridPaychecks_ProcessGridKey);
      // 
      // paycheckBindingSource
      // 
      this.paycheckBindingSource.DataSource = typeof(FinanceSim.Paycheck);
      // 
      // gridViewPaychecks
      // 
      this.gridViewPaychecks.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.collPaycheckName,
            this.collPaycheckTotal,
            this.colPaycheckAccountId,
            this.colPaycheckDeposits,
            this.collPaycheckDue});
      this.gridViewPaychecks.GridControl = this.gridPaychecks;
      this.gridViewPaychecks.Name = "gridViewPaychecks";
      this.gridViewPaychecks.OptionsDetail.EnableMasterViewMode = false;
      this.gridViewPaychecks.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
      this.gridViewPaychecks.OptionsView.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
      this.gridViewPaychecks.OptionsView.ShowGroupPanel = false;
      this.gridViewPaychecks.CustomUnboundColumnData += new DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(this.gridViewPaychecks_CustomUnboundColumnData);
      // 
      // collPaycheckName
      // 
      this.collPaycheckName.FieldName = "Name";
      this.collPaycheckName.Name = "collPaycheckName";
      this.collPaycheckName.Visible = true;
      this.collPaycheckName.VisibleIndex = 0;
      // 
      // collPaycheckTotal
      // 
      this.collPaycheckTotal.DisplayFormat.FormatString = "c2";
      this.collPaycheckTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
      this.collPaycheckTotal.FieldName = "Total";
      this.collPaycheckTotal.Name = "collPaycheckTotal";
      this.collPaycheckTotal.Visible = true;
      this.collPaycheckTotal.VisibleIndex = 1;
      // 
      // colPaycheckAccountId
      // 
      this.colPaycheckAccountId.Caption = "Account";
      this.colPaycheckAccountId.ColumnEdit = this.cboAccounts;
      this.colPaycheckAccountId.FieldName = "AccountId";
      this.colPaycheckAccountId.Name = "colPaycheckAccountId";
      this.colPaycheckAccountId.Visible = true;
      this.colPaycheckAccountId.VisibleIndex = 2;
      // 
      // colPaycheckDeposits
      // 
      this.colPaycheckDeposits.Caption = "Deposits";
      this.colPaycheckDeposits.ColumnEdit = this.btnEditPaycheckDeposits;
      this.colPaycheckDeposits.FieldName = "colPaycheckDeposits";
      this.colPaycheckDeposits.Name = "colPaycheckDeposits";
      this.colPaycheckDeposits.UnboundType = DevExpress.Data.UnboundColumnType.String;
      this.colPaycheckDeposits.Visible = true;
      this.colPaycheckDeposits.VisibleIndex = 3;
      // 
      // btnEditPaycheckDeposits
      // 
      this.btnEditPaycheckDeposits.AutoHeight = false;
      this.btnEditPaycheckDeposits.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
      this.btnEditPaycheckDeposits.Name = "btnEditPaycheckDeposits";
      this.btnEditPaycheckDeposits.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
      this.btnEditPaycheckDeposits.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnEditPaycheckDeposits_ButtonClick);
      // 
      // collPaycheckDue
      // 
      this.collPaycheckDue.Caption = "Schedule";
      this.collPaycheckDue.ColumnEdit = this.btnEditDueInfo;
      this.collPaycheckDue.FieldName = "Due";
      this.collPaycheckDue.Name = "collPaycheckDue";
      this.collPaycheckDue.Visible = true;
      this.collPaycheckDue.VisibleIndex = 4;
      // 
      // gridBills
      // 
      this.gridBills.DataSource = this.billBindingSource;
      this.gridBills.ExternalRepository = this.prShared;
      this.gridBills.Location = new System.Drawing.Point(36, 124);
      this.gridBills.MainView = this.gridViewBills;
      this.gridBills.Name = "gridBills";
      this.gridBills.Size = new System.Drawing.Size(521, 325);
      this.gridBills.TabIndex = 6;
      this.gridBills.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewBills});
      this.gridBills.ProcessGridKey += new System.Windows.Forms.KeyEventHandler(this.gridBills_ProcessGridKey);
      // 
      // billBindingSource
      // 
      this.billBindingSource.DataSource = typeof(FinanceSim.Bill);
      // 
      // gridViewBills
      // 
      this.gridViewBills.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colBillName,
            this.coBilllPayment,
            this.colBillAccountId,
            this.colBillDue});
      this.gridViewBills.GridControl = this.gridBills;
      this.gridViewBills.Name = "gridViewBills";
      this.gridViewBills.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
      this.gridViewBills.OptionsView.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
      this.gridViewBills.OptionsView.ShowGroupPanel = false;
      // 
      // colBillName
      // 
      this.colBillName.FieldName = "Name";
      this.colBillName.Name = "colBillName";
      this.colBillName.Visible = true;
      this.colBillName.VisibleIndex = 0;
      // 
      // coBilllPayment
      // 
      this.coBilllPayment.DisplayFormat.FormatString = "c2";
      this.coBilllPayment.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
      this.coBilllPayment.FieldName = "Payment";
      this.coBilllPayment.Name = "coBilllPayment";
      this.coBilllPayment.Visible = true;
      this.coBilllPayment.VisibleIndex = 1;
      // 
      // colBillAccountId
      // 
      this.colBillAccountId.Caption = "Account";
      this.colBillAccountId.ColumnEdit = this.cboAccounts;
      this.colBillAccountId.FieldName = "AccountId";
      this.colBillAccountId.Name = "colBillAccountId";
      this.colBillAccountId.Visible = true;
      this.colBillAccountId.VisibleIndex = 2;
      // 
      // colBillDue
      // 
      this.colBillDue.Caption = "Schedule";
      this.colBillDue.ColumnEdit = this.btnEditDueInfo;
      this.colBillDue.FieldName = "Due";
      this.colBillDue.Name = "colBillDue";
      this.colBillDue.Visible = true;
      this.colBillDue.VisibleIndex = 3;
      // 
      // gridDebts
      // 
      this.gridDebts.DataSource = this.debtBindingSource;
      this.gridDebts.ExternalRepository = this.prShared;
      this.gridDebts.Location = new System.Drawing.Point(36, 124);
      this.gridDebts.MainView = this.gridViewDebts;
      this.gridDebts.Name = "gridDebts";
      this.gridDebts.Size = new System.Drawing.Size(521, 325);
      this.gridDebts.TabIndex = 7;
      this.gridDebts.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewDebts});
      this.gridDebts.ProcessGridKey += new System.Windows.Forms.KeyEventHandler(this.gridDebts_ProcessGridKey);
      // 
      // debtBindingSource
      // 
      this.debtBindingSource.DataSource = typeof(FinanceSim.Debt);
      // 
      // gridViewDebts
      // 
      this.gridViewDebts.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDebtName,
            this.colDebtPayment,
            this.colDebtBalance,
            this.colDebtInterest,
            this.colDebtAccountId,
            this.colDebtDue});
      this.gridViewDebts.GridControl = this.gridDebts;
      this.gridViewDebts.Name = "gridViewDebts";
      this.gridViewDebts.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
      this.gridViewDebts.OptionsView.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
      this.gridViewDebts.OptionsView.ShowGroupPanel = false;
      // 
      // colDebtName
      // 
      this.colDebtName.FieldName = "Name";
      this.colDebtName.Name = "colDebtName";
      this.colDebtName.Visible = true;
      this.colDebtName.VisibleIndex = 0;
      // 
      // colDebtPayment
      // 
      this.colDebtPayment.DisplayFormat.FormatString = "c2";
      this.colDebtPayment.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
      this.colDebtPayment.FieldName = "Payment";
      this.colDebtPayment.Name = "colDebtPayment";
      this.colDebtPayment.Visible = true;
      this.colDebtPayment.VisibleIndex = 1;
      // 
      // colDebtBalance
      // 
      this.colDebtBalance.DisplayFormat.FormatString = "c2";
      this.colDebtBalance.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
      this.colDebtBalance.FieldName = "Balance";
      this.colDebtBalance.Name = "colDebtBalance";
      this.colDebtBalance.Visible = true;
      this.colDebtBalance.VisibleIndex = 2;
      // 
      // colDebtInterest
      // 
      this.colDebtInterest.DisplayFormat.FormatString = "p2";
      this.colDebtInterest.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
      this.colDebtInterest.FieldName = "Interest";
      this.colDebtInterest.Name = "colDebtInterest";
      this.colDebtInterest.Visible = true;
      this.colDebtInterest.VisibleIndex = 3;
      // 
      // colDebtAccountId
      // 
      this.colDebtAccountId.Caption = "Account";
      this.colDebtAccountId.ColumnEdit = this.cboAccounts;
      this.colDebtAccountId.FieldName = "AccountId";
      this.colDebtAccountId.Name = "colDebtAccountId";
      this.colDebtAccountId.Visible = true;
      this.colDebtAccountId.VisibleIndex = 4;
      // 
      // colDebtDue
      // 
      this.colDebtDue.Caption = "Schedule";
      this.colDebtDue.ColumnEdit = this.btnEditDueInfo;
      this.colDebtDue.FieldName = "Due";
      this.colDebtDue.Name = "colDebtDue";
      this.colDebtDue.Visible = true;
      this.colDebtDue.VisibleIndex = 5;
      // 
      // cboProfiles
      // 
      this.cboProfiles.Location = new System.Drawing.Point(54, 12);
      this.cboProfiles.Name = "cboProfiles";
      this.cboProfiles.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.cboProfiles.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name", 50, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Created", "Created", 49, DevExpress.Utils.FormatType.DateTime, "M/d/yyyy", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
      this.cboProfiles.Properties.DataSource = this.profileBindingSource;
      this.cboProfiles.Properties.DisplayMember = "Name";
      this.cboProfiles.Properties.NullText = "[Select a Profile]";
      this.cboProfiles.Properties.ShowHeader = false;
      this.cboProfiles.Properties.ShowLines = false;
      this.cboProfiles.Size = new System.Drawing.Size(527, 20);
      this.cboProfiles.StyleController = this.layoutControl1;
      this.cboProfiles.TabIndex = 4;
      this.cboProfiles.EditValueChanged += new System.EventHandler(this.cboProfiles_EditValueChanged);
      // 
      // profileBindingSource
      // 
      this.profileBindingSource.DataSource = typeof(FinanceSim.Profile);
      // 
      // txtProfileName
      // 
      this.txtProfileName.EditValue = "";
      this.txtProfileName.Location = new System.Drawing.Point(66, 66);
      this.txtProfileName.Name = "txtProfileName";
      this.txtProfileName.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered;
      this.txtProfileName.Size = new System.Drawing.Size(503, 20);
      this.txtProfileName.StyleController = this.layoutControl1;
      this.txtProfileName.TabIndex = 6;
      // 
      // layoutControlGroup1
      // 
      this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
      this.layoutControlGroup1.GroupBordersVisible = false;
      this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.lcgProfile});
      this.layoutControlGroup1.Name = "Root";
      this.layoutControlGroup1.Size = new System.Drawing.Size(593, 485);
      this.layoutControlGroup1.TextVisible = false;
      // 
      // layoutControlItem1
      // 
      this.layoutControlItem1.Control = this.cboProfiles;
      this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
      this.layoutControlItem1.Name = "layoutControlItem1";
      this.layoutControlItem1.Size = new System.Drawing.Size(573, 24);
      this.layoutControlItem1.Text = "Profiles:";
      this.layoutControlItem1.TextSize = new System.Drawing.Size(39, 13);
      // 
      // lcgProfile
      // 
      this.lcgProfile.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem7,
            this.tabbedControlGroup1});
      this.lcgProfile.Location = new System.Drawing.Point(0, 24);
      this.lcgProfile.Name = "lcgProfile";
      this.lcgProfile.Size = new System.Drawing.Size(573, 441);
      this.lcgProfile.Text = "[Select a Profile]";
      // 
      // layoutControlItem7
      // 
      this.layoutControlItem7.Control = this.txtProfileName;
      this.layoutControlItem7.Location = new System.Drawing.Point(0, 0);
      this.layoutControlItem7.Name = "layoutControlItem7";
      this.layoutControlItem7.Size = new System.Drawing.Size(549, 24);
      this.layoutControlItem7.Text = "Name:";
      this.layoutControlItem7.TextSize = new System.Drawing.Size(39, 13);
      // 
      // tabbedControlGroup1
      // 
      this.tabbedControlGroup1.Location = new System.Drawing.Point(0, 24);
      this.tabbedControlGroup1.Name = "tabbedControlGroup1";
      this.tabbedControlGroup1.SelectedTabPage = this.layoutControlGroup5;
      this.tabbedControlGroup1.SelectedTabPageIndex = 0;
      this.tabbedControlGroup1.Size = new System.Drawing.Size(549, 375);
      this.tabbedControlGroup1.TabPages.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup5,
            this.layoutControlGroup4,
            this.layoutControlGroup3,
            this.layoutControlGroup2});
      // 
      // layoutControlGroup5
      // 
      this.layoutControlGroup5.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem5});
      this.layoutControlGroup5.Location = new System.Drawing.Point(0, 0);
      this.layoutControlGroup5.Name = "layoutControlGroup5";
      this.layoutControlGroup5.Size = new System.Drawing.Size(525, 329);
      this.layoutControlGroup5.Text = "Accounts";
      // 
      // layoutControlItem5
      // 
      this.layoutControlItem5.Control = this.gridAccounts;
      this.layoutControlItem5.Location = new System.Drawing.Point(0, 0);
      this.layoutControlItem5.Name = "layoutControlItem5";
      this.layoutControlItem5.Size = new System.Drawing.Size(525, 329);
      this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
      this.layoutControlItem5.TextVisible = false;
      // 
      // layoutControlGroup2
      // 
      this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2});
      this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
      this.layoutControlGroup2.Name = "layoutControlGroup2";
      this.layoutControlGroup2.Size = new System.Drawing.Size(525, 329);
      this.layoutControlGroup2.Text = "Debts";
      // 
      // layoutControlItem2
      // 
      this.layoutControlItem2.Control = this.gridDebts;
      this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
      this.layoutControlItem2.Name = "layoutControlItem2";
      this.layoutControlItem2.Size = new System.Drawing.Size(525, 329);
      this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
      this.layoutControlItem2.TextVisible = false;
      // 
      // barManager1
      // 
      this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
      this.barManager1.DockControls.Add(this.barDockControlTop);
      this.barManager1.DockControls.Add(this.barDockControlBottom);
      this.barManager1.DockControls.Add(this.barDockControlLeft);
      this.barManager1.DockControls.Add(this.barDockControlRight);
      this.barManager1.Form = this;
      this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.skinBarSubItem1,
            this.tbbSave,
            this.tbbNewProfile,
            this.tbbCloneProfile,
            this.tbbRemoveProfile,
            this.tbbRun});
      this.barManager1.MaxItemId = 8;
      // 
      // bar1
      // 
      this.bar1.BarName = "Tools";
      this.bar1.DockCol = 0;
      this.bar1.DockRow = 0;
      this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
      this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.skinBarSubItem1, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.tbbSave, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.tbbNewProfile, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.tbbCloneProfile, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.tbbRemoveProfile, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.tbbRun, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
      this.bar1.OptionsBar.AllowQuickCustomization = false;
      this.bar1.OptionsBar.DrawDragBorder = false;
      this.bar1.OptionsBar.UseWholeRow = true;
      this.bar1.Text = "Tools";
      // 
      // skinBarSubItem1
      // 
      this.skinBarSubItem1.Caption = "Skins";
      this.skinBarSubItem1.Id = 0;
      this.skinBarSubItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("skinBarSubItem1.ImageOptions.Image")));
      this.skinBarSubItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("skinBarSubItem1.ImageOptions.LargeImage")));
      this.skinBarSubItem1.Name = "skinBarSubItem1";
      // 
      // tbbSave
      // 
      this.tbbSave.Caption = "Save";
      this.tbbSave.Id = 1;
      this.tbbSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("tbbSave.ImageOptions.Image")));
      this.tbbSave.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("tbbSave.ImageOptions.LargeImage")));
      this.tbbSave.Name = "tbbSave";
      this.tbbSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.tbbSave_ItemClick);
      // 
      // tbbNewProfile
      // 
      this.tbbNewProfile.Caption = "New";
      this.tbbNewProfile.Id = 2;
      this.tbbNewProfile.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("tbbNewProfile.ImageOptions.Image")));
      this.tbbNewProfile.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("tbbNewProfile.ImageOptions.LargeImage")));
      this.tbbNewProfile.Name = "tbbNewProfile";
      this.tbbNewProfile.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.tbbNewProfile_ItemClick);
      // 
      // tbbCloneProfile
      // 
      this.tbbCloneProfile.Caption = "Clone";
      this.tbbCloneProfile.Id = 3;
      this.tbbCloneProfile.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("tbbCloneProfile.ImageOptions.Image")));
      this.tbbCloneProfile.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("tbbCloneProfile.ImageOptions.LargeImage")));
      this.tbbCloneProfile.Name = "tbbCloneProfile";
      this.tbbCloneProfile.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.tbbCloneProfile_ItemClick);
      // 
      // tbbRemoveProfile
      // 
      this.tbbRemoveProfile.Caption = "Remove";
      this.tbbRemoveProfile.Id = 4;
      this.tbbRemoveProfile.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("tbbRemoveProfile.ImageOptions.Image")));
      this.tbbRemoveProfile.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("tbbRemoveProfile.ImageOptions.LargeImage")));
      this.tbbRemoveProfile.Name = "tbbRemoveProfile";
      this.tbbRemoveProfile.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.tbbRemoveProfile_ItemClick);
      // 
      // tbbRun
      // 
      this.tbbRun.Caption = "Run";
      this.tbbRun.Id = 7;
      this.tbbRun.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("tbbRun.ImageOptions.Image")));
      this.tbbRun.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("tbbRun.ImageOptions.LargeImage")));
      this.tbbRun.Name = "tbbRun";
      this.tbbRun.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.tbbRun_ItemClick);
      // 
      // barDockControlTop
      // 
      this.barDockControlTop.CausesValidation = false;
      this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
      this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
      this.barDockControlTop.Manager = this.barManager1;
      this.barDockControlTop.Size = new System.Drawing.Size(593, 31);
      // 
      // barDockControlBottom
      // 
      this.barDockControlBottom.CausesValidation = false;
      this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.barDockControlBottom.Location = new System.Drawing.Point(0, 516);
      this.barDockControlBottom.Manager = this.barManager1;
      this.barDockControlBottom.Size = new System.Drawing.Size(593, 0);
      // 
      // barDockControlLeft
      // 
      this.barDockControlLeft.CausesValidation = false;
      this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
      this.barDockControlLeft.Location = new System.Drawing.Point(0, 31);
      this.barDockControlLeft.Manager = this.barManager1;
      this.barDockControlLeft.Size = new System.Drawing.Size(0, 485);
      // 
      // barDockControlRight
      // 
      this.barDockControlRight.CausesValidation = false;
      this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
      this.barDockControlRight.Location = new System.Drawing.Point(593, 31);
      this.barDockControlRight.Manager = this.barManager1;
      this.barDockControlRight.Size = new System.Drawing.Size(0, 485);
      // 
      // layoutControlGroup4
      // 
      this.layoutControlGroup4.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem4});
      this.layoutControlGroup4.Location = new System.Drawing.Point(0, 0);
      this.layoutControlGroup4.Name = "layoutControlGroup4";
      this.layoutControlGroup4.Size = new System.Drawing.Size(525, 329);
      this.layoutControlGroup4.Text = "Paychecks";
      // 
      // layoutControlItem4
      // 
      this.layoutControlItem4.Control = this.gridPaychecks;
      this.layoutControlItem4.Location = new System.Drawing.Point(0, 0);
      this.layoutControlItem4.Name = "layoutControlItem4";
      this.layoutControlItem4.Size = new System.Drawing.Size(525, 329);
      this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
      this.layoutControlItem4.TextVisible = false;
      // 
      // layoutControlGroup3
      // 
      this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem3});
      this.layoutControlGroup3.Location = new System.Drawing.Point(0, 0);
      this.layoutControlGroup3.Name = "layoutControlGroup3";
      this.layoutControlGroup3.Size = new System.Drawing.Size(525, 329);
      this.layoutControlGroup3.Text = "Bills";
      // 
      // layoutControlItem3
      // 
      this.layoutControlItem3.Control = this.gridBills;
      this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
      this.layoutControlItem3.Name = "layoutControlItem3";
      this.layoutControlItem3.Size = new System.Drawing.Size(525, 329);
      this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
      this.layoutControlItem3.TextVisible = false;
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(593, 516);
      this.Controls.Add(this.layoutControl1);
      this.Controls.Add(this.barDockControlLeft);
      this.Controls.Add(this.barDockControlRight);
      this.Controls.Add(this.barDockControlBottom);
      this.Controls.Add(this.barDockControlTop);
      this.Name = "MainForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Finance Simulator";
      ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
      this.layoutControl1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.gridAccounts)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.bankAccountBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.cboAccounts)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.accountItemBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.btnEditDueInfo)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridViewAccounts)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridPaychecks)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.paycheckBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridViewPaychecks)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.btnEditPaycheckDeposits)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridBills)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.billBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridViewBills)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridDebts)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.debtBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridViewDebts)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.cboProfiles.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.profileBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtProfileName.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.lcgProfile)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.tabbedControlGroup1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup5)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private DevExpress.XtraLayout.LayoutControl layoutControl1;
    private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
    private DevExpress.XtraEditors.LookUpEdit cboProfiles;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
    private DevExpress.XtraLayout.LayoutControlGroup lcgProfile;
    private DevExpress.XtraGrid.GridControl gridDebts;
    private DevExpress.XtraGrid.Views.Grid.GridView gridViewDebts;
    private DevExpress.XtraGrid.GridControl gridBills;
    private DevExpress.XtraGrid.Views.Grid.GridView gridViewBills;
    private DevExpress.XtraGrid.GridControl gridPaychecks;
    private DevExpress.XtraGrid.Views.Grid.GridView gridViewPaychecks;
    private DevExpress.XtraGrid.GridControl gridAccounts;
    private DevExpress.XtraGrid.Views.Grid.GridView gridViewAccounts;
    private System.Windows.Forms.BindingSource bankAccountBindingSource;
    private DevExpress.XtraGrid.Columns.GridColumn colAccountName;
    private DevExpress.XtraGrid.Columns.GridColumn colAccountType;
    private DevExpress.XtraGrid.Columns.GridColumn colAccountBalance;
    private DevExpress.XtraGrid.Columns.GridColumn colAccountAPY;
    private DevExpress.XtraEditors.TextEdit txtProfileName;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
    private System.Windows.Forms.BindingSource paycheckBindingSource;
    private DevExpress.XtraGrid.Columns.GridColumn colPaycheckAccountId;
    private DevExpress.XtraGrid.Columns.GridColumn collPaycheckName;
    private DevExpress.XtraGrid.Columns.GridColumn collPaycheckTotal;
    private DevExpress.XtraGrid.Columns.GridColumn collPaycheckDue;
    private System.Windows.Forms.BindingSource billBindingSource;
    private DevExpress.XtraGrid.Columns.GridColumn colBillName;
    private DevExpress.XtraGrid.Columns.GridColumn colBillDue;
    private DevExpress.XtraGrid.Columns.GridColumn coBilllPayment;
    private DevExpress.XtraGrid.Columns.GridColumn colBillAccountId;
    private System.Windows.Forms.BindingSource debtBindingSource;
    private DevExpress.XtraGrid.Columns.GridColumn colDebtInterest;
    private DevExpress.XtraGrid.Columns.GridColumn colDebtBalance;
    private DevExpress.XtraGrid.Columns.GridColumn colDebtName;
    private DevExpress.XtraGrid.Columns.GridColumn colDebtDue;
    private DevExpress.XtraGrid.Columns.GridColumn colDebtPayment;
    private DevExpress.XtraGrid.Columns.GridColumn colDebtAccountId;
    private DevExpress.XtraEditors.Repository.PersistentRepository prShared;
    private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit cboAccounts;
    private System.Windows.Forms.BindingSource accountItemBindingSource;
    private DevExpress.XtraBars.BarManager barManager1;
    private DevExpress.XtraBars.Bar bar1;
    private DevExpress.XtraBars.BarDockControl barDockControlTop;
    private DevExpress.XtraBars.BarDockControl barDockControlBottom;
    private DevExpress.XtraBars.BarDockControl barDockControlLeft;
    private DevExpress.XtraBars.BarDockControl barDockControlRight;
    private DevExpress.XtraBars.SkinBarSubItem skinBarSubItem1;
    private DevExpress.XtraBars.BarButtonItem tbbSave;
    private DevExpress.XtraBars.BarButtonItem tbbNewProfile;
    private DevExpress.XtraBars.BarButtonItem tbbCloneProfile;
    private DevExpress.XtraBars.BarButtonItem tbbRemoveProfile;
    private System.Windows.Forms.BindingSource profileBindingSource;
    private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnEditDueInfo;
    private DevExpress.XtraGrid.Columns.GridColumn colPaycheckDeposits;
    private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnEditPaycheckDeposits;
    private DevExpress.XtraBars.BarButtonItem tbbRun;
    private DevExpress.XtraLayout.TabbedControlGroup tabbedControlGroup1;
    private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup5;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
    private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
    private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup4;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
    private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
  }
}

