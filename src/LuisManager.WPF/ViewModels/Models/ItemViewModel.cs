using System;
using Caliburn.Micro;
using LuisManager.Domain;
using LuisManager.Domain.Enums;
using LuisManager.WPF.Messages;

namespace LuisManager.WPF.ViewModels.Models
{
    public class ItemViewModel : PropertyChangedBase
    {
        private readonly Product _product;
        private readonly IEventAggregator _eventAggregator;

        public ItemViewModel(IEventAggregator eventAggregator)
        {
            _product = new Product();
            _eventAggregator = eventAggregator;
        }

        public ItemViewModel(Product product, IEventAggregator eventAggregator)
        {
            _product = product;
            _eventAggregator = eventAggregator;
        }

        public Product Product
        {
            get => _product;
        }

        public string Id
        {
            get => _product.Id;
            set
            {
                _product.Id = value;
                NotifyOfPropertyChange(() => Id);   
            }
        }

        public string Engineer
        {
            get => _product.Engineer;
            set
            {
                _product.Engineer = value;
                NotifyOfPropertyChange(() => Engineer);
            }
        }

        public string Name
        {
            get => _product.Name;
            set
            {
                _product.Name = value;
                NotifyOfPropertyChange(() => Name);
            }
        }

        public string RawMaterial
        {
            get => _product.RawMaterial;
            set
            {
                _product.RawMaterial = value;
                NotifyOfPropertyChange(() => RawMaterial);
            }
        }

        public DevelopmentStatus Status
        {
            get => _product.Status;
            set
            {
                _product.Status = value;
                NotifyOfPropertyChange(() => Status);
            }
        }

        public DateTime DevelopmentStartDate
        {
            get => _product.DevelopmentStartDate;
            set
            {
                _product.DevelopmentStartDate = value;
                NotifyOfPropertyChange(() => DevelopmentStartDate);
            }
        }

        public DateTime ExpectedCompletionDate
        {
            get => _product.ExpectedCompletionDate;
            set
            {
                _product.ExpectedCompletionDate = value;
                NotifyOfPropertyChange(() => ExpectedCompletionDate);
            }
        }

        public string SupplyManagementContact
        {
            get => _product.SupplyManagementContact;
            set
            {
                _product.SupplyManagementContact = value;
                NotifyOfPropertyChange(() => SupplyManagementContact);
            }
        }

        public string Notes
        {
            get => _product.Notes;
            set
            {
                _product.Notes = value;
                NotifyOfPropertyChange(() => Notes);
            }
        }

        public string ImageSource
        {
            get => _product.ImageSource;
            set
            {
                _product.ImageSource = value;
                NotifyOfPropertyChange(() => ImageSource);
            }
        }

        public void EditItem()
        {
            _eventAggregator.PublishOnUIThread(new EditItemMessage(this));
        }
    }
}
