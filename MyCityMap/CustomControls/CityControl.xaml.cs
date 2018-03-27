using System;
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

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace MyCityMap.CustomControls
{
    public sealed partial class CityControl : UserControl
    {
        public string ImageUrl
        {
            get { return (string)GetValue(ImageUrlProperty); }
            set { SetValue(ImageUrlProperty, value); }
        }
        public static readonly DependencyProperty ImageUrlProperty =
            DependencyProperty.Register("ImageUrl", typeof(string), typeof(CityControl), null);
        public string TitleImage
        {
            get { return (string)GetValue(TitleImageProperty); }
            set { SetValue(TitleImageProperty, value); }
        }
        public static readonly DependencyProperty TitleImageProperty =
            DependencyProperty.Register("TitleImage", typeof(string), typeof(CityControl), null);
        public CityControl()
         {
             this.InitializeComponent();
         }
       
    }
}
