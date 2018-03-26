using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro;
using MyCityMap.Services;
using MyCityMap.Models;
using Windows.UI.Xaml;

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
        public bool LoadingProgressRing { get; set; }

        private async void Page_Loaded(object sender, RoutedEventArgs e)
        {
            await InitializeAsync();
        }

        private async Task InitializeAsync()
        {
            LoadingProgressRing = true;
            var cities = await new CityService().LoadCityAsync();
            LoadingProgressRing = false;
            //CitiesMapBtn.Visibility = Visibility.Visible;
            if (cities != null) Cities = cities;
           // else ShowNoData();
        }

    }
}
