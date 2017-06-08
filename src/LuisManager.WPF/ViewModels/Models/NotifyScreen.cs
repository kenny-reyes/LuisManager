using Caliburn.Micro;

namespace LuisManager.WPF.ViewModels.Models
{
    public class NotifyScreen : Screen
    {
        public virtual void DoNotifyScreen()
        {
            NotifyOfPropertyChange();
        }
    }
}
