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
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;
using WinRTXamlToolkit.Controls;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace MoTApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MapPage : Page
    {
        public MapPage()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if (e.Parameter == null)
            {
                RouteMapImage.Source = new BitmapImage(new Uri(base.BaseUri, "Assets/fullMap.png"));
            }
            else if (e.Parameter is Route)
            {
                var route = e.Parameter as Route;
                RouteMapImage.Source = new BitmapImage(new Uri(base.BaseUri, route.mapImage));
            }
        }

        private void ZoomInBtn_Click(object sender, RoutedEventArgs e)
        {
            if (RouteMapImage.Height < RouteMapImage.MaxHeight)
            {
                RouteMapImage.Height += 100;
                if (!ZoomOutBtn.IsEnabled)
                {
                    ZoomOutIcon.Source = new BitmapImage(new Uri(base.BaseUri, "Assets/icon_ZoomOutBlack.png"));
                    ZoomOutBtn.IsEnabled = true;
                }
            }
            if (RouteMapImage.Height == RouteMapImage.MaxHeight)
            {
                ZoomInIcon.Source = new BitmapImage(new Uri(base.BaseUri, "Assets/icon_ZoomInGray.png"));
                ZoomInBtn.IsEnabled = false;
            }
        }

        private void ZoomOutBtn_Click(object sender, RoutedEventArgs e)
        {
            if (RouteMapImage.Height > RouteMapImage.MinHeight)
            {
                RouteMapImage.Height -= 100;
                if (!ZoomInBtn.IsEnabled)
                {
                    ZoomInIcon.Source = new BitmapImage(new Uri(base.BaseUri, "Assets/icon_ZoomInBlack.png"));
                    ZoomInBtn.IsEnabled = true;
                }            
            }
            if (RouteMapImage.Height == RouteMapImage.MinHeight)
            {
                ZoomOutIcon.Source = new BitmapImage(new Uri(base.BaseUri, "Assets/icon_ZoomOutGray.png"));
                ZoomOutBtn.IsEnabled = false;
            }
        }
    }
}
