using System.Collections.Generic;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;
using MyCityMap.Models;
using Windows.Devices.Geolocation;
using Windows.UI.Xaml.Controls.Maps;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace MyCityMap.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class CitiesMapView : Page
    {
        public CitiesMapView()
        {
            InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            var cities = e.Parameter as IEnumerable<City>;
            if(cities!=null)
            {
                foreach (var city in cities)
                {
                    AddIconOnMap(city);
                }
            }
            base.OnNavigatedTo(e);
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
                Title = city.Name
            };

            if (mapIcon != null)
            {
                MapControl.MapElements.Remove(mapIcon);
            }

            MapControl.MapElements.Add(mapIcon);
            MapControl.Center = geoPoint;
        }

    }
}
