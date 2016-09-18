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
        public List<Stop> stops { get; set; }
        public List<List<string>> SatGoTimes { get; set; }
        public List<List<string>> SatReturnTimes { get; set; }
        public List<List<string>> SunToThuGoTimes { get; set; }
        public List<List<string>> SunToThuReturnTimes { get; set; }

        public TablePage()
        {
            this.InitializeComponent();
            SatGoTimes = new List<List<string>>();
            SatReturnTimes = new List<List<string>>();
            SunToThuGoTimes = new List<List<string>>();
            SunToThuReturnTimes = new List<List<string>>();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if (e.Parameter is Route)
            {
                var route = e.Parameter as Route;
                stops = route.stops;
                foreach (var stop in stops)
                {
                    SatGoTimes.Add(stop.SatGoTimetable);
                    SatReturnTimes.Add(stop.SatReturnTimetable);
                    SunToThuGoTimes.Add(stop.SunToThuGoTimetable);
                    SunToThuReturnTimes.Add(stop.SunToThuReturnTimetable);
                }

                var goingRoute = stops.Select(p => p.city).Distinct().ToArray();
                GoRouteAreaTextBlock.Text = String.Format("(via {0})", string.Join(" - ", goingRoute));

                var returningRoute = goingRoute.Reverse();
                ReturnRouteAreaTextBlock.Text = String.Format("(via {0})", string.Join(" - ", returningRoute));

                SatGoTimes = SwapRowsAndColumns(SatGoTimes);
                SatReturnTimes = SwapRowsAndColumns(SatReturnTimes);
                SunToThuReturnTimes = SwapRowsAndColumns(SunToThuReturnTimes);
                SunToThuGoTimes = SwapRowsAndColumns(SunToThuGoTimes);

                //StopsListView.ItemsSource = stops;
                SatGoTimesListView.ItemsSource = SatGoTimes;
                SatReturnTimesListView.ItemsSource = SatReturnTimes;
                SunToThuGoTimesListView.ItemsSource = SunToThuGoTimes;
                SunToThuReturnTimesListView.ItemsSource = SunToThuReturnTimes;
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
        
        
    }
}
