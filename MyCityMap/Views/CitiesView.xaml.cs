using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using System.Threading.Tasks;
using MyCityMap.Services;
using MyCityMap.ViewModels;
using MyCityMap.Models;


// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace MyCityMap.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class CitiesView : Page
    {

        public CitiesViewModel ViewModel { get; set; }

        public CitiesView()
        {
            InitializeComponent();

            DataContextChanged += (s, e) => { ViewModel = DataContext as CitiesViewModel; };
            //_cityService = new CityService();
            //_networkService = new NetworkService();

        }

        private void OnCitiesListItemClick(object sender, ItemClickEventArgs e)
        {
            ViewModel.NavigateToCityDetails(e.ClickedItem as City);
        }

        //private async void Page_Loaded(object sender, RoutedEventArgs e)
        //{
        //    await InitializeAsync();
        //}

        //private async Task InitializeAsync()
        //{
        //    LoadingProgressRing.IsActive = true;
        //    var cities = await new CityService().LoadCityAsync();
        //    LoadingProgressRing.IsActive = false;
        //    CitiesMapBtn.Visibility = Visibility.Visible;
        //    if (cities != null) GridView.ItemsSource = cities;
        //    else ShowNoData();
        //}

        //private void ShowNoData()
        //{
        //    NoDataText.Text = _networkService.HasInternet() ? NoInternetLabel : NoDataLabel;
        //    NoDataText.Visibility = Visibility.Visible;
        //}

        //private void ListCities_ItemClick (object sender, ItemClickEventArgs e)
        //{
        //    Frame.Navigate(typeof(CityView), e.ClickedItem);
        //}

        //private void CitiesMap_Click(object sender, RoutedEventArgs e)
        //{
        //    Frame.Navigate(typeof(CitiesMapView), GridView.ItemsSource);
        //}
    }
}
