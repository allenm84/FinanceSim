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
      this.treeList1 = new DevExpress.XtraTreeList.TreeList();
      this.colName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
      this.colBalance = new DevExpress.XtraTreeList.Columns.TreeListColumn();
      this.colPayment = new DevExpress.XtraTreeList.Columns.TreeListColumn();
      this.debtBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.btnOK = new DevExpress.XtraEditors.SimpleButton();
      this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
      this.numInitialSnowball = new DevExpress.XtraEditors.SpinEdit();
      this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
      this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
      this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
      this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
      this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
      this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
      this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
      this.dragDropEvents1 = new DevExpress.Utils.DragDrop.DragDropEvents(this.components);
      ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
      this.layoutControl1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.treeList1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.debtBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numInitialSnowball.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
      this.SuspendLayout();
      // 
      // layoutControl1
      // 
      this.layoutControl1.Controls.Add(this.treeList1);
      this.layoutControl1.Controls.Add(this.btnOK);
      this.layoutControl1.Controls.Add(this.btnCancel);
      this.layoutControl1.Controls.Add(this.numInitialSnowball);
      this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.layoutControl1.Location = new System.Drawing.Point(0, 0);
      this.layoutControl1.Name = "layoutControl1";
      this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(876, 157, 650, 400);
      this.layoutControl1.Root = this.layoutControlGroup1;
      this.layoutControl1.Size = new System.Drawing.Size(391, 354);
      this.layoutControl1.TabIndex = 0;
      this.layoutControl1.Text = "layoutControl1";
      // 
      // treeList1
      // 
      this.behaviorManager1.SetBehaviors(this.treeList1, new DevExpress.Utils.Behaviors.Behavior[] {
            ((DevExpress.Utils.Behaviors.Behavior)(DevExpress.Utils.DragDrop.DragDropBehavior.Create(typeof(DevExpress.XtraTreeList.TreeListDragDropSource), true, true, true, this.dragDropEvents1)))});
      this.treeList1.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colName,
            this.colBalance,
            this.colPayment});
      this.treeList1.DataSource = this.debtBindingSource;
      this.treeList1.Location = new System.Drawing.Point(12, 36);
      this.treeList1.Name = "treeList1";
      this.treeList1.OptionsBehavior.Editable = false;
      this.treeList1.OptionsCustomization.AllowBandMoving = false;
      this.treeList1.OptionsCustomization.AllowBandResizing = false;
      this.treeList1.OptionsCustomization.AllowColumnMoving = false;
      this.treeList1.OptionsCustomization.AllowSort = false;
      this.treeList1.OptionsView.ShowButtons = false;
      this.treeList1.OptionsView.ShowRoot = false;
      this.treeList1.Size = new System.Drawing.Size(367, 280);
      this.treeList1.TabIndex = 10;
      // 
      // colName
      // 
      this.colName.FieldName = "Name";
      this.colName.Name = "colName";
      this.colName.Visible = true;
      this.colName.VisibleIndex = 0;
      // 
      // colBalance
      // 
      this.colBalance.FieldName = "Balance";
      this.colBalance.Format.FormatString = "c2";
      this.colBalance.Format.FormatType = DevExpress.Utils.FormatType.Numeric;
      this.colBalance.Name = "colBalance";
      this.colBalance.Visible = true;
      this.colBalance.VisibleIndex = 1;
      // 
      // colPayment
      // 
      this.colPayment.FieldName = "Payment";
      this.colPayment.Format.FormatString = "c2";
      this.colPayment.Format.FormatType = DevExpress.Utils.FormatType.Numeric;
      this.colPayment.Name = "colPayment";
      this.colPayment.Visible = true;
      this.colPayment.VisibleIndex = 2;
      // 
      // debtBindingSource
      // 
      this.debtBindingSource.DataSource = typeof(FinanceSim.Debt);
      // 
      // btnOK
      // 
      this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.btnOK.Location = new System.Drawing.Point(239, 320);
      this.btnOK.Name = "btnOK";
      this.btnOK.Size = new System.Drawing.Size(68, 22);
      this.btnOK.StyleController = this.layoutControl1;
      this.btnOK.TabIndex = 9;
      this.btnOK.Text = "OK";
      // 
      // btnCancel
      // 
      this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnCancel.Location = new System.Drawing.Point(311, 320);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new System.Drawing.Size(68, 22);
      this.btnCancel.StyleController = this.layoutControl1;
      this.btnCancel.TabIndex = 8;
      this.btnCancel.Text = "Cancel";
      // 
      // numInitialSnowball
      // 
      this.numInitialSnowball.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.numInitialSnowball.Location = new System.Drawing.Point(85, 12);
      this.numInitialSnowball.Name = "numInitialSnowball";
      this.numInitialSnowball.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.numInitialSnowball.Properties.DisplayFormat.FormatString = "c2";
      this.numInitialSnowball.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
      this.numInitialSnowball.Size = new System.Drawing.Size(294, 20);
      this.numInitialSnowball.StyleController = this.layoutControl1;
      this.numInitialSnowball.TabIndex = 5;
      // 
      // layoutControlGroup1
      // 
      this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
      this.layoutControlGroup1.GroupBordersVisible = false;
      this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.emptySpaceItem1,
            this.layoutControlItem2,
            this.layoutControlItem5,
            this.layoutControlItem4,
            this.layoutControlItem3});
      this.layoutControlGroup1.Name = "Root";
      this.layoutControlGroup1.Size = new System.Drawing.Size(391, 354);
      this.layoutControlGroup1.TextVisible = false;
      // 
      // emptySpaceItem1
      // 
      this.emptySpaceItem1.AllowHotTrack = false;
      this.emptySpaceItem1.Location = new System.Drawing.Point(0, 308);
      this.emptySpaceItem1.MinSize = new System.Drawing.Size(104, 24);
      this.emptySpaceItem1.Name = "emptySpaceItem1";
      this.emptySpaceItem1.Size = new System.Drawing.Size(227, 26);
      this.emptySpaceItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
      this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
      // 
      // layoutControlItem2
      // 
      this.layoutControlItem2.Control = this.numInitialSnowball;
      this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
      this.layoutControlItem2.Name = "layoutControlItem2";
      this.layoutControlItem2.Size = new System.Drawing.Size(371, 24);
      this.layoutControlItem2.Text = "Initial Amount:";
      this.layoutControlItem2.TextSize = new System.Drawing.Size(70, 13);
      // 
      // layoutControlItem5
      // 
      this.layoutControlItem5.Control = this.btnCancel;
      this.layoutControlItem5.Location = new System.Drawing.Point(299, 308);
      this.layoutControlItem5.MaxSize = new System.Drawing.Size(72, 26);
      this.layoutControlItem5.MinSize = new System.Drawing.Size(72, 26);
      this.layoutControlItem5.Name = "layoutControlItem5";
      this.layoutControlItem5.Size = new System.Drawing.Size(72, 26);
      this.layoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
      this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
      this.layoutControlItem5.TextVisible = false;
      // 
      // layoutControlItem4
      // 
      this.layoutControlItem4.Control = this.btnOK;
      this.layoutControlItem4.Location = new System.Drawing.Point(227, 308);
      this.layoutControlItem4.MaxSize = new System.Drawing.Size(72, 26);
      this.layoutControlItem4.MinSize = new System.Drawing.Size(72, 26);
      this.layoutControlItem4.Name = "layoutControlItem4";
      this.layoutControlItem4.Size = new System.Drawing.Size(72, 26);
      this.layoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
      this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
      this.layoutControlItem4.TextVisible = false;
      // 
      // layoutControlItem3
      // 
      this.layoutControlItem3.Control = this.treeList1;
      this.layoutControlItem3.Location = new System.Drawing.Point(0, 24);
      this.layoutControlItem3.Name = "layoutControlItem3";
      this.layoutControlItem3.Size = new System.Drawing.Size(371, 284);
      this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
      this.layoutControlItem3.TextVisible = false;
      // 
      // dragDropEvents1
      // 
      this.dragDropEvents1.DragOver += new DevExpress.Utils.DragDrop.DragOverEventHandler(this.dragDropEvents1_DragOver);
      // 
      // SetupSnowballDialog
      // 
      this.AcceptButton = this.btnOK;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.btnCancel;
      this.ClientSize = new System.Drawing.Size(391, 354);
      this.Controls.Add(this.layoutControl1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "SetupSnowballDialog";
      this.Text = "Setup Snowball";
      ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
      this.layoutControl1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.treeList1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.debtBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numInitialSnowball.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private DevExpress.XtraLayout.LayoutControl layoutControl1;
    private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
    private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
    private DevExpress.XtraEditors.SpinEdit numInitialSnowball;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
    private DevExpress.XtraEditors.SimpleButton btnCancel;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
    private DevExpress.XtraEditors.SimpleButton btnOK;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
    private System.Windows.Forms.BindingSource debtBindingSource;
    private DevExpress.XtraTreeList.TreeList treeList1;
    private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
    private DevExpress.Utils.DragDrop.DragDropEvents dragDropEvents1;
    private DevExpress.XtraTreeList.Columns.TreeListColumn colName;
    private DevExpress.XtraTreeList.Columns.TreeListColumn colBalance;
    private DevExpress.XtraTreeList.Columns.TreeListColumn colPayment;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
  }
}