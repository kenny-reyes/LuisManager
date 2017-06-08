using Caliburn.Micro;
using LuisManager.Domain;
using LuisManager.WPF.ViewModels.Models;

namespace LuisManager.WPF.ViewModels
{
    public sealed class KanbanViewModel : NotifyScreen
    {
        private readonly MainViewModel _mainViewModel;
        private readonly IEventAggregator _eventAggregator;

        public KanbanViewModel(MainViewModel mainViewModel, IEventAggregator eventAggregator)
        {
            _mainViewModel = mainViewModel;
            _eventAggregator = eventAggregator;
            DisplayName = Localization.Resources.GridView_Tab;
        }

        public LuisScheme Data => _mainViewModel.Data;

        public override void DoNotifyScreen()
        {
            NotifyOfPropertyChange(() => Data);
            base.DoNotifyScreen();
        }
    }
}
