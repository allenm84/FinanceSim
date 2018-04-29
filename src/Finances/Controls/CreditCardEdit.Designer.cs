namespace Finances
{
  partial class CreditCardEdit
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
      this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
      this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
      this.ctrlLoanEdit = new Finances.LoanEdit();
      this.ctrlPayments = new Finances.CollectionButtonEdit();
      this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
      this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
      this.layoutControl1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
      this.SuspendLayout();
      // 
      // layoutControl1
      // 
      this.layoutControl1.Controls.Add(this.ctrlLoanEdit);
      this.layoutControl1.Controls.Add(this.ctrlPayments);
      this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.layoutControl1.Location = new System.Drawing.Point(0, 0);
      this.layoutControl1.Name = "layoutControl1";
      this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(667, 187, 650, 400);
      this.layoutControl1.Root = this.layoutControlGroup1;
      this.layoutControl1.Size = new System.Drawing.Size(306, 290);
      this.layoutControl1.TabIndex = 0;
      this.layoutControl1.Text = "layoutControl1";
      // 
      // layoutControlGroup1
      // 
      this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
      this.layoutControlGroup1.GroupBordersVisible = false;
      this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.emptySpaceItem1,
            this.layoutControlItem1,
            this.layoutControlItem7});
      this.layoutControlGroup1.Name = "Root";
      this.layoutControlGroup1.Size = new System.Drawing.Size(306, 290);
      this.layoutControlGroup1.TextVisible = false;
      // 
      // emptySpaceItem1
      // 
      this.emptySpaceItem1.AllowHotTrack = false;
      this.emptySpaceItem1.Location = new System.Drawing.Point(0, 269);
      this.emptySpaceItem1.MinSize = new System.Drawing.Size(10, 1);
      this.emptySpaceItem1.Name = "emptySpaceItem1";
      this.emptySpaceItem1.Size = new System.Drawing.Size(286, 1);
      this.emptySpaceItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
      this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
      // 
      // ctrlLoanEdit
      // 
      this.ctrlLoanEdit.GroupPadding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
      this.ctrlLoanEdit.Location = new System.Drawing.Point(10, 10);
      this.ctrlLoanEdit.Name = "ctrlLoanEdit";
      this.ctrlLoanEdit.Size = new System.Drawing.Size(286, 245);
      this.ctrlLoanEdit.TabIndex = 11;
      this.ctrlLoanEdit.TextSize = new System.Drawing.Size(57, 13);
      // 
      // ctrlPayments
      // 
      this.ctrlPayments.Location = new System.Drawing.Point(72, 257);
      this.ctrlPayments.Name = "ctrlPayments";
      this.ctrlPayments.Size = new System.Drawing.Size(222, 20);
      this.ctrlPayments.TabIndex = 10;
      // 
      // layoutControlItem1
      // 
      this.layoutControlItem1.Control = this.ctrlLoanEdit;
      this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
      this.layoutControlItem1.MaxSize = new System.Drawing.Size(0, 245);
      this.layoutControlItem1.MinSize = new System.Drawing.Size(136, 245);
      this.layoutControlItem1.Name = "layoutControlItem1";
      this.layoutControlItem1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
      this.layoutControlItem1.Size = new System.Drawing.Size(286, 245);
      this.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
      this.layoutControlItem1.Text = "Loan";
      this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
      this.layoutControlItem1.TextVisible = false;
      // 
      // layoutControlItem7
      // 
      this.layoutControlItem7.AppearanceItemCaption.FontStyleDelta = System.Drawing.FontStyle.Bold;
      this.layoutControlItem7.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem7.Control = this.ctrlPayments;
      this.layoutControlItem7.Location = new System.Drawing.Point(0, 245);
      this.layoutControlItem7.Name = "layoutControlItem7";
      this.layoutControlItem7.Size = new System.Drawing.Size(286, 24);
      this.layoutControlItem7.Text = "Payments";
      this.layoutControlItem7.TextSize = new System.Drawing.Size(57, 13);
      // 
      // CreditCardEdit
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.layoutControl1);
      this.Name = "CreditCardEdit";
      this.Size = new System.Drawing.Size(306, 290);
      ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
      this.layoutControl1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private DevExpress.XtraLayout.LayoutControl layoutControl1;
    private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
    private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
    private CollectionButtonEdit ctrlPayments;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
    private LoanEdit ctrlLoanEdit;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
  }
}
