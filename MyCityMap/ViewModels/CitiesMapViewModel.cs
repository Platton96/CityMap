using MyCityMap.Common;
using MyCityMap.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Devices.Geolocation;
using Windows.Storage.Streams;
using Windows.UI.Xaml.Controls.Maps;

namespace MyCityMap.ViewModels
{
    public class CitiesMapViewModel : BaseViewModel
    {
        private INavigationManager _pageNavigationManager;
        public CitiesMapViewModel(INavigationManager pageNavigationManager)
        {
            _pageNavigationManager = pageNavigationManager;
        }
        private IEnumerable<City> _cities;
        public IEnumerable<City> Cities
        {
            get { return _cities; }
            set
            {
                _cities = value;
                NotifyOfPropertyChange(nameof(Cities));
            }
        }
        

        private MapControl _mapCities;
        public MapControl MapCities
        {
            get { return _mapCities; }
            set
            {
                _mapCities = value;
                NotifyOfPropertyChange(nameof(MapCities));
            }
        }

        public IEnumerable<City> Parameter { get; set; }
        protected override void OnActivate()
        {
            base.OnActivate();
            Cities = Parameter;
            foreach (var city in _cities)
            {
                AddIconOnMap(city);
            }
        }
        private void AddIconOnMap(City city)
        {

            var location = new BasicGeoposition
            {
                Latitude = city.Latitude,
                Longitude = city.Longitude
            };

            var geoPoint = new Geopoint(location);

            var mapIcon = new MapIcon
            {
                Location = geoPoint,
                Title = city.Name,
                Image = RandomAccessStreamReference.CreateFromUri(new Uri("ms-appx:///Assets/MapIcon.png"))
            };
            var a = MapCities;

            if (mapIcon != null)
            {
                MapCities.MapElements.Remove(mapIcon);
            }

            MapCities.MapElements.Add(mapIcon);
            MapCities.Center = geoPoint;
        }
    }
}