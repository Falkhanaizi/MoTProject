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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace MoTApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class BusTimeTablePage : Page
    {
        public List<Route> routes { get; set; }

        public BusTimeTablePage()
        {
            this.InitializeComponent();
            routes = TripsManager.GetSavedRoutes();
            MyFrame.Navigate(typeof(TablePage), routes.First());
        }

        private void RoutesListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var route = (Route)RoutesListBox.SelectedItem;
            MyFrame.Navigate(typeof(TablePage), route);
        }

        /*
        private void Grid_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (!RoutesSplitView.IsPaneOpen)
            {
                RoutesSplitView.IsPaneOpen = true;
            }
            else
            {
                RoutesSplitView.IsPaneOpen = false;
            }
        }

        private void TripsList_ItemClick(object sender, ItemClickEventArgs e)
        {
            var route = (Route)e.ClickedItem;
            MyFrame.Navigate(typeof(TablePage), route);
        }
       */
    }
}
