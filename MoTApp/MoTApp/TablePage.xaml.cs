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
    public sealed partial class TablePage : Page
    {
        //public List<AllRoutesTimes> AllRoutes { get; set; }
        public List<Stop> stops { get; set; }
        public List<List<string>> SatThuGoTimes { get; set; }
        public List<List<string>> SatThuReturnTimes { get; set; }
        public List<List<string>> FridayGoTimes { get; set; }
        public List<List<string>> FridayReturnTimes { get; set; }

        public TablePage()
        {
            this.InitializeComponent();
            //AllRoutes = new List<AllRoutesTimes>();
            SatThuGoTimes = new List<List<string>>();
            SatThuReturnTimes = new List<List<string>>();
            FridayGoTimes = new List<List<string>>();
            FridayReturnTimes = new List<List<string>>();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if(e.Parameter == null){
                var routes = TripsManager.GetSavedRoutes();
                foreach (var route in routes)
                {
                    //AllRoutes.Add(new AllRoutesTimes(route.stops));
                }
            }
            if (e.Parameter is Route)
            {
                var route = e.Parameter as Route;
                stops = route.stops;
                foreach (var stop in stops)
                {
                    SatThuGoTimes.Add(stop.SatGoTimetable);
                    SatThuReturnTimes.Add(stop.SatReturnTimetable);
                    FridayGoTimes.Add(stop.SunToThuGoTimetable);
                    FridayReturnTimes.Add(stop.SunToThuReturnTimetable);
                }

                var goingRoute = stops.Select(p => p.city).Distinct().ToArray();
                GoRouteStartFinishTextBlock.Text = string.Format("{0} - {1}", goingRoute.First(), goingRoute.Last());
                GoRouteAreaTextBlock.Text = String.Format("via {0}", string.Join(" - ", goingRoute.Except(new string[] { goingRoute.First(), goingRoute.Last()})));

                var returningRoute = goingRoute.Reverse();
                ReturnRouteStartFinishTextBlock.Text = string.Format("{0} - {1}", returningRoute.First(), returningRoute.Last());
                ReturnRouteAreaTextBlock.Text = String.Format("via {0}", string.Join(" - ", returningRoute.Except(new string[] { returningRoute.First(), returningRoute.Last() })));

                SatThuGoTimes = SwapRowsAndColumns(SatThuGoTimes);
                SatThuReturnTimes = SwapRowsAndColumns(SatThuReturnTimes);
                FridayReturnTimes = SwapRowsAndColumns(FridayReturnTimes);
                FridayGoTimes = SwapRowsAndColumns(FridayGoTimes);

                //StopsListView.ItemsSource = stops;
                GoTimesListView.ItemsSource = SatThuGoTimes;
                ReturnTimesListView.ItemsSource = SatThuReturnTimes;

                ReturnStopsList.ItemsSource = stops.Reverse<Stop>();
            }
        }
        
        private List<List<string>> SwapRowsAndColumns(List<List<string>> times)
        {
            int rowCount = times.Count;
            int columnCount = times[0].Count;
            var transposed = new List<List<string>>(columnCount);
            for (int i = 0; i < columnCount; i++)
            {
                List<string> newRow = new List<string>();
                foreach (List<string> value in times)
                {
                    newRow.Add(value[i]);
                }
                newRow.Sort();
                transposed.Add(newRow);
            }
            return transposed;
        }

        private void SatThuBtn_Tapped(object sender, TappedRoutedEventArgs e)
        {
            GoTimesListView.ItemsSource = SatThuGoTimes;
            ReturnTimesListView.ItemsSource = SatThuReturnTimes;
        }

        private void FriBtn_Tapped(object sender, TappedRoutedEventArgs e)
        {
            GoTimesListView.ItemsSource = FridayGoTimes;
            ReturnTimesListView.ItemsSource = FridayReturnTimes;
        }

        private class AllRoutesTimes
        {
            public List<Stop> stops { get; private set; }
            public List<List<string>> SatThuGoTimes { get; private set; }
            public List<List<string>> SatThuReturnTimes { get; private set; }
            public List<List<string>> FridayGoTimes { get; private set; }
            public List<List<string>> FridayReturnTimes { get; private set; }

            public AllRoutesTimes(List<Stop> stops)
            {
                this.stops = stops;
                SatThuGoTimes = new List<List<string>>();
                SatThuReturnTimes = new List<List<string>>();
                FridayGoTimes = new List<List<string>>();
                FridayReturnTimes = new List<List<string>>();
                foreach (var stop in stops)
                {
                    SatThuGoTimes.Add(stop.SatGoTimetable);
                    SatThuReturnTimes.Add(stop.SatReturnTimetable);
                    FridayGoTimes.Add(stop.SunToThuGoTimetable);
                    FridayReturnTimes.Add(stop.SunToThuReturnTimetable);
                }
                SatThuGoTimes = SwapRowsAndColumns(SatThuGoTimes);
                SatThuReturnTimes = SwapRowsAndColumns(SatThuReturnTimes);
                FridayReturnTimes = SwapRowsAndColumns(FridayReturnTimes);
                FridayGoTimes = SwapRowsAndColumns(FridayGoTimes);
            }

            private List<List<string>> SwapRowsAndColumns(List<List<string>> times)
            {
                int rowCount = times.Count;
                int columnCount = times[0].Count;
                var transposed = new List<List<string>>(columnCount);
                for (int i = 0; i < columnCount; i++)
                {
                    List<string> newRow = new List<string>();
                    foreach (List<string> value in times)
                    {
                        newRow.Add(value[i]);
                    }
                    newRow.Sort();
                    transposed.Add(newRow);
                }
                return transposed;
            }
        }
    }
}
