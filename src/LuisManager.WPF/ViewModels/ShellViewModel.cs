using System.Collections.Generic;
using Caliburn.Micro;
using LuisManager.WPF.Messages;

namespace LuisManager.WPF.ViewModels
{
    public class ShellViewModel : Conductor<Screen>, IHandle<EditItemMessage>, IHandle<UpdateLanesMessage>, IHandle<OpenAboutMessage>
    { 
        private readonly MainViewModel _mainViewModel;
        private readonly ListProductsViewModel _listProductsViewModel;
        private readonly KanbanViewModel _kanbanViewModel;
        private readonly EditItemViewModel _editItemViewModel;
        private readonly AboutViewModel _aboutViewModel;
        private readonly IEventAggregator _eventAggregator;
        private readonly IWindowManager _windowManager;

        public ShellViewModel(MainViewModel mainViewModel, ListProductsViewModel listProductsViewModel, KanbanViewModel kanbanViewModel, 
            EditItemViewModel editItemViewModel, AboutViewModel aboutViewModel,
            IEventAggregator eventAggregator, IWindowManager windowManager)
        {
            _mainViewModel = mainViewModel;
            _listProductsViewModel = listProductsViewModel;
            _kanbanViewModel = kanbanViewModel;
            _editItemViewModel = editItemViewModel;
            _aboutViewModel = aboutViewModel;
            _eventAggregator = eventAggregator;
            _windowManager = windowManager;
        }

        protected override void OnViewAttached(object view, object context)
        {
            DisplayName = Localization.Resources.Title_Shell;
            _eventAggregator.Subscribe(this);
            _mainViewModel.ScreenList = new List<Screen>{ _listProductsViewModel, _kanbanViewModel}; 
            ActivateItem(_mainViewModel);
            base.OnViewAttached(view, context);
        }

        protected override void OnDeactivate(bool close)
        {
            _eventAggregator.Unsubscribe(this);
            base.OnDeactivate(close);
        }

        public void Handle(EditItemMessage message)
        {
            _editItemViewModel.Item = message.Item;
            _windowManager.ShowDialog(_editItemViewModel);
        }

        public void Handle(UpdateLanesMessage message)
        {
            _mainViewModel.Save();
        }

        public void Handle(OpenAboutMessage message)
        {
            _windowManager.ShowDialog(_aboutViewModel);
        }
    }
}
