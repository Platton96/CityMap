using MyCityMap.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCityMap.Common
{
    public interface INavigationManager
    {
        void NavigateToCityDetails(City city);
        void NavigateToCitiesMap(IEnumerable<City> cities);
        void SetBackButtonVisibility(bool value);
    }
}
