using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Newtonsoft.Json;

namespace FinanceSim
{
  public partial class MainForm : BaseForm
  {
    private readonly string _filepath;
    private Profile _currentProfile;

    public MainForm()
    {
      _filepath = "profiles.json";

      InitializeComponent();
      LoadProfile(null);

      LoadData();
    }

    private void LoadData()
    {
      if (File.Exists(_filepath))
      {
        var jsonText = File.ReadAllText(_filepath);
        var profiles = JsonConvert.DeserializeObject<List<Profile>>(jsonText);
        foreach (var profile in profiles)
        {
          profileBindingSource.Add(profile);
        }
      }
    }

    private void SetIsProfileEditable(bool isEditable)
    {
      var grids = new[] { gridAccounts, gridBills, gridDebts, gridPaychecks };
      Array.ForEach(grids, grid => grid.Enabled = isEditable);
      txtProfileName.Enabled = isEditable;
    }

    private void UpdateProfileGroup()
    {
      lcgProfile.Text = $"{_currentProfile.Name} Data";
    }

    private void PushChanges()
    {
      _currentProfile.Accounts = bankAccountBindingSource.OfType<BankAccount>().ToList();
      _currentProfile.Bills = billBindingSource.OfType<Bill>().ToList();
      _currentProfile.Debts = debtBindingSource.OfType<Debt>().ToList();
      _currentProfile.Paychecks = paycheckBindingSource.OfType<Paycheck>().ToList();
    }

    private void LoadProfile(Profile profile)
    {
      if (_currentProfile != null)
      {
        _currentProfile.PropertyChanged -= currentProfile_PropertyChanged;
        PushChanges();
      }

      txtProfileName.DataBindings.Clear();

      using (accountItemBindingSource.DeferListChangedEvents())
      {
        bankAccountBindingSource.Clear();
        billBindingSource.Clear();
        debtBindingSource.Clear();
        paycheckBindingSource.Clear();
      }

      _currentProfile = profile;
      SetIsProfileEditable(profile != null);

      bankAccountBindingSource.ListChanged -= bankAccountBindingSource_ListChanged;
      debtBindingSource.ListChanged -= bankAccountBindingSource_ListChanged;

      if (profile == null)
      {
        lcgProfile.Text = cboProfiles.Properties.NullText;
      }
      else
      {
        UpdateProfileGroup();
        _currentProfile.PropertyChanged += currentProfile_PropertyChanged;

        // bind the name
        txtProfileName.DataBindings.Add(nameof(TextEdit.Text), profile, nameof(Profile.Name));

        // add all of the accounts
        foreach (var item in profile.OfType<IAccount>())
        {
          accountItemBindingSource.Add(new AccountItem(item));
        }

        // populate the other lists
        foreach (var a in profile.Accounts)
          bankAccountBindingSource.Add(a);
        foreach (var b in profile.Bills)
          billBindingSource.Add(b);
        foreach (var d in profile.Debts)
          debtBindingSource.Add(d);
        foreach (var p in profile.Paychecks)
          paycheckBindingSource.Add(p);

        // list for changes to the accounts
        bankAccountBindingSource.ListChanged += bankAccountBindingSource_ListChanged;
        debtBindingSource.ListChanged += bankAccountBindingSource_ListChanged;
      }
    }

    private async void SelectProfile(Profile profile)
    {
      await Task.Yield();
      cboProfiles.EditValue = profile;
    }

    private void AddNewProfile(Profile profile)
    {
      profileBindingSource.Add(profile);
      SelectProfile(profile);
    }

    private void UpdateAccountItems()
    {
      var accounts = bankAccountBindingSource.OfType<IAccount>().Concat(debtBindingSource.OfType<IAccount>());
      var desired = new HashSet<IAccount>(accounts, IHasIdComparer<IAccount>.Instance);

      // remove the ones that are no longer valid
      for (int i = accountItemBindingSource.Count - 1; i > -1; --i)
      {
        if (accountItemBindingSource[i] is AccountItem item && !desired.Remove(item.Value))
        {
          item.Release();
          accountItemBindingSource.RemoveAt(i);
        }
      }

      // desired now only contains the new items, so add item
      foreach (var value in desired)
      {
        accountItemBindingSource.Add(new AccountItem(value));
      }
    }

