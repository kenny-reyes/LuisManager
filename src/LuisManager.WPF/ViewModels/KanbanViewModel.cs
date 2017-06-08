using Caliburn.Micro;

namespace LuisManager.WPF.ViewModels
{
    public sealed class KanbanViewModel : Screen
    {
        private readonly MainViewModel _mainViewModel;
        private readonly IEventAggregator _eventAggregator;

        public KanbanViewModel(MainViewModel mainViewModel, IEventAggregator eventAggregator)
        {
            _mainViewModel = mainViewModel;
            _eventAggregator = eventAggregator;
            DisplayName = Localization.Resources.GridView_Tab;
        }

        public string hola {get;}
    }
}
