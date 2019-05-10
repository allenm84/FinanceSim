namespace FinanceSim
{
  partial class SetupSimulationDialog
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
      this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
      this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
      this.dtStart = new DevExpress.XtraEditors.DateEdit();
      this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
      this.dtEnd = new DevExpress.XtraEditors.DateEdit();
      this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
      this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
      this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
      this.btnOK = new DevExpress.XtraEditors.SimpleButton();
      this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
      this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
      this.layoutControl1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dtStart.Properties.CalendarTimeProperties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dtStart.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dtEnd.Properties.CalendarTimeProperties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dtEnd.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
      this.SuspendLayout();
      // 
      // layoutControl1
      // 
      this.layoutControl1.Controls.Add(this.btnOK);
      this.layoutControl1.Controls.Add(this.btnCancel);
      this.layoutControl1.Controls.Add(this.dtEnd);
      this.layoutControl1.Controls.Add(this.dtStart);
      this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.layoutControl1.Location = new System.Drawing.Point(0, 0);
      this.layoutControl1.Name = "layoutControl1";
      this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(691, 168, 650, 400);
      this.layoutControl1.Root = this.layoutControlGroup1;
      this.layoutControl1.Size = new System.Drawing.Size(256, 98);
      this.layoutControl1.TabIndex = 0;
      this.layoutControl1.Text = "layoutControl1";
      // 
      // layoutControlGroup1
      // 
      this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
      this.layoutControlGroup1.GroupBordersVisible = false;
      this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.emptySpaceItem2});
      this.layoutControlGroup1.Name = "Root";
      this.layoutControlGroup1.Size = new System.Drawing.Size(256, 98);
      this.layoutControlGroup1.TextVisible = false;
      // 
      // dtStart
      // 
      this.dtStart.EditValue = null;
      this.dtStart.Location = new System.Drawing.Point(44, 12);
      this.dtStart.Name = "dtStart";
      this.dtStart.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.dtStart.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.dtStart.Size = new System.Drawing.Size(200, 20);
      this.dtStart.StyleController = this.layoutControl1;
      this.dtStart.TabIndex = 4;
      // 
      // layoutControlItem1
      // 
      this.layoutControlItem1.Control = this.dtStart;
      this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
      this.layoutControlItem1.Name = "layoutControlItem1";
      this.layoutControlItem1.Size = new System.Drawing.Size(236, 24);
      this.layoutControlItem1.Text = "Start:";
      this.layoutControlItem1.TextSize = new System.Drawing.Size(28, 13);
      // 
      // dtEnd
      // 
      this.dtEnd.EditValue = null;
      this.dtEnd.Location = new System.Drawing.Point(44, 36);
      this.dtEnd.Name = "dtEnd";
      this.dtEnd.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.dtEnd.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.dtEnd.Size = new System.Drawing.Size(200, 20);
      this.dtEnd.StyleController = this.layoutControl1;
      this.dtEnd.TabIndex = 5;
      // 
      // layoutControlItem2
      // 
      this.layoutControlItem2.Control = this.dtEnd;
      this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
      this.layoutControlItem2.Name = "layoutControlItem2";
      this.layoutControlItem2.Size = new System.Drawing.Size(236, 24);
      this.layoutControlItem2.Text = "End:";
      this.layoutControlItem2.TextSize = new System.Drawing.Size(28, 13);
      // 
      // btnCancel
      // 
      this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnCancel.Location = new System.Drawing.Point(175, 60);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new System.Drawing.Size(69, 22);
      this.btnCancel.StyleController = this.layoutControl1;
      this.btnCancel.TabIndex = 6;
      this.btnCancel.Text = "Cancel";
      // 
      // layoutControlItem3
      // 
      this.layoutControlItem3.Control = this.btnCancel;
      this.layoutControlItem3.Location = new System.Drawing.Point(163, 48);
      this.layoutControlItem3.Name = "layoutControlItem3";
      this.layoutControlItem3.Size = new System.Drawing.Size(73, 30);
      this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
      this.layoutControlItem3.TextVisible = false;
      // 
      // btnOK
      // 
      this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.btnOK.Location = new System.Drawing.Point(103, 60);
      this.btnOK.Name = "btnOK";
      this.btnOK.Size = new System.Drawing.Size(68, 22);
      this.btnOK.StyleController = this.layoutControl1;
      this.btnOK.TabIndex = 7;
      this.btnOK.Text = "OK";
      // 
      // layoutControlItem4
      // 
      this.layoutControlItem4.Control = this.btnOK;
      this.layoutControlItem4.Location = new System.Drawing.Point(91, 48);
      this.layoutControlItem4.Name = "layoutControlItem4";
      this.layoutControlItem4.Size = new System.Drawing.Size(72, 30);
      this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
      this.layoutControlItem4.TextVisible = false;
      // 
      // emptySpaceItem2
      // 
      this.emptySpaceItem2.AllowHotTrack = false;
      this.emptySpaceItem2.Location = new System.Drawing.Point(0, 48);
      this.emptySpaceItem2.Name = "emptySpaceItem2";
      this.emptySpaceItem2.Size = new System.Drawing.Size(91, 30);
      this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
      // 
      // SetupSimulationDialog
      // 
      this.AcceptButton = this.btnOK;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.btnCancel;
      this.ClientSize = new System.Drawing.Size(256, 98);
      this.Controls.Add(this.layoutControl1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "SetupSimulationDialog";
      this.Text = "Setup Simulation";
      ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
      this.layoutControl1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dtStart.Properties.CalendarTimeProperties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dtStart.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dtEnd.Properties.CalendarTimeProperties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dtEnd.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private DevExpress.XtraLayout.LayoutControl layoutControl1;
    private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
    private DevExpress.XtraEditors.DateEdit dtStart;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
    private DevExpress.XtraEditors.DateEdit dtEnd;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
    private DevExpress.XtraEditors.SimpleButton btnOK;
    private DevExpress.XtraEditors.SimpleButton btnCancel;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
    private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
  }
}