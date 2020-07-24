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
    private const string FileName = "profiles.json";

    private readonly GitDrive _gitDrive;
    private ProfileViewModel _selectedProfile;

    public MainViewModel()
    {
      _gitDrive = new GitDrive(new Uri("https://allenm84@bitbucket.org/allenm84/storage.git"));

      NewProfileCommand = new DelegateCommand(DoNewProfile);
      CloneProfileCommand = new DelegateCommand(DoCloneProfile, IsProfileSelected);
      RemoveProfileCommand = new DelegateCommand(DoRemoveProfile, IsProfileSelected);
      ExportProfileCommand = new DelegateCommand(DoExportProfile, IsProfileSelected);
      RunProfileCommand = new DelegateCommand(DoRunProfile, IsProfileSelected);
    }

    public ObservableCollectionEx<ProfileViewModel> Profiles { get; } = new ObservableCollectionEx<ProfileViewModel>();

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

    public async Task LoadData()
    {
      if (await _gitDrive.Initialize() && _gitDrive.FileExists(FileName))
      {
        var jsonText = _gitDrive.ReadAllText(FileName);
        var profiles = JsonConvert.DeserializeObject<List<Profile>>(jsonText);
        Profiles.Set(profiles.Select(p => new ProfileViewModel(p)));
        SelectedProfile = Profiles.LastOrDefault();
      }
    }

    public async Task SaveData()
    {
      var profiles = Profiles.Select(p => p.GetModel()).ToList();
      var jsonText = JsonConvert.SerializeObject(profiles);
      await Task.Run(() => _gitDrive.WriteAllText(FileName, jsonText));
    }

    private Profile CreateProfileModel()
    {
      return new Profile
      {
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
      model.Created = DateTime.Today;
      AddProfile(model);
    }

    private void DoRemoveProfile()
    {
      Profiles.Remove(SelectedProfile);
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
      var model = new SimulationSetup();
      if (Messenger.Popup("Simulation Setup", model, modal: true))
      {
        var profile = SelectedProfile.GetModel();
        var result = await Simulation.Run(model, profile);
        Messenger.Popup("Results", new SimulationResultsViewModel(result), modal: false);
      }
    }
  }
}
