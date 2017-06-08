using Caliburn.Micro;
using LuisManager.Domain;
using LuisManager.WPF.Messages;

namespace LuisManager.WPF.ViewModels.Models
{
    public class ItemViewModel : PropertyChangedBase
    {
        private readonly LuisScheme _luisScheme;
        private readonly IEventAggregator _eventAggregator;

        public ItemViewModel(IEventAggregator eventAggregator)
        {
            _luisScheme = new LuisScheme();
            _eventAggregator = eventAggregator;
        }

        public ItemViewModel(LuisScheme luisScheme, IEventAggregator eventAggregator)
        {
            _luisScheme = luisScheme;
            _eventAggregator = eventAggregator;
        }

        public LuisScheme LuisScheme
        {
            get => _luisScheme;
        }

        //public string Id
        //{
        //    get => _luisScheme.Id;
        //    set
        //    {
        //        _luisScheme.Id = value;
        //        NotifyOfPropertyChange(() => Id);   
        //    }
        //}

        //public string Engineer
        //{
        //    get => _luisScheme.Engineer;
        //    set
        //    {
        //        _luisScheme.Engineer = value;
        //        NotifyOfPropertyChange(() => Engineer);
        //    }
        //}

        //public string Name
        //{
        //    get => _luisScheme.Name;
        //    set
        //    {
        //        _luisScheme.Name = value;
        //        NotifyOfPropertyChange(() => Name);
        //    }
        //}

        //public string RawMaterial
        //{
        //    get => _luisScheme.RawMaterial;
        //    set
        //    {
        //        _luisScheme.RawMaterial = value;
        //        NotifyOfPropertyChange(() => RawMaterial);
        //    }
        //}

        //public DevelopmentStatus Status
        //{
        //    get => _luisScheme.Status;
        //    set
        //    {
        //        _luisScheme.Status = value;
        //        NotifyOfPropertyChange(() => Status);
        //    }
        //}

        //public DateTime DevelopmentStartDate
        //{
        //    get => _luisScheme.DevelopmentStartDate;
        //    set
        //    {
        //        _luisScheme.DevelopmentStartDate = value;
        //        NotifyOfPropertyChange(() => DevelopmentStartDate);
        //    }
        //}

        //public DateTime ExpectedCompletionDate
        //{
        //    get => _luisScheme.ExpectedCompletionDate;
        //    set
        //    {
        //        _luisScheme.ExpectedCompletionDate = value;
        //        NotifyOfPropertyChange(() => ExpectedCompletionDate);
        //    }
        //}

        //public string SupplyManagementContact
        //{
        //    get => _luisScheme.SupplyManagementContact;
        //    set
        //    {
        //        _luisScheme.SupplyManagementContact = value;
        //        NotifyOfPropertyChange(() => SupplyManagementContact);
        //    }
        //}

        //public string Notes
        //{
        //    get => _luisScheme.Notes;
        //    set
        //    {
        //        _luisScheme.Notes = value;
        //        NotifyOfPropertyChange(() => Notes);
        //    }
        //}

        //public string ImageSource
        //{
        //    get => _luisScheme.ImageSource;
        //    set
        //    {
        //        _luisScheme.ImageSource = value;
        //        NotifyOfPropertyChange(() => ImageSource);
        //    }
        //}

        public void EditItem()
        {
            _eventAggregator.PublishOnUIThread(new EditItemMessage(this));
        }
    }
}
