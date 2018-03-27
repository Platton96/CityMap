using System.Collections.Generic;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;
using MyCityMap.Models;
using Windows.Devices.Geolocation;
using Windows.UI.Xaml.Controls.Maps;
using System.Linq;
using System;
using Windows.UI.Xaml.Media.Imaging;
using Windows.Storage.Streams;
using MyCityMap.ViewModels;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace MyCityMap.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class CitiesMapView : Page
    {
        public CitiesMapViewModel ViewModel { get; set; }
        public CitiesMapView()
        {
            DataContextChanged += (s, e) => { ViewModel = DataContext as CitiesMapViewModel; };
            InitializeComponent();
        }


        //protected override void OnNavigatedTo(NavigationEventArgs e)
        //{
        //    _cities = e.Parameter as IEnumerable<City>;

        //    if(_cities!=null)
        //    {
        //        foreach (var city in _cities)
        //        {
        //            AddIconOnMap(city);
        //        }
        //    }
        //    base.OnNavigatedTo(e);
        //}
        
        //private void AddIconOnMap(City city)
        //{
            
        //    var location = new BasicGeoposition
        //    {
        //        Latitude = city.Latitude,
        //        Longitude = city.Longitude
        //    };

        //    var geoPoint = new Geopoint(location);

        //    var mapIcon = new MapIcon
        //    {
        //        Location = geoPoint,
        //        Title = city.Name,
        //        Image =RandomAccessStreamReference.CreateFromUri(new Uri("ms-appx:///Assets/MapIcon.png")) 
        //    };

        //    if (mapIcon != null)
        //    {
        //        MapControl.MapElements.Remove(mapIcon);
        //    }

        //    MapControl.MapElements.Add(mapIcon);
        //    MapControl.Center = geoPoint;
        //}
        //private void MapElement_Click(object sender, MapElementClickEventArgs e)
        //{

        //    var mapIconCity = e.MapElements.FirstOrDefault() as MapIcon;
        //    var city = _cities.Where(c =>c.Name == mapIconCity.Title).FirstOrDefault();
                               
        //    Frame.Navigate(typeof(CityView), city);
        //}

    }
}
