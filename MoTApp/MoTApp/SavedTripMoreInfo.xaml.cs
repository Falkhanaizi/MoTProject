using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Devices.Geolocation;
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
    public sealed partial class SavedTripMoreInfo : Page
    {
        public List<string> expandedStopsInfo { get; set; }
        public List<string> times { get; set; }
        public Trip trip { get; set; }
        public DateTime date { get; set; }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if (e.Parameter is Trip)
            {
                trip = e.Parameter as Trip;
                expandedStopsInfo = trip.stops.Select(s => s.city + ", " + s.name + " " + times[0]).ToList<string>();
            }
        }

        public SavedTripMoreInfo()
        {
            this.InitializeComponent();
            date = DateTime.Now;
            times = new List<string>() { "10:00", "11:00", "12:00", "13:00", "14:00", "15:00" };
        }

        private void EditBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void QuitBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ReminderBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void RouteMap_Loaded(object sender, RoutedEventArgs e)
        {
            RouteMap.Center =
              new Geopoint(new BasicGeoposition()
              {
                  //Geopoint for Seattle 
                  Latitude = 47.604,
                  Longitude = -122.329
              });
            RouteMap.ZoomLevel = 12;
        }
    }
}
