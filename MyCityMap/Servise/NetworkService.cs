using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Networking.Connectivity;

namespace MyCityMap.Servise
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
