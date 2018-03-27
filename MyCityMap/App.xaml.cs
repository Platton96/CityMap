using System;
using Windows.ApplicationModel.Activation;
using Windows.UI.Xaml.Controls;
using MyCityMap.Views;
using Caliburn.Micro;
using MyCityMap.ViewModels;
using System.Collections.Generic;
using MyCityMap.Common;

namespace MyCityMap
{
    public sealed partial class App 
    {
        private WinRTContainer container;

        public App()
        {
            InitializeComponent();
            this.Suspending += OnSuspending;
        }

        protected override void Configure()
        {
            container = new WinRTContainer();

            container.RegisterWinRTServices();

            container.PerRequest<CitiesViewModel>();
            container.PerRequest<CityViewModel>();
            container.PerRequest<CitiesMapViewModel>();
            container.Singleton<INavigationManager, NavigationManager>();
        }

        protected override void PrepareViewFirst(Frame rootFrame)
        {
            container.RegisterNavigationService(rootFrame);
        }

        protected override void OnLaunched(LaunchActivatedEventArgs args)
        {
            if (args.PreviousExecutionState == ApplicationExecutionState.Running)
                return;

            DisplayRootView<CitiesView>();
        }

        protected override object GetInstance(Type service, string key)
        {
            return container.GetInstance(service, key);
        }

        protected override IEnumerable<object> GetAllInstances(Type service)
        {
            return container.GetAllInstances(service);
        }

        protected override void BuildUp(object instance)
        {
            container.BuildUp(instance);
        }
    }
}