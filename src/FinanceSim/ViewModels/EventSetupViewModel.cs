using System;
using System.Collections.Generic;

namespace FinanceSim
{
  public class EventSetupViewModel : CollectionEditorViewModel<BaseEventViewModel, BaseEvent>
  {
    private static readonly BaseEventType[] sEventTypes = (BaseEventType[])Enum.GetValues(typeof(BaseEventType));

    public EventSetupViewModel(ProfileViewModel profile, IEnumerable<BaseEvent> events)
      : base(profile, events)
    {
    }

    protected override BaseEvent ToModel(BaseEventViewModel viewModel)
      => viewModel.GetModel();

    protected override BaseEventViewModel ToViewModel(BaseEvent model) => model switch
    {
      AdjustPaycheckTotalEvent apte => new AdjustPaycheckTotalEventViewModel(Profile, apte),
      AdjustSnowballAmountEvent asae => new AdjustSnowballAmountEventViewModel(Profile, asae),
      ChangeBillPaymentEvent cbpe => new ChangePaymentEventViewModel(Profile, cbpe),
      _ => throw new InvalidOperationException($"{model.GetType()} is not a known event")
    };

    protected override BaseEventViewModel NewViewModel()
    {
      if (Messenger.Pick("New Event", "Choose an event type", sEventTypes, out var choice))
      {
        return choice switch
        {
          BaseEventType.AdjustPaycheckTotal => new AdjustPaycheckTotalEventViewModel(Profile),
          BaseEventType.AdjustSnowballAmount => new AdjustSnowballAmountEventViewModel(Profile),
          BaseEventType.ChangePayment => new ChangePaymentEventViewModel(Profile),
          _ => null,
        };
      }
      return null;
    }
  }
}