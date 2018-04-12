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
      this.splitContainer1 = new System.Windows.Forms.SplitContainer();
      this.treeProfiles = new System.Windows.Forms.VistaTreeView();
      this.contextProfiles = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.addProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.removeProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.copyProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.runProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.propertyGridProfile = new System.Windows.Forms.PropertyGrid();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
      this.splitContainer1.Panel1.SuspendLayout();
      this.splitContainer1.Panel2.SuspendLayout();
      this.splitContainer1.SuspendLayout();
      this.contextProfiles.SuspendLayout();
      this.SuspendLayout();
      // 
      // splitContainer1
      // 
      this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.splitContainer1.Location = new System.Drawing.Point(10, 10);
      this.splitContainer1.Name = "splitContainer1";
      // 
      // splitContainer1.Panel1
      // 
      this.splitContainer1.Panel1.Controls.Add(this.treeProfiles);
      this.splitContainer1.Panel1.Controls.Add(this.label1);
      // 
      // splitContainer1.Panel2
      // 
      this.splitContainer1.Panel2.Controls.Add(this.propertyGridProfile);
      this.splitContainer1.Panel2.Controls.Add(this.label2);
      this.splitContainer1.Size = new System.Drawing.Size(511, 462);
      this.splitContainer1.SplitterDistance = 156;
      this.splitContainer1.TabIndex = 0;
      // 
      // treeProfiles
      // 
      this.treeProfiles.ContextMenuStrip = this.contextProfiles;
      this.treeProfiles.Dock = System.Windows.Forms.DockStyle.Fill;
      this.treeProfiles.FullRowSelect = true;
      this.treeProfiles.HideSelection = false;
      this.treeProfiles.Location = new System.Drawing.Point(0, 13);
      this.treeProfiles.Name = "treeProfiles";
      this.treeProfiles.ShowLines = false;
      this.treeProfiles.ShowPlusMinus = false;
      this.treeProfiles.ShowRootLines = false;
      this.treeProfiles.Size = new System.Drawing.Size(156, 449);
      this.treeProfiles.TabIndex = 0;
      this.treeProfiles.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeProfiles_AfterSelect);
      // 
      // contextProfiles
      // 
      this.contextProfiles.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addProfileToolStripMenuItem,
            this.removeProfileToolStripMenuItem,
            this.copyProfileToolStripMenuItem,
            this.runProfileToolStripMenuItem});
      this.contextProfiles.Name = "contextProfiles";
      this.contextProfiles.Size = new System.Drawing.Size(155, 92);
      this.contextProfiles.Opening += new System.ComponentModel.CancelEventHandler(this.contextProfiles_Opening);
      // 
      // addProfileToolStripMenuItem
      // 
      this.addProfileToolStripMenuItem.Name = "addProfileToolStripMenuItem";
      this.addProfileToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
      this.addProfileToolStripMenuItem.Text = "Add Profile";
      this.addProfileToolStripMenuItem.Click += new System.EventHandler(this.addProfileToolStripMenuItem_Click);
      // 
      // removeProfileToolStripMenuItem
      // 
      this.removeProfileToolStripMenuItem.Name = "removeProfileToolStripMenuItem";
      this.removeProfileToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
      this.removeProfileToolStripMenuItem.Text = "Remove Profile";
      this.removeProfileToolStripMenuItem.Click += new System.EventHandler(this.removeProfileToolStripMenuItem_Click);
      // 
      // copyProfileToolStripMenuItem
      // 
      this.copyProfileToolStripMenuItem.Name = "copyProfileToolStripMenuItem";
      this.copyProfileToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
      this.copyProfileToolStripMenuItem.Text = "Copy Profile";
      this.copyProfileToolStripMenuItem.Click += new System.EventHandler(this.copyProfileToolStripMenuItem_Click);
      // 
      // runProfileToolStripMenuItem
      // 
      this.runProfileToolStripMenuItem.Name = "runProfileToolStripMenuItem";
      this.runProfileToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
      this.runProfileToolStripMenuItem.Text = "Run Profile";
      this.runProfileToolStripMenuItem.Click += new System.EventHandler(this.runProfileToolStripMenuItem_Click);
      // 
      // propertyGridProfile
      // 
      this.propertyGridProfile.Dock = System.Windows.Forms.DockStyle.Fill;
      this.propertyGridProfile.Location = new System.Drawing.Point(0, 13);
      this.propertyGridProfile.Name = "propertyGridProfile";
      this.propertyGridProfile.Size = new System.Drawing.Size(351, 449);
      this.propertyGridProfile.TabIndex = 0;
      this.propertyGridProfile.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.propertyGridProfile_PropertyValueChanged);
      // 
      // label1
      // 
      this.label1.Dock = System.Windows.Forms.DockStyle.Top;
      this.label1.Location = new System.Drawing.Point(0, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(156, 13);
      this.label1.TabIndex = 1;
      this.label1.Text = "Profiles:";
      // 
      // label2
      // 
      this.label2.Dock = System.Windows.Forms.DockStyle.Top;
      this.label2.Location = new System.Drawing.Point(0, 0);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(351, 13);
      this.label2.TabIndex = 1;
      this.label2.Text = "Selected Profile:";
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(531, 482);
      this.Controls.Add(this.splitContainer1);
      this.Name = "MainForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Finances";
      this.splitContainer1.Panel1.ResumeLayout(false);
      this.splitContainer1.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
      this.splitContainer1.ResumeLayout(false);
      this.contextProfiles.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.SplitContainer splitContainer1;
    private System.Windows.Forms.VistaTreeView treeProfiles;
    private System.Windows.Forms.ContextMenuStrip contextProfiles;
    private System.Windows.Forms.ToolStripMenuItem addProfileToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem removeProfileToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem runProfileToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem copyProfileToolStripMenuItem;
    private System.Windows.Forms.PropertyGrid propertyGridProfile;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
  }
}

