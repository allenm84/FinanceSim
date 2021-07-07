using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Google.Cloud.Firestore;
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
      _gitDrive = new GitDrive(new Uri("https://github.com/allenm84/Storage.git"));

      NewProfileCommand = new DelegateCommand(DoNewProfile);
      CloneProfileCommand = new DelegateCommand(DoCloneProfile, IsProfileSelected);
      RemoveProfileCommand = new DelegateCommand(DoRemoveProfile, IsProfileSelected);
      ExportProfileCommand = new DelegateCommand(DoExportProfile, IsProfileSelected);
      RunProfileCommand = new DelegateCommand(DoRunProfile, IsProfileSelected);
      ViewScheduleCommand = new DelegateCommand(DoViewSchedule);
      ConvertCommand = new DelegateCommand(DoConvert);
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
    public DelegateCommand ViewScheduleCommand { get; }
    public DelegateCommand ConvertCommand { get; }

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

    private async void DoConvert()
    {
      const string projectId = "mapa-apps";
      var db = FirestoreDb.Create(projectId);
      foreach (var profile in Profiles.Select(p => p.GetModel()))
      {
        var item = new ConvertedProfile
        {
          Name = profile.Name,
          Created = profile.Created,
          Accounts = profile.Accounts,
          Bills = profile.Bills,
          Debts = profile.Debts,
          Paychecks = profile.Paychecks,
          Transactions = profile.Transactions,
          Events = profile.Events.All().ToList(),
          Setup = profile.Setup,
          Snowball = profile.Snowball
        };

        var json = JsonConvert.SerializeObject(item, new JsonSerializerSettings
        {
          TypeNameHandling = TypeNameHandling.Auto,
        });

        var password = Environment.GetEnvironmentVariable("STRING_CIPHER_KEY");
        var data = StringCipher.EncryptString(password, json);

        var docRef = db.Collection("financeSim").Document(item.Id);
        var docData = new Dictionary<string, object>
          {
            { "Name", profile.Name },
            { "Created", profile.Created.ToUniversalTime() },
            { "Data", data }
          };
        await docRef.SetAsync(docData, SetOptions.Overwrite);
      }
    }
  }

  public class ConvertedProfile
  {
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public string Name { get; set; }
    public DateTime Created { get; set; }
    public List<BankAccount> Accounts { get; set; }
    public List<Bill> Bills { get; set; }
    public List<Debt> Debts { get; set; }
    public List<Paycheck> Paychecks { get; set; }
    public List<Transaction> Transactions { get; set; }
    public List<BaseEvent> Events { get; set; }
    public SnowBallSetup Snowball { get; set; }
    public SimulationSetup Setup { get; set; }
  }
}
