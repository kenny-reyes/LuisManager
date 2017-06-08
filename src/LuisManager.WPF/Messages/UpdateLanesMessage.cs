using LuisManager.Domain.Enums;
using LuisManager.WPF.ViewModels.Models;

namespace LuisManager.WPF.Messages
{
    public class UpdateLanesMessage
    {
        public UpdateLanesMessage(ItemViewModel item, DevelopmentStatus previousStatus)
        {
            Item = item;
            PreviousStatus = previousStatus;
        }

        public ItemViewModel Item { get; }

        public DevelopmentStatus PreviousStatus { get; }
    }
}
