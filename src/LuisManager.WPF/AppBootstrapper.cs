using System;
using System.Threading;
using Autofac;
using Caliburn.Micro;
using LuisManager.Common.Contracts;
using LuisManager.Common.Contracts.Helpers;
using LuisManager.WPF.Helpers;
using LuisManager.WPF.ViewModels;

namespace LuisManager.WPF
{
    public class AppBootstrapper : BootstrapperBase
    {
        IContainer _container;

        public AppBootstrapper()
        {
            Initialize();
        }

        protected override void Configure()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<EventAggregator>().As<IEventAggregator>().SingleInstance();
            builder.RegisterType<WindowManager>().As<IWindowManager>().SingleInstance();

            builder.RegisterType<ShellViewModel>().SingleInstance();
            builder.RegisterType<MainViewModel>().SingleInstance();
            builder.RegisterType<EditItemViewModel>().SingleInstance();
            builder.RegisterType<AboutViewModel>().SingleInstance();
            builder.RegisterType<KanbanViewModel>().SingleInstance();
            builder.RegisterType<ListProductsViewModel>().SingleInstance();

            builder.RegisterType<JsonDataProvider.JsonDataProvider>().As<IDataProvider>().SingleInstance();
            builder.RegisterType<ConfigurationService.ConfigurationService>().As<IConfigurationService>().SingleInstance();

            builder.RegisterType<FileHelper>().As<IFileHelper>().SingleInstance();
            builder.RegisterType<JsonHelper>().As<IJsonHelper>().SingleInstance();

            _container = builder.Build();
        }

        protected override object GetInstance(Type service, string key)
        {
            var instance = _container.Resolve(service);
            if (instance != null)
            {
                return instance;
            }
            throw new InvalidOperationException("Could not locate any instances.");
        }

        protected override void OnStartup(object sender, System.Windows.StartupEventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-US");
            DisplayRootViewFor<ShellViewModel>();
        }
    }
}