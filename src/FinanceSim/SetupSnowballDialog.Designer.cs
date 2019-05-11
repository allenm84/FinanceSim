namespace FinanceSim
{
  partial class SetupSnowballDialog
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
      this.btnOK = new DevExpress.XtraEditors.SimpleButton();
      this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
      this.cboDebts = new DevExpress.XtraEditors.SearchLookUpEdit();
      this.debtBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
      this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
      this.numInitialSnowball = new DevExpress.XtraEditors.SpinEdit();
      this.dtStart = new DevExpress.XtraEditors.DateEdit();
      this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
      this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
      this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
      this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
      this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
      this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
      this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
      this.layoutControl1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.cboDebts.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.debtBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numInitialSnowball.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dtStart.Properties.CalendarTimeProperties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dtStart.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
      this.SuspendLayout();
      // 
      // layoutControl1
      // 
      this.layoutControl1.Controls.Add(this.btnOK);
      this.layoutControl1.Controls.Add(this.btnCancel);
      this.layoutControl1.Controls.Add(this.cboDebts);
      this.layoutControl1.Controls.Add(this.numInitialSnowball);
      this.layoutControl1.Controls.Add(this.dtStart);
      this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.layoutControl1.Location = new System.Drawing.Point(0, 0);
      this.layoutControl1.Name = "layoutControl1";
      this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(876, 155, 650, 400);
      this.layoutControl1.Root = this.layoutControlGroup1;
      this.layoutControl1.Size = new System.Drawing.Size(286, 122);
      this.layoutControl1.TabIndex = 0;
      this.layoutControl1.Text = "layoutControl1";
      // 
      // btnOK
      // 
      this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.btnOK.Location = new System.Drawing.Point(114, 84);
      this.btnOK.Name = "btnOK";
      this.btnOK.Size = new System.Drawing.Size(78, 22);
      this.btnOK.StyleController = this.layoutControl1;
      this.btnOK.TabIndex = 9;
      this.btnOK.Text = "OK";
      // 
      // btnCancel
      // 
      this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnCancel.Location = new System.Drawing.Point(196, 84);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new System.Drawing.Size(78, 22);
      this.btnCancel.StyleController = this.layoutControl1;
      this.btnCancel.TabIndex = 8;
      this.btnCancel.Text = "Cancel";
      // 
      // cboDebts
      // 
      this.cboDebts.Location = new System.Drawing.Point(85, 60);
      this.cboDebts.Name = "cboDebts";
      this.cboDebts.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.cboDebts.Properties.DataSource = this.debtBindingSource;
      this.cboDebts.Properties.DisplayMember = "Name";
      this.cboDebts.Properties.NullText = "[Select a debt]";
      this.cboDebts.Properties.PopupView = this.searchLookUpEdit1View;
      this.cboDebts.Size = new System.Drawing.Size(189, 20);
      this.cboDebts.StyleController = this.layoutControl1;
      this.cboDebts.TabIndex = 6;
      // 
      // debtBindingSource
      // 
      this.debtBindingSource.DataSource = typeof(FinanceSim.Debt);
      // 
      // searchLookUpEdit1View
      // 
      this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colName});
      this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
      this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
      this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.searchLookUpEdit1View.OptionsView.ShowColumnHeaders = false;
      this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
      this.searchLookUpEdit1View.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.False;
      this.searchLookUpEdit1View.OptionsView.ShowIndicator = false;
      this.searchLookUpEdit1View.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.False;
      this.searchLookUpEdit1View.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colName, DevExpress.Data.ColumnSortOrder.Ascending)});
      // 
      // colName
      // 
      this.colName.FieldName = "Name";
      this.colName.Name = "colName";
      this.colName.Visible = true;
      this.colName.VisibleIndex = 0;
      // 
      // numInitialSnowball
      // 
      this.numInitialSnowball.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.numInitialSnowball.Location = new System.Drawing.Point(85, 36);
      this.numInitialSnowball.Name = "numInitialSnowball";
      this.numInitialSnowball.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.numInitialSnowball.Properties.DisplayFormat.FormatString = "c2";
      this.numInitialSnowball.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
      this.numInitialSnowball.Size = new System.Drawing.Size(189, 20);
      this.numInitialSnowball.StyleController = this.layoutControl1;
      this.numInitialSnowball.TabIndex = 5;
      // 
      // dtStart
      // 
      this.dtStart.EditValue = null;
      this.dtStart.Location = new System.Drawing.Point(85, 12);
      this.dtStart.Name = "dtStart";
      this.dtStart.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.dtStart.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.dtStart.Size = new System.Drawing.Size(189, 20);
      this.dtStart.StyleController = this.layoutControl1;
      this.dtStart.TabIndex = 4;
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
            this.layoutControlItem5,
            this.layoutControlItem4});
      this.layoutControlGroup1.Name = "Root";
      this.layoutControlGroup1.Size = new System.Drawing.Size(286, 122);
      this.layoutControlGroup1.TextVisible = false;
      // 
      // layoutControlItem1
      // 
      this.layoutControlItem1.Control = this.dtStart;
      this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
      this.layoutControlItem1.Name = "layoutControlItem1";
      this.layoutControlItem1.Size = new System.Drawing.Size(266, 24);
      this.layoutControlItem1.Text = "Start Date:";
      this.layoutControlItem1.TextSize = new System.Drawing.Size(70, 13);
      // 
      // emptySpaceItem1
      // 
      this.emptySpaceItem1.AllowHotTrack = false;
      this.emptySpaceItem1.Location = new System.Drawing.Point(0, 72);
      this.emptySpaceItem1.Name = "emptySpaceItem1";
      this.emptySpaceItem1.Size = new System.Drawing.Size(102, 30);
      this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
      // 
      // layoutControlItem2
      // 
      this.layoutControlItem2.Control = this.numInitialSnowball;
      this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
      this.layoutControlItem2.Name = "layoutControlItem2";
      this.layoutControlItem2.Size = new System.Drawing.Size(266, 24);
      this.layoutControlItem2.Text = "Initial Amount:";
      this.layoutControlItem2.TextSize = new System.Drawing.Size(70, 13);
      // 
      // layoutControlItem3
      // 
      this.layoutControlItem3.Control = this.cboDebts;
      this.layoutControlItem3.Location = new System.Drawing.Point(0, 48);
      this.layoutControlItem3.Name = "layoutControlItem3";
      this.layoutControlItem3.Size = new System.Drawing.Size(266, 24);
      this.layoutControlItem3.Text = "First Target:";
      this.layoutControlItem3.TextSize = new System.Drawing.Size(70, 13);
      // 
      // layoutControlItem5
      // 
      this.layoutControlItem5.Control = this.btnCancel;
      this.layoutControlItem5.Location = new System.Drawing.Point(184, 72);
      this.layoutControlItem5.Name = "layoutControlItem5";
      this.layoutControlItem5.Size = new System.Drawing.Size(82, 30);
      this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
      this.layoutControlItem5.TextVisible = false;
      // 
      // layoutControlItem4
      // 
      this.layoutControlItem4.Control = this.btnOK;
      this.layoutControlItem4.Location = new System.Drawing.Point(102, 72);
      this.layoutControlItem4.Name = "layoutControlItem4";
      this.layoutControlItem4.Size = new System.Drawing.Size(82, 30);
      this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
      this.layoutControlItem4.TextVisible = false;
      // 
      // SetupSnowballDialog
      // 
      this.AcceptButton = this.btnOK;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.btnCancel;
      this.ClientSize = new System.Drawing.Size(286, 122);
      this.Controls.Add(this.layoutControl1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "SetupSnowballDialog";
      this.Text = "Setup Snowball";
      ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
      this.layoutControl1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.cboDebts.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.debtBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numInitialSnowball.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dtStart.Properties.CalendarTimeProperties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dtStart.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private DevExpress.XtraLayout.LayoutControl layoutControl1;
    private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
    private DevExpress.XtraEditors.DateEdit dtStart;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
    private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
    private DevExpress.XtraEditors.SpinEdit numInitialSnowball;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
    private DevExpress.XtraEditors.SearchLookUpEdit cboDebts;
    private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
    private DevExpress.XtraEditors.SimpleButton btnCancel;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
    private DevExpress.XtraEditors.SimpleButton btnOK;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
    private System.Windows.Forms.BindingSource debtBindingSource;
    private DevExpress.XtraGrid.Columns.GridColumn colName;
  }
}