using System;
using System.Collections.Generic;
using System.Linq;

namespace FinanceSim
{
  public class EventSetupViewModel : CollectionEditorViewModel<BaseEventViewModel, BaseEvent>
  {
    static readonly BaseEventType[] sEventTypes = (BaseEventType[])Enum.GetValues(typeof(BaseEventType));

    public EventSetupViewModel(ProfileViewModel profile, EventSetup model)
      : base(profile, AllEvents(model))
    {
    }

    private static IEnumerable<BaseEvent> AllEvents(EventSetup model)
    {
      return EnumerableHelper.Iterate<BaseEvent>(
        model?.AdjustPaycheckTotalEvents,
        model?.AdjustSnowballAmountEvents,
        model?.ChangeBillPaymentEvents);
    }

    public EventSetup GetModel()
    {
      var items = GetModels().ToList();

      return new EventSetup
      {
        AdjustPaycheckTotalEvents = items.OfType<AdjustPaycheckTotalEvent>().ToList(),
        AdjustSnowballAmountEvents = items.OfType<AdjustSnowballAmountEvent>().ToList(),
        ChangeBillPaymentEvents = items.OfType<ChangeBillPaymentEvent>().ToList()
      };
    }

    protected override BaseEvent ToModel(BaseEventViewModel viewModel)
    {
      return viewModel.GetModel();
    }

    protected override BaseEventViewModel ToViewModel(BaseEvent model)
    {
      switch (model)
      {
        case AdjustPaycheckTotalEvent apte:
          {
            return new AdjustPaycheckTotalEventViewModel(Profile, apte);
          }
        case AdjustSnowballAmountEvent asae:
          {
            return new AdjustSnowballAmountEventViewModel(Profile, asae);
          }
        case ChangeBillPaymentEvent cbpe:
          {
            return new ChangePaymentEventViewModel(Profile, cbpe);
          }
        default:
          {
            throw new InvalidOperationException($"{model.GetType()} is not a known event");
          }
      }
    }

    protected override BaseEventViewModel NewViewModel()
    {
      if (Messenger.Pick("New Event", "Choose an event type", sEventTypes, out var choice))
      {
        switch (choice)
        {
          case BaseEventType.AdjustPaycheckTotal: return new AdjustPaycheckTotalEventViewModel(Profile);
          case BaseEventType.AdjustSnowballAmount: return new AdjustSnowballAmountEventViewModel(Profile);
          case BaseEventType.ChangePayment: return new ChangePaymentEventViewModel(Profile);
        }
      }
      return null;
    }
  }
}