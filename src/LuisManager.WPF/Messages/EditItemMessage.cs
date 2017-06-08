

using LuisManager.WPF.ViewModels.Models;

namespace LuisManager.WPF.Messages
{
    public class EditItemMessage
    {
        public EditItemMessage(TreeItemViewModel treeItem)
        {
            TreeItem = treeItem;
        }

        public TreeItemViewModel TreeItem { get; }
    }
}