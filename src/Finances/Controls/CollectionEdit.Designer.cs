namespace Finances
{
  partial class CollectionEdit
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
      this.components = new System.ComponentModel.Container();
      DevExpress.XtraLayout.ColumnDefinition columnDefinition1 = new DevExpress.XtraLayout.ColumnDefinition();
      DevExpress.XtraLayout.ColumnDefinition columnDefinition2 = new DevExpress.XtraLayout.ColumnDefinition();
      DevExpress.XtraLayout.ColumnDefinition columnDefinition3 = new DevExpress.XtraLayout.ColumnDefinition();
      DevExpress.XtraLayout.ColumnDefinition columnDefinition4 = new DevExpress.XtraLayout.ColumnDefinition();
      DevExpress.XtraLayout.RowDefinition rowDefinition1 = new DevExpress.XtraLayout.RowDefinition();
      DevExpress.XtraLayout.RowDefinition rowDefinition2 = new DevExpress.XtraLayout.RowDefinition();
      this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
      this.gridCollection = new DevExpress.XtraGrid.GridControl();
      this.baseNamedItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.gridViewCollection = new DevExpress.XtraGrid.Views.Grid.GridView();
      this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
      this.pnlEditor = new DevExpress.XtraEditors.PanelControl();
      this.btnRemove = new DevExpress.XtraEditors.SimpleButton();
      this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
      this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
      this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
      this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
      this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
      this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
      this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
      this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
      this.splitterItem1 = new DevExpress.XtraLayout.SplitterItem();
      this.btnCopy = new DevExpress.XtraEditors.SimpleButton();
      this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
      this.layoutControl1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.gridCollection)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.baseNamedItemBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridViewCollection)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pnlEditor)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.splitterItem1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
      this.SuspendLayout();
      // 
      // layoutControl1
      // 
      this.layoutControl1.Controls.Add(this.btnCopy);
      this.layoutControl1.Controls.Add(this.gridCollection);
      this.layoutControl1.Controls.Add(this.pnlEditor);
      this.layoutControl1.Controls.Add(this.btnRemove);
      this.layoutControl1.Controls.Add(this.btnAdd);
      this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.layoutControl1.Location = new System.Drawing.Point(0, 0);
      this.layoutControl1.Name = "layoutControl1";
      this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1047, 156, 650, 400);
      this.layoutControl1.Root = this.layoutControlGroup1;
      this.layoutControl1.Size = new System.Drawing.Size(656, 429);
      this.layoutControl1.TabIndex = 0;
      this.layoutControl1.Text = "layoutControl1";
      // 
      // gridCollection
      // 
      this.gridCollection.DataSource = this.baseNamedItemBindingSource;
      this.gridCollection.Location = new System.Drawing.Point(14, 32);
      this.gridCollection.MainView = this.gridViewCollection;
      this.gridCollection.Name = "gridCollection";
      this.gridCollection.Size = new System.Drawing.Size(247, 357);
      this.gridCollection.TabIndex = 8;
      this.gridCollection.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewCollection});
      this.gridCollection.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gridCollection_MouseDoubleClick);
      // 
      // baseNamedItemBindingSource
      // 
      this.baseNamedItemBindingSource.DataSource = typeof(Finances.BaseNamedItem);
      // 
      // gridViewCollection
      // 
      this.gridViewCollection.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colName});
      this.gridViewCollection.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
      this.gridViewCollection.GridControl = this.gridCollection;
      this.gridViewCollection.Name = "gridViewCollection";
      this.gridViewCollection.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
      this.gridViewCollection.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
      this.gridViewCollection.OptionsBehavior.Editable = false;
      this.gridViewCollection.OptionsBehavior.ReadOnly = true;
      this.gridViewCollection.OptionsDetail.EnableMasterViewMode = false;
      this.gridViewCollection.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.gridViewCollection.OptionsSelection.MultiSelect = true;
      this.gridViewCollection.OptionsView.ShowColumnHeaders = false;
      this.gridViewCollection.OptionsView.ShowGroupPanel = false;
      this.gridViewCollection.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.False;
      this.gridViewCollection.OptionsView.ShowIndicator = false;
      // 
      // colName
      // 
      this.colName.FieldName = "Name";
      this.colName.Name = "colName";
      this.colName.Visible = true;
      this.colName.VisibleIndex = 0;
      // 
      // pnlEditor
      // 
      this.pnlEditor.Appearance.BackColor = System.Drawing.SystemColors.Window;
      this.pnlEditor.Appearance.Options.UseBackColor = true;
      this.pnlEditor.Location = new System.Drawing.Point(294, 32);
      this.pnlEditor.Name = "pnlEditor";
      this.pnlEditor.Size = new System.Drawing.Size(348, 383);
      this.pnlEditor.TabIndex = 7;
      // 
      // btnRemove
      // 
      this.btnRemove.Location = new System.Drawing.Point(94, 393);
      this.btnRemove.Name = "btnRemove";
      this.btnRemove.Size = new System.Drawing.Size(76, 22);
      this.btnRemove.StyleController = this.layoutControl1;
      this.btnRemove.TabIndex = 6;
      this.btnRemove.Text = "Remove";
      this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
      // 
      // btnAdd
      // 
      this.btnAdd.Location = new System.Drawing.Point(14, 393);
      this.btnAdd.Name = "btnAdd";
      this.btnAdd.Size = new System.Drawing.Size(76, 22);
      this.btnAdd.StyleController = this.layoutControl1;
      this.btnAdd.TabIndex = 5;
      this.btnAdd.Text = "Add";
      this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
      // 
      // layoutControlGroup1
      // 
      this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
      this.layoutControlGroup1.GroupBordersVisible = false;
      this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2,
            this.layoutControlGroup3,
            this.splitterItem1});
      this.layoutControlGroup1.Name = "Root";
      this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
      this.layoutControlGroup1.Size = new System.Drawing.Size(656, 429);
      this.layoutControlGroup1.TextVisible = false;
      // 
      // layoutControlGroup2
      // 
      this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem1,
            this.layoutControlItem5});
      this.layoutControlGroup2.LayoutMode = DevExpress.XtraLayout.Utils.LayoutMode.Table;
      this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
      this.layoutControlGroup2.Name = "layoutControlGroup2";
      columnDefinition1.SizeType = System.Windows.Forms.SizeType.Absolute;
      columnDefinition1.Width = 80D;
      columnDefinition2.SizeType = System.Windows.Forms.SizeType.Absolute;
      columnDefinition2.Width = 80D;
      columnDefinition3.SizeType = System.Windows.Forms.SizeType.Percent;
      columnDefinition3.Width = 100D;
      columnDefinition4.SizeType = System.Windows.Forms.SizeType.Absolute;
      columnDefinition4.Width = 80D;
      this.layoutControlGroup2.OptionsTableLayoutGroup.ColumnDefinitions.AddRange(new DevExpress.XtraLayout.ColumnDefinition[] {
            columnDefinition1,
            columnDefinition2,
            columnDefinition3,
            columnDefinition4});
      rowDefinition1.Height = 100D;
      rowDefinition1.SizeType = System.Windows.Forms.SizeType.Percent;
      rowDefinition2.Height = 26D;
      rowDefinition2.SizeType = System.Windows.Forms.SizeType.AutoSize;
      this.layoutControlGroup2.OptionsTableLayoutGroup.RowDefinitions.AddRange(new DevExpress.XtraLayout.RowDefinition[] {
            rowDefinition1,
            rowDefinition2});
      this.layoutControlGroup2.Size = new System.Drawing.Size(275, 429);
      this.layoutControlGroup2.Text = "Collection";
      // 
      // layoutControlItem2
      // 
      this.layoutControlItem2.Control = this.btnAdd;
      this.layoutControlItem2.Location = new System.Drawing.Point(0, 361);
      this.layoutControlItem2.Name = "layoutControlItem2";
      this.layoutControlItem2.OptionsTableLayoutItem.RowIndex = 1;
      this.layoutControlItem2.Size = new System.Drawing.Size(80, 26);
      this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
      this.layoutControlItem2.TextVisible = false;
      // 
      // layoutControlItem3
      // 
      this.layoutControlItem3.Control = this.btnRemove;
      this.layoutControlItem3.Location = new System.Drawing.Point(80, 361);
      this.layoutControlItem3.Name = "layoutControlItem3";
      this.layoutControlItem3.OptionsTableLayoutItem.ColumnIndex = 1;
      this.layoutControlItem3.OptionsTableLayoutItem.RowIndex = 1;
      this.layoutControlItem3.Size = new System.Drawing.Size(80, 26);
      this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
      this.layoutControlItem3.TextVisible = false;
      // 
      // layoutControlItem1
      // 
      this.layoutControlItem1.Control = this.gridCollection;
      this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
      this.layoutControlItem1.Name = "layoutControlItem1";
      this.layoutControlItem1.OptionsTableLayoutItem.ColumnSpan = 4;
      this.layoutControlItem1.Size = new System.Drawing.Size(251, 361);
      this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
      this.layoutControlItem1.TextVisible = false;
      // 
      // layoutControlGroup3
      // 
      this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem4});
      this.layoutControlGroup3.Location = new System.Drawing.Point(280, 0);
      this.layoutControlGroup3.Name = "layoutControlGroup3";
      this.layoutControlGroup3.Size = new System.Drawing.Size(376, 429);
      this.layoutControlGroup3.Text = "Item";
      // 
      // layoutControlItem4
      // 
      this.layoutControlItem4.Control = this.pnlEditor;
      this.layoutControlItem4.Location = new System.Drawing.Point(0, 0);
      this.layoutControlItem4.Name = "layoutControlItem4";
      this.layoutControlItem4.Size = new System.Drawing.Size(352, 387);
      this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
      this.layoutControlItem4.TextVisible = false;
      // 
      // splitterItem1
      // 
      this.splitterItem1.AllowHotTrack = true;
      this.splitterItem1.Location = new System.Drawing.Point(275, 0);
      this.splitterItem1.Name = "splitterItem1";
      this.splitterItem1.Size = new System.Drawing.Size(5, 429);
      // 
      // btnCopy
      // 
      this.btnCopy.Location = new System.Drawing.Point(185, 393);
      this.btnCopy.Name = "btnCopy";
      this.btnCopy.Size = new System.Drawing.Size(76, 22);
      this.btnCopy.StyleController = this.layoutControl1;
      this.btnCopy.TabIndex = 9;
      this.btnCopy.Text = "Copy";
      this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
      // 
      // layoutControlItem5
      // 
      this.layoutControlItem5.Control = this.btnCopy;
      this.layoutControlItem5.Location = new System.Drawing.Point(171, 361);
      this.layoutControlItem5.Name = "layoutControlItem5";
      this.layoutControlItem5.OptionsTableLayoutItem.ColumnIndex = 3;
      this.layoutControlItem5.OptionsTableLayoutItem.RowIndex = 1;
      this.layoutControlItem5.Size = new System.Drawing.Size(80, 26);
      this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
      this.layoutControlItem5.TextVisible = false;
      // 
      // CollectionEdit
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.layoutControl1);
      this.Name = "CollectionEdit";
      this.Size = new System.Drawing.Size(656, 429);
      ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
      this.layoutControl1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.gridCollection)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.baseNamedItemBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridViewCollection)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pnlEditor)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.splitterItem1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private DevExpress.XtraLayout.LayoutControl layoutControl1;
    private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
    private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
    private DevExpress.XtraEditors.SimpleButton btnRemove;
    private DevExpress.XtraEditors.SimpleButton btnAdd;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
    private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
    private DevExpress.XtraLayout.SplitterItem splitterItem1;
    private DevExpress.XtraEditors.PanelControl pnlEditor;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
    private DevExpress.XtraGrid.GridControl gridCollection;
    private DevExpress.XtraGrid.Views.Grid.GridView gridViewCollection;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
    private System.Windows.Forms.BindingSource baseNamedItemBindingSource;
    private DevExpress.XtraGrid.Columns.GridColumn colName;
    private DevExpress.XtraEditors.SimpleButton btnCopy;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
  }
}
