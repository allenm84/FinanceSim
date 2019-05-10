namespace FinanceSim
{
  partial class EditPaycheckDepositsDialog
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
      this.gridDeposits = new DevExpress.XtraGrid.GridControl();
      this.paycheckDepositBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.gridViewDeposits = new DevExpress.XtraGrid.Views.Grid.GridView();
      this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colAmount = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colAccountId = new DevExpress.XtraGrid.Columns.GridColumn();
      this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
      this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
      this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
      this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
      this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
      this.layoutControl1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.gridDeposits)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.paycheckDepositBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridViewDeposits)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
      this.SuspendLayout();
      // 
      // layoutControl1
      // 
      this.layoutControl1.Controls.Add(this.btnCancel);
      this.layoutControl1.Controls.Add(this.btnOK);
      this.layoutControl1.Controls.Add(this.gridDeposits);
      this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.layoutControl1.Location = new System.Drawing.Point(0, 0);
      this.layoutControl1.Name = "layoutControl1";
      this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(853, 292, 650, 400);
      this.layoutControl1.Root = this.layoutControlGroup1;
      this.layoutControl1.Size = new System.Drawing.Size(433, 258);
      this.layoutControl1.TabIndex = 0;
      this.layoutControl1.Text = "layoutControl1";
      // 
      // btnCancel
      // 
      this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnCancel.Location = new System.Drawing.Point(345, 224);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new System.Drawing.Size(76, 22);
      this.btnCancel.StyleController = this.layoutControl1;
      this.btnCancel.TabIndex = 6;
      this.btnCancel.Text = "Cancel";
      // 
      // btnOK
      // 
      this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.btnOK.Location = new System.Drawing.Point(265, 224);
      this.btnOK.Name = "btnOK";
      this.btnOK.Size = new System.Drawing.Size(76, 22);
      this.btnOK.StyleController = this.layoutControl1;
      this.btnOK.TabIndex = 5;
      this.btnOK.Text = "OK";
      // 
      // gridDeposits
      // 
      this.gridDeposits.DataSource = this.paycheckDepositBindingSource;
      this.gridDeposits.Location = new System.Drawing.Point(12, 12);
      this.gridDeposits.MainView = this.gridViewDeposits;
      this.gridDeposits.Name = "gridDeposits";
      this.gridDeposits.Size = new System.Drawing.Size(409, 208);
      this.gridDeposits.TabIndex = 4;
      this.gridDeposits.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewDeposits});
      this.gridDeposits.ProcessGridKey += new System.Windows.Forms.KeyEventHandler(this.gridDeposits_ProcessGridKey);
      // 
      // paycheckDepositBindingSource
      // 
      this.paycheckDepositBindingSource.DataSource = typeof(FinanceSim.PaycheckDeposit);
      // 
      // gridViewDeposits
      // 
      this.gridViewDeposits.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colName,
            this.colAmount,
            this.colAccountId});
      this.gridViewDeposits.GridControl = this.gridDeposits;
      this.gridViewDeposits.Name = "gridViewDeposits";
      this.gridViewDeposits.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
      this.gridViewDeposits.OptionsView.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
      this.gridViewDeposits.OptionsView.ShowGroupPanel = false;
      // 
      // colName
      // 
      this.colName.FieldName = "Name";
      this.colName.Name = "colName";
      this.colName.Visible = true;
      this.colName.VisibleIndex = 0;
      // 
      // colAmount
      // 
      this.colAmount.DisplayFormat.FormatString = "c2";
      this.colAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
      this.colAmount.FieldName = "Amount";
      this.colAmount.Name = "colAmount";
      this.colAmount.Visible = true;
      this.colAmount.VisibleIndex = 1;
      // 
      // colAccountId
      // 
      this.colAccountId.Caption = "Account";
      this.colAccountId.FieldName = "AccountId";
      this.colAccountId.Name = "colAccountId";
      this.colAccountId.Visible = true;
      this.colAccountId.VisibleIndex = 2;
      // 
      // layoutControlGroup1
      // 
      this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
      this.layoutControlGroup1.GroupBordersVisible = false;
      this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.emptySpaceItem1});
      this.layoutControlGroup1.Name = "Root";
      this.layoutControlGroup1.Size = new System.Drawing.Size(433, 258);
      this.layoutControlGroup1.TextVisible = false;
      // 
      // layoutControlItem1
      // 
      this.layoutControlItem1.Control = this.gridDeposits;
      this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
      this.layoutControlItem1.Name = "layoutControlItem1";
      this.layoutControlItem1.Size = new System.Drawing.Size(413, 212);
      this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
      this.layoutControlItem1.TextVisible = false;
      // 
      // layoutControlItem2
      // 
      this.layoutControlItem2.Control = this.btnOK;
      this.layoutControlItem2.Location = new System.Drawing.Point(253, 212);
      this.layoutControlItem2.MaxSize = new System.Drawing.Size(80, 26);
      this.layoutControlItem2.MinSize = new System.Drawing.Size(80, 26);
      this.layoutControlItem2.Name = "layoutControlItem2";
      this.layoutControlItem2.Size = new System.Drawing.Size(80, 26);
      this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
      this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
      this.layoutControlItem2.TextVisible = false;
      // 
      // layoutControlItem3
      // 
      this.layoutControlItem3.Control = this.btnCancel;
      this.layoutControlItem3.Location = new System.Drawing.Point(333, 212);
      this.layoutControlItem3.MaxSize = new System.Drawing.Size(80, 26);
      this.layoutControlItem3.MinSize = new System.Drawing.Size(80, 26);
      this.layoutControlItem3.Name = "layoutControlItem3";
      this.layoutControlItem3.Size = new System.Drawing.Size(80, 26);
      this.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
      this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
      this.layoutControlItem3.TextVisible = false;
      // 
      // emptySpaceItem1
      // 
      this.emptySpaceItem1.AllowHotTrack = false;
      this.emptySpaceItem1.Location = new System.Drawing.Point(0, 212);
      this.emptySpaceItem1.Name = "emptySpaceItem1";
      this.emptySpaceItem1.Size = new System.Drawing.Size(253, 26);
      this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
      // 
      // EditPaycheckDepositsDialog
      // 
      this.AcceptButton = this.btnOK;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.btnCancel;
      this.ClientSize = new System.Drawing.Size(433, 258);
      this.Controls.Add(this.layoutControl1);
      this.Name = "EditPaycheckDepositsDialog";
      this.Text = "Edit Paycheck Deposits";
      ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
      this.layoutControl1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.gridDeposits)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.paycheckDepositBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridViewDeposits)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private DevExpress.XtraLayout.LayoutControl layoutControl1;
    private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
    private DevExpress.XtraGrid.GridControl gridDeposits;
    private DevExpress.XtraGrid.Views.Grid.GridView gridViewDeposits;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
    private DevExpress.XtraEditors.SimpleButton btnCancel;
    private DevExpress.XtraEditors.SimpleButton btnOK;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
    private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
    private System.Windows.Forms.BindingSource paycheckDepositBindingSource;
    private DevExpress.XtraGrid.Columns.GridColumn colAccountId;
    private DevExpress.XtraGrid.Columns.GridColumn colName;
    private DevExpress.XtraGrid.Columns.GridColumn colAmount;
  }
}