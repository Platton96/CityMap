﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using MyCityMap.Concrete;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace MyCityMap.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class CitiesView : Page
    {
        public CitiesView()
        {
            this.InitializeComponent();
            var citiesRepository = new CitiesRepository();
            ListCities.ItemsSource = citiesRepository.Cities;
           
        }
        private void ListCities_ItemClick (object sender, ItemClickEventArgs e)
        {
            Frame.Navigate(typeof(CityView), e.ClickedItem);
        }
    }
}