using System;

namespace FinanceSim
{
  public class DueInfoViewModel : BaseNotifyPropertyChanged
  {
    static DueInfo? _clipboard = null;
    static event EventHandler _canPasteChanged;

    private bool _hasEnd;
    private DateTime _end;
    private DateTime _start;
    private DueType _type;
    private int _period;
    private DateTime _seed;

    public DueInfoViewModel(DueInfo model) 
      : this()
    {
      Read(model);
    }

    public DueInfoViewModel()
    {
      CopyCommand = new DelegateCommand(DoCopy);
      PasteCommand = new DelegateCommand(DoPaste, CanPaste);

      _canPasteChanged += OnCanPasteChanged;
    }

    public DateTime Start
    {
      get => _start;
      set => SetField(ref _start, value);
    }

    public bool HasEnd
    {
      get => _hasEnd;
      set => SetField(ref _hasEnd, value);
    }

    public DateTime End
    {
      get => _end;
      set => SetField(ref _end, value);
    }

    public DueType Type
    {
      get => _type;
      set => SetField(ref _type, value);
    }

    public int Period
    {
      get => _period;
      set => SetField(ref _period, value);
    }

    public DateTime Seed
    {
      get => _seed;
      set => SetField(ref _seed, value);
    }

    public DelegateCommand CopyCommand { get; }
    public DelegateCommand PasteCommand { get; }

    private void Read(DueInfo model)
    {
      HasEnd = model.End.HasValue;
      End = model.End.GetValueOrDefault();
      Start = model.Start;
      Type = model.Type;
      Period = model.Period;
      Seed = model.Seed;
    }

    private void OnCanPasteChanged(object sender, EventArgs e)
    {
      PasteCommand.Refresh();
    }

    private void DoCopy()
    {
      _clipboard = GetModel();
      _canPasteChanged?.Invoke(this, EventArgs.Empty);
    }

    private bool CanPaste() => 
      _clipboard != null;

    private void DoPaste()
    {
      Read(_clipboard.Value);
    }

    public DueInfo GetModel()
    {
      var info = new DueInfo
      {
        End = null,
        Period = Period,
        Seed = Seed,
        Start = Start,
        Type = Type,
      };

      if (HasEnd)
      {
        info.End = End;
      }

      return info;
    }
  }
}
