using Caliburn.Micro;
using MyCityMap.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyCityMap.Models;
using Windows.UI.Xaml;

namespace MyCityMap.ViewModels
{
    public class CitiesViewModel : BaseViewModel
    {
        private INavigationService _pageNavigationService;
        private const string NoInternetLabel = "No internet conection";
        private const string NoDataLabel = "No Data";

        private CityService _cityService;
        private NetworkService _networkService;

        public CitiesViewModel(INavigationService pageNavigationService) : base(pageNavigationService)
        {
            _pageNavigationService = pageNavigationService;
            _cityService = new CityService();
            _networkService = new NetworkService();
        }
        private IEnumerable<City> _cities;
        public IEnumerable<City> Cities
        {
            get { return _cities; }
            set
            {
                _cities = value;
                NotifyOfPropertyChange(() => Cities);
            }
         }

        private bool _isActiveLoadingProgressRing;
        public bool IsActiveLoadingProgressRing
        {
            get { return _isActiveLoadingProgressRing; }
            set
            {
                _isActiveLoadingProgressRing = value;
                NotifyOfPropertyChange(() => IsActiveLoadingProgressRing);
            }
        }

        private Visibility _visibilityOfCitiesMapButton;
        public Visibility VisibilityOfCitiesMapButton
        {
            get { return _visibilityOfCitiesMapButton; }
            set
            {
                _visibilityOfCitiesMapButton = value;
                NotifyOfPropertyChange(() => VisibilityOfCitiesMapButton);
            }
        }
        protected override async void OnViewLoaded(object view)
        {
            await InitializeAsync();
            base.OnViewLoaded(view);
        }

        private async Task InitializeAsync()
        {
            VisibilityOfCitiesMapButton = Visibility.Collapsed;
            IsActiveLoadingProgressRing = true;
            var cities = await new CityService().LoadCityAsync();
            IsActiveLoadingProgressRing = false;
            VisibilityOfCitiesMapButton= Visibility.Visible;
            if (cities != null) Cities = cities;
            else ShowNoData();
        }


    }
}
