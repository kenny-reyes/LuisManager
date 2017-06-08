using System;
using System.Collections.Generic;
using System.Windows;
using Caliburn.Micro;
using LuisManager.Common.Contracts;
using LuisManager.Domain;
using LuisManager.WPF.Messages;
using LuisManager.WPF.ViewModels.Models;
using Microsoft.Win32;

namespace LuisManager.WPF.ViewModels
{
    public class MainViewModel : Screen
    {
        private const int TabListView = 0;
        private const int TabGridView = 1;
        private readonly IDataProvider _dataProvider;
        private readonly IConfigurationService _configurationService;
        private readonly IEventAggregator _eventAggregator;
        private string _fileOpennedPath;
        private LuisScheme _data;

        public MainViewModel(IDataProvider dataProvider, IConfigurationService configurationService, IEventAggregator eventAggregator)
        {
            _dataProvider = dataProvider;
            _configurationService = configurationService;
            _eventAggregator = eventAggregator;
        }
        
        private int _selectedIndexTab;

        public int SelectedIndexTab
        {
            get => _selectedIndexTab;
            set
            {
                _selectedIndexTab = value;
                NotifyOfPropertyChange(() => SelectedIndexTab);
            }
        }

        public List<Screen> ScreenList { get; set; }

        public LuisScheme Data
        {
            get => _data;
            set
            {
                if (Equals(value, _data)) return;
                _data = value;
                NotifyOfPropertyChange(() => Data);
            }
        }

        public void ShowListView()
        {
            if (SelectedIndexTab == TabListView) return;
            SelectedIndexTab --;
        }

        public void ShowGridView()
        {
            if (SelectedIndexTab == TabGridView) return;
            SelectedIndexTab ++;
        }

        public void NewItem()
        {
            var item = new ItemViewModel(_eventAggregator);
            _eventAggregator.PublishOnUIThread(new EditItemMessage(item));

        }

        public void Login()
        {
            _eventAggregator.PublishOnUIThread(new OpenLoginMessage());
        }

        public void About()
        {
            _eventAggregator.PublishOnUIThread(new OpenAboutMessage());
        }

        public void Exit()
        {
            Application.Current.Shutdown();
        }

        public void Save()
        {
            //var products = DevelopmentItems?.Select(item => item.LuisScheme);
            //_dataProvider.SetData(products);
        }

        public void OpenFile()
        {
            var openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "json|*.json";
            try
            {
                if (openFileDialog.ShowDialog() == true)
                {
                    _fileOpennedPath = openFileDialog.FileName;
                }
                if (string.IsNullOrWhiteSpace(_fileOpennedPath)) return;
                _configurationService.Configuration.JsonFilePath = _fileOpennedPath;
                _data = _dataProvider.GetData();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
