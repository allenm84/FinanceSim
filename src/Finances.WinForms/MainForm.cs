using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Finances
{
  public partial class MainForm : BaseForm
  {
    private readonly string mFilepath;

    private readonly DataContractSerializer mProfileListDcs = new DataContractSerializer(typeof(List<Profile>));
    private readonly DataContractSerializer mProfileDcs = new DataContractSerializer(typeof(Profile));
    private readonly List<Profile> mProfiles = new List<Profile>();

    public MainForm()
    {
      InitializeComponent();

      var dir = Path.Combine(DropboxPath.Data, "Finances");
      if (!Directory.Exists(dir))
      {
        Directory.CreateDirectory(dir);
      }
      mFilepath = Path.Combine(dir, "profiles.xml");

      ReadProfiles();
    }

    private void ReadProfiles()
    {
      if (File.Exists(mFilepath))
      {
        using (var stream = File.OpenRead(mFilepath))
        {
          var profiles = mProfileListDcs.ReadObject(stream) as IEnumerable<Profile>;
          foreach (var profile in profiles)
          {
            foreach (var cc in profile.CreditCards)
            {
              if (cc.Payments == null)
              {
                cc.Payments = new List<RecurringPayment>();
              }
            }
            AddProfile(profile);
          }
        }
      }
    }

    private void WriteProfiles()
    {
      using (var stream = File.Create(mFilepath))
      {
        mProfileListDcs.WriteObject(stream, mProfiles);
      }
    }

    private void AddProfile(Profile profile)
    {
      mProfiles.Add(profile);
      var node = new ProfileNode(profile);
      treeProfiles.Nodes.Add(node);
      treeProfiles.SelectedNode = node;
    }

    private Profile CloneProfile(Profile profile)
    {
      using (var stream = new MemoryStream())
      {
        mProfileDcs.WriteObject(stream, profile);
        stream.Position = 0;
        return mProfileDcs.ReadObject(stream) as Profile;
      }
    }

    protected override void OnFormClosing(FormClosingEventArgs e)
    {
      WriteProfiles();
      base.OnFormClosing(e);
    }

    private void treeProfiles_AfterSelect(object sender, TreeViewEventArgs e)
    {
      var node = e.Node as ProfileNode;
      propertyGridProfile.SelectedObject = node?.Profile;
    }

    private void contextProfiles_Opening(object sender, CancelEventArgs e)
    {
      bool isSelected = (treeProfiles.SelectedNode is ProfileNode);
      removeProfileToolStripMenuItem.Visible = isSelected;
      copyProfileToolStripMenuItem.Visible = isSelected;
      runProfileToolStripMenuItem.Visible = isSelected;
    }

    private void addProfileToolStripMenuItem_Click(object sender, EventArgs e)
    {
      var profile = new Profile();
      profile.Name = "<New Profile>";
      profile.Created = DateTime.Now;
      profile.StartDate = DateTime.Today;
      profile.StartingBalance = 0;
      profile.CreditCards = new List<CreditCard>();
      profile.Loans = new List<Loan>();
      profile.Paychecks = new List<Paycheck>();
      profile.RecurringPayments = new List<RecurringPayment>();
      AddProfile(profile);
    }

    private void removeProfileToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (treeProfiles.SelectedNode is ProfileNode profile)
      {
        var result = MessageBox.Show(this, "Are you sure you want to remove the current profile?", "Confirm",
        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (result == DialogResult.Yes)
        {
          // remove the node from the tree
          profile.Remove();

          // remove the profile from the list of profiles
          mProfiles.Remove(profile.Profile);
        }
      }
    }

    private void copyProfileToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (treeProfiles.SelectedNode is ProfileNode node)
      {
        var profile = node.Profile;

        var copy = CloneProfile(profile);
        copy.Name = $"Copy of {copy.Name}";
        copy.Created = DateTime.Now;

        AddProfile(copy);
      }
    }

    private void runProfileToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (treeProfiles.SelectedNode is ProfileNode node)
      {
        var profile = node.Profile;
        var copy = CloneProfile(profile);
        new ProfileRunnerDialog(copy).Show(this);
      }
    }

    private void propertyGridProfile_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
    {
      if (e.ChangedItem.PropertyDescriptor.Name == nameof(Profile.Name))
      {
        if (treeProfiles.SelectedNode is ProfileNode profile)
        {
          profile.Text = e.ChangedItem.Value as string;
        }
      }
    }
  }
}
