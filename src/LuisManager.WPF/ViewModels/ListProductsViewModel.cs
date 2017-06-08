using Caliburn.Micro;
using LuisManager.Domain;
using LuisManager.WPF.ViewModels.Models;

namespace LuisManager.WPF.ViewModels
{
    public sealed class ListProductsViewModel : NotifyScreen
    {
        private readonly MainViewModel _mainViewModel;

        public ListProductsViewModel(MainViewModel mainViewModel, IEventAggregator eventAggregator)
        {
            _mainViewModel = mainViewModel;
            DisplayName = Localization.Resources.ListView_Tab;
        }

        public LuisScheme Data => _mainViewModel.Data;           

        public void SortProducts(object sortField, bool isSortAscending)
        {
            var field = sortField as string;
            if (string.IsNullOrEmpty(field)) return;

            //var view = CollectionViewSource.GetDefaultView(DevelopmentItems);

            //var sortDirection = isSortAscending ? ListSortDirection.Ascending : ListSortDirection.Descending;
            //view.SortDescriptions.Clear();
            //view.SortDescriptions.Add(new SortDescription(field, sortDirection));
        }

        public override void DoNotifyScreen()
        {
            NotifyOfPropertyChange(() => Data);
            base.DoNotifyScreen();
        }
    }
}