    private void RefreshAccountColumns()
    {
      gridViewBills.RefreshData();
      gridViewDebts.RefreshData();
      gridViewPaychecks.RefreshData();
    }

    private void bankAccountBindingSource_ListChanged(object sender, ListChangedEventArgs e)
    {
      if (e.ListChangedType == ListChangedType.ItemAdded ||
        e.ListChangedType == ListChangedType.ItemDeleted ||
        e.ListChangedType == ListChangedType.Reset)
      {
        UpdateAccountItems();
      }
      else
      {
        RefreshAccountColumns();
      }
    }

    private void currentProfile_PropertyChanged(object sender, PropertyChangedEventArgs e)
    {
      UpdateProfileGroup();
    }

    private void tbbSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
    {
      if (_currentProfile != null)
      {
        PushChanges();

        var profiles = profileBindingSource.OfType<Profile>().ToList();
        var jsonText = JsonConvert.SerializeObject(profiles);
        File.WriteAllText(_filepath, jsonText);
      }
    }

    private void tbbNewProfile_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
    {
      AddNewProfile(new Profile
      {
        Created = DateTime.Now,
        Name = "<New Profile>",
      });
    }

    private void tbbCloneProfile_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
    {
      if (_currentProfile != null)
      {
        var data = JsonConvert.SerializeObject(_currentProfile);
        var cloned = JsonConvert.DeserializeObject<Profile>(data);
        cloned.Created = DateTime.Now;
        cloned.Name = $"Clone of {_currentProfile.Name}";
        AddNewProfile(cloned);
      }
    }

    private void tbbRemoveProfile_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
    {
      if (_currentProfile != null && this.Confirm($"Are you sure you want to remove {_currentProfile.Name}?"))
      {
        profileBindingSource.Remove(_currentProfile);
      }
    }

    private async void tbbRun_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
    {
      if (_currentProfile != null)
      {
        using (var dlg = new SetupSimulationDialog())
        {
          if (dlg.ShowDialog(this) == DialogResult.OK)
          {
            PushChanges();
            var result = await Simulation.Run(dlg.Start, dlg.End, _currentProfile);
            var popup = new SimulationResultDialog();
            popup.Populate(result);
            popup.Show(this);
          }
        }
      }
    }

    private void cboProfiles_EditValueChanged(object sender, EventArgs e)
    {
      var profile = cboProfiles.EditValue as Profile;
      LoadProfile(profile);
    }

    private void gridViewPaychecks_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
    {
      if (e.Column == colPaycheckDeposits && e.Row is Paycheck paycheck)
      {
        e.Value = $"{paycheck.Deposits.Sum(p => p.Amount):c2}";
      }
    }

    private void btnEditPaycheckDeposits_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
    {
      if (gridViewPaychecks.GetFocusedRow() is Paycheck paycheck)
      {
        using (var dlg = new EditPaycheckDepositsDialog())
        {
          dlg.ColumnEdit = cboAccounts;
          dlg.Deposits = paycheck.Deposits;
          if (dlg.ShowDialog(this) == DialogResult.OK)
          {
            paycheck.Deposits = dlg.Deposits.ToList();
            gridViewPaychecks.CloseEditor();
            gridViewPaychecks.RefreshData();
          }
        }
      }
    }

    private void btnEditDueInfo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
    {
      if (sender is ButtonEdit editor && editor.EditValue is DueInfo info)
      {
        using (var dlg = new EditDueInfoDialog())
        {
          dlg.Value = info;
          if (dlg.ShowDialog(this) == DialogResult.OK)
          {
            editor.EditValue = dlg.Value;
          }
        }
      }
    }

    private void gridAccounts_ProcessGridKey(object sender, KeyEventArgs e)
    {
      gridViewAccounts.ProcessDeleteKey(e, this);
    }

    private void gridPaychecks_ProcessGridKey(object sender, KeyEventArgs e)
    {
      gridViewPaychecks.ProcessDeleteKey(e, this);
    }

    private void gridBills_ProcessGridKey(object sender, KeyEventArgs e)
    {
      gridViewBills.ProcessDeleteKey(e, this);
    }

    private void gridDebts_ProcessGridKey(object sender, KeyEventArgs e)
    {
      gridViewDebts.ProcessDeleteKey(e, this);
    }
  }
}
