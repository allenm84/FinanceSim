namespace Finances
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
      this.ctrlProfiles = new Finances.CollectionEdit();
      this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
      this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
      this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
      this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
      this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
      this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
      this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
      this.bar1 = new DevExpress.XtraBars.Bar();
      this.btnSave = new DevExpress.XtraBars.BarButtonItem();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
      this.layoutControl1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
      this.SuspendLayout();
      // 
      // layoutControl1
      // 
      this.layoutControl1.Controls.Add(this.ctrlProfiles);
      this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.layoutControl1.Location = new System.Drawing.Point(0, 47);
      this.layoutControl1.Name = "layoutControl1";
      this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(997, 184, 650, 400);
      this.layoutControl1.Root = this.layoutControlGroup1;
      this.layoutControl1.Size = new System.Drawing.Size(711, 385);
      this.layoutControl1.TabIndex = 1;
      this.layoutControl1.Text = "layoutControl1";
      // 
      // ctrlProfiles
      // 
      this.ctrlProfiles.CollectionCaption = "Profiles";
      this.ctrlProfiles.Location = new System.Drawing.Point(10, 10);
      this.ctrlProfiles.Name = "ctrlProfiles";
      this.ctrlProfiles.Size = new System.Drawing.Size(691, 365);
      this.ctrlProfiles.TabIndex = 4;
      this.ctrlProfiles.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ctrlProfiles_MouseDoubleClick);
      // 
      // layoutControlGroup1
      // 
      this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
      this.layoutControlGroup1.GroupBordersVisible = false;
      this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
      this.layoutControlGroup1.Name = "Root";
      this.layoutControlGroup1.Size = new System.Drawing.Size(711, 385);
      this.layoutControlGroup1.TextVisible = false;
      // 
      // layoutControlItem1
      // 
      this.layoutControlItem1.Control = this.ctrlProfiles;
      this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
      this.layoutControlItem1.Name = "layoutControlItem1";
      this.layoutControlItem1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
      this.layoutControlItem1.Size = new System.Drawing.Size(691, 365);
      this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
      this.layoutControlItem1.TextVisible = false;
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
            this.btnSave});
      this.barManager1.MaxItemId = 1;
      // 
      // barDockControlTop
      // 
      this.barDockControlTop.CausesValidation = false;
      this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
      this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
      this.barDockControlTop.Manager = this.barManager1;
      this.barDockControlTop.Size = new System.Drawing.Size(711, 47);
      // 
      // barDockControlBottom
      // 
      this.barDockControlBottom.CausesValidation = false;
      this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.barDockControlBottom.Location = new System.Drawing.Point(0, 432);
      this.barDockControlBottom.Manager = this.barManager1;
      this.barDockControlBottom.Size = new System.Drawing.Size(711, 0);
      // 
      // barDockControlLeft
      // 
      this.barDockControlLeft.CausesValidation = false;
      this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
      this.barDockControlLeft.Location = new System.Drawing.Point(0, 47);
      this.barDockControlLeft.Manager = this.barManager1;
      this.barDockControlLeft.Size = new System.Drawing.Size(0, 385);
      // 
      // barDockControlRight
      // 
      this.barDockControlRight.CausesValidation = false;
      this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
      this.barDockControlRight.Location = new System.Drawing.Point(711, 47);
      this.barDockControlRight.Manager = this.barManager1;
      this.barDockControlRight.Size = new System.Drawing.Size(0, 385);
      // 
      // bar1
      // 
      this.bar1.BarName = "Tools";
      this.bar1.DockCol = 0;
      this.bar1.DockRow = 0;
      this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
      this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSave, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
      this.bar1.OptionsBar.AllowQuickCustomization = false;
      this.bar1.OptionsBar.DisableCustomization = true;
      this.bar1.OptionsBar.DrawBorder = false;
      this.bar1.OptionsBar.DrawDragBorder = false;
      this.bar1.OptionsBar.UseWholeRow = true;
      this.bar1.Text = "Tools";
      // 
      // btnSave
      // 
      this.btnSave.Caption = "Save";
      this.btnSave.Id = 0;
      this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
      this.btnSave.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S));
      this.btnSave.Name = "btnSave";
      this.btnSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSave_ItemClick);
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(711, 432);
      this.Controls.Add(this.layoutControl1);
      this.Controls.Add(this.barDockControlLeft);
      this.Controls.Add(this.barDockControlRight);
      this.Controls.Add(this.barDockControlBottom);
      this.Controls.Add(this.barDockControlTop);
      this.Name = "MainForm";
      this.Text = "Finances";
      ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
      this.layoutControl1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private DevExpress.XtraLayout.LayoutControl layoutControl1;
    private CollectionEdit ctrlProfiles;
    private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
    private DevExpress.XtraBars.BarManager barManager1;
    private DevExpress.XtraBars.Bar bar1;
    private DevExpress.XtraBars.BarButtonItem btnSave;
    private DevExpress.XtraBars.BarDockControl barDockControlTop;
    private DevExpress.XtraBars.BarDockControl barDockControlBottom;
    private DevExpress.XtraBars.BarDockControl barDockControlLeft;
    private DevExpress.XtraBars.BarDockControl barDockControlRight;
  }
}

