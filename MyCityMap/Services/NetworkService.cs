using Windows.Networking.Connectivity;

namespace MyCityMap.Services
{
    public class NetworkService
    {
        public bool HasInternet()
        {
            var conectionProfile = NetworkInformation.GetInternetConnectionProfile();
            return conectionProfile != null && 
                   conectionProfile.GetNetworkConnectivityLevel() == NetworkConnectivityLevel.InternetAccess;
        }
    }
}
