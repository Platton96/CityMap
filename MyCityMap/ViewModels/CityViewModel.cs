using MyCityMap.Services;
using System;
using Windows.UI.Xaml.Media.Imaging;
using Caliburn.Micro;
using MyCityMap.Models;
using MyCityMap.Common;

namespace MyCityMap.ViewModels
{
    public class CityViewModel : BaseViewModel
    {
        private INavigationManager _pageNavigationManager;
        public CityViewModel (INavigationManager pageNavigationManager)
        {
            _pageNavigationManager = pageNavigationManager;
        }
        private City _city;
        public City City
        {
            get { return _city; }
            set
            {
                _city = value;
                NotifyOfPropertyChange(nameof(City));
            }
        }

        private BitmapImage _imageCity;
        public BitmapImage ImageCity
        {
            get { return _imageCity; }
            set
            {
                _imageCity = value;
                NotifyOfPropertyChange(nameof(ImageCity));
            }
        }

        public City Parameter { get; set; }


        protected override void OnActivate()
        {
            base.OnActivate();
            City = Parameter;
            ImageCity= new BitmapImage(new Uri(City.ImageUrl));
        }


    }
}

