using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro;
using MyCityMap.Services;
using MyCityMap.Models;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using MyCityMap.Views;
using System.Collections.ObjectModel;

namespace MyCityMap.ViewModels
{
    public class CitiesViewModel:ViewModelBase
    {
        private INavigationService _pageNavigationService;

        private const string NoInternetLabel = "No internet conection";
        private const string NoDataLabel = "No Data";

        private CityService _cityService;
        private NetworkService _networkService;

        public  CitiesViewModel(INavigationService pageNavigationService) : base(pageNavigationService)
        {
            _pageNavigationService = pageNavigationService;
            _cityService = new CityService();
            _networkService = new NetworkService();
        }

        public IEnumerable<City> Cities { get; set; }
        public bool IsActiveLoadingProgressRing { get; set; }
        //public bool 
        private async void Page_Loaded(/*object sender, RoutedEventArgs e*/)
        {
            await InitializeAsync();
        }

        private async Task InitializeAsync()
        {
            IsActiveLoadingProgressRing = true;
            var cities = await new CityService().LoadCityAsync();
            IsActiveLoadingProgressRing = false;
            //CitiesMapBtn.Visibility = Visibility.Visible;
            if (cities != null) Cities = cities;
                    
           // else ShowNoData();
        }
        public void ShowNoData()
        {
            //NoDataText.Text = _networkService.HasInternet() ? NoInternetLabel : NoDataLabel;
            //NoDataText.Visibility = Visibility.Visible;
        }

        public void ListCities_ItemClick(/*object sender, ItemClickEventArgs e*/)
        {
            //Frame.Navigate(typeof(CityView), e.ClickedItem);
           // NavigateTo<>
        }

        public void CitiesMap_Click()
        {
            // Frame.Navigate(typeof(CitiesMapView), Cit);
            //NavigateTo<>
        }
        protected override async void OnViewLoaded(object view)
        {
            await InitializeAsync();
            base.OnViewLoaded(view);
        }
      

    }
}
