using Caliburn.Micro;
using MyCityMap.Models;
using MyCityMap.ViewModels;
using System.Collections.Generic;
using Windows.UI.Core;

namespace MyCityMap.Common
{
    public class NavigationManager : INavigationManager
    {
        private readonly INavigationService _navigationService;

        public NavigationManager(INavigationService navigationService)
        {
            _navigationService = navigationService;
            SystemNavigationManager.GetForCurrentView().BackRequested += OnBackRequested; ;
        }

        private void OnBackRequested(object sender, BackRequestedEventArgs e)
        {
            _navigationService.GoBack();
        }

        public void NavigateToCityDetails(City city)
        {
            _navigationService.NavigateToViewModel<CityViewModel>(city);
        }
        public void NavigateToCitiesMap(IEnumerable<City> cities)
        {
            _navigationService.NavigateToViewModel<CitiesMapViewModel>(cities);
        }
        public void SetBackButtonVisibility(bool value)
        {
            SystemNavigationManager.GetForCurrentView().AppViewBackButtonVisibility = value ? AppViewBackButtonVisibility.Visible : AppViewBackButtonVisibility.Collapsed;
        }
    }
}
