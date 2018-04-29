namespace Finances
{
  partial class CollectionButtonEdit
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
      this.buttonEdit1 = new DevExpress.XtraEditors.ButtonEdit();
      ((System.ComponentModel.ISupportInitialize)(this.buttonEdit1.Properties)).BeginInit();
      this.SuspendLayout();
      // 
      // buttonEdit1
      // 
      this.buttonEdit1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.buttonEdit1.EditValue = "(Collection)";
      this.buttonEdit1.Location = new System.Drawing.Point(0, 0);
      this.buttonEdit1.Name = "buttonEdit1";
      this.buttonEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
      this.buttonEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
      this.buttonEdit1.Size = new System.Drawing.Size(390, 20);
      this.buttonEdit1.TabIndex = 0;
      this.buttonEdit1.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.buttonEdit1_ButtonClick);
      // 
      // CollectionButtonEdit
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.buttonEdit1);
      this.Name = "CollectionButtonEdit";
      this.Size = new System.Drawing.Size(390, 28);
      ((System.ComponentModel.ISupportInitialize)(this.buttonEdit1.Properties)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private DevExpress.XtraEditors.ButtonEdit buttonEdit1;
  }
}
