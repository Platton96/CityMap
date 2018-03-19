using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using System.Threading.Tasks;
using MyCityMap.Services;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace MyCityMap.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class CitiesView : Page
    {
        private const string NoInternetLabel = "No internet conection";
        private const string NoDataLabel = "No Data";

        private CityService _cityService;
        private NetworkService _networkService;

        public CitiesView()
        {
            this.InitializeComponent();
      
        }
        private async void Page_Loaded(object sender, RoutedEventArgs e)
        {
            await InitializeAsync();
            _cityService = new CityService();
            _networkService = new NetworkService();

        }
        private async Task InitializeAsync()
        {
            LoadingProgressRing.IsActive = true;
            var cities = await new CityService().LoadCityAsync();
            LoadingProgressRing.IsActive = false;

            if (cities != null) GridView.ItemsSource = cities;
            else ShowNoData();
           


        }
        private void ShowNoData()
        {
            NoDataText.Text = _networkService.HasInternet() ? NoInternetLabel : NoDataLabel;
            NoDataText.Visibility = Visibility.Visible;
        }
        private void ListCities_ItemClick (object sender, ItemClickEventArgs e)
        {
            Frame.Navigate(typeof(CityView), e.ClickedItem);
        }
    }
}
