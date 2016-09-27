using System;
using System.Collections.Generic;
using System.Linq;

using Xamarin.Forms;

namespace BahrainRed
{
	public partial class TimeTablePage : ContentPage
	{
		//public List<AllRoutesTimes> AllRoutes { get; set; }
		public List<Stop> stops { get; set; }
		public List<List<string>> SatThuGoTimes { get; set; }
		public List<List<string>> SatThuReturnTimes { get; set; }
		public List<List<string>> FridayGoTimes { get; set; }
		public List<List<string>> FridayReturnTimes { get; set; }

		public TimeTablePage()
		{
			this.InitializeComponent();
			//AllRoutes = new List<AllRoutesTimes>();
			SatThuGoTimes = new List<List<string>>();
			SatThuReturnTimes = new List<List<string>>();
			FridayGoTimes = new List<List<string>>();
			FridayReturnTimes = new List<List<string>>();

			var route = TripsManager.GetSavedRoutes().First();
			stops = route.stops;
			foreach (var stop in stops)
			{
				SatThuGoTimes.Add(stop.SatGoTimetable);
				SatThuReturnTimes.Add(stop.SatReturnTimetable);
				FridayGoTimes.Add(stop.SunToThuGoTimetable);
				FridayReturnTimes.Add(stop.SunToThuReturnTimetable);
			}

			var goingRoute = stops.Select(p => p.city).Distinct().ToArray();
			GoRouteStartFinishLabel.Text = string.Format("{0} - {1}", goingRoute.First(), goingRoute.Last());
			GoRouteAreaLabel.Text = String.Format("via {0}", string.Join(" - ", goingRoute.Except(new string[] { goingRoute.First(), goingRoute.Last() })));

			var returningRoute = goingRoute.Reverse();
			//ReturnRouteStartFinishLabel.Text = string.Format("{0} - {1}", returningRoute.First(), returningRoute.Last());
			//ReturnRouteAreaLabel.Text = String.Format("via {0}", string.Join(" - ", returningRoute.Except(new string[] { returningRoute.First(), returningRoute.Last() })));

			SatThuGoTimes = SwapRowsAndColumns(SatThuGoTimes);
			SatThuReturnTimes = SwapRowsAndColumns(SatThuReturnTimes);
			FridayReturnTimes = SwapRowsAndColumns(FridayReturnTimes);
			FridayGoTimes = SwapRowsAndColumns(FridayGoTimes);

			StopsListView.ItemsSource = stops;
			GoTimesListView.ItemsSource = SatThuGoTimes;
			//ReturnTimesListView.ItemsSource = SatThuReturnTimes;

			//ReturnStopsList.ItemsSource = stops.Reverse<Stop>();
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

