namespace Finances
{
  partial class TransactionGridView
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
      this.gridControl1 = new DevExpress.XtraGrid.GridControl();
      this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
      this.transactionBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colDate = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colAmount = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colBalance = new DevExpress.XtraGrid.Columns.GridColumn();
      ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.transactionBindingSource)).BeginInit();
      this.SuspendLayout();
      // 
      // gridControl1
      // 
      this.gridControl1.DataSource = this.transactionBindingSource;
      this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.gridControl1.Location = new System.Drawing.Point(0, 0);
      this.gridControl1.MainView = this.gridView1;
      this.gridControl1.Name = "gridControl1";
      this.gridControl1.Size = new System.Drawing.Size(403, 203);
      this.gridControl1.TabIndex = 0;
      this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
      // 
      // gridView1
      // 
      this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colName,
            this.colDate,
            this.colAmount,
            this.colBalance});
      this.gridView1.GridControl = this.gridControl1;
      this.gridView1.Name = "gridView1";
      this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
      this.gridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
      this.gridView1.OptionsBehavior.Editable = false;
      this.gridView1.OptionsBehavior.ReadOnly = true;
      this.gridView1.OptionsView.ShowGroupPanel = false;
      // 
      // transactionBindingSource
      // 
      this.transactionBindingSource.DataSource = typeof(Finances.Transaction);
      // 
      // colName
      // 
      this.colName.FieldName = "Name";
      this.colName.Name = "colName";
      this.colName.Visible = true;
      this.colName.VisibleIndex = 0;
      // 
      // colDate
      // 
      this.colDate.FieldName = "Date";
      this.colDate.Name = "colDate";
      this.colDate.Visible = true;
      this.colDate.VisibleIndex = 1;
      // 
      // colAmount
      // 
      this.colAmount.DisplayFormat.FormatString = "c2";
      this.colAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
      this.colAmount.FieldName = "Amount";
      this.colAmount.Name = "colAmount";
      this.colAmount.Visible = true;
      this.colAmount.VisibleIndex = 2;
      // 
      // colBalance
      // 
      this.colBalance.DisplayFormat.FormatString = "c2";
      this.colBalance.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
      this.colBalance.FieldName = "Balance";
      this.colBalance.Name = "colBalance";
      this.colBalance.Visible = true;
      this.colBalance.VisibleIndex = 3;
      // 
      // TransactionGridView
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.gridControl1);
      this.Name = "TransactionGridView";
      this.Size = new System.Drawing.Size(403, 203);
      ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.transactionBindingSource)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private DevExpress.XtraGrid.GridControl gridControl1;
    private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    private System.Windows.Forms.BindingSource transactionBindingSource;
    private DevExpress.XtraGrid.Columns.GridColumn colName;
    private DevExpress.XtraGrid.Columns.GridColumn colDate;
    private DevExpress.XtraGrid.Columns.GridColumn colAmount;
    private DevExpress.XtraGrid.Columns.GridColumn colBalance;
  }
}
