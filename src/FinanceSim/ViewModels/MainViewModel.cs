using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace FinanceSim
{
  public class MainViewModel : BaseNotifyPropertyChanged
  {
    private readonly List<string> _removedProfiles = new();
    private ProfileViewModel _selectedProfile;

    public MainViewModel()
    {
      NewProfileCommand = new DelegateCommand(DoNewProfile);
      CloneProfileCommand = new DelegateCommand(DoCloneProfile, IsProfileSelected);
      RemoveProfileCommand = new DelegateCommand(DoRemoveProfile, IsProfileSelected);
      ExportProfileCommand = new DelegateCommand(DoExportProfile, IsProfileSelected);
      RunProfileCommand = new DelegateCommand(DoRunProfile, IsProfileSelected);
      ViewScheduleCommand = new DelegateCommand(DoViewSchedule);
    }

    public ObservableCollectionEx<ProfileViewModel> Profiles { get; } = new();

    public ProfileViewModel SelectedProfile
    {
      get => _selectedProfile;
      set
      {
        SetField(ref _selectedProfile, value);
        RefreshCommands();
      }
    }

    public DelegateCommand NewProfileCommand { get; }
    public DelegateCommand CloneProfileCommand { get; }
    public DelegateCommand RemoveProfileCommand { get; }
    public DelegateCommand ExportProfileCommand { get; }
    public DelegateCommand RunProfileCommand { get; }
    public DelegateCommand ViewScheduleCommand { get; }

    public async Task LoadData()
    {
      var profiles = await FirestoreBackend.FetchAsync();
      Profiles.Set(profiles.Select(p => new ProfileViewModel(p)));
      SelectedProfile = Profiles.LastOrDefault();
    }

    public async Task SaveData()
    {
      var profiles = Profiles.Select(p => p.GetModel());
      await FirestoreBackend.PushAsync(profiles, _removedProfiles);
      _removedProfiles.Clear();
    }

    private Profile CreateProfileModel()
    {
      return new()
      {
        Id = Guid.NewGuid().ToString(),
        Created = DateTime.Now,
        Name = "<New Profile>",
      };
    }

    private void AddProfile(Profile model)
    {
      var profile = new ProfileViewModel(model);
      Profiles.Add(profile);
      SelectedProfile = profile;
    }

    private void RefreshCommands()
    {
      CloneProfileCommand.Refresh();
      RemoveProfileCommand.Refresh();
      ExportProfileCommand.Refresh();
      RunProfileCommand.Refresh();
    }

    private bool IsProfileSelected() =>
      SelectedProfile != null;

    private void DoNewProfile()
    {
      AddProfile(CreateProfileModel());
    }

    private void DoCloneProfile()
    {
      var model = SelectedProfile.GetModel().Clone();
      model.Name = $"Copy of {model.Name}";
      model.Created = DateTime.Now;
      model.Id = Guid.NewGuid().ToString();
      AddProfile(model);
    }

    private void DoRemoveProfile()
    {
      var index = Profiles.IndexOf(_selectedProfile);

      _removedProfiles.Add(_selectedProfile.Id);
      Profiles.RemoveAt(index);

      index = Math.Max(0, Math.Min(index, Profiles.Count - 1));
      SelectedProfile = Profiles[index];
    }

    private void DoExportProfile()
    {
      if (Messenger.PromptSaveFileAs("Export Profile", "JSON (*.json) | *.json", out var saveFilePath))
      {
        var model = SelectedProfile.GetModel();
        var json = JsonConvert.SerializeObject(model);
        File.WriteAllText(saveFilePath, json);
      }
    }

    private async void DoRunProfile()
    {
      var setup = SelectedProfile.Setup;
      if (Messenger.Popup("Simulation Setup", setup, modal: true))
      {
        var model = setup.GetModel();
        var profile = SelectedProfile.GetModel();
        var result = await Simulation.Run(model, profile);
        Messenger.Popup("Results", new SimulationResultsViewModel(result), modal: false);
      }
    }

    private async void DoViewSchedule()
    {
      var schedule = new ScheduleSetupViewModel();
      if (Messenger.Popup("Schedule Setup", schedule, modal: true))
      {
        var profile = SelectedProfile.GetModel();
        var start = schedule.Date.AddDays(-schedule.DaysBefore);
        var end = schedule.Date.AddDays(schedule.DaysAfter);
        var setup = new SimulationSetup { Start = start, End = end, UseSnowball = false };
        var result = await Simulation.Run(setup, profile);
        var items = result.Where(it => it.Key.Id != SimulationNoticeBoard.AccountId).SelectMany(it => it.Value);
        Messenger.Popup("Schedule", new ScheduleResultViewModel(items), modal: false);
      }
    }
  }
}