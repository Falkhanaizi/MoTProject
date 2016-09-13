using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
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
        }

        private void RoutesListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var route = (Route)RoutesListBox.SelectedItem;
            MyFrame.Navigate(typeof(TablePage), route);
            RoutesListBox.Visibility = Visibility.Collapsed;
            RoutesGridView.Visibility = Visibility.Collapsed;
            idText.Text = route.id;
            RouteIdBtn.Background = route.color;
        }

        private void RoutesGridView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var route = (Route)RoutesGridView.SelectedItem;
            MyFrame.Navigate(typeof(TablePage), route);
            RoutesGridView.Visibility = Visibility.Collapsed;
            idText.Text = route.id;
            RouteIdBtn.Background = route.color;
        }


        private void RouteIdBtn_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (RoutesListBox.Visibility == Visibility.Visible)
            {
                RoutesListBox.Visibility = Visibility.Collapsed;
            }
            else
            {
                RoutesListBox.Visibility = Visibility.Visible;
            }
        }

        private void BackBtn_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Frame.GoBack();
        }
    }
}
