using Caliburn.Micro;

namespace LuisManager.WPF.ViewModels
{
    public sealed class ListProductsViewModel : Screen
    {
        private readonly MainViewModel _mainViewModel;

        public ListProductsViewModel(MainViewModel mainViewModel, IEventAggregator eventAggregator)
        {
            _mainViewModel = mainViewModel;
            DisplayName = Localization.Resources.ListView_Tab;
        }

        //public ObservableCollection<ItemViewModel> DevelopmentItems => _mainViewModel.DevelopmentItems;           

        public void SortProducts(object sortField, bool isSortAscending)
        {
            var field = sortField as string;
            if (string.IsNullOrEmpty(field)) return;

            //var view = CollectionViewSource.GetDefaultView(DevelopmentItems);

            //var sortDirection = isSortAscending ? ListSortDirection.Ascending : ListSortDirection.Descending;
            //view.SortDescriptions.Clear();
            //view.SortDescriptions.Add(new SortDescription(field, sortDirection));
        }
    }
}
