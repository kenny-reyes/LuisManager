

using LuisManager.WPF.ViewModels.Models;

namespace LuisManager.WPF.Messages
{
    public class EditItemMessage
    {
        public EditItemMessage(ItemViewModel item)
        {
            Item = item;
        }

        public ItemViewModel Item { get; }
    }
}