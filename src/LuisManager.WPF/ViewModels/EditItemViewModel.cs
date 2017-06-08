using System;
using System.IO;
using Caliburn.Micro;
using LuisManager.Domain.Enums;
using Microsoft.Win32;

namespace LuisManager.WPF.ViewModels
{
    public sealed class EditItemViewModel : Screen
    {
        private readonly string _imagesDirectory = AppDomain.CurrentDomain.BaseDirectory + "Assets\\";
        private Models.TreeItemViewModel _treeItem;
        private DevelopmentStatus _status;
        private string _rawMaterial;
        private string _name;
        private string _id;
        private string _engineer;
        private DateTime _developmentStartDate;
        private DateTime _expectedCompletionDate;
        private string _supplyManagementContact;
        private string _notes;
        private Uri _imageSource;
        private readonly IEventAggregator _eventAggregator;

        public EditItemViewModel(IEventAggregator eventAggregator)
        {
            _eventAggregator = eventAggregator;
            DisplayName = Localization.Resources.Title_Shell;
        }

        public Models.TreeItemViewModel TreeItem
        {
            get => _treeItem;
            set
            {
                _treeItem = value;
                //Engineer = _treeItem.Engineer;
                //Id = _treeItem.Id;
                //Name = _treeItem.Name;
                //RawMaterial = _treeItem.RawMaterial;
                //DevelopmentStartDate = _treeItem.DevelopmentStartDate;
                //ExpectedCompletionDate = _treeItem.ExpectedCompletionDate;
                //SupplyManagementContact = _treeItem.SupplyManagementContact;
                //Notes = _treeItem.Notes;
                //Status = _treeItem.Status;
                //ImageSource = new Uri(_imagesDirectory + TreeItem.ImageSource);
            }
        }

        public DateTime DevelopmentStartDate
        {
            get => _developmentStartDate;
            set
            {
                if (value.Equals(_developmentStartDate)) return;
                _developmentStartDate = value;
                NotifyOfPropertyChange(() => DevelopmentStartDate);
            }
        }

        public DateTime ExpectedCompletionDate
        {
            get => _expectedCompletionDate;
            set
            {
                if (value.Equals(_expectedCompletionDate)) return;
                _expectedCompletionDate = value;
                NotifyOfPropertyChange(() => ExpectedCompletionDate);
            }
        }

        public string SupplyManagementContact
        {
            get => _supplyManagementContact;
            set
            {
                if (value == _supplyManagementContact) return;
                _supplyManagementContact = value;
                NotifyOfPropertyChange(() => SupplyManagementContact);
            }
        }

        public string Notes
        {
            get => _notes;
            set
            {
                if (value == _notes) return;
                _notes = value;
                NotifyOfPropertyChange(() => Notes);
            }
        }

        public DevelopmentStatus Status
        {
            get => _status;
            set
            {
                if (value == _status) return;
                _status = value;
                NotifyOfPropertyChange(() => Status);
            }
        }

        public string RawMaterial
        {
            get => _rawMaterial;
            set
            {
                if (value == _rawMaterial) return;
                _rawMaterial = value;
                NotifyOfPropertyChange(() => RawMaterial);
            }
        }

        public string Name
        {
            get => _name;
            set
            {
                if (value == _name) return;
                _name = value;
                NotifyOfPropertyChange(() => Name);
            }
        }

        public string Id
        {
            get => _id;
            set
            {
                if (value == _id) return;
                _id = value;
                NotifyOfPropertyChange(() => Id);
            }
        }

        public string Engineer
        {
            get => _engineer;
            set
            {
                if (value == _engineer) return;
                _engineer = value;
                NotifyOfPropertyChange(() => Engineer);
            }
        }

        public Uri ImageSource
        {
            get => _imageSource;
            set
            {
                if (value == _imageSource) return;
                _imageSource = value;
                NotifyOfPropertyChange(() => ImageSource);
            }
        }

        public void UploadPhoto()
        {
            var openFileDialog = new OpenFileDialog {Filter = "Image Files(*.BMP;*.JPG;*.PNG;*.GIF)|*.BMP;*.JPG;*.GIF;*.PNG"};
            if (openFileDialog.ShowDialog() == true)
            {
                var storeFilePath = _imagesDirectory + Path.GetFileName(openFileDialog.FileName);
                if (!File.Exists(storeFilePath))
                {
                    File.Copy(openFileDialog.FileName, storeFilePath);
                }
                ImageSource = new Uri(storeFilePath);
            }
        }

        public void CloseEditWindow()
        {
            TryClose();
        }

        public void SaveAndCloseEditWindow()
        {
            //var previousStatus = _treeItem.Status;
            //_treeItem.Engineer = Engineer;
            //_treeItem.Id = Id;
            //_treeItem.Name = Name;
            //_treeItem.RawMaterial = RawMaterial;
            //_treeItem.DevelopmentStartDate = DevelopmentStartDate;
            //_treeItem.ExpectedCompletionDate = ExpectedCompletionDate;
            //_treeItem.SupplyManagementContact = SupplyManagementContact;
            //_treeItem.Notes = Notes;
            //_treeItem.Status = Status;
            //_treeItem.ImageSource = ImageSource.LocalPath.Replace(_imagesDirectory, string.Empty);
            //_eventAggregator.PublishOnUIThread(new UpdateLanesMessage(_treeItem, previousStatus));
            CloseEditWindow();
        }
    }
}
