using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro;
using MyCityMap.Services;
using Windows.UI.Xaml;

namespace MyCityMap.ViewModels
{
    public class CitiesViewModel:ViewModelBase
    {
        private const string NoInternetLabel = "No internet conection";
        private const string NoDataLabel = "No Data";

        private CityService _cityService;
        private NetworkService _networkService;
        private INavigationService _pagenavigationService;


        public CitiesViewModel(INavigationService pageNavigationService): base(pageNavigationService)
        {
            _pagenavigationService = pageNavigationService;
            _cityService = new CityService();
            _networkService = new NetworkService();
        }
        private async void Page_Loaded(object sender, RoutedEventArgs e)
        {
           await InitializeAsync();
        }

        private async Task InitializeAsync()
        {
            //LoadingProgressRing.IsActive = true;
            var cities = await new CityService().LoadCityAsync();
           // LoadingProgressRing.IsActive = false;
           // CitiesMapBtn.Visibility = Visibility.Visible;
           // if (cities != null) GridView.ItemsSource = cities;
            //else ShowNoData();
        }
    }
}
