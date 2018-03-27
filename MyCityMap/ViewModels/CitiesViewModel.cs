using Caliburn.Micro;
using MyCityMap.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyCityMap.Models;
using Windows.UI.Xaml;
using MyCityMap.Common;

namespace MyCityMap.ViewModels
{
    public class CitiesViewModel : BaseViewModel
    {
        private const string NoInternetLabel = "No internet conection";
        private const string NoDataLabel = "No Data";

        private readonly INavigationManager _navigationManager;

        private CityService _cityService;
        private NetworkService _networkService;

        public CitiesViewModel(INavigationManager navigationManager)
        {
            _navigationManager = navigationManager;
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

        private Visibility _isCitiesMapButtonVisible;
        public Visibility IsCitiesMapButtonVisible
        {
            get { return _isCitiesMapButtonVisible; }
            set
            {
                _isCitiesMapButtonVisible = value;
                NotifyOfPropertyChange(() => IsCitiesMapButtonVisible);
            }
        }

        private string _noDataText;
        public string NoDataText
        {
            get { return _noDataText; }
            set
            {
                _noDataText = value;
                NotifyOfPropertyChange(() => NoDataText);
            }
        }

        private Visibility _visiblityOfNoDataText;
        public Visibility VisiblityOfNoDataText
        {
            get { return _visiblityOfNoDataText; }
            set
            {
                _visiblityOfNoDataText = value;
                NotifyOfPropertyChange(() => VisiblityOfNoDataText);
            }
        }
        protected override async void OnViewLoaded(object view)
        {
            await InitializeAsync();
            base.OnViewLoaded(view);
        }

        private async Task InitializeAsync()
        {
            VisiblityOfNoDataText = Visibility.Collapsed;
            IsCitiesMapButtonVisible = Visibility.Collapsed;
            IsActiveLoadingProgressRing = true;
            var cities = await new CityService().LoadCityAsync();
            IsActiveLoadingProgressRing = false;
            IsCitiesMapButtonVisible= Visibility.Visible;
            if (cities != null) Cities = cities;
            else ShowNoData();
        }

        private void ShowNoData()
        {
            NoDataText = _networkService.HasInternet() ? NoInternetLabel : NoDataLabel;
            VisiblityOfNoDataText = Visibility.Visible;
        }
        public void NavigateToCityDetails(City city)
        {
            _navigationManager.SetBackButtonVisibility(true);
            _navigationManager.NavigateToCityDetails(city);
        }


    }
}
