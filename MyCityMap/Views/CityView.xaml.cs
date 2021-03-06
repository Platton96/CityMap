﻿using System;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;
using MyCityMap.Models;
using Windows.UI.Xaml.Media.Imaging;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace MyCityMap.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class CityView : Page
    {
        public CityView()
        {
            InitializeComponent();
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if (e.Parameter is City city)
            {
                NavigationControl.NavigationTitle = city.Name;
                DescriptionCity.Text = city.Description;
                ImageCity.Source = new BitmapImage(new Uri(city.ImageUrl));
            }
            base.OnNavigatedTo(e);
        }
    }
}
