using LuisManager.Domain.Enums;
using LuisManager.WPF.ViewModels.Models;

namespace LuisManager.WPF.Messages
{
    public class UpdateLanesMessage
    {
        public UpdateLanesMessage(TreeItemViewModel treeItem, DevelopmentStatus previousStatus)
        {
            TreeItem = treeItem;
            PreviousStatus = previousStatus;
        }

        public TreeItemViewModel TreeItem { get; }

        public DevelopmentStatus PreviousStatus { get; }
    }
}
